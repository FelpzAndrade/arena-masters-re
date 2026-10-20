using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000DA")]
	public abstract class JsonWriter
	{
		[Token(Token = "0x20000DB")]
		private enum State
		{
			[Token(Token = "0x40003A9")]
			Start = 0,
			[Token(Token = "0x40003AA")]
			Property = 1,
			[Token(Token = "0x40003AB")]
			ObjectStart = 2,
			[Token(Token = "0x40003AC")]
			Object = 3,
			[Token(Token = "0x40003AD")]
			ArrayStart = 4,
			[Token(Token = "0x40003AE")]
			Array = 5,
			[Token(Token = "0x40003AF")]
			ConstructorStart = 6,
			[Token(Token = "0x40003B0")]
			Constructor = 7,
			[Token(Token = "0x40003B1")]
			Bytes = 8,
			[Token(Token = "0x40003B2")]
			Closed = 9,
			[Token(Token = "0x40003B3")]
			Error = 10
		}

		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly State[][] stateArray;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x8")]
		private int _top;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<JTokenType> _stack;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x10")]
		private State _currentState;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x14")]
		private Formatting _formatting;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x18")]
		private bool CloseOutput__BackingField;

		[Token(Token = "0x1700012B")]
		public bool CloseOutput
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0xF77744", Offset = "0xF77744", VA = "0xF77744")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0xF82DDC", Offset = "0xF82DDC", VA = "0xF82DDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		protected internal int Top
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xF77E8C", Offset = "0xF77E8C", VA = "0xF77E8C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012D")]
		public WriteState WriteState
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xF83A4C", Offset = "0xF83A4C", VA = "0xF83A4C")]
			get
			{
				return default(WriteState);
			}
		}

		[Token(Token = "0x1700012E")]
		public Formatting Formatting
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xF77E84", Offset = "0xF77E84", VA = "0xF77E84")]
			get
			{
				return default(Formatting);
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xF83BA8", Offset = "0xF83BA8", VA = "0xF83BA8")]
			set
			{
			}
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xF77330", Offset = "0xF77330", VA = "0xF77330")]
		protected JsonWriter()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xF839F4", Offset = "0xF839F4", VA = "0xF839F4", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xF83BB0", Offset = "0xF83BB0", VA = "0xF83BB0")]
		private void Push(JTokenType value)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xF83CC8", Offset = "0xF83CC8", VA = "0xF83CC8")]
		private JTokenType Pop()
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xF83CE8", Offset = "0xF83CE8", VA = "0xF83CE8")]
		private JTokenType Peek()
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000787")]
		public abstract void Flush();

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xF77740", Offset = "0xF77740", VA = "0xF77740", Slot = "6")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xF77830", Offset = "0xF77830", VA = "0xF77830", Slot = "7")]
		public virtual void WriteStartObject()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xF8422C", Offset = "0xF8422C", VA = "0xF8422C", Slot = "8")]
		public virtual void WriteEndObject()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xF77938", Offset = "0xF77938", VA = "0xF77938", Slot = "9")]
		public virtual void WriteStartArray()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xF84510", Offset = "0xF84510", VA = "0xF84510", Slot = "10")]
		public virtual void WriteEndArray()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xF77AD8", Offset = "0xF77AD8", VA = "0xF77AD8", Slot = "11")]
		public virtual void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xF84518", Offset = "0xF84518", VA = "0xF84518", Slot = "12")]
		public virtual void WriteEndConstructor()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xF77D9C", Offset = "0xF77D9C", VA = "0xF77D9C", Slot = "13")]
		public virtual void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xF84520", Offset = "0xF84520", VA = "0xF84520", Slot = "14")]
		public virtual void WriteEnd()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xF846DC", Offset = "0xF846DC", VA = "0xF846DC")]
		public void WriteToken(JsonReader reader)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xF84840", Offset = "0xF84840", VA = "0xF84840")]
		internal void WriteToken(JsonReader reader, int initialDepth)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xF853EC", Offset = "0xF853EC", VA = "0xF853EC")]
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xF85800", Offset = "0xF85800", VA = "0xF85800")]
		private bool IsEndToken(JsonToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xF8482C", Offset = "0xF8482C", VA = "0xF8482C")]
		private bool IsStartToken(JsonToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xF84540", Offset = "0xF84540", VA = "0xF84540")]
		private void WriteEnd(JTokenType type)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xF83D84", Offset = "0xF83D84", VA = "0xF83D84")]
		private void AutoCompleteAll()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xF85814", Offset = "0xF85814", VA = "0xF85814")]
		private JTokenType GetTypeForCloseToken(JsonToken token)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xF85944", Offset = "0xF85944", VA = "0xF85944")]
		private JsonToken GetCloseTokenForType(JTokenType type)
		{
			return default(JsonToken);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xF84234", Offset = "0xF84234", VA = "0xF84234")]
		private void AutoCompleteClose(JsonToken tokenBeingClosed)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xF85A74", Offset = "0xF85A74", VA = "0xF85A74", Slot = "15")]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xF85A78", Offset = "0xF85A78", VA = "0xF85A78", Slot = "16")]
		protected virtual void WriteIndent()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xF85A7C", Offset = "0xF85A7C", VA = "0xF85A7C", Slot = "17")]
		protected virtual void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xF85A80", Offset = "0xF85A80", VA = "0xF85A80", Slot = "18")]
		protected virtual void WriteIndentSpace()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xF83DD8", Offset = "0xF83DD8", VA = "0xF83DD8")]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xF78074", Offset = "0xF78074", VA = "0xF78074", Slot = "19")]
		public virtual void WriteNull()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xF78144", Offset = "0xF78144", VA = "0xF78144", Slot = "20")]
		public virtual void WriteUndefined()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xF781AC", Offset = "0xF781AC", VA = "0xF781AC", Slot = "21")]
		public virtual void WriteRaw(string json)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xF85A84", Offset = "0xF85A84", VA = "0xF85A84", Slot = "22")]
		public virtual void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xF782B8", Offset = "0xF782B8", VA = "0xF782B8", Slot = "23")]
		public virtual void WriteValue(string value)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xF78384", Offset = "0xF78384", VA = "0xF78384", Slot = "24")]
		public virtual void WriteValue(int value)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xF78450", Offset = "0xF78450", VA = "0xF78450", Slot = "25")]
		public virtual void WriteValue(uint value)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xF78530", Offset = "0xF78530", VA = "0xF78530", Slot = "26")]
		public virtual void WriteValue(long value)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xF78610", Offset = "0xF78610", VA = "0xF78610", Slot = "27")]
		public virtual void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xF786DC", Offset = "0xF786DC", VA = "0xF786DC", Slot = "28")]
		public virtual void WriteValue(float value)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xF787BC", Offset = "0xF787BC", VA = "0xF787BC", Slot = "29")]
		public virtual void WriteValue(double value)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xF78888", Offset = "0xF78888", VA = "0xF78888", Slot = "30")]
		public virtual void WriteValue(bool value)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xF78954", Offset = "0xF78954", VA = "0xF78954", Slot = "31")]
		public virtual void WriteValue(short value)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xF78A20", Offset = "0xF78A20", VA = "0xF78A20", Slot = "32")]
		public virtual void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xF78AEC", Offset = "0xF78AEC", VA = "0xF78AEC", Slot = "33")]
		public virtual void WriteValue(char value)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xF78BB8", Offset = "0xF78BB8", VA = "0xF78BB8", Slot = "34")]
		public virtual void WriteValue(byte value)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xF78C84", Offset = "0xF78C84", VA = "0xF78C84", Slot = "35")]
		public virtual void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xF78D74", Offset = "0xF78D74", VA = "0xF78D74", Slot = "36")]
		public virtual void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xF78E5C", Offset = "0xF78E5C", VA = "0xF78E5C", Slot = "37")]
		public virtual void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xF790B8", Offset = "0xF790B8", VA = "0xF790B8", Slot = "38")]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xF791A8", Offset = "0xF791A8", VA = "0xF791A8", Slot = "39")]
		public virtual void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xF79288", Offset = "0xF79288", VA = "0xF79288", Slot = "40")]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xF85AD8", Offset = "0xF85AD8", VA = "0xF85AD8", Slot = "41")]
		public virtual void WriteValue(int? value)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xF85BF8", Offset = "0xF85BF8", VA = "0xF85BF8", Slot = "42")]
		public virtual void WriteValue(uint? value)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xF85D18", Offset = "0xF85D18", VA = "0xF85D18", Slot = "43")]
		public virtual void WriteValue(long? value)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xF85E54", Offset = "0xF85E54", VA = "0xF85E54", Slot = "44")]
		public virtual void WriteValue(ulong? value)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xF85F90", Offset = "0xF85F90", VA = "0xF85F90", Slot = "45")]
		public virtual void WriteValue(float? value)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xF860B0", Offset = "0xF860B0", VA = "0xF860B0", Slot = "46")]
		public virtual void WriteValue(double? value)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xF861EC", Offset = "0xF861EC", VA = "0xF861EC", Slot = "47")]
		public virtual void WriteValue(bool? value)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xF8630C", Offset = "0xF8630C", VA = "0xF8630C", Slot = "48")]
		public virtual void WriteValue(short? value)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xF8642C", Offset = "0xF8642C", VA = "0xF8642C", Slot = "49")]
		public virtual void WriteValue(ushort? value)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xF8654C", Offset = "0xF8654C", VA = "0xF8654C", Slot = "50")]
		public virtual void WriteValue(char? value)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xF8666C", Offset = "0xF8666C", VA = "0xF8666C", Slot = "51")]
		public virtual void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xF8678C", Offset = "0xF8678C", VA = "0xF8678C", Slot = "52")]
		public virtual void WriteValue(sbyte? value)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xF868AC", Offset = "0xF868AC", VA = "0xF868AC", Slot = "53")]
		public virtual void WriteValue(decimal? value)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xF869F0", Offset = "0xF869F0", VA = "0xF869F0", Slot = "54")]
		public virtual void WriteValue(DateTime? value)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xF86B44", Offset = "0xF86B44", VA = "0xF86B44", Slot = "55")]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xF86CB4", Offset = "0xF86CB4", VA = "0xF86CB4", Slot = "56")]
		public virtual void WriteValue(Guid? value)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xF86DF8", Offset = "0xF86DF8", VA = "0xF86DF8", Slot = "57")]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xF78F68", Offset = "0xF78F68", VA = "0xF78F68", Slot = "58")]
		public virtual void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xF79354", Offset = "0xF79354", VA = "0xF79354", Slot = "59")]
		public virtual void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xF86F38", Offset = "0xF86F38", VA = "0xF86F38", Slot = "60")]
		public virtual void WriteValue(object value)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xF795C0", Offset = "0xF795C0", VA = "0xF795C0", Slot = "61")]
		public virtual void WriteComment(string text)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xF79630", Offset = "0xF79630", VA = "0xF79630", Slot = "62")]
		public virtual void WriteWhitespace(string ws)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xF839FC", Offset = "0xF839FC", VA = "0xF839FC")]
		private void Dispose(bool disposing)
		{
		}
	}
}
