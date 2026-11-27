using System.Media;

namespace Plugins.Default;

public class CoolDownRule
{
	public SnoPower SnoPower { get; }
	public SoundPlayer SoundPlayer { get; private set; }

	public CoolDownRule(SnoPower snoPower, SoundPlayer soundPlayer)
	{
		SnoPower = snoPower;
		SoundPlayer = soundPlayer;
	}

	public void DisposeSoundPlayer()
	{
		SoundPlayer.Dispose();
		SoundPlayer = null;
	}
}
