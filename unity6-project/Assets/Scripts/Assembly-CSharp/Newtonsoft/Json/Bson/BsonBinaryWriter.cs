using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200009C")]
	internal class BsonBinaryWriter
	{
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding Encoding;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x8")]
		private readonly BinaryWriter _writer;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0xC")]
		private byte[] _largeByteBuffer;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x10")]
		private int _maxChars;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x14")]
		private DateTimeKind DateTimeKindHandling__BackingField;

		[Token(Token = "0x170000A3")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1380B44", Offset = "0x1380B44", VA = "0x1380B44")]
			get
			{
				return default(DateTimeKind);
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1380A78", Offset = "0x1380A78", VA = "0x1380A78")]
			set
			{
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x13809CC", Offset = "0x13809CC", VA = "0x13809CC")]
		public BsonBinaryWriter(Stream stream)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1380B4C", Offset = "0x1380B4C", VA = "0x1380B4C")]
		public void Flush()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1380BA4", Offset = "0x1380BA4", VA = "0x1380BA4")]
		public void Close()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1380BFC", Offset = "0x1380BFC", VA = "0x1380BFC")]
		public void WriteToken(BsonToken t)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x13816F4", Offset = "0x13816F4", VA = "0x13816F4")]
		private void WriteTokenInternal(BsonToken t)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1382FD0", Offset = "0x1382FD0", VA = "0x1382FD0")]
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x138365C", Offset = "0x138365C", VA = "0x138365C")]
		private int CalculateSize(int stringByteCount)
		{
			return default(int);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1383664", Offset = "0x1383664", VA = "0x1383664")]
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1380C20", Offset = "0x1380C20", VA = "0x1380C20")]
		private int CalculateSize(BsonToken t)
		{
			return default(int);
		}
	}
}
