using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

[Token(Token = "0x2000EE8")]
public class XWidget_StallChargeConfirmForAd : XWidget_StallChargeConfirm, IAdmobListener
{
	[Token(Token = "0x4004EE9")]
	[FieldOffset(Offset = "0x34")]
	public XButton btnAdCharge;

	[Token(Token = "0x4004EEA")]
	[FieldOffset(Offset = "0x38")]
	public XButton btnAdDisable;

	[Token(Token = "0x6006F3D")]
	[Address(RVA = "0x1B0E7C8", Offset = "0x1B0E7C8", VA = "0x1B0E7C8")]
	public XWidget_StallChargeConfirmForAd()
	{
	}

	[Token(Token = "0x6006F3E")]
	[Address(RVA = "0x1B0E7D0", Offset = "0x1B0E7D0", VA = "0x1B0E7D0", Slot = "26")]
	protected override void Build()
	{
	}

	[Token(Token = "0x6006F3F")]
	[Address(RVA = "0x1B0E7EC", Offset = "0x1B0E7EC", VA = "0x1B0E7EC")]
	private void SetButtons()
	{
	}

	[Token(Token = "0x6006F40")]
	[Address(RVA = "0x1B0ECB8", Offset = "0x1B0ECB8", VA = "0x1B0ECB8")]
	public void OnClick_AdvertisementCharge()
	{
	}

	[Token(Token = "0x6006F41")]
	[Address(RVA = "0x1B0EE10", Offset = "0x1B0EE10", VA = "0x1B0EE10", Slot = "27")]
	public void OnAdRequested(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6006F42")]
	[Address(RVA = "0x1B0EE14", Offset = "0x1B0EE14", VA = "0x1B0EE14", Slot = "28")]
	public void OnAdLoaded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6006F43")]
	[Address(RVA = "0x1B0EE18", Offset = "0x1B0EE18", VA = "0x1B0EE18", Slot = "29")]
	public void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}

	[Token(Token = "0x6006F44")]
	[Address(RVA = "0x1B0EE1C", Offset = "0x1B0EE1C", VA = "0x1B0EE1C", Slot = "30")]
	public void OnAdOpening(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6006F45")]
	[Address(RVA = "0x1B0EE20", Offset = "0x1B0EE20", VA = "0x1B0EE20", Slot = "31")]
	public void OnAdStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6006F46")]
	[Address(RVA = "0x1B0EE24", Offset = "0x1B0EE24", VA = "0x1B0EE24", Slot = "32")]
	public void OnAdRewarded(object sender, Reward args)
	{
	}

	[Token(Token = "0x6006F47")]
	[Address(RVA = "0x1B0EE2C", Offset = "0x1B0EE2C", VA = "0x1B0EE2C", Slot = "33")]
	public void OnAdClosed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6006F48")]
	[Address(RVA = "0x1B0EE30", Offset = "0x1B0EE30", VA = "0x1B0EE30", Slot = "34")]
	public void OnAdLeavingApplication(object sender, EventArgs args)
	{
	}
}
