using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

[Token(Token = "0x20004C6")]
public class XChatManager
{
	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0x8")]
	private XChatSpamChecker m_ChatSpamChecker;

	[Token(Token = "0x4001816")]
	[FieldOffset(Offset = "0xC")]
	private IChatUI chatUI;

	[Token(Token = "0x4001817")]
	[FieldOffset(Offset = "0x10")]
	private OnRecieveChatMessage m_onRecieveNormalChatMessage;

	[Token(Token = "0x4001818")]
	[FieldOffset(Offset = "0x14")]
	private OnClanWarPartyUpdated m_onClanWarPartyUpdated;

	[Token(Token = "0x1400005B")]
	public event OnRecieveChatMessage onRecieveNormalChatMessage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x1AC2E90", Offset = "0x1AC2E90", VA = "0x1AC2E90")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x1AC301C", Offset = "0x1AC301C", VA = "0x1AC301C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005C")]
	public event OnClanWarPartyUpdated onClanWarPartyUpdated
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x1AC31A8", Offset = "0x1AC31A8", VA = "0x1AC31A8")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x1AC3334", Offset = "0x1AC3334", VA = "0x1AC3334")]
		remove
		{
		}
	}

	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x1AC2D04", Offset = "0x1AC2D04", VA = "0x1AC2D04")]
	public XChatManager()
	{
	}

	[Token(Token = "0x6002904")]
	[Address(RVA = "0x1AC34C0", Offset = "0x1AC34C0", VA = "0x1AC34C0")]
	public void InitChatUI(IChatUI chatUI)
	{
	}

	[Token(Token = "0x6002905")]
	[Address(RVA = "0x1AC34C8", Offset = "0x1AC34C8", VA = "0x1AC34C8")]
	public void ClearChatUI()
	{
	}

	[Token(Token = "0x6002906")]
	[Address(RVA = "0x1AC34D4", Offset = "0x1AC34D4", VA = "0x1AC34D4")]
	public void RegisterClanWarPartyUpdated(OnClanWarPartyUpdated onClanWarPartyUpdated)
	{
	}

	[Token(Token = "0x6002907")]
	[Address(RVA = "0x1AC3770", Offset = "0x1AC3770", VA = "0x1AC3770")]
	public void ClearClanWarPartyUpdated()
	{
	}

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x1AC377C", Offset = "0x1AC377C", VA = "0x1AC377C")]
	private bool CheckAntiSpam()
	{
		return default(bool);
	}

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x1AC3854", Offset = "0x1AC3854", VA = "0x1AC3854")]
	public void AddMessage(PhotonChatMessage msg)
	{
	}

	[Token(Token = "0x600290A")]
	[Address(RVA = "0x1AC3AA8", Offset = "0x1AC3AA8", VA = "0x1AC3AA8")]
	private void AddChatMessage(ChatMessage msg)
	{
	}

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x1AC3BB0", Offset = "0x1AC3BB0", VA = "0x1AC3BB0")]
	private ChatMessage NewSystemMessage(string strMsg)
	{
		return null;
	}

	[Token(Token = "0x600290C")]
	[Address(RVA = "0x1AC3C7C", Offset = "0x1AC3C7C", VA = "0x1AC3C7C")]
	public void SendMessage(XChatChannelType chatChannelType, XChatMsgType msgType, string message, string strOriginMessage, object chatParams)
	{
	}

	[Token(Token = "0x600290D")]
	[Address(RVA = "0x1AC3DE4", Offset = "0x1AC3DE4", VA = "0x1AC3DE4")]
	public void SendInGameSystemMessage(string message)
	{
	}

	[Token(Token = "0x600290E")]
	[Address(RVA = "0x1AC3FB0", Offset = "0x1AC3FB0", VA = "0x1AC3FB0")]
	internal void ChangeNormalChannel(string changeLang, int changeChannelID, Action refreshChannel)
	{
	}

	[Token(Token = "0x600290F")]
	[Address(RVA = "0x1AC40A0", Offset = "0x1AC40A0", VA = "0x1AC40A0")]
	public void ChatWindowRefresh()
	{
	}

	[Token(Token = "0x6002910")]
	[Address(RVA = "0x1AC41A0", Offset = "0x1AC41A0", VA = "0x1AC41A0")]
	public void ChatUIClear()
	{
	}

	[Token(Token = "0x6002911")]
	[Address(RVA = "0x1AC429C", Offset = "0x1AC429C", VA = "0x1AC429C")]
	public void RefreshUIChatMessages(XUIChatGround.XUIChatMessageType type)
	{
	}

	[Token(Token = "0x6002912")]
	[Address(RVA = "0x1AC43A4", Offset = "0x1AC43A4", VA = "0x1AC43A4")]
	public void RefreshMessages(List<ChatMessage> messages)
	{
	}

	[Token(Token = "0x6002913")]
	[Address(RVA = "0x1AC44AC", Offset = "0x1AC44AC", VA = "0x1AC44AC")]
	public void RefreshClanWarPartyCount(int clanWarPartyCount)
	{
	}

	[Token(Token = "0x6002914")]
	[Address(RVA = "0x1AC45C4", Offset = "0x1AC45C4", VA = "0x1AC45C4")]
	public void RefreshChatTab()
	{
	}
}
