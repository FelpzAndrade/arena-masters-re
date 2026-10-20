using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C46")]
public class XWidget_RegionTitleUI : MonoBehaviour
{
	[Token(Token = "0x4003E36")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH;

	[Token(Token = "0x4003E37")]
	[FieldOffset(Offset = "0xC")]
	public UILabel regionLabel;

	[Token(Token = "0x4003E38")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite regionSprite;

	[Token(Token = "0x60058D3")]
	[Address(RVA = "0x133AD78", Offset = "0x133AD78", VA = "0x133AD78")]
	public XWidget_RegionTitleUI()
	{
	}

	[Token(Token = "0x60058D5")]
	[Address(RVA = "0x133AE10", Offset = "0x133AE10", VA = "0x133AE10")]
	public static XWidget_RegionTitleUI Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60058D6")]
	[Address(RVA = "0x133AFB0", Offset = "0x133AFB0", VA = "0x133AFB0")]
	public void SetInfo(ConnectEnum.RegionType region)
	{
	}

	[Token(Token = "0x60058D7")]
	[Address(RVA = "0x133AFE8", Offset = "0x133AFE8", VA = "0x133AFE8")]
	private string GetRegionText(ConnectEnum.RegionType region)
	{
		return null;
	}
}
