using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000965")]
	public class RotationItemSet
	{
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x8")]
		private int RotationId__BackingField;

		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0xC")]
		private RotationShopItems Current__BackingField;

		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0x10")]
		private RotationShopItems Next__BackingField;

		[Token(Token = "0x17000AA9")]
		public int RotationId
		{
			[Token(Token = "0x6004BAA")]
			[Address(RVA = "0x21C32E0", Offset = "0x21C32E0", VA = "0x21C32E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BAB")]
			[Address(RVA = "0x21C32E8", Offset = "0x21C32E8", VA = "0x21C32E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000AAA")]
		public RotationShopItems Current
		{
			[Token(Token = "0x6004BAC")]
			[Address(RVA = "0x21C32F0", Offset = "0x21C32F0", VA = "0x21C32F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BAD")]
			[Address(RVA = "0x21C32F8", Offset = "0x21C32F8", VA = "0x21C32F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000AAB")]
		public RotationShopItems Next
		{
			[Token(Token = "0x6004BAE")]
			[Address(RVA = "0x21C3300", Offset = "0x21C3300", VA = "0x21C3300")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BAF")]
			[Address(RVA = "0x21C3308", Offset = "0x21C3308", VA = "0x21C3308")]
			set
			{
			}
		}

		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x21C32D8", Offset = "0x21C32D8", VA = "0x21C32D8")]
		public RotationItemSet()
		{
		}
	}
}
