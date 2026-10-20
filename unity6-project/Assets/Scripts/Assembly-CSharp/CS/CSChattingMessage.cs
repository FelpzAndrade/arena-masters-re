using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000870")]
	public class CSChattingMessage
	{
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x8")]
		private long timeStamp__BackingField;

		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x10")]
		private string strJsonObj__BackingField;

		[Token(Token = "0x17000973")]
		public long timeStamp
		{
			[Token(Token = "0x6004597")]
			[Address(RVA = "0x22288D0", Offset = "0x22288D0", VA = "0x22288D0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004598")]
			[Address(RVA = "0x22288B8", Offset = "0x22288B8", VA = "0x22288B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000974")]
		public string strJsonObj
		{
			[Token(Token = "0x6004599")]
			[Address(RVA = "0x22288D8", Offset = "0x22288D8", VA = "0x22288D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600459A")]
			[Address(RVA = "0x22288C8", Offset = "0x22288C8", VA = "0x22288C8")]
			set
			{
			}
		}

		[Token(Token = "0x6004596")]
		[Address(RVA = "0x2228888", Offset = "0x2228888", VA = "0x2228888")]
		public CSChattingMessage(long _ts, string _msg)
		{
		}
	}
}
