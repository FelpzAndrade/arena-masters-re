using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EFC")]
public class XWidget_RankTierInfo : MonoBehaviour
{
	[Token(Token = "0x4004F67")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblRankType;

	[Token(Token = "0x4004F68")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_TierInfo tierInfo;

	[Token(Token = "0x4004F69")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblTierText;

	[Token(Token = "0x6006FE4")]
	[Address(RVA = "0x1334048", Offset = "0x1334048", VA = "0x1334048")]
	public XWidget_RankTierInfo()
	{
	}

	[Token(Token = "0x6006FE5")]
	[Address(RVA = "0x1334050", Offset = "0x1334050", VA = "0x1334050")]
	private bool IsPtIng(int placementTestCount)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FE6")]
	[Address(RVA = "0x1334060", Offset = "0x1334060", VA = "0x1334060")]
	public bool IsUnrank(int placementTestCount, int currentSeason)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FE7")]
	[Address(RVA = "0x131108C", Offset = "0x131108C", VA = "0x131108C")]
	public void Build(RankType matchRankType, int elo, int latestPlaySeason, int placementTestCount, CSProtoInfoManager_TrophyReward protoTrophy)
	{
	}

	[Token(Token = "0x6006FE8")]
	[Address(RVA = "0x133415C", Offset = "0x133415C", VA = "0x133415C")]
	public void Build(RankType matchRankType, XMyInfo myinfo, int curSeason, ProtoInfoManager_GameModeInstance protoModeInstance, CSProtoInfoManager_TrophyReward protoTrophy)
	{
	}
}
