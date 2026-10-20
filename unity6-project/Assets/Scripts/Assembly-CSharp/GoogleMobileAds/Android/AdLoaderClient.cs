using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x200004C")]
	public class AdLoaderClient : AndroidJavaProxy, IAdLoaderClient
	{
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xC")]
		private AndroidJavaObject adLoader;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x10")]
		private EventHandler<AdFailedToLoadEventArgs> m_OnAdFailedToLoad;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x14")]
		private EventHandler<CustomNativeEventArgs> m_OnCustomNativeTemplateAdLoaded;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Action<CustomNativeTemplateAd, string>> CustomNativeTemplateCallbacks__BackingField;

		[Token(Token = "0x1700004F")]
		private Dictionary<string, Action<CustomNativeTemplateAd, string>> CustomNativeTemplateCallbacks
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x1F389B4", Offset = "0x1F389B4", VA = "0x1F389B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x1F3899C", Offset = "0x1F3899C", VA = "0x1F3899C")]
			set
			{
			}
		}

		[Token(Token = "0x1400003A")]
		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x1F389BC", Offset = "0x1F389BC", VA = "0x1F389BC", Slot = "6")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1F38B48", Offset = "0x1F38B48", VA = "0x1F38B48", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x1400003B")]
		public event EventHandler<CustomNativeEventArgs> OnCustomNativeTemplateAdLoaded
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1F38CD4", Offset = "0x1F38CD4", VA = "0x1F38CD4", Slot = "8")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x1F38E60", Offset = "0x1F38E60", VA = "0x1F38E60", Slot = "9")]
			remove
			{
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1F38360", Offset = "0x1F38360", VA = "0x1F38360")]
		public AdLoaderClient(AdLoader unityAdLoader) : base((string)null)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1F38FEC", Offset = "0x1F38FEC", VA = "0x1F38FEC", Slot = "10")]
		public void LoadAd(AdRequest request)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1F3B118", Offset = "0x1F3B118", VA = "0x1F3B118")]
		public void onCustomTemplateAdLoaded(AndroidJavaObject ad)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1F3B330", Offset = "0x1F3B330", VA = "0x1F3B330")]
		private void onAdFailedToLoad(string errorReason)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1F3B4BC", Offset = "0x1F3B4BC", VA = "0x1F3B4BC")]
		public void onCustomClick(AndroidJavaObject ad, string assetName)
		{
		}
	}
}
