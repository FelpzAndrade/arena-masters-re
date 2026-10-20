using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A10")]
	[AnonymousCommand]
	public class CSNetCommand_NJ_GetCurrency : CSNetCommand
	{
		[Token(Token = "0x2000A11")]
		public class ResultData
		{
			[Token(Token = "0x4002FD3")]
			[FieldOffset(Offset = "0x8")]
			private string Npsn__BackingField;

			[Token(Token = "0x4002FD4")]
			[FieldOffset(Offset = "0xC")]
			private int GoldPaid__BackingField;

			[Token(Token = "0x4002FD5")]
			[FieldOffset(Offset = "0x10")]
			private int CrystalPaid__BackingField;

			[Token(Token = "0x17000AF4")]
			public string Npsn
			{
				[Token(Token = "0x6004D59")]
				[Address(RVA = "0x2449418", Offset = "0x2449418", VA = "0x2449418")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004D5A")]
				[Address(RVA = "0x2449420", Offset = "0x2449420", VA = "0x2449420")]
				set
				{
				}
			}

			[Token(Token = "0x17000AF5")]
			public int GoldPaid
			{
				[Token(Token = "0x6004D5B")]
				[Address(RVA = "0x2449428", Offset = "0x2449428", VA = "0x2449428")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004D5C")]
				[Address(RVA = "0x2449430", Offset = "0x2449430", VA = "0x2449430")]
				set
				{
				}
			}

			[Token(Token = "0x17000AF6")]
			public int CrystalPaid
			{
				[Token(Token = "0x6004D5D")]
				[Address(RVA = "0x2449438", Offset = "0x2449438", VA = "0x2449438")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004D5E")]
				[Address(RVA = "0x2449440", Offset = "0x2449440", VA = "0x2449440")]
				set
				{
				}
			}

			[Token(Token = "0x6004D58")]
			[Address(RVA = "0x24493F0", Offset = "0x24493F0", VA = "0x24493F0")]
			public ResultData()
			{
			}
		}

		[Token(Token = "0x2000A12")]
		public class ResponseDataBase
		{
			[Token(Token = "0x4002FD6")]
			[FieldOffset(Offset = "0x8")]
			private string ResultStatus__BackingField;

			[Token(Token = "0x17000AF7")]
			public string ResultStatus
			{
				[Token(Token = "0x6004D60")]
				[Address(RVA = "0x2449410", Offset = "0x2449410", VA = "0x2449410")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004D61")]
				[Address(RVA = "0x2449408", Offset = "0x2449408", VA = "0x2449408")]
				set
				{
				}
			}

			[Token(Token = "0x6004D5F")]
			[Address(RVA = "0x2449308", Offset = "0x2449308", VA = "0x2449308")]
			public ResponseDataBase()
			{
			}
		}

		[Token(Token = "0x2000A13")]
		public class ResponseData : ResponseDataBase
		{
			[Token(Token = "0x4002FD7")]
			[FieldOffset(Offset = "0xC")]
			private ResultData Data__BackingField;

			[Token(Token = "0x17000AF8")]
			public ResultData Data
			{
				[Token(Token = "0x6004D63")]
				[Address(RVA = "0x2449400", Offset = "0x2449400", VA = "0x2449400")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004D64")]
				[Address(RVA = "0x24493F8", Offset = "0x24493F8", VA = "0x24493F8")]
				set
				{
				}
			}

			[Token(Token = "0x6004D62")]
			[Address(RVA = "0x2449270", Offset = "0x2449270", VA = "0x2449270")]
			public ResponseData()
			{
			}
		}

		[Token(Token = "0x6004D57")]
		[Address(RVA = "0x2449268", Offset = "0x2449268", VA = "0x2449268")]
		public CSNetCommand_NJ_GetCurrency()
		{
		}
	}
}
