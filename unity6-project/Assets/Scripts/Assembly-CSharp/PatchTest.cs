using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000013")]
public class PatchTest : MonoBehaviour
{
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0xC")]
	public AssetbundlePatcher patcher;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblMsg;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1B7FAE0", Offset = "0x1B7FAE0", VA = "0x1B7FAE0")]
	public PatchTest()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1B7FAE8", Offset = "0x1B7FAE8", VA = "0x1B7FAE8")]
	public void OnClick_PatchStart()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1B7FC00", Offset = "0x1B7FC00", VA = "0x1B7FC00")]
	private void _003COnClick_PatchStart_003Em__0(string group, int cur, int total, float progress)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1B7FF10", Offset = "0x1B7FF10", VA = "0x1B7FF10")]
	private void _003COnClick_PatchStart_003Em__1(AssetbundlePatcher.Result result)
	{
	}
}
