using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x200004A")]
	internal interface IRewardBasedVideoAdClient
	{
		[Token(Token = "0x14000033")]
		event EventHandler<EventArgs> OnAdLoaded;

		[Token(Token = "0x14000034")]
		event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

		[Token(Token = "0x14000035")]
		event EventHandler<EventArgs> OnAdOpening;

		[Token(Token = "0x14000036")]
		event EventHandler<EventArgs> OnAdStarted;

		[Token(Token = "0x14000037")]
		event EventHandler<Reward> OnAdRewarded;

		[Token(Token = "0x14000038")]
		event EventHandler<EventArgs> OnAdClosed;

		[Token(Token = "0x14000039")]
		event EventHandler<EventArgs> OnAdLeavingApplication;

		[Token(Token = "0x6000240")]
		void CreateRewardBasedVideoAd();

		[Token(Token = "0x6000241")]
		void LoadAd(AdRequest request, string adUnitId);

		[Token(Token = "0x6000242")]
		bool IsLoaded();

		[Token(Token = "0x6000243")]
		void ShowRewardBasedVideoAd();
	}
}
