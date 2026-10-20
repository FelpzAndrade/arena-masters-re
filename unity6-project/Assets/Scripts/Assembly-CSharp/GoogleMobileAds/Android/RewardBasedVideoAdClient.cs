using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x2000052")]
	internal class RewardBasedVideoAdClient : AndroidJavaProxy, IRewardBasedVideoAdClient
	{
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xC")]
		private AndroidJavaObject androidRewardBasedVideo;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdStarted;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x24")]
		private EventHandler<Reward> m_OnAdRewarded;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x28")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x0")]
		private static EventHandler<EventArgs> _003C_003Ef__am_0024cache8;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x4")]
		private static EventHandler<AdFailedToLoadEventArgs> _003C_003Ef__am_0024cache9;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x8")]
		private static EventHandler<EventArgs> _003C_003Ef__am_0024cacheA;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xC")]
		private static EventHandler<EventArgs> _003C_003Ef__am_0024cacheB;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x10")]
		private static EventHandler<EventArgs> _003C_003Ef__am_0024cacheC;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x14")]
		private static EventHandler<Reward> _003C_003Ef__am_0024cacheD;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x18")]
		private static EventHandler<EventArgs> _003C_003Ef__am_0024cacheE;

		[Token(Token = "0x1400004B")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1F41F5C", Offset = "0x1F41F5C", VA = "0x1F41F5C", Slot = "6")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1F420E8", Offset = "0x1F420E8", VA = "0x1F420E8", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x1400004C")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1F42274", Offset = "0x1F42274", VA = "0x1F42274", Slot = "8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1F42400", Offset = "0x1F42400", VA = "0x1F42400", Slot = "9")]
			remove
			{
			}
		}

		[Token(Token = "0x1400004D")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1F4258C", Offset = "0x1F4258C", VA = "0x1F4258C", Slot = "10")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1F42718", Offset = "0x1F42718", VA = "0x1F42718", Slot = "11")]
			remove
			{
			}
		}

		[Token(Token = "0x1400004E")]
		public event EventHandler<EventArgs> OnAdStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1F428A4", Offset = "0x1F428A4", VA = "0x1F428A4", Slot = "12")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1F42A30", Offset = "0x1F42A30", VA = "0x1F42A30", Slot = "13")]
			remove
			{
			}
		}

		[Token(Token = "0x1400004F")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1F42BBC", Offset = "0x1F42BBC", VA = "0x1F42BBC", Slot = "16")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1F42D48", Offset = "0x1F42D48", VA = "0x1F42D48", Slot = "17")]
			remove
			{
			}
		}

		[Token(Token = "0x14000050")]
		public event EventHandler<Reward> OnAdRewarded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1F42ED4", Offset = "0x1F42ED4", VA = "0x1F42ED4", Slot = "14")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1F43060", Offset = "0x1F43060", VA = "0x1F43060", Slot = "15")]
			remove
			{
			}
		}

		[Token(Token = "0x14000051")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1F431EC", Offset = "0x1F431EC", VA = "0x1F431EC", Slot = "18")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1F43378", Offset = "0x1F43378", VA = "0x1F43378", Slot = "19")]
			remove
			{
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1F4194C", Offset = "0x1F4194C", VA = "0x1F4194C")]
		public RewardBasedVideoAdClient() : base((string)null)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1F43504", Offset = "0x1F43504", VA = "0x1F43504", Slot = "20")]
		public void CreateRewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1F435D0", Offset = "0x1F435D0", VA = "0x1F435D0", Slot = "21")]
		public void LoadAd(AdRequest request, string adUnitId)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1F43744", Offset = "0x1F43744", VA = "0x1F43744", Slot = "22")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1F4381C", Offset = "0x1F4381C", VA = "0x1F4381C", Slot = "23")]
		public void ShowRewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1F438E8", Offset = "0x1F438E8", VA = "0x1F438E8")]
		public void DestroyRewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1F439B4", Offset = "0x1F439B4", VA = "0x1F439B4")]
		private void onAdLoaded()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1F43A90", Offset = "0x1F43A90", VA = "0x1F43A90")]
		private void onAdFailedToLoad(string errorReason)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1F43B70", Offset = "0x1F43B70", VA = "0x1F43B70")]
		private void onAdOpened()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1F43C4C", Offset = "0x1F43C4C", VA = "0x1F43C4C")]
		private void onAdStarted()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1F43D28", Offset = "0x1F43D28", VA = "0x1F43D28")]
		private void onAdClosed()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1F43E04", Offset = "0x1F43E04", VA = "0x1F43E04")]
		private void onAdRewarded(string type, float amount)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1F43FB4", Offset = "0x1F43FB4", VA = "0x1F43FB4")]
		private void onAdLeftApplication()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1F44090", Offset = "0x1F44090", VA = "0x1F44090")]
		private static void _003COnAdLoaded_003Em__21(object P_0, EventArgs P_1)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1F44094", Offset = "0x1F44094", VA = "0x1F44094")]
		private static void _003COnAdFailedToLoad_003Em__22(object P_0, AdFailedToLoadEventArgs P_1)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1F44098", Offset = "0x1F44098", VA = "0x1F44098")]
		private static void _003COnAdOpening_003Em__23(object P_0, EventArgs P_1)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1F4409C", Offset = "0x1F4409C", VA = "0x1F4409C")]
		private static void _003COnAdStarted_003Em__24(object P_0, EventArgs P_1)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1F440A0", Offset = "0x1F440A0", VA = "0x1F440A0")]
		private static void _003COnAdClosed_003Em__25(object P_0, EventArgs P_1)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1F440A4", Offset = "0x1F440A4", VA = "0x1F440A4")]
		private static void _003COnAdRewarded_003Em__26(object P_0, Reward P_1)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1F440A8", Offset = "0x1F440A8", VA = "0x1F440A8")]
		private static void _003COnAdLeavingApplication_003Em__27(object P_0, EventArgs P_1)
		{
		}
	}
}
