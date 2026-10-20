using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3B")]
public class XUIChatMessage : XUIChatMessageBase
{
	[Token(Token = "0x4003DD0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblSender;

	[Token(Token = "0x4003DD1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblMessage;

	[Token(Token = "0x4003DD2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblTime;

	[Token(Token = "0x4003DD3")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x4003DD4")]
	[FieldOffset(Offset = "0x28")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4003DD5")]
	[FieldOffset(Offset = "0x2C")]
	public XUIChatUserInfo chatUserInfo;

	[Token(Token = "0x4003DD6")]
	[FieldOffset(Offset = "0x30")]
	public UIPanel m_scrollPanel;

	[Token(Token = "0x4003DD7")]
	[FieldOffset(Offset = "0x34")]
	public Color myNameColor;

	[Token(Token = "0x4003DD8")]
	[FieldOffset(Offset = "0x44")]
	public Color defaultNameColor;

	[Token(Token = "0x4003DD9")]
	[FieldOffset(Offset = "0x54")]
	private bool isMine;

	[Token(Token = "0x4003DDA")]
	[FieldOffset(Offset = "0x58")]
	private string m_aid;

	[Token(Token = "0x6005861")]
	[Address(RVA = "0x1A341E4", Offset = "0x1A341E4", VA = "0x1A341E4")]
	public XUIChatMessage()
	{
	}

	[Token(Token = "0x6005862")]
	[Address(RVA = "0x1A341F4", Offset = "0x1A341F4", VA = "0x1A341F4", Slot = "4")]
	public override void Build(ChatMessage msg, Action<EventDelegate> infoAction)
	{
	}

	[Token(Token = "0x6005863")]
	[Address(RVA = "0x1A3425C", Offset = "0x1A3425C", VA = "0x1A3425C")]
	private void Build(ChatMessage chatMessage, string sender)
	{
	}

	[Token(Token = "0x6005864")]
	[Address(RVA = "0x1A34590", Offset = "0x1A34590", VA = "0x1A34590")]
	private void ParserPhotonChatMessage(ChatMessage chatMessage)
	{
	}

	[Token(Token = "0x6005865")]
	[Address(RVA = "0x1A3475C", Offset = "0x1A3475C", VA = "0x1A3475C")]
	private string MakeSendTimeStr(long tick)
	{
		return null;
	}

	[Token(Token = "0x6005866")]
	[Address(RVA = "0x1A343B8", Offset = "0x1A343B8", VA = "0x1A343B8")]
	private void BuildMessage(UILabel lblMsg, string msg)
	{
	}

	[Token(Token = "0x6005867")]
	[Address(RVA = "0x1A343E8", Offset = "0x1A343E8", VA = "0x1A343E8")]
	private void BuildProfileIcon(int profileIconId)
	{
	}

	[Token(Token = "0x6005868")]
	[Address(RVA = "0x1A344DC", Offset = "0x1A344DC", VA = "0x1A344DC")]
	private void BuildTitle(int titleId)
	{
	}

	[Token(Token = "0x6005869")]
	[Address(RVA = "0x1A34B24", Offset = "0x1A34B24", VA = "0x1A34B24")]
	public void OnClick_Info()
	{
	}

	[Token(Token = "0x600586A")]
	[Address(RVA = "0x1A34E34", Offset = "0x1A34E34", VA = "0x1A34E34")]
	private void OnDisable()
	{
	}
}
