using System.Collections.Generic;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x200003B")]
	public class CustomNativeTemplateAd
	{
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x8")]
		private ICustomNativeTemplateClient client;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1F3B308", Offset = "0x1F3B308", VA = "0x1F3B308")]
		internal CustomNativeTemplateAd(ICustomNativeTemplateClient client)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1F47C78", Offset = "0x1F47C78", VA = "0x1F47C78")]
		public List<string> GetAvailableAssetNames()
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1F3B5F8", Offset = "0x1F3B5F8", VA = "0x1F3B5F8")]
		public string GetCustomTemplateId()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1F47D80", Offset = "0x1F47D80", VA = "0x1F47D80")]
		public Texture2D GetTexture2D(string key)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1F47FB4", Offset = "0x1F47FB4", VA = "0x1F47FB4")]
		public string GetText(string key)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1F480C4", Offset = "0x1F480C4", VA = "0x1F480C4")]
		public void PerformClick(string assetName)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1F481D4", Offset = "0x1F481D4", VA = "0x1F481D4")]
		public void RecordImpression()
		{
		}
	}
}
