using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000257")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	[Token(Token = "0x2000258")]
	public enum Side
	{
		[Token(Token = "0x4000A7C")]
		BottomLeft = 0,
		[Token(Token = "0x4000A7D")]
		Left = 1,
		[Token(Token = "0x4000A7E")]
		TopLeft = 2,
		[Token(Token = "0x4000A7F")]
		Top = 3,
		[Token(Token = "0x4000A80")]
		TopRight = 4,
		[Token(Token = "0x4000A81")]
		Right = 5,
		[Token(Token = "0x4000A82")]
		BottomRight = 6,
		[Token(Token = "0x4000A83")]
		Bottom = 7,
		[Token(Token = "0x4000A84")]
		Center = 8
	}

	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0xC")]
	public Camera uiCamera;

	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x10")]
	public GameObject container;

	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x14")]
	public Side side;

	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x18")]
	public bool runOnlyOnce;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 relativeOffset;

	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 pixelOffset;

	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	[SerializeField]
	private UIWidget widgetContainer;

	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x30")]
	private Transform mTrans;

	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x34")]
	private Animation mAnim;

	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x38")]
	private Rect mRect;

	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x48")]
	private UIRoot mRoot;

	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x4C")]
	private bool mStarted;

	[Token(Token = "0x600144D")]
	[Address(RVA = "0x1D64938", Offset = "0x1D64938", VA = "0x1D64938")]
	public UIAnchor()
	{
	}

	[Token(Token = "0x600144E")]
	[Address(RVA = "0x1D64A54", Offset = "0x1D64A54", VA = "0x1D64A54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600144F")]
	[Address(RVA = "0x1D64C94", Offset = "0x1D64C94", VA = "0x1D64C94")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001450")]
	[Address(RVA = "0x1D64EA8", Offset = "0x1D64EA8", VA = "0x1D64EA8")]
	private void ScreenSizeChanged()
	{
	}

	[Token(Token = "0x6001451")]
	[Address(RVA = "0x1D66050", Offset = "0x1D66050", VA = "0x1D66050")]
	private void Start()
	{
	}

	[Token(Token = "0x6001452")]
	[Address(RVA = "0x1D64EC4", Offset = "0x1D64EC4", VA = "0x1D64EC4")]
	private void Update()
	{
	}
}
