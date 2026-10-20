using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000966")]
	public class RotationShopItems
	{
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0x8")]
		private int ProductId__BackingField;

		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0x10")]
		private DateTime EndTime__BackingField;

		[Token(Token = "0x17000AAC")]
		public int ProductId
		{
			[Token(Token = "0x6004BB1")]
			[Address(RVA = "0x21C3318", Offset = "0x21C3318", VA = "0x21C3318")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BB2")]
			[Address(RVA = "0x21C3320", Offset = "0x21C3320", VA = "0x21C3320")]
			set
			{
			}
		}

		[Token(Token = "0x17000AAD")]
		public DateTime EndTime
		{
			[Token(Token = "0x6004BB3")]
			[Address(RVA = "0x21C3328", Offset = "0x21C3328", VA = "0x21C3328")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004BB4")]
			[Address(RVA = "0x21C3338", Offset = "0x21C3338", VA = "0x21C3338")]
			set
			{
			}
		}

		[Token(Token = "0x6004BB0")]
		[Address(RVA = "0x21C3310", Offset = "0x21C3310", VA = "0x21C3310")]
		public RotationShopItems()
		{
		}
	}
}
