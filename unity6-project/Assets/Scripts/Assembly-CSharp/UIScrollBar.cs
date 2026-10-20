using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F0")]
[ExecuteInEditMode]
public class UIScrollBar : UISlider
{
	[Token(Token = "0x20001F1")]
	private enum Direction
	{
		[Token(Token = "0x40007F9")]
		Horizontal = 0,
		[Token(Token = "0x40007FA")]
		Vertical = 1,
		[Token(Token = "0x40007FB")]
		Upgraded = 2
	}

	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[SerializeField]
	protected float mSize;

	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x54")]
	[HideInInspector]
	[SerializeField]
	private float mScroll;

	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	private Direction mDir;

	[Token(Token = "0x17000273")]
	public float scrollValue
	{
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x179480C", Offset = "0x179480C", VA = "0x179480C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x1794810", Offset = "0x1794810", VA = "0x1794810")]
		set
		{
		}
	}

	[Token(Token = "0x17000274")]
	public float barSize
	{
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x1794818", Offset = "0x1794818", VA = "0x1794818")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x1794820", Offset = "0x1794820", VA = "0x1794820")]
		set
		{
		}
	}

	[Token(Token = "0x6001075")]
	[Address(RVA = "0x17947DC", Offset = "0x17947DC", VA = "0x17947DC")]
	public UIScrollBar()
	{
	}

	[Token(Token = "0x600107A")]
	[Address(RVA = "0x1794A68", Offset = "0x1794A68", VA = "0x1794A68", Slot = "4")]
	protected override void Upgrade()
	{
	}

	[Token(Token = "0x600107B")]
	[Address(RVA = "0x1794AAC", Offset = "0x1794AAC", VA = "0x1794AAC", Slot = "5")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600107C")]
	[Address(RVA = "0x179589C", Offset = "0x179589C", VA = "0x179589C", Slot = "6")]
	protected override float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x600107D")]
	[Address(RVA = "0x1795C60", Offset = "0x1795C60", VA = "0x1795C60", Slot = "7")]
	public override void ForceUpdate()
	{
	}
}
