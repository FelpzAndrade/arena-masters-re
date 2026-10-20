using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000ABF")]
public class CSProtoInfoManager_Emblem : Dictionary<int, List<CSEmblemSetInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x6004EF5")]
	[Address(RVA = "0x21F370C", Offset = "0x21F370C", VA = "0x21F370C")]
	public CSProtoInfoManager_Emblem()
	{
	}

	[Token(Token = "0x6004EF6")]
	[Address(RVA = "0x21F3790", Offset = "0x21F3790", VA = "0x21F3790", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EF7")]
	[Address(RVA = "0x21F37A0", Offset = "0x21F37A0", VA = "0x21F37A0", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6004EF8")]
	[Address(RVA = "0x21F37A4", Offset = "0x21F37A4", VA = "0x21F37A4", Slot = "44")]
	public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EF9")]
	[Address(RVA = "0x21F3D74", Offset = "0x21F3D74", VA = "0x21F3D74", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EFA")]
	[Address(RVA = "0x21F3F48", Offset = "0x21F3F48", VA = "0x21F3F48")]
	public int GetEmblemSetInfo(XGameModeType type, UserDataBase user)
	{
		return default(int);
	}

	[Token(Token = "0x6004EFB")]
	[Address(RVA = "0x21F417C", Offset = "0x21F417C", VA = "0x21F417C")]
	public CSEmblemSetInfo GetEmblemSetInfo(XGameModeType type, int iD)
	{
		return null;
	}
}
