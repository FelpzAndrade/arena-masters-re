using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EC5")]
public class XWidget_BetterOptionPopup : XUIButtons
{
	[Token(Token = "0x4004D94")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblTitle;

	[Token(Token = "0x4004D95")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblMessage;

	[Token(Token = "0x4004D96")]
	[FieldOffset(Offset = "0x38")]
	public Transform changeOptionStatParent;

	[Token(Token = "0x4004D97")]
	[FieldOffset(Offset = "0x3C")]
	private XWidget_OptionStatSwitch m_changeOptionStat;

	[Token(Token = "0x17000E14")]
	public XWidget_OptionStatSwitch changeOptionStat
	{
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0x15BC514", Offset = "0x15BC514", VA = "0x15BC514")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E14")]
	[Address(RVA = "0x15BC50C", Offset = "0x15BC50C", VA = "0x15BC50C")]
	public XWidget_BetterOptionPopup()
	{
	}

	[Token(Token = "0x6006E16")]
	[Address(RVA = "0x15BC738", Offset = "0x15BC738", VA = "0x15BC738")]
	public void Show(string strTitle, string strMessage, XMessageBoxButtons nButtons, Action delegateOK, XItem item, int curOptionID, Dictionary<int, bool> changeOptionIDs)
	{
	}
}
