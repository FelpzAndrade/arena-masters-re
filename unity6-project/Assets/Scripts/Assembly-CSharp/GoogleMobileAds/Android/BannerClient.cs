using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x200004D")]
	internal class BannerClient : AndroidJavaProxy, IBannerClient
	{
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xC")]
		private AndroidJavaObject bannerView;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x1400003C")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1F3B8FC", Offset = "0x1F3B8FC", VA = "0x1F3B8FC", Slot = "6")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1F3BA88", Offset = "0x1F3BA88", VA = "0x1F3BA88", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003D")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1F3BC14", Offset = "0x1F3BC14", VA = "0x1F3BC14", Slot = "8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1F3BDA0", Offset = "0x1F3BDA0", VA = "0x1F3BDA0", Slot = "9")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003E")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1F3BF2C", Offset = "0x1F3BF2C", VA = "0x1F3BF2C", Slot = "10")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x1F3C0B8", Offset = "0x1F3C0B8", VA = "0x1F3C0B8", Slot = "11")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003F")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1F3C244", Offset = "0x1F3C244", VA = "0x1F3C244", Slot = "12")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1F3C3D0", Offset = "0x1F3C3D0", VA = "0x1F3C3D0", Slot = "13")]
			remove
			{
			}
		}

		[Token(Token = "0x14000040")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1F3C55C", Offset = "0x1F3C55C", VA = "0x1F3C55C", Slot = "14")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1F3C6E8", Offset = "0x1F3C6E8", VA = "0x1F3C6E8", Slot = "15")]
			remove
			{
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1F3B6FC", Offset = "0x1F3B6FC", VA = "0x1F3B6FC")]
		public BannerClient() : base((string)null)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1F3C874", Offset = "0x1F3C874", VA = "0x1F3C874", Slot = "16")]
		public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1F3CCB8", Offset = "0x1F3CCB8", VA = "0x1F3CCB8", Slot = "17")]
		public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1F3CF0C", Offset = "0x1F3CF0C", VA = "0x1F3CF0C", Slot = "18")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1F3D03C", Offset = "0x1F3D03C", VA = "0x1F3D03C", Slot = "19")]
		public void ShowBannerView()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1F3D108", Offset = "0x1F3D108", VA = "0x1F3D108", Slot = "20")]
		public void HideBannerView()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1F3D1D4", Offset = "0x1F3D1D4", VA = "0x1F3D1D4", Slot = "21")]
		public void DestroyBannerView()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1F3D2A0", Offset = "0x1F3D2A0", VA = "0x1F3D2A0")]
		public void onAdLoaded()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1F3D37C", Offset = "0x1F3D37C", VA = "0x1F3D37C")]
		public void onAdFailedToLoad(string errorReason)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1F3D45C", Offset = "0x1F3D45C", VA = "0x1F3D45C")]
		public void onAdOpened()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1F3D538", Offset = "0x1F3D538", VA = "0x1F3D538")]
		public void onAdClosed()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1F3D614", Offset = "0x1F3D614", VA = "0x1F3D614")]
		public void onAdLeftApplication()
		{
		}
	}
}
