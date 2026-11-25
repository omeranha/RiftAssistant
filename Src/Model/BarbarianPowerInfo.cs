using System;

namespace RiftAssistant.Model;

public class BarbarianPowerInfo
{
	private readonly Player player0;

	public Skill AncientSpear => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 377453);

	public Skill Avalanche => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 353447);

	public Skill Bash => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 79242);

	public Skill BattleRage => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 79076);

	public Skill CallOfTheAncients => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 80049);

	public Skill Cleave => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 80263);

	public Skill Earthquake => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 98878);

	public Skill Frenzy => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 78548);

	public Skill FuriousCharge => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 97435);

	public Skill GroundStomp => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 79446);

	public Skill HammerOfTheAncients => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 80028);

	public Skill IgnorePain => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 79528);

	public Skill Leap => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 93409);

	public Skill Overpower => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 159169);

	public Skill Rend => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 70472);

	public Skill Revenge => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 109342);

	public Skill SeismicSlam => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 86989);

	public Skill Sprint => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 78551);

	public Skill ThreateningShout => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 79077);

	public Skill WarCry => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 375483);

	public Skill WeaponThrow => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 377452);

	public Skill Whirlwind => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 96296);

	public Skill WrathOfTheBerserker => Array.Find(player0.SkillSlots, (Skill skill) => skill != null && skill.CurrentSnoPower?.Sno == 79607);

	public SnoPower Animosity => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205228);

	public SnoPower BerserkerRage => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205187);

	public SnoPower Bloodthirst => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205217);

	public SnoPower BoonOfBulKathos => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 204603);

	public SnoPower Brawler => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205133);

	public SnoPower EarthenMight => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 361661);

	public SnoPower InspiringPresence => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205546);

	public SnoPower Juggernaut => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205707);

	public SnoPower NervesOfSteel => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 217819);

	public SnoPower NoEscape => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 204725);

	public SnoPower PoundOfFlesh => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205205);

	public SnoPower Rampage => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 296572);

	public SnoPower Relentless => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205398);

	public SnoPower Ruthless => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205175);

	public SnoPower Superstition => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205491);

	public SnoPower SwordAndBoard => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 340877);

	public SnoPower ToughAsNails => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205848);

	public SnoPower Unforgiving => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 205300);

	public SnoPower WeaponsMaster => player0.UsedPassives.Find((SnoPower snoPower) => snoPower.Sno == 206147);

	internal BarbarianPowerInfo(Player player)
	{
		player0 = player;
	}
}
