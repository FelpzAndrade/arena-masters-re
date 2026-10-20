using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C9E")]
public class XWidget_ShopBonusItem : MonoBehaviour
{
	[Token(Token = "0x400403A")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprItemIcon;

	[Token(Token = "0x400403B")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblOriginCount;

	[Token(Token = "0x400403C")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprBounsItemIcon;

	[Token(Token = "0x400403D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblBonusCount;

	[Token(Token = "0x6005B21")]
	[Address(RVA = "0x1B0493C", Offset = "0x1B0493C", VA = "0x1B0493C")]
	public XWidget_ShopBonusItem()
	{
	}

	[Token(Token = "0x6005B22")]
	[Address(RVA = "0x1B04944", Offset = "0x1B04944", VA = "0x1B04944")]
	public void Show(IShopItem item)
	{
	}

	[Token(Token = "0x6005B23")]
	[Address(RVA = "0x1B04BFC", Offset = "0x1B04BFC", VA = "0x1B04BFC")]
	public void Hide()
	{
	}
}
