using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000F3")]
	public class JValue : JToken, IFormattable, IEquatable<JValue>, IComparable<JValue>
	{
		protected JValue()
		{
		}

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x24")]
		private JTokenType _valueType;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x28")]
		private object _value;

		[Token(Token = "0x17000172")]
		public override bool HasValues
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xFA5354", Offset = "0xFA5354", VA = "0xFA5354", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000173")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xFA570C", Offset = "0xFA570C", VA = "0xFA570C", Slot = "13")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x17000174")]
		public new object Value
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xF94E30", Offset = "0xF94E30", VA = "0xF94E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xFA5714", Offset = "0xFA5714", VA = "0xFA5714")]
			set
			{
			}
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xF901AC", Offset = "0xF901AC", VA = "0xF901AC")]
		internal JValue(object value, JTokenType type)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xF980D0", Offset = "0xF980D0", VA = "0xF980D0")]
		public JValue(JValue other)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xF9F090", Offset = "0xF9F090", VA = "0xF9F090")]
		public JValue(long value)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xFA0234", Offset = "0xFA0234", VA = "0xFA0234")]
		public JValue(ulong value)
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xF9FED8", Offset = "0xF9FED8", VA = "0xF9FED8")]
		public JValue(double value)
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xF9F810", Offset = "0xF9F810", VA = "0xF9F810")]
		public JValue(DateTime value)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xF9EDA8", Offset = "0xF9EDA8", VA = "0xF9EDA8")]
		public JValue(bool value)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xFA00D0", Offset = "0xFA00D0", VA = "0xFA00D0")]
		public JValue(string value)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xFA3D30", Offset = "0xFA3D30", VA = "0xFA3D30")]
		public JValue(Guid value)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xFA3DF8", Offset = "0xFA3DF8", VA = "0xFA3DF8")]
		public JValue(Uri value)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xFA3E20", Offset = "0xFA3E20", VA = "0xFA3E20")]
		public JValue(TimeSpan value)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xF7C718", Offset = "0xF7C718", VA = "0xF7C718")]
		public JValue(object value)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xFA43BC", Offset = "0xFA43BC", VA = "0xFA43BC", Slot = "25")]
		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xFA5228", Offset = "0xFA5228", VA = "0xFA5228", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xFA44CC", Offset = "0xFA44CC", VA = "0xFA44CC")]
		private static int Compare(JTokenType valueType, object objA, object objB)
		{
			return default(int);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xFA535C", Offset = "0xFA535C", VA = "0xFA535C")]
		private static int CompareFloat(object objA, object objB)
		{
			return default(int);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xFA54E8", Offset = "0xFA54E8", VA = "0xFA54E8", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xF90110", Offset = "0xF90110", VA = "0xF90110")]
		public static JValue CreateComment(string value)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xFA5578", Offset = "0xFA5578", VA = "0xFA5578")]
		public static JValue CreateString(string value)
		{
			return null;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xFA3ED8", Offset = "0xFA3ED8", VA = "0xFA3ED8")]
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xFA5614", Offset = "0xFA5614", VA = "0xFA5614")]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xFA580C", Offset = "0xFA580C", VA = "0xFA580C", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xFA5FCC", Offset = "0xFA5FCC", VA = "0xFA5FCC", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xFA52E8", Offset = "0xFA52E8", VA = "0xFA52E8")]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xFA60E8", Offset = "0xFA60E8", VA = "0xFA60E8", Slot = "26")]
		public bool Equals(JValue other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xFA6108", Offset = "0xFA6108", VA = "0xFA6108", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xFA61DC", Offset = "0xFA61DC", VA = "0xFA61DC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xFA6230", Offset = "0xFA6230", VA = "0xFA6230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xFA6328", Offset = "0xFA6328", VA = "0xFA6328")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xFA65B4", Offset = "0xFA65B4", VA = "0xFA65B4")]
		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xFA63E0", Offset = "0xFA63E0", VA = "0xFA63E0", Slot = "24")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xFA65C0", Offset = "0xFA65C0", VA = "0xFA65C0", Slot = "27")]
		public int CompareTo(JValue obj)
		{
			return default(int);
		}
	}
}
