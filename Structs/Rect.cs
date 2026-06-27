using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct RECT
{
	public int Left;
	public int Top;
	public int Right;
	public int Bottom;
}