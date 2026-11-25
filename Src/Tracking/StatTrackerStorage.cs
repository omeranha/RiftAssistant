using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace RiftAssistant.Tracking;

internal sealed record StatTrackerSnapshot
{
	public int Version { get; set; } = StatTrackerStorage.CurrentVersion;
	public uint AreaSno { get; set; }
	public long ElapsedMilliseconds { get; set; }
	public long TownMilliseconds { get; set; }
	public double Experience { get; set; }
	public long Gold { get; set; }
	public long MonsterKill { get; set; }
	public long EliteKill { get; set; }
	public long DropAll { get; set; }
	public long DropWhite { get; set; }
	public long DropMagic { get; set; }
	public long DropRare { get; set; }
	public long DropLegendary { get; set; }
	public long DropAncient { get; set; }
	public long DropPrimalAncient { get; set; }
	public long DropGold { get; set; }
	public long DropBloodShard { get; set; }
	public long Death { get; set; }
	public double DamageDealtAll { get; set; }
	public double DamageDealtCrit { get; set; }
	public double DamageTaken { get; set; }
	public double Healing { get; set; }
	public double WalkYards { get; set; }

	public bool IsPlausible()
	{
		long[] counters = [ElapsedMilliseconds, TownMilliseconds, Gold, MonsterKill, EliteKill, DropAll, DropWhite, DropMagic, DropRare, DropLegendary, DropAncient, DropPrimalAncient, DropGold, DropBloodShard, Death];
		double[] amounts = [Experience, DamageDealtAll, DamageDealtCrit, DamageTaken, Healing, WalkYards];
		return Array.TrueForAll(counters, value => value >= 0) && Array.TrueForAll(amounts, value => double.IsFinite(value) && value >= 0.0);
	}
}

internal static class StatTrackerStorage
{
	public const int CurrentVersion = 1;

	private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };
	private static readonly Lock Gate = new();
	private static readonly Lock DrainLock = new();
	private static readonly Dictionary<string, StatTrackerSnapshot> Pending = [];
	private static readonly Dictionary<string, StatTrackerSnapshot> LastWritten = [];
	private static readonly AutoResetEvent WorkAvailable = new(false);
	private static Thread writerThread;

	public static string PathFor(string id, string key)
	{
		return Path.Combine(Program.StatTrackerFolder, $"{SanitizeFileName(id)}_{SanitizeFileName(key)}.json");
	}

	// A snapshot that is still waiting for the writer thread is newer than the file, so it is returned first.
	public static StatTrackerSnapshot Read(string path)
	{
		lock (Gate) {
			if (Pending.TryGetValue(path, out var pending)) return pending;
		}

		try {
			if (!File.Exists(path)) return null;

			var snapshot = JsonSerializer.Deserialize<StatTrackerSnapshot>(File.ReadAllText(path, Encoding.UTF8), JsonOptions);
			if (snapshot == null || snapshot.IsPlausible()) return snapshot;

			Logger.LogException($"[stat tracker] {Path.GetFileName(path)} has impossible values and was ignored");
			KeepDamagedCopy(path);
			return null;
		} catch (JsonException ex) {
			Logger.LogException($"[stat tracker] {Path.GetFileName(path)} is damaged and was ignored: {ex.Message}");
			KeepDamagedCopy(path);
			return null;
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			Logger.LogException($"[stat tracker] could not read {Path.GetFileName(path)}: {ex.Message}");
			return null;
		}
	}

	public static void Write(string path, StatTrackerSnapshot snapshot)
	{
		lock (Gate) {
			bool unchanged = Pending.TryGetValue(path, out var queued) ? queued == snapshot : LastWritten.TryGetValue(path, out var last) && last == snapshot;
			if (unchanged) return;

			Pending[path] = snapshot;
		}

		EnsureWriterThread();
		WorkAvailable.Set();
	}

	public static void Flush()
	{
		WritePending();
	}

	private static void EnsureWriterThread()
	{
		if (writerThread != null) return;

		lock (Gate) {
			if (writerThread != null) return;

			writerThread = new Thread(() => {
				while (true) {
					WorkAvailable.WaitOne();
					WritePending();
				}
			}) {
				IsBackground = true,
				Name = "StatTrackerWriter"
			};
			writerThread.Start();
		}
	}

	private static void WritePending()
	{
		lock (DrainLock) {
			while (true) {
				string path = null;
				StatTrackerSnapshot snapshot = null;
				lock (Gate) {
					foreach (var pair in Pending) {
						(path, snapshot) = (pair.Key, pair.Value);
						break;
					}
				}

				if (path == null) return;

				bool written = TryWriteFile(path, snapshot);
				lock (Gate) {
					if (written) LastWritten[path] = snapshot;
					if (Pending.TryGetValue(path, out var current) && ReferenceEquals(current, snapshot)) Pending.Remove(path);
				}
			}
		}
	}

	private static bool TryWriteFile(string path, StatTrackerSnapshot snapshot)
	{
		try {
			Directory.CreateDirectory(Path.GetDirectoryName(path));
			string temporaryPath = path + ".tmp";
			File.WriteAllText(temporaryPath, JsonSerializer.Serialize(snapshot, JsonOptions), Encoding.UTF8);
			File.Move(temporaryPath, path, true);
			return true;
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
			Logger.LogException($"[stat tracker] could not save {Path.GetFileName(path)}: {ex.Message}");
			return false;
		}
	}

	private static string SanitizeFileName(string name)
	{
		var builder = new StringBuilder(name.Length);
		foreach (char c in name) {
			builder.Append(Array.IndexOf(Path.GetInvalidFileNameChars(), c) >= 0 ? '_' : c);
		}

		return builder.ToString();
	}

	private static void KeepDamagedCopy(string path)
	{
		try {
			File.Copy(path, path + ".damaged", true);
		} catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) {
		}
	}
}
