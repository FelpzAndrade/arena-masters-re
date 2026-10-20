using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200064E")]
public class XProtoInfoManager_ClanLevel : List<XClanLevelInfo>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4001E45")]
	[FieldOffset(Offset = "0x14")]
	public List<int> ExpList;

	[Token(Token = "0x60035FB")]
	[Address(RVA = "0x1C869C0", Offset = "0x1C869C0", VA = "0x1C869C0")]
	public XProtoInfoManager_ClanLevel()
	{
	}

	[Token(Token = "0x60035FC")]
	[Address(RVA = "0x1C888D4", Offset = "0x1C888D4", VA = "0x1C888D4", Slot = "35")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60035FD")]
	[Address(RVA = "0x1C888D8", Offset = "0x1C888D8", VA = "0x1C888D8", Slot = "34")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FE")]
	[Address(RVA = "0x1C88B58", Offset = "0x1C88B58", VA = "0x1C88B58", Slot = "33")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FF")]
	[Address(RVA = "0x1C88B68", Offset = "0x1C88B68", VA = "0x1C88B68", Slot = "36")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6003600")]
	[Address(RVA = "0x1C88ED8", Offset = "0x1C88ED8", VA = "0x1C88ED8")]
	public XClanLevelInfo GetLevelInfo(int exp)
	{
		return null;
	}

	[Token(Token = "0x6003601")]
	[Address(RVA = "0x1C88FE4", Offset = "0x1C88FE4", VA = "0x1C88FE4")]
	private void _003CLoadFromLocalFile_003Em__17B(XClanLevelInfo e)
	{
	}
}
