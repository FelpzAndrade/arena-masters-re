using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000858")]
public class XRoomSelector
{
	[Token(Token = "0x2000859")]
	private sealed class _003CGetChooseRoomInfo_003Ec__AnonStorey144
	{
		[Token(Token = "0x4002411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int eloPt;

		[Token(Token = "0x600454D")]
		[Address(RVA = "0x1CA90B0", Offset = "0x1CA90B0", VA = "0x1CA90B0")]
		public _003CGetChooseRoomInfo_003Ec__AnonStorey144()
		{
		}

		[Token(Token = "0x600454E")]
		[Address(RVA = "0x1CAB8B4", Offset = "0x1CAB8B4", VA = "0x1CAB8B4")]
		internal int _003C_003Em__1DD(RoomInfo item)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200085A")]
	private sealed class _003CGetChooseRoomInfoByPing_003Ec__AnonStorey145
	{
		[Token(Token = "0x4002412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int ping;

		[Token(Token = "0x4002413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int pingBounds;

		[Token(Token = "0x600454F")]
		[Address(RVA = "0x1CA90B8", Offset = "0x1CA90B8", VA = "0x1CA90B8")]
		public _003CGetChooseRoomInfoByPing_003Ec__AnonStorey145()
		{
		}

		[Token(Token = "0x6004550")]
		[Address(RVA = "0x1CAB9C8", Offset = "0x1CAB9C8", VA = "0x1CAB9C8")]
		internal bool _003C_003Em__1DE(RoomInfo item)
		{
			return default(bool);
		}

		[Token(Token = "0x6004551")]
		[Address(RVA = "0x1CABAF0", Offset = "0x1CABAF0", VA = "0x1CABAF0")]
		internal int _003C_003Em__1DF(RoomInfo item)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200085B")]
	private sealed class _003CCollectCandidateRoomsNew_003Ec__AnonStorey146
	{
		[Token(Token = "0x4002414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameModeInstanceInfo info;

		[Token(Token = "0x4002415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int teamLevel;

		[Token(Token = "0x4002416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int nSectorID;

		[Token(Token = "0x4002417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal GeneralExpandElo expandElo;

		[Token(Token = "0x4002418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool isNewbieMatch;

		[Token(Token = "0x4002419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal List<int> ignoredSectors;

		[Token(Token = "0x400241A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal XRoomSelector _003C_003Ef__this;

		[Token(Token = "0x6004552")]
		[Address(RVA = "0x1CA9E9C", Offset = "0x1CA9E9C", VA = "0x1CA9E9C")]
		public _003CCollectCandidateRoomsNew_003Ec__AnonStorey146()
		{
		}

		[Token(Token = "0x6004553")]
		[Address(RVA = "0x1CAB644", Offset = "0x1CAB644", VA = "0x1CAB644")]
		internal bool _003C_003Em__1E1(RoomInfo room)
		{
			return default(bool);
		}

		[Token(Token = "0x6004554")]
		[Address(RVA = "0x1CAB698", Offset = "0x1CAB698", VA = "0x1CAB698")]
		internal void _003C_003Em__1E2(RoomInfo room)
		{
		}
	}

	[Token(Token = "0x200085C")]
	private sealed class _003CFindRegionGameServerRoom_003Ec__AnonStorey147
	{
		[Token(Token = "0x400241B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string region;

		[Token(Token = "0x400241C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XRoomSelector _003C_003Ef__this;

		[Token(Token = "0x6004555")]
		[Address(RVA = "0x1CA9EA4", Offset = "0x1CA9EA4", VA = "0x1CA9EA4")]
		public _003CFindRegionGameServerRoom_003Ec__AnonStorey147()
		{
		}

		[Token(Token = "0x6004556")]
		[Address(RVA = "0x1CAB884", Offset = "0x1CAB884", VA = "0x1CAB884")]
		internal bool _003C_003Em__1E3(RoomInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400240A")]
	private const bool SELECT_DUPLICATED_ROOM = true;

	[Token(Token = "0x400240B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private XPhotonManager.IPhotonNetwork m_photonNetwork;

	[Token(Token = "0x400240C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int m_MyLevel;

	[Token(Token = "0x400240D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private XRoomJoinLevelCalculator m_JoinLevelCalculator;

	[Token(Token = "0x400240E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private HashSet<string> m_SelectedRoomNames;

	[Token(Token = "0x400240F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<RoomInfo> m_CandidateRooms;

	[Token(Token = "0x4002410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Func<RoomInfo, RoomInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x17000968")]
	public List<RoomInfo> CandidateRoom
	{
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x1CA7380", Offset = "0x1CA7380", VA = "0x1CA7380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600452D")]
	[Address(RVA = "0x1CA7258", Offset = "0x1CA7258", VA = "0x1CA7258")]
	public XRoomSelector(XPhotonManager.IPhotonNetwork photonNetwork)
	{
	}

	[Token(Token = "0x600452F")]
	[Address(RVA = "0x1CA7388", Offset = "0x1CA7388", VA = "0x1CA7388")]
	private void Reset()
	{
	}

	[Token(Token = "0x6004530")]
	[Address(RVA = "0x1CA7490", Offset = "0x1CA7490", VA = "0x1CA7490")]
	private int RollSectorID(GameModeInstanceInfo gameModeInstanceInfo, [Optional] List<int> ignoredSectors)
	{
		return default(int);
	}

	[Token(Token = "0x6004531")]
	[Address(RVA = "0x1CA79BC", Offset = "0x1CA79BC", VA = "0x1CA79BC")]
	public int RecommendSectorId(GameModeInstanceInfo gameModeInstanceInfo, EventGameModeInfo eventGameModeInfo, bool isQuickMatch, XQuickMatchOptionData quickMatchOption)
	{
		return default(int);
	}

	[Token(Token = "0x6004532")]
	[Address(RVA = "0x1CA80BC", Offset = "0x1CA80BC", VA = "0x1CA80BC")]
	public XGameModeType RecommendGameMode(XQuickMatchOptionData quickMatchOption)
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6004533")]
	[Address(RVA = "0x1CA816C", Offset = "0x1CA816C", VA = "0x1CA816C")]
	private bool IsNewbieGameModeType(XGameModeType gameModeType)
	{
		return default(bool);
	}

	[Token(Token = "0x6004534")]
	[Address(RVA = "0x1CA817C", Offset = "0x1CA817C", VA = "0x1CA817C")]
	private RoomInfo GetChooseRoom(GameModeInstanceInfo info, int teamLevel, int sectorID, int myEloPt, bool isNewbieMatch, string gsRegion, [Optional] List<int> ignoredSectors)
	{
		return null;
	}

	[Token(Token = "0x6004535")]
	[Address(RVA = "0x1CA8878", Offset = "0x1CA8878", VA = "0x1CA8878")]
	public RoomInfo ChooseRoomInfoByRegionGameServer(string gsRegion, int myEloPt, int matchPing, int matchPingBounds, List<RoomInfo> _candidateRooms, GameModeInstanceInfo info)
	{
		return null;
	}

	[Token(Token = "0x6004536")]
	[Address(RVA = "0x1CA7C5C", Offset = "0x1CA7C5C", VA = "0x1CA7C5C")]
	private int RecommendSectorIdImpl(GameModeInstanceInfo gameModeInstanceInfo, int myEloPt, bool isQuickMatch, XQuickMatchOptionData quickMatchOption)
	{
		return default(int);
	}

	[Token(Token = "0x6004537")]
	[Address(RVA = "0x1CA8F34", Offset = "0x1CA8F34", VA = "0x1CA8F34")]
	private RoomInfo GetChooseRoomInfo(List<RoomInfo> roomInfoList, int eloPt, GameModeInstanceInfo info)
	{
		return null;
	}

	[Token(Token = "0x6004538")]
	[Address(RVA = "0x1CA8C64", Offset = "0x1CA8C64", VA = "0x1CA8C64")]
	public RoomInfo ChooseRoomInfoByPing(List<RoomInfo> roomInfoList, int eloPt, int matchPing, int matchPingBounds, GameModeInstanceInfo info)
	{
		return null;
	}

	[Token(Token = "0x6004539")]
	[Address(RVA = "0x1CA8D54", Offset = "0x1CA8D54", VA = "0x1CA8D54")]
	public List<RoomInfo> GetChooseRoomInfoByPing(List<RoomInfo> roomInfoList, int ping, int pingBounds = 0)
	{
		return null;
	}

	[Token(Token = "0x600453A")]
	[Address(RVA = "0x1CA90C0", Offset = "0x1CA90C0", VA = "0x1CA90C0")]
	public int FindFriendlyRoomSectorId(XGameModeType mode, string strRoomName)
	{
		return default(int);
	}

	[Token(Token = "0x600453B")]
	[Address(RVA = "0x1CA9574", Offset = "0x1CA9574", VA = "0x1CA9574")]
	public bool CheckInvitationRoom(out XGameModeType gameModeType)
	{
		gameModeType = default;
		return default(bool);
	}

	[Token(Token = "0x600453C")]
	[Address(RVA = "0x1CA9A5C", Offset = "0x1CA9A5C", VA = "0x1CA9A5C")]
	public bool SelectRoom(GameModeInstanceInfo info, int nSectorID, int eloPt, bool isNewbieMatch, out string strSelectedRoomName)
	{
		strSelectedRoomName = default;
		return default(bool);
	}

	[Token(Token = "0x600453D")]
	[Address(RVA = "0x1CA9E98", Offset = "0x1CA9E98", VA = "0x1CA9E98")]
	private void AddSelectedRoomName(string strSelectedRoomName)
	{
	}

	[Token(Token = "0x600453E")]
	[Address(RVA = "0x1CA7924", Offset = "0x1CA7924", VA = "0x1CA7924")]
	private bool IsIgnoredSector(int sectorId, List<int> ignoredSectors)
	{
		return default(bool);
	}

	[Token(Token = "0x600453F")]
	[Address(RVA = "0x1CA8548", Offset = "0x1CA8548", VA = "0x1CA8548")]
	public void CollectCandidateRoomsNew(List<RoomInfo> liRoomInfo, GameModeInstanceInfo info, int teamLevel, int nSectorID, GeneralExpandElo expandElo, bool isNewbieMatch, [Optional] List<int> ignoredSectors)
	{
	}

	[Token(Token = "0x6004540")]
	[Address(RVA = "0x1CA8A28", Offset = "0x1CA8A28", VA = "0x1CA8A28")]
	public bool FindRegionGameServerRoom(string region, List<RoomInfo> liCandidateRooms, out List<RoomInfo> liChooseRoom)
	{
		liChooseRoom = default;
		return default(bool);
	}

	[Token(Token = "0x6004541")]
	[Address(RVA = "0x1CA9EAC", Offset = "0x1CA9EAC", VA = "0x1CA9EAC")]
	private bool CheckCustomRoomType(RoomInfo room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004542")]
	[Address(RVA = "0x1CA9EE8", Offset = "0x1CA9EE8", VA = "0x1CA9EE8")]
	private bool IsCollectCondition(RoomInfo room, GameModeInstanceInfo gameModeInstanceInfo, int teamLevel, int nSectorID, GeneralExpandElo expandElo, bool isNewbieMatch)
	{
		return default(bool);
	}

	[Token(Token = "0x6004543")]
	[Address(RVA = "0x1CAB1D4", Offset = "0x1CAB1D4", VA = "0x1CAB1D4")]
	private bool CheckPrivateRoom(RoomInfo room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004544")]
	[Address(RVA = "0x1CAB378", Offset = "0x1CAB378", VA = "0x1CAB378")]
	private bool CheckOpenRoom(RoomInfo room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004545")]
	[Address(RVA = "0x1CAAF70", Offset = "0x1CAAF70", VA = "0x1CAAF70")]
	private bool CheckRoomMaxPlayer(RoomInfo room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004546")]
	[Address(RVA = "0x1CAB3C8", Offset = "0x1CAB3C8", VA = "0x1CAB3C8")]
	private bool CheckRegionServerRoom(RoomInfo room, string region)
	{
		return default(bool);
	}

	[Token(Token = "0x6004547")]
	[Address(RVA = "0x1CAA7BC", Offset = "0x1CAA7BC", VA = "0x1CAA7BC")]
	private bool CheckBannedRoom(string bannedPlayerList)
	{
		return default(bool);
	}

	[Token(Token = "0x6004548")]
	[Address(RVA = "0x1CAA9E4", Offset = "0x1CAA9E4", VA = "0x1CAA9E4")]
	private bool CheckNewbieRoom(RoomInfo room, bool isNewbieMatch)
	{
		return default(bool);
	}

	[Token(Token = "0x6004549")]
	[Address(RVA = "0x1CAAB84", Offset = "0x1CAAB84", VA = "0x1CAAB84")]
	private bool CheckBlockedMeRoom(RoomInfo room)
	{
		return default(bool);
	}

	[Token(Token = "0x600454A")]
	[Address(RVA = "0x1CAB60C", Offset = "0x1CAB60C", VA = "0x1CAB60C")]
	public void ProcessRoomSelectorHistory(XGameModeType nGameModeType, CSWinlose winlose, int nRank)
	{
	}

	[Token(Token = "0x600454B")]
	[Address(RVA = "0x1CA87CC", Offset = "0x1CA87CC", VA = "0x1CA87CC")]
	public bool IsWantRegionServerRoom(string gsRegion)
	{
		return default(bool);
	}

	[Token(Token = "0x600454C")]
	[Address(RVA = "0x1CAB63C", Offset = "0x1CAB63C", VA = "0x1CAB63C")]
	private static RoomInfo _003CCollectCandidateRoomsNew_003Em__1E0(RoomInfo room)
	{
		return null;
	}
}
