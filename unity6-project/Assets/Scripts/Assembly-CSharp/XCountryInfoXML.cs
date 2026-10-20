using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000655")]
[XmlRoot("t1")]
public sealed class XCountryInfoXML
{
	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x8")]
	[XmlElement("COUNTRY")]
	public List<XCountryInfo> dataList;

	[Token(Token = "0x6003618")]
	[Address(RVA = "0x19A1930", Offset = "0x19A1930", VA = "0x19A1930")]
	public XCountryInfoXML()
	{
		dataList = new List<XCountryInfo>();
	}

	[Token(Token = "0x6003619")]
	[Address(RVA = "0x19A19DC", Offset = "0x19A19DC", VA = "0x19A19DC")]
	public void Add(XCountryInfo i)
	{
		dataList.Add(i);
	}
}
