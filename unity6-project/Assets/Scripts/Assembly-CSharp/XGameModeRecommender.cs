using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200085E")]
public class XGameModeRecommender
{
	[Token(Token = "0x200085F")]
	public class GameModeItem : CSHelper.IWeightedRandomItem
	{
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x8")]
		private XGameModeType gameModeType__BackingField;

		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0xC")]
		private int Weight__BackingField;

		[Token(Token = "0x1700096C")]
		public XGameModeType gameModeType
		{
			[Token(Token = "0x6004572")]
			[Address(RVA = "0x1412DA8", Offset = "0x1412DA8", VA = "0x1412DA8")]
			get
			{
				return default(XGameModeType);
			}
			[Token(Token = "0x6004573")]
			[Address(RVA = "0x1412D98", Offset = "0x1412D98", VA = "0x1412D98")]
			set
			{
			}
		}

		[Token(Token = "0x1700096D")]
		public int Weight
		{
			[Token(Token = "0x6004574")]
			[Address(RVA = "0x1413068", Offset = "0x1413068", VA = "0x1413068", Slot = "4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004575")]
			[Address(RVA = "0x1412DA0", Offset = "0x1412DA0", VA = "0x1412DA0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6004571")]
		[Address(RVA = "0x1412D90", Offset = "0x1412D90", VA = "0x1412D90")]
		public GameModeItem()
		{
		}
	}

	[Token(Token = "0x4002435")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, int> m_ModeRoomCountDic;

	[Token(Token = "0x6004564")]
	[Address(RVA = "0x1411CD8", Offset = "0x1411CD8", VA = "0x1411CD8")]
	public XGameModeRecommender()
	{
	}

	[Token(Token = "0x6004565")]
	[Address(RVA = "0x1411D84", Offset = "0x1411D84", VA = "0x1411D84")]
	private RoomInfo[] GetCurrentRoomList()
	{
		return null;
	}

	[Token(Token = "0x6004566")]
	[Address(RVA = "0x1411EEC", Offset = "0x1411EEC", VA = "0x1411EEC")]
	private bool CheckEnabledGameMode(XGameModeType gameModeType)
	{
		return default(bool);
	}

	[Token(Token = "0x6004567")]
	[Address(RVA = "0x1412188", Offset = "0x1412188", VA = "0x1412188")]
	private bool CheckEnabledMatchType(MatchType matchType)
	{
		return default(bool);
	}

	[Token(Token = "0x6004568")]
	[Address(RVA = "0x14121B8", Offset = "0x14121B8", VA = "0x14121B8")]
	private bool IsNewbieLevel(int nMyTeamLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6004569")]
	[Address(RVA = "0x1412260", Offset = "0x1412260", VA = "0x1412260")]
	private bool CheckPossibleQuickMatch_Sector(XQuickMatchOptionData quickMatchOption, int sectorID)
	{
		return default(bool);
	}

	[Token(Token = "0x600456A")]
	[Address(RVA = "0x1412308", Offset = "0x1412308", VA = "0x1412308")]
	private bool CheckPossibleQuickMatch_SectorList(XQuickMatchOptionData quickMatchOption, List<int> sectorIDList)
	{
		return default(bool);
	}

	[Token(Token = "0x600456B")]
	[Address(RVA = "0x141233C", Offset = "0x141233C", VA = "0x141233C")]
	private bool CheckPossibleQuickMatch_GameMode(XQuickMatchOptionData quickMatchOption, XGameModeType gameModeType)
	{
		return default(bool);
	}

	[Token(Token = "0x600456C")]
	[Address(RVA = "0x14123E4", Offset = "0x14123E4", VA = "0x14123E4")]
	private bool CheckPossibleQuickMatch_Newbie(XQuickMatchOptionData quickMatchOption, bool isNewbieRoom, int nMyTeamLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x600456D")]
	[Address(RVA = "0x1412418", Offset = "0x1412418", VA = "0x1412418")]
	private int GatherRooms(XQuickMatchOptionData quickMatchOption)
	{
		return default(int);
	}

	[Token(Token = "0x600456E")]
	[Address(RVA = "0x14129C8", Offset = "0x14129C8", VA = "0x14129C8")]
	private XGameModeType PickFromGameModeInstances(XQuickMatchOptionData quickMatchOption)
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x600456F")]
	[Address(RVA = "0x1412DB0", Offset = "0x1412DB0", VA = "0x1412DB0")]
	private XGameModeType PickFromRooms()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6004570")]
	[Address(RVA = "0x1412F6C", Offset = "0x1412F6C", VA = "0x1412F6C")]
	public XGameModeType RecommendGameMode(XQuickMatchOptionData quickMatchOption)
	{
		return default(XGameModeType);
	}
}
