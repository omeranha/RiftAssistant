namespace Plugins;

public interface IChatLineChangedHandler : IPlugin
{
	void OnChatLineChanged(string currentLine, string previousLine);
}
