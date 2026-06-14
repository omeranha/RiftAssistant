using System;
using System.Drawing;
using work;

internal static class GameWindowManager
{
	public static DiabloWindow Window;

	internal static bool Update()
	{
		Window.Handle = Win32.User32.FindWindow("D3 Main Window Class", null);
		if (Window.Handle == IntPtr.Zero) {
			Window.Handle = Win32.User32.FindWindow(null, Window.WindowTitle);
			if (Window.Handle == IntPtr.Zero) {
				Window.Offset = Point.Empty;
				return false;
			}
		}

		Point clientPoint = default;
		Win32.User32.ClientToScreen(Window.Handle, ref clientPoint);
		Win32.User32.GetClientRect(Window.Handle, out Win32.RECT clientRect);

		int clientWidth = clientRect.Right - clientRect.Left;
		int clientHeight = clientRect.Bottom - clientRect.Top;
		if (clientWidth > 0) {
			bool isFullscreen = CoreCollector.GameSettingsManager.IsFullscreen;

			int width = clientWidth;
			int height = isFullscreen ? (width * 9 / 16) : clientHeight;
			int offsetX = clientPoint.X;
			int offsetY = isFullscreen ? clientPoint.Y + ((clientHeight - height) / 2) : clientPoint.Y;
			if (offsetX != Window.Offset.X || offsetY != Window.Offset.Y) {
				Window.Offset = new Point(offsetX, offsetY);
			}

			if (Window.Size.Width != width || Window.Size.Height != height) {
				Window.Size = new Size(width, height);

				float fWidth = width;
				float fHeight = height;
				Window.Aspect = (fWidth / fHeight) * (600f / 800f);
				float baseWidth = (fHeight / 3f) * 4f;
				float scaleHeight = 600f / fHeight;
				Window.WidescreenOffset = (fWidth - baseWidth) * scaleHeight;
				Window.HeightUiRatio = fHeight / 1200f;
			}
		} else if (Window.Size.Width == 0) {
			Window.Size = new Size(1280, 720);
			Window.Aspect = 1f;
		}
		return true;
	}
}
