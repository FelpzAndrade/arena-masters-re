using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200012A")]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x8")]
		private readonly JsonSerializer _serializer;

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xFC0708", Offset = "0xFC0708", VA = "0xFC0708")]
		public JsonFormatterConverter(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000B4E")]
		private T GetTokenValue<T>(object value)
		{
			return (T)default;
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xFC07A8", Offset = "0xFC07A8", VA = "0xFC07A8", Slot = "4")]
		public object Convert(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0xFC0904", Offset = "0xFC0904", VA = "0xFC0904", Slot = "11")]
		public object Convert(object value, TypeCode typeCode)
		{
			return null;
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0xFC0AC0", Offset = "0xFC0AC0", VA = "0xFC0AC0", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xFC0B4C", Offset = "0xFC0B4C", VA = "0xFC0B4C", Slot = "12")]
		public byte ToByte(object value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xFC0BD8", Offset = "0xFC0BD8", VA = "0xFC0BD8", Slot = "13")]
		public char ToChar(object value)
		{
			return default(char);
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xFC0C64", Offset = "0xFC0C64", VA = "0xFC0C64", Slot = "14")]
		public DateTime ToDateTime(object value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xFC0CF8", Offset = "0xFC0CF8", VA = "0xFC0CF8", Slot = "15")]
		public decimal ToDecimal(object value)
		{
			return 0m;
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xFC0D8C", Offset = "0xFC0D8C", VA = "0xFC0D8C", Slot = "16")]
		public double ToDouble(object value)
		{
			return default(double);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xFC0E18", Offset = "0xFC0E18", VA = "0xFC0E18", Slot = "6")]
		public short ToInt16(object value)
		{
			return default(short);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xFC0EA4", Offset = "0xFC0EA4", VA = "0xFC0EA4", Slot = "7")]
		public int ToInt32(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xFC0F30", Offset = "0xFC0F30", VA = "0xFC0F30", Slot = "8")]
		public long ToInt64(object value)
		{
			return default(long);
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0xFC0FBC", Offset = "0xFC0FBC", VA = "0xFC0FBC", Slot = "17")]
		public sbyte ToSByte(object value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0xFC1048", Offset = "0xFC1048", VA = "0xFC1048", Slot = "18")]
		public float ToSingle(object value)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xFC10D4", Offset = "0xFC10D4", VA = "0xFC10D4", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xFC1160", Offset = "0xFC1160", VA = "0xFC1160", Slot = "19")]
		public ushort ToUInt16(object value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xFC11EC", Offset = "0xFC11EC", VA = "0xFC11EC", Slot = "10")]
		public uint ToUInt32(object value)
		{
			return default(uint);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0xFC1278", Offset = "0xFC1278", VA = "0xFC1278", Slot = "20")]
		public ulong ToUInt64(object value)
		{
			return default(ulong);
		}
	}
}
