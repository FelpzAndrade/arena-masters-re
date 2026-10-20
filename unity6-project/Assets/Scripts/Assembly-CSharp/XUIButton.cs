using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001066")]
public class XUIButton : UIButtonColor
{
	[Token(Token = "0x400588D")]
	[FieldOffset(Offset = "0x0")]
	private static XUIButton current;

	[Token(Token = "0x400588E")]
	[FieldOffset(Offset = "0x70")]
	public string pressedSprite;

	[Token(Token = "0x400588F")]
	[FieldOffset(Offset = "0x74")]
	public string disabledSprite;

	[Token(Token = "0x4005890")]
	[FieldOffset(Offset = "0x78")]
	public Sprite pressedSprite2D;

	[Token(Token = "0x4005891")]
	[FieldOffset(Offset = "0x7C")]
	public Sprite disabledSprite2D;

	[Token(Token = "0x4005892")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 normalScale;

	[Token(Token = "0x4005893")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 pressedScale;

	[Token(Token = "0x4005894")]
	[FieldOffset(Offset = "0x98")]
	private bool m_isPressed;

	[Token(Token = "0x4005895")]
	[FieldOffset(Offset = "0x9C")]
	private TweenColor m_tween;

	[Token(Token = "0x4005896")]
	[FieldOffset(Offset = "0xA0")]
	private State m_prevState;

	[Token(Token = "0x4005897")]
	[FieldOffset(Offset = "0xA4")]
	public bool pixelSnap;

	[Token(Token = "0x4005898")]
	[FieldOffset(Offset = "0xA8")]
	public List<EventDelegate> onClick;

	[Token(Token = "0x4005899")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject tweenScaleTarget;

	[NonSerialized]
	[Token(Token = "0x400589A")]
	[FieldOffset(Offset = "0xB0")]
	private UISprite mSprite;

	[NonSerialized]
	[Token(Token = "0x400589B")]
	[FieldOffset(Offset = "0xB4")]
	private UI2DSprite mSprite2D;

	[NonSerialized]
	[Token(Token = "0x400589C")]
	[FieldOffset(Offset = "0xB8")]
	private string mNormalSprite;

	[NonSerialized]
	[Token(Token = "0x400589D")]
	[FieldOffset(Offset = "0xBC")]
	private Sprite mNormalSprite2D;

	[NonSerialized]
	[Token(Token = "0x400589E")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 mScale;

	[Token(Token = "0x17000F4F")]
	public override bool isEnabled
	{
		[Token(Token = "0x6007BE8")]
		[Address(RVA = "0x1A2CC9C", Offset = "0x1A2CC9C", VA = "0x1A2CC9C", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007BE9")]
		[Address(RVA = "0x1A2CE40", Offset = "0x1A2CE40", VA = "0x1A2CE40", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000F50")]
	public string normalSprite
	{
		[Token(Token = "0x6007BEA")]
		[Address(RVA = "0x1A2D16C", Offset = "0x1A2D16C", VA = "0x1A2D16C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007BEB")]
		[Address(RVA = "0x1A2D1B8", Offset = "0x1A2D1B8", VA = "0x1A2D1B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000F51")]
	public Sprite normalSprite2D
	{
		[Token(Token = "0x6007BEC")]
		[Address(RVA = "0x1A2D5D4", Offset = "0x1A2D5D4", VA = "0x1A2D5D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007BED")]
		[Address(RVA = "0x1A2D620", Offset = "0x1A2D620", VA = "0x1A2D620")]
		set
		{
		}
	}

	[Token(Token = "0x6007BE7")]
	[Address(RVA = "0x1A2CB70", Offset = "0x1A2CB70", VA = "0x1A2CB70")]
	public XUIButton()
	{
	}

	[Token(Token = "0x6007BEE")]
	[Address(RVA = "0x1A2D9E4", Offset = "0x1A2D9E4", VA = "0x1A2D9E4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6007BEF")]
	[Address(RVA = "0x1A2DC30", Offset = "0x1A2DC30", VA = "0x1A2DC30", Slot = "7")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6007BF0")]
	[Address(RVA = "0x1A2DCD4", Offset = "0x1A2DCD4", VA = "0x1A2DCD4", Slot = "11")]
	protected override void OnDragOver()
	{
	}

	[Token(Token = "0x6007BF1")]
	[Address(RVA = "0x1A2DCD8", Offset = "0x1A2DCD8", VA = "0x1A2DCD8", Slot = "12")]
	protected override void OnDragOut()
	{
	}

	[Token(Token = "0x6007BF2")]
	[Address(RVA = "0x1A2DCDC", Offset = "0x1A2DCDC", VA = "0x1A2DCDC", Slot = "9")]
	protected override void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6007BF3")]
	[Address(RVA = "0x1A2DCE0", Offset = "0x1A2DCE0", VA = "0x1A2DCE0", Slot = "14")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x6007BF4")]
	[Address(RVA = "0x1A2E040", Offset = "0x1A2E040", VA = "0x1A2E040", Slot = "10")]
	protected override void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6007BF5")]
	[Address(RVA = "0x1A2E328", Offset = "0x1A2E328", VA = "0x1A2E328")]
	private void Update()
	{
	}

	[Token(Token = "0x6007BF6")]
	[Address(RVA = "0x1A2E570", Offset = "0x1A2E570", VA = "0x1A2E570", Slot = "13")]
	public override void SetState(State state, bool immediate)
	{
	}

	[Token(Token = "0x6007BF7")]
	[Address(RVA = "0x1A2E898", Offset = "0x1A2E898", VA = "0x1A2E898")]
	private void SetScale(GameObject target, float duration, Vector3 to, UITweener.Method method = UITweener.Method.EaseInOut)
	{
	}

	[Token(Token = "0x6007BF8")]
	[Address(RVA = "0x1A2D3F0", Offset = "0x1A2D3F0", VA = "0x1A2D3F0")]
	protected void SetSprite(string sp)
	{
	}

	[Token(Token = "0x6007BF9")]
	[Address(RVA = "0x1A2D804", Offset = "0x1A2D804", VA = "0x1A2D804")]
	protected void SetSprite(Sprite sp)
	{
	}
}
