using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000648")]
public class XProtoInfoManager_BattleRecord : Dictionary<int, XBattleRecord_ViewInfo>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4001E3C")]
	[FieldOffset(Offset = "0x34")]
	public List<int> Order;

	[Token(Token = "0x60035E4")]
	[Address(RVA = "0x1C86AB0", Offset = "0x1C86AB0", VA = "0x1C86AB0")]
	public XProtoInfoManager_BattleRecord()
	{
	}

	[Token(Token = "0x60035E5")]
	[Address(RVA = "0x1C86F18", Offset = "0x1C86F18", VA = "0x1C86F18", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60035E6")]
	[Address(RVA = "0x1C86F1C", Offset = "0x1C86F1C", VA = "0x1C86F1C", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x60035E7")]
	[Address(RVA = "0x1C872AC", Offset = "0x1C872AC", VA = "0x1C872AC", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x60035E8")]
	[Address(RVA = "0x1C872BC", Offset = "0x1C872BC", VA = "0x1C872BC", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x60035E9")]
	[Address(RVA = "0x1C87594", Offset = "0x1C87594", VA = "0x1C87594")]
	private void CookingList(List<XBattleRecord_XMLData> dataList)
	{
	}

	[Token(Token = "0x60035EA")]
	[Address(RVA = "0x1C8778C", Offset = "0x1C8778C", VA = "0x1C8778C")]
	public XBattleRecord_ViewInfo GetViewInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x60035EB")]
	[Address(RVA = "0x1C878E4", Offset = "0x1C878E4", VA = "0x1C878E4")]
	public XBattleRecord_ViewInfo GetViewInfo(MatchType matchType, XGameModeType gameModeType)
	{
		return null;
	}
}
