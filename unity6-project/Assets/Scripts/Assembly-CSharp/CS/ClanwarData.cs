using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200094B")]
	public class ClanwarData
	{
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0x8")]
		public SeasonRecord Season;

		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0xC")]
		public SeasonRecord PrevSeason;

		[Token(Token = "0x4002E16")]
		[FieldOffset(Offset = "0x10")]
		private long OpenTime__BackingField;

		[Token(Token = "0x4002E17")]
		[FieldOffset(Offset = "0x18")]
		private long CloseTime__BackingField;

		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x20")]
		private long RewardTime__BackingField;

		[Token(Token = "0x4002E19")]
		[FieldOffset(Offset = "0x28")]
		private long TicketNextChargeTime__BackingField;

		[Token(Token = "0x17000A52")]
		public long OpenTime
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0x23EC058", Offset = "0x23EC058", VA = "0x23EC058")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0x23EC060", Offset = "0x23EC060", VA = "0x23EC060")]
			set
			{
			}
		}

		[Token(Token = "0x17000A53")]
		public long CloseTime
		{
			[Token(Token = "0x6004AA2")]
			[Address(RVA = "0x23EC070", Offset = "0x23EC070", VA = "0x23EC070")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004AA3")]
			[Address(RVA = "0x23EC078", Offset = "0x23EC078", VA = "0x23EC078")]
			set
			{
			}
		}

		[Token(Token = "0x17000A54")]
		public long RewardTime
		{
			[Token(Token = "0x6004AA4")]
			[Address(RVA = "0x23EC088", Offset = "0x23EC088", VA = "0x23EC088")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004AA5")]
			[Address(RVA = "0x23EC090", Offset = "0x23EC090", VA = "0x23EC090")]
			set
			{
			}
		}

		[Token(Token = "0x17000A55")]
		public long TicketNextChargeTime
		{
			[Token(Token = "0x6004AA6")]
			[Address(RVA = "0x23EC0A0", Offset = "0x23EC0A0", VA = "0x23EC0A0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004AA7")]
			[Address(RVA = "0x23EC0A8", Offset = "0x23EC0A8", VA = "0x23EC0A8")]
			set
			{
			}
		}

		[Token(Token = "0x6004A9F")]
		[Address(RVA = "0x23EBFA4", Offset = "0x23EBFA4", VA = "0x23EBFA4")]
		public ClanwarData()
		{
		}
	}
}
