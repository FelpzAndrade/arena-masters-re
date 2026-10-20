using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200094E")]
	public class ClanWarSeasonRecord
	{
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x8")]
		public ClanWarRecord Record;

		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0xC")]
		private int SeasonNum__BackingField;

		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x10")]
		private int Score__BackingField;

		[Token(Token = "0x17000A5A")]
		public int SeasonNum
		{
			[Token(Token = "0x6004AB4")]
			[Address(RVA = "0x23EC698", Offset = "0x23EC698", VA = "0x23EC698")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AB5")]
			[Address(RVA = "0x23EC6A0", Offset = "0x23EC6A0", VA = "0x23EC6A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A5B")]
		public int Score
		{
			[Token(Token = "0x6004AB6")]
			[Address(RVA = "0x23EC6A8", Offset = "0x23EC6A8", VA = "0x23EC6A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AB7")]
			[Address(RVA = "0x23EC6B0", Offset = "0x23EC6B0", VA = "0x23EC6B0")]
			set
			{
			}
		}

		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x23EBF0C", Offset = "0x23EBF0C", VA = "0x23EBF0C")]
		public ClanWarSeasonRecord()
		{
		}
	}
}
