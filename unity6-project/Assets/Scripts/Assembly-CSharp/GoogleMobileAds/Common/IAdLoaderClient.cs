using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x2000045")]
	internal interface IAdLoaderClient
	{
		[Token(Token = "0x14000022")]
		event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

		[Token(Token = "0x14000023")]
		event EventHandler<CustomNativeEventArgs> OnCustomNativeTemplateAdLoaded;

		[Token(Token = "0x60001FC")]
		void LoadAd(AdRequest request);
	}
}
