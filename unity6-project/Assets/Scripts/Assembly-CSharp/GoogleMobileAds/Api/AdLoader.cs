using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Common;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000033")]
	public class AdLoader
	{
		[Token(Token = "0x2000034")]
		public class Builder
		{
			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x8")]
			private string AdUnitId__BackingField;

			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0xC")]
			private HashSet<NativeAdType> AdTypes__BackingField;

			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x10")]
			private HashSet<string> TemplateIds__BackingField;

			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x14")]
			private Dictionary<string, Action<CustomNativeTemplateAd, string>> CustomNativeTemplateClickHandlers__BackingField;

			[Token(Token = "0x17000031")]
			internal string AdUnitId
			{
				[Token(Token = "0x6000127")]
				[Address(RVA = "0x1F444A0", Offset = "0x1F444A0", VA = "0x1F444A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000128")]
				[Address(RVA = "0x1F44EFC", Offset = "0x1F44EFC", VA = "0x1F44EFC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			internal HashSet<NativeAdType> AdTypes
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0x1F444D0", Offset = "0x1F444D0", VA = "0x1F444D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600012A")]
				[Address(RVA = "0x1F44F04", Offset = "0x1F44F04", VA = "0x1F44F04")]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			internal HashSet<string> TemplateIds
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x1F444C0", Offset = "0x1F444C0", VA = "0x1F444C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x1F44F0C", Offset = "0x1F44F0C", VA = "0x1F44F0C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			internal Dictionary<string, Action<CustomNativeTemplateAd, string>> CustomNativeTemplateClickHandlers
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0x1F444B0", Offset = "0x1F444B0", VA = "0x1F444B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600012E")]
				[Address(RVA = "0x1F44F14", Offset = "0x1F44F14", VA = "0x1F44F14")]
				private set
				{
				}
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1F44DE0", Offset = "0x1F44DE0", VA = "0x1F44DE0")]
			public Builder(string adUnitId)
			{
			}

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1F44F1C", Offset = "0x1F44F1C", VA = "0x1F44F1C")]
			public Builder ForCustomNativeAd(string templateId)
			{
				return null;
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1F44FF0", Offset = "0x1F44FF0", VA = "0x1F44FF0")]
			public Builder ForCustomNativeAd(string templateId, Action<CustomNativeTemplateAd, string> callback)
			{
				return null;
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1F450FC", Offset = "0x1F450FC", VA = "0x1F450FC")]
			public AdLoader Build()
			{
				return null;
			}
		}

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x8")]
		private IAdLoaderClient adLoaderClient;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0xC")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<CustomNativeEventArgs> m_OnCustomNativeTemplateAdLoaded;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<string, Action<CustomNativeTemplateAd, string>> CustomNativeTemplateClickHandlers__BackingField;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18")]
		private string AdUnitId__BackingField;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x1C")]
		private HashSet<NativeAdType> AdTypes__BackingField;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<string> TemplateIds__BackingField;

		[Token(Token = "0x1700002D")]
		public Dictionary<string, Action<CustomNativeTemplateAd, string>> CustomNativeTemplateClickHandlers
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1F38994", Offset = "0x1F38994", VA = "0x1F38994")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1F444B8", Offset = "0x1F444B8", VA = "0x1F444B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public string AdUnitId
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1F3898C", Offset = "0x1F3898C", VA = "0x1F3898C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1F444A8", Offset = "0x1F444A8", VA = "0x1F444A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public HashSet<NativeAdType> AdTypes
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1F389A4", Offset = "0x1F389A4", VA = "0x1F389A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1F444D8", Offset = "0x1F444D8", VA = "0x1F444D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public HashSet<string> TemplateIds
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1F389AC", Offset = "0x1F389AC", VA = "0x1F389AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1F444C8", Offset = "0x1F444C8", VA = "0x1F444C8")]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1F44570", Offset = "0x1F44570", VA = "0x1F44570")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1F446FC", Offset = "0x1F446FC", VA = "0x1F446FC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event EventHandler<CustomNativeEventArgs> OnCustomNativeTemplateAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1F44888", Offset = "0x1F44888", VA = "0x1F44888")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1F44A14", Offset = "0x1F44A14", VA = "0x1F44A14")]
			remove
			{
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1F44130", Offset = "0x1F44130", VA = "0x1F44130")]
		private AdLoader(Builder builder)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1F44BA0", Offset = "0x1F44BA0", VA = "0x1F44BA0")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1F44CB0", Offset = "0x1F44CB0", VA = "0x1F44CB0")]
		private void _003CAdLoader_003Em__9(object sender, CustomNativeEventArgs args)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1F44D48", Offset = "0x1F44D48", VA = "0x1F44D48")]
		private void _003CAdLoader_003Em__A(object sender, AdFailedToLoadEventArgs args)
		{
		}
	}
}
