using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x2000046")]
	internal interface IBannerClient
	{
		[Token(Token = "0x14000024")]
		event EventHandler<EventArgs> OnAdLoaded;

		[Token(Token = "0x14000025")]
		event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

		[Token(Token = "0x14000026")]
		event EventHandler<EventArgs> OnAdOpening;

		[Token(Token = "0x14000027")]
		event EventHandler<EventArgs> OnAdClosed;

		[Token(Token = "0x14000028")]
		event EventHandler<EventArgs> OnAdLeavingApplication;

		[Token(Token = "0x6000207")]
		void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position);

		[Token(Token = "0x6000208")]
		void CreateBannerView(string adUnitId, AdSize adSize, int x, int y);

		[Token(Token = "0x6000209")]
		void LoadAd(AdRequest request);

		[Token(Token = "0x600020A")]
		void ShowBannerView();

		[Token(Token = "0x600020B")]
		void HideBannerView();

		[Token(Token = "0x600020C")]
		void DestroyBannerView();
	}
}
