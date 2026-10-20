using System.Collections;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000685")]
public class XProtoInfoManager_Tips : Dictionary<int, XTips>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4001FCD")]
	[FieldOffset(Offset = "0x34")]
	private ArrayList m_TipsBufferArrayList;

	[Token(Token = "0x600370F")]
	[Address(RVA = "0x1C865B8", Offset = "0x1C865B8", VA = "0x1C865B8")]
	public XProtoInfoManager_Tips()
	{
	}

	[Token(Token = "0x6003710")]
	[Address(RVA = "0x1C91960", Offset = "0x1C91960", VA = "0x1C91960", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6003711")]
	[Address(RVA = "0x1C91970", Offset = "0x1C91970", VA = "0x1C91970", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6003712")]
	[Address(RVA = "0x1C91974", Offset = "0x1C91974", VA = "0x1C91974", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x6003713")]
	[Address(RVA = "0x1C91AD0", Offset = "0x1C91AD0", VA = "0x1C91AD0", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6003714")]
	[Address(RVA = "0x1C91E24", Offset = "0x1C91E24", VA = "0x1C91E24")]
	public string GetRandomtip(int nTeamLevel, XGameModeType nGameModeType = XGameModeType.NA)
	{
		return null;
	}

	[Token(Token = "0x6003715")]
	[Address(RVA = "0x1C9236C", Offset = "0x1C9236C", VA = "0x1C9236C")]
	private static string MakeTipString(XTips tip)
	{
		return null;
	}

	[Token(Token = "0x6003716")]
	[Address(RVA = "0x1C92748", Offset = "0x1C92748", VA = "0x1C92748")]
	private void _003CLoadFromLocalFile_003Em__188(XTips e)
	{
	}
}
