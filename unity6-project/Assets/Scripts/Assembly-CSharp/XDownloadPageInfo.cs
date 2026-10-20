using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200065B")]
public class XDownloadPageInfo
{
	[Token(Token = "0x4001E7F")]
	[FieldOffset(Offset = "0x8")]
	public string bgPath1;

	[Token(Token = "0x4001E80")]
	[FieldOffset(Offset = "0xC")]
	public string bgPath2;

	[Token(Token = "0x4001E81")]
	[FieldOffset(Offset = "0x10")]
	public int page_id;

	[Token(Token = "0x4001E82")]
	[FieldOffset(Offset = "0x14")]
	private List<XDownloadImgDisplayInfo> displayInfos;

	[Token(Token = "0x4001E83")]
	[FieldOffset(Offset = "0x18")]
	private int ImgCount__BackingField;

	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0x1C")]
	private int TextCount__BackingField;

	[Token(Token = "0x170007E2")]
	public int ImgCount
	{
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x19A9274", Offset = "0x19A9274", VA = "0x19A9274")]
		get
		{
			return ImgCount__BackingField;
		}
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x19A927C", Offset = "0x19A927C", VA = "0x19A927C")]
		set
		{
			ImgCount__BackingField = value;
		}
	}

	[Token(Token = "0x170007E3")]
	public int TextCount
	{
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x19A9284", Offset = "0x19A9284", VA = "0x19A9284")]
		get
		{
			return TextCount__BackingField;
		}
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x19A928C", Offset = "0x19A928C", VA = "0x19A928C")]
		set
		{
			TextCount__BackingField = value;
		}
	}

	[Token(Token = "0x6003631")]
	[Address(RVA = "0x19A8C20", Offset = "0x19A8C20", VA = "0x19A8C20")]
	public XDownloadPageInfo(string bgPath1, string bgPath2, int pageID)
	{
		displayInfos = new List<XDownloadImgDisplayInfo>();
		this.bgPath1 = bgPath1;
		this.bgPath2 = bgPath2;
		page_id = pageID;
	}

	[Token(Token = "0x6003636")]
	[Address(RVA = "0x19A8E04", Offset = "0x19A8E04", VA = "0x19A8E04")]
	public void AddDisplayInfo(XDownloadImgDisplayInfo displayInfo)
	{
		displayInfos.Add(displayInfo);
		if (displayInfo.IsImgDisplay())
		{
			ImgCount++;
		}
		else if (displayInfo.IsTextDisplay())
		{
			TextCount++;
		}
	}

	[Token(Token = "0x6003637")]
	[Address(RVA = "0x19A9294", Offset = "0x19A9294", VA = "0x19A9294")]
	public List<XDownloadImgDisplayInfo> GetDisplayInfos()
	{
		return new List<XDownloadImgDisplayInfo>(displayInfos);
	}
}
