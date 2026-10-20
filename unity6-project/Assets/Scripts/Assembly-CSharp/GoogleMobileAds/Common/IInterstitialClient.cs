using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x2000048")]
	internal interface IInterstitialClient
	{
		[Token(Token = "0x14000029")]
		event EventHandler<EventArgs> OnAdLoaded;

		[Token(Token = "0x1400002A")]
		event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

		[Token(Token = "0x1400002B")]
		event EventHandler<EventArgs> OnAdOpening;

		[Token(Token = "0x1400002C")]
		event EventHandler<EventArgs> OnAdClosed;

		[Token(Token = "0x1400002D")]
		event EventHandler<EventArgs> OnAdLeavingApplication;

		[Token(Token = "0x600021D")]
		void CreateInterstitialAd(string adUnitId);

		[Token(Token = "0x600021E")]
		void LoadAd(AdRequest request);

		[Token(Token = "0x600021F")]
		bool IsLoaded();

		[Token(Token = "0x6000220")]
		void ShowInterstitial();

		[Token(Token = "0x6000221")]
		void DestroyInterstitial();
	}
}
