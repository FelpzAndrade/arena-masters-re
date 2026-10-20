using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F8")]
[ExecuteInEditMode]
public class UISlider : UIProgressBar
{
	[Token(Token = "0x20001F9")]
	private enum Direction
	{
		[Token(Token = "0x4000838")]
		Horizontal = 0,
		[Token(Token = "0x4000839")]
		Vertical = 1,
		[Token(Token = "0x400083A")]
		Upgraded = 2
	}

	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private Transform foreground;

	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	[SerializeField]
	private float rawValue;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private Direction direction;

	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[HideInInspector]
	protected bool mInverted;

	[Token(Token = "0x1700027E")]
	public bool isColliderEnabled
	{
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x179B858", Offset = "0x179B858", VA = "0x179B858")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027F")]
	public float sliderValue
	{
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x179B9D4", Offset = "0x179B9D4", VA = "0x179B9D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x179B9D8", Offset = "0x179B9D8", VA = "0x179B9D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000280")]
	public bool inverted
	{
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x179B9E0", Offset = "0x179B9E0", VA = "0x179B9E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x179B9F4", Offset = "0x179B9F4", VA = "0x179B9F4")]
		set
		{
		}
	}

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x17947F8", Offset = "0x17947F8", VA = "0x17947F8")]
	public UISlider()
	{
	}

	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x179B9F8", Offset = "0x179B9F8", VA = "0x179B9F8", Slot = "4")]
	protected override void Upgrade()
	{
	}

	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x1794FAC", Offset = "0x1794FAC", VA = "0x1794FAC", Slot = "5")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x179BB30", Offset = "0x179BB30", VA = "0x179BB30")]
	protected void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x179BC7C", Offset = "0x179BC7C", VA = "0x179BC7C")]
	protected void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x179BDAC", Offset = "0x179BDAC", VA = "0x179BDAC")]
	protected void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x179BFC4", Offset = "0x179BFC4", VA = "0x179BFC4")]
	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x179C108", Offset = "0x179C108", VA = "0x179C108", Slot = "8")]
	public override void OnPan(Vector2 delta)
	{
	}
}
