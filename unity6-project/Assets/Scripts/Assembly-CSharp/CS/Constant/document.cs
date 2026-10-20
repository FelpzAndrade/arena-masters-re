using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS.Constant
{
	[Serializable]
	[Token(Token = "0x2000AE1")]
	public sealed class document
	{
		[Token(Token = "0x400348B")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<key, string> m_ValueMap;

		[Token(Token = "0x400348C")]
		[FieldOffset(Offset = "0xC")]
		public ArrayList dataList;

		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x23ECD88", Offset = "0x23ECD88", VA = "0x23ECD88")]
		public document()
		{
		}

		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x23ECE58", Offset = "0x23ECE58", VA = "0x23ECE58")]
		public void Add(info i)
		{
		}

		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x23ECEB8", Offset = "0x23ECEB8", VA = "0x23ECEB8")]
		public bool ContainsKey(key k)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F92")]
		[Address(RVA = "0x23ECF58", Offset = "0x23ECF58", VA = "0x23ECF58")]
		public string GetValue(key k)
		{
			return null;
		}

		[Token(Token = "0x6004F93")]
		[Address(RVA = "0x23ED088", Offset = "0x23ED088", VA = "0x23ED088")]
		public int GetValueInt(key k)
		{
			return default(int);
		}

		[Token(Token = "0x6004F94")]
		[Address(RVA = "0x23ED144", Offset = "0x23ED144", VA = "0x23ED144")]
		public double GetValueDouble(key k)
		{
			return default(double);
		}
	}
}
