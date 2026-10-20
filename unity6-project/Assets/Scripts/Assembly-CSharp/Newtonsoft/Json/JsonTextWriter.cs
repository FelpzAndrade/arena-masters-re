using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000D4")]
	public class JsonTextWriter : JsonWriter
	{
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x1C")]
		private readonly TextWriter _writer;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x20")]
		private Base64Encoder _base64Encoder;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x24")]
		private char _indentChar;

		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x28")]
		private int _indentation;

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x2C")]
		private char _quoteChar;

		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x2E")]
		private bool _quoteName;

		[Token(Token = "0x17000116")]
		private Base64Encoder Base64Encoder
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0xF77430", Offset = "0xF77430", VA = "0xF77430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		public int Indentation
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0xF774D8", Offset = "0xF774D8", VA = "0xF774D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xF774E0", Offset = "0xF774E0", VA = "0xF774E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public char QuoteChar
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xF7759C", Offset = "0xF7759C", VA = "0xF7759C")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xF775A4", Offset = "0xF775A4", VA = "0xF775A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public char IndentChar
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xF77668", Offset = "0xF77668", VA = "0xF77668")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600071B")]
			[Address(RVA = "0xF77670", Offset = "0xF77670", VA = "0xF77670")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public bool QuoteName
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0xF77678", Offset = "0xF77678", VA = "0xF77678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0xF77680", Offset = "0xF77680", VA = "0xF77680")]
			set
			{
			}
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xF6FDD4", Offset = "0xF6FDD4", VA = "0xF6FDD4")]
		public JsonTextWriter(TextWriter textWriter)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xF77688", Offset = "0xF77688", VA = "0xF77688", Slot = "5")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xF776E0", Offset = "0xF776E0", VA = "0xF776E0", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xF7774C", Offset = "0xF7774C", VA = "0xF7774C", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xF77854", Offset = "0xF77854", VA = "0xF77854", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xF7795C", Offset = "0xF7795C", VA = "0xF7795C", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xF77AFC", Offset = "0xF77AFC", VA = "0xF77AFC", Slot = "15")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xF77D08", Offset = "0xF77D08", VA = "0xF77D08", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xF77DA4", Offset = "0xF77DA4", VA = "0xF77DA4", Slot = "16")]
		protected override void WriteIndent()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xF77E94", Offset = "0xF77E94", VA = "0xF77E94", Slot = "17")]
		protected override void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xF77EF0", Offset = "0xF77EF0", VA = "0xF77EF0", Slot = "18")]
		protected override void WriteIndentSpace()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xF77F4C", Offset = "0xF77F4C", VA = "0xF77F4C")]
		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xF77FAC", Offset = "0xF77FAC", VA = "0xF77FAC", Slot = "19")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xF7807C", Offset = "0xF7807C", VA = "0xF7807C", Slot = "20")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xF7814C", Offset = "0xF7814C", VA = "0xF7814C", Slot = "21")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xF781B0", Offset = "0xF781B0", VA = "0xF781B0", Slot = "23")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xF782C0", Offset = "0xF782C0", VA = "0xF782C0", Slot = "24")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xF7838C", Offset = "0xF7838C", VA = "0xF7838C", Slot = "25")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xF78458", Offset = "0xF78458", VA = "0xF78458", Slot = "26")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xF78538", Offset = "0xF78538", VA = "0xF78538", Slot = "27")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xF78618", Offset = "0xF78618", VA = "0xF78618", Slot = "28")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xF786E4", Offset = "0xF786E4", VA = "0xF786E4", Slot = "29")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xF787C4", Offset = "0xF787C4", VA = "0xF787C4", Slot = "30")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xF78890", Offset = "0xF78890", VA = "0xF78890", Slot = "31")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xF7895C", Offset = "0xF7895C", VA = "0xF7895C", Slot = "32")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xF78A28", Offset = "0xF78A28", VA = "0xF78A28", Slot = "33")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xF78AF4", Offset = "0xF78AF4", VA = "0xF78AF4", Slot = "34")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xF78BC0", Offset = "0xF78BC0", VA = "0xF78BC0", Slot = "35")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xF78C8C", Offset = "0xF78C8C", VA = "0xF78C8C", Slot = "36")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xF78D7C", Offset = "0xF78D7C", VA = "0xF78D7C", Slot = "37")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xF78E64", Offset = "0xF78E64", VA = "0xF78E64", Slot = "58")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xF78FC4", Offset = "0xF78FC4", VA = "0xF78FC4", Slot = "38")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xF790C0", Offset = "0xF790C0", VA = "0xF790C0", Slot = "39")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xF791B0", Offset = "0xF791B0", VA = "0xF791B0", Slot = "40")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xF79290", Offset = "0xF79290", VA = "0xF79290", Slot = "59")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xF79450", Offset = "0xF79450", VA = "0xF79450", Slot = "61")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xF795C8", Offset = "0xF795C8", VA = "0xF795C8", Slot = "62")]
		public override void WriteWhitespace(string ws)
		{
		}
	}
}
