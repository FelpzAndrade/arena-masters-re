using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D76")]
public class XUIFlag : MonoBehaviour
{
	[Token(Token = "0x400456B")]
	[FieldOffset(Offset = "0xC")]
	public UIBasicSprite sprATeamInteractionTime;

	[Token(Token = "0x400456C")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprBTeamInteractionTime;

	[Token(Token = "0x400456D")]
	[FieldOffset(Offset = "0x14")]
	public UIBasicSprite sprNeutralityFlag;

	[Token(Token = "0x400456E")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprATeamFlag;

	[Token(Token = "0x400456F")]
	[FieldOffset(Offset = "0x1C")]
	public UIBasicSprite sprBTeamFlag;

	[Token(Token = "0x4004570")]
	[FieldOffset(Offset = "0x20")]
	public TweenScale tweenScaleLoop;

	[Token(Token = "0x4004571")]
	[FieldOffset(Offset = "0x24")]
	public float targetScale;

	[Token(Token = "0x4004572")]
	[FieldOffset(Offset = "0x28")]
	public UITweener[] aTeamFlagTweens;

	[Token(Token = "0x4004573")]
	[FieldOffset(Offset = "0x2C")]
	public UITweener[] bTeamFlagTweens;

	[Token(Token = "0x60062CB")]
	[Address(RVA = "0x1A44824", Offset = "0x1A44824", VA = "0x1A44824")]
	public XUIFlag()
	{
	}

	[Token(Token = "0x60062CC")]
	[Address(RVA = "0x1A44838", Offset = "0x1A44838", VA = "0x1A44838")]
	private void Awake()
	{
	}

	[Token(Token = "0x60062CD")]
	[Address(RVA = "0x1A4499C", Offset = "0x1A4499C", VA = "0x1A4499C")]
	public void PlayRootScale(bool foward)
	{
	}

	[Token(Token = "0x60062CE")]
	[Address(RVA = "0x1A44AF8", Offset = "0x1A44AF8", VA = "0x1A44AF8")]
	private void PlayTween(UITweener[] tweens)
	{
	}

	[Token(Token = "0x60062CF")]
	[Address(RVA = "0x1A44B84", Offset = "0x1A44B84", VA = "0x1A44B84")]
	private void ResetTween(UITweener[] tweens)
	{
	}

	[Token(Token = "0x60062D0")]
	[Address(RVA = "0x1A44C10", Offset = "0x1A44C10", VA = "0x1A44C10")]
	public void ShowNeutralityFlag()
	{
	}

	[Token(Token = "0x60062D1")]
	[Address(RVA = "0x1A44CA4", Offset = "0x1A44CA4", VA = "0x1A44CA4")]
	public void ShowATeamFlag()
	{
	}

	[Token(Token = "0x60062D2")]
	[Address(RVA = "0x1A44D40", Offset = "0x1A44D40", VA = "0x1A44D40")]
	public void ShowATeamFlagBlink()
	{
	}

	[Token(Token = "0x60062D3")]
	[Address(RVA = "0x1A44DDC", Offset = "0x1A44DDC", VA = "0x1A44DDC")]
	public void ShowBTeamFlag()
	{
	}

	[Token(Token = "0x60062D4")]
	[Address(RVA = "0x1A44E78", Offset = "0x1A44E78", VA = "0x1A44E78")]
	public void ShowBTeamFlagBlink()
	{
	}

	[Token(Token = "0x60062D5")]
	[Address(RVA = "0x1A44F14", Offset = "0x1A44F14", VA = "0x1A44F14")]
	public void ResetOccupationValue()
	{
	}

	[Token(Token = "0x60062D6")]
	[Address(RVA = "0x1A44F60", Offset = "0x1A44F60", VA = "0x1A44F60")]
	public void SetOccupationValue(float value)
	{
	}
}
