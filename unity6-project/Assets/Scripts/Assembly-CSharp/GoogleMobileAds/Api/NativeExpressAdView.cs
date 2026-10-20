using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Common;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000041")]
	public class NativeExpressAdView
	{
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x8")]
		private INativeExpressAdClient client;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xC")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x1400000E")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x1F4A7A0", Offset = "0x1F4A7A0", VA = "0x1F4A7A0")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1F4A92C", Offset = "0x1F4A92C", VA = "0x1F4A92C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1F4AAB8", Offset = "0x1F4AAB8", VA = "0x1F4AAB8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1F4AC44", Offset = "0x1F4AC44", VA = "0x1F4AC44")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1F4ADD0", Offset = "0x1F4ADD0", VA = "0x1F4ADD0")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1F4AF5C", Offset = "0x1F4AF5C", VA = "0x1F4AF5C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1F4B0E8", Offset = "0x1F4B0E8", VA = "0x1F4B0E8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1F4B274", Offset = "0x1F4B274", VA = "0x1F4B274")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1F4B400", Offset = "0x1F4B400", VA = "0x1F4B400")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1F4B58C", Offset = "0x1F4B58C", VA = "0x1F4B58C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1F49F98", Offset = "0x1F49F98", VA = "0x1F49F98")]
		public NativeExpressAdView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1F4A644", Offset = "0x1F4A644", VA = "0x1F4A644")]
		public NativeExpressAdView(string adUnitId, AdSize adSize, int x, int y)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1F4B718", Offset = "0x1F4B718", VA = "0x1F4B718")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1F4B828", Offset = "0x1F4B828", VA = "0x1F4B828")]
		public void Hide()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1F4B930", Offset = "0x1F4B930", VA = "0x1F4B930")]
		public void Show()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1F4BA38", Offset = "0x1F4BA38", VA = "0x1F4BA38")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1F4A164", Offset = "0x1F4A164", VA = "0x1F4A164")]
		private void configureNativeExpressAdEvents()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1F4BB40", Offset = "0x1F4BB40", VA = "0x1F4BB40")]
		private void _003CconfigureNativeExpressAdEvents_003Em__15(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1F4BBD8", Offset = "0x1F4BBD8", VA = "0x1F4BBD8")]
		private void _003CconfigureNativeExpressAdEvents_003Em__16(object sender, AdFailedToLoadEventArgs args)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1F4BC70", Offset = "0x1F4BC70", VA = "0x1F4BC70")]
		private void _003CconfigureNativeExpressAdEvents_003Em__17(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1F4BD08", Offset = "0x1F4BD08", VA = "0x1F4BD08")]
		private void _003CconfigureNativeExpressAdEvents_003Em__18(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1F4BDA0", Offset = "0x1F4BDA0", VA = "0x1F4BDA0")]
		private void _003CconfigureNativeExpressAdEvents_003Em__19(object sender, EventArgs args)
		{
		}
	}
}
