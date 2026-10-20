using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000CA")]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x18")]
		private MemberSerialization _memberSerialization;

		[Token(Token = "0x170000E3")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0xF6C008", Offset = "0xF6C008", VA = "0xF6C008")]
			get
			{
				return default(MemberSerialization);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xF6BFF8", Offset = "0xF6BFF8", VA = "0xF6BFF8")]
			set
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xF6BFD0", Offset = "0xF6BFD0", VA = "0xF6BFD0")]
		public JsonObjectAttribute()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xF6BFD8", Offset = "0xF6BFD8", VA = "0xF6BFD8")]
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xF6C000", Offset = "0xF6C000", VA = "0xF6C000")]
		public JsonObjectAttribute(string id)
		{
		}
	}
}
