using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008A3")]
	public static class CSHelper
	{
		[Token(Token = "0x20008A4")]
		public interface IWeightedRandomItem
		{
			[Token(Token = "0x17000986")]
			int Weight
			{
				[Token(Token = "0x600461D")]
				get;
				[Token(Token = "0x600461E")]
				set;
			}
		}

		[Token(Token = "0x4002A7B")]
		[FieldOffset(Offset = "0x0")]
		private static Random randomInstnace;

		[Token(Token = "0x4002A7C")]
		[FieldOffset(Offset = "0x4")]
		private static Random rng;

		[Token(Token = "0x4002A7D")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024mapF;

		[Token(Token = "0x4002A7E")]
		[FieldOffset(Offset = "0xC")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map10;

		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x2232668", Offset = "0x2232668", VA = "0x2232668")]
		public static string GetetDayKeyType(DayOfWeek day)
		{
			return null;
		}

		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x2232708", Offset = "0x2232708", VA = "0x2232708")]
		public static bool CheckLadderOpenTime(string time, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x2232CA0", Offset = "0x2232CA0", VA = "0x2232CA0")]
		public static DateTime GetLadderOpenStartTime(string time, DateTime now)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x2232FE0", Offset = "0x2232FE0", VA = "0x2232FE0")]
		public static DateTime GetLadderOpenEndTime(string time, DateTime now)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x2233320", Offset = "0x2233320", VA = "0x2233320")]
		public static string GetLadderOpenStartOrEndRemainTime(CSProtoInfoManager_GameConst gameConst, DateTime now, bool isModeOpen, string openTime)
		{
			return null;
		}

		[Token(Token = "0x6004600")]
		public static Type GetDeclaredType<TSelf>(TSelf self)
		{
			return null;
		}

		[Token(Token = "0x6004601")]
		[Address(RVA = "0x2233544", Offset = "0x2233544", VA = "0x2233544")]
		public static Currency CurrencyFromContentType(CSContentType SourceType)
		{
			return default(Currency);
		}

		[Token(Token = "0x6004602")]
		[Address(RVA = "0x2233574", Offset = "0x2233574", VA = "0x2233574")]
		public static CSContentType ContentTypeFromCurrency(Currency SourceType)
		{
			return default(CSContentType);
		}

		[Token(Token = "0x6004603")]
		[Address(RVA = "0x22335A4", Offset = "0x22335A4", VA = "0x22335A4")]
		public static Currency SaleCostTypeToCurrency(string strSale)
		{
			return default(Currency);
		}

		[Token(Token = "0x6004604")]
		[Address(RVA = "0x223387C", Offset = "0x223387C", VA = "0x223387C")]
		public static StallType ToStallType(ShopItemCategory cat)
		{
			return default(StallType);
		}

		[Token(Token = "0x6004605")]
		[Address(RVA = "0x2233894", Offset = "0x2233894", VA = "0x2233894")]
		public static string[] StringToStringArr(string str, char symbol = ',')
		{
			return null;
		}

		[Token(Token = "0x6004606")]
		[Address(RVA = "0x2233AA4", Offset = "0x2233AA4", VA = "0x2233AA4")]
		public static int[] StringToIntArr(string str, char symbol = ',')
		{
			return null;
		}

		[Token(Token = "0x6004607")]
		[Address(RVA = "0x2233C9C", Offset = "0x2233C9C", VA = "0x2233C9C")]
		public static bool StringToFloatArr(string str, out float[] arr, char symbol = ',')
		{
			arr = default;
			return default(bool);
		}

		[Token(Token = "0x6004608")]
		[Address(RVA = "0x2233F44", Offset = "0x2233F44", VA = "0x2233F44")]
		public static string ReplaceCodeText(string strText)
		{
			if (string.IsNullOrEmpty(strText))
			{
				return strText;
			}
			return strText.Replace("[BR]", "\n");
		}

		[Token(Token = "0x6004609")]
		[Address(RVA = "0x2234048", Offset = "0x2234048", VA = "0x2234048")]
		public static string ListStringToCommaSeparateString(List<string> listStr)
		{
			return null;
		}

		[Token(Token = "0x600460A")]
		[Address(RVA = "0x223439C", Offset = "0x223439C", VA = "0x223439C")]
		public static List<string> CommaSeparateStringToListString(string str)
		{
			return null;
		}

		[Token(Token = "0x600460B")]
		[Address(RVA = "0x2234520", Offset = "0x2234520", VA = "0x2234520")]
		public static void RandomInit()
		{
		}

		[Token(Token = "0x600460C")]
		[Address(RVA = "0x223466C", Offset = "0x223466C", VA = "0x223466C")]
		public static bool DiceRate(int nRate)
		{
			return default(bool);
		}

		[Token(Token = "0x600460D")]
		[Address(RVA = "0x2234828", Offset = "0x2234828", VA = "0x2234828")]
		public static bool DiceRate(float nRate)
		{
			return default(bool);
		}

		[Token(Token = "0x600460E")]
		[Address(RVA = "0x2234720", Offset = "0x2234720", VA = "0x2234720")]
		public static int GetRandom(int nMin, int nMax)
		{
			return default(int);
		}

		[Token(Token = "0x600460F")]
		public static T PickRandomItem<T>(List<T> collection)
		{
			return (T)default;
		}

		[Token(Token = "0x6004610")]
		public static T PickWeightedRandom<T>(List<T> list) where T : IWeightedRandomItem
		{
			return (T)default;
		}

		[Token(Token = "0x6004611")]
		[Address(RVA = "0x2234954", Offset = "0x2234954", VA = "0x2234954")]
		public static MemoryStream CreateMemStreamFromFileLoader(CSFileLoaderBase loader)
		{
			return null;
		}

		[Token(Token = "0x6004612")]
		public static void ModifyEach<T>(this IList<T> source, Func<T, T> projection)
		{
		}

		[Token(Token = "0x6004613")]
		public static void Initialize<T>(this T[] array) where T : new()
		{
		}

		[Token(Token = "0x6004614")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Token(Token = "0x6004615")]
		[Address(RVA = "0x2227D4C", Offset = "0x2227D4C", VA = "0x2227D4C")]
		public static bool ParsingPeriodTimeToDateTime(string itemPeriodTime, out DateTime dateTime, bool isUTC = true)
		{
			dateTime = default;
			return default(bool);
		}

		[Token(Token = "0x6004616")]
		public static string GetXmlEnumAttributeValueFromEnum<TEnum>(this TEnum value) where TEnum : struct, IConvertible
		{
			return null;
		}

		[Token(Token = "0x6004617")]
		[Address(RVA = "0x2234AF4", Offset = "0x2234AF4", VA = "0x2234AF4")]
		public static bool IsReleaseMode(ConnectEnum.ServerType serverType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004618")]
		[Address(RVA = "0x2234B04", Offset = "0x2234B04", VA = "0x2234B04")]
		public static bool IsDevelopServerType(ConnectEnum.ServerType serverType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004619")]
		[Address(RVA = "0x2234B18", Offset = "0x2234B18", VA = "0x2234B18")]
		public static string GetPremiumTicketStatKey(int ticketID)
		{
			return null;
		}

		[Token(Token = "0x600461A")]
		[Address(RVA = "0x2234C50", Offset = "0x2234C50", VA = "0x2234C50")]
		public static PoliceVsThiefRole GetPoliceVsThiefRole(XTeamEnum team, int round)
		{
			return default(PoliceVsThiefRole);
		}

		[Token(Token = "0x600461B")]
		public static T GameModeParamIntUsingGameMode<T>(GameModeInfo info, string key)
		{
			return (T)default;
		}

		[Token(Token = "0x600461C")]
		private static int _003CPickWeightedRandom_00601_003Em__1E4<T>(T c) where T : IWeightedRandomItem
		{
			return default(int);
		}
	}
}
