using GoogleMobileAds.Api;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x2000053")]
	internal class Utils
	{
		[Token(Token = "0x4000161")]
		public const string AdListenerClassName = "com.google.android.gms.ads.AdListener";

		[Token(Token = "0x4000162")]
		public const string AdRequestClassName = "com.google.android.gms.ads.AdRequest";

		[Token(Token = "0x4000163")]
		public const string AdRequestBuilderClassName = "com.google.android.gms.ads.AdRequest$Builder";

		[Token(Token = "0x4000164")]
		public const string AdSizeClassName = "com.google.android.gms.ads.AdSize";

		[Token(Token = "0x4000165")]
		public const string AdMobExtrasClassName = "com.google.android.gms.ads.mediation.admob.AdMobExtras";

		[Token(Token = "0x4000166")]
		public const string PlayStorePurchaseListenerClassName = "com.google.android.gms.ads.purchase.PlayStorePurchaseListener";

		[Token(Token = "0x4000167")]
		public const string InAppPurchaseListenerClassName = "com.google.android.gms.ads.purchase.InAppPurchaseListener";

		[Token(Token = "0x4000168")]
		public const string BannerViewClassName = "com.google.unity.ads.Banner";

		[Token(Token = "0x4000169")]
		public const string InterstitialClassName = "com.google.unity.ads.Interstitial";

		[Token(Token = "0x400016A")]
		public const string RewardBasedVideoClassName = "com.google.unity.ads.RewardBasedVideo";

		[Token(Token = "0x400016B")]
		public const string NativeExpressAdViewClassName = "com.google.unity.ads.NativeExpressAd";

		[Token(Token = "0x400016C")]
		public const string NativeAdLoaderClassName = "com.google.unity.ads.NativeAdLoader";

		[Token(Token = "0x400016D")]
		public const string UnityAdListenerClassName = "com.google.unity.ads.UnityAdListener";

		[Token(Token = "0x400016E")]
		public const string UnityRewardBasedVideoAdListenerClassName = "com.google.unity.ads.UnityRewardBasedVideoAdListener";

		[Token(Token = "0x400016F")]
		public const string UnityCustomNativeAdListener = "com.google.unity.ads.UnityCustomNativeAdListener";

		[Token(Token = "0x4000170")]
		public const string PluginUtilsClassName = "com.google.unity.ads.PluginUtils";

		[Token(Token = "0x4000171")]
		public const string UnityActivityClassName = "com.unity3d.player.UnityPlayer";

		[Token(Token = "0x4000172")]
		public const string BundleClassName = "android.os.Bundle";

		[Token(Token = "0x4000173")]
		public const string DateClassName = "java.util.Date";

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1F440AC", Offset = "0x1F440AC", VA = "0x1F440AC")]
		public Utils()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1F3CA60", Offset = "0x1F3CA60", VA = "0x1F3CA60")]
		public static AndroidJavaObject GetAdSizeJavaObject(AdSize adSize)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1F3911C", Offset = "0x1F3911C", VA = "0x1F3911C")]
		public static AndroidJavaObject GetAdRequestJavaObject(AdRequest request)
		{
			return null;
		}
	}
}
