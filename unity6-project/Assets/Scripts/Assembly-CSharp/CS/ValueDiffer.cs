using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000980")]
	public class ValueDiffer<T> where T : struct
	{
		[Token(Token = "0x4002EF7")]
		[FieldOffset(Offset = "0x0")]
		private T Before__BackingField;

		[Token(Token = "0x4002EF8")]
		[FieldOffset(Offset = "0x0")]
		private T After__BackingField;

		[Token(Token = "0x17000AEE")]
		public T Before
		{
			[Token(Token = "0x6004C5C")]
			get
			{
				return (T)default;
			}
			[Token(Token = "0x6004C5D")]
			set
			{
			}
		}

		[Token(Token = "0x17000AEF")]
		public T After
		{
			[Token(Token = "0x6004C5E")]
			get
			{
				return (T)default;
			}
			[Token(Token = "0x6004C5F")]
			set
			{
			}
		}

		[Token(Token = "0x6004C5B")]
		public ValueDiffer(T Before)
		{
		}
	}
}
