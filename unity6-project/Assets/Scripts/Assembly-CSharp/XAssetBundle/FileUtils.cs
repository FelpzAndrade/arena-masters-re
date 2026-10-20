using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x2000390")]
	public static class FileUtils
	{
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x1EF418C", Offset = "0x1EF418C", VA = "0x1EF418C")]
		public static string CombinePath(string path1, string path2)
		{
			return null;
		}

		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x1EF423C", Offset = "0x1EF423C", VA = "0x1EF423C")]
		public static string[] GetAllFilePaths(string path, bool includeSub = true)
		{
			return null;
		}

		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x1EF4338", Offset = "0x1EF4338", VA = "0x1EF4338")]
		public static void ChangeDirSeparatorToWindows(ref string path)
		{
		}

		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x1EF4418", Offset = "0x1EF4418", VA = "0x1EF4418")]
		public static void ChangeDirSeparatorToLinux(ref string path)
		{
		}

		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x1EF44F8", Offset = "0x1EF44F8", VA = "0x1EF44F8")]
		public static string GetDirWithLinuxSeparator(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x1EF45D0", Offset = "0x1EF45D0", VA = "0x1EF45D0")]
		public static string GetDirWithWindowsSeparator(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x1EEEF6C", Offset = "0x1EEEF6C", VA = "0x1EEEF6C")]
		public static void RemoveFile(string path)
		{
		}

		[Token(Token = "0x6001D4B")]
		[Address(RVA = "0x1EEE184", Offset = "0x1EEE184", VA = "0x1EEE184")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D4C")]
		[Address(RVA = "0x1EEC3E4", Offset = "0x1EEC3E4", VA = "0x1EEC3E4")]
		public static string ReadAllText(string path)
		{
			return null;
		}

		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x1EED004", Offset = "0x1EED004", VA = "0x1EED004")]
		public static void SaveFile(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x1EF46DC", Offset = "0x1EF46DC", VA = "0x1EF46DC")]
		public static void SaveTextToFile(string path, string str)
		{
		}

		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x1EED2A4", Offset = "0x1EED2A4", VA = "0x1EED2A4")]
		public static void SaveAppendTextToFile(string path, List<string> lines)
		{
		}

		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x1EF48B4", Offset = "0x1EF48B4", VA = "0x1EF48B4")]
		public static bool IsFile(string ext, string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x1EE98F8", Offset = "0x1EE98F8", VA = "0x1EE98F8")]
		public static bool IsInclude(string str, string path, StringComparison strComparison = StringComparison.Ordinal)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x1EF48E0", Offset = "0x1EF48E0", VA = "0x1EF48E0")]
		public static bool IsInclude(List<string> strs, string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D53")]
		[Address(RVA = "0x1EF4B20", Offset = "0x1EF4B20", VA = "0x1EF4B20")]
		public static bool IsMetaFile(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x1EF4BBC", Offset = "0x1EF4BBC", VA = "0x1EF4BBC")]
		public static bool IsManifest(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x1EF4C58", Offset = "0x1EF4C58", VA = "0x1EF4C58")]
		public static bool IsDSStore(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x1EF4CF4", Offset = "0x1EF4CF4", VA = "0x1EF4CF4")]
		public static bool IsCSFile(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x1EEC3D8", Offset = "0x1EEC3D8", VA = "0x1EEC3D8")]
		public static bool IsExist(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x1EF4D90", Offset = "0x1EF4D90", VA = "0x1EF4D90")]
		public static bool IsDirExist(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x1EF4D9C", Offset = "0x1EF4D9C", VA = "0x1EF4D9C")]
		public static void BackupDir(string path)
		{
		}

		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x1EF5014", Offset = "0x1EF5014", VA = "0x1EF5014")]
		public static void DeepCopy(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x1EF5288", Offset = "0x1EF5288", VA = "0x1EF5288")]
		public static void FileCopy(string sourcePath, string destPath, bool overwrite = true)
		{
		}

		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x1EF52AC", Offset = "0x1EF52AC", VA = "0x1EF52AC")]
		public static void RemoveReturnString(ref string str)
		{
		}

		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x1EEB69C", Offset = "0x1EEB69C", VA = "0x1EEB69C")]
		public static string ConvertURLForFileAccess(string url)
		{
			return null;
		}

		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x1EEB6A4", Offset = "0x1EEB6A4", VA = "0x1EEB6A4")]
		public static string ConvertURL(string url)
		{
			return null;
		}

		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0x1EF46A8", Offset = "0x1EF46A8", VA = "0x1EF46A8")]
		public static void EnsureDirectory(string dirPath)
		{
		}
	}
}
