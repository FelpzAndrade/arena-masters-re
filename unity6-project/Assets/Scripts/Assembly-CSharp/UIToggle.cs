using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FF")]
[ExecuteInEditMode]
public class UIToggle : UIWidgetContainer
{
	[Token(Token = "0x2000200")]
	public delegate bool Validate(bool choice);

	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIToggle> list;

	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x4")]
	public static UIToggle current;

	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0xC")]
	public int group;

	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget activeSprite;

	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0x14")]
	public bool invertSpriteState;

	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x18")]
	public Animation activeAnimation;

	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x1C")]
	public Animator animator;

	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x20")]
	public UITweener tween;

	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x24")]
	public bool startsActive;

	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x25")]
	public bool instantTween;

	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x26")]
	public bool optionCanBeNone;

	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0x28")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x2C")]
	public Validate validator;

	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private UISprite checkSprite;

	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[HideInInspector]
	private Animation checkAnimation;

	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[HideInInspector]
	private string functionName;

	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[SerializeField]
	private bool startsChecked;

	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x41")]
	private bool mIsActive;

	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0x42")]
	private bool mStarted;

	[Token(Token = "0x17000282")]
	public bool value
	{
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x178449C", Offset = "0x178449C", VA = "0x178449C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x17941A8", Offset = "0x17941A8", VA = "0x17941A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000283")]
	public bool isColliderEnabled
	{
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x17A72B8", Offset = "0x17A72B8", VA = "0x17A72B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000284")]
	public bool isChecked
	{
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x17A7434", Offset = "0x17A7434", VA = "0x17A7434")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x17A7454", Offset = "0x17A7454", VA = "0x17A7454")]
		set
		{
		}
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x17A64FC", Offset = "0x17A64FC", VA = "0x17A64FC")]
	public UIToggle()
	{
	}

	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x17A7458", Offset = "0x17A7458", VA = "0x17A7458")]
	public static UIToggle GetActiveToggle(int group)
	{
		return null;
	}

	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x17A7614", Offset = "0x17A7614", VA = "0x17A7614")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x17A7700", Offset = "0x17A7700", VA = "0x17A7700")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x17A77EC", Offset = "0x17A77EC", VA = "0x17A77EC")]
	public void Start()
	{
	}

	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x17A7B54", Offset = "0x17A7B54", VA = "0x17A7B54")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x17A6674", Offset = "0x17A6674", VA = "0x17A6674")]
	public void Set(bool state, bool notify = true)
	{
	}
}
