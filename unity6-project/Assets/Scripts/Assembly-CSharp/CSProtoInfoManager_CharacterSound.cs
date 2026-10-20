using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000AAA")]
public class CSProtoInfoManager_CharacterSound : Dictionary<int, Dictionary<int, CSCharacterSoundInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x6004E94")]
	[Address(RVA = "0x21F2AA4", Offset = "0x21F2AA4", VA = "0x21F2AA4")]
	public CSProtoInfoManager_CharacterSound()
	{
	}

	[Token(Token = "0x6004E95")]
	[Address(RVA = "0x21F2B28", Offset = "0x21F2B28", VA = "0x21F2B28", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E96")]
	[Address(RVA = "0x21F2B38", Offset = "0x21F2B38", VA = "0x21F2B38", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6004E97")]
	[Address(RVA = "0x21F2B3C", Offset = "0x21F2B3C", VA = "0x21F2B3C", Slot = "44")]
	public virtual bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E98")]
	[Address(RVA = "0x21F306C", Offset = "0x21F306C", VA = "0x21F306C", Slot = "45")]
	public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}
}
