using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FA1")]
public class XWidget_LobbyBannerView : MonoBehaviour
{
	[Token(Token = "0x2000FA2")]
	public class LobbyBannerData
	{
		[Token(Token = "0x40052C5")]
		[FieldOffset(Offset = "0x8")]
		public XLobbyButtonInfo lobbyButtonInfo;

		[Token(Token = "0x40052C6")]
		[FieldOffset(Offset = "0xC")]
		public List<LobbyRankerData> lobbbyRankDatas;

		[Token(Token = "0x600748B")]
		[Address(RVA = "0x145B5A0", Offset = "0x145B5A0", VA = "0x145B5A0")]
		public LobbyBannerData()
		{
		}
	}

	[Token(Token = "0x2000FA3")]
	public class LobbyRankerData
	{
		[Token(Token = "0x40052C7")]
		[FieldOffset(Offset = "0x8")]
		public MatchType matchType;

		[Token(Token = "0x40052C8")]
		[FieldOffset(Offset = "0xC")]
		public RankType rankType;

		[Token(Token = "0x40052C9")]
		[FieldOffset(Offset = "0x10")]
		public int rank;

		[Token(Token = "0x40052CA")]
		[FieldOffset(Offset = "0x14")]
		public int score;

		[Token(Token = "0x40052CB")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40052CC")]
		[FieldOffset(Offset = "0x1C")]
		public int DecoMainID;

		[Token(Token = "0x40052CD")]
		[FieldOffset(Offset = "0x20")]
		public int DecoSubID;

		[Token(Token = "0x600748C")]
		[Address(RVA = "0x145C240", Offset = "0x145C240", VA = "0x145C240")]
		public LobbyRankerData()
		{
		}
	}

	[Token(Token = "0x2000FA4")]
	private sealed class _003CBuild_003Ec__AnonStorey241
	{
		[Token(Token = "0x40052CE")]
		[FieldOffset(Offset = "0x8")]
		internal List<LobbyRankerData> infos;

		[Token(Token = "0x40052CF")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_LobbyBannerView _003C_003Ef__this;

		[Token(Token = "0x600748D")]
		[Address(RVA = "0x145CD00", Offset = "0x145CD00", VA = "0x145CD00")]
		public _003CBuild_003Ec__AnonStorey241()
		{
		}

		[Token(Token = "0x600748E")]
		[Address(RVA = "0x145CDA4", Offset = "0x145CDA4", VA = "0x145CDA4")]
		internal void _003C_003Em__4C5(int i, XUILobbyRankerItem rankerUI)
		{
		}
	}

	[Token(Token = "0x40052B5")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_SwipeObject bannerSwiper;

	[Token(Token = "0x40052B6")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder indexBoxBuilder;

	[Token(Token = "0x40052B7")]
	[FieldOffset(Offset = "0x14")]
	private List<LobbyBannerData> lobbyBannerDatas;

	[Token(Token = "0x40052B8")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, List<LobbyRankerData>> lobbbyRankDatas;

	[Token(Token = "0x40052B9")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, string> strRankTypes;

	[Token(Token = "0x40052BA")]
	[FieldOffset(Offset = "0x20")]
	private UIToggle[] toggles;

	[Token(Token = "0x40052BB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblDuelDayText;

	[Token(Token = "0x40052BC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblTeamDayText;

	[Token(Token = "0x40052BD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goNoDataRoot;

	[Token(Token = "0x40052BE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goDefaultDataRoot;

	[Token(Token = "0x40052BF")]
	[FieldOffset(Offset = "0x34")]
	private float m_elaspedTime;

	[Token(Token = "0x40052C0")]
	[FieldOffset(Offset = "0x38")]
	public float NextImageShowInterval;

	[Token(Token = "0x40052C1")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<LobbyBannerData> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x40052C2")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<LobbyRankerData> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x40052C3")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<LobbyRankerData> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x40052C4")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<LobbyRankerData> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x600747C")]
	[Address(RVA = "0x145AA68", Offset = "0x145AA68", VA = "0x145AA68")]
	public XWidget_LobbyBannerView()
	{
	}

	[Token(Token = "0x600747D")]
	[Address(RVA = "0x145AB88", Offset = "0x145AB88", VA = "0x145AB88")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600747E")]
	[Address(RVA = "0x145ABB4", Offset = "0x145ABB4", VA = "0x145ABB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600747F")]
	[Address(RVA = "0x145ACA4", Offset = "0x145ACA4", VA = "0x145ACA4")]
	private void Build(LastWeekRankerInfo lastWeekData, List<XLobbyButtonInfo> bannerInfos)
	{
	}

	[Token(Token = "0x6007480")]
	[Address(RVA = "0x145BB48", Offset = "0x145BB48", VA = "0x145BB48")]
	private void BuildBannerClickAction(string link)
	{
	}

	[Token(Token = "0x6007481")]
	[Address(RVA = "0x145BE04", Offset = "0x145BE04", VA = "0x145BE04")]
	public void Build()
	{
	}

	[Token(Token = "0x6007482")]
	[Address(RVA = "0x145C1DC", Offset = "0x145C1DC", VA = "0x145C1DC")]
	private void BuildBanner(int index)
	{
	}

	[Token(Token = "0x6007483")]
	[Address(RVA = "0x145B64C", Offset = "0x145B64C", VA = "0x145B64C")]
	private void AddRankerData(LobbyBannerData lobbyBannerData, MatchType matchType, RankType rankType, List<RankerMetaData> rankerData, List<ClanRankMetaData> clanRankData)
	{
	}

	[Token(Token = "0x6007484")]
	[Address(RVA = "0x145C248", Offset = "0x145C248", VA = "0x145C248")]
	private void AddClanRankerData(int index, string rankString, MatchType matchType, RankType rankType, List<ClanRankMetaData> clanRankData)
	{
	}

	[Token(Token = "0x6007485")]
	[Address(RVA = "0x145C5C0", Offset = "0x145C5C0", VA = "0x145C5C0")]
	private void AddRankerData(int index, string rankString, MatchType matchType, RankType rankType, List<RankerMetaData> rankerData)
	{
	}

	[Token(Token = "0x6007486")]
	[Address(RVA = "0x145C938", Offset = "0x145C938", VA = "0x145C938")]
	private static bool _003CBuild_003Em__4C0(LobbyBannerData x)
	{
		return default(bool);
	}

	[Token(Token = "0x6007487")]
	[Address(RVA = "0x145C948", Offset = "0x145C948", VA = "0x145C948")]
	private void _003CBuild_003Em__4C1(int index, GameObject go)
	{
	}

	[Token(Token = "0x6007488")]
	[Address(RVA = "0x145CD08", Offset = "0x145CD08", VA = "0x145CD08")]
	private static int _003CAddRankerData_003Em__4C2(LobbyRankerData a, LobbyRankerData b)
	{
		return default(int);
	}

	[Token(Token = "0x6007489")]
	[Address(RVA = "0x145CD3C", Offset = "0x145CD3C", VA = "0x145CD3C")]
	private static int _003CAddClanRankerData_003Em__4C3(LobbyRankerData a, LobbyRankerData b)
	{
		return default(int);
	}

	[Token(Token = "0x600748A")]
	[Address(RVA = "0x145CD70", Offset = "0x145CD70", VA = "0x145CD70")]
	private static int _003CAddRankerData_003Em__4C4(LobbyRankerData a, LobbyRankerData b)
	{
		return default(int);
	}
}
