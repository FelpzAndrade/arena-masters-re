using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000636")]
public static class XNewQuestCompleteLogic
{
	[Token(Token = "0x4001DFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly List<Type> IgnoreCommandList;

	[Token(Token = "0x600356F")]
	[Address(RVA = "0x1EC1400", Offset = "0x1EC1400", VA = "0x1EC1400")]
	public static void UpdateForInitialTime()
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0x1ED22C4", Offset = "0x1ED22C4", VA = "0x1ED22C4")]
	public static bool IsResetTime(XMyInfo user, int resetHour, [Optional] DayOfWeek? ResetWeeklyStatsDay)
	{
		return default(bool);
	}

	[Token(Token = "0x6003571")]
	[Address(RVA = "0x1EC9E70", Offset = "0x1EC9E70", VA = "0x1EC9E70")]
	public static List<int> GetQuestClearedList()
	{
		return null;
	}

	[Token(Token = "0x6003572")]
	[Address(RVA = "0x1ED2434", Offset = "0x1ED2434", VA = "0x1ED2434")]
	public static List<int> GetNexonCPQClearedList()
	{
		return null;
	}

	[Token(Token = "0x6003573")]
	[Address(RVA = "0x1ED2948", Offset = "0x1ED2948", VA = "0x1ED2948")]
	public static List<int> GetNexonCPQCompleteableList()
	{
		return null;
	}

	[Token(Token = "0x6003574")]
	[Address(RVA = "0x1ECA2F8", Offset = "0x1ECA2F8", VA = "0x1ECA2F8")]
	public static List<int> GetIronsClearedList()
	{
		return null;
	}

	[Token(Token = "0x6003575")]
	[Address(RVA = "0x1ED2E60", Offset = "0x1ED2E60", VA = "0x1ED2E60")]
	private static QuestInfo GetNewIronsInfo(List<int> newIronsList)
	{
		return null;
	}

	[Token(Token = "0x6003576")]
	[Address(RVA = "0x1ED3100", Offset = "0x1ED3100", VA = "0x1ED3100")]
	private static QuestInfo GetNewNexonCPQInfo(List<int> newIronsList)
	{
		return null;
	}

	[Token(Token = "0x6003577")]
	[Address(RVA = "0x1ED33A0", Offset = "0x1ED33A0", VA = "0x1ED33A0")]
	private static TitleInfo GetNewTitleInfo(List<int> newTitleList)
	{
		return null;
	}

	[Token(Token = "0x6003578")]
	[Address(RVA = "0x1ED3548", Offset = "0x1ED3548", VA = "0x1ED3548")]
	public static void Update()
	{
	}

	[Token(Token = "0x6003579")]
	[Address(RVA = "0x1ED3624", Offset = "0x1ED3624", VA = "0x1ED3624")]
	private static void UpdateQuests()
	{
	}

	[Token(Token = "0x600357A")]
	[Address(RVA = "0x1ED3E48", Offset = "0x1ED3E48", VA = "0x1ED3E48")]
	private static void UpdateCPQComplete()
	{
	}

	[Token(Token = "0x600357B")]
	[Address(RVA = "0x1ED4118", Offset = "0x1ED4118", VA = "0x1ED4118")]
	private static void AutoNotifyNexonCPQComplete(List<int> newNexonCPQList)
	{
	}

	[Token(Token = "0x600357C")]
	[Address(RVA = "0x1ED3B34", Offset = "0x1ED3B34", VA = "0x1ED3B34")]
	private static void UpdateTitles()
	{
	}

	[Token(Token = "0x600357D")]
	[Address(RVA = "0x1ED21DC", Offset = "0x1ED21DC", VA = "0x1ED21DC")]
	private static bool IsUpdateableGameFlow()
	{
		return default(bool);
	}
}
