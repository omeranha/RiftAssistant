using Plugins;

internal class PlayerDamage : IPlayerDamageInfo
{
	public double TotalDamage { get; set; }

	public double RunDps { get; set; }

	public double CurrentDps { get; set; }

	public double MaximumDps { get; set; }
}
