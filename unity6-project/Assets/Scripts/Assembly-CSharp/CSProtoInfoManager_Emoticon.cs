using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000AC3")]
public class CSProtoInfoManager_Emoticon : Dictionary<int, List<CSEmoticonSetInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x6004F03")]
	[Address(RVA = "0x21F430C", Offset = "0x21F430C", VA = "0x21F430C")]
	public CSProtoInfoManager_Emoticon()
	{
	}

	[Token(Token = "0x6004F04")]
	[Address(RVA = "0x21F4390", Offset = "0x21F4390", VA = "0x21F4390", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F05")]
	[Address(RVA = "0x21F43A0", Offset = "0x21F43A0", VA = "0x21F43A0", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6004F06")]
	[Address(RVA = "0x21F48B8", Offset = "0x21F48B8", VA = "0x21F48B8", Slot = "44")]
	public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F07")]
	[Address(RVA = "0x21F4E9C", Offset = "0x21F4E9C", VA = "0x21F4E9C")]
	public List<CSEmoticonSetInfo> GetEmoticonSetInfos(int id)
	{
		return null;
	}

	[Token(Token = "0x6004F08")]
	[Address(RVA = "0x21F5078", Offset = "0x21F5078", VA = "0x21F5078")]
	public CSEmoticonSetInfo GetEmoticonSetInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x6004F09")]
	[Address(RVA = "0x21F5154", Offset = "0x21F5154", VA = "0x21F5154")]
	public CSEmoticonSetInfo GetEmoticonInfo(int id, int subID)
	{
		return null;
	}

	[Token(Token = "0x6004F0A")]
	[Address(RVA = "0x21F5260", Offset = "0x21F5260", VA = "0x21F5260")]
	public List<CSEmoticonSetInfo> GetEmoticonSets()
	{
		return null;
	}

	[Token(Token = "0x6004F0B")]
	[Address(RVA = "0x21F555C", Offset = "0x21F555C", VA = "0x21F555C", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}
}
