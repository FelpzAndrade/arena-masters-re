using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200096F")]
	public class PtPlayData
	{
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x8")]
		private bool IsEnd__BackingField;

		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0xC")]
		private int PlayCnt__BackingField;

		[Token(Token = "0x17000AD1")]
		public bool IsEnd
		{
			[Token(Token = "0x6004C0A")]
			[Address(RVA = "0x21B9B78", Offset = "0x21B9B78", VA = "0x21B9B78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C0B")]
			[Address(RVA = "0x21B9B68", Offset = "0x21B9B68", VA = "0x21B9B68")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD2")]
		public int PlayCnt
		{
			[Token(Token = "0x6004C0C")]
			[Address(RVA = "0x21B9B80", Offset = "0x21B9B80", VA = "0x21B9B80")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C0D")]
			[Address(RVA = "0x21B9B70", Offset = "0x21B9B70", VA = "0x21B9B70")]
			set
			{
			}
		}

		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x21B9B44", Offset = "0x21B9B44", VA = "0x21B9B44")]
		public PtPlayData()
		{
		}
	}
}
