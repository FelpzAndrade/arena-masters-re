using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008BF")]
	public static class MatchConst
	{
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MAX_PLAYERS;

		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int EXPAND_MATCH_INTERVAL;

		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int EXPAND_ELO;

		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int EXPAND_MIN_ELO;

		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int EXPAND_MAX_ELO_SOLO;

		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int EXPAND_MAX_ELO_TEAM;

		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int EXPAND_MAX_ELO_CLAN;

		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int EXPAND_ELO_GENERAL;

		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int MIN_ELO;

		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int MAX_ELO;

		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int TIME_OUT_SEC;

		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int TIME_ELAPSE_EXPAND_ELO;

		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x30")]
		public static readonly long MATCH_SUCCESS_DELAY_SEND_TIME;

		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int PING_GROUP_MIN;

		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int PING_GROUP_MAX;

		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int EXPAND_BASE_ELO;

		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int EXPAND_BASE_CONST;

		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int EXPAND_BASE_FACTOR;

		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int ClanWarGameModeID;

		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int RankSoloGameModeID;

		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int RankCapturePointGameModeID;

		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int RankTeamGameModeID;

		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int EventRelayGameModeID;

		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int EventPoliceVsThiefGameModeID;

		[Token(Token = "0x4002ABE")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int EventClssicGameModeID;

		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int EventTeamDeathMatchGameModeID;

		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x233B8B0", Offset = "0x233B8B0", VA = "0x233B8B0")]
		public static Guid get_game_name()
		{
			return default(Guid);
		}

		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x233B958", Offset = "0x233B958", VA = "0x233B958")]
		public static int GetGameModeID(MatchType type, XGameModeType mode)
		{
			return default(int);
		}
	}
}
