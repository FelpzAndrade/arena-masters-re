using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001040")]
public class XUITierInfo : MonoBehaviour
{
	[Token(Token = "0x4005785")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprTier;

	[Token(Token = "0x4005786")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTierName;

	[Token(Token = "0x4005787")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblTierScore;

	[Token(Token = "0x6007951")]
	[Address(RVA = "0x1938110", Offset = "0x1938110", VA = "0x1938110")]
	public XUITierInfo()
	{
	}

	[Token(Token = "0x6007952")]
	[Address(RVA = "0x1938118", Offset = "0x1938118", VA = "0x1938118")]
	public void Build(string tierIconPath, string tierName, string tierScore)
	{
	}
}
