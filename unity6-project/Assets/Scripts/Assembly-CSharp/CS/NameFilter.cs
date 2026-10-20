using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000907")]
	public class NameFilter
	{
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x8")]
		private List<string> m_allow_words;

		[Token(Token = "0x4002B7B")]
		[FieldOffset(Offset = "0xC")]
		private List<string> m_disallow_words;

		[Token(Token = "0x170009B4")]
		public int DisallowWordsCount
		{
			[Token(Token = "0x600485B")]
			[Address(RVA = "0x233DB90", Offset = "0x233DB90", VA = "0x233DB90")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004853")]
		[Address(RVA = "0x233CFBC", Offset = "0x233CFBC", VA = "0x233CFBC")]
		public NameFilter()
		{
		}

		[Token(Token = "0x6004854")]
		[Address(RVA = "0x233D080", Offset = "0x233D080", VA = "0x233D080", Slot = "4")]
		public virtual bool load_from_file(string path_allow, string path_disallow)
		{
			return default(bool);
		}

		[Token(Token = "0x6004855")]
		[Address(RVA = "0x233D43C", Offset = "0x233D43C", VA = "0x233D43C")]
		public void create_allow_filter(string text)
		{
		}

		[Token(Token = "0x6004856")]
		[Address(RVA = "0x233D604", Offset = "0x233D604", VA = "0x233D604")]
		public void create_disallow_filter(string text)
		{
		}

		[Token(Token = "0x6004857")]
		[Address(RVA = "0x233D1F8", Offset = "0x233D1F8", VA = "0x233D1F8")]
		private void _load(string path, List<string> list)
		{
		}

		[Token(Token = "0x6004858")]
		[Address(RVA = "0x233D86C", Offset = "0x233D86C", VA = "0x233D86C")]
		public bool is_valid(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6004859")]
		[Address(RVA = "0x233C284", Offset = "0x233C284", VA = "0x233C284")]
		public bool is_not_disallow_words(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x600485A")]
		[Address(RVA = "0x233DA54", Offset = "0x233DA54", VA = "0x233DA54")]
		public bool is_allowd_char(string val)
		{
			return default(bool);
		}
	}
}
