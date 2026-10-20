using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Common;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x200003F")]
	public class InterstitialAd
	{
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x8")]
		private IInterstitialClient client;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xC")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x14000009")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1F488F0", Offset = "0x1F488F0", VA = "0x1F488F0")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1F48A7C", Offset = "0x1F48A7C", VA = "0x1F48A7C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1F48C08", Offset = "0x1F48C08", VA = "0x1F48C08")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1F48D94", Offset = "0x1F48D94", VA = "0x1F48D94")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1F48F20", Offset = "0x1F48F20", VA = "0x1F48F20")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1F490AC", Offset = "0x1F490AC", VA = "0x1F490AC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1F49238", Offset = "0x1F49238", VA = "0x1F49238")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1F493C4", Offset = "0x1F493C4", VA = "0x1F493C4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1F49550", Offset = "0x1F49550", VA = "0x1F49550")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1F496DC", Offset = "0x1F496DC", VA = "0x1F496DC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1F482DC", Offset = "0x1F482DC", VA = "0x1F482DC")]
		public InterstitialAd(string adUnitId)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1F49868", Offset = "0x1F49868", VA = "0x1F49868")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1F49978", Offset = "0x1F49978", VA = "0x1F49978")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1F49A80", Offset = "0x1F49A80", VA = "0x1F49A80")]
		public void Show()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1F49B88", Offset = "0x1F49B88", VA = "0x1F49B88")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1F49C90", Offset = "0x1F49C90", VA = "0x1F49C90")]
		private void _003CInterstitialAd_003Em__10(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1F49D28", Offset = "0x1F49D28", VA = "0x1F49D28")]
		private void _003CInterstitialAd_003Em__11(object sender, AdFailedToLoadEventArgs args)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1F49DC0", Offset = "0x1F49DC0", VA = "0x1F49DC0")]
		private void _003CInterstitialAd_003Em__12(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1F49E58", Offset = "0x1F49E58", VA = "0x1F49E58")]
		private void _003CInterstitialAd_003Em__13(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1F49EF0", Offset = "0x1F49EF0", VA = "0x1F49EF0")]
		private void _003CInterstitialAd_003Em__14(object sender, EventArgs args)
		{
		}
	}
}
