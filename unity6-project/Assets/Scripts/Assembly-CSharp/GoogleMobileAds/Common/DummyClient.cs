using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x2000044")]
	internal class DummyClient : IAdLoaderClient, IBannerClient, IInterstitialClient, INativeExpressAdClient, IRewardBasedVideoAdClient
	{
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xC")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<EventArgs> m_OnAdStarted;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<Reward> m_OnAdRewarded;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x24")]
		private EventHandler<CustomNativeEventArgs> m_OnCustomNativeTemplateAdLoaded;

		[Token(Token = "0x1700004E")]
		public string UserId
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1F4FE1C", Offset = "0x1F4FE1C", VA = "0x1F4FE1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x1F4FFB4", Offset = "0x1F4FFB4", VA = "0x1F4FFB4")]
			set
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1F4E55C", Offset = "0x1F4E55C", VA = "0x1F4E55C", Slot = "56")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x1F4E6E8", Offset = "0x1F4E6E8", VA = "0x1F4E6E8", Slot = "57")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x1F4E874", Offset = "0x1F4E874", VA = "0x1F4E874", Slot = "58")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x1F4EA00", Offset = "0x1F4EA00", VA = "0x1F4EA00", Slot = "59")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x1F4EB8C", Offset = "0x1F4EB8C", VA = "0x1F4EB8C", Slot = "60")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x1F4ED18", Offset = "0x1F4ED18", VA = "0x1F4ED18", Slot = "61")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event EventHandler<EventArgs> OnAdStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x1F4EEA4", Offset = "0x1F4EEA4", VA = "0x1F4EEA4", Slot = "62")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1F4F030", Offset = "0x1F4F030", VA = "0x1F4F030", Slot = "63")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1F4F1BC", Offset = "0x1F4F1BC", VA = "0x1F4F1BC", Slot = "66")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1F4F348", Offset = "0x1F4F348", VA = "0x1F4F348", Slot = "67")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event EventHandler<Reward> OnAdRewarded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1F4F4D4", Offset = "0x1F4F4D4", VA = "0x1F4F4D4", Slot = "64")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x1F4F660", Offset = "0x1F4F660", VA = "0x1F4F660", Slot = "65")]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1F4F7EC", Offset = "0x1F4F7EC", VA = "0x1F4F7EC", Slot = "68")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x1F4F978", Offset = "0x1F4F978", VA = "0x1F4F978", Slot = "69")]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public event EventHandler<CustomNativeEventArgs> OnCustomNativeTemplateAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1F4FB04", Offset = "0x1F4FB04", VA = "0x1F4FB04", Slot = "6")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1F4FC90", Offset = "0x1F4FC90", VA = "0x1F4FC90", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1F4E3D0", Offset = "0x1F4E3D0", VA = "0x1F4E3D0")]
		public DummyClient()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1F50130", Offset = "0x1F50130", VA = "0x1F50130", Slot = "19")]
		public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1F502AC", Offset = "0x1F502AC", VA = "0x1F502AC", Slot = "20")]
		public void CreateBannerView(string adUnitId, AdSize adSize, int positionX, int positionY)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1F50428", Offset = "0x1F50428", VA = "0x1F50428", Slot = "52")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1F505A4", Offset = "0x1F505A4", VA = "0x1F505A4", Slot = "22")]
		public void ShowBannerView()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1F50720", Offset = "0x1F50720", VA = "0x1F50720", Slot = "23")]
		public void HideBannerView()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1F5089C", Offset = "0x1F5089C", VA = "0x1F5089C", Slot = "24")]
		public void DestroyBannerView()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1F50A18", Offset = "0x1F50A18", VA = "0x1F50A18", Slot = "35")]
		public void CreateInterstitialAd(string adUnitId)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1F50B94", Offset = "0x1F50B94", VA = "0x1F50B94", Slot = "72")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1F50D14", Offset = "0x1F50D14", VA = "0x1F50D14", Slot = "38")]
		public void ShowInterstitial()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1F50E90", Offset = "0x1F50E90", VA = "0x1F50E90", Slot = "39")]
		public void DestroyInterstitial()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1F5100C", Offset = "0x1F5100C", VA = "0x1F5100C", Slot = "70")]
		public void CreateRewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1F51188", Offset = "0x1F51188", VA = "0x1F51188")]
		public void SetUserId(string userId)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1F51304", Offset = "0x1F51304", VA = "0x1F51304", Slot = "71")]
		public void LoadAd(AdRequest request, string adUnitId)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1F51480", Offset = "0x1F51480", VA = "0x1F51480")]
		public void DestroyRewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1F515FC", Offset = "0x1F515FC", VA = "0x1F515FC", Slot = "73")]
		public void ShowRewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1F51778", Offset = "0x1F51778", VA = "0x1F51778")]
		public void CreateAdLoader(AdLoader.Builder builder)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1F518F4", Offset = "0x1F518F4", VA = "0x1F518F4")]
		public void Load(AdRequest request)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1F51A70", Offset = "0x1F51A70", VA = "0x1F51A70", Slot = "50")]
		public void CreateNativeExpressAdView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1F51BEC", Offset = "0x1F51BEC", VA = "0x1F51BEC", Slot = "51")]
		public void CreateNativeExpressAdView(string adUnitId, AdSize adSize, int positionX, int positionY)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1F51D68", Offset = "0x1F51D68", VA = "0x1F51D68")]
		public void SetAdSize(AdSize adSize)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1F51EE4", Offset = "0x1F51EE4", VA = "0x1F51EE4", Slot = "53")]
		public void ShowNativeExpressAdView()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1F52060", Offset = "0x1F52060", VA = "0x1F52060", Slot = "54")]
		public void HideNativeExpressAdView()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1F521DC", Offset = "0x1F521DC", VA = "0x1F521DC", Slot = "55")]
		public void DestroyNativeExpressAdView()
		{
		}
	}
}
