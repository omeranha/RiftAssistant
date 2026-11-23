using System;
using System.IO;
using System.Linq;
using RiftAssistant.Controllers;
using Xunit;

namespace RiftAssistant.Tests;

public class PublicApiTests
{
	[Fact]
	public void PublicTypesMatchTheApprovedList()
	{
		string[] actual = [.. typeof(Controller).Assembly.GetExportedTypes().Select(type => type.FullName).OrderBy(name => name, StringComparer.Ordinal)];
		string path = FindApprovedList();

		if (Environment.GetEnvironmentVariable("UPDATE_PUBLIC_API") == "1") {
			File.WriteAllLines(path, actual);
			return;
		}

		string[] approved = File.ReadAllLines(path);
		var added = actual.Except(approved).ToList();
		var removed = approved.Except(actual).ToList();
		Assert.True(added.Count == 0 && removed.Count == 0, $"Public API changed. Added: [{string.Join(", ", added)}] Removed: [{string.Join(", ", removed)}]. Set UPDATE_PUBLIC_API=1 and run the test to approve the change.");
	}

	private static string FindApprovedList()
	{
		for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory != null; directory = directory.Parent) {
			string candidate = Path.Combine(directory.FullName, "tests", "RiftAssistant.Tests", "PublicApi.txt");
			if (Directory.Exists(Path.GetDirectoryName(candidate))) return candidate;
		}

		throw new DirectoryNotFoundException("tests/RiftAssistant.Tests not found");
	}
}