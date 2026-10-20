using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C7E")]
public class XWidget_GachaEffect : MonoBehaviour
{
	[Token(Token = "0x4003F72")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprBox;

	[Token(Token = "0x4003F73")]
	[FieldOffset(Offset = "0x10")]
	public string SoundKey;

	[Token(Token = "0x4003F74")]
	[FieldOffset(Offset = "0x14")]
	public float soundDelay;

	[Token(Token = "0x6005A2B")]
	[Address(RVA = "0x1436950", Offset = "0x1436950", VA = "0x1436950")]
	public XWidget_GachaEffect()
	{
	}

	[Token(Token = "0x6005A2C")]
	[Address(RVA = "0x1433AC0", Offset = "0x1433AC0", VA = "0x1433AC0")]
	public void PlaySoundDelayed()
	{
	}

	[Token(Token = "0x6005A2D")]
	[Address(RVA = "0x14369E8", Offset = "0x14369E8", VA = "0x14369E8")]
	private void PlaySound()
	{
	}
}
