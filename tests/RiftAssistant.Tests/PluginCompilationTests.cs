using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Xunit;

namespace RiftAssistant.Tests;

public class PluginCompilationTests
{
	private const string GlobalUsings = "global using RiftAssistant; global using RiftAssistant.Collectors; global using RiftAssistant.Controllers; global using RiftAssistant.Engine; global using RiftAssistant.Input; global using RiftAssistant.Memory; global using RiftAssistant.Model; global using RiftAssistant.Modules; global using RiftAssistant.PluginHost; global using RiftAssistant.Rendering; global using RiftAssistant.Sno; global using RiftAssistant.Tracking; global using Plugins;";

	[Fact]
	public void BundledPluginsCompileAgainstTheCurrentApi()
	{
		string directory = FindPluginScripts();
		var options = new CSharpParseOptions(LanguageVersion.Preview);
		var trees = Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories).Select(file => CSharpSyntaxTree.ParseText(File.ReadAllText(file), options, file)).ToList();
		trees.Add(CSharpSyntaxTree.ParseText(GlobalUsings, options, "GlobalUsings.cs"));

		var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")).Split(Path.PathSeparator).Where(path => path.EndsWith(".dll")).Select(path => MetadataReference.CreateFromFile(path)).ToList();
		var compilation = CSharpCompilation.Create("PluginCheck", trees, references, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithAllowUnsafe(true));

		var errors = compilation.GetDiagnostics().Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error).Select(diagnostic => diagnostic.ToString()).ToList();
		Assert.True(errors.Count == 0, string.Join(Environment.NewLine, errors.Take(20)));
	}

	private static string FindPluginScripts()
	{
		for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory != null; directory = directory.Parent) {
			string candidate = Path.Combine(directory.FullName, "PluginScripts");
			if (Directory.Exists(candidate)) return candidate;
		}

		throw new DirectoryNotFoundException("PluginScripts folder not found");
	}
}
