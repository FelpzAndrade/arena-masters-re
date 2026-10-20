using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200086C")]
	public class CSBroadcastExtraData
	{
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<int, object> Param;

		[Token(Token = "0x40026AD")]
		[FieldOffset(Offset = "0xC")]
		private string To__BackingField;

		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0x10")]
		private string From__BackingField;

		[Token(Token = "0x1700096E")]
		public string To
		{
			[Token(Token = "0x6004584")]
			[Address(RVA = "0x23F0768", Offset = "0x23F0768", VA = "0x23F0768")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004585")]
			[Address(RVA = "0x23F0758", Offset = "0x23F0758", VA = "0x23F0758")]
			set
			{
			}
		}

		[Token(Token = "0x1700096F")]
		public string From
		{
			[Token(Token = "0x6004586")]
			[Address(RVA = "0x23F0770", Offset = "0x23F0770", VA = "0x23F0770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004587")]
			[Address(RVA = "0x23F0760", Offset = "0x23F0760", VA = "0x23F0760")]
			set
			{
			}
		}

		[Token(Token = "0x6004583")]
		[Address(RVA = "0x23F06A4", Offset = "0x23F06A4", VA = "0x23F06A4")]
		public CSBroadcastExtraData()
		{
		}
	}
}
