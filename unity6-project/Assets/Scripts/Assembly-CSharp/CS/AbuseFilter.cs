using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008EE")]
	public class AbuseFilter
	{
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x8")]
		private AbuseCharNode m_root_node;

		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string m_cheating_char;

		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MAX_ABUSE_WORD_LEN;

		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int MAX_PUNC_CHUNK_LEN;

		[Token(Token = "0x6004790")]
		[Address(RVA = "0x23E44AC", Offset = "0x23E44AC", VA = "0x23E44AC")]
		public AbuseFilter()
		{
		}

		[Token(Token = "0x6004792")]
		[Address(RVA = "0x23E45F4", Offset = "0x23E45F4", VA = "0x23E45F4", Slot = "4")]
		public virtual void load_from_file(string filePath)
		{
		}

		[Token(Token = "0x6004793")]
		[Address(RVA = "0x23E4714", Offset = "0x23E4714", VA = "0x23E4714")]
		public void create_abuse_filter(string text)
		{
		}

		[Token(Token = "0x6004794")]
		[Address(RVA = "0x23E4890", Offset = "0x23E4890", VA = "0x23E4890")]
		public bool add_abuse_word(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6004795")]
		[Address(RVA = "0x23E4A30", Offset = "0x23E4A30", VA = "0x23E4A30")]
		public bool is_valid(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6004796")]
		[Address(RVA = "0x23E4C90", Offset = "0x23E4C90", VA = "0x23E4C90")]
		public string filtering(string val)
		{
			return null;
		}

		[Token(Token = "0x6004797")]
		[Address(RVA = "0x23E4AD8", Offset = "0x23E4AD8", VA = "0x23E4AD8")]
		public int match(string val)
		{
			return default(int);
		}

		[Token(Token = "0x6004798")]
		[Address(RVA = "0x23E4E2C", Offset = "0x23E4E2C", VA = "0x23E4E2C")]
		public bool is_punctutation(string val)
		{
			return default(bool);
		}
	}
}
