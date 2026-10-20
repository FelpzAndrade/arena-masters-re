using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200069D")]
public class XHelper
{
	[Token(Token = "0x200069E")]
	public class UIDChecker
	{
		[Token(Token = "0x4002031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int arrayMaxSize;

		[Token(Token = "0x4002032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private uint[] m_UIDArray;

		[Token(Token = "0x4002033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int m_index;

		[Token(Token = "0x4002034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint m_lastUID;

		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x1D1EEC0", Offset = "0x1D1EEC0", VA = "0x1D1EEC0")]
		public UIDChecker()
		{
		}

		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x1D1F038", Offset = "0x1D1F038", VA = "0x1D1F038")]
		public bool Check(uint colUID)
		{
			return default(bool);
		}

		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x1D1F180", Offset = "0x1D1F180", VA = "0x1D1F180")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200069F")]
	public class TimeChecker
	{
		[Token(Token = "0x4002035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private float m_endTime;

		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x1D1EE88", Offset = "0x1D1EE88", VA = "0x1D1EE88")]
		public TimeChecker()
		{
		}

		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x1D1EE90", Offset = "0x1D1EE90", VA = "0x1D1EE90")]
		public void Start(float startTime, float period)
		{
		}

		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x1D1EEA4", Offset = "0x1D1EEA4", VA = "0x1D1EEA4")]
		public bool IsOver(float curTime)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006A0")]
	public class XIntervalUpdater
	{
		[Token(Token = "0x20006A1")]
		public delegate bool CheckAction();

		[Token(Token = "0x4002036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool m_isLoop;

		[Token(Token = "0x4002037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float m_TickTime;

		[Token(Token = "0x4002038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float m_intervalTime;

		[Token(Token = "0x4002039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private CheckAction m_action;

		[Token(Token = "0x400203A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isEnable;

		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x1D1F36C", Offset = "0x1D1F36C", VA = "0x1D1F36C")]
		public XIntervalUpdater(float invervalTime, CheckAction action, bool isLoop)
		{
		}

		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x1D1F3A4", Offset = "0x1D1F3A4", VA = "0x1D1F3A4")]
		public void Update()
		{
		}
	}

	[Token(Token = "0x20006A2")]
	public struct XColInfo
	{
		[Token(Token = "0x400203B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float fDistance;

		[Token(Token = "0x400203C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Collider col;

		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x1D1F304", Offset = "0x1D1F304", VA = "0x1D1F304", Slot = "4")]
		private int System_002ECollections_002EIComparer_002ECompare(object a, object b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4002030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint m_nGenID;

	[Token(Token = "0x6003771")]
	[Address(RVA = "0x1D18338", Offset = "0x1D18338", VA = "0x1D18338")]
	public XHelper()
	{
	}

	[Token(Token = "0x6003773")]
	[Address(RVA = "0x1D18344", Offset = "0x1D18344", VA = "0x1D18344")]
	public static void GetPetStatString(CSProtoInfoManager_BalancePet protoBalance, int petLevel, CSCharacterInfo charInfo, out string teamEXP, out string medal, out string gold)
	{
		gold = default;
		medal = default;
		teamEXP = default;
	}

	[Token(Token = "0x6003774")]
	[Address(RVA = "0x1D185A0", Offset = "0x1D185A0", VA = "0x1D185A0")]
	public static void GetPetTotalStat(CSProtoInfoManager_BalancePet protoBalance, List<XModuleActor> petActorList, out int totalTeamEXP, out float totalMedal, out float totalGold)
	{
		totalGold = default;
		totalMedal = default;
		totalTeamEXP = default;
	}

	[Token(Token = "0x6003775")]
	[Address(RVA = "0x1D18840", Offset = "0x1D18840", VA = "0x1D18840")]
	public static string ToMd5(byte[] input)
	{
		return null;
	}

	[Token(Token = "0x6003776")]
	[Address(RVA = "0x1D189A8", Offset = "0x1D189A8", VA = "0x1D189A8")]
	public static float ByteToMegaByte(int bytes)
	{
		return default(float);
	}

	[Token(Token = "0x6003777")]
	[Address(RVA = "0x1D189C4", Offset = "0x1D189C4", VA = "0x1D189C4")]
	public static string GetDeviceUid()
	{
		return null;
	}

	[Token(Token = "0x6003778")]
	[Address(RVA = "0x1D189D0", Offset = "0x1D189D0", VA = "0x1D189D0")]
	public static bool IsNull(object aObj)
	{
		return default(bool);
	}

	[Token(Token = "0x6003779")]
	[Address(RVA = "0x1D18A1C", Offset = "0x1D18A1C", VA = "0x1D18A1C")]
	public static bool IsSelectTeamSetting(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x600377A")]
	[Address(RVA = "0x1D18C08", Offset = "0x1D18C08", VA = "0x1D18C08")]
	public static bool IsPVE()
	{
		return default(bool);
	}

	[Token(Token = "0x600377B")]
	[Address(RVA = "0x1D18D2C", Offset = "0x1D18D2C", VA = "0x1D18D2C")]
	public static bool IsTeamMode(XGameModeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600377C")]
	[Address(RVA = "0x1D18D38", Offset = "0x1D18D38", VA = "0x1D18D38")]
	public static bool IsReviveMode(XGameModeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600377D")]
	[Address(RVA = "0x1D18D44", Offset = "0x1D18D44", VA = "0x1D18D44")]
	public static bool IsHeadStoneMode(XGameModeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600377E")]
	[Address(RVA = "0x1D18D50", Offset = "0x1D18D50", VA = "0x1D18D50")]
	public static bool IsUITeamMode(XGameModeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600377F")]
	[Address(RVA = "0x1D18D20", Offset = "0x1D18D20", VA = "0x1D18D20")]
	public static bool IsPVE(XGameModeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003780")]
	[Address(RVA = "0x1D18D5C", Offset = "0x1D18D5C", VA = "0x1D18D5C")]
	public static string CurrentSectorName()
	{
		return null;
	}

	[Token(Token = "0x6003781")]
	[Address(RVA = "0x1D19000", Offset = "0x1D19000", VA = "0x1D19000")]
	internal static string GetAPIReturnCodeMsg(ApiReturnCode nErrorCode)
	{
		return null;
	}

	[Token(Token = "0x6003782")]
	[Address(RVA = "0x1D19174", Offset = "0x1D19174", VA = "0x1D19174")]
	public static XGameModeType ToGameModeType(MissionPlayPattern type)
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6003783")]
	[Address(RVA = "0x1D191A4", Offset = "0x1D191A4", VA = "0x1D191A4")]
	public static bool IsPVPMatchOrArenaType(GameModeInfo gameModeInfo, CSStageInfo stageInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6003784")]
	[Address(RVA = "0x1D19200", Offset = "0x1D19200", VA = "0x1D19200")]
	public static Dictionary<int, int> GetSelectedTalentPage()
	{
		return null;
	}

	[Token(Token = "0x6003785")]
	[Address(RVA = "0x1D195E4", Offset = "0x1D195E4", VA = "0x1D195E4")]
	public static GameObject Find(GameObject go, params string[] list)
	{
		return null;
	}

	[Token(Token = "0x6003786")]
	[Address(RVA = "0x1D197FC", Offset = "0x1D197FC", VA = "0x1D197FC")]
	public static GameObject FindRecursively(GameObject go, string name)
	{
		return null;
	}

	[Token(Token = "0x6003787")]
	[Address(RVA = "0x1D19CA0", Offset = "0x1D19CA0", VA = "0x1D19CA0")]
	public static void FindRecursivelySkinnedMeshRenderer(GameObject go, List<SkinnedMeshRenderer> listFound)
	{
	}

	[Token(Token = "0x6003788")]
	[Address(RVA = "0x1D1A090", Offset = "0x1D1A090", VA = "0x1D1A090")]
	public static void SetLayerRecursively(GameObject go, int nLayer)
	{
	}

	[Token(Token = "0x6003789")]
	[Address(RVA = "0x1D1A3F8", Offset = "0x1D1A3F8", VA = "0x1D1A3F8")]
	public static void ClearParticleRecursively(GameObject go)
	{
	}

	[Token(Token = "0x600378A")]
	[Address(RVA = "0x1D1A7FC", Offset = "0x1D1A7FC", VA = "0x1D1A7FC")]
	public static bool DiceRate(int nRate)
	{
		return UnityEngine.Random.Range(1, 101) <= nRate;
	}

	[Token(Token = "0x600378B")]
	[Address(RVA = "0x1D1A830", Offset = "0x1D1A830", VA = "0x1D1A830")]
	public static bool DiceRate(float fDice)
	{
		return UnityEngine.Random.Range(0f, 100f) <= fDice;
	}

	[Token(Token = "0x600378C")]
	[Address(RVA = "0x1D1A874", Offset = "0x1D1A874", VA = "0x1D1A874")]
	public static float GetRandom(float fMin, float fMax)
	{
		return default(float);
	}

	[Token(Token = "0x600378D")]
	[Address(RVA = "0x1D1A880", Offset = "0x1D1A880", VA = "0x1D1A880")]
	public static int GetRandom(int nMin, int nMax)
	{
		return default(int);
	}

	[Token(Token = "0x600378E")]
	[Address(RVA = "0x1D1A890", Offset = "0x1D1A890", VA = "0x1D1A890")]
	public static int GetRandom(List<int> value_list)
	{
		return default(int);
	}

	[Token(Token = "0x600378F")]
	[Address(RVA = "0x1D1A9C0", Offset = "0x1D1A9C0", VA = "0x1D1A9C0")]
	public static string GetRandom(string[] arr)
	{
		return null;
	}

	[Token(Token = "0x6003790")]
	[Address(RVA = "0x1D1AB04", Offset = "0x1D1AB04", VA = "0x1D1AB04")]
	public static string GetRandom(List<string> value_list)
	{
		return null;
	}

	[Token(Token = "0x6003791")]
	[Address(RVA = "0x1D1AC84", Offset = "0x1D1AC84", VA = "0x1D1AC84")]
	public static void CaptureScreenShot()
	{
	}

	[Token(Token = "0x6003792")]
	[Address(RVA = "0x1D1B148", Offset = "0x1D1B148", VA = "0x1D1B148")]
	public static bool IsInGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6003793")]
	[Address(RVA = "0x1D1B26C", Offset = "0x1D1B26C", VA = "0x1D1B26C")]
	public static string GetPhotonPlayerName(XModuleEntity me)
	{
		return null;
	}

	[Token(Token = "0x6003794")]
	[Address(RVA = "0x1D1B3C0", Offset = "0x1D1B3C0", VA = "0x1D1B3C0")]
	public static bool CheckShopItemBuyFree(CSShopItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6003795")]
	[Address(RVA = "0x1D1B664", Offset = "0x1D1B664", VA = "0x1D1B664")]
	public static bool CheckShopItemNewBadgeEnabled(CSShopItem shopItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6003796")]
	[Address(RVA = "0x1D1B6A4", Offset = "0x1D1B6A4", VA = "0x1D1B6A4")]
	internal static int GetRoomEmptyTtl(XGameModeType nGameModeType, MatchType nMatchType)
	{
		return default(int);
	}

	[Token(Token = "0x6003797")]
	[Address(RVA = "0x1D1B74C", Offset = "0x1D1B74C", VA = "0x1D1B74C")]
	private static bool IsServerMatchingType(MatchType nMatchType)
	{
		return default(bool);
	}

	[Token(Token = "0x6003798")]
	[Address(RVA = "0x1D1B760", Offset = "0x1D1B760", VA = "0x1D1B760")]
	public static bool IsShowedItem(CSShopItem itemInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6003799")]
	[Address(RVA = "0x1D1BCE0", Offset = "0x1D1BCE0", VA = "0x1D1BCE0")]
	public static uint GenerateUID()
	{
		return default(uint);
	}

	[Token(Token = "0x600379A")]
	[Address(RVA = "0x1D1BD98", Offset = "0x1D1BD98", VA = "0x1D1BD98")]
	public static bool CheckGameModeSneak()
	{
		return default(bool);
	}

	[Token(Token = "0x600379B")]
	[Address(RVA = "0x1D1BF98", Offset = "0x1D1BF98", VA = "0x1D1BF98")]
	public static bool CheckCurrentGameModeStateIsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600379C")]
	[Address(RVA = "0x1D1C0B0", Offset = "0x1D1C0B0", VA = "0x1D1C0B0")]
	public static bool CheckCurrentGameModeStateIsPlaying(XGameModeStateType nGameModeState)
	{
		return default(bool);
	}

	[Token(Token = "0x600379D")]
	[Address(RVA = "0x1D1C0C0", Offset = "0x1D1C0C0", VA = "0x1D1C0C0")]
	public static bool CheckCharTagButtonEnabled(GameModeInfo gameModeInfo, XGameModeStateType currentStateType)
	{
		return default(bool);
	}

	[Token(Token = "0x600379E")]
	[Address(RVA = "0x1D1C100", Offset = "0x1D1C100", VA = "0x1D1C100")]
	public static float DistanceXZ(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[Token(Token = "0x600379F")]
	[Address(RVA = "0x1D1C134", Offset = "0x1D1C134", VA = "0x1D1C134")]
	public static float DistanceXZSquared(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[Token(Token = "0x60037A0")]
	[Address(RVA = "0x1D1C160", Offset = "0x1D1C160", VA = "0x1D1C160")]
	public static TimeSpan GetDiffTimeSpan(DateTime lastTime)
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x60037A1")]
	[Address(RVA = "0x1D1C2EC", Offset = "0x1D1C2EC", VA = "0x1D1C2EC")]
	public static TimeSpan GetDiffCoolTimeSpan(DateTime lastTime, int coolTime)
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x60037A2")]
	[Address(RVA = "0x1D1C4B0", Offset = "0x1D1C4B0", VA = "0x1D1C4B0")]
	public static string GetRemainTimeString(double remainedSec, string isBefore = "")
	{
		return null;
	}

	[Token(Token = "0x60037A3")]
	[Address(RVA = "0x1D1CB98", Offset = "0x1D1CB98", VA = "0x1D1CB98")]
	public static string GetDiffTimeString(DateTime lastTime, string isBefore = "")
	{
		return null;
	}

	[Token(Token = "0x60037A4")]
	[Address(RVA = "0x1D1C618", Offset = "0x1D1C618", VA = "0x1D1C618")]
	public static string GetRemainTimeToString(int days, int hours, int minutes, int second, string isBefore = "")
	{
		return null;
	}

	[Token(Token = "0x60037A5")]
	[Address(RVA = "0x1D1CCB0", Offset = "0x1D1CCB0", VA = "0x1D1CCB0")]
	public static string GetDiffTimeStringOneStatement(DateTime lastTime)
	{
		return null;
	}

	[Token(Token = "0x60037A6")]
	[Address(RVA = "0x1D1CDE0", Offset = "0x1D1CDE0", VA = "0x1D1CDE0")]
	public static string GetRemainTimeToStringOneStatement(int days, int hours, int minutes, int second)
	{
		return null;
	}

	[Token(Token = "0x60037A7")]
	[Address(RVA = "0x1D1D2E8", Offset = "0x1D1D2E8", VA = "0x1D1D2E8")]
	public static void GetRemainTime(double remainedSec, out int hours, out int days, out int mins, out int secs)
	{
		days = default;
		hours = default;
		mins = default;
		secs = default;
	}

	[Token(Token = "0x60037A8")]
	[Address(RVA = "0x1D1D3B8", Offset = "0x1D1D3B8", VA = "0x1D1D3B8")]
	public static string GetRemainTimeToString(TimeSpan timeSpan)
	{
		return null;
	}

	[Token(Token = "0x60037A9")]
	[Address(RVA = "0x1D1D948", Offset = "0x1D1D948", VA = "0x1D1D948")]
	public static string GetRemainHourAndMinuteString(double remainedSec, string isBefore = "")
	{
		return null;
	}

	[Token(Token = "0x60037AA")]
	[Address(RVA = "0x1D1DA68", Offset = "0x1D1DA68", VA = "0x1D1DA68")]
	public static string GetRemainHourAndMinuteToString(int days, int hours, int minutes)
	{
		return null;
	}

	[Token(Token = "0x60037AB")]
	[Address(RVA = "0x1D1DC1C", Offset = "0x1D1DC1C", VA = "0x1D1DC1C")]
	private static string GetTimeString(string year, string month, string day, [Optional] string hour, [Optional] string min)
	{
		return null;
	}

	[Token(Token = "0x60037AC")]
	[Address(RVA = "0x1D1DE60", Offset = "0x1D1DE60", VA = "0x1D1DE60")]
	public static string GetParseStringForDateTime(DateTime lastTime)
	{
		return null;
	}

	[Token(Token = "0x60037AD")]
	[Address(RVA = "0x1D1E020", Offset = "0x1D1E020", VA = "0x1D1E020")]
	public static StringBuilder GetRemainCooltimeToString(DateTime coolEndTime)
	{
		return null;
	}

	[Token(Token = "0x60037AE")]
	[Address(RVA = "0x1D1E4EC", Offset = "0x1D1E4EC", VA = "0x1D1E4EC")]
	public static string ParsingPeriodTimeToString(string itemPeriodTime)
	{
		return null;
	}

	[Token(Token = "0x60037AF")]
	[Address(RVA = "0x1D1E778", Offset = "0x1D1E778", VA = "0x1D1E778")]
	internal static int GetMaxChannel()
	{
		return default(int);
	}

	[Token(Token = "0x60037B0")]
	[Address(RVA = "0x1D1E828", Offset = "0x1D1E828", VA = "0x1D1E828")]
	public static int GetPingGroup(int ping)
	{
		return default(int);
	}

	[Token(Token = "0x60037B1")]
	[Address(RVA = "0x1D1EA7C", Offset = "0x1D1EA7C", VA = "0x1D1EA7C")]
	public static bool IsNewbieLevel(int nMyTeamLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x60037B2")]
	[Address(RVA = "0x1D1EB90", Offset = "0x1D1EB90", VA = "0x1D1EB90")]
	public static bool IsNewbieQuickMatchOption()
	{
		return default(bool);
	}

	[Token(Token = "0x60037B3")]
	[Address(RVA = "0x1D1ECA0", Offset = "0x1D1ECA0", VA = "0x1D1ECA0")]
	public static string GetWantRegionGameServer(string country, string testRegionServerKey = "")
	{
		return null;
	}

	[Token(Token = "0x60037B4")]
	[Address(RVA = "0x1D1EE60", Offset = "0x1D1EE60", VA = "0x1D1EE60")]
	internal static bool IsPermanentlyBlockTime(long remainSec)
	{
		return default(bool);
	}
}
