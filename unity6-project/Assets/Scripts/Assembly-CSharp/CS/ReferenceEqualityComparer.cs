using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008B6")]
	public class ReferenceEqualityComparer : EqualityComparer<object>
	{
		[Token(Token = "0x600468C")]
		[Address(RVA = "0x21C0CAC", Offset = "0x21C0CAC", VA = "0x21C0CAC")]
		public ReferenceEqualityComparer()
		{
		}

		[Token(Token = "0x600468D")]
		[Address(RVA = "0x21C0D68", Offset = "0x21C0D68", VA = "0x21C0D68", Slot = "9")]
		public override bool Equals(object x, object y)
		{
			return default(bool);
		}

		[Token(Token = "0x600468E")]
		[Address(RVA = "0x21C0D74", Offset = "0x21C0D74", VA = "0x21C0D74", Slot = "8")]
		public override int GetHashCode(object obj)
		{
			return default(int);
		}
	}
}
