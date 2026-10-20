using System;
using Il2CppDummyDll;

[Token(Token = "0x2000BBE")]
public static class XTimeHelper
{
	[Token(Token = "0x2000BBF")]
	public enum SHOW_TIME_REGION
	{
		[Token(Token = "0x4003BCD")]
		HOUR = 0,
		[Token(Token = "0x4003BCE")]
		MINUTE = 1,
		[Token(Token = "0x4003BCF")]
		SECONDS = 2
	}

	[Token(Token = "0x4003BC9")]
	private const int _m = 60;

	[Token(Token = "0x4003BCA")]
	private const int _h = 3600;

	[Token(Token = "0x4003BCB")]
	private const int _d = 86400;

	[Token(Token = "0x60054F3")]
	[Address(RVA = "0x1848270", Offset = "0x1848270", VA = "0x1848270")]
	public static int DateTimeToUnixTime(DateTime time)
	{
		return default(int);
	}

	[Token(Token = "0x60054F4")]
	[Address(RVA = "0x18483A4", Offset = "0x18483A4", VA = "0x18483A4")]
	public static int UnixTime()
	{
		return default(int);
	}

	[Token(Token = "0x60054F5")]
	[Address(RVA = "0x1848468", Offset = "0x1848468", VA = "0x1848468")]
	public static int UnixTime(int day, int hour, int min, int sec)
	{
		return default(int);
	}

	[Token(Token = "0x60054F6")]
	[Address(RVA = "0x1848490", Offset = "0x1848490", VA = "0x1848490")]
	public static int UnixTime(int hour, int min, int sec)
	{
		return default(int);
	}

	[Token(Token = "0x60054F7")]
	[Address(RVA = "0x18484A8", Offset = "0x18484A8", VA = "0x18484A8")]
	public static void Get(out int day, out int hour, out int min, out int sec, int unixtime)
	{
		day = default;
		hour = default;
		min = default;
		sec = default;
	}

	[Token(Token = "0x60054F8")]
	[Address(RVA = "0x1848520", Offset = "0x1848520", VA = "0x1848520")]
	public static string ConvertString(int unixtime)
	{
		return null;
	}

	[Token(Token = "0x60054F9")]
	[Address(RVA = "0x18488D8", Offset = "0x18488D8", VA = "0x18488D8")]
	public static DateTime UnixTimeToDateTime(long unixTimeStamp)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60054FA")]
	[Address(RVA = "0x1848960", Offset = "0x1848960", VA = "0x1848960")]
	public static int Quantize(int unixtime)
	{
		return default(int);
	}

	[Token(Token = "0x60054FB")]
	[Address(RVA = "0x182B0B8", Offset = "0x182B0B8", VA = "0x182B0B8")]
	public static float NowTime()
	{
		return default(float);
	}

	[Token(Token = "0x60054FC")]
	[Address(RVA = "0x1848A04", Offset = "0x1848A04", VA = "0x1848A04")]
	public static float DeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x60054FD")]
	[Address(RVA = "0x1848A10", Offset = "0x1848A10", VA = "0x1848A10")]
	public static float FixedDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x60054FE")]
	[Address(RVA = "0x1848A1C", Offset = "0x1848A1C", VA = "0x1848A1C")]
	public static string[] GetOpenTimeString(string time)
	{
		return null;
	}

	[Token(Token = "0x60054FF")]
	[Address(RVA = "0x1848BD0", Offset = "0x1848BD0", VA = "0x1848BD0")]
	public static bool TryGetTimeStringConditionSubdivision(TimeSpan remainTime, out string timerText, bool remain = false)
	{
		timerText = default;
		return default(bool);
	}

	[Token(Token = "0x6005500")]
	[Address(RVA = "0x1849028", Offset = "0x1849028", VA = "0x1849028")]
	public static string GetTimeByCultureInfo(TimeSpan span, string format)
	{
		return null;
	}

	[Token(Token = "0x6005501")]
	[Address(RVA = "0x1849338", Offset = "0x1849338", VA = "0x1849338")]
	public static string GetTimeFormat(bool isIncludePM, SHOW_TIME_REGION show_time_region)
	{
		return null;
	}

	[Token(Token = "0x6005502")]
	[Address(RVA = "0x18494BC", Offset = "0x18494BC", VA = "0x18494BC")]
	public static string GetTimeByLangauge(TimeSpan span, bool isIncludePM, SHOW_TIME_REGION show_time_region)
	{
		return null;
	}

	[Token(Token = "0x6005503")]
	[Address(RVA = "0x1822284", Offset = "0x1822284", VA = "0x1822284")]
	public static int GetRealTimeStartUpMs()
	{
		return default(int);
	}
}
