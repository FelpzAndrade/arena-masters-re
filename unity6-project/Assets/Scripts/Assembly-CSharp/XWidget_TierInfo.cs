using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EFD")]
public class XWidget_TierInfo : MonoBehaviour
{
	[Token(Token = "0x4004F6A")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprTierIcon;

	[Token(Token = "0x4004F6B")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblScore;

	[Token(Token = "0x6006FE9")]
	[Address(RVA = "0x1B22CEC", Offset = "0x1B22CEC", VA = "0x1B22CEC")]
	public XWidget_TierInfo()
	{
	}

	[Token(Token = "0x6006FEA")]
	[Address(RVA = "0x1B22CF4", Offset = "0x1B22CF4", VA = "0x1B22CF4")]
	public void Build(string strElo, string tierIconPath, bool silhouette = false)
	{
	}
}
