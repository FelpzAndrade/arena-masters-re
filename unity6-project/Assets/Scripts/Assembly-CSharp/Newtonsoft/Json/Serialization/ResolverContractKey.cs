using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200011A")]
	internal struct ResolverContractKey : IEquatable<ResolverContractKey>
	{
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x0")]
		private readonly Type _resolverType;

		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x4")]
		private readonly Type _contractType;

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x11929C4", Offset = "0x11929C4", VA = "0x11929C4")]
		public ResolverContractKey(Type resolverType, Type contractType)
		{
			this = default;
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x1192A64", Offset = "0x1192A64", VA = "0x1192A64", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x1192B5C", Offset = "0x1192B5C", VA = "0x1192B5C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x1192B64", Offset = "0x1192B64", VA = "0x1192B64", Slot = "4")]
		public bool Equals(ResolverContractKey other)
		{
			return default(bool);
		}
	}
}
