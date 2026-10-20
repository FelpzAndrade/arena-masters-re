using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000673")]
public sealed class PackageDetailInfoXML
{
	[Token(Token = "0x4001EF0")]
	[FieldOffset(Offset = "0x8")]
	public List<PackageDetailInfo> dataList;

	[Token(Token = "0x600367E")]
	[Address(RVA = "0x1B77504", Offset = "0x1B77504", VA = "0x1B77504")]
	public PackageDetailInfoXML()
	{
	}

	[Token(Token = "0x600367F")]
	[Address(RVA = "0x1B775B0", Offset = "0x1B775B0", VA = "0x1B775B0")]
	public void Add(PackageDetailInfo i)
	{
	}
}
