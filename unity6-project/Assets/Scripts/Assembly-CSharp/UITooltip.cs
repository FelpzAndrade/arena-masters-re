using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000294")]
public class UITooltip : MonoBehaviour
{
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x0")]
	protected static UITooltip mInstance;

	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0xC")]
	public Camera uiCamera;

	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x10")]
	public UILabel text;

	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0x14")]
	public GameObject tooltipRoot;

	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0x18")]
	public UISprite background;

	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x1C")]
	public float appearSpeed;

	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x20")]
	public bool scalingTransitions;

	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x24")]
	protected GameObject mTooltip;

	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0x28")]
	protected Transform mTrans;

	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x2C")]
	protected float mTarget;

	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x30")]
	protected float mCurrent;

	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x34")]
	protected Vector3 mPos;

	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x40")]
	protected Vector3 mSize;

	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x4C")]
	protected UIWidget[] mWidgets;

	[Token(Token = "0x170003CE")]
	public static bool isVisible
	{
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x17A8910", Offset = "0x17A8910", VA = "0x17A8910")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x17A88B8", Offset = "0x17A88B8", VA = "0x17A88B8")]
	public UITooltip()
	{
	}

	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x17A8A28", Offset = "0x17A8A28", VA = "0x17A8A28")]
	private void Awake()
	{
	}

	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x17A8AAC", Offset = "0x17A8AAC", VA = "0x17A8AAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x17A8B30", Offset = "0x17A8B30", VA = "0x17A8B30", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x17A8CF8", Offset = "0x17A8CF8", VA = "0x17A8CF8", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x17A904C", Offset = "0x17A904C", VA = "0x17A904C", Slot = "6")]
	protected virtual void SetAlpha(float val)
	{
	}

	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x17A90E0", Offset = "0x17A90E0", VA = "0x17A90E0", Slot = "7")]
	protected virtual void SetText(string tooltipText)
	{
	}

	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x17A9A04", Offset = "0x17A9A04", VA = "0x17A9A04")]
	public static void ShowText(string text)
	{
	}

	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x17A9B38", Offset = "0x17A9B38", VA = "0x17A9B38")]
	public static void Show(string text)
	{
	}

	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x17A9C6C", Offset = "0x17A9C6C", VA = "0x17A9C6C")]
	public static void Hide()
	{
	}
}
