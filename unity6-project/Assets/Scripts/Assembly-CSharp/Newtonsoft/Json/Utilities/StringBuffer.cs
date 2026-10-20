using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200016A")]
	internal class StringBuffer
	{
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x8")]
		private char[] _buffer;

		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0xC")]
		private int _position;

		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] _emptyBuffer;

		[Token(Token = "0x17000239")]
		public int Position
		{
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x11A0360", Offset = "0x11A0360", VA = "0x11A0360")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x11A0368", Offset = "0x11A0368", VA = "0x11A0368")]
			set
			{
			}
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x11A0154", Offset = "0x11A0154", VA = "0x11A0154")]
		public StringBuffer()
		{
		}

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x11A0218", Offset = "0x11A0218", VA = "0x11A0218")]
		public StringBuffer(int initalSize)
		{
		}

		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x11A0370", Offset = "0x11A0370", VA = "0x11A0370")]
		public void Append(char value)
		{
		}

		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x11A04BC", Offset = "0x11A04BC", VA = "0x11A04BC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x11A03F4", Offset = "0x11A03F4", VA = "0x11A03F4")]
		private void EnsureSize(int appendLength)
		{
		}

		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x11A057C", Offset = "0x11A057C", VA = "0x11A057C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x11A05AC", Offset = "0x11A05AC", VA = "0x11A05AC")]
		public string ToString(int start, int length)
		{
			return null;
		}

		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x11A05DC", Offset = "0x11A05DC", VA = "0x11A05DC")]
		public char[] GetInternalBuffer()
		{
			return null;
		}
	}
}
