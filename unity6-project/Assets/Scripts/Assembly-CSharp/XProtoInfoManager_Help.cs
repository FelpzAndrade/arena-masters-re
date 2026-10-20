using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200100F")]
public class XProtoInfoManager_Help : Dictionary<int, List<XHelpInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4005601")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<HelpLink, XHelpInfo> linkDic;

	[Token(Token = "0x4005602")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<XHelpInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60077CA")]
	[Address(RVA = "0x1C86884", Offset = "0x1C86884", VA = "0x1C86884")]
	public XProtoInfoManager_Help()
	{
	}

	[Token(Token = "0x60077CB")]
	[Address(RVA = "0x1C8B49C", Offset = "0x1C8B49C", VA = "0x1C8B49C", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x60077CC")]
	[Address(RVA = "0x1C8B4AC", Offset = "0x1C8B4AC", VA = "0x1C8B4AC", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60077CD")]
	[Address(RVA = "0x1C8B4B0", Offset = "0x1C8B4B0", VA = "0x1C8B4B0", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x60077CE")]
	[Address(RVA = "0x1C8B814", Offset = "0x1C8B814", VA = "0x1C8B814")]
	public void LoadFromServer(JToken source)
	{
	}

	[Token(Token = "0x60077CF")]
	[Address(RVA = "0x1C8B8A8", Offset = "0x1C8B8A8", VA = "0x1C8B8A8", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x60077D0")]
	[Address(RVA = "0x1C8BED0", Offset = "0x1C8BED0", VA = "0x1C8BED0")]
	public List<int> GetMainCategoryIDList(string country)
	{
		return null;
	}

	[Token(Token = "0x60077D1")]
	[Address(RVA = "0x1C8C178", Offset = "0x1C8C178", VA = "0x1C8C178")]
	public List<XHelpInfo> GetSubCategoryList(int groupID, string country)
	{
		return null;
	}

	[Token(Token = "0x60077D2")]
	[Address(RVA = "0x1C8C3C4", Offset = "0x1C8C3C4", VA = "0x1C8C3C4")]
	public XHelpInfo FindHelpItem(int groupID, int subNumber = 0)
	{
		return null;
	}

	[Token(Token = "0x60077D3")]
	[Address(RVA = "0x1C8C4E0", Offset = "0x1C8C4E0", VA = "0x1C8C4E0")]
	public XHelpInfo FindFirstHelpItem(HelpLink link)
	{
		return null;
	}

	[Token(Token = "0x60077D4")]
	[Address(RVA = "0x1C8C5A0", Offset = "0x1C8C5A0", VA = "0x1C8C5A0")]
	private static int _003CCooking_003Em__4FD(XHelpInfo x, XHelpInfo y)
	{
		return default(int);
	}
}
