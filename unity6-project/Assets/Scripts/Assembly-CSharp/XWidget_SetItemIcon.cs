using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C9D")]
public class XWidget_SetItemIcon : MonoBehaviour
{
	[Token(Token = "0x4004038")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprEnableIcon;

	[Token(Token = "0x4004039")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goSprDisable;

	[Token(Token = "0x6005B1D")]
	[Address(RVA = "0x1B03C88", Offset = "0x1B03C88", VA = "0x1B03C88")]
	public XWidget_SetItemIcon()
	{
	}

	[Token(Token = "0x6005B1E")]
	[Address(RVA = "0x1B03C90", Offset = "0x1B03C90", VA = "0x1B03C90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B1F")]
	[Address(RVA = "0x1B03DF4", Offset = "0x1B03DF4", VA = "0x1B03DF4")]
	public void Build(string strEnableSpritePath)
	{
	}

	[Token(Token = "0x6005B20")]
	[Address(RVA = "0x1B03FE0", Offset = "0x1B03FE0", VA = "0x1B03FE0")]
	public void SetActiveIcon(bool active)
	{
	}
}
