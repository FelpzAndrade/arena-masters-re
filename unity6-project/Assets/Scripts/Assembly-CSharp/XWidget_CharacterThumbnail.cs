using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F74")]
public class XWidget_CharacterThumbnail : MonoBehaviour
{
	[Token(Token = "0x400519D")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x400519E")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprCharIcon;

	[Token(Token = "0x400519F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblLevel;

	[Token(Token = "0x6007315")]
	[Address(RVA = "0x15CE660", Offset = "0x15CE660", VA = "0x15CE660")]
	public XWidget_CharacterThumbnail()
	{
	}

	[Token(Token = "0x6007316")]
	[Address(RVA = "0x15CE668", Offset = "0x15CE668", VA = "0x15CE668")]
	public void Build(int charID, int skinID, int lv, int titleID, float alpha = 1f)
	{
	}

	[Token(Token = "0x6007317")]
	[Address(RVA = "0x15CEAD4", Offset = "0x15CEAD4", VA = "0x15CEAD4")]
	public void SetVisible(bool visible)
	{
	}
}
