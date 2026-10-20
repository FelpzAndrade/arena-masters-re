using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008CE")]
	public static class CSTimeStampHelper
	{
		[Token(Token = "0x17000991")]
		public static DateTime DefaultTimeStampTime
		{
			[Token(Token = "0x6004716")]
			[Address(RVA = "0x1CD6BA4", Offset = "0x1CD6BA4", VA = "0x1CD6BA4")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6004714")]
		[Address(RVA = "0x1CD68A0", Offset = "0x1CD68A0", VA = "0x1CD68A0")]
		public static double CalcTimeStampRemainedSecs(Dictionary<string, TimeStampData> timeStamps, string strTimeStampId, CSTimeInterval timeInterval, DateTime dtNowUTC)
		{
			return default(double);
		}

		[Token(Token = "0x6004715")]
		[Address(RVA = "0x1CD9440", Offset = "0x1CD9440", VA = "0x1CD9440")]
		public static TimeStampData GetTimeStampData(Dictionary<string, TimeStampData> timeStamps, string strTimeStampId)
		{
			return null;
		}

		[Token(Token = "0x6004717")]
		[Address(RVA = "0x1CD95A8", Offset = "0x1CD95A8", VA = "0x1CD95A8")]
		public static double CalcTimeStampRemainedSecs(DateTime dtUTCLastTime, double intervalMin, DateTime dtUTCNow)
		{
			return default(double);
		}

		[Token(Token = "0x6004718")]
		[Address(RVA = "0x1CD6B5C", Offset = "0x1CD6B5C", VA = "0x1CD6B5C")]
		public static DateTime CalcTimeStampResetCoolTimeUTC(DateTime dtUTCLastTime, double intervalMin)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6004719")]
		[Address(RVA = "0x1CD6914", Offset = "0x1CD6914", VA = "0x1CD6914")]
		public static int GetTimeStampCount(Dictionary<string, TimeStampData> timeStamps, string strTimeStampId)
		{
			return default(int);
		}

		[Token(Token = "0x600471A")]
		[Address(RVA = "0x1CD9624", Offset = "0x1CD9624", VA = "0x1CD9624")]
		public static Dictionary<string, TimeStampData> ConvertTimeStampToUTC(Dictionary<string, TimeStampData> timeStamps)
		{
			return null;
		}

		[Token(Token = "0x600471B")]
		[Address(RVA = "0x1CD98A0", Offset = "0x1CD98A0", VA = "0x1CD98A0")]
		public static long GetNewTimeStamp()
		{
			return default(long);
		}
	}
}
