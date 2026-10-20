using System.Collections.Generic;
using System.Text;
using CS;
using Il2CppDummyDll;
using TapjoyUnity;
using UnityEngine;

[Token(Token = "0x2000BF6")]
public class XTapjoyManager : MonoBehaviour
{
	[Token(Token = "0x2000BF7")]
	public enum GENRE
	{
		[Token(Token = "0x4003C90")]
		AOS = 1,
		[Token(Token = "0x4003C91")]
		STRATEGY = 2,
		[Token(Token = "0x4003C92")]
		ACTION = 3,
		[Token(Token = "0x4003C93")]
		FPS = 4,
		[Token(Token = "0x4003C94")]
		CARD = 5,
		[Token(Token = "0x4003C95")]
		OTHER = 6
	}

	[Token(Token = "0x2000BF8")]
	public enum TUTORIALFUNNELSTATE
	{
		[Token(Token = "0x4003C97")]
		SPLASH = 1,
		[Token(Token = "0x4003C98")]
		DATADOWNLOAD_START = 2,
		[Token(Token = "0x4003C99")]
		DATADOWNLOAD_END = 3,
		[Token(Token = "0x4003C9A")]
		TITLESCENE = 4,
		[Token(Token = "0x4003C9B")]
		LOGIN = 5,
		[Token(Token = "0x4003C9C")]
		REGISTRATION_NICKNAME = 6,
		[Token(Token = "0x4003C9D")]
		BASIC_CONTROL_GUIDE = 7,
		[Token(Token = "0x4003C9E")]
		TUTORIAL_START = 8,
		[Token(Token = "0x4003C9F")]
		COLLEAGUE_SELECT = 9,
		[Token(Token = "0x4003CA0")]
		NORMAL_MATCH_START_1 = 10,
		[Token(Token = "0x4003CA1")]
		NORMAL_MATCH_END_1 = 11,
		[Token(Token = "0x4003CA2")]
		RELIC_REINFORCE = 12,
		[Token(Token = "0x4003CA3")]
		NORMAL_MATCH_START_2 = 13,
		[Token(Token = "0x4003CA4")]
		NORMAL_MATCH_END_2 = 14,
		[Token(Token = "0x4003CA5")]
		TAG_SKILL_REGISTRATION = 15,
		[Token(Token = "0x4003CA6")]
		TUTORIAL_END = 16
	}

	[Token(Token = "0x2000BF9")]
	public enum COHORT
	{
		[Token(Token = "0x4003CA8")]
		SERVER_REGION = 1,
		[Token(Token = "0x4003CA9")]
		PUSH = 2,
		[Token(Token = "0x4003CAA")]
		COLLEAGUE = 3,
		[Token(Token = "0x4003CAB")]
		DULE_RANK_ELO_TIER = 4,
		[Token(Token = "0x4003CAC")]
		TEAM_RANK_ELO_TIER = 5
	}

	[Token(Token = "0x2000BFA")]
	public class TJPlacementInfo
	{
		[Token(Token = "0x4003CAD")]
		[FieldOffset(Offset = "0x8")]
		public TJPlacement placement;

		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0xC")]
		public bool isReady;

		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x1835738", Offset = "0x1835738", VA = "0x1835738")]
		public TJPlacementInfo()
		{
		}
	}

	[Token(Token = "0x2000BFB")]
	private class SkillInfoLog
	{
		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0xC")]
		public int point;

		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x183EAA0", Offset = "0x183EAA0", VA = "0x183EAA0")]
		public SkillInfoLog(int _id, int _point)
		{
		}
	}

	[Token(Token = "0x4003C83")]
	[FieldOffset(Offset = "0xC")]
	public bool isConnected;

	[Token(Token = "0x4003C84")]
	[FieldOffset(Offset = "0xD")]
	public bool contentGenreIsReadyForPlacement;

	[Token(Token = "0x4003C85")]
	[FieldOffset(Offset = "0xE")]
	public bool contentAgeReadyForPlacement;

