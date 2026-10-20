using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200087C")]
	public class CSContent
	{
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x8")]
		public CSContentType ContentType;

		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0xC")]
		public int ContentCount;

		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x10")]
		public int ContentId;

		[Token(Token = "0x40028E4")]
		[FieldOffset(Offset = "0x14")]
		public int Bonus;

		[Token(Token = "0x40028E5")]
		[FieldOffset(Offset = "0x18")]
		public int UsePaid;

		[Token(Token = "0x17000985")]
		public static CSContent None
		{
			[Token(Token = "0x60045C0")]
			[Address(RVA = "0x2229B14", Offset = "0x2229B14", VA = "0x2229B14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x2229A48", Offset = "0x2229A48", VA = "0x2229A48")]
		public CSContent()
		{
		}

		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x2229A6C", Offset = "0x2229A6C", VA = "0x2229A6C")]
		public CSContent(CSContentType type)
		{
		}

		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x2229A94", Offset = "0x2229A94", VA = "0x2229A94")]
		public CSContent(CSContentType type, int id, int count)
		{
		}

		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x2229AC8", Offset = "0x2229AC8", VA = "0x2229AC8")]
		public CSContent(CSContent other)
		{
		}

		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x2229BAC", Offset = "0x2229BAC", VA = "0x2229BAC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x2229C8C", Offset = "0x2229C8C", VA = "0x2229C8C")]
		public bool SameContent(CSContent other)
		{
			return default(bool);
		}

		[Token(Token = "0x60045C3")]
		[Address(RVA = "0x2229DC8", Offset = "0x2229DC8", VA = "0x2229DC8")]
		public bool IsGacha()
		{
			return default(bool);
		}

		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x2229DDC", Offset = "0x2229DDC", VA = "0x2229DDC")]
		public bool IsItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x2229DF0", Offset = "0x2229DF0", VA = "0x2229DF0")]
		public bool IsArenaCoin()
		{
			return default(bool);
		}

		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x2229E04", Offset = "0x2229E04", VA = "0x2229E04")]
		public bool IsProfileIcon()
		{
			return default(bool);
		}

		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x2229E18", Offset = "0x2229E18", VA = "0x2229E18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x2229E34", Offset = "0x2229E34", VA = "0x2229E34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x222A0EC", Offset = "0x222A0EC", VA = "0x222A0EC")]
		public bool IsArenaCoinInsteadOfItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x222A110", Offset = "0x222A110", VA = "0x222A110")]
		public void RestoreOriginalItemType()
		{
		}

		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x222A138", Offset = "0x222A138", VA = "0x222A138")]
		public Currency GetBonusCurrency()
		{
			return default(Currency);
		}
	}
}
