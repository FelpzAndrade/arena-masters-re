using System.Collections.Generic;
using CS.Constant;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AE7")]
	public class AttendanceOptions
	{
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x8")]
		private int ReturnerDay__BackingField;

		[Token(Token = "0x40034E1")]
		[FieldOffset(Offset = "0xC")]
		private int ReturnerResetDay__BackingField;

		[Token(Token = "0x17000BAD")]
		public int ReturnerDay
		{
			[Token(Token = "0x6005076")]
			[Address(RVA = "0x23E7C30", Offset = "0x23E7C30", VA = "0x23E7C30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005077")]
			[Address(RVA = "0x23E7C20", Offset = "0x23E7C20", VA = "0x23E7C20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BAE")]
		public int ReturnerResetDay
		{
			[Token(Token = "0x6005078")]
			[Address(RVA = "0x23E7C38", Offset = "0x23E7C38", VA = "0x23E7C38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6005079")]
			[Address(RVA = "0x23E7C28", Offset = "0x23E7C28", VA = "0x23E7C28")]
			private set
			{
			}
		}

		[Token(Token = "0x6005075")]
		[Address(RVA = "0x23E7B3C", Offset = "0x23E7B3C", VA = "0x23E7B3C")]
		public AttendanceOptions(Dictionary<key, string> source)
		{
		}
	}
}
