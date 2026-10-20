using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B7D")]
	public class CSTimeInterval
	{
		[Token(Token = "0x4003A19")]
		[FieldOffset(Offset = "0x8")]
		public string strID;

		[Token(Token = "0x4003A1A")]
		[FieldOffset(Offset = "0xC")]
		public int nIntervalMinutes;

		[Token(Token = "0x4003A1B")]
		[FieldOffset(Offset = "0x10")]
		public int nMaxCount;

		[Token(Token = "0x4003A1C")]
		[FieldOffset(Offset = "0x14")]
		public int nResetHourTime;

		[Token(Token = "0x4003A1D")]
		[FieldOffset(Offset = "0x18")]
		public IntervalType intervalType;

		[Token(Token = "0x6005351")]
		[Address(RVA = "0x1CD9218", Offset = "0x1CD9218", VA = "0x1CD9218")]
		public CSTimeInterval()
		{
		}

		[Token(Token = "0x6005352")]
		[Address(RVA = "0x1CC81C0", Offset = "0x1CC81C0", VA = "0x1CC81C0")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x6005353")]
		[Address(RVA = "0x1CD92E4", Offset = "0x1CD92E4", VA = "0x1CD92E4")]
		public bool IsConsecutively()
		{
			return default(bool);
		}
	}
}
