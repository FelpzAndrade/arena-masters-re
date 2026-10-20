using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003DA")]
public class XChatExtraService
{
	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, XChatExtraCommand> m_dicCommand;

	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x1AC1C7C", Offset = "0x1AC1C7C", VA = "0x1AC1C7C")]
	public XChatExtraService()
	{
	}

	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x1AC1D30", Offset = "0x1AC1D30", VA = "0x1AC1D30")]
	private void BuildCommand()
	{
	}

	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x1AC1F88", Offset = "0x1AC1F88", VA = "0x1AC1F88")]
	private void AddCommand(string _command, string _desc, Func<XChatExtraCommandContext, bool> func)
	{
	}

	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x1AC20F8", Offset = "0x1AC20F8", VA = "0x1AC20F8")]
	public bool IsChatExtraCommand(string _message)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F74")]
	[Address(RVA = "0x1AC2240", Offset = "0x1AC2240", VA = "0x1AC2240")]
	public bool ProcessCommand(string _sender, string _message)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F75")]
	[Address(RVA = "0x1AC24A4", Offset = "0x1AC24A4", VA = "0x1AC24A4")]
	private bool InviteFriendToParty(XChatExtraCommandContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x1AC26AC", Offset = "0x1AC26AC", VA = "0x1AC26AC")]
	private bool AcceptPartyInviation(XChatExtraCommandContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x1AC27F8", Offset = "0x1AC27F8", VA = "0x1AC27F8")]
	private bool RefuseGameInvitation(XChatExtraCommandContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x1AC29EC", Offset = "0x1AC29EC", VA = "0x1AC29EC")]
	private bool NotifyCreatedRoom(XChatExtraCommandContext context)
	{
		return default(bool);
	}
}
