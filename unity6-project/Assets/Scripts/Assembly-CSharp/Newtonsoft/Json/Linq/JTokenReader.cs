using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000F0")]
	public class JTokenReader : JsonReader
	{
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x2C")]
		private readonly JToken _root;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x30")]
		private JToken _parent;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x34")]
		private JToken _current;

		[Token(Token = "0x1700016E")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0xFA0B68", Offset = "0xFA0B68", VA = "0xFA0B68", Slot = "19")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber();
			}
		}

		[Token(Token = "0x1700016F")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0xFA0C84", Offset = "0xFA0C84", VA = "0xFA0C84", Slot = "20")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition();
			}
		}

		[Token(Token = "0x17000170")]
		private bool IsEndElement
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0xFA0B50", Offset = "0xFA0B50", VA = "0xFA0B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xF9A1CC", Offset = "0xF9A1CC", VA = "0xF9A1CC")]
		public JTokenReader(JToken token)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xFA0A48", Offset = "0xFA0A48", VA = "0xFA0A48", Slot = "18")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xFA0B68", Offset = "0xFA0B68", VA = "0xFA0B68", Slot = "19")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber()
		{
			return default(int);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xFA0C84", Offset = "0xFA0C84", VA = "0xFA0C84", Slot = "20")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition()
		{
			return default(int);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xFA0D9C", Offset = "0xFA0D9C", VA = "0xFA0D9C", Slot = "12")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xFA12A8", Offset = "0xFA12A8", VA = "0xFA12A8", Slot = "13")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xFA178C", Offset = "0xFA178C", VA = "0xFA178C", Slot = "14")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xFA1C04", Offset = "0xFA1C04", VA = "0xFA1C04", Slot = "11")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xFA1D78", Offset = "0xFA1D78", VA = "0xFA1D78")]
		private bool ReadOver(JToken t)
		{
			return default(bool);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xFA2640", Offset = "0xFA2640", VA = "0xFA2640")]
		private bool ReadToEnd()
		{
			return default(bool);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xFA2748", Offset = "0xFA2748", VA = "0xFA2748")]
		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xFA1CF0", Offset = "0xFA1CF0", VA = "0xFA1CF0")]
		private bool ReadInto(JContainer c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xFA2648", Offset = "0xFA2648", VA = "0xFA2648")]
		private bool SetEnd(JContainer c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xFA1E3C", Offset = "0xFA1E3C", VA = "0xFA1E3C")]
		private void SetToken(JToken token)
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xFA29B0", Offset = "0xFA29B0", VA = "0xFA29B0")]
		private string SafeToString(object value)
		{
			return null;
		}
	}
}
