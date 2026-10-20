using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x2000050")]
	internal class InterstitialClient : AndroidJavaProxy, IInterstitialClient
	{
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xC")]
		private AndroidJavaObject interstitial;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x14000041")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1F3E1F4", Offset = "0x1F3E1F4", VA = "0x1F3E1F4", Slot = "6")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1F3E380", Offset = "0x1F3E380", VA = "0x1F3E380", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x14000042")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1F3E50C", Offset = "0x1F3E50C", VA = "0x1F3E50C", Slot = "8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1F3E698", Offset = "0x1F3E698", VA = "0x1F3E698", Slot = "9")]
			remove
			{
			}
		}

		[Token(Token = "0x14000043")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1F3E824", Offset = "0x1F3E824", VA = "0x1F3E824", Slot = "10")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x1F3E9B0", Offset = "0x1F3E9B0", VA = "0x1F3E9B0", Slot = "11")]
			remove
			{
			}
		}

		[Token(Token = "0x14000044")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1F3EB3C", Offset = "0x1F3EB3C", VA = "0x1F3EB3C", Slot = "12")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1F3ECC8", Offset = "0x1F3ECC8", VA = "0x1F3ECC8", Slot = "13")]
			remove
			{
			}
		}

		[Token(Token = "0x14000045")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x1F3EE54", Offset = "0x1F3EE54", VA = "0x1F3EE54", Slot = "14")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1F3EFE0", Offset = "0x1F3EFE0", VA = "0x1F3EFE0", Slot = "15")]
			remove
			{
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1F3DFF4", Offset = "0x1F3DFF4", VA = "0x1F3DFF4")]
		public InterstitialClient() : base((string)null)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1F3F16C", Offset = "0x1F3F16C", VA = "0x1F3F16C", Slot = "16")]
		public void CreateInterstitialAd(string adUnitId)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1F3F290", Offset = "0x1F3F290", VA = "0x1F3F290", Slot = "17")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1F3F3C0", Offset = "0x1F3F3C0", VA = "0x1F3F3C0", Slot = "18")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1F3F498", Offset = "0x1F3F498", VA = "0x1F3F498", Slot = "19")]
		public void ShowInterstitial()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1F3F564", Offset = "0x1F3F564", VA = "0x1F3F564", Slot = "20")]
		public void DestroyInterstitial()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1F3F630", Offset = "0x1F3F630", VA = "0x1F3F630")]
		public void onAdLoaded()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1F3F70C", Offset = "0x1F3F70C", VA = "0x1F3F70C")]
		public void onAdFailedToLoad(string errorReason)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1F3F7EC", Offset = "0x1F3F7EC", VA = "0x1F3F7EC")]
		public void onAdOpened()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1F3F8C8", Offset = "0x1F3F8C8", VA = "0x1F3F8C8")]
		public void onAdClosed()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1F3F9A4", Offset = "0x1F3F9A4", VA = "0x1F3F9A4")]
		public void onAdLeftApplication()
		{
		}
	}
}
