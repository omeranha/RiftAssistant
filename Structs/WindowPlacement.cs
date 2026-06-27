using System.Drawing;

public struct WINDOWPLACEMENT
{
	public int length;
	public int flags;
	public int showCmd;
	public Point minPosition;
	public Point maxPosition;
	public Rectangle normalPosition;
}