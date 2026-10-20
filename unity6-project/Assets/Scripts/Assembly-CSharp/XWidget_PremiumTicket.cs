using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FD1")]
public class XWidget_PremiumTicket : MonoBehaviour
{
	[Token(Token = "0x4005413")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4005414")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblText;

	[Token(Token = "0x4005415")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_OnPress callBack;

	[Token(Token = "0x4005416")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goTweenRoot;

	[Token(Token = "0x4005417")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblChargeInfo;

	[Token(Token = "0x4005418")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x4005419")]
	[FieldOffset(Offset = "0x24")]
	private IBaseLobbyNotiIconData m_IconData;

	[Token(Token = "0x400541A")]
	[FieldOffset(Offset = "0x28")]
	private Action onHide;

	[Token(Token = "0x60075D3")]
	[Address(RVA = "0x131E2D0", Offset = "0x131E2D0", VA = "0x131E2D0")]
	public XWidget_PremiumTicket()
	{
	}

	[Token(Token = "0x60075D4")]
	[Address(RVA = "0x131E2D8", Offset = "0x131E2D8", VA = "0x131E2D8")]
	public void Awake()
	{
	}

	[Token(Token = "0x60075D5")]
	[Address(RVA = "0x131E3DC", Offset = "0x131E3DC", VA = "0x131E3DC")]
	public void ShowEnterChargeInfo()
	{
	}

	[Token(Token = "0x60075D6")]
	[Address(RVA = "0x131E44C", Offset = "0x131E44C", VA = "0x131E44C")]
	public void HideEnterChargeInfo()
	{
	}

	[Token(Token = "0x60075D7")]
	[Address(RVA = "0x131E478", Offset = "0x131E478", VA = "0x131E478")]
	private void Init(IBaseLobbyNotiIconData iconData, Action onHide, string spritecColorHex = "")
	{
	}

	[Token(Token = "0x60075D8")]
	[Address(RVA = "0x131E9A0", Offset = "0x131E9A0", VA = "0x131E9A0")]
	public void InitForPremiumTicket(PremiumTicketData ticketData, Action onHide)
	{
	}

	[Token(Token = "0x60075D9")]
	[Address(RVA = "0x131EBE0", Offset = "0x131EBE0", VA = "0x131EBE0")]
	public void InitForHotTime(CSEventSystemInfo eventSystemInfo, Action onHide)
	{
	}

	[Token(Token = "0x60075DA")]
	[Address(RVA = "0x131ECDC", Offset = "0x131ECDC", VA = "0x131ECDC")]
	public void InitForFusionDiscount(CSEventSystemInfo eventSystemInfo, Action onHide)
	{
	}

	[Token(Token = "0x60075DB")]
	[Address(RVA = "0x131EDA0", Offset = "0x131EDA0", VA = "0x131EDA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60075DC")]
	[Address(RVA = "0x131E7AC", Offset = "0x131E7AC", VA = "0x131E7AC")]
	public bool RefreshText()
	{
		return default(bool);
	}
}
