using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace RiftAssistant.Controllers;

public class SoundController
{
	private SpeechSynthesizer synthesizer;
	private int appliedVolume = -1;
	private SoundSettings gameSettings;

	public bool IsSpeakEnabled { get; set; } = true;

	public Stopwatch LastSpeak { get; } = new();

	public bool IsIngameSoundEnabled => !gameSettings.Muted;

	public int IngameMasterVolume => (int)Math.Round(gameSettings.MasterVolume * 100f);

	public int IngameEffectsVolume => (int)Math.Round(gameSettings.EffectsVolume * 100f);

	public VolumeMode VolumeMode { get; set; } = VolumeMode.AutoMasterAndEffects;

	public double VolumeMultiplier { get; set; } = 1.0;

	public int ConstantVolume { get; set; } = 100;

	public void Speak(string text)
	{
		if (!IsSpeakEnabled || string.IsNullOrEmpty(text)) return;

		LastSpeak.Restart();
		try {
			if (synthesizer == null) {
				synthesizer = new SpeechSynthesizer { Rate = 1 };
				synthesizer.SetOutputToDefaultAudioDevice();
			}

			synthesizer.SpeakAsync(text);
		} catch (Exception ex) {
			Logger.LogException(ex.ToString());
		}
	}

	public void StopSpeak()
	{
		synthesizer?.SpeakAsyncCancelAll();
	}

	public SoundPlayer LoadSoundPlayer(string fileName)
	{
		string path = Path.Combine(Program.AppDir, "sounds", fileName);
		if (!File.Exists(path)) return null;

		try {
			var player = new SoundPlayer(path);
			player.Load();
			return player;
		} catch (Exception ex) {
			Logger.LogException(ex.ToString());
			return null;
		}
	}

	internal void Update(SoundSettings settings)
	{
		gameSettings = settings;

		int volume = VolumeMode switch {
			VolumeMode.AutoMaster => (int)Math.Round(settings.MasterVolume * 100f * VolumeMultiplier),
			VolumeMode.AutoMasterAndEffects => (int)Math.Round(settings.MasterVolume * settings.EffectsVolume * 100f * VolumeMultiplier),
			_ => ConstantVolume
		};

		if (volume == appliedVolume) return;

		int level = Math.Clamp(65535 * volume / 100, 0, 65535);
		waveOutSetVolume(IntPtr.Zero, (uint)(level | (level << 16)));
		appliedVolume = volume;
	}

	[DllImport("winmm.dll")]
	private static extern int waveOutSetVolume(IntPtr deviceHandle, uint volume);
}