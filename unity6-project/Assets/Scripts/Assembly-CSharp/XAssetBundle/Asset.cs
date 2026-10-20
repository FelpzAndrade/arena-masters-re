using System.Collections.Generic;
using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x2000369")]
	public class Asset
	{
		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x0")]
		public static List<string> ExportExcludeList;

		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x4")]
		public static List<string> ExportGroupingFolderList;

		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x8")]
		public static List<string> ForceRemoveListOnBuild;

		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0xC")]
		public static List<string> OnlyExportExcludeList;

		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0x10")]
		public static List<string> ObfTargetList;

		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0x14")]
		private static bool isInit;

		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x1EE8E60", Offset = "0x1EE8E60", VA = "0x1EE8E60")]
		public Asset()
		{
		}

		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x1EE9734", Offset = "0x1EE9734", VA = "0x1EE9734")]
		public static string IsInUIGroupingFolder(string path)
		{
			return null;
		}

		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x1EE97F0", Offset = "0x1EE97F0", VA = "0x1EE97F0")]
		private static string GetGroup(List<string> list, string path)
		{
			return null;
		}

		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x1EE9938", Offset = "0x1EE9938", VA = "0x1EE9938")]
		public static string ConvertStringGroupingFolderToAssetBundle(string groupingFolder)
		{
			return null;
		}

		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x1EE99A8", Offset = "0x1EE99A8", VA = "0x1EE99A8")]
		public static bool IsExclude(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x1EE9B6C", Offset = "0x1EE9B6C", VA = "0x1EE9B6C")]
		public static bool IsExcludeOnlyExport(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x1EE9C28", Offset = "0x1EE9C28", VA = "0x1EE9C28")]
		public static bool IsIgnoreAsset(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x1EE9CB8", Offset = "0x1EE9CB8", VA = "0x1EE9CB8")]
		public static bool IsObfTarget(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x1EE9A64", Offset = "0x1EE9A64", VA = "0x1EE9A64")]
		private static bool IsInclude(List<string> list, string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x1EE9D74", Offset = "0x1EE9D74", VA = "0x1EE9D74")]
		public static string ExtractName(string path)
		{
			return null;
		}

		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x1EE9E1C", Offset = "0x1EE9E1C", VA = "0x1EE9E1C")]
		public static void ReMakeExportGroupingFolderList(List<string> pathList)
		{
		}
	}
}
