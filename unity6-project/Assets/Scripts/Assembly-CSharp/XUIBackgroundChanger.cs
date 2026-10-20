using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001019")]
public class XUIBackgroundChanger : MonoBehaviour
{
	[Token(Token = "0x4005648")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprBackground;

	[Token(Token = "0x4005649")]
	[FieldOffset(Offset = "0x10")]
	public LobbyBackground curBackgroundType;

	[Token(Token = "0x6007811")]
	[Address(RVA = "0x1A2B1B8", Offset = "0x1A2B1B8", VA = "0x1A2B1B8")]
	public XUIBackgroundChanger()
	{
	}

	[Token(Token = "0x6007812")]
	[Address(RVA = "0x1A2B1C0", Offset = "0x1A2B1C0", VA = "0x1A2B1C0")]
	public void ChangeBackground(LobbyBackground backgroundType)
	{
	}
}
