using System.Collections.Generic;
using Il2CppDummyDll;

namespace GoogleMobileAds.Common
{
	[Token(Token = "0x2000047")]
	internal interface ICustomNativeTemplateClient
	{
		[Token(Token = "0x600020D")]
		string GetTemplateId();

		[Token(Token = "0x600020E")]
		byte[] GetImageByteArray(string key);

		[Token(Token = "0x600020F")]
		List<string> GetAvailableAssetNames();

		[Token(Token = "0x6000210")]
		string GetText(string key);

		[Token(Token = "0x6000211")]
		void PerformClick(string assetName);

		[Token(Token = "0x6000212")]
		void RecordImpression();
	}
}
