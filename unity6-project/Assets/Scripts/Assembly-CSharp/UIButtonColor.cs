using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C1")]
[ExecuteInEditMode]
public class UIButtonColor : UIWidgetContainer
{
	[Token(Token = "0x20001C2")]
	public enum State
	{
		[Token(Token = "0x4000699")]
		Normal = 0,
		[Token(Token = "0x400069A")]
		Hover = 1,
		[Token(Token = "0x400069B")]
		Pressed = 2,
		[Token(Token = "0x400069C")]
		Disabled = 3
	}

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0xC")]
	public GameObject tweenTarget;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x10")]
	public Color hover;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x20")]
	public Color pressed;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x30")]
	public Color disabledColor;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	[NonSerialized]
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x44")]
	protected Color mStartingColor;

	[NonSerialized]
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x54")]
	protected Color mDefaultColor;

	[NonSerialized]
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x64")]
	protected bool mInitDone;

	[NonSerialized]
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x68")]
	protected UIWidget mWidget;

	[NonSerialized]
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x6C")]
	protected State mState;

	[Token(Token = "0x1700024D")]
	public State state
	{
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x16BFF20", Offset = "0x16BFF20", VA = "0x16BFF20")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x16BFF28", Offset = "0x16BFF28", VA = "0x16BFF28")]
		set
		{
		}
	}

	[Token(Token = "0x1700024E")]
	public Color defaultColor
	{
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x16BFF78", Offset = "0x16BFF78", VA = "0x16BFF78")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x16BFFD0", Offset = "0x16BFFD0", VA = "0x16BFFD0")]
		set
		{
		}
	}

	[Token(Token = "0x1700024F")]
	public virtual bool isEnabled
	{
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x16C0088", Offset = "0x16C0088", VA = "0x16C0088", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x16C0090", Offset = "0x16C0090", VA = "0x16C0090", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x16BDAA8", Offset = "0x16BDAA8", VA = "0x16BDAA8")]
	public UIButtonColor()
	{
	}

	[Token(Token = "0x6000F0C")]
	[Address(RVA = "0x16C0098", Offset = "0x16C0098", VA = "0x16C0098")]
	public void ResetDefaultColor()
	{
	}

	[Token(Token = "0x6000F0D")]
	[Address(RVA = "0x16C00BC", Offset = "0x16C00BC", VA = "0x16C00BC")]
	public void CacheDefaultColor()
	{
	}

	[Token(Token = "0x6000F0E")]
	[Address(RVA = "0x16C010C", Offset = "0x16C010C", VA = "0x16C010C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F0F")]
	[Address(RVA = "0x16BEAD4", Offset = "0x16BEAD4", VA = "0x16BEAD4", Slot = "6")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x16C01C4", Offset = "0x16C01C4", VA = "0x16C01C4", Slot = "7")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000F11")]
	[Address(RVA = "0x16C05B0", Offset = "0x16C05B0", VA = "0x16C05B0", Slot = "8")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x16C0770", Offset = "0x16C0770", VA = "0x16C0770", Slot = "9")]
	protected virtual void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x16C08EC", Offset = "0x16C08EC", VA = "0x16C08EC", Slot = "10")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x16BF4C0", Offset = "0x16BF4C0", VA = "0x16BF4C0", Slot = "11")]
	protected virtual void OnDragOver()
	{
	}

	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x16BF7A0", Offset = "0x16BF7A0", VA = "0x16BF7A0", Slot = "12")]
	protected virtual void OnDragOut()
	{
	}

	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x16BFD88", Offset = "0x16BFD88", VA = "0x16BFD88", Slot = "13")]
	public virtual void SetState(State state, bool instant)
	{
	}

	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x16C0F88", Offset = "0x16C0F88", VA = "0x16C0F88")]
	public void UpdateColor(bool instant)
	{
	}
}
