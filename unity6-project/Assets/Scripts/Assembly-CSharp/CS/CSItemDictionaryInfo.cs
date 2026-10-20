using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B08")]
	public class CSItemDictionaryInfo
	{
		[Token(Token = "0x400364C")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x6005131")]
		[Address(RVA = "0x2235838", Offset = "0x2235838", VA = "0x2235838")]
		public CSItemDictionaryInfo()
		{
		}

		[Token(Token = "0x6005132")]
		[Address(RVA = "0x2235840", Offset = "0x2235840", VA = "0x2235840")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
