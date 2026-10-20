using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5A")]
public class XPanel_FailureFadeOut : MonoBehaviour
{
	[Token(Token = "0x40044C3")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprFadeImage;

	[Token(Token = "0x40044C4")]
	[FieldOffset(Offset = "0x10")]
	public float m_fadeDuration;

	[Token(Token = "0x40044C5")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha fadeAlpha;

	[Token(Token = "0x60061FD")]
	[Address(RVA = "0x16B7178", Offset = "0x16B7178", VA = "0x16B7178")]
	public XPanel_FailureFadeOut()
	{
	}

	[Token(Token = "0x60061FE")]
	[Address(RVA = "0x16B718C", Offset = "0x16B718C", VA = "0x16B718C")]
	public void Show()
	{
	}

	[Token(Token = "0x60061FF")]
	[Address(RVA = "0x16B71CC", Offset = "0x16B71CC", VA = "0x16B71CC")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6006200")]
	[Address(RVA = "0x16B722C", Offset = "0x16B722C", VA = "0x16B722C")]
	public void RequestFailureExit()
	{
	}

	[Token(Token = "0x6006201")]
	[Address(RVA = "0x16B731C", Offset = "0x16B731C", VA = "0x16B731C")]
	public void Hide()
	{
	}
}
