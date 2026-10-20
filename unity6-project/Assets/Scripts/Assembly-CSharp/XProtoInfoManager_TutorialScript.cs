using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200068A")]
public class XProtoInfoManager_TutorialScript : Dictionary<int, TutorialGroup>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4002001")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, int> tutoObjectIDDic;

	[Token(Token = "0x600371A")]
	[Address(RVA = "0x1C86660", Offset = "0x1C86660", VA = "0x1C86660")]
	public XProtoInfoManager_TutorialScript()
	{
	}

	[Token(Token = "0x600371B")]
	[Address(RVA = "0x1C927EC", Offset = "0x1C927EC", VA = "0x1C927EC", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x600371C")]
	[Address(RVA = "0x1C927FC", Offset = "0x1C927FC", VA = "0x1C927FC", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x600371D")]
	[Address(RVA = "0x1C92800", Offset = "0x1C92800", VA = "0x1C92800", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x600371E")]
	[Address(RVA = "0x1C92A80", Offset = "0x1C92A80", VA = "0x1C92A80", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x600371F")]
	[Address(RVA = "0x1C9351C", Offset = "0x1C9351C", VA = "0x1C9351C")]
	public int GetGameObjectTutorialTargetID(string gameObjectName)
	{
		return default(int);
	}
}
