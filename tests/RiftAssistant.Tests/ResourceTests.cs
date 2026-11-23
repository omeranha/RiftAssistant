using RiftAssistant.Model;
using Xunit;

namespace RiftAssistant.Tests;

public class ResourceTests
{
	[Fact]
	public void ApplicationResourcesLoad()
	{
		Assert.NotNull(AppResources.BuffFrame);
		Assert.NotNull(AppResources.DebuffFrame);
		Assert.NotNull(AppResources.Icon);
	}

	[Fact]
	public void GameResourcesLoad()
	{
		var set = GameResources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.InvariantCulture, true, false);
		Assert.NotNull(set);
	}
}