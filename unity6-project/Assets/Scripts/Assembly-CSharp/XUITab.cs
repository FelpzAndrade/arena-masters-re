using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CB9")]
public class XUITab : UIBase
{
	[Token(Token = "0x40040B5")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x40040B6")]
	[FieldOffset(Offset = "0x10")]
	public UISprite Selected;

	[Token(Token = "0x40040B7")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Unselected;

	[Token(Token = "0x40040B8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject New;

	[Token(Token = "0x40040B9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Lock;

	[Token(Token = "0x40040BA")]
	[FieldOffset(Offset = "0x20")]
	public OnClick OnTabClicked;

	[Token(Token = "0x40040BB")]
	[FieldOffset(Offset = "0x24")]
	private object Id__BackingField;

	[Token(Token = "0x17000CD7")]
	public object Id
	{
		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0x1932F74", Offset = "0x1932F74", VA = "0x1932F74")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0x1932F7C", Offset = "0x1932F7C", VA = "0x1932F7C")]
		set
		{
		}
	}

	[Token(Token = "0x6005BBE")]
	[Address(RVA = "0x1932F6C", Offset = "0x1932F6C", VA = "0x1932F6C")]
	public XUITab()
	{
	}

	[Token(Token = "0x6005BC1")]
	[Address(RVA = "0x1932F84", Offset = "0x1932F84", VA = "0x1932F84")]
	public XUITab Clone()
	{
		return null;
	}

	[Token(Token = "0x6005BC2")]
	[Address(RVA = "0x1933118", Offset = "0x1933118", VA = "0x1933118")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x6005BC3")]
	[Address(RVA = "0x19331E8", Offset = "0x19331E8", VA = "0x19331E8")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6005BC4")]
	[Address(RVA = "0x1933350", Offset = "0x1933350", VA = "0x1933350")]
	public void SetNew(bool isNew)
	{
	}

	[Token(Token = "0x6005BC5")]
	[Address(RVA = "0x1933430", Offset = "0x1933430", VA = "0x1933430")]
	public void SetLock(bool isLock)
	{
	}

	[Token(Token = "0x6005BC6")]
	[Address(RVA = "0x1933510", Offset = "0x1933510", VA = "0x1933510")]
	public void OnClick_Tab()
	{
	}
}
