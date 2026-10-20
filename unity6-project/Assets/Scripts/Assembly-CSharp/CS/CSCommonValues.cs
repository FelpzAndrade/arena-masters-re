using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AB5")]
	public class CSCommonValues
	{
		[Token(Token = "0x4003237")]
		[FieldOffset(Offset = "0x8")]
		public string key;

		[Token(Token = "0x4003238")]
		[FieldOffset(Offset = "0xC")]
		public string value;

		[Token(Token = "0x6004EBC")]
		[Address(RVA = "0x2228AC0", Offset = "0x2228AC0", VA = "0x2228AC0")]
		public CSCommonValues()
		{
		}
	}
}
