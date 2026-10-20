using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001017")]
internal class XUIArenaShopItem : UIBase
{
	[Token(Token = "0x4005635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string prefabName;

	[Token(Token = "0x4005636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x4005637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform iconParent;

	[Token(Token = "0x4005638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XWidget_ContentIcon ItemIcon;

	[Token(Token = "0x4005639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UI2DSprite sprPriceIcon;

	[Token(Token = "0x400563A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblPriceCost;

	[Token(Token = "0x400563B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XUIGachaInfo GachaInfo;

	[Token(Token = "0x400563C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject goSoldOut;

	[Token(Token = "0x400563D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_isActive;

	[Token(Token = "0x400563E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private CSArenaShopItem Item__BackingField;

	[Token(Token = "0x17000EF6")]
	public CSArenaShopItem Item
	{
		[Token(Token = "0x6007806")]
		[Address(RVA = "0x1A29F48", Offset = "0x1A29F48", VA = "0x1A29F48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007807")]
		[Address(RVA = "0x1A29F50", Offset = "0x1A29F50", VA = "0x1A29F50")]
		set
		{
		}
	}

	[Token(Token = "0x6007804")]
	[Address(RVA = "0x1A29EB0", Offset = "0x1A29EB0", VA = "0x1A29EB0")]
	public XUIArenaShopItem()
	{
	}

	[Token(Token = "0x6007808")]
	[Address(RVA = "0x1A29F58", Offset = "0x1A29F58", VA = "0x1A29F58")]
	public static XUIArenaShopItem Create(CSArenaShopItem item)
	{
		return null;
	}

	[Token(Token = "0x6007809")]
	[Address(RVA = "0x1A2A190", Offset = "0x1A2A190", VA = "0x1A2A190")]
	public void Build()
	{
	}

	[Token(Token = "0x600780A")]
	[Address(RVA = "0x1A2A1B4", Offset = "0x1A2A1B4", VA = "0x1A2A1B4", Slot = "12")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x600780B")]
	[Address(RVA = "0x1A2A1F4", Offset = "0x1A2A1F4", VA = "0x1A2A1F4")]
	private void SetName()
	{
	}

	[Token(Token = "0x600780C")]
	[Address(RVA = "0x1A2A344", Offset = "0x1A2A344", VA = "0x1A2A344")]
	private void SetItem()
	{
	}

	[Token(Token = "0x600780D")]
	[Address(RVA = "0x1A2A488", Offset = "0x1A2A488", VA = "0x1A2A488")]
	private void SetPrice()
	{
	}

	[Token(Token = "0x600780E")]
	[Address(RVA = "0x1A2A6C4", Offset = "0x1A2A6C4", VA = "0x1A2A6C4")]
	private void SetGachaInfo()
	{
	}

	[Token(Token = "0x600780F")]
	[Address(RVA = "0x1A2A7EC", Offset = "0x1A2A7EC", VA = "0x1A2A7EC")]
	public void OnClick_Detail()
	{
	}

	[Token(Token = "0x6007810")]
	[Address(RVA = "0x1A2AA60", Offset = "0x1A2AA60", VA = "0x1A2AA60")]
	public void OnClick_Buy()
	{
	}
}
