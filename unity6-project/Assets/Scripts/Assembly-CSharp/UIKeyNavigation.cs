using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E0")]
public class UIKeyNavigation : MonoBehaviour
{
	[Token(Token = "0x20001E1")]
	public enum Constraint
	{
		[Token(Token = "0x400076C")]
		None = 0,
		[Token(Token = "0x400076D")]
		Vertical = 1,
		[Token(Token = "0x400076E")]
		Horizontal = 2,
		[Token(Token = "0x400076F")]
		Explicit = 3
	}

	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIKeyNavigation> list;

	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0xC")]
	public Constraint constraint;

	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x10")]
	public GameObject onUp;

	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x14")]
	public GameObject onDown;

	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x18")]
	public GameObject onLeft;

	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject onRight;

	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x20")]
	public GameObject onClick;

	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x24")]
	public GameObject onTab;

	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x28")]
	public bool startsSelected;

	[NonSerialized]
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x29")]
	private bool mStarted;

	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x4")]
	public static int mLastFrame;

	[Token(Token = "0x17000257")]
	public static UIKeyNavigation current
	{
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x16FFE04", Offset = "0x16FFE04", VA = "0x16FFE04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000258")]
	public bool isColliderEnabled
	{
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x16FFF38", Offset = "0x16FFF38", VA = "0x16FFF38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x16C1238", Offset = "0x16C1238", VA = "0x16C1238")]
	public UIKeyNavigation()
	{
	}

	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x16C17EC", Offset = "0x16C17EC", VA = "0x16C17EC", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x17000F4", Offset = "0x17000F4", VA = "0x17000F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x17001CC", Offset = "0x17001CC", VA = "0x17001CC", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x17002B8", Offset = "0x17002B8", VA = "0x17002B8")]
	private static bool IsActive(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0x17004A0", Offset = "0x17004A0", VA = "0x17004A0")]
	public GameObject GetLeft()
	{
		return null;
	}

	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x1700AC0", Offset = "0x1700AC0", VA = "0x1700AC0")]
	public GameObject GetRight()
	{
		return null;
	}

	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x1700BC0", Offset = "0x1700BC0", VA = "0x1700BC0")]
	public GameObject GetUp()
	{
		return null;
	}

	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x1700CC0", Offset = "0x1700CC0", VA = "0x1700CC0")]
	public GameObject GetDown()
	{
		return null;
	}

	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x17005A0", Offset = "0x17005A0", VA = "0x17005A0")]
	public GameObject Get(Vector3 myDir, float x = 1f, float y = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x1700DC0", Offset = "0x1700DC0", VA = "0x1700DC0")]
	protected static Vector3 GetCenter(GameObject go)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x17011BC", Offset = "0x17011BC", VA = "0x17011BC", Slot = "6")]
	public virtual void OnNavigate(KeyCode key)
	{
	}

	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x170142C", Offset = "0x170142C", VA = "0x170142C", Slot = "7")]
	public virtual void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x1701A24", Offset = "0x1701A24", VA = "0x1701A24", Slot = "8")]
	protected virtual void OnClick()
	{
	}
}
