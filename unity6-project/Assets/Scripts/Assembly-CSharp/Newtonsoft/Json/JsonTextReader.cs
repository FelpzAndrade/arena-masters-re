using System;
using System.Globalization;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000D2")]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x20000D3")]
		private enum ReadType
		{
			[Token(Token = "0x4000369")]
			Read = 0,
			[Token(Token = "0x400036A")]
			ReadAsBytes = 1,
			[Token(Token = "0x400036B")]
			ReadAsDecimal = 2,
			[Token(Token = "0x400036C")]
			ReadAsDateTimeOffset = 3
		}

		[Token(Token = "0x400035E")]
		private const int LineFeedValue = 10;

		[Token(Token = "0x400035F")]
		private const int CarriageReturnValue = 13;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x2C")]
		private readonly TextReader _reader;

		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x30")]
		private readonly StringBuffer _buffer;

		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x34")]
		private char? _lastChar;

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x38")]
		private int _currentLinePosition;

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x3C")]
		private int _currentLineNumber;

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x40")]
		private bool _end;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x44")]
		private ReadType _readType;

		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x48")]
		private CultureInfo _culture;

		[Token(Token = "0x17000113")]
		public CultureInfo Culture
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xF70588", Offset = "0xF70588", VA = "0xF70588")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xF70638", Offset = "0xF70638", VA = "0xF70638")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public int LineNumber
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xF77310", Offset = "0xF77310", VA = "0xF77310", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000115")]
		public int LinePosition
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0xF77328", Offset = "0xF77328", VA = "0xF77328", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xF6EE80", Offset = "0xF6EE80", VA = "0xF6EE80")]
		public JsonTextReader(TextReader reader)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xF70640", Offset = "0xF70640", VA = "0xF70640")]
		private void ParseString(char quote)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xF70944", Offset = "0xF70944", VA = "0xF70944")]
		private void ReadStringIntoBuffer(char quote)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xF7185C", Offset = "0xF7185C", VA = "0xF7185C")]
		private JsonReaderException CreateJsonReaderException(string format, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xF71978", Offset = "0xF71978", VA = "0xF71978")]
		private TimeSpan ReadOffset(string offsetText)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xF71300", Offset = "0xF71300", VA = "0xF71300")]
		private void ParseDate(string text)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xF7173C", Offset = "0xF7173C", VA = "0xF7173C")]
		private char MoveNext()
		{
			return default(char);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xF71BF0", Offset = "0xF71BF0", VA = "0xF71BF0")]
		private bool HasNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xF71C50", Offset = "0xF71C50", VA = "0xF71C50")]
		private int PeekNext()
		{
			return default(int);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xF71CA8", Offset = "0xF71CA8", VA = "0xF71CA8", Slot = "11")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xF72038", Offset = "0xF72038", VA = "0xF72038", Slot = "12")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xF7299C", Offset = "0xF7299C", VA = "0xF7299C", Slot = "13")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xF73130", Offset = "0xF73130", VA = "0xF73130", Slot = "14")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xF71CB4", Offset = "0xF71CB4", VA = "0xF71CB4")]
		private bool ReadInternal()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xF74234", Offset = "0xF74234", VA = "0xF74234")]
		private bool ParsePostValue(char currentChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xF740EC", Offset = "0xF740EC", VA = "0xF740EC")]
		private bool ParseObject(char currentChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xF74854", Offset = "0xF74854", VA = "0xF74854")]
		private bool ParseProperty(char firstChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xF74D40", Offset = "0xF74D40", VA = "0xF74D40")]
		private bool ValidIdentifierChar(char value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xF74E08", Offset = "0xF74E08", VA = "0xF74E08")]
		private char ParseUnquotedProperty(char firstChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xF73908", Offset = "0xF73908", VA = "0xF73908")]
		private bool ParseValue(char currentChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xF751FC", Offset = "0xF751FC", VA = "0xF751FC")]
		private bool EatWhitespace(char initialChar, bool oneOrMore, out char finalChar)
		{
			finalChar = default;
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xF75A1C", Offset = "0xF75A1C", VA = "0xF75A1C")]
		private void ParseConstructor()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xF76578", Offset = "0xF76578", VA = "0xF76578")]
		private void ParseNumber(char firstChar)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xF74578", Offset = "0xF74578", VA = "0xF74578")]
		private void ParseComment()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xF771E8", Offset = "0xF771E8", VA = "0xF771E8")]
		private bool MatchValue(char firstChar, string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xF77024", Offset = "0xF77024", VA = "0xF77024")]
		private bool MatchValue(char firstChar, string value, bool noTrailingNonSeperatorCharacters)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xF77084", Offset = "0xF77084", VA = "0xF77084")]
		private bool IsSeperator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xF752F4", Offset = "0xF752F4", VA = "0xF752F4")]
		private void ParseTrue()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xF757F4", Offset = "0xF757F4", VA = "0xF757F4")]
		private void ParseNull()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xF76DFC", Offset = "0xF76DFC", VA = "0xF76DFC")]
		private void ParseUndefined()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xF75574", Offset = "0xF75574", VA = "0xF75574")]
		private void ParseFalse()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xF762EC", Offset = "0xF762EC", VA = "0xF762EC")]
		private void ParseNumberNegativeInfinity()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xF76060", Offset = "0xF76060", VA = "0xF76060")]
		private void ParseNumberPositiveInfinity()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xF75DD4", Offset = "0xF75DD4", VA = "0xF75DD4")]
		private void ParseNumberNaN()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xF7728C", Offset = "0xF7728C", VA = "0xF7728C", Slot = "17")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xF77308", Offset = "0xF77308", VA = "0xF77308", Slot = "18")]
		public bool HasLineInfo()
		{
			return default(bool);
		}
	}
}
