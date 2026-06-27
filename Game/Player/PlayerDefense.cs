using System;
using Plugins;

public class PlayerDefense(Player player)
{
	private readonly Player player = player;

	public float EhpCur { get; set; }

	public float EhpMax { get; set; }

	public float HealthCur { get; set; }

	public float HealthMax { get; set; }

	public float HealthPct { get; set; }

	public float CurShield { get; set; }

	public float Armor { get; set; }

	public float LifeBonus { get; set; }

	public float ResPhysical { get; set; }

	public float ResCold { get; set; }

	public float ResFire { get; set; }

	public float ResLightning { get; set; }

	public float ResPoison { get; set; }

	public float ResArcane { get; set; }

	public float ResLowest { get; set; }

	public float ResAverage { get; set; }

	public float LifeRegen { get; set; }

	public float LifeOnHit { get; set; }

	public float LifeOnKill { get; set; }

	public float Thorns { get; set; }

	public float GlobeBonusHealth { get; set; }

	public float DRClass { get; set; }

	public float drArmor { get; set; }

	public float drResist { get; set; }

	public float drCombined { get; set; }

	public float[] DamageReductionFromType { get; set; } = new float[6];

	public float AverageDamageReductionFromType { get; set; }

	public float CCReduction { get; set; }

	public float DamageReduction { get; set; }

	public float DRRanged { get; set; }

	public float DRMelee { get; set; }

	public float DRElite { get; set; }

	public double CurrentDamageTakenPerSecond { get; set; }

	public double CurrentHealingPerSecond { get; set; }

	public double CurrentEffectiveHealingPercent
	{
		get {
			double num = CurrentHealingPerSecond - CurrentDamageTakenPerSecond;
			if (!(Math.Abs(num) < 1.0) && player.Defense.HealthMax != 0f) {
				return Math.Max(-100.0, Math.Min(100.0, num * 100.0 / (double)player.Defense.HealthMax));
			}
			return 0.0;
		}
	}
}
