using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D5")]
public class UIDraggableCamera : MonoBehaviour
{
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0xC")]
	public Transform rootForBounds;

	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 scale;

	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x18")]
	public float scrollWheelFactor;

	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragObject.DragEffect dragEffect;

	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x20")]
	public bool smoothDragStart;

	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x24")]
	public float momentumAmount;

	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x28")]
	private Camera mCam;

	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x2C")]
	private Transform mTrans;

	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x30")]
	private bool mPressed;

	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 mMomentum;

	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x3C")]
	private Bounds mBounds;

	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x54")]
	private float mScroll;

	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x58")]
	private UIRoot mRoot;

	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x5C")]
	private bool mDragStarted;

	[Token(Token = "0x17000252")]
	public Vector2 currentMomentum
	{
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x16E1838", Offset = "0x16E1838", VA = "0x16E1838")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x16E184C", Offset = "0x16E184C", VA = "0x16E184C")]
		set
		{
		}
	}

	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x16E17C0", Offset = "0x16E17C0", VA = "0x16E17C0")]
	public UIDraggableCamera()
	{
	}

	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x16E1858", Offset = "0x16E1858", VA = "0x16E1858")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x16E1AB0", Offset = "0x16E1AB0", VA = "0x16E1AB0")]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x16E1F04", Offset = "0x16E1F04", VA = "0x16E1F04")]
	public bool ConstrainToBounds(bool immediate)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x16DEB04", Offset = "0x16DEB04", VA = "0x16DEB04")]
	public void Press(bool isPressed)
	{
	}

	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x16DEE3C", Offset = "0x16DEE3C", VA = "0x16DEE3C")]
	public void Drag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x16DF2A4", Offset = "0x16DF2A4", VA = "0x16DF2A4")]
	public void Scroll(float delta)
	{
	}

	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x16E217C", Offset = "0x16E217C", VA = "0x16E217C")]
	private void Update()
	{
	}
}
