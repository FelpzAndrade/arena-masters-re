using UnityEngine;
using System.Text;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200065D")]
public class XProtoInfoManager_DownloadImg : Dictionary<string, Dictionary<int, XDownloadEpisodeInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x600363A")]
	[Address(RVA = "0x1C863A8", Offset = "0x1C863A8", VA = "0x1C863A8")]
	public XProtoInfoManager_DownloadImg()
	{
	}

	[Token(Token = "0x600363B")]
	[Address(RVA = "0x1C8A87C", Offset = "0x1C8A87C", VA = "0x1C8A87C", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return from == ProtoInfoFrom.Client;
	}

	[Token(Token = "0x600363C")]
	[Address(RVA = "0x1C8A88C", Offset = "0x1C8A88C", VA = "0x1C8A88C", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x600363D")]
	[Address(RVA = "0x1C8A890", Offset = "0x1C8A890", VA = "0x1C8A890", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return true;
	}

	[Token(Token = "0x600363E")]
	[Address(RVA = "0x1C8A898", Offset = "0x1C8A898", VA = "0x1C8A898")]
	public void CookingList(List<XDownloadImgXMLInfo> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			XDownloadImgXMLInfo info = dataList[i];
			string language = info.language.ToString().ToLower();
			if (!ContainsKey(language))
			{
				Add(language, new Dictionary<int, XDownloadEpisodeInfo>());
			}
			int episode = info.episode;
			if (!this[language].ContainsKey(episode))
			{
				this[language].Add(episode, new XDownloadEpisodeInfo(episode, language));
			}
			XDownloadEpisodeInfo episodeInfo = this[language][episode];
			if (!episodeInfo.ExistPageInfo(info.page_id))
			{
				episodeInfo.AddPageInfo(info.bgPath1, info.bgPath2, info.page_id);
			}
			episodeInfo.AddDisplayInfo(info.page_id, CreateDisplayInfo(info));
		}
	}

	[Token(Token = "0x600363F")]
	[Address(RVA = "0x1C8AF60", Offset = "0x1C8AF60", VA = "0x1C8AF60", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		Clear();
		XDownloadImgInfoXML xml = CSXMLSerialization.Deserialize<XDownloadImgInfoXML>(loader, Encoding.UTF8);
		if (xml == null)
		{
			if (loader != null)
			{
				CSLog.Error("Load failed : " + loader.Filename);
			}
			return false;
		}
		CookingList(xml.dataList);
		CSLog.Info("Load complete : " + loader.Filename);
		return true;
	}

	[Token(Token = "0x6003640")]
	[Address(RVA = "0x1C8AC48", Offset = "0x1C8AC48", VA = "0x1C8AC48")]
	private XDownloadImgDisplayInfo CreateDisplayInfo(XDownloadImgXMLInfo info)
	{
		if (info.fontSize == 0)
		{
			info.fontSize = 24;
		}
		string imgPath = info.imgPath;
		string text = null;
		if (string.IsNullOrEmpty(imgPath))
		{
			text = info.text;
		}
		XDownloadImgDisplayInfo display = new XDownloadImgDisplayInfo();
		display.ImgPath = imgPath;
		display.Text = CSHelper.ReplaceCodeText(text);
		display.Position = new Vector2(info.posX, info.posY);
		display.Size = new Vector2(info.sizeX, info.sizeY);
		display.FontSize = info.fontSize;
		display.Rotation = new Vector3(0f, 0f, info.rotation);
		display.OutlineColor = string.IsNullOrEmpty(info.outlineColor) ? Color.white : XUIHelper.HexToColor(info.outlineColor);
		display.OutlineSize = info.outlineSize;
		display.TextSpace = new Vector2(info.textSpaceX, info.textSpaceY);
		return display;
	}

	[Token(Token = "0x6003641")]
	[Address(RVA = "0x1C8B250", Offset = "0x1C8B250", VA = "0x1C8B250")]
	public Dictionary<int, XDownloadEpisodeInfo> GetDownloadImgListsByLanguage(string strLanguage)
	{
		string language = strLanguage.ToLower();
		if (ContainsKey(language))
		{
			return this[language];
		}
		string fallback = "en-US".ToLower();
		if (ContainsKey(fallback))
		{
			return this[fallback];
		}
		return new Dictionary<int, XDownloadEpisodeInfo>();
	}
}
