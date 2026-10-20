using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20004C7")]
public interface IChatUI
{
	[Token(Token = "0x6002915")]
	bool IsEnabled();

	[Token(Token = "0x6002916")]
	void ChatWindowRefresh();

	[Token(Token = "0x6002917")]
	void RefreshUIChatMessages(XUIChatGround.XUIChatMessageType type);

	[Token(Token = "0x6002918")]
	void RefreshMessages(List<ChatMessage> messages);

	[Token(Token = "0x6002919")]
	void AddChatMessage(ChatMessage msg);

	[Token(Token = "0x600291A")]
	bool CheckMessageTypeInTab(PhotonChatMessage msg);

	[Token(Token = "0x600291B")]
	void RefreshClanWarPartyCount(int currentClanWarPartyCount);

	[Token(Token = "0x600291C")]
	void ChatUIClear();

	[Token(Token = "0x600291D")]
	void RefreshChatTab();
}
