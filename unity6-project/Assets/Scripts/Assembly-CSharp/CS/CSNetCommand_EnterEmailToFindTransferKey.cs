using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A56")]
	public class CSNetCommand_EnterEmailToFindTransferKey : CSNetCommand
	{
		[Token(Token = "0x2000A57")]
		public class RequestData
		{
			[Token(Token = "0x4003016")]
			[FieldOffset(Offset = "0x8")]
			private string Email__BackingField;

			[Token(Token = "0x4003017")]
			[FieldOffset(Offset = "0xC")]
			private string Language__BackingField;

			[Token(Token = "0x17000AF9")]
			public string Email
			{
				[Token(Token = "0x6004DB1")]
				[Address(RVA = "0x2448FA0", Offset = "0x2448FA0", VA = "0x2448FA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004DB2")]
				[Address(RVA = "0x2448FA8", Offset = "0x2448FA8", VA = "0x2448FA8")]
				set
				{
				}
			}

			[Token(Token = "0x17000AFA")]
			public string Language
			{
				[Token(Token = "0x6004DB3")]
				[Address(RVA = "0x2448FB0", Offset = "0x2448FB0", VA = "0x2448FB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004DB4")]
				[Address(RVA = "0x2448FB8", Offset = "0x2448FB8", VA = "0x2448FB8")]
				set
				{
				}
			}

			[Token(Token = "0x6004DB0")]
			[Address(RVA = "0x2448F98", Offset = "0x2448F98", VA = "0x2448F98")]
			public RequestData()
			{
			}
		}

		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x2448F20", Offset = "0x2448F20", VA = "0x2448F20")]
		public CSNetCommand_EnterEmailToFindTransferKey()
		{
		}

		[Token(Token = "0x6004DAF")]
		[Address(RVA = "0x2448F28", Offset = "0x2448F28", VA = "0x2448F28", Slot = "7")]
		public override string MethodType()
		{
			return null;
		}
	}
}
