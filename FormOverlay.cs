using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using work;

internal class FormOverlay : Form
{
	protected override bool ShowWithoutActivation => true;

	private const int LWA_ALPHA = 2;

	public FormOverlay()
	{
		FormBorderStyle = FormBorderStyle.None;
		TopMost = true;
		ShowInTaskbar = false;
		DoubleBuffered = true;
		_ = Win32.User32.SetWindowLong(Handle, -20, 524448);
		Win32.User32.SetLayeredWindowAttributes_1(Handle, 0, byte.MaxValue, LWA_ALPHA);
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	[DllImport("dwmapi.dll")]
	private static extern void DwmExtendFrameIntoClientArea(IntPtr intptr_0, ref int[] int_0);

	protected override void OnResize(EventArgs e)
	{
		int[] margins = [0, 0, Width, Height];
		DwmExtendFrameIntoClientArea(Handle, ref margins);
	}
}