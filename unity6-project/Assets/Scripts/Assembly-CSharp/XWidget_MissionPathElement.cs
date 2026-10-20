using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FAC")]
public class XWidget_MissionPathElement : MonoBehaviour
{
	[Token(Token = "0x4005301")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprActive;

	[Token(Token = "0x4005302")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprClear;

	[Token(Token = "0x4005303")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprDisable;

	[Token(Token = "0x4005304")]
	[FieldOffset(Offset = "0x18")]
	public UITweener[] tweenList;

	[Token(Token = "0x4005305")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha tweenStart;

	[Token(Token = "0x4005306")]
	[FieldOffset(Offset = "0x20")]
	public float firstDealy;

	[Token(Token = "0x4005307")]
	[FieldOffset(Offset = "0x24")]
	private bool isActive;

	[Token(Token = "0x60074AB")]
	[Address(RVA = "0x1467638", Offset = "0x1467638", VA = "0x1467638")]
	public XWidget_MissionPathElement()
	{
	}

	[Token(Token = "0x60074AC")]
	[Address(RVA = "0x1467648", Offset = "0x1467648", VA = "0x1467648")]
	private void Reset()
	{
	}

	[Token(Token = "0x60074AD")]
	[Address(RVA = "0x14672DC", Offset = "0x14672DC", VA = "0x14672DC")]
	public void Build(bool isPrevCleared, int bestScore, int index, TweenAlpha nextTween)
	{
	}

	[Token(Token = "0x60074AE")]
	[Address(RVA = "0x1466E2C", Offset = "0x1466E2C", VA = "0x1466E2C")]
	public void StartTween()
	{
	}
}
