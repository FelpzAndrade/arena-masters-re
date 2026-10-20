using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA0")]
public class XWidget_Slide : MonoBehaviour
{
	[Token(Token = "0x2000CA1")]
	public enum SlideState
	{
		[Token(Token = "0x400404C")]
		InCallBack = 0,
		[Token(Token = "0x400404D")]
		In = 1,
		[Token(Token = "0x400404E")]
		SlideIn = 2,
		[Token(Token = "0x400404F")]
		OutCallBack = 3,
		[Token(Token = "0x4004050")]
		Out = 4,
		[Token(Token = "0x4004051")]
		SlideOut = 5
	}

	[Token(Token = "0x4004040")]
	[FieldOffset(Offset = "0xC")]
	private AnimationCurve slideXCurve;

	[Token(Token = "0x4004041")]
	[FieldOffset(Offset = "0x10")]
	private SlideState m_curState;

	[Token(Token = "0x4004042")]
	[FieldOffset(Offset = "0x14")]
	public Transform slideRoot;

	[Token(Token = "0x4004043")]
	[FieldOffset(Offset = "0x18")]
	public float slideStartPos;

	[Token(Token = "0x4004044")]
	[FieldOffset(Offset = "0x1C")]
	public float slideEndPos;

	[Token(Token = "0x4004045")]
	[FieldOffset(Offset = "0x20")]
	public float slideTime;

	[Token(Token = "0x4004046")]
	[FieldOffset(Offset = "0x24")]
	private float m_curTime;

	[Token(Token = "0x4004047")]
	[FieldOffset(Offset = "0x28")]
	public Action OutStartCallBack;

	[Token(Token = "0x4004048")]
	[FieldOffset(Offset = "0x2C")]
	public Action OutCallBack;

	[Token(Token = "0x4004049")]
	[FieldOffset(Offset = "0x30")]
	public Action InStartCallBack;

	[Token(Token = "0x400404A")]
	[FieldOffset(Offset = "0x34")]
	public Action InCallBack;

	[Token(Token = "0x17000CC6")]
	public SlideState CurState
	{
		[Token(Token = "0x6005B28")]
		[Address(RVA = "0x1B0B52C", Offset = "0x1B0B52C", VA = "0x1B0B52C")]
		get
		{
			return default(SlideState);
		}
	}

	[Token(Token = "0x6005B27")]
	[Address(RVA = "0x1B0B51C", Offset = "0x1B0B51C", VA = "0x1B0B51C")]
	public XWidget_Slide()
	{
	}

	[Token(Token = "0x6005B29")]
	[Address(RVA = "0x1B0B534", Offset = "0x1B0B534", VA = "0x1B0B534")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B2A")]
	[Address(RVA = "0x1B0B738", Offset = "0x1B0B738", VA = "0x1B0B738")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005B2B")]
	[Address(RVA = "0x1B0B870", Offset = "0x1B0B870", VA = "0x1B0B870")]
	public void SetSlidePos(float startPos, float endPos)
	{
	}

	[Token(Token = "0x6005B2C")]
	[Address(RVA = "0x1B0B8F4", Offset = "0x1B0B8F4", VA = "0x1B0B8F4")]
	public void SetOutStartCallback(Action outStartCallBack)
	{
	}

	[Token(Token = "0x6005B2D")]
	[Address(RVA = "0x1B0B8FC", Offset = "0x1B0B8FC", VA = "0x1B0B8FC")]
	public void SetOutCallback(Action outCallBack)
	{
	}

	[Token(Token = "0x6005B2E")]
	[Address(RVA = "0x1B0B904", Offset = "0x1B0B904", VA = "0x1B0B904")]
	public void SetInStartCallback(Action inStartCallBack)
	{
	}

	[Token(Token = "0x6005B2F")]
	[Address(RVA = "0x1B0B90C", Offset = "0x1B0B90C", VA = "0x1B0B90C")]
	public void SetInCallback(Action inCallBack)
	{
	}

	[Token(Token = "0x6005B30")]
	[Address(RVA = "0x1B0B85C", Offset = "0x1B0B85C", VA = "0x1B0B85C")]
	public void Build(bool slideIn)
	{
	}

	[Token(Token = "0x6005B31")]
	[Address(RVA = "0x1B0B538", Offset = "0x1B0B538", VA = "0x1B0B538")]
	private void BuildSlideCurve()
	{
	}

	[Token(Token = "0x6005B32")]
	[Address(RVA = "0x1B0B914", Offset = "0x1B0B914", VA = "0x1B0B914")]
	private void Update()
	{
	}

	[Token(Token = "0x6005B33")]
	[Address(RVA = "0x1B0B918", Offset = "0x1B0B918", VA = "0x1B0B918")]
	protected void CheckSlide()
	{
	}

	[Token(Token = "0x6005B34")]
	[Address(RVA = "0x1B0BACC", Offset = "0x1B0BACC", VA = "0x1B0BACC")]
	public bool IsOuting()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B35")]
	[Address(RVA = "0x1B0BAE4", Offset = "0x1B0BAE4", VA = "0x1B0BAE4")]
	public bool IsInning()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B36")]
	[Address(RVA = "0x1B0BAF8", Offset = "0x1B0BAF8", VA = "0x1B0BAF8")]
	public void ToggleSlide()
	{
	}

	[Token(Token = "0x6005B37")]
	[Address(RVA = "0x1B0BB40", Offset = "0x1B0BB40", VA = "0x1B0BB40")]
	public void SlideIn()
	{
	}

	[Token(Token = "0x6005B38")]
	[Address(RVA = "0x1B0BB5C", Offset = "0x1B0BB5C", VA = "0x1B0BB5C")]
	public void SlideOut()
	{
	}
}
