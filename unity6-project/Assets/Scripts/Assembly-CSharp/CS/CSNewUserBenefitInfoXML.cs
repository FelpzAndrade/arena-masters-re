using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B13")]
	public sealed class CSNewUserBenefitInfoXML
	{
		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x8")]
		public List<CSNewUserBenefitInfo> Benefits;

		[Token(Token = "0x6005157")]
		[Address(RVA = "0x1FBFA74", Offset = "0x1FBFA74", VA = "0x1FBFA74")]
		public CSNewUserBenefitInfoXML()
		{
		}

		[Token(Token = "0x6005158")]
		[Address(RVA = "0x1FBFB20", Offset = "0x1FBFB20", VA = "0x1FBFB20")]
		public void Add(CSNewUserBenefitInfo benefit)
		{
		}
	}
}
