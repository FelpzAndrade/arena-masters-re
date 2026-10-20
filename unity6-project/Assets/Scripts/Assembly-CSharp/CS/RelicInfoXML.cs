using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B3F")]
	public sealed class RelicInfoXML
	{
		[Token(Token = "0x40037BE")]
		[FieldOffset(Offset = "0x8")]
		public List<RelicInfo> m_relic;

		[Token(Token = "0x6005238")]
		[Address(RVA = "0x21C14A0", Offset = "0x21C14A0", VA = "0x21C14A0")]
		public RelicInfoXML()
		{
		}

		[Token(Token = "0x6005239")]
		[Address(RVA = "0x21C154C", Offset = "0x21C154C", VA = "0x21C154C")]
		public void Add(RelicInfo val)
		{
		}
	}
}
