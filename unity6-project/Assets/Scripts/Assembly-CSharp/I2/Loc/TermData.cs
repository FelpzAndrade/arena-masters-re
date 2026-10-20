using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x200007F")]
	public class TermData
	{
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x8")]
		public string Term;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0xC")]
		public eTermType TermType;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x10")]
		public string Description;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x14")]
		public string[] Languages;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x18")]
		public string[] Languages_Touch;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x1C")]
		public byte[] Flags;

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD6B4C4", Offset = "0xD6B4C4", VA = "0xD6B4C4")]
		public TermData()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xD6EFF0", Offset = "0xD6EFF0", VA = "0xD6EFF0")]
		public string GetTranslation(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xD88750", Offset = "0xD88750", VA = "0xD88750")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD673F0", Offset = "0xD673F0", VA = "0xD673F0")]
		public bool HasTouchTranslations()
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD6DA28", Offset = "0xD6DA28", VA = "0xD6DA28")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD88748", Offset = "0xD88748", VA = "0xD88748")]
		public static bool IsTouchType()
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD6F548", Offset = "0xD6F548", VA = "0xD6F548")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}
	}
}
