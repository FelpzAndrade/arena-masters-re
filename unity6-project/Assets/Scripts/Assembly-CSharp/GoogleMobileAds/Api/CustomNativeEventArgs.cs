using System;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x200003A")]
	public class CustomNativeEventArgs : EventArgs
	{
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x8")]
		private CustomNativeTemplateAd nativeAd__BackingField;

		[Token(Token = "0x17000046")]
		public CustomNativeTemplateAd nativeAd
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1F47C70", Offset = "0x1F47C70", VA = "0x1F47C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1F3B328", Offset = "0x1F3B328", VA = "0x1F3B328")]
			set
			{
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1F3B244", Offset = "0x1F3B244", VA = "0x1F3B244")]
		public CustomNativeEventArgs()
		{
		}
	}
}
