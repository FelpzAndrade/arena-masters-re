using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000252")]
public abstract class UITweener : MonoBehaviour
{
	[Token(Token = "0x2000253")]
	public enum Method
	{
		[Token(Token = "0x4000A55")]
		Linear = 0,
		[Token(Token = "0x4000A56")]
		EaseIn = 1,
		[Token(Token = "0x4000A57")]
		EaseOut = 2,
		[Token(Token = "0x4000A58")]
		EaseInOut = 3,
		[Token(Token = "0x4000A59")]
		BounceIn = 4,
		[Token(Token = "0x4000A5A")]
		BounceOut = 5
	}

	[Token(Token = "0x2000254")]
	public enum Style
	{
		[Token(Token = "0x4000A5C")]
		Once = 0,
		[Token(Token = "0x4000A5D")]
		Loop = 1,
		[Token(Token = "0x4000A5E")]
		PingPong = 2
	}

	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x0")]
	public static UITweener current;

	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public Method method;

	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public Style style;

	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public float delay;

	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public float duration;

	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool steeperCurves;

	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public int tweenGroup;

	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GameObject eventReceiver;

	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public string callWhenFinished;

	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x3C")]
	private float mStartTime;

	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x40")]
	private float mDuration;

	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x44")]
	private float mAmountPerDelta;

	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x48")]
	private float mFactor;

	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x4C")]
	private List<EventDelegate> mTemp;

	[Token(Token = "0x17000313")]
	public float amountPerDelta
	{
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x17A9F68", Offset = "0x17A9F68", VA = "0x17A9F68")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000314")]
	public float tweenFactor
	{
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x17AA06C", Offset = "0x17AA06C", VA = "0x17AA06C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x17A7CD0", Offset = "0x17A7CD0", VA = "0x17A7CD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000315")]
	public Direction direction
	{
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x1786730", Offset = "0x1786730", VA = "0x1786730")]
		get
		{
			return default(Direction);
		}
	}

	[Token(Token = "0x6001418")]
	[Address(RVA = "0x17A9D90", Offset = "0x17A9D90", VA = "0x17A9D90")]
	protected UITweener()
	{
	}

	[Token(Token = "0x600141D")]
	[Address(RVA = "0x17AA074", Offset = "0x17AA074", VA = "0x17AA074")]
	private void Reset()
	{
	}

	[Token(Token = "0x600141E")]
	[Address(RVA = "0x17AA0F0", Offset = "0x17AA0F0", VA = "0x17AA0F0", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600141F")]
	[Address(RVA = "0x17AA0F4", Offset = "0x17AA0F4", VA = "0x17AA0F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001420")]
	[Address(RVA = "0x17AAA3C", Offset = "0x17AAA3C", VA = "0x17AAA3C")]
	public void SetOnFinished(EventDelegate.Callback del)
	{
	}

	[Token(Token = "0x6001421")]
	[Address(RVA = "0x17AAAF0", Offset = "0x17AAAF0", VA = "0x17AAAF0")]
	public void SetOnFinished(EventDelegate del)
	{
	}

	[Token(Token = "0x6001422")]
	[Address(RVA = "0x17AABA4", Offset = "0x17AABA4", VA = "0x17AABA4")]
	public void AddOnFinished(EventDelegate.Callback del)
	{
	}

	[Token(Token = "0x6001423")]
	[Address(RVA = "0x17AAC58", Offset = "0x17AAC58", VA = "0x17AAC58")]
	public void AddOnFinished(EventDelegate del)
	{
	}

	[Token(Token = "0x6001424")]
	[Address(RVA = "0x17AAD0C", Offset = "0x17AAD0C", VA = "0x17AAD0C")]
	public void RemoveOnFinished(EventDelegate del)
	{
	}

	[Token(Token = "0x6001425")]
	[Address(RVA = "0x17AADCC", Offset = "0x17AADCC", VA = "0x17AADCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001426")]
	[Address(RVA = "0x17AA734", Offset = "0x17AA734", VA = "0x17AA734")]
	public void Sample(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6001427")]
	[Address(RVA = "0x17AADD8", Offset = "0x17AADD8", VA = "0x17AADD8")]
	private float BounceLogic(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6001428")]
	[Address(RVA = "0x17AAE9C", Offset = "0x17AAE9C", VA = "0x17AAE9C")]
	public void Play()
	{
	}

	[Token(Token = "0x6001429")]
	[Address(RVA = "0x17AAEA4", Offset = "0x17AAEA4", VA = "0x17AAEA4")]
	public void PlayForward()
	{
	}

	[Token(Token = "0x600142A")]
	[Address(RVA = "0x17AAEAC", Offset = "0x17AAEAC", VA = "0x17AAEAC")]
	public void PlayReverse()
	{
	}

	[Token(Token = "0x600142B")]
	[Address(RVA = "0x1786830", Offset = "0x1786830", VA = "0x1786830")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x600142C")]
	[Address(RVA = "0x178690C", Offset = "0x178690C", VA = "0x178690C")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x600142D")]
	[Address(RVA = "0x17AAEB4", Offset = "0x17AAEB4", VA = "0x17AAEB4")]
	public void CustomResetToBeginning()
	{
	}

	[Token(Token = "0x600142E")]
	[Address(RVA = "0x1786754", Offset = "0x1786754", VA = "0x1786754")]
	public void Toggle()
	{
	}

	[Token(Token = "0x600142F")]
	protected abstract void OnUpdate(float factor, bool isFinished);

	[Token(Token = "0x6001430")]
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return null;
	}

	[Token(Token = "0x6001431")]
	[Address(RVA = "0x17AAFF8", Offset = "0x17AAFF8", VA = "0x17AAFF8", Slot = "6")]
	public virtual void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0x17AAFFC", Offset = "0x17AAFFC", VA = "0x17AAFFC", Slot = "7")]
	public virtual void SetEndToCurrentValue()
	{
	}
}
