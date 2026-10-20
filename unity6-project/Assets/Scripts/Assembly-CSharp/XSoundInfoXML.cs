using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

// Reconstruido a partir do pseudo-C (Ghidra) de libil2cpp.so; nomes XML conforme Resources/xml/sound_xml.
[Serializable]
[Token(Token = "0x2000BB2")]
[XmlRoot("t1")]
public sealed class XSoundInfoXML
{
	[Token(Token = "0x4003B8B")]
	[FieldOffset(Offset = "0x8")]
	[XmlElement("SOUND")]
	public List<XSoundInfo> dataList;

	[Token(Token = "0x60054A5")]
	[Address(RVA = "0x1825A5C", Offset = "0x1825A5C", VA = "0x1825A5C")]
	public XSoundInfoXML()
	{
		dataList = new List<XSoundInfo>();
	}

	[Token(Token = "0x60054A6")]
	[Address(RVA = "0x1825B08", Offset = "0x1825B08", VA = "0x1825B08")]
	public void Add(XSoundInfo i)
	{
		dataList.Add(i);
	}
}
