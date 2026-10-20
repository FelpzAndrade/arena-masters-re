using System.Xml.Serialization;
using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000658")]
public class XDownloadImgXMLInfo
{
	[Token(Token = "0x4001E61")]
	[FieldOffset(Offset = "0x8")]
	[XmlAttribute("id")]
	public int id;

	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0xC")]
	[XmlAttribute("language")]
	public string language;

	[Token(Token = "0x4001E63")]
	[FieldOffset(Offset = "0x10")]
	[XmlAttribute("bg_path_1")]
	public string bgPath1;

	[Token(Token = "0x4001E64")]
	[FieldOffset(Offset = "0x14")]
	[XmlAttribute("bg_path_2")]
	public string bgPath2;

	[Token(Token = "0x4001E65")]
	[FieldOffset(Offset = "0x18")]
	[XmlAttribute("img_path")]
	public string imgPath;

	[Token(Token = "0x4001E66")]
	[FieldOffset(Offset = "0x1C")]
	[XmlAttribute("ep")]
	public int episode;

	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0x20")]
	[XmlAttribute("page_id")]
	public int page_id;

	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0x24")]
	[XmlAttribute("text")]
	public string text;

	[Token(Token = "0x4001E69")]
	[FieldOffset(Offset = "0x28")]
	[XmlAttribute("position_x")]
	public float posX;

	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0x2C")]
	[XmlAttribute("position_y")]
	public float posY;

	[Token(Token = "0x4001E6B")]
	[FieldOffset(Offset = "0x30")]
	[XmlAttribute("size_x")]
	public int sizeX;

	[Token(Token = "0x4001E6C")]
	[FieldOffset(Offset = "0x34")]
	[XmlAttribute("size_y")]
	public int sizeY;

	[Token(Token = "0x4001E6D")]
	[FieldOffset(Offset = "0x38")]
	[XmlAttribute("font_size")]
	public int fontSize;

	[Token(Token = "0x4001E6E")]
	[FieldOffset(Offset = "0x3C")]
	[XmlAttribute("rotation")]
	public int rotation;

	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x40")]
	[XmlAttribute("outline_size")]
	public float outlineSize;

	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0x44")]
	[XmlAttribute("outline_color")]
	public string outlineColor;

	[Token(Token = "0x4001E71")]
	[FieldOffset(Offset = "0x48")]
	[XmlAttribute("text_space_x")]
	public float textSpaceX;

	[Token(Token = "0x4001E72")]
	[FieldOffset(Offset = "0x4C")]
	[XmlAttribute("text_space_y")]
	public float textSpaceY;

	[Token(Token = "0x6003627")]
	[Address(RVA = "0x19A926C", Offset = "0x19A926C", VA = "0x19A926C")]
	public XDownloadImgXMLInfo()
	{
	}
}
