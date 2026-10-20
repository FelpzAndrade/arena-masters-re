using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B1B")]
	public sealed class PackageShopInfoXML
	{
		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x8")]
		public List<PackageShopInfo> dataList;

		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x21AD6F8", Offset = "0x21AD6F8", VA = "0x21AD6F8")]
		public PackageShopInfoXML()
		{
		}

		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x21AD7A4", Offset = "0x21AD7A4", VA = "0x21AD7A4")]
		public void Add(PackageShopInfo i)
		{
		}
	}
}
