using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A58")]
	public class CSNetCommand_ReqeustTransfer : CSNetCommand
	{
		[Token(Token = "0x2000A59")]
		public class RequestData
		{
			[Token(Token = "0x4003018")]
			[FieldOffset(Offset = "0x8")]
			private string TransferKey__BackingField;

			[Token(Token = "0x17000AFB")]
			public string TransferKey
			{
				[Token(Token = "0x6004DB8")]
				[Address(RVA = "0x1FBD084", Offset = "0x1FBD084", VA = "0x1FBD084")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004DB9")]
				[Address(RVA = "0x1FBD08C", Offset = "0x1FBD08C", VA = "0x1FBD08C")]
				set
				{
				}
			}

			[Token(Token = "0x6004DB7")]
			[Address(RVA = "0x1FBD07C", Offset = "0x1FBD07C", VA = "0x1FBD07C")]
			public RequestData()
			{
			}
		}

		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x1FBD004", Offset = "0x1FBD004", VA = "0x1FBD004")]
		public CSNetCommand_ReqeustTransfer()
		{
		}

		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x1FBD00C", Offset = "0x1FBD00C", VA = "0x1FBD00C", Slot = "7")]
		public override string MethodType()
		{
			return null;
		}
	}
}
