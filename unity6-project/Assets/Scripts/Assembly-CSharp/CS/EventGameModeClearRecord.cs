using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000956")]
	public class EventGameModeClearRecord
	{
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0x8")]
		[JsonIgnore]
		private Dictionary<int, EventGameModeRecordData> _playRecordDic;

		[Token(Token = "0x17000A78")]
		public Dictionary<int, EventGameModeRecordData> PlayRecordDic
		{
			[Token(Token = "0x6004B0D")]
			[Address(RVA = "0x1CDD594", Offset = "0x1CDD594", VA = "0x1CDD594")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B0E")]
			[Address(RVA = "0x1CDD644", Offset = "0x1CDD644", VA = "0x1CDD644")]
			set
			{
			}
		}

		[Token(Token = "0x17000A79")]
		public int Count
		{
			[Token(Token = "0x6004B0F")]
			[Address(RVA = "0x1CDD64C", Offset = "0x1CDD64C", VA = "0x1CDD64C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x1CDD58C", Offset = "0x1CDD58C", VA = "0x1CDD58C")]
		public EventGameModeClearRecord()
		{
		}

		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x1CDD6E8", Offset = "0x1CDD6E8", VA = "0x1CDD6E8")]
		public bool TryAddData(int id, DateTime expireTime, short defaultElo)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x1CDD9A4", Offset = "0x1CDD9A4", VA = "0x1CDD9A4")]
		private EventGameModeRecordData GetData(int id)
		{
			return null;
		}

		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x1CDD80C", Offset = "0x1CDD80C", VA = "0x1CDD80C")]
		public bool IsExistData(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x1CDDA64", Offset = "0x1CDDA64", VA = "0x1CDDA64")]
		public int GetMilestoneRecieveValue(int id, ConditionType condition)
		{
			return default(int);
		}

		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x1CDD05C", Offset = "0x1CDD05C", VA = "0x1CDD05C")]
		public int GetFirstRecieveValue(int id, ConditionType condition)
		{
			return default(int);
		}

		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x1CDD158", Offset = "0x1CDD158", VA = "0x1CDD158")]
		public int GetTotalRecieveValue(int id, ConditionType condition)
		{
			return default(int);
		}

		[Token(Token = "0x6004B16")]
		[Address(RVA = "0x1CDDB78", Offset = "0x1CDDB78", VA = "0x1CDDB78")]
		public void SetMilestoneRecieveValue(int id, ConditionType condition, int value)
		{
		}

		[Token(Token = "0x6004B17")]
		[Address(RVA = "0x1CDDC3C", Offset = "0x1CDDC3C", VA = "0x1CDDC3C")]
		public void SetFirstRecieveValue(int id, ConditionType condition, int value)
		{
		}

		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x1CDDD00", Offset = "0x1CDDD00", VA = "0x1CDDD00")]
		public void SetTotalRecieveValue(int id, ConditionType condition, int value)
		{
		}

		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x1CDDDC4", Offset = "0x1CDDDC4", VA = "0x1CDDDC4")]
		public int GetFailCount(int id)
		{
			return default(int);
		}

		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x1CDDDEC", Offset = "0x1CDDDEC", VA = "0x1CDDDEC")]
		public void IncreaseOneChallengeCount(int id)
		{
		}

		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x1CDDE24", Offset = "0x1CDDE24", VA = "0x1CDDE24")]
		public void IncreaseOneTotalWin(int id)
		{
		}

		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x1CDDE5C", Offset = "0x1CDDE5C", VA = "0x1CDDE5C")]
		public void UpdateMilesotneCount(int id, ConditionType conditionType)
		{
		}

		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x1CDDE94", Offset = "0x1CDDE94", VA = "0x1CDDE94")]
		public void IncreaseAchievementRank(int id, int rank)
		{
		}

		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x1CDDEF0", Offset = "0x1CDDEF0", VA = "0x1CDDEF0")]
		public void IncreaseOneFailCount(int id)
		{
		}

		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x1CDDF44", Offset = "0x1CDDF44", VA = "0x1CDDF44")]
		public int GetRepeatCount(int id)
		{
			return default(int);
		}

		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x1CDDF6C", Offset = "0x1CDDF6C", VA = "0x1CDDF6C")]
		public short GetElo(int id)
		{
			return default(short);
		}

		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x1CDDF8C", Offset = "0x1CDDF8C", VA = "0x1CDDF8C")]
		public bool IsPayed(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x1CDDFE0", Offset = "0x1CDDFE0", VA = "0x1CDDFE0")]
		public void ResetPayEnterCostRefresh(int id)
		{
		}

		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x1CDDFFC", Offset = "0x1CDDFFC", VA = "0x1CDDFFC")]
		public void PayEnterRecord(int id)
		{
		}

		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x1CDE038", Offset = "0x1CDE038", VA = "0x1CDE038")]
		public bool IsMilestoneRecieveWin(int id, ConditionType conditionType, int checkCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x1CDE088", Offset = "0x1CDE088", VA = "0x1CDE088")]
		public bool IsFirstRecieveWin(int id, ConditionType conditionType, int checkCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x1CDE0D8", Offset = "0x1CDE0D8", VA = "0x1CDE0D8")]
		public void UpdateFirstRecieveWinValue(int id, ConditionType conditionType)
		{
		}

		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x1CDE138", Offset = "0x1CDE138", VA = "0x1CDE138")]
		public void RepeatRefresh(int id)
		{
		}

		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x1CDE1A8", Offset = "0x1CDE1A8", VA = "0x1CDE1A8")]
		public void Remove(int id)
		{
		}

		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x1CDE24C", Offset = "0x1CDE24C", VA = "0x1CDE24C")]
		public string ToString(int id)
		{
			return null;
		}

		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x1CDE31C", Offset = "0x1CDE31C", VA = "0x1CDE31C")]
		public List<int> GetNeedExpireList(DateTime now)
		{
			return null;
		}

		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x1CDE5CC", Offset = "0x1CDE5CC", VA = "0x1CDE5CC")]
		public bool IsMilestoneRecived(int id, ConditionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x1CDE60C", Offset = "0x1CDE60C", VA = "0x1CDE60C")]
		public bool IsFirstRecived(int id, ConditionType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x1CDE64C", Offset = "0x1CDE64C", VA = "0x1CDE64C")]
		public void SetElo(int id, short elo)
		{
		}
	}
}
