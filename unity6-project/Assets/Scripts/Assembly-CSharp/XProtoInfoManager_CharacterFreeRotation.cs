using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200064B")]
public class XProtoInfoManager_CharacterFreeRotation : Dictionary<int, List<int>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4001E41")]
	[FieldOffset(Offset = "0x38")]
	private DateTime StandardTime;

	[Token(Token = "0x60035F0")]
	[Address(RVA = "0x1C861B8", Offset = "0x1C861B8", VA = "0x1C861B8")]
	public XProtoInfoManager_CharacterFreeRotation()
	{
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0x1C87C48", Offset = "0x1C87C48", VA = "0x1C87C48", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x1C87E88", Offset = "0x1C87E88", VA = "0x1C87E88", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60035F3")]
	[Address(RVA = "0x1C87E8C", Offset = "0x1C87E8C", VA = "0x1C87E8C", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F4")]
	[Address(RVA = "0x1C87E9C", Offset = "0x1C87E9C", VA = "0x1C87E9C", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F5")]
	[Address(RVA = "0x1C884F8", Offset = "0x1C884F8", VA = "0x1C884F8")]
	private int GetTodayIndex(DateTime nowLocalTime)
	{
		return default(int);
	}

	[Token(Token = "0x60035F6")]
	[Address(RVA = "0x1C88678", Offset = "0x1C88678", VA = "0x1C88678")]
	public bool IsFreeRotaCharacter(DateTime nowLocalTime, int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0x1C887DC", Offset = "0x1C887DC", VA = "0x1C887DC")]
	public List<int> GetTodayFreeList(DateTime nowLocalTime)
	{
		return null;
	}
}
