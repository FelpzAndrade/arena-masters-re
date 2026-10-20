using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008FB")]
	public struct CSLogic_ELO
	{
		[Token(Token = "0x60047FF")]
		[Address(RVA = "0x2237A04", Offset = "0x2237A04", VA = "0x2237A04")]
		public GameKey GetGameKey(MatchType matchType, XGameModeType gameModeType)
		{
			return default(GameKey);
		}

		[Token(Token = "0x6004800")]
		[Address(RVA = "0x2237ADC", Offset = "0x2237ADC", VA = "0x2237ADC")]
		public short GetSeasonELO(RankType rankType, EloImpl Elo, CSProtoInfoManager_GameConst gameConst, DateTime ServerLocalDateTime)
		{
			return default(short);
		}

		[Token(Token = "0x6004801")]
		[Address(RVA = "0x2237B08", Offset = "0x2237B08", VA = "0x2237B08")]
		public static SeasonELO CreateSeasonELO(int season, RankType rankType, short eloScore)
		{
			return null;
		}
	}
}
