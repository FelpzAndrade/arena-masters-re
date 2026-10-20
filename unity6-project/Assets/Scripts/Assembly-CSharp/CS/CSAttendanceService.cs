using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008F1")]
	public class CSAttendanceService
	{
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x8")]
		private CSProtoInfoManager_AttendanceBook m_proto;

		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x23EF0EC", Offset = "0x23EF0EC", VA = "0x23EF0EC")]
		public CSAttendanceService(CSProtoInfoManager_AttendanceBook proto)
		{
		}

		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x23EF10C", Offset = "0x23EF10C", VA = "0x23EF10C")]
		public bool CheckAttendance(UserDataBase user, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x23EF2E8", Offset = "0x23EF2E8", VA = "0x23EF2E8")]
		public bool CheckAttendance(long TimeStamp, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x23EF49C", Offset = "0x23EF49C", VA = "0x23EF49C")]
		private int GetUtcHour(long serverTime, long serverLocalTime)
		{
			return default(int);
		}

		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x23EF544", Offset = "0x23EF544", VA = "0x23EF544")]
		public DateTime AttendanceClientLocal(long serverTime, long serverLocalTime, long timeStamp)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x23EF6DC", Offset = "0x23EF6DC", VA = "0x23EF6DC")]
		public CSContent GetReward(UserDataBase user, int getIndex = -1)
		{
			return null;
		}

		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x23EF9B0", Offset = "0x23EF9B0", VA = "0x23EF9B0")]
		private CSContent GetReward(int index)
		{
			return null;
		}

		[Token(Token = "0x60047AD")]
		[Address(RVA = "0x23EFB58", Offset = "0x23EFB58", VA = "0x23EFB58")]
		public List<CSContent> GetRewardGroup(UserDataBase user)
		{
			return null;
		}

		[Token(Token = "0x60047AE")]
		[Address(RVA = "0x23EFC8C", Offset = "0x23EFC8C", VA = "0x23EFC8C")]
		public List<CSContent> GetWholeRewards(UserDataBase user)
		{
			return null;
		}

		[Token(Token = "0x60047AF")]
		[Address(RVA = "0x23EFE54", Offset = "0x23EFE54", VA = "0x23EFE54")]
		private int GetAttendanceDays(UserDataBase user)
		{
			return default(int);
		}

		[Token(Token = "0x60047B0")]
		[Address(RVA = "0x23EFFB0", Offset = "0x23EFFB0", VA = "0x23EFFB0")]
		public void IncrementDays(UserDataBase user)
		{
		}

		[Token(Token = "0x60047B1")]
		[Address(RVA = "0x23EF844", Offset = "0x23EF844", VA = "0x23EF844")]
		public int GetIndex(UserDataBase user)
		{
			return default(int);
		}

		[Token(Token = "0x60047B2")]
		[Address(RVA = "0x23F0270", Offset = "0x23F0270", VA = "0x23F0270")]
		public int GetIndexInGroup(UserDataBase user)
		{
			return default(int);
		}

		[Token(Token = "0x60047B3")]
		[Address(RVA = "0x23F02A4", Offset = "0x23F02A4", VA = "0x23F02A4")]
		private int GetIndexInGroup(int index)
		{
			return default(int);
		}
	}
}
