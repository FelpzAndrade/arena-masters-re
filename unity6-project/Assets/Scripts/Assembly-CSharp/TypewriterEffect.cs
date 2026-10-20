using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B9")]
public class TypewriterEffect : MonoBehaviour
{
	[Token(Token = "0x20001BA")]
	private struct FadeEntry
	{
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x4")]
		public string text;

		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x8")]
		public float alpha;
	}

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x0")]
	public static TypewriterEffect current;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0xC")]
	public int charsPerSecond;

	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x10")]
	public float fadeInTime;

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x14")]
	public float delayOnPeriod;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x18")]
	public float delayOnNewLine;

	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView scrollView;

	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0x20")]
	public bool keepFullDimensions;

	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0x24")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x28")]
	private UILabel mLabel;

	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x2C")]
	private string mFullText;

	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x30")]
	private int mCurrentOffset;

	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x34")]
	private float mNextChar;

	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x38")]
	private bool mReset;

	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x39")]
	private bool mActive;

	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x3C")]
	private BetterList<FadeEntry> mFade;

	[Token(Token = "0x17000249")]
	public bool isActive
	{
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x1D61574", Offset = "0x1D61574", VA = "0x1D61574")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x1D6142C", Offset = "0x1D6142C", VA = "0x1D6142C")]
	public TypewriterEffect()
	{
	}

	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x1D6157C", Offset = "0x1D6157C", VA = "0x1D6157C")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x1D615AC", Offset = "0x1D615AC", VA = "0x1D615AC")]
	public void Finish()
	{
	}

	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x1D622A8", Offset = "0x1D622A8", VA = "0x1D622A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x1D622B4", Offset = "0x1D622B4", VA = "0x1D622B4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x1D61790", Offset = "0x1D61790", VA = "0x1D61790")]
	private void Update()
	{
	}
}
