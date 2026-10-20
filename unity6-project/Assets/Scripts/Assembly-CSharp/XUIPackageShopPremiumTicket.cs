using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000EF0")]
public class XUIPackageShopPremiumTicket : XUIPackageShopItemBase
{
	[Token(Token = "0x2000EF1")]
	private sealed class _003CBuildPremiumTicketDayEffect_003Ec__AnonStorey21F
	{
		[Token(Token = "0x4004F35")]
		[FieldOffset(Offset = "0x8")]
		internal PremiumTicketInfo info;

		[Token(Token = "0x4004F36")]
		[FieldOffset(Offset = "0xC")]
		internal XUIPackageShopPremiumTicket _003C_003Ef__this;

		[Token(Token = "0x6006FB7")]
		[Address(RVA = "0x190B05C", Offset = "0x190B05C", VA = "0x190B05C")]
		public _003CBuildPremiumTicketDayEffect_003Ec__AnonStorey21F()
		{
		}

		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0x190B6EC", Offset = "0x190B6EC", VA = "0x190B6EC")]
		internal string _003C_003Em__450()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EF2")]
	private sealed class _003CBuildPremiumTicketDayEffect_003Ec__AnonStorey220
	{
		[Token(Token = "0x4004F37")]
		[FieldOffset(Offset = "0x8")]
		internal PremiumTicketContent contentInfo;

		[Token(Token = "0x4004F38")]
		[FieldOffset(Offset = "0xC")]
		internal XUIPackageShopPremiumTicket _003C_003Ef__this;

		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0x190B064", Offset = "0x190B064", VA = "0x190B064")]
		public _003CBuildPremiumTicketDayEffect_003Ec__AnonStorey220()
		{
		}

		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0x190B884", Offset = "0x190B884", VA = "0x190B884")]
		internal string _003C_003Em__451()
		{
			return null;
		}
	}

	[Token(Token = "0x4004F32")]
	[FieldOffset(Offset = "0x5C")]
	public XWiget_GridBuilder immediatelyContent;

	[Token(Token = "0x4004F33")]
	[FieldOffset(Offset = "0x60")]
	public XWiget_GridBuilder everyDayContent;

	[Token(Token = "0x4004F34")]
	[FieldOffset(Offset = "0x64")]
	public XWidget_CashBuyInfo cashBuyInfo;

	[Token(Token = "0x6006FAB")]
	[Address(RVA = "0x190A3DC", Offset = "0x190A3DC", VA = "0x190A3DC")]
	public XUIPackageShopPremiumTicket()
	{
	}

	[Token(Token = "0x6006FAC")]
	[Address(RVA = "0x190A3EC", Offset = "0x190A3EC", VA = "0x190A3EC", Slot = "6")]
	public override void Show(PackageShopInfo info, Action<PackageShopInfo> buyClickAction, Action<string, int> detailClickAction, Action refreshAction)
	{
	}

	[Token(Token = "0x6006FAD")]
	[Address(RVA = "0x190A41C", Offset = "0x190A41C", VA = "0x190A41C")]
	private void BuildActiveCashBuyInfo()
	{
	}

	[Token(Token = "0x6006FAE")]
	[Address(RVA = "0x190A4FC", Offset = "0x190A4FC", VA = "0x190A4FC", Slot = "11")]
	protected override void BuildDisable(bool isDisable)
	{
	}

	[Token(Token = "0x6006FAF")]
	[Address(RVA = "0x190A6E8", Offset = "0x190A6E8", VA = "0x190A6E8", Slot = "4")]
	protected override void BuildContentInfo(List<CSContent> contentList)
	{
	}

	[Token(Token = "0x6006FB0")]
	[Address(RVA = "0x190AF44", Offset = "0x190AF44", VA = "0x190AF44", Slot = "5")]
	protected override void Reposition()
	{
	}

	[Token(Token = "0x6006FB1")]
	[Address(RVA = "0x190AFD8", Offset = "0x190AFD8", VA = "0x190AFD8", Slot = "10")]
	protected override string GetDisableText()
	{
		return null;
	}

	[Token(Token = "0x6006FB2")]
	[Address(RVA = "0x190AA0C", Offset = "0x190AA0C", VA = "0x190AA0C")]
	private void BuildPremiumTicketDayEffect(int premiumTicketID)
	{
	}

	[Token(Token = "0x6006FB3")]
	[Address(RVA = "0x190B06C", Offset = "0x190B06C", VA = "0x190B06C", Slot = "9")]
	protected override bool GetDisable(PackageShopInfo info, int buyedCount)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FB4")]
	[Address(RVA = "0x190B354", Offset = "0x190B354", VA = "0x190B354")]
	private string GetPremiumProvideContentLocalizeText(CSContentType provideContentType)
	{
		return null;
	}

	[Token(Token = "0x6006FB5")]
	[Address(RVA = "0x190B45C", Offset = "0x190B45C", VA = "0x190B45C", Slot = "8")]
	protected override string GetBuyButtonText()
	{
		return null;
	}

	[Token(Token = "0x6006FB6")]
	[Address(RVA = "0x190B5B8", Offset = "0x190B5B8", VA = "0x190B5B8")]
	public void OnClick_RefundDetailPopupShow()
	{
	}
}
