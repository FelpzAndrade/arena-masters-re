using System.Collections.Generic;
using Il2CppDummyDll;

namespace DustinHorne.Json.Examples
{
	[Token(Token = "0x2000091")]
	public class JNSimpleObjectModel
	{
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x8")]
		private int IntValue__BackingField;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0xC")]
		private float FloatValue__BackingField;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x10")]
		private string StringValue__BackingField;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x14")]
		private List<int> IntList__BackingField;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x18")]
		private JNObjectType ObjectType__BackingField;

		[Token(Token = "0x1700008E")]
		public int IntValue
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1E69390", Offset = "0x1E69390", VA = "0x1E69390")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1E68920", Offset = "0x1E68920", VA = "0x1E68920")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public float FloatValue
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1E69398", Offset = "0x1E69398", VA = "0x1E69398")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1E68928", Offset = "0x1E68928", VA = "0x1E68928")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public string StringValue
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1E68948", Offset = "0x1E68948", VA = "0x1E68948")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1E68930", Offset = "0x1E68930", VA = "0x1E68930")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public List<int> IntList
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1E693A0", Offset = "0x1E693A0", VA = "0x1E693A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1E68938", Offset = "0x1E68938", VA = "0x1E68938")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public JNObjectType ObjectType
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1E69370", Offset = "0x1E69370", VA = "0x1E69370")]
			get
			{
				return default(JNObjectType);
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1E68940", Offset = "0x1E68940", VA = "0x1E68940")]
			set
			{
			}
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1E68918", Offset = "0x1E68918", VA = "0x1E68918")]
		public JNSimpleObjectModel()
		{
		}
	}
}
