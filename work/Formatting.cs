using System;
using System.Globalization;

namespace work;

public static class Formatting
{
	public static string VtoS(long value, ValueFormat format)
	{
		if (value < 0)
		{
			return "-" + VtoS(-value, format);
		}
		switch (format)
		{
		default:
			return null;
		case ValueFormat.NormalNumber:
			return value.ToString("#,0.#", CultureInfo.InvariantCulture);
		case ValueFormat.NormalNumberNoDecimal:
			return value.ToString("#,0", CultureInfo.InvariantCulture);
		case ValueFormat.LongNumber:
			if (value == 0L)
			{
				return "0";
			}
			if (value < 100000000000000000L)
			{
				if (value < 1000000000000000L)
				{
					if (value < 100000000000000L)
					{
						if (value < 1000000000000L)
						{
							if (value < 100000000000L)
							{
								if (value < 1000000000)
								{
									if (value < 100000000)
									{
										if (value < 1000000)
										{
											if (value < 10000)
											{
												if (value < 1000)
												{
													if (value < 100)
													{
														return value.ToString("0.0", CultureInfo.InvariantCulture);
													}
													return value.ToString("0", CultureInfo.InvariantCulture);
												}
												return value.ToString("#,0", CultureInfo.InvariantCulture);
											}
											return ((float)value / 1000f).ToString("#,0k", CultureInfo.InvariantCulture);
										}
										return ((float)value / 1000f / 1000f).ToString("#,0.0M", CultureInfo.InvariantCulture);
									}
									return ((float)value / 1000f / 1000f).ToString("#,0M", CultureInfo.InvariantCulture);
								}
								return ((float)value / 1000f / 1000f / 1000f).ToString("#,0.0bn", CultureInfo.InvariantCulture);
							}
							return ((float)value / 1000f / 1000f / 1000f).ToString("#,0bn", CultureInfo.InvariantCulture);
						}
						return ((float)value / 1000f / 1000f / 1000f / 1000f).ToString("#,0.0tr", CultureInfo.InvariantCulture);
					}
					return ((float)value / 1000f / 1000f / 1000f / 1000f).ToString("#,0tr", CultureInfo.InvariantCulture);
				}
				return ((float)value / 1000f / 1000f / 1000f / 1000f / 1000f).ToString("#,0.0qd", CultureInfo.InvariantCulture);
			}
			return ((float)value / 1000f / 1000f / 1000f / 1000f / 1000f).ToString("#,0qd", CultureInfo.InvariantCulture);
		case ValueFormat.ShortNumber:
			if (value == 0L)
			{
				return "0";
			}
			if (value < 100000000000000000L)
			{
				if (value < 1000000000000000L)
				{
					if (value < 100000000000000L)
					{
						if (value < 1000000000000L)
						{
							if (value < 100000000000L)
							{
								if (value < 1000000000)
								{
									if (value < 100000000)
									{
										if (value < 1000000)
										{
											if (value < 1000)
											{
												if (value < 100)
												{
													return value.ToString("0.0", CultureInfo.InvariantCulture);
												}
												return value.ToString("0", CultureInfo.InvariantCulture);
											}
											return ((float)value / 1000f).ToString("#,0.#k", CultureInfo.InvariantCulture);
										}
										return ((float)value / 1000f / 1000f).ToString("#,0.0M", CultureInfo.InvariantCulture);
									}
									return ((float)value / 1000f / 1000f).ToString("#,0M", CultureInfo.InvariantCulture);
								}
								return ((float)value / 1000f / 1000f / 1000f).ToString("#,0.0bn", CultureInfo.InvariantCulture);
							}
							return ((float)value / 1000f / 1000f / 1000f).ToString("#,0bn", CultureInfo.InvariantCulture);
						}
						return ((float)value / 1000f / 1000f / 1000f / 1000f).ToString("#,0.0tr", CultureInfo.InvariantCulture);
					}
					return ((float)value / 1000f / 1000f / 1000f / 1000f).ToString("#,0tr", CultureInfo.InvariantCulture);
				}
				return ((float)value / 1000f / 1000f / 1000f / 1000f / 1000f).ToString("#,0.0qd", CultureInfo.InvariantCulture);
			}
			return ((float)value / 1000f / 1000f / 1000f / 1000f / 1000f).ToString("#,0qd", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysK:
			return ((float)value / 1000f).ToString("#,0.#K", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysKNoDecimal:
			return ((float)value / 1000f).ToString("#,0K", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysM:
			return ((float)value / 1000f).ToString("#,0.#M", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysMNoDecimal:
			return ((float)value / 1000f).ToString("#,0M", CultureInfo.InvariantCulture);
		case ValueFormat.LongTime:
		{
			long num2 = value / 36000000000L;
			return ((num2 > 0) ? (num2.ToString("D", CultureInfo.InvariantCulture) + "h ") : "") + new TimeSpan(value).ToString("m\\m\\ ss\\s", CultureInfo.InvariantCulture);
		}
		case ValueFormat.LongTimeNoSeconds:
		{
			long num = value / 36000000000L;
			return ((num > 0) ? (num.ToString("D", CultureInfo.InvariantCulture) + "h ") : "") + new TimeSpan(value).ToString("m\\m", CultureInfo.InvariantCulture);
		}
		}
	}

	public static string VtoS(double value, ValueFormat format)
	{
		if (value < 0.0)
		{
			return "-" + VtoS(0.0 - value, format);
		}
		switch (format)
		{
		default:
			return null;
		case ValueFormat.NormalNumber:
			return value.ToString("#,0.0", CultureInfo.InvariantCulture);
		case ValueFormat.NormalNumberNoDecimal:
			return Math.Round(value, 0).ToString("#,0", CultureInfo.InvariantCulture);
		case ValueFormat.LongNumber:
			if (value == 0.0)
			{
				return "0";
			}
			if (value < 1E+17)
			{
				if (value < 1000000000000000.0)
				{
					if (value < 100000000000000.0)
					{
						if (value < 1000000000000.0)
						{
							if (value < 100000000000.0)
							{
								if (value < 1000000000.0)
								{
									if (value < 100000000.0)
									{
										if (value < 1000000.0)
										{
											if (value < 10000.0)
											{
												if (value < 1000.0)
												{
													if (value < 100.0)
													{
														return value.ToString("0.0", CultureInfo.InvariantCulture);
													}
													return value.ToString("0", CultureInfo.InvariantCulture);
												}
												return value.ToString("#,0", CultureInfo.InvariantCulture);
											}
											return (value / 1000.0).ToString("#,0k", CultureInfo.InvariantCulture);
										}
										return (value / 1000.0 / 1000.0).ToString("#,0.0M", CultureInfo.InvariantCulture);
									}
									return (value / 1000.0 / 1000.0).ToString("#,0M", CultureInfo.InvariantCulture);
								}
								return (value / 1000.0 / 1000.0 / 1000.0).ToString("#,0.0bn", CultureInfo.InvariantCulture);
							}
							return (value / 1000.0 / 1000.0 / 1000.0).ToString("#,0bn", CultureInfo.InvariantCulture);
						}
						return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0.0tr", CultureInfo.InvariantCulture);
					}
					return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0tr", CultureInfo.InvariantCulture);
				}
				return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0.0qd", CultureInfo.InvariantCulture);
			}
			return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0qd", CultureInfo.InvariantCulture);
		case ValueFormat.ShortNumber:
			if (value == 0.0)
			{
				return "0";
			}
			if (value < 1E+17)
			{
				if (value < 1000000000000000.0)
				{
					if (value < 100000000000000.0)
					{
						if (value < 1000000000000.0)
						{
							if (value < 100000000000.0)
							{
								if (value < 1000000000.0)
								{
									if (value < 100000000.0)
									{
										if (value < 1000000.0)
										{
											if (value < 1000.0)
											{
												if (value < 100.0)
												{
													return value.ToString("0.0", CultureInfo.InvariantCulture);
												}
												return value.ToString("0", CultureInfo.InvariantCulture);
											}
											return (value / 1000.0).ToString("#,0.#k", CultureInfo.InvariantCulture);
										}
										return (value / 1000.0 / 1000.0).ToString("#,0.0M", CultureInfo.InvariantCulture);
									}
									return (value / 1000.0 / 1000.0).ToString("#,0M", CultureInfo.InvariantCulture);
								}
								return (value / 1000.0 / 1000.0 / 1000.0).ToString("#,0.0bn", CultureInfo.InvariantCulture);
							}
							return (value / 1000.0 / 1000.0 / 1000.0).ToString("#,0bn", CultureInfo.InvariantCulture);
						}
						return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0.0tr", CultureInfo.InvariantCulture);
					}
					return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0tr", CultureInfo.InvariantCulture);
				}
				return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0.0qd", CultureInfo.InvariantCulture);
			}
			return (value / 1000.0 / 1000.0 / 1000.0 / 1000.0 / 1000.0).ToString("#,0qd", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysK:
			return (value / 1000.0).ToString("#,0.0K", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysKNoDecimal:
			return (value / 1000.0).ToString("#,0K", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysM:
			return (value / 1000.0).ToString("#,0.0M", CultureInfo.InvariantCulture);
		case ValueFormat.AlwaysMNoDecimal:
			return (value / 1000.0).ToString("#,0M", CultureInfo.InvariantCulture);
		}
	}
}
