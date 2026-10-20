using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000925")]
public static class CSLogic_ClanBox
{
	[Token(Token = "0x6004902")]
	[Address(RVA = "0x21F2130", Offset = "0x21F2130", VA = "0x21F2130")]
	public static List<CSClanBoxReward> GetRewards(int score, CSProtoInfoManager_ClanBoxReward protoClanBox)
	{
		return null;
	}

	[Token(Token = "0x6004903")]
	[Address(RVA = "0x21F215C", Offset = "0x21F215C", VA = "0x21F215C")]
	public static ApiReturnCode CheckCanPaidBoxReward(int curSeason, int minScore, int maxScore, ClanBoxSeasonRecord clanRecord, ClanMemberSeasonRecord memberRecord)
	{
		return default(ApiReturnCode);
	}
}
