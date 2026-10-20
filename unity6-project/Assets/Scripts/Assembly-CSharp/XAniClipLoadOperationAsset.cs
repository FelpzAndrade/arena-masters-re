using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000601")]
public class XAniClipLoadOperationAsset : XAniClipLoadOperation
{
	[Token(Token = "0x4001CD1")]
	[FieldOffset(Offset = "0x8")]
	protected AnimationClip m_obj;

	[Token(Token = "0x6003358")]
	[Address(RVA = "0x1EE2ED0", Offset = "0x1EE2ED0", VA = "0x1EE2ED0")]
	public XAniClipLoadOperationAsset(AnimationClip obj)
	{
	}

	[Token(Token = "0x6003359")]
	[Address(RVA = "0x1EE2EF0", Offset = "0x1EE2EF0", VA = "0x1EE2EF0", Slot = "7")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600335A")]
	[Address(RVA = "0x1EE2FA0", Offset = "0x1EE2FA0", VA = "0x1EE2FA0", Slot = "8")]
	public override AnimationClip GetAsset()
	{
		return null;
	}
}
