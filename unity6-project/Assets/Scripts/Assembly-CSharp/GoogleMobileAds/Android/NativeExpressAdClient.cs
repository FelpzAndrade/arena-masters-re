using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x2000051")]
	internal class NativeExpressAdClient : AndroidJavaProxy, INativeExpressAdClient
	{
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC")]
		private AndroidJavaObject nativeExpressAdView;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x14000046")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1F3FC80", Offset = "0x1F3FC80", VA = "0x1F3FC80", Slot = "6")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1F3FE0C", Offset = "0x1F3FE0C", VA = "0x1F3FE0C", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x14000047")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1F3FF98", Offset = "0x1F3FF98", VA = "0x1F3FF98", Slot = "8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1F40124", Offset = "0x1F40124", VA = "0x1F40124", Slot = "9")]
			remove
			{
			}
		}

		[Token(Token = "0x14000048")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1F402B0", Offset = "0x1F402B0", VA = "0x1F402B0", Slot = "10")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1F4043C", Offset = "0x1F4043C", VA = "0x1F4043C", Slot = "11")]
			remove
			{
			}
		}

		[Token(Token = "0x14000049")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1F405C8", Offset = "0x1F405C8", VA = "0x1F405C8", Slot = "12")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1F40754", Offset = "0x1F40754", VA = "0x1F40754", Slot = "13")]
			remove
			{
			}
		}

		[Token(Token = "0x1400004A")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1F408E0", Offset = "0x1F408E0", VA = "0x1F408E0", Slot = "14")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1F40A6C", Offset = "0x1F40A6C", VA = "0x1F40A6C", Slot = "15")]
			remove
			{
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1F3FA80", Offset = "0x1F3FA80", VA = "0x1F3FA80")]
		public NativeExpressAdClient() : base((string)null)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1F40BF8", Offset = "0x1F40BF8", VA = "0x1F40BF8", Slot = "16")]
		public void CreateNativeExpressAdView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1F40DE4", Offset = "0x1F40DE4", VA = "0x1F40DE4", Slot = "17")]
		public void CreateNativeExpressAdView(string adUnitId, AdSize adSize, int x, int y)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1F41038", Offset = "0x1F41038", VA = "0x1F41038", Slot = "18")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1F41168", Offset = "0x1F41168", VA = "0x1F41168")]
		public void SetAdSize(AdSize adSize)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1F41298", Offset = "0x1F41298", VA = "0x1F41298", Slot = "19")]
		public void ShowNativeExpressAdView()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1F41364", Offset = "0x1F41364", VA = "0x1F41364", Slot = "20")]
		public void HideNativeExpressAdView()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1F41430", Offset = "0x1F41430", VA = "0x1F41430", Slot = "21")]
		public void DestroyNativeExpressAdView()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1F414FC", Offset = "0x1F414FC", VA = "0x1F414FC")]
		public void onAdLoaded()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1F415D8", Offset = "0x1F415D8", VA = "0x1F415D8")]
		public void onAdFailedToLoad(string errorReason)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1F416B8", Offset = "0x1F416B8", VA = "0x1F416B8")]
		public void onAdOpened()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1F41794", Offset = "0x1F41794", VA = "0x1F41794")]
		public void onAdClosed()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1F41870", Offset = "0x1F41870", VA = "0x1F41870")]
		public void onAdLeftApplication()
		{
		}
	}
}
