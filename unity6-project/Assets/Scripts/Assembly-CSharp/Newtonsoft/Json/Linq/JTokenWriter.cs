using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000F2")]
	public class JTokenWriter : JsonWriter
	{
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x1C")]
		private JContainer _token;

		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x20")]
		private JContainer _parent;

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x24")]
		private JValue _value;

		[Token(Token = "0x17000171")]
		public JToken Token
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0xF9A30C", Offset = "0xF9A30C", VA = "0xF9A30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xF8F424", Offset = "0xF8F424", VA = "0xF8F424")]
		public JTokenWriter(JContainer container)
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xF9A26C", Offset = "0xF9A26C", VA = "0xF9A26C")]
		public JTokenWriter()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xFA2A04", Offset = "0xFA2A04", VA = "0xFA2A04", Slot = "5")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xFA2A08", Offset = "0xFA2A08", VA = "0xFA2A08", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xFA2A0C", Offset = "0xFA2A0C", VA = "0xFA2A0C", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xFA2AB8", Offset = "0xFA2AB8", VA = "0xFA2AB8")]
		private void AddParent(JContainer container)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xFA2B14", Offset = "0xFA2B14", VA = "0xFA2B14")]
		private void RemoveParent()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xFA2B94", Offset = "0xFA2B94", VA = "0xFA2B94", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xFA2C40", Offset = "0xFA2C40", VA = "0xFA2C40", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xFA2CF4", Offset = "0xFA2CF4", VA = "0xFA2CF4", Slot = "15")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xFA2CF8", Offset = "0xFA2CF8", VA = "0xFA2CF8", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xFA2DA0", Offset = "0xFA2DA0", VA = "0xFA2DA0")]
		private void AddValue(object value, JsonToken token)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xFA2E3C", Offset = "0xFA2E3C", VA = "0xFA2E3C")]
		internal void AddValue(JValue value, JsonToken token)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xFA2EF0", Offset = "0xFA2EF0", VA = "0xFA2EF0", Slot = "19")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xFA2F14", Offset = "0xFA2F14", VA = "0xFA2F14", Slot = "20")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xFA2F38", Offset = "0xFA2F38", VA = "0xFA2F38", Slot = "21")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xFA2FE0", Offset = "0xFA2FE0", VA = "0xFA2FE0", Slot = "61")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xFA3010", Offset = "0xFA3010", VA = "0xFA3010", Slot = "23")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xFA3100", Offset = "0xFA3100", VA = "0xFA3100", Slot = "24")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xFA31B0", Offset = "0xFA31B0", VA = "0xFA31B0", Slot = "25")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xFA3260", Offset = "0xFA3260", VA = "0xFA3260", Slot = "26")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xFA3314", Offset = "0xFA3314", VA = "0xFA3314", Slot = "27")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xFA33C8", Offset = "0xFA33C8", VA = "0xFA33C8", Slot = "28")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xFA3480", Offset = "0xFA3480", VA = "0xFA3480", Slot = "29")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xFA3538", Offset = "0xFA3538", VA = "0xFA3538", Slot = "30")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xFA35E8", Offset = "0xFA35E8", VA = "0xFA35E8", Slot = "31")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xFA3698", Offset = "0xFA3698", VA = "0xFA3698", Slot = "32")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xFA3748", Offset = "0xFA3748", VA = "0xFA3748", Slot = "33")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xFA3788", Offset = "0xFA3788", VA = "0xFA3788", Slot = "34")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xFA3838", Offset = "0xFA3838", VA = "0xFA3838", Slot = "35")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xFA38E8", Offset = "0xFA38E8", VA = "0xFA38E8", Slot = "36")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xFA39B0", Offset = "0xFA39B0", VA = "0xFA39B0", Slot = "37")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xFA3A74", Offset = "0xFA3A74", VA = "0xFA3A74", Slot = "38")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xFA3B64", Offset = "0xFA3B64", VA = "0xFA3B64", Slot = "58")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xFA3B8C", Offset = "0xFA3B8C", VA = "0xFA3B8C", Slot = "40")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xFA3C40", Offset = "0xFA3C40", VA = "0xFA3C40", Slot = "39")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xFA3D08", Offset = "0xFA3D08", VA = "0xFA3D08", Slot = "59")]
		public override void WriteValue(Uri value)
		{
		}
	}
}
