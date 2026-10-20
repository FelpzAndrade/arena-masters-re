using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B25")]
	public sealed class PremiumTicketInfoXML
	{
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x8")]
		public List<PremiumTicketInfo> premiumTicketInfoList;

		[Token(Token = "0x60051EF")]
		[Address(RVA = "0x21AEC30", Offset = "0x21AEC30", VA = "0x21AEC30")]
		public PremiumTicketInfoXML()
		{
		}

		[Token(Token = "0x60051F0")]
		[Address(RVA = "0x21AECDC", Offset = "0x21AECDC", VA = "0x21AECDC")]
		public void Add(PremiumTicketInfo i)
		{
		}
	}
}
