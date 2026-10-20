using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200065C")]
[XmlRoot("t1")]
public sealed class XDownloadImgInfoXML
{
	[Token(Token = "0x4001E85")]
	[FieldOffset(Offset = "0x8")]
	[XmlElement("DOWNLOADIMG")]
	public List<XDownloadImgXMLInfo> dataList;

	[Token(Token = "0x6003638")]
	[Address(RVA = "0x19A9120", Offset = "0x19A9120", VA = "0x19A9120")]
	public XDownloadImgInfoXML()
	{
		dataList = new List<XDownloadImgXMLInfo>();
	}

	[Token(Token = "0x6003639")]
	[Address(RVA = "0x19A91CC", Offset = "0x19A91CC", VA = "0x19A91CC")]
	public void Add(XDownloadImgXMLInfo i)
	{
		dataList.Add(i);
	}
}