	[Token(Token = "0x4003C86")]
	[FieldOffset(Offset = "0x10")]
	public string output;

	[Token(Token = "0x4003C87")]
	[FieldOffset(Offset = "0x14")]
	private string customEvent;

	[Token(Token = "0x4003C88")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, TJPlacementInfo> placementDic;

	[Token(Token = "0x4003C89")]
	[FieldOffset(Offset = "0x1C")]
	private StringBuilder logParamBuilder;

	[Token(Token = "0x4003C8A")]
	[FieldOffset(Offset = "0x20")]
	private StringBuilder gameModeParamBuilder;

	[Token(Token = "0x4003C8B")]
	[FieldOffset(Offset = "0x24")]
	private XModuleActor myPlayerActor;

	[Token(Token = "0x4003C8C")]
	[FieldOffset(Offset = "0x28")]
	private string region;

	[Token(Token = "0x4003C8D")]
	[FieldOffset(Offset = "0x2C")]
	private bool isLobbyEvent;

	[Token(Token = "0x4003C8E")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map14;

	[Token(Token = "0x6005689")]
	[Address(RVA = "0x1835300", Offset = "0x1835300", VA = "0x1835300")]
	public XTapjoyManager()
	{
	}

	[Token(Token = "0x600568A")]
	[Address(RVA = "0x1835464", Offset = "0x1835464", VA = "0x1835464")]
	public void InitPlacementDictionary()
	{
	}

	[Token(Token = "0x600568B")]
	[Address(RVA = "0x18355F0", Offset = "0x18355F0", VA = "0x18355F0")]
	private void AddDictionaryAndRequestPlacement(string placementName)
	{
	}

	[Token(Token = "0x600568C")]
	[Address(RVA = "0x1835740", Offset = "0x1835740", VA = "0x1835740")]
	public void Init()
	{
	}

	[Token(Token = "0x600568D")]
	[Address(RVA = "0x1835C90", Offset = "0x1835C90", VA = "0x1835C90")]
	private string AndroidConnectByServerTypeKey()
	{
		return null;
	}

	[Token(Token = "0x600568E")]
	[Address(RVA = "0x1835EA0", Offset = "0x1835EA0", VA = "0x1835EA0")]
	private string IOSConnectByServerTypeKey()
	{
		return null;
	}

	[Token(Token = "0x600568F")]
	[Address(RVA = "0x18360B0", Offset = "0x18360B0", VA = "0x18360B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005690")]
	[Address(RVA = "0x1836468", Offset = "0x1836468", VA = "0x1836468")]
	public void HandlePlacementRequestSuccess(TJPlacement placement)
	{
	}

	[Token(Token = "0x6005691")]
	[Address(RVA = "0x183646C", Offset = "0x183646C", VA = "0x183646C")]
	public void HandlePlacementRequestFailure(TJPlacement placement, string error)
	{
	}

	[Token(Token = "0x6005692")]
	[Address(RVA = "0x1836624", Offset = "0x1836624", VA = "0x1836624")]
	public void HandlePlacementContentReady(TJPlacement placement)
	{
	}

	[Token(Token = "0x6005693")]
	[Address(RVA = "0x1836854", Offset = "0x1836854", VA = "0x1836854")]
	public void HandlePlacementContentShow(TJPlacement placement)
	{
	}

	[Token(Token = "0x6005694")]
	[Address(RVA = "0x1836778", Offset = "0x1836778", VA = "0x1836778")]
	public void ShowPlacement(string placementName)
	{
	}

	[Token(Token = "0x6005695")]
	[Address(RVA = "0x1836910", Offset = "0x1836910", VA = "0x1836910")]
	private void CheckAndContinuePlacement(string placementName)
	{
	}

	[Token(Token = "0x6005696")]
	[Address(RVA = "0x1836B8C", Offset = "0x1836B8C", VA = "0x1836B8C")]
	public void HandlePlacementContentDismiss(TJPlacement placement)
	{
	}

	[Token(Token = "0x6005697")]
	[Address(RVA = "0x1836CF8", Offset = "0x1836CF8", VA = "0x1836CF8")]
	private void HandleOnPurchaseRequest(TJPlacement placement, TJActionRequest request, string productId)
	{
	}

	[Token(Token = "0x6005698")]
	[Address(RVA = "0x1836E38", Offset = "0x1836E38", VA = "0x1836E38")]
	private void HandleOnRewardRequest(TJPlacement placement, TJActionRequest request, string itemId, int quantity)
	{
	}

	[Token(Token = "0x6005699")]
	[Address(RVA = "0x1836F18", Offset = "0x1836F18", VA = "0x1836F18")]
	public void TrackTutorialFunnelEvent(string category, string name, int value)
	{
	}

	[Token(Token = "0x600569A")]
	[Address(RVA = "0x18371F8", Offset = "0x18371F8", VA = "0x18371F8")]
	public void CheckAndTrackTrackingSDK(int tutorialState)
	{
	}

	[Token(Token = "0x600569B")]
	[Address(RVA = "0x1837330", Offset = "0x1837330", VA = "0x1837330")]
	public void TrackTrackingSDK(string eventName, string adjustEventToken, bool isUseNpaCode = true)
	{
	}

	[Token(Token = "0x600569C")]
	[Address(RVA = "0x1837598", Offset = "0x1837598", VA = "0x1837598")]
	private void TrackingEventLevelupSDK(int level)
	{
	}

	[Token(Token = "0x600569D")]
	[Address(RVA = "0x1837664", Offset = "0x1837664", VA = "0x1837664")]
	public void TrackLevelupFunnelEvent(int beforeTeamLv, int afterTeamLv)
	{
	}

	[Token(Token = "0x600569E")]
	[Address(RVA = "0x1837A10", Offset = "0x1837A10", VA = "0x1837A10")]
	public void TrackPurchaseEvent(string productId, string currencyCode, float price)
	{
	}

	[Token(Token = "0x600569F")]
	[Address(RVA = "0x183794C", Offset = "0x183794C", VA = "0x183794C")]
	public void TrackEvent(string category, string name)
	{
	}

	[Token(Token = "0x60056A0")]
	[Address(RVA = "0x1837AE8", Offset = "0x1837AE8", VA = "0x1837AE8")]
	public void SetUserID(string id)
	{
	}

	[Token(Token = "0x60056A1")]
	[Address(RVA = "0x1837B90", Offset = "0x1837B90", VA = "0x1837B90")]
	public void SetUserLevel(int level)
	{
	}

	[Token(Token = "0x60056A2")]
	[Address(RVA = "0x1837C38", Offset = "0x1837C38", VA = "0x1837C38")]
	public void SetUserCohort(int variableIndex, string name)
	{
	}

	[Token(Token = "0x60056A3")]
	[Address(RVA = "0x1837CE8", Offset = "0x1837CE8", VA = "0x1837CE8")]
	public void TrackEventLobby()
	{
	}

	[Token(Token = "0x60056A4")]
	[Address(RVA = "0x1838A68", Offset = "0x1838A68", VA = "0x1838A68")]
	public void TrackEventMatchSuccess(string battleIdx, int waitTime, bool isAutoStart = true)
	{
	}

	[Token(Token = "0x60056A5")]
	[Address(RVA = "0x183987C", Offset = "0x183987C", VA = "0x183987C")]
	public void TrackEventMatchFail(string battleIdx, int waitTime, bool isAutoStart = false)
	{
	}

	[Token(Token = "0x60056A6")]
	[Address(RVA = "0x1839A5C", Offset = "0x1839A5C", VA = "0x1839A5C")]
	public void TrackEventNormalMatchSuccess(string battleIdx, int waitTime, bool isAutoStart = true)
	{
	}

	[Token(Token = "0x60056A7")]
	[Address(RVA = "0x1839C34", Offset = "0x1839C34", VA = "0x1839C34")]
	public void TrackEventNormalMatchFailed(string battleIdx, int waitTime)
	{
	}

	[Token(Token = "0x60056A8")]
	[Address(RVA = "0x1839E0C", Offset = "0x1839E0C", VA = "0x1839E0C")]
	public void TrackEventAchievement(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x60056A9")]
	[Address(RVA = "0x183A744", Offset = "0x183A744", VA = "0x183A744")]
	public void TrackEventInGameRoomPing()
	{
	}

	[Token(Token = "0x60056AA")]
	[Address(RVA = "0x183AC20", Offset = "0x183AC20", VA = "0x183AC20")]
	public bool TrackEventInGameMyPing()
	{
		return default(bool);
	}

	[Token(Token = "0x60056AB")]
	[Address(RVA = "0x183ABEC", Offset = "0x183ABEC", VA = "0x183ABEC")]
	private int CalcPingPack(int ping)
	{
		return default(int);
	}

	[Token(Token = "0x60056AC")]
	[Address(RVA = "0x183B360", Offset = "0x183B360", VA = "0x183B360")]
	internal void TrackEventRankMatchingTime(MatchType matchType, XGameModeType mode, int waitTime)
	{
	}

	[Token(Token = "0x60056AD")]
	[Address(RVA = "0x183B774", Offset = "0x183B774", VA = "0x183B774")]
	private string CurrentSectorName()
	{
		return null;
	}

	[Token(Token = "0x60056AE")]
	[Address(RVA = "0x183B814", Offset = "0x183B814", VA = "0x183B814")]
	private string GetCurrentGameDataModeName()
	{
		return null;
	}

	[Token(Token = "0x60056AF")]
	[Address(RVA = "0x183BAD8", Offset = "0x183BAD8", VA = "0x183BAD8")]
	private string GameModeParameter(string battleID = "")
	{
		return null;
	}

	[Token(Token = "0x60056B0")]
	[Address(RVA = "0x183CEBC", Offset = "0x183CEBC", VA = "0x183CEBC")]
	public void TrackELO(TierRank tier, string rank, MatchType matchType, bool isTeamMode, int teamLevel)
	{
	}

	[Token(Token = "0x60056B1")]
	[Address(RVA = "0x183CCF4", Offset = "0x183CCF4", VA = "0x183CCF4")]
	private string GetMatchTypeString(MatchType matchType)
	{
		return null;
	}

	[Token(Token = "0x60056B2")]
	[Address(RVA = "0x183D140", Offset = "0x183D140", VA = "0x183D140")]
	private string GetCategoryStringByMatchType(MatchType matchType, bool isTeamMode)
	{
		return null;
	}

	[Token(Token = "0x60056B3")]
	[Address(RVA = "0x183D214", Offset = "0x183D214", VA = "0x183D214")]
	public void TrackPVPGameEnd(XPlayerManager m_playerManager, MatchType matchType, int teamLevel)
	{
	}

	[Token(Token = "0x60056B4")]
	[Address(RVA = "0x1823F70", Offset = "0x1823F70", VA = "0x1823F70")]
	public void TrackPVEGameEnd(XGameData gameData, int teamLevel, bool isClearTicket = false)
	{
	}

	[Token(Token = "0x60056B5")]
	[Address(RVA = "0x183D500", Offset = "0x183D500", VA = "0x183D500")]
	public void TrackGameStart()
	{
	}

	[Token(Token = "0x60056B6")]
	[Address(RVA = "0x18227D0", Offset = "0x18227D0", VA = "0x18227D0")]
	public void TrackGameEnd(XPlayerManager m_playerManager, bool isExit, bool isPve = false, bool isGiveup = false, int starScore = 0)
	{
	}

	[Token(Token = "0x60056B7")]
	[Address(RVA = "0x183EAC8", Offset = "0x183EAC8", VA = "0x183EAC8")]
	public void TrackOnTag(XModuleActor actor, float previousHP, int tagSkillID)
	{
	}

	[Token(Token = "0x60056B8")]
	[Address(RVA = "0x183F308", Offset = "0x183F308", VA = "0x183F308")]
	public void AddSkillCoolTimeString(StringBuilder logParamBuilder, int skillId, XModuleSkill moduleSkill)
	{
	}

	[Token(Token = "0x60056B9")]
	[Address(RVA = "0x1838C48", Offset = "0x1838C48", VA = "0x1838C48")]
	public string GetMatchLogString(string battleIdx, int waitTime, bool isMatchSuccess, bool isAutoStart)
	{
		return null;
	}

	[Token(Token = "0x60056BA")]
	[Address(RVA = "0x1838308", Offset = "0x1838308", VA = "0x1838308")]
	public string GetCharcterParamString(List<string> party, bool isCachedCharacter = false)
	{
		return null;
	}

	[Token(Token = "0x60056BB")]
	[Address(RVA = "0x183F38C", Offset = "0x183F38C", VA = "0x183F38C")]
	public string GetRankEloParanString()
	{
		return null;
	}

	[Token(Token = "0x60056BC")]
	[Address(RVA = "0x183A180", Offset = "0x183A180", VA = "0x183A180")]
	public string GetRankParamString()
	{
		return null;
	}

	[Token(Token = "0x60056BD")]
	[Address(RVA = "0x1838238", Offset = "0x1838238", VA = "0x1838238")]
	public void SetCohortELOTIER()
	{
	}

	[Token(Token = "0x60056BE")]
	[Address(RVA = "0x183F64C", Offset = "0x183F64C", VA = "0x183F64C")]
	public string GetRankTier(RankType rankType)
	{
		return null;
	}

	[Token(Token = "0x60056BF")]
	[Address(RVA = "0x183865C", Offset = "0x183865C", VA = "0x183865C")]
	public string GetCurrencyParmString()
	{
		return null;
	}

	[Token(Token = "0x60056C0")]
	[Address(RVA = "0x183F80C", Offset = "0x183F80C", VA = "0x183F80C")]
	public void TrackEventQuest(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x60056C1")]
	[Address(RVA = "0x183FB48", Offset = "0x183FB48", VA = "0x183FB48")]
	public void TrackArenaShop(IShopItem shopItem, bool isBuyFree)
	{
	}

	[Token(Token = "0x60056C2")]
	[Address(RVA = "0x184046C", Offset = "0x184046C", VA = "0x184046C")]
	private int GetTeamLevel()
	{
		return default(int);
	}

	[Token(Token = "0x60056C3")]
	[Address(RVA = "0x1840584", Offset = "0x1840584", VA = "0x1840584")]
	public bool TrackEmoticon(CSEmoticonSetInfo emoticonSetInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60056C4")]
	[Address(RVA = "0x1840788", Offset = "0x1840788", VA = "0x1840788")]
	public void TrackInGameAD(string sceneName, int id)
	{
	}

	[Token(Token = "0x60056C5")]
	[Address(RVA = "0x1840910", Offset = "0x1840910", VA = "0x1840910")]
	public void TrackEventMedalShopAD(string sceneName)
	{
	}

	[Token(Token = "0x60056C6")]
	[Address(RVA = "0x1840A70", Offset = "0x1840A70", VA = "0x1840A70")]
	public void TrackShop(IShopItem item, bool isBuyFree)
	{
	}

	[Token(Token = "0x60056C7")]
	[Address(RVA = "0x183FBE8", Offset = "0x183FBE8", VA = "0x183FBE8")]
	private void TrackShop(bool isNormaShopLog, string shopName, IShopItem shopItem, bool isBuyFree)
	{
	}

	[Token(Token = "0x60056C8")]
	[Address(RVA = "0x1840CA8", Offset = "0x1840CA8", VA = "0x1840CA8")]
	public void TrackEventForGetCharacter(int characterID)
	{
	}

	[Token(Token = "0x60056C9")]
	[Address(RVA = "0x1840DBC", Offset = "0x1840DBC", VA = "0x1840DBC")]
	public void HandleConnectSuccess()
	{
	}

	[Token(Token = "0x60056CA")]
	[Address(RVA = "0x184100C", Offset = "0x184100C", VA = "0x184100C")]
	public void HandleConnectFailure()
	{
	}
}
