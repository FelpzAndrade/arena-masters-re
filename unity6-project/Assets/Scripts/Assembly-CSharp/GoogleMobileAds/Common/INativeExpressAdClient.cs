using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x2000049")]
	internal interface INativeExpressAdClient
	{
		[Token(Token = "0x1400002E")]
		event EventHandler<EventArgs> OnAdLoaded;

		[Token(Token = "0x1400002F")]
		event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

		[Token(Token = "0x14000030")]
		event EventHandler<EventArgs> OnAdOpening;

		[Token(Token = "0x14000031")]
		event EventHandler<EventArgs> OnAdClosed;

		[Token(Token = "0x14000032")]
		event EventHandler<EventArgs> OnAdLeavingApplication;

		[Token(Token = "0x600022C")]
		void CreateNativeExpressAdView(string adUnitId, AdSize adSize, AdPosition position);

		[Token(Token = "0x600022D")]
		void CreateNativeExpressAdView(string adUnitId, AdSize adSize, int x, int y);

		[Token(Token = "0x600022E")]
		void LoadAd(AdRequest request);

		[Token(Token = "0x600022F")]
		void ShowNativeExpressAdView();

		[Token(Token = "0x6000230")]
		void HideNativeExpressAdView();

		[Token(Token = "0x6000231")]
		void DestroyNativeExpressAdView();
	}
}
