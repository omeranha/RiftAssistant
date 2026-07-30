using System;

public class CrusaderPowerInfo
{
	private readonly Player class310_0;

	public Skill AkaratsChampion => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 269032);

	public Skill BlessedHammer => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 266766);

	public Skill BlessedShield => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 266951);

	public Skill Bombardment => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 284876);

	public Skill Condemn => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 266627);

	public Skill Consecration => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 273941);

	public Skill CrushingResolve => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 267818);

	public Skill FallingSword => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 239137);

	public Skill FistOfTheHeavens => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 239218);

	public Skill HeavensFury => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 316014);

	public Skill IronSkin => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 291804);

	public Skill Judgment => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 267600);

	public Skill Justice => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 325216);

	public Skill LawsOfHope => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 342279);

	public Skill LawsOfJustice => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 342280);

	public Skill LawsOfValor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 342281);

	public Skill Phalanx => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 330729);

	public Skill Provoke => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 290545);

	public Skill Punish => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 285903);

	public Skill ShieldBash => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 353492);

	public Skill ShieldGlare => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 268530);

	public Skill Slash => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 289243);

	public Skill Smite => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 286510);

	public Skill SteedCharge => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 243853);

	public Skill SweepAttack => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 239042);

	public SnoPower Blunt => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 348773);

	public SnoPower DivineFortress => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 356176);

	public SnoPower Fanaticism => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 357269);

	public SnoPower Fervor => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 357218);

	public SnoPower Finery => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 311629);

	public SnoPower HeavenlyStrength => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 286177);

	public SnoPower HoldYourGround => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 302500);

	public SnoPower HolyCause => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 310804);

	public SnoPower Indestructible => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 309830);

	public SnoPower Insurmountable => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 310640);

	public SnoPower IronMaiden => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 310783);

	public SnoPower LongArmOfTheLaw => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 310678);

	public SnoPower LordCommander => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 348741);

	public SnoPower Renewal => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 356173);

	public SnoPower Righteousness => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 356147);

	public SnoPower ToweringShield => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 356052);

	public SnoPower Vigilant => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 310626);

	public SnoPower Wrathful => class310_0.list_2.Find((SnoPower SnoPower_0) => SnoPower_0.Sno == 310775);

	internal CrusaderPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
