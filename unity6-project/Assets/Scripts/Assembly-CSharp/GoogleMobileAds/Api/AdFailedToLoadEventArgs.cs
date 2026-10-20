using System;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000031")]
	public class AdFailedToLoadEventArgs : EventArgs
	{
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x8")]
		private string Message__BackingField;

		[Token(Token = "0x1700002C")]
		public string Message
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1F44128", Offset = "0x1F44128", VA = "0x1F44128")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1F3B4B4", Offset = "0x1F3B4B4", VA = "0x1F3B4B4")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1F3B410", Offset = "0x1F3B410", VA = "0x1F3B410")]
		public AdFailedToLoadEventArgs()
		{
		}
	}
}
