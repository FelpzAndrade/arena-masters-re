using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F8B")]
public class XWidget_IconAndDesc : MonoBehaviour
{
	[Token(Token = "0x4005214")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblPrefixDesc;

	[Token(Token = "0x4005215")]
	[FieldOffset(Offset = "0x10")]
	public GameObject selectObject;

	[Token(Token = "0x4005216")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4005217")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblDesc1;

	[Token(Token = "0x4005218")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblDesc2;

	[Token(Token = "0x60073AE")]
	[Address(RVA = "0x143F310", Offset = "0x143F310", VA = "0x143F310")]
	public XWidget_IconAndDesc()
	{
	}

	[Token(Token = "0x60073AF")]
	[Address(RVA = "0x143F318", Offset = "0x143F318", VA = "0x143F318")]
	public void NormalItemBuild(Sprite spr, string desc1, string desc2)
	{
	}

	[Token(Token = "0x60073B0")]
	[Address(RVA = "0x143F600", Offset = "0x143F600", VA = "0x143F600")]
	public void SelectItemBuild(string prefixDesc, Sprite spr, string desc1, string desc2, bool isSelected)
	{
	}
}
