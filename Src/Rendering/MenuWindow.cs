using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;

namespace RiftAssistant.Rendering;

internal abstract class MenuWindow
{
	private const int Padding = 10;
	private const int HeaderHeight = 38;
	private const int RowSpacing = 3;
	private const int ScrollBarWidth = 6;
	private const int WheelStep = 48;
	private const int MinThumbHeight = 24;

	private readonly int contentWidth;
	private readonly int sidebarWidth;
	private readonly int minContentHeight;
	private readonly int maxContentHeight;

	private volatile IUIComponent[] sidebarRows = [];
	private volatile IUIComponent[] pinnedRows = [];
	private volatile IUIComponent[] scrollRows = [];
	private volatile bool dirty = true;
	private bool visible;
	private int drawX;
	private int drawY;
	private int windowHeight = 100;
	private int viewportTop;
	private int viewportHeight;
	private int contentHeight;
	private int scroll;
	private bool dragging;
	private int dragGrab;

	protected MenuWindow(int contentWidth, int sidebarWidth = 0, int minContentHeight = 0, int maxContentHeight = 0)
	{
		this.contentWidth = contentWidth;
		this.sidebarWidth = sidebarWidth;
		this.minContentHeight = minContentHeight;
		this.maxContentHeight = maxContentHeight;
	}

	public bool Visible
	{
		get => visible;
		set {
			if (visible == value) return;

			visible = value;
			if (!value) {
				KeyboardCapture.End();
				dragging = false;
			}

			OnVisibleChanged(value);
			dirty = true;
		}
	}

	public int Width => Padding + (sidebarWidth > 0 ? sidebarWidth + Padding : 0) + contentWidth + Padding;

	public int Height => windowHeight;

	protected abstract string Title { get; }

	protected virtual string Subtitle => "";

	protected virtual bool CanGoBack => false;

	protected virtual bool NeedsRebuild => false;

	protected int ContentLeft => Padding + (sidebarWidth > 0 ? sidebarWidth + Padding : 0);

	protected virtual void OnBack()
	{
	}

	protected virtual void OnVisibleChanged(bool isVisible)
	{
	}

	protected virtual void BuildSidebar(List<IUIComponent> rows)
	{
	}

	protected virtual void BuildPinned(List<IUIComponent> rows)
	{
	}

	protected abstract void BuildContent(List<IUIComponent> rows);

	protected void Invalidate()
	{
		dirty = true;
	}

	protected void ScrollToTop()
	{
		scroll = 0;
		dirty = true;
	}

	public void Toggle()
	{
		Visible = !Visible;
	}

	public bool Contains(int mouseX, int mouseY)
	{
		return Visible && mouseX >= drawX && mouseX <= drawX + Width && mouseY >= drawY && mouseY <= drawY + windowHeight;
	}

	public bool HandleWheel(int mouseX, int mouseY, int delta)
	{
		if (!Contains(mouseX, mouseY)) return false;

		SetScroll(scroll - delta / 120 * WheelStep);
		return true;
	}

	public bool HandleInput(int mouseX, int mouseY, bool isMouseClicked)
	{
		if (!Visible || !isMouseClicked || !Contains(mouseX, mouseY)) return false;

		if (CloseSlot().Contains(mouseX, mouseY)) {
			Visible = false;
			return true;
		}

		if (CanGoBack && BackSlot().Contains(mouseX, mouseY)) {
			OnBack();
			dirty = true;
			return true;
		}

		if (HandleRows(sidebarRows, mouseX, mouseY) || HandleRows(pinnedRows, mouseX, mouseY)) return true;

		if (mouseX >= drawX + ContentLeft && mouseX <= drawX + ContentLeft + contentWidth && mouseY >= drawY + viewportTop && mouseY <= drawY + viewportTop + viewportHeight && HandleRows(scrollRows, mouseX, mouseY)) return true;

		if (MaxScroll() > 0 && TrackSlot().Contains(mouseX, mouseY)) {
			var thumb = ThumbSlot();
			if (thumb.Contains(mouseX, mouseY)) {
				dragging = true;
				dragGrab = mouseY - (int)thumb.Top;
			} else {
				SetScroll(scroll + (mouseY < thumb.Top ? -viewportHeight : viewportHeight));
			}
		}

		return true;
	}

	public void Draw(int x, int y)
	{
		if (!Visible) return;

		drawX = x;
		drawY = y;
		if (dirty || NeedsRebuild) Rebuild();

		if (dragging) {
			if ((Control.MouseButtons & MouseButtons.Left) == 0) {
				dragging = false;
			} else {
				ScrollFromThumb(GameWindowManager.Window.CursorY - dragGrab);
			}
		}

		var area = new RectangleF(x, y, Width, windowHeight);
		MenuStyle.FillOf(MenuColor.Black, 225).DrawRectangle(area);
		MenuStyle.Outline.DrawRectangle(area);
		DrawHeader();

		foreach (var row in sidebarRows) row.Draw(x, y);
		foreach (var row in pinnedRows) row.Draw(x, y);

		var target = Overlay.Instance.renderTarget;
		if (target == null) return;
		var viewport = new RectangleF(x + ContentLeft, y + viewportTop, contentWidth, viewportHeight);
		target.PushAxisAlignedClip(new RawRectangleF(viewport.Left, viewport.Top, viewport.Right, viewport.Bottom), AntialiasMode.Aliased);
		try {
			foreach (var row in scrollRows) {
				float top = row.Bounds.Top - scroll;
				if (top + row.Bounds.Height < viewportTop || top > viewportTop + viewportHeight) continue;

				row.Draw(x, y - scroll);
			}
		} finally {
			target.PopAxisAlignedClip();
		}

		DrawScrollBar();
	}

