using System;
using System.Globalization;

public static class Formatting
{
	private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

	private static readonly (double Divisor, string Suffix, string Decimal, string Integer)[] Units = {
		(1e15, "qd", "#,0.0{0}", "#,0{0}"),
		(1e12, "tr", "#,0.0{0}", "#,0{0}"),
		(1e9,  "bn", "#,0.0{0}", "#,0{0}"),
		(1e6,  "M",  "#,0.0{0}", "#,0{0}"),
		(1e3,  "k",  "#,0.0{0}", "#,0{0}")
	};

	public static string ValueToString(long value, ValueFormat format)
	{
		if (value < 0)
			return "-" + ValueToString(-(double)value, format);

		return ValueToString((double)value, format);
	}

	public static string ValueToString(double value, ValueFormat format)
	{
		if (value < 0)
			return "-" + ValueToString(-value, format);

		switch (format) {
			case ValueFormat.NormalNumber:
				return value.ToString("#,0.0", Culture);

			case ValueFormat.NormalNumberNoDecimal:
				return value.ToString("#,0", Culture);

			case ValueFormat.LongNumber:
				return FormatScaled(value, false);

			case ValueFormat.ShortNumber:
				return FormatScaled(value, true);

			case ValueFormat.AlwaysK:
				return (value / 1e3).ToString("#,0.0K", Culture);

			case ValueFormat.AlwaysKNoDecimal:
				return (value / 1e3).ToString("#,0K", Culture);

			case ValueFormat.AlwaysM:
				return (value / 1e6).ToString("#,0.0M", Culture);

			case ValueFormat.AlwaysMNoDecimal:
				return (value / 1e6).ToString("#,0M", Culture);

			case ValueFormat.LongTime:
			{
				var ts = TimeSpan.FromTicks((long)value);
				return (ts.Hours > 0 ? $"{ts.Hours}h " : "") + ts.ToString("m\\m\\ ss\\s", Culture);
			}

			case ValueFormat.LongTimeNoSeconds:
			{
				var ts = TimeSpan.FromTicks((long)value);
				return (ts.Hours > 0 ? $"{ts.Hours}h " : "") + ts.ToString("m\\m", Culture);
			}

			default:
				return null;
		}
	}

	private static string FormatScaled(double value, bool shortK)
	{
		if (value == 0)
			return "0";

		if (value < 100)
			return value.ToString("0.0", Culture);

		if (value < 1000)
			return value.ToString("0", Culture);

		if (value < 10000)
			return value.ToString("#,0", Culture);

		foreach (var unit in Units) {
			if (value >= unit.Divisor) {
				double scaled = value / unit.Divisor;
				string pattern = scaled < 100 ? unit.Decimal : unit.Integer;
				return scaled.ToString(
					string.Format(pattern,
						unit.Suffix == "k" && shortK ? ".#k" : unit.Suffix),
					Culture);
			}
		}

		return (value / 1e3).ToString(shortK ? "#,0.#k" : "#,0k", Culture);
	}
}