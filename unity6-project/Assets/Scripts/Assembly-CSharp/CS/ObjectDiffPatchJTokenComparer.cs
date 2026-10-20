using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000B9D")]
	internal class ObjectDiffPatchJTokenComparer : IEqualityComparer<JToken>
	{
		[Token(Token = "0x600541F")]
		[Address(RVA = "0x2342980", Offset = "0x2342980", VA = "0x2342980")]
		public ObjectDiffPatchJTokenComparer()
		{
		}

		[Token(Token = "0x6005420")]
		[Address(RVA = "0x2342988", Offset = "0x2342988", VA = "0x2342988", Slot = "4")]
		public bool Equals(JToken x, JToken y)
		{
			return default(bool);
		}

		[Token(Token = "0x6005421")]
		[Address(RVA = "0x23429BC", Offset = "0x23429BC", VA = "0x23429BC", Slot = "5")]
		public int GetHashCode(JToken i)
		{
			return default(int);
		}
	}
}
