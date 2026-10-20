using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D1")]
[ExecuteInEditMode]
public class UIDragObject : MonoBehaviour
{
	[Token(Token = "0x20001D2")]
	public enum DragEffect
	{
		[Token(Token = "0x40006F4")]
		None = 0,
		[Token(Token = "0x40006F5")]
		Momentum = 1,
		[Token(Token = "0x40006F6")]
		MomentumAndSpring = 2
	}

	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0xC")]
	public Transform target;

	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x10")]
	public UIPanel panelRegion;

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 scrollMomentum;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x20")]
	public bool restrictWithinPanel;

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x24")]
	public UIRect contentRect;

	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x28")]
	public DragEffect dragEffect;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x2C")]
	public float momentumAmount;

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected Vector3 scale;

	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	[SerializeField]
	private float scrollWheelFactor;

	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x40")]
	private Plane mPlane;

	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 mTargetPos;

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 mLastPos;

	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 mMomentum;

	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 mScroll;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x80")]
	private Bounds mBounds;

	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x98")]
	private int mTouchID;

	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x9C")]
	private bool mStarted;

	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x9D")]
	private bool mPressed;

	[Token(Token = "0x17000251")]
	public Vector3 dragMovement
	{
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x16E25B4", Offset = "0x16E25B4", VA = "0x16E25B4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x16E25C8", Offset = "0x16E25C8", VA = "0x16E25C8")]
		set
		{
		}
	}

	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x16E24E4", Offset = "0x16E24E4", VA = "0x16E24E4")]
	public UIDragObject()
	{
	}

	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x16E25D4", Offset = "0x16E25D4", VA = "0x16E25D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x16E2858", Offset = "0x16E2858", VA = "0x16E2858")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x16E2864", Offset = "0x16E2864", VA = "0x16E2864")]
	private void FindPanel()
	{
	}

	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x16E29FC", Offset = "0x16E29FC", VA = "0x16E29FC")]
	private void UpdateBounds()
	{
	}

	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x16E2D0C", Offset = "0x16E2D0C", VA = "0x16E2D0C")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x16E3620", Offset = "0x16E3620", VA = "0x16E3620")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x16E3BF8", Offset = "0x16E3BF8", VA = "0x16E3BF8")]
	private void Move(Vector3 worldDelta)
	{
	}

	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x16E428C", Offset = "0x16E428C", VA = "0x16E428C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x16E32A0", Offset = "0x16E32A0", VA = "0x16E32A0")]
	public void CancelMovement()
	{
	}

	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x16E3524", Offset = "0x16E3524", VA = "0x16E3524")]
	public void CancelSpring()
	{
	}

	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x16E45F8", Offset = "0x16E45F8", VA = "0x16E45F8")]
	private void OnScroll(float delta)
	{
	}
}
