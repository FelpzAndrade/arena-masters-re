using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace IniFile
{
	[Token(Token = "0x20008E5")]
	public class IniFile
	{
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Dictionary<string, string>> IniDictionary;

		[Token(Token = "0x6004773")]
		[Address(RVA = "0xD88F18", Offset = "0xD88F18", VA = "0xD88F18")]
		public IniFile()
		{
		}

		[Token(Token = "0x6004775")]
		[Address(RVA = "0xD88FD0", Offset = "0xD88FD0", VA = "0xD88FD0")]
		public void LoadFromStream(string data)
		{
		}

		[Token(Token = "0x6004776")]
		[Address(RVA = "0xD8979C", Offset = "0xD8979C", VA = "0xD8979C")]
		public void FileRead(string path)
		{
		}

		[Token(Token = "0x6004777")]
		[Address(RVA = "0xD892E4", Offset = "0xD892E4", VA = "0xD892E4")]
		private void StreamRead(StreamReader sr)
		{
		}

		[Token(Token = "0x6004778")]
		[Address(RVA = "0xD89920", Offset = "0xD89920", VA = "0xD89920")]
		private void SetDictionary(string _Section, string _Key, string _Value)
		{
		}

		[Token(Token = "0x6004779")]
		[Address(RVA = "0xD89D0C", Offset = "0xD89D0C", VA = "0xD89D0C")]
		public void RemoveKey(string _Section, string _Key)
		{
		}

		[Token(Token = "0x600477A")]
		[Address(RVA = "0xD89F50", Offset = "0xD89F50", VA = "0xD89F50")]
		public void SetValue(string _Section, string _Key, string _Value)
		{
		}

		[Token(Token = "0x600477B")]
		[Address(RVA = "0xD89F68", Offset = "0xD89F68", VA = "0xD89F68")]
		public void SaveIniFile(string savePath)
		{
		}

		[Token(Token = "0x600477C")]
		[Address(RVA = "0xD8A184", Offset = "0xD8A184", VA = "0xD8A184")]
		public string GetText()
		{
			return null;
		}

		[Token(Token = "0x600477D")]
		[Address(RVA = "0xD8A9DC", Offset = "0xD8A9DC", VA = "0xD8A9DC")]
		public string GetValue(string _Section, string _Key)
		{
			return null;
		}
	}
}
