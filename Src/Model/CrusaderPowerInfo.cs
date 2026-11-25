using System;

namespace RiftAssistant.Model;

public class CrusaderPowerInfo
{
	private readonly Player player0;

	public Skill AkaratsChampion => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 269032);

	public Skill BlessedHammer => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 266766);

	public Skill BlessedShield => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 266951);

	public Skill Bombardment => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 284876);

	public Skill Condemn => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 266627);

	public Skill Consecration => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 273941);

	public Skill CrushingResolve => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 267818);

	public Skill FallingSword => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 239137);

	public Skill FistOfTheHeavens => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 239218);

	public Skill HeavensFury => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 316014);

	public Skill IronSkin => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 291804);

	public Skill Judgment => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 267600);

	public Skill Justice => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 325216);

	public Skill LawsOfHope => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 342279);

	public Skill LawsOfJustice => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 342280);

	public Skill LawsOfValor => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 342281);

	public Skill Phalanx => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 330729);

	public Skill Provoke => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 290545);

	public Skill Punish => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 285903);

	public Skill ShieldBash => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 353492);

	public Skill ShieldGlare => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 268530);

	public Skill Slash => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 289243);

	public Skill Smite => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 286510);

	public Skill SteedCharge => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 243853);

	public Skill SweepAttack => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 239042);

	public SnoPower Blunt => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 348773);

	public SnoPower DivineFortress => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 356176);

	public SnoPower Fanaticism => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 357269);

	public SnoPower Fervor => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 357218);

	public SnoPower Finery => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 311629);

	public SnoPower HeavenlyStrength => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 286177);

	public SnoPower HoldYourGround => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 302500);

	public SnoPower HolyCause => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 310804);

	public SnoPower Indestructible => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 309830);

	public SnoPower Insurmountable => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 310640);

	public SnoPower IronMaiden => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 310783);

	public SnoPower LongArmOfTheLaw => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 310678);

	public SnoPower LordCommander => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 348741);

	public SnoPower Renewal => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 356173);

	public SnoPower Righteousness => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 356147);

	public SnoPower ToweringShield => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 356052);

	public SnoPower Vigilant => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 310626);

	public SnoPower Wrathful => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 310775);

	internal CrusaderPowerInfo(Player player)
	{
		player0 = player;
	}
}
