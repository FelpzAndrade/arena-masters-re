using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E5")]
[ExecuteInEditMode]
public class UIPlayTween : MonoBehaviour
{
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x0")]
	public static UIPlayTween current;

	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject tweenTarget;

	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x10")]
	public int tweenGroup;

	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x14")]
	public Trigger trigger;

	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x18")]
	public Direction playDirection;

	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x1C")]
	public bool resetOnPlay;

	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x1D")]
	public bool resetIfDisabled;

	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x20")]
	public EnableCondition ifDisabledOnPlay;

	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x24")]
	public DisableCondition disableWhenFinished;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x28")]
	public bool includeChildren;

	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x2C")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	[SerializeField]
	private string callWhenFinished;

	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x38")]
	private UITweener[] mTweens;

	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x3C")]
	private bool mStarted;

	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x40")]
	private int mActive;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x44")]
	private bool mActivated;

	[Token(Token = "0x6001000")]
	[Address(RVA = "0x17853A4", Offset = "0x17853A4", VA = "0x17853A4")]
	public UIPlayTween()
	{
	}

	[Token(Token = "0x6001001")]
	[Address(RVA = "0x1785458", Offset = "0x1785458", VA = "0x1785458")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001002")]
	[Address(RVA = "0x178556C", Offset = "0x178556C", VA = "0x178556C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001003")]
	[Address(RVA = "0x178563C", Offset = "0x178563C", VA = "0x178563C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001004")]
	[Address(RVA = "0x1785A64", Offset = "0x1785A64", VA = "0x1785A64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001005")]
	[Address(RVA = "0x1785BD0", Offset = "0x1785BD0", VA = "0x1785BD0")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x6001006")]
	[Address(RVA = "0x17859E4", Offset = "0x17859E4", VA = "0x17859E4")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6001007")]
	[Address(RVA = "0x1786140", Offset = "0x1786140", VA = "0x1786140")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x6001008")]
	[Address(RVA = "0x1786184", Offset = "0x1786184", VA = "0x1786184")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6001009")]
	[Address(RVA = "0x1786208", Offset = "0x1786208", VA = "0x1786208")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600100A")]
	[Address(RVA = "0x1786240", Offset = "0x1786240", VA = "0x1786240")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x600100B")]
	[Address(RVA = "0x1786278", Offset = "0x1786278", VA = "0x1786278")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x600100C")]
	[Address(RVA = "0x17862FC", Offset = "0x17862FC", VA = "0x17862FC")]
	private void OnToggle()
	{
	}

	[Token(Token = "0x600100D")]
	[Address(RVA = "0x17865A8", Offset = "0x17865A8", VA = "0x17865A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600100E")]
	[Address(RVA = "0x1785BE4", Offset = "0x1785BE4", VA = "0x1785BE4")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x600100F")]
	[Address(RVA = "0x1786970", Offset = "0x1786970", VA = "0x1786970")]
	private void OnFinished()
	{
	}
}
