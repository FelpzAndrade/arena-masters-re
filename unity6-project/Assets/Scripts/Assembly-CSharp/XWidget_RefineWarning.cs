using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EE5")]
public class XWidget_RefineWarning : XUIBaseWidget
{
	[Token(Token = "0x4004EDC")]
	[FieldOffset(Offset = "0x1C")]
	public Transform newItemIconParent;

	[Token(Token = "0x4004EDD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel newItemName;

	[Token(Token = "0x4004EDE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblComment;

	[Token(Token = "0x4004EDF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblSubComment;

	[Token(Token = "0x4004EE0")]
	[FieldOffset(Offset = "0x2C")]
	protected Action m_action;

	[Token(Token = "0x4004EE1")]
	[FieldOffset(Offset = "0x30")]
	protected XWidget_ItemIcon m_newItemIcon;

	[Token(Token = "0x17000E21")]
	public XWidget_ItemIcon NewItemIcon
	{
		[Token(Token = "0x6006F31")]
		[Address(RVA = "0x13389E0", Offset = "0x13389E0", VA = "0x13389E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006F30")]
	[Address(RVA = "0x13389D8", Offset = "0x13389D8", VA = "0x13389D8")]
	public XWidget_RefineWarning()
	{
	}

	[Token(Token = "0x6006F32")]
	[Address(RVA = "0x1338BB0", Offset = "0x1338BB0", VA = "0x1338BB0")]
	public void Show(string commentText, string subCommentText, XItem newItem, Action action)
	{
	}

	[Token(Token = "0x6006F33")]
	[Address(RVA = "0x1338D88", Offset = "0x1338D88", VA = "0x1338D88")]
	public void Action()
	{
	}
}
