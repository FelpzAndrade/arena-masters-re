using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B95")]
	public class ContentsTags
	{
		[Token(Token = "0x4003B23")]
		[FieldOffset(Offset = "0x8")]
		private HashSet<string> m_ContentsTags;

		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x23ED2E4", Offset = "0x23ED2E4", VA = "0x23ED2E4")]
		public ContentsTags()
		{
		}

		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x23ED390", Offset = "0x23ED390", VA = "0x23ED390")]
		public void Init(string tags)
		{
		}

		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x23ED57C", Offset = "0x23ED57C", VA = "0x23ED57C")]
		public bool Check(string contentsTag)
		{
			return default(bool);
		}
	}
}
