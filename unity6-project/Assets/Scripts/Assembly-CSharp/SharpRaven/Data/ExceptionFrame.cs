using System.Collections.Generic;
using Il2CppDummyDll;

namespace SharpRaven.Data
{
	[Token(Token = "0x2000356")]
	public class ExceptionFrame
	{
		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x8")]
		public string AbsolutePath;

		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0xC")]
		public string Filename;

		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x10")]
		public string Module;

		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x14")]
		public string Function;

		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> Vars;

		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x1C")]
		public List<string> PreContext;

		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x20")]
		public string Source;

		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x24")]
		public int LineNumber;

		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x28")]
		public int ColumnNumber;

		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x2C")]
		public bool InApp;

		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x30")]
		public List<string> PostContext;

		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x20F0DD8", Offset = "0x20F0DD8", VA = "0x20F0DD8")]
		public ExceptionFrame()
		{
		}
	}
}
