using System;
using System.Runtime.InteropServices;
using CS.ranking;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008CD")]
	public static class CSTimeHelper
	{
		[Token(Token = "0x17000990")]
		public static long UTCDefaultValue
		{
			[Token(Token = "0x6004706")]
			[Address(RVA = "0x1CD7684", Offset = "0x1CD7684", VA = "0x1CD7684")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6004707")]
		[Address(RVA = "0x1CD7784", Offset = "0x1CD7784", VA = "0x1CD7784")]
		public static bool CheckexpiredTime(DateTime checkTime, DateTime now, TimeSpan checkTimeSpan)
		{
			return default(bool);
		}

		[Token(Token = "0x6004708")]
		[Address(RVA = "0x1CD78CC", Offset = "0x1CD78CC", VA = "0x1CD78CC")]
		public static bool CheckResetTime(DateTime checkTime, DateTime now, TimeSpan resetTimeSpan, [Optional] DayOfWeek? resetDayOfWeek)
		{
			return default(bool);
		}

		[Token(Token = "0x6004709")]
		[Address(RVA = "0x1CD7A4C", Offset = "0x1CD7A4C", VA = "0x1CD7A4C")]
		private static DateTime GetClosestResetTimePast(DateTime time, TimeSpan resetTimeSpan, DayOfWeek? resetDayOfWeek)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600470A")]
		[Address(RVA = "0x1CD7F08", Offset = "0x1CD7F08", VA = "0x1CD7F08")]
		public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600470B")]
		[Address(RVA = "0x1CD7F90", Offset = "0x1CD7F90", VA = "0x1CD7F90")]
		private static DateTime GetClosestResetTimeFuture(DateTime time, TimeSpan resetTimeSpan, DayOfWeek? resetDayOfWeek)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600470C")]
		[Address(RVA = "0x1CD844C", Offset = "0x1CD844C", VA = "0x1CD844C")]
		public static TimeSpan GetRemainResetTimeWeekly(DateTime now, TimeSpan resetTime, DayOfWeek resetDay)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x600470D")]
		[Address(RVA = "0x1CD859C", Offset = "0x1CD859C", VA = "0x1CD859C")]
		public static TimeSpan GetRemainResetTimeDaily(DateTime now, TimeSpan resetTime)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x600470E")]
		[Address(RVA = "0x1CD8700", Offset = "0x1CD8700", VA = "0x1CD8700")]
		public static TimeSpan ParseResetTime(string str)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x600470F")]
		[Address(RVA = "0x1CD8B1C", Offset = "0x1CD8B1C", VA = "0x1CD8B1C")]
		public static double DifferenceSecs(DateTime oldDate, DateTime newDate)
		{
			return default(double);
		}

		[Token(Token = "0x6004710")]
		[Address(RVA = "0x1CD8C1C", Offset = "0x1CD8C1C", VA = "0x1CD8C1C")]
		public static DateTime ConvertWeekToDateTime(week w)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004711")]
		[Address(RVA = "0x1CD8E28", Offset = "0x1CD8E28", VA = "0x1CD8E28")]
		public static string GetRemainTimeString(TimeSpan remainTime)
		{
			return null;
		}

		[Token(Token = "0x6004712")]
		[Address(RVA = "0x1CD91B8", Offset = "0x1CD91B8", VA = "0x1CD91B8")]
		public static long ToTimeMS(DateTime dtTime)
		{
			return default(long);
		}

		[Token(Token = "0x6004713")]
		[Address(RVA = "0x1CD91F8", Offset = "0x1CD91F8", VA = "0x1CD91F8")]
		public static long ToTimeMS(long timeTick)
		{
			return default(long);
		}
	}
}
