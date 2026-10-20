using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using Il2CppDummyDll;

namespace GoogleMobileAds
{
	[Token(Token = "0x2000054")]
	internal class GoogleMobileAdsClientFactory
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1F52360", Offset = "0x1F52360", VA = "0x1F52360")]
		public GoogleMobileAdsClientFactory()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1F45F14", Offset = "0x1F45F14", VA = "0x1F45F14")]
		internal static IBannerClient BuildBannerClient()
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1F48868", Offset = "0x1F48868", VA = "0x1F48868")]
		internal static IInterstitialClient BuildInterstitialClient()
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1F4C590", Offset = "0x1F4C590", VA = "0x1F4C590")]
		internal static IRewardBasedVideoAdClient BuildRewardBasedVideoAdClient()
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1F444E0", Offset = "0x1F444E0", VA = "0x1F444E0")]
		internal static IAdLoaderClient BuildAdLoaderClient(AdLoader adLoader)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1F4A0DC", Offset = "0x1F4A0DC", VA = "0x1F4A0DC")]
		internal static INativeExpressAdClient BuildNativeExpressAdClient()
		{
			return null;
		}
	}
}
