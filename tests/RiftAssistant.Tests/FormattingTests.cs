using RiftAssistant.Model;
using Xunit;

namespace RiftAssistant.Tests;

public class FormattingTests
{
	[Theory]
	[InlineData(0, "0")]
	[InlineData(999, "999")]
	public void NormalNumberNoDecimal_FormatsWholeNumbers(long value, string expected)
	{
		Assert.Equal(expected, Formatting.ValueToString(value, ValueFormat.NormalNumberNoDecimal));
	}

	[Fact]
	public void NormalNumberNoDecimal_UsesThousandsSeparator()
	{
		Assert.Equal("1,234,567", Formatting.ValueToString(1234567L, ValueFormat.NormalNumberNoDecimal));
	}

	[Fact]
	public void NegativeValues_KeepTheSign()
	{
		Assert.Equal("-1,500", Formatting.ValueToString(-1500L, ValueFormat.NormalNumberNoDecimal));
	}

	[Fact]
	public void LongNumber_ScalesLargeValues()
	{
		string text = Formatting.ValueToString(2_500_000_000L, ValueFormat.LongNumber);
		Assert.EndsWith("bn", text);
	}
}
