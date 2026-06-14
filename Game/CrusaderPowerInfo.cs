using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class CrusaderPowerInfo : ICrusaderPowerInfo
{
	private readonly Player class310_0;

	public IPlayerSkill AkaratsChampion => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 269032);

	public IPlayerSkill BlessedHammer => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 266766);

	public IPlayerSkill BlessedShield => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 266951);

	public IPlayerSkill Bombardment => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 284876);

	public IPlayerSkill Condemn => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 266627);

	public IPlayerSkill Consecration => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 273941);

	public IPlayerSkill CrushingResolve => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 267818);

	public IPlayerSkill FallingSword => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 239137);

	public IPlayerSkill FistOfTheHeavens => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 239218);

	public IPlayerSkill HeavensFury => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 316014);

	public IPlayerSkill IronSkin => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 291804);

	public IPlayerSkill Judgment => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 267600);

	public IPlayerSkill Justice => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 325216);

	public IPlayerSkill LawsOfHope => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 342279);

	public IPlayerSkill LawsOfJustice => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 342280);

	public IPlayerSkill LawsOfValor => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 342281);

	public IPlayerSkill Phalanx => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 330729);

	public IPlayerSkill Provoke => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 290545);

	public IPlayerSkill Punish => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 285903);

	public IPlayerSkill ShieldBash => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 353492);

	public IPlayerSkill ShieldGlare => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 268530);

	public IPlayerSkill Slash => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 289243);

	public IPlayerSkill Smite => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 286510);

	public IPlayerSkill SteedCharge => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 243853);

	public IPlayerSkill SweepAttack => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 239042);

	public ISnoPower Blunt => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 348773);

	public ISnoPower DivineFortress => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 356176);

	public ISnoPower Fanaticism => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 357269);

	public ISnoPower Fervor => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 357218);

	public ISnoPower Finery => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 311629);

	public ISnoPower HeavenlyStrength => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 286177);

	public ISnoPower HoldYourGround => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 302500);

	public ISnoPower HolyCause => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 310804);

	public ISnoPower Indestructible => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 309830);

	public ISnoPower Insurmountable => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 310640);

	public ISnoPower IronMaiden => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 310783);

	public ISnoPower LongArmOfTheLaw => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 310678);

	public ISnoPower LordCommander => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 348741);

	public ISnoPower Renewal => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 356173);

	public ISnoPower Righteousness => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 356147);

	public ISnoPower ToweringShield => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 356052);

	public ISnoPower Vigilant => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 310626);

	public ISnoPower Wrathful => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 310775);

	internal CrusaderPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
