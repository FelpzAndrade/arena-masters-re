using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EEE")]
public abstract class XUIPackageShopItemBase : MonoBehaviour
{
	[Token(Token = "0x4004F1C")]
	[FieldOffset(Offset = "0xC")]
	private int m_width;

	[Token(Token = "0x4004F1D")]
	[FieldOffset(Offset = "0x10")]
	private UIWidget m_widget;

	[Token(Token = "0x4004F1E")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprImg;

	[Token(Token = "0x4004F1F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblPackageName;

	[Token(Token = "0x4004F20")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblBuyAvailableCount;

	[Token(Token = "0x4004F21")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblRemainTime;

	[Token(Token = "0x4004F22")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goRemainRoot;

	[Token(Token = "0x4004F23")]
	[FieldOffset(Offset = "0x28")]
	public DateTime saleEndTime;

	[Token(Token = "0x4004F24")]
	[FieldOffset(Offset = "0x38")]
	public GameObject goDisable;

	[Token(Token = "0x4004F25")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblDisable;

	[Token(Token = "0x4004F26")]
	[FieldOffset(Offset = "0x40")]
	private Action<PackageShopInfo> m_buyClickAction;

	[Token(Token = "0x4004F27")]
	[FieldOffset(Offset = "0x44")]
	private Action<string, int> m_detailClickAction;

	[Token(Token = "0x4004F28")]
	[FieldOffset(Offset = "0x48")]
	public Action m_onRefresh;

	[Token(Token = "0x4004F29")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_Button btnBuy;

	[Token(Token = "0x4004F2A")]
	[FieldOffset(Offset = "0x50")]
	public XWidget_Button btnInfo;

	[Token(Token = "0x4004F2B")]
	[FieldOffset(Offset = "0x54")]
	protected PackageShopInfo m_info;

	[Token(Token = "0x4004F2C")]
	[FieldOffset(Offset = "0x58")]
	private bool HasSaleTime;

	[Token(Token = "0x4004F2D")]
	[FieldOffset(Offset = "0x59")]
	private bool sendRefresh;

	[Token(Token = "0x17000E25")]
	public int Width
	{
		[Token(Token = "0x6006F83")]
		[Address(RVA = "0x190743C", Offset = "0x190743C", VA = "0x190743C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006F82")]
	[Address(RVA = "0x1906528", Offset = "0x1906528", VA = "0x1906528")]
	protected XUIPackageShopItemBase()
	{
	}

	[Token(Token = "0x6006F84")]
	protected abstract void BuildContentInfo(List<CSContent> contentList);

	[Token(Token = "0x6006F85")]
	protected abstract void Reposition();

	[Token(Token = "0x6006F86")]
	[Address(RVA = "0x190754C", Offset = "0x190754C", VA = "0x190754C", Slot = "6")]
	public virtual void Show(PackageShopInfo info, Action<PackageShopInfo> buyClickAction, Action<string, int> detailClickAction, Action refreshAction)
	{
	}

	[Token(Token = "0x6006F87")]
	[Address(RVA = "0x190665C", Offset = "0x190665C", VA = "0x190665C", Slot = "7")]
	protected virtual void BuildImage(string path)
	{
	}

	[Token(Token = "0x6006F88")]
	[Address(RVA = "0x1907AF8", Offset = "0x1907AF8", VA = "0x1907AF8", Slot = "8")]
	protected virtual string GetBuyButtonText()
	{
		return null;
	}

	[Token(Token = "0x6006F89")]
	[Address(RVA = "0x1907820", Offset = "0x1907820", VA = "0x1907820")]
	private void Build(PackageShopInfo info)
	{
	}

	[Token(Token = "0x6006F8A")]
	[Address(RVA = "0x1907C7C", Offset = "0x1907C7C", VA = "0x1907C7C", Slot = "9")]
	protected virtual bool GetDisable(PackageShopInfo info, int buyedCount)
	{
		return default(bool);
	}

	[Token(Token = "0x6006F8B")]
	[Address(RVA = "0x1907B7C", Offset = "0x1907B7C", VA = "0x1907B7C")]
	protected int GetBuyedCount(PackageShopInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x6006F8C")]
	[Address(RVA = "0x1907CDC", Offset = "0x1907CDC", VA = "0x1907CDC", Slot = "10")]
	protected virtual string GetDisableText()
	{
		return null;
	}

	[Token(Token = "0x6006F8D")]
	[Address(RVA = "0x1907D60", Offset = "0x1907D60", VA = "0x1907D60", Slot = "11")]
	protected virtual void BuildDisable(bool isDisable)
	{
	}

	[Token(Token = "0x6006F8E")]
	[Address(RVA = "0x1907FB4", Offset = "0x1907FB4", VA = "0x1907FB4")]
	private double GetRemainSecond()
	{
		return default(double);
	}

	[Token(Token = "0x6006F8F")]
	[Address(RVA = "0x1908130", Offset = "0x1908130", VA = "0x1908130")]
	private void RefreshTimeText(double remainSec)
	{
	}

	[Token(Token = "0x6006F90")]
	[Address(RVA = "0x190778C", Offset = "0x190778C", VA = "0x190778C")]
	public void Update()
	{
	}

	[Token(Token = "0x6006F91")]
	[Address(RVA = "0x19083D4", Offset = "0x19083D4", VA = "0x19083D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006F92")]
	[Address(RVA = "0x1908558", Offset = "0x1908558", VA = "0x1908558")]
	public void OnClick_BuyButton()
	{
	}

	[Token(Token = "0x6006F93")]
	[Address(RVA = "0x1909410", Offset = "0x1909410", VA = "0x1909410")]
	public void OnClick_DetailButton()
	{
	}

	[Token(Token = "0x6006F94")]
	[Address(RVA = "0x1908654", Offset = "0x1908654", VA = "0x1908654")]
	private bool TryCheckBuyItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6006F95")]
	[Address(RVA = "0x1908AC4", Offset = "0x1908AC4", VA = "0x1908AC4")]
	private int GetOwnedCharacterCount(PackageShopInfo item)
	{
		return default(int);
	}

	[Token(Token = "0x6006F96")]
	[Address(RVA = "0x1908F8C", Offset = "0x1908F8C", VA = "0x1908F8C")]
	private int GetOwnedPetCount(PackageShopInfo item)
	{
		return default(int);
	}

	[Token(Token = "0x6006F97")]
	[Address(RVA = "0x19088EC", Offset = "0x19088EC", VA = "0x19088EC")]
	private bool IsOwnedSkin(PackageShopInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x6006F98")]
	[Address(RVA = "0x19094D4", Offset = "0x19094D4", VA = "0x19094D4")]
	private string GetOwnedSkinWarningMsg()
	{
		return null;
	}

	[Token(Token = "0x6006F99")]
	[Address(RVA = "0x19099D8", Offset = "0x19099D8", VA = "0x19099D8")]
	private string GetOwnedCharWarningMsg(int ownCharCount)
	{
		return null;
	}

	[Token(Token = "0x6006F9A")]
	[Address(RVA = "0x1909B74", Offset = "0x1909B74", VA = "0x1909B74")]
	private string GetOwnedPetWarningMsg(int ownCharCount)
	{
		return null;
	}

	[Token(Token = "0x6006F9B")]
	[Address(RVA = "0x1909150", Offset = "0x1909150", VA = "0x1909150")]
	private void ShowMessagePopupPetWarning(int ownedPetCnt)
	{
	}

	[Token(Token = "0x6006F9C")]
	[Address(RVA = "0x1908C88", Offset = "0x1908C88", VA = "0x1908C88")]
	private void ShowMessagePopupOwnedSkinWarning(bool IsOwnedSkin, int ownedCharCnt)
	{
	}

	[Token(Token = "0x6006F9D")]
	[Address(RVA = "0x1909678", Offset = "0x1909678", VA = "0x1909678")]
	private int GetOwnedSkinReturnArenaCoin()
	{
		return default(int);
	}

	[Token(Token = "0x6006F9E")]
	[Address(RVA = "0x1909D10", Offset = "0x1909D10", VA = "0x1909D10")]
	private void OnResponse(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6006F9F")]
	[Address(RVA = "0x1909FDC", Offset = "0x1909FDC", VA = "0x1909FDC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006FA0")]
	[Address(RVA = "0x190A244", Offset = "0x190A244", VA = "0x190A244")]
	private void _003CShowMessagePopupPetWarning_003Em__44E()
	{
	}

	[Token(Token = "0x6006FA1")]
	[Address(RVA = "0x190A310", Offset = "0x190A310", VA = "0x190A310")]
	private void _003CShowMessagePopupOwnedSkinWarning_003Em__44F()
	{
	}
}
