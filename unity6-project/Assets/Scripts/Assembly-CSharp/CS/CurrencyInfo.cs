using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ABB")]
	public class CurrencyInfo
	{
		[Token(Token = "0x4003248")]
		[FieldOffset(Offset = "0x8")]
		private Currency Currency__BackingField;

		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0xC")]
		private CSContentType ContentType__BackingField;

		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0x10")]
		private Stat.Type IncreaseStat__BackingField;

		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x14")]
		private Stat.Type DecreaseStat__BackingField;

		[Token(Token = "0x17000B2C")]
		public Currency Currency
		{
			[Token(Token = "0x6004EE1")]
			[Address(RVA = "0x1CDA524", Offset = "0x1CDA524", VA = "0x1CDA524")]
			get
			{
				return default(Currency);
			}
			[Token(Token = "0x6004EE2")]
			[Address(RVA = "0x1CDA504", Offset = "0x1CDA504", VA = "0x1CDA504")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B2D")]
		public CSContentType ContentType
		{
			[Token(Token = "0x6004EE3")]
			[Address(RVA = "0x1CDA52C", Offset = "0x1CDA52C", VA = "0x1CDA52C")]
			get
			{
				return default(CSContentType);
			}
			[Token(Token = "0x6004EE4")]
			[Address(RVA = "0x1CDA50C", Offset = "0x1CDA50C", VA = "0x1CDA50C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B2E")]
		public Stat.Type IncreaseStat
		{
			[Token(Token = "0x6004EE5")]
			[Address(RVA = "0x1CDA534", Offset = "0x1CDA534", VA = "0x1CDA534")]
			get
			{
				return default(Stat.Type);
			}
			[Token(Token = "0x6004EE6")]
			[Address(RVA = "0x1CDA514", Offset = "0x1CDA514", VA = "0x1CDA514")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B2F")]
		public Stat.Type DecreaseStat
		{
			[Token(Token = "0x6004EE7")]
			[Address(RVA = "0x1CDA53C", Offset = "0x1CDA53C", VA = "0x1CDA53C")]
			get
			{
				return default(Stat.Type);
			}
			[Token(Token = "0x6004EE8")]
			[Address(RVA = "0x1CDA51C", Offset = "0x1CDA51C", VA = "0x1CDA51C")]
			private set
			{
			}
		}

		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x1CDA4CC", Offset = "0x1CDA4CC", VA = "0x1CDA4CC")]
		public CurrencyInfo(Currency Currency, CSContentType ContentType, Stat.Type IncreaseStat, Stat.Type DecreaseStat)
		{
		}
	}
}
