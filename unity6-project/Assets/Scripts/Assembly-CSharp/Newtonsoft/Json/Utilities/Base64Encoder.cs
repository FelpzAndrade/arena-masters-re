using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000142")]
	internal class Base64Encoder
	{
		[Token(Token = "0x4000545")]
		private const int Base64LineSize = 76;

		[Token(Token = "0x4000546")]
		private const int LineSizeInBytes = 57;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x8")]
		private readonly char[] _charsLine;

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0xC")]
		private readonly TextWriter _writer;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x10")]
		private byte[] _leftOverBytes;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x14")]
		private int _leftOverBytesCount;

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x1192BF0", Offset = "0x1192BF0", VA = "0x1192BF0")]
		public Base64Encoder(TextWriter writer)
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x1192CB0", Offset = "0x1192CB0", VA = "0x1192CB0")]
		public void Encode(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x1193194", Offset = "0x1193194", VA = "0x1193194")]
		public void Flush()
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x1193124", Offset = "0x1193124", VA = "0x1193124")]
		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
}
