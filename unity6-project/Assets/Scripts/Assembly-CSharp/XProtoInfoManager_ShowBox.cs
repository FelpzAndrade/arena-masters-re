using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000678")]
public class XProtoInfoManager_ShowBox : Dictionary<int, List<ShowBoxInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x6003689")]
	[Address(RVA = "0x1C86534", Offset = "0x1C86534", VA = "0x1C86534")]
	public XProtoInfoManager_ShowBox()
	{
	}

	[Token(Token = "0x600368A")]
	[Address(RVA = "0x1C90004", Offset = "0x1C90004", VA = "0x1C90004", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x600368B")]
	[Address(RVA = "0x1C90014", Offset = "0x1C90014", VA = "0x1C90014", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x600368C")]
	[Address(RVA = "0x1C90018", Offset = "0x1C90018", VA = "0x1C90018", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x600368D")]
	[Address(RVA = "0x1C90020", Offset = "0x1C90020", VA = "0x1C90020", Slot = "44")]
	public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}
}