	private void DrawHeader()
	{
		float titleWidth = MenuStyle.DrawText(MenuStyle.TitleFont, Title, drawX + Padding, drawY + 6, 24);
		string subtitle = Subtitle;
		if (subtitle.Length > 0) MenuStyle.DrawText(MenuStyle.FontOf(MenuColor.Muted, small: true), subtitle, drawX + Padding + titleWidth + 10, drawY + 6, 24);

		var closeSlot = CloseSlot();
		MenuStyle.DrawBox(closeSlot, "X");
		if (CanGoBack) MenuStyle.DrawBox(BackSlot(), "< Back");
	}

	private void DrawScrollBar()
	{
		if (MaxScroll() <= 0) return;

		MenuStyle.FillOf(MenuColor.Dark).DrawRectangle(TrackSlot());
		var thumb = ThumbSlot();
		MenuStyle.FillOf(dragging ? MenuColor.White : MenuColor.Gray).DrawRectangle(thumb);
	}

	private bool HandleRows(IUIComponent[] rows, int mouseX, int mouseY)
	{
		foreach (var row in rows) {
			var bounds = row.Bounds;
			float offset = ReferenceEquals(rows, scrollRows) ? scroll : 0;
			float left = drawX + bounds.Left;
			float top = drawY + bounds.Top - offset;
			if (mouseX < left || mouseX > left + bounds.Width || mouseY < top || mouseY > top + bounds.Height) continue;
			if (row.HandleInput(mouseX, mouseY, true)) return true;
		}

		return false;
	}

	private RectangleF CloseSlot() => new(drawX + Width - 30, drawY + 7, 24, 22);

	private RectangleF BackSlot() => new(drawX + Width - 94, drawY + 7, 60, 22);

	private RectangleF TrackSlot() => new(drawX + Width - Padding / 2f - ScrollBarWidth / 2f - 1, drawY + viewportTop, ScrollBarWidth, viewportHeight);

	private RectangleF ThumbSlot()
	{
		var track = TrackSlot();
		int maxScroll = MaxScroll();
		float thumbHeight = Math.Max(MinThumbHeight, track.Height * viewportHeight / (float)contentHeight);
		float thumbTop = track.Top + (track.Height - thumbHeight) * (maxScroll == 0 ? 0 : scroll / (float)maxScroll);
		return new RectangleF(track.Left, thumbTop, track.Width, thumbHeight);
	}

	private int MaxScroll()
	{
		return Math.Max(0, contentHeight - viewportHeight);
	}

	private void SetScroll(int value)
	{
		int clamped = Math.Clamp(value, 0, MaxScroll());
		if (clamped == scroll) return;

		scroll = clamped;
		ApplyOrigins();
	}

	private void ScrollFromThumb(int thumbTop)
	{
		var track = TrackSlot();
		float travel = track.Height - ThumbSlot().Height;
		if (travel <= 0) return;

		SetScroll((int)Math.Round((thumbTop - track.Top) / travel * MaxScroll()));
	}

	private void ApplyOrigins()
	{
		foreach (var row in sidebarRows) if (row is MenuRow menuRow) menuRow.SetOrigin(drawX, drawY);
		foreach (var row in pinnedRows) if (row is MenuRow menuRow) menuRow.SetOrigin(drawX, drawY);
		foreach (var row in scrollRows) if (row is MenuRow menuRow) menuRow.SetOrigin(drawX, drawY - scroll);
	}

	private void Rebuild()
	{
		dirty = false;
		var sidebar = new List<IUIComponent>();
		var pinned = new List<IUIComponent>();
		var content = new List<IUIComponent>();
		BuildSidebar(sidebar);
		BuildPinned(pinned);
		BuildContent(content);

		int sidebarBottom = Place(sidebar, Padding, sidebarWidth, HeaderHeight);
		int pinnedBottom = Place(pinned, ContentLeft, contentWidth, HeaderHeight);
		viewportTop = pinned.Count > 0 ? pinnedBottom : HeaderHeight;
		int contentBottom = Place(content, ContentLeft, contentWidth, viewportTop);
		contentHeight = Math.Max(0, contentBottom - viewportTop - (content.Count > 0 ? RowSpacing : 0));

		if (maxContentHeight == 0) {
			viewportHeight = contentHeight;
		} else {
			int available = Math.Max(0, maxContentHeight - (viewportTop - HeaderHeight));
			viewportHeight = Math.Clamp(contentHeight, Math.Min(minContentHeight, available), available);
		}

		int bodyBottom = Math.Max(sidebar.Count > 0 ? sidebarBottom - RowSpacing : HeaderHeight, viewportTop + viewportHeight);
		windowHeight = bodyBottom + Padding;
		scroll = Math.Clamp(scroll, 0, MaxScroll());

		sidebarRows = [.. sidebar];
		pinnedRows = [.. pinned];
		scrollRows = [.. content];
		ApplyOrigins();
	}

	private static int Place(List<IUIComponent> rows, int left, int width, int top)
	{
		foreach (var row in rows) {
			var bounds = row.Bounds;
			row.Bounds = new RectangleF(left, top, row is MenuRow ? width : bounds.Width, bounds.Height);
			top += (int)bounds.Height + RowSpacing;
		}

		return top;
	}
}
