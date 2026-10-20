using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CBA")]
public class XUITabView : UIBase
{
	[Token(Token = "0x40040BC")]
	[FieldOffset(Offset = "0xC")]
	public XUITab CloneTab;

	[Token(Token = "0x40040BD")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Gab;

	[Token(Token = "0x40040BE")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<object, XUITab> TabList;

	[Token(Token = "0x40040BF")]
	[FieldOffset(Offset = "0x1C")]
	private OnClick m_OnTabClicked;

	[Token(Token = "0x17000CD8")]
	public OnClick OnTabClicked
	{
		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x19335F8", Offset = "0x19335F8", VA = "0x19335F8")]
		set
		{
		}
	}

	[Token(Token = "0x6005BC7")]
	[Address(RVA = "0x193352C", Offset = "0x193352C", VA = "0x193352C")]
	public XUITabView()
	{
	}

	[Token(Token = "0x6005BC9")]
	[Address(RVA = "0x1933760", Offset = "0x1933760", VA = "0x1933760")]
	public void Awake()
	{
	}

	[Token(Token = "0x6005BCA")]
	[Address(RVA = "0x193384C", Offset = "0x193384C", VA = "0x193384C")]
	public XUITab CreateTab(object id, string title)
	{
		return null;
	}

	[Token(Token = "0x6005BCB")]
	[Address(RVA = "0x193394C", Offset = "0x193394C", VA = "0x193394C")]
	public XUITab AddTab(object id, string title)
	{
		return null;
	}

	[Token(Token = "0x6005BCC")]
	[Address(RVA = "0x1933974", Offset = "0x1933974", VA = "0x1933974")]
	public void AddTab(XUITab tab)
	{
	}

	[Token(Token = "0x6005BCD")]
	[Address(RVA = "0x1933B80", Offset = "0x1933B80", VA = "0x1933B80")]
	private Vector2 CalcTabPositionByIndex(XUITab tab, int index)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005BCE")]
	[Address(RVA = "0x1933C20", Offset = "0x1933C20", VA = "0x1933C20")]
	public void SetSelectTab(object id)
	{
	}

	[Token(Token = "0x6005BCF")]
	[Address(RVA = "0x1933DC8", Offset = "0x1933DC8", VA = "0x1933DC8")]
	public void SetNewTab(object id, bool isNew)
	{
	}

	[Token(Token = "0x6005BD0")]
	[Address(RVA = "0x1933EB4", Offset = "0x1933EB4", VA = "0x1933EB4")]
	public void SetLockTab(object id, bool isLock)
	{
	}

	[Token(Token = "0x6005BD1")]
	[Address(RVA = "0x1933FA0", Offset = "0x1933FA0", VA = "0x1933FA0")]
	public void Clear()
	{
	}
}
