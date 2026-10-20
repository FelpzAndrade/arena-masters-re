using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Common;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000039")]
	public class BannerView
	{
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x8")]
		private IBannerClient client;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xC")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x14000004")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1F465D8", Offset = "0x1F465D8", VA = "0x1F465D8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1F46764", Offset = "0x1F46764", VA = "0x1F46764")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1F468F0", Offset = "0x1F468F0", VA = "0x1F468F0")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1F46A7C", Offset = "0x1F46A7C", VA = "0x1F46A7C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1F46C08", Offset = "0x1F46C08", VA = "0x1F46C08")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1F46D94", Offset = "0x1F46D94", VA = "0x1F46D94")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1F46F20", Offset = "0x1F46F20", VA = "0x1F46F20")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1F470AC", Offset = "0x1F470AC", VA = "0x1F470AC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1F47238", Offset = "0x1F47238", VA = "0x1F47238")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1F473C4", Offset = "0x1F473C4", VA = "0x1F473C4")]
			remove
			{
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1F45DD0", Offset = "0x1F45DD0", VA = "0x1F45DD0")]
		public BannerView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1F4647C", Offset = "0x1F4647C", VA = "0x1F4647C")]
		public BannerView(string adUnitId, AdSize adSize, int x, int y)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1F47550", Offset = "0x1F47550", VA = "0x1F47550")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1F47660", Offset = "0x1F47660", VA = "0x1F47660")]
		public void Hide()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1F47768", Offset = "0x1F47768", VA = "0x1F47768")]
		public void Show()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1F47870", Offset = "0x1F47870", VA = "0x1F47870")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1F45F9C", Offset = "0x1F45F9C", VA = "0x1F45F9C")]
		private void configureBannerEvents()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1F47978", Offset = "0x1F47978", VA = "0x1F47978")]
		private void _003CconfigureBannerEvents_003Em__B(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1F47A10", Offset = "0x1F47A10", VA = "0x1F47A10")]
		private void _003CconfigureBannerEvents_003Em__C(object sender, AdFailedToLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1F47AA8", Offset = "0x1F47AA8", VA = "0x1F47AA8")]
		private void _003CconfigureBannerEvents_003Em__D(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1F47B40", Offset = "0x1F47B40", VA = "0x1F47B40")]
		private void _003CconfigureBannerEvents_003Em__E(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1F47BD8", Offset = "0x1F47BD8", VA = "0x1F47BD8")]
		private void _003CconfigureBannerEvents_003Em__F(object sender, EventArgs args)
		{
		}
	}
}
