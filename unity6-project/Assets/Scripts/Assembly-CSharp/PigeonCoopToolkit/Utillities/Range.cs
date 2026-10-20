using System;
using Il2CppDummyDll;

namespace PigeonCoopToolkit.Utillities
{
	[Serializable]
	[Token(Token = "0x2000344")]
	public class Range
	{
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x8")]
		public float Min;

		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0xC")]
		public float Max;

		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x1BB3548", Offset = "0x1BB3548", VA = "0x1BB3548")]
		public Range()
		{
		}

		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x1BB3550", Offset = "0x1BB3550", VA = "0x1BB3550")]
		public bool WithinRange(float value)
		{
			return default(bool);
		}
	}
}
