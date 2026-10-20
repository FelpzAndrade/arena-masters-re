using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000659")]
public class XDownloadEpisodeInfo
{
	[Token(Token = "0x4001E73")]
	[FieldOffset(Offset = "0x8")]
	public int Episode;

	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x4001E75")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, XDownloadPageInfo> pageInfos;

	[Token(Token = "0x170007E1")]
	public int PageCount
	{
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x19A89FC", Offset = "0x19A89FC", VA = "0x19A89FC")]
		get
		{
			return pageInfos.Count;
		}
	}

	[Token(Token = "0x6003628")]
	[Address(RVA = "0x19A8940", Offset = "0x19A8940", VA = "0x19A8940")]
	public XDownloadEpisodeInfo(int Episode, string language)
	{
		pageInfos = new Dictionary<int, XDownloadPageInfo>();
		this.Episode = Episode;
		this.language = language;
	}

	[Token(Token = "0x600362A")]
	[Address(RVA = "0x19A8A94", Offset = "0x19A8A94", VA = "0x19A8A94")]
	public bool ExistPageInfo(int pageID)
	{
		return pageInfos.ContainsKey(pageID);
	}

	[Token(Token = "0x600362B")]
	[Address(RVA = "0x19A8B34", Offset = "0x19A8B34", VA = "0x19A8B34")]
	public void AddPageInfo(string bgPath1, string bgPath2, int pageID)
	{
		pageInfos.Add(pageID, new XDownloadPageInfo(bgPath1, bgPath2, pageID));
	}

	[Token(Token = "0x600362C")]
	[Address(RVA = "0x19A8D50", Offset = "0x19A8D50", VA = "0x19A8D50")]
	public void AddDisplayInfo(int pageID, XDownloadImgDisplayInfo displayInfo)
	{
		pageInfos[pageID].AddDisplayInfo(displayInfo);
	}

	[Token(Token = "0x600362D")]
	[Address(RVA = "0x19A8EE4", Offset = "0x19A8EE4", VA = "0x19A8EE4")]
	public XDownloadPageInfo GetPageInfo(int page)
	{
		if (!ExistPageInfo(page))
		{
			return null;
		}
		return pageInfos[page];
	}
}
