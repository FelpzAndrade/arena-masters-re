using System.Collections.Generic;
using GoogleMobileAds.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x200004E")]
	public class CustomNativeTemplateClient : ICustomNativeTemplateClient
	{
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x8")]
		private AndroidJavaObject customNativeAd;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1F3B2E8", Offset = "0x1F3B2E8", VA = "0x1F3B2E8")]
		public CustomNativeTemplateClient(AndroidJavaObject customNativeAd)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1F3D934", Offset = "0x1F3D934", VA = "0x1F3D934", Slot = "6")]
		public List<string> GetAvailableAssetNames()
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1F3DA48", Offset = "0x1F3DA48", VA = "0x1F3DA48", Slot = "4")]
		public string GetTemplateId()
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1F3DB20", Offset = "0x1F3DB20", VA = "0x1F3DB20", Slot = "5")]
		public byte[] GetImageByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1F3DC68", Offset = "0x1F3DC68", VA = "0x1F3DC68", Slot = "7")]
		public string GetText(string key)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1F3DE04", Offset = "0x1F3DE04", VA = "0x1F3DE04", Slot = "8")]
		public void PerformClick(string assetName)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1F3DF28", Offset = "0x1F3DF28", VA = "0x1F3DF28", Slot = "9")]
		public void RecordImpression()
		{
		}
	}
}
