using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000602")]
public class XAniClipLoadOperationAssetAsync : XAniClipLoadOperation
{
	[Token(Token = "0x4001CD2")]
	[FieldOffset(Offset = "0x8")]
	protected XAssetBundleLoadAssetOperation m_obj;

	[Token(Token = "0x600335B")]
	[Address(RVA = "0x1EE2FA8", Offset = "0x1EE2FA8", VA = "0x1EE2FA8")]
	public XAniClipLoadOperationAssetAsync(XAssetBundleLoadAssetOperation obj)
	{
	}

	[Token(Token = "0x600335C")]
	[Address(RVA = "0x1EE2FC8", Offset = "0x1EE2FC8", VA = "0x1EE2FC8", Slot = "7")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600335D")]
	[Address(RVA = "0x1EE2FDC", Offset = "0x1EE2FDC", VA = "0x1EE2FDC", Slot = "8")]
	public override AnimationClip GetAsset()
	{
		return null;
	}
}
