using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200028E")]
[ExecuteInEditMode]
public class UIStretch : MonoBehaviour
{
	[Token(Token = "0x200028F")]
	public enum Style
	{
		[Token(Token = "0x4000C37")]
		None = 0,
		[Token(Token = "0x4000C38")]
		Horizontal = 1,
		[Token(Token = "0x4000C39")]
		Vertical = 2,
		[Token(Token = "0x4000C3A")]
		Both = 3,
		[Token(Token = "0x4000C3B")]
		BasedOnHeight = 4,
		[Token(Token = "0x4000C3C")]
		FillKeepingRatio = 5,
		[Token(Token = "0x4000C3D")]
		FitInternalKeepingRatio = 6
	}

	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0xC")]
	public Camera uiCamera;

	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x10")]
	public GameObject container;

	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x14")]
	public Style style;

	[Token(Token = "0x4000C29")]
	[FieldOffset(Offset = "0x18")]
	public bool runOnlyOnce;

	[Token(Token = "0x4000C2A")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 relativeSize;

	[Token(Token = "0x4000C2B")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 initialSize;

	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 borderPadding;

	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[HideInInspector]
	private UIWidget widgetContainer;

	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x3C")]
	private UIWidget mWidget;

	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x40")]
	private UISprite mSprite;

	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x44")]
	private UIPanel mPanel;

	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x48")]
	private UIRoot mRoot;

	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x4C")]
	private Animation mAnim;

	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x50")]
	private Rect mRect;

	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x60")]
	private bool mStarted;

	[Token(Token = "0x600167F")]
	[Address(RVA = "0x17A0288", Offset = "0x17A0288", VA = "0x17A0288")]
	public UIStretch()
	{
	}

	[Token(Token = "0x6001680")]
	[Address(RVA = "0x17A02FC", Offset = "0x17A02FC", VA = "0x17A02FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001681")]
	[Address(RVA = "0x17A05F8", Offset = "0x17A05F8", VA = "0x17A05F8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001682")]
	[Address(RVA = "0x17A080C", Offset = "0x17A080C", VA = "0x17A080C")]
	private void ScreenSizeChanged()
	{
	}

	[Token(Token = "0x6001683")]
	[Address(RVA = "0x17A172C", Offset = "0x17A172C", VA = "0x17A172C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001684")]
	[Address(RVA = "0x17A0828", Offset = "0x17A0828", VA = "0x17A0828")]
	private void Update()
	{
	}
}
