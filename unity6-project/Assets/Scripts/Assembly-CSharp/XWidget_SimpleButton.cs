using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C9F")]
public class XWidget_SimpleButton : MonoBehaviour
{
	[Token(Token = "0x400403E")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprDisable;

	[Token(Token = "0x400403F")]
	[FieldOffset(Offset = "0x10")]
	private bool m_isDisable;

	[Token(Token = "0x6005B24")]
	[Address(RVA = "0x1B06D90", Offset = "0x1B06D90", VA = "0x1B06D90")]
	public XWidget_SimpleButton()
	{
	}

	[Token(Token = "0x6005B25")]
	[Address(RVA = "0x1B06D98", Offset = "0x1B06D98", VA = "0x1B06D98")]
	public void SetDisable(bool disable)
	{
	}

	[Token(Token = "0x6005B26")]
	[Address(RVA = "0x1B06E8C", Offset = "0x1B06E8C", VA = "0x1B06E8C")]
	public void Show(bool bShow)
	{
	}
}
