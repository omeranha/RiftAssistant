using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class FormOverlay : Form
{
	protected override CreateParams CreateParams
	{
		get {
			const int WS_EX_LAYERED = 0x00080000;
			const int WS_EX_TRANSPARENT = 0x00000020;
			const int WS_EX_TOOLWINDOW = 0x00000080;
			const int WS_EX_NOACTIVATE = 0x08000000;

			var cp = base.CreateParams;
			cp.ExStyle |= WS_EX_LAYERED | WS_EX_TRANSPARENT | WS_EX_TOOLWINDOW | WS_EX_NOACTIVATE;
			return cp;
		}
	}

	protected override bool ShowWithoutActivation => true;

	public FormOverlay()
	{
		FormBorderStyle = FormBorderStyle.None;
		TopMost = true;
		ShowInTaskbar = false;
		DoubleBuffered = false;
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		SetLayeredWindowAttributes(Handle, 0, 255, 2);
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		int[] margins = [0, 0, Width, Height];
		DwmExtendFrameIntoClientArea(Handle, ref margins);
	}

	[DllImport("dwmapi.dll")]
	private static extern void DwmExtendFrameIntoClientArea(IntPtr intptr_0, ref int[] int_0);

	[DllImport("user32.dll")]
	static extern int GetWindowLong(IntPtr hwnd, int index);

	[DllImport("user32.dll")]
	private static extern int SetWindowLong(IntPtr handle, int index, int newLong);

	[DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
	private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, int key, byte alpha, int flags);
}