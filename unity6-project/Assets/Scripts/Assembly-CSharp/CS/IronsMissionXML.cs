using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AFA")]
	public sealed class IronsMissionXML
	{
		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x8")]
		public List<IronsMission> dataList;

		[Token(Token = "0x60050EF")]
		[Address(RVA = "0x233975C", Offset = "0x233975C", VA = "0x233975C")]
		public IronsMissionXML()
		{
		}

		[Token(Token = "0x60050F0")]
		[Address(RVA = "0x2339808", Offset = "0x2339808", VA = "0x2339808")]
		public void Add(IronsMission i)
		{
		}
	}
}
