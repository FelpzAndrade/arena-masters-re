using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E9")]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Type _propertyType;

		[Token(Token = "0x17000157")]
		public override Type ComponentType
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xF97FF8", Offset = "0xF97FF8", VA = "0xF97FF8", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xF980B4", Offset = "0xF980B4", VA = "0xF980B4", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000159")]
		public override Type PropertyType
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xF980BC", Offset = "0xF980BC", VA = "0xF980BC", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		protected override int NameHashCode
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xF980C4", Offset = "0xF980C4", VA = "0xF980C4", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xF92AF4", Offset = "0xF92AF4", VA = "0xF92AF4")]
		public JPropertyDescriptor(string name, Type propertyType) : base(name, (System.Attribute[])null)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xF97DB0", Offset = "0xF97DB0", VA = "0xF97DB0")]
		private static JObject CastInstance(object instance)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xF97E34", Offset = "0xF97E34", VA = "0xF97E34", Slot = "29")]
		public override bool CanResetValue(object component)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xF97E3C", Offset = "0xF97E3C", VA = "0xF97E3C", Slot = "26")]
		public override object GetValue(object component)
		{
			return null;
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xF97EA0", Offset = "0xF97EA0", VA = "0xF97EA0", Slot = "28")]
		public override void ResetValue(object component)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xF97EA4", Offset = "0xF97EA4", VA = "0xF97EA4", Slot = "27")]
		public override void SetValue(object component, object value)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xF97FF0", Offset = "0xF97FF0", VA = "0xF97FF0", Slot = "30")]
		public override bool ShouldSerializeValue(object component)
		{
			return default(bool);
		}
	}
}
