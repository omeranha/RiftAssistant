using System;
using System.Runtime.CompilerServices;
using Plugins;

namespace work;

internal class BarbarianPowerInfo : IBarbarianPowerInfo
{
	private readonly Player class310_0;

	public IPlayerSkill AncientSpear => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 377453);

	public IPlayerSkill Avalanche => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 353447);

	public IPlayerSkill Bash => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 79242);

	public IPlayerSkill BattleRage => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 79076);

	public IPlayerSkill CallOfTheAncients => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 80049);

	public IPlayerSkill Cleave => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 80263);

	public IPlayerSkill Earthquake => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 98878);

	public IPlayerSkill Frenzy => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 78548);

	public IPlayerSkill FuriousCharge => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 97435);

	public IPlayerSkill GroundStomp => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 79446);

	public IPlayerSkill HammerOfTheAncients => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 80028);

	public IPlayerSkill IgnorePain => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 79528);

	public IPlayerSkill Leap => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 93409);

	public IPlayerSkill Overpower => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 159169);

	public IPlayerSkill Rend => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 70472);

	public IPlayerSkill Revenge => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 109342);

	public IPlayerSkill SeismicSlam => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 86989);

	public IPlayerSkill Sprint => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 78551);

	public IPlayerSkill ThreateningShout => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 79077);

	public IPlayerSkill WarCry => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 375483);

	public IPlayerSkill WeaponThrow => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 377452);

	public IPlayerSkill Whirlwind => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 96296);

	public IPlayerSkill WrathOfTheBerserker => Array.Find(class310_0.class386_0, (Skill class386_0) => class386_0 != null && class386_0.CurrentSnoPower?.Sno == 79607);

	public ISnoPower Animosity => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205228);

	public ISnoPower BerserkerRage => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205187);

	public ISnoPower Bloodthirst => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205217);

	public ISnoPower BoonOfBulKathos => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 204603);

	public ISnoPower Brawler => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205133);

	public ISnoPower EarthenMight => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 361661);

	public ISnoPower InspiringPresence => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205546);

	public ISnoPower Juggernaut => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205707);

	public ISnoPower NervesOfSteel => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 217819);

	public ISnoPower NoEscape => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 204725);

	public ISnoPower PoundOfFlesh => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205205);

	public ISnoPower Rampage => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 296572);

	public ISnoPower Relentless => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205398);

	public ISnoPower Ruthless => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205175);

	public ISnoPower Superstition => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205491);

	public ISnoPower SwordAndBoard => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 340877);

	public ISnoPower ToughAsNails => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205848);

	public ISnoPower Unforgiving => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 205300);

	public ISnoPower WeaponsMaster => class310_0.list_2.Find((ISnoPower isnoPower_0) => isnoPower_0.Sno == 206147);

	internal BarbarianPowerInfo(Player class310_1)
	{
		class310_0 = class310_1;
	}
}
