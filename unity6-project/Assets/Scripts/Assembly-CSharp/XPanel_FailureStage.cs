using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5B")]
public class XPanel_FailureStage : MonoBehaviour
{
	[Token(Token = "0x40044C6")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprFadeImage;

	[Token(Token = "0x40044C7")]
	[FieldOffset(Offset = "0x10")]
	public float m_fadeDuration;

	[Token(Token = "0x40044C8")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha fadeAlpha;

	[Token(Token = "0x6006202")]
	[Address(RVA = "0x16B7350", Offset = "0x16B7350", VA = "0x16B7350")]
	public XPanel_FailureStage()
	{
	}

	[Token(Token = "0x6006203")]
	[Address(RVA = "0x16B7364", Offset = "0x16B7364", VA = "0x16B7364")]
	public void Show()
	{
	}

	[Token(Token = "0x6006204")]
	[Address(RVA = "0x16B73A4", Offset = "0x16B73A4", VA = "0x16B73A4")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6006205")]
	[Address(RVA = "0x16B7404", Offset = "0x16B7404", VA = "0x16B7404")]
	public void RequestFailureExit()
	{
	}

	[Token(Token = "0x6006206")]
	[Address(RVA = "0x16B74F4", Offset = "0x16B74F4", VA = "0x16B74F4")]
	public void Hide()
	{
	}
}
