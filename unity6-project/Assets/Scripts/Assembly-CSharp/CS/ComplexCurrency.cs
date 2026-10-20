using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000952")]
	public class ComplexCurrency
	{
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool[] DecreaseOrder;

		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x8")]
		private int Paid__BackingField;

		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0xC")]
		private int Free__BackingField;

		[Token(Token = "0x17000A69")]
		public int Paid
		{
			[Token(Token = "0x6004AD7")]
			[Address(RVA = "0x23EC9F4", Offset = "0x23EC9F4", VA = "0x23EC9F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004AD8")]
			[Address(RVA = "0x23EC9FC", Offset = "0x23EC9FC", VA = "0x23EC9FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000A6A")]
		public int Free
		{
			[Token(Token = "0x6004AD9")]
			[Address(RVA = "0x23ECA04", Offset = "0x23ECA04", VA = "0x23ECA04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004ADA")]
			[Address(RVA = "0x23ECA0C", Offset = "0x23ECA0C", VA = "0x23ECA0C")]
			protected set
			{
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000A6B")]
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x23ECA14", Offset = "0x23ECA14", VA = "0x23ECA14")]
		private int get_Item(bool IsPaid)
		{
			return default(int);
		}

		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x23ECA28", Offset = "0x23ECA28", VA = "0x23ECA28")]
		private void set_Item(bool IsPaid, int value)
		{
		}

		[Token(Token = "0x17000A6C")]
		[JsonIgnore]
		public int TotalValue
		{
			[Token(Token = "0x6004ADD")]
			[Address(RVA = "0x23ECA38", Offset = "0x23ECA38", VA = "0x23ECA38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x23EC908", Offset = "0x23EC908", VA = "0x23EC908")]
		public ComplexCurrency()
		{
		}

		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x23ECA48", Offset = "0x23ECA48", VA = "0x23ECA48")]
		public int Increase(int Amount, bool IsPaid = false)
		{
			return default(int);
		}

		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x23ECC14", Offset = "0x23ECC14", VA = "0x23ECC14")]
		public int IncreaseForce(int Amount, bool IsPaid = false)
		{
			return default(int);
		}
	}
}
