using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1D")]
public class XUIFirstRewardItemList : XUIListView
{
	[Token(Token = "0x4004FFE")]
	[FieldOffset(Offset = "0x78")]
	private List<CSFirstRankReward> tab_list;

	[Token(Token = "0x4004FFF")]
	[FieldOffset(Offset = "0x7C")]
	private RankType m_rankType;

	[Token(Token = "0x4005000")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_firstRankRewardRecievedItemIDList;

	[Token(Token = "0x4005001")]
	[FieldOffset(Offset = "0x84")]
	private int m_bestELO;

	[Token(Token = "0x4005002")]
	[FieldOffset(Offset = "0x88")]
	private bool m_isPlacementTest;

	[Token(Token = "0x17000E49")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070AB")]
		[Address(RVA = "0x1A44334", Offset = "0x1A44334", VA = "0x1A44334", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E4A")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070AC")]
		[Address(RVA = "0x1A443AC", Offset = "0x1A443AC", VA = "0x1A443AC", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E4B")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070AD")]
		[Address(RVA = "0x1A443B4", Offset = "0x1A443B4", VA = "0x1A443B4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60070AA")]
	[Address(RVA = "0x1A44290", Offset = "0x1A44290", VA = "0x1A44290")]
	public XUIFirstRewardItemList()
	{
	}

	[Token(Token = "0x60070AE")]
	[Address(RVA = "0x1A4444C", Offset = "0x1A4444C", VA = "0x1A4444C")]
	public void Build(RankType rankType, List<CSFirstRankReward> infoList, List<int> firstRankRewardRecievedItemIDList, int bestELO, bool isPlacementTest)
	{
	}

	[Token(Token = "0x60070AF")]
	[Address(RVA = "0x1A4463C", Offset = "0x1A4463C", VA = "0x1A4463C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
