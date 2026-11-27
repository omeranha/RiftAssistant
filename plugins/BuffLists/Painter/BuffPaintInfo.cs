using System.Collections.Generic;

namespace Plugins.Default;

public class BuffPaintInfo
{
	public uint Id { get; set; }
	public SnoPower SnoPower { get; set; }
	public double Elapsed { get; set; }
	public double TimeLeft { get; set; }
	public int Stacks { get; set; }
	public List<SnoPowerIcon> Icons { get; set; }
	public BuffRule Rule { get; set; }
	public Texture BackgroundTexture { get; set; }
	public Texture Texture { get; set; }

	public float Size { get; set; }
	public bool? TimeLeftNumbersOverride { get; set; }
}
