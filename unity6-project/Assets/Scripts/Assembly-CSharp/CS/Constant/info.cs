using System;
using Il2CppDummyDll;

namespace CS.Constant
{
	[Serializable]
	[Token(Token = "0x2000AE0")]
	public sealed class info
	{
		[Token(Token = "0x4003489")]
		[FieldOffset(Offset = "0x8")]
		public string strName;

		[Token(Token = "0x400348A")]
		[FieldOffset(Offset = "0xC")]
		public string strValue;

		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x23ED200", Offset = "0x23ED200", VA = "0x23ED200")]
		public info()
		{
		}
	}
}
