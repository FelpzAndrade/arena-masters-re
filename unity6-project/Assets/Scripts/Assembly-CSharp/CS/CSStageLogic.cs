using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000910")]
	public class CSStageLogic
	{
		[Token(Token = "0x4002B85")]
		[FieldOffset(Offset = "0x8")]
		protected CSProtoInfoManager_Stage m_protoStage;

		[Token(Token = "0x4002B86")]
		[FieldOffset(Offset = "0xC")]
		protected CSProtoInfoManager_GameConst m_protoGameConst;

		[Token(Token = "0x4002B87")]
		[FieldOffset(Offset = "0x10")]
		protected CSProtoInfoManager_TimeInterval m_protoTimeInterval;

		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x14")]
		protected CSProtoInfoManager_PremiumTicket m_protoPremiumTicket;

		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x18")]
		protected Random m_random;

		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x0")]
		public static int potionId;

		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x1C")]
		protected readonly List<int> m_plunderGoldMaxScores;

		[Token(Token = "0x4002B8C")]
		[FieldOffset(Offset = "0x20")]
		protected readonly List<int> m_plunderPotionMaxScores;

		[Token(Token = "0x6004887")]
		[Address(RVA = "0x1CD46E4", Offset = "0x1CD46E4", VA = "0x1CD46E4")]
		public CSStageLogic()
		{
		}

		[Token(Token = "0x6004888")]
		[Address(RVA = "0x1CD48E0", Offset = "0x1CD48E0", VA = "0x1CD48E0")]
		public CSStageLogic(CSProtoInfoManager_Stage protoStage, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_TimeInterval protoTimeInterval, CSProtoInfoManager_PremiumTicket protoPremiumTicket)
		{
		}

		[Token(Token = "0x600488A")]
		[Address(RVA = "0x1CD4B84", Offset = "0x1CD4B84", VA = "0x1CD4B84")]
		public ApiReturnCode CheckEnterable(UserDataBase userData, int stageIndex, DateTime now)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x600488B")]
		[Address(RVA = "0x1CD5754", Offset = "0x1CD5754", VA = "0x1CD5754")]
		public bool CheckEnterableSolo(UserDataBase userData, int stageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600488C")]
		[Address(RVA = "0x1CD58D0", Offset = "0x1CD58D0", VA = "0x1CD58D0")]
		public bool HasClearedSolo(UserDataBase userData, int stageNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x600488D")]
		[Address(RVA = "0x1CD5374", Offset = "0x1CD5374", VA = "0x1CD5374")]
		public int GetClearedSolo(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x600488E")]
		[Address(RVA = "0x1CD5910", Offset = "0x1CD5910", VA = "0x1CD5910")]
		public void SaveCleardSolo(UserDataBase userData, int stageNumber)
		{
		}

		[Token(Token = "0x600488F")]
		[Address(RVA = "0x1CD5A58", Offset = "0x1CD5A58", VA = "0x1CD5A58")]
		public CSStageInfo GetCurrentSkyTowerInfo(UserDataBase userData)
		{
			return null;
		}

		[Token(Token = "0x6004890")]
		[Address(RVA = "0x1CD5B74", Offset = "0x1CD5B74", VA = "0x1CD5B74")]
		public CSStageInfo GetLastFloorSkyTowerInfo()
		{
			return null;
		}

		[Token(Token = "0x6004891")]
		[Address(RVA = "0x1CD5C80", Offset = "0x1CD5C80", VA = "0x1CD5C80")]
		public CSStageInfo GetLastSkyTowerInfo(UserDataBase userData)
		{
			return null;
		}

		[Token(Token = "0x6004892")]
		[Address(RVA = "0x1CD513C", Offset = "0x1CD513C", VA = "0x1CD513C")]
		public bool HasCleared(UserDataBase userData, int stageIndex, out int bestScore)
		{
			bestScore = default;
			return default(bool);
		}

		[Token(Token = "0x6004893")]
		[Address(RVA = "0x1CD5D9C", Offset = "0x1CD5D9C", VA = "0x1CD5D9C")]
		public CSStageInfo GetCurrentStageInfo(UserDataBase userData)
		{
			return null;
		}

		[Token(Token = "0x6004894")]
		[Address(RVA = "0x1CD6210", Offset = "0x1CD6210", VA = "0x1CD6210")]
		public bool HasCleared(UserDataBase userData, int stageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6004895")]
		[Address(RVA = "0x1CD6234", Offset = "0x1CD6234", VA = "0x1CD6234")]
		public string GetDateStatKey(int id)
		{
			return null;
		}

		[Token(Token = "0x6004896")]
		[Address(RVA = "0x1CD6388", Offset = "0x1CD6388", VA = "0x1CD6388")]
		public int GetPremiumTicketEnterSpecialDungeonBonus(UserDataBase userData, CSProtoInfoManager_PremiumTicket protoPremiumTicket, DateTime nowTime)
		{
			return default(int);
		}

		[Token(Token = "0x6004897")]
		[Address(RVA = "0x1CD56AC", Offset = "0x1CD56AC", VA = "0x1CD56AC")]
		public bool IsEnterablePlayCount(UserDataBase userData, CSStageInfo info, DateTime nowTime, int enterCnt = 1)
		{
			return default(bool);
		}

		[Token(Token = "0x6004898")]
		[Address(RVA = "0x1CD54B8", Offset = "0x1CD54B8", VA = "0x1CD54B8")]
		private bool IsPassedCoolTime(UserDataBase userData, CSStageInfo info, CSTimeInterval timeInterval, DateTime nowLocal)
		{
			return default(bool);
		}

		[Token(Token = "0x6004899")]
		[Address(RVA = "0x1CD5560", Offset = "0x1CD5560", VA = "0x1CD5560")]
		private bool IsEnterablePlayCountOnCoolTime(UserDataBase userData, CSStageInfo info, CSTimeInterval timeInterval)
		{
			return default(bool);
		}

		[Token(Token = "0x600489A")]
		[Address(RVA = "0x1CD69FC", Offset = "0x1CD69FC", VA = "0x1CD69FC")]
		public DateTime GetResetCoolTime(DateTime dtLastTimeUTC, CSStageInfo stageInfo)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600489B")]
		[Address(RVA = "0x1CD66F0", Offset = "0x1CD66F0", VA = "0x1CD66F0")]
		public int GetDateStat(UserDataBase userData, int playLimitGroup)
		{
			return default(int);
		}

		[Token(Token = "0x600489C")]
		[Address(RVA = "0x1CD6BD8", Offset = "0x1CD6BD8", VA = "0x1CD6BD8")]
		public static bool IsAvailableDayOfWeek(CSDailyDungeonDays availableDayOfWeeks, CSDailyDungeonDays dayOfWeek)
		{
			return default(bool);
		}

		[Token(Token = "0x600489D")]
		[Address(RVA = "0x1CD55D8", Offset = "0x1CD55D8", VA = "0x1CD55D8")]
		public static bool IsAvailableDayOfWeek(CSDailyDungeonDays availableDayOfWeeks, DayOfWeek dayOfWeek)
		{
			return default(bool);
		}

		[Token(Token = "0x600489E")]
		[Address(RVA = "0x1CD6BEC", Offset = "0x1CD6BEC", VA = "0x1CD6BEC")]
		private static CSDailyDungeonDays ToDungeonDay(DayOfWeek dayOfWeek)
		{
			return default(CSDailyDungeonDays);
		}

		[Token(Token = "0x600489F")]
		[Address(RVA = "0x1CD5228", Offset = "0x1CD5228", VA = "0x1CD5228")]
		public int GetCleardStageStar(UserDataBase userData, int stageGroup)
		{
			return default(int);
		}
	}
}
