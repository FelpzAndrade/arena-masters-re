using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200009E")]
	public class BsonReader : JsonReader
	{
		[Token(Token = "0x200009F")]
		private enum BsonReaderState
		{
			[Token(Token = "0x40002AB")]
			Normal = 0,
			[Token(Token = "0x40002AC")]
			ReferenceStart = 1,
			[Token(Token = "0x40002AD")]
			ReferenceRef = 2,
			[Token(Token = "0x40002AE")]
			ReferenceId = 3,
			[Token(Token = "0x40002AF")]
			CodeWScopeStart = 4,
			[Token(Token = "0x40002B0")]
			CodeWScopeCode = 5,
			[Token(Token = "0x40002B1")]
			CodeWScopeScope = 6,
			[Token(Token = "0x40002B2")]
			CodeWScopeScopeObject = 7,
			[Token(Token = "0x40002B3")]
			CodeWScopeScopeEnd = 8
		}

		[Token(Token = "0x20000A0")]
		private class ContainerContext
		{
			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x8")]
			public readonly BsonType Type;

			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0xC")]
			public int Length;

			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x10")]
			public int Position;

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1385BB4", Offset = "0x1385BB4", VA = "0x1385BB4")]
			public ContainerContext(BsonType type)
			{
			}
		}

		[Token(Token = "0x400029B")]
		private const int MaxCharBytesSize = 128;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] _seqRange1;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x4")]
		private static readonly byte[] _seqRange2;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] _seqRange3;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0xC")]
		private static readonly byte[] _seqRange4;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x2C")]
		private readonly BinaryReader _reader;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ContainerContext> _stack;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x34")]
		private byte[] _byteBuffer;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x38")]
		private char[] _charBuffer;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x3C")]
		private BsonType _currentElementType;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x40")]
		private BsonReaderState _bsonReaderState;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x44")]
		private ContainerContext _currentContext;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x48")]
		private bool _readRootValueAsArray;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x49")]
		private bool _jsonNet35BinaryCompatibility;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x4C")]
		private DateTimeKind _dateTimeKindHandling;

		[Token(Token = "0x170000A5")]
		public bool JsonNet35BinaryCompatibility
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1383D50", Offset = "0x1383D50", VA = "0x1383D50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1383D58", Offset = "0x1383D58", VA = "0x1383D58")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool ReadRootValueAsArray
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1383D60", Offset = "0x1383D60", VA = "0x1383D60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1383D68", Offset = "0x1383D68", VA = "0x1383D68")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1383D70", Offset = "0x1383D70", VA = "0x1383D70")]
			get
			{
				return default(DateTimeKind);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1383D78", Offset = "0x1383D78", VA = "0x1383D78")]
			set
			{
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x13839D0", Offset = "0x13839D0", VA = "0x13839D0")]
		public BsonReader(Stream stream)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x13839F0", Offset = "0x13839F0", VA = "0x13839F0")]
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1383D80", Offset = "0x1383D80", VA = "0x1383D80")]
		private string ReadElement()
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x13841FC", Offset = "0x13841FC", VA = "0x13841FC", Slot = "12")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x13844E0", Offset = "0x13844E0", VA = "0x13844E0", Slot = "13")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x13849C4", Offset = "0x13849C4", VA = "0x13849C4", Slot = "14")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1384E3C", Offset = "0x1384E3C", VA = "0x1384E3C", Slot = "11")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1385A64", Offset = "0x1385A64", VA = "0x1385A64", Slot = "17")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x138578C", Offset = "0x138578C", VA = "0x138578C")]
		private bool ReadCodeWScope()
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x13853F0", Offset = "0x13853F0", VA = "0x13853F0")]
		private bool ReadReference()
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1385118", Offset = "0x1385118", VA = "0x1385118")]
		private bool ReadNormal()
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1386440", Offset = "0x1386440", VA = "0x1386440")]
		private void PopContext()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1385BD4", Offset = "0x1385BD4", VA = "0x1385BD4")]
		private void PushContext(ContainerContext newContext)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x13863DC", Offset = "0x13863DC", VA = "0x13863DC")]
		private byte ReadByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1385CE0", Offset = "0x1385CE0", VA = "0x1385CE0")]
		private void ReadType(BsonType type)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1386604", Offset = "0x1386604", VA = "0x1386604")]
		private byte[] ReadBinary()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1383E04", Offset = "0x1383E04", VA = "0x1383E04")]
		private string ReadString()
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1385B38", Offset = "0x1385B38", VA = "0x1385B38")]
		private string ReadLengthString()
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x13869CC", Offset = "0x13869CC", VA = "0x13869CC")]
		private string GetString(int length)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1386924", Offset = "0x1386924", VA = "0x1386924")]
		private int GetLastFullCharStop(int start)
		{
			return default(int);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1386E20", Offset = "0x1386E20", VA = "0x1386E20")]
		private int BytesInSequence(byte b)
		{
			return default(int);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x13867B4", Offset = "0x13867B4", VA = "0x13867B4")]
		private void EnsureBuffers()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x13865A0", Offset = "0x13865A0", VA = "0x13865A0")]
		private double ReadDouble()
		{
			return default(double);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1385AD4", Offset = "0x1385AD4", VA = "0x1385AD4")]
		private int ReadInt32()
		{
			return default(int);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x138664C", Offset = "0x138664C", VA = "0x138664C")]
		private long ReadInt64()
		{
			return default(long);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1383DA0", Offset = "0x1383DA0", VA = "0x1383DA0")]
		private BsonType ReadType()
		{
			return default(BsonType);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1386574", Offset = "0x1386574", VA = "0x1386574")]
		private void MovePosition(int count)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1385C78", Offset = "0x1385C78", VA = "0x1385C78")]
		private byte[] ReadBytes(int count)
		{
			return null;
		}
	}
}
