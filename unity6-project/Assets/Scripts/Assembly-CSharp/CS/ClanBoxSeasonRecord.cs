using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200094F")]
	public class ClanBoxSeasonRecord
	{
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x8")]
		private int SeasonNum__BackingField;

		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0xC")]
		private int Score__BackingField;

		[Token(Token = "0x17000A5C")]
		public int SeasonNum
		{
			[Token(Token = "0x6004AB9")]
			[Address(RVA = "0x23EB6C0", Offset = "0x23EB6C0", VA = "0x23EB6C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004ABA")]
			[Address(RVA = "0x23EB6C8", Offset = "0x23EB6C8", VA = "0x23EB6C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5D")]
		public int Score
		{
			[Token(Token = "0x6004ABB")]
			[Address(RVA = "0x23EB6D0", Offset = "0x23EB6D0", VA = "0x23EB6D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004ABC")]
			[Address(RVA = "0x23EB6D8", Offset = "0x23EB6D8", VA = "0x23EB6D8")]
			set
			{
			}
		}

		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x23EB6B8", Offset = "0x23EB6B8", VA = "0x23EB6B8")]
		public ClanBoxSeasonRecord()
		{
		}
	}
}
