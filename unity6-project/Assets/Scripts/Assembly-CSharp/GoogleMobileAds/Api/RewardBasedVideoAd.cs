using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Common;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000043")]
	public class RewardBasedVideoAd
	{
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x8")]
		private IRewardBasedVideoAdClient client;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		private static RewardBasedVideoAd instance;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0xC")]
		private EventHandler<EventArgs> m_OnAdLoaded;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<EventArgs> m_OnAdOpening;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<EventArgs> m_OnAdStarted;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<EventArgs> m_OnAdClosed;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x20")]
		private EventHandler<Reward> m_OnAdRewarded;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x24")]
		private EventHandler<EventArgs> m_OnAdLeavingApplication;

		[Token(Token = "0x1700004D")]
		public static RewardBasedVideoAd Instance
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1F4DBC0", Offset = "0x1F4DBC0", VA = "0x1F4DBC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000013")]
		public event EventHandler<EventArgs> OnAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1F4C618", Offset = "0x1F4C618", VA = "0x1F4C618")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1F4C7A4", Offset = "0x1F4C7A4", VA = "0x1F4C7A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1F4C930", Offset = "0x1F4C930", VA = "0x1F4C930")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1F4CABC", Offset = "0x1F4CABC", VA = "0x1F4CABC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event EventHandler<EventArgs> OnAdOpening
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1F4CC48", Offset = "0x1F4CC48", VA = "0x1F4CC48")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1F4CDD4", Offset = "0x1F4CDD4", VA = "0x1F4CDD4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event EventHandler<EventArgs> OnAdStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1F4CF60", Offset = "0x1F4CF60", VA = "0x1F4CF60")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1F4D0EC", Offset = "0x1F4D0EC", VA = "0x1F4D0EC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event EventHandler<EventArgs> OnAdClosed
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1F4D278", Offset = "0x1F4D278", VA = "0x1F4D278")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1F4D404", Offset = "0x1F4D404", VA = "0x1F4D404")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event EventHandler<Reward> OnAdRewarded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1F4D590", Offset = "0x1F4D590", VA = "0x1F4D590")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1F4D71C", Offset = "0x1F4D71C", VA = "0x1F4D71C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event EventHandler<EventArgs> OnAdLeavingApplication
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x1F4D8A8", Offset = "0x1F4D8A8", VA = "0x1F4D8A8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1F4DA34", Offset = "0x1F4DA34", VA = "0x1F4DA34")]
			remove
			{
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1F4BE4C", Offset = "0x1F4BE4C", VA = "0x1F4BE4C")]
		private RewardBasedVideoAd()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1F4DC80", Offset = "0x1F4DC80", VA = "0x1F4DC80")]
		public void LoadAd(AdRequest request, string adUnitId)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1F4DD98", Offset = "0x1F4DD98", VA = "0x1F4DD98")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1F4DEA0", Offset = "0x1F4DEA0", VA = "0x1F4DEA0")]
		public void Show()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1F4DFA8", Offset = "0x1F4DFA8", VA = "0x1F4DFA8")]
		private void _003CRewardBasedVideoAd_003Em__1A(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1F4E040", Offset = "0x1F4E040", VA = "0x1F4E040")]
		private void _003CRewardBasedVideoAd_003Em__1B(object sender, AdFailedToLoadEventArgs args)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1F4E0D8", Offset = "0x1F4E0D8", VA = "0x1F4E0D8")]
		private void _003CRewardBasedVideoAd_003Em__1C(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1F4E170", Offset = "0x1F4E170", VA = "0x1F4E170")]
		private void _003CRewardBasedVideoAd_003Em__1D(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1F4E208", Offset = "0x1F4E208", VA = "0x1F4E208")]
		private void _003CRewardBasedVideoAd_003Em__1E(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1F4E2A0", Offset = "0x1F4E2A0", VA = "0x1F4E2A0")]
		private void _003CRewardBasedVideoAd_003Em__1F(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1F4E338", Offset = "0x1F4E338", VA = "0x1F4E338")]
		private void _003CRewardBasedVideoAd_003Em__20(object sender, Reward args)
		{
		}
	}
}
