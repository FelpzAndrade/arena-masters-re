using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000649")]
public class FreeRotaionInfo
{
	[Token(Token = "0x4001E3D")]
	[FieldOffset(Offset = "0x8")]
	public int groupId;

	[Token(Token = "0x4001E3E")]
	[FieldOffset(Offset = "0xC")]
	public int rotation_id_1;

	[Token(Token = "0x4001E3F")]
	[FieldOffset(Offset = "0x10")]
	public int rotation_id_2;

	[Token(Token = "0x60035EC")]
	[Address(RVA = "0x1F27B10", Offset = "0x1F27B10", VA = "0x1F27B10")]
	public FreeRotaionInfo()
	{
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x1F27B18", Offset = "0x1F27B18", VA = "0x1F27B18")]
	public bool Cooking()
	{
		return default(bool);
	}
}
