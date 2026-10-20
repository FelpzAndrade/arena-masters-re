using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200094D")]
	public class ClanWar
	{
		[Token(Token = "0x4002E1E")]
		[FieldOffset(Offset = "0x8")]
		public ClanWarRecord TotalRecord;

		[Token(Token = "0x4002E1F")]
		[FieldOffset(Offset = "0xC")]
		public ClanWarSeasonRecord CurSeason;

		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x10")]
		public ClanWarSeasonRecord PrevSeason;

		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x14")]
		public ClanBoxSeasonRecord CurBoxSeason;

		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x18")]
		public ClanBoxSeasonRecord PrevBoxSeason;

		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x23EBD80", Offset = "0x23EBD80", VA = "0x23EBD80")]
		public ClanWar()
		{
		}
	}
}
