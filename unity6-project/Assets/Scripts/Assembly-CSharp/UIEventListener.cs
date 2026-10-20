using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022F")]
public class UIEventListener : MonoBehaviour
{
	[Token(Token = "0x2000230")]
	public delegate void VoidDelegate(GameObject go);

	[Token(Token = "0x2000231")]
	public delegate void BoolDelegate(GameObject go, bool state);

	[Token(Token = "0x2000232")]
	public delegate void FloatDelegate(GameObject go, float delta);

	[Token(Token = "0x2000233")]
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	[Token(Token = "0x2000234")]
	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	[Token(Token = "0x2000235")]
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0xC")]
	public object parameter;

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x10")]
	public VoidDelegate onSubmit;

	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x14")]
	public VoidDelegate onClick;

	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x18")]
	public VoidDelegate onDoubleClick;

	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x1C")]
	public BoolDelegate onHover;

	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x20")]
	public BoolDelegate onPress;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x24")]
	public BoolDelegate onSelect;

	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x28")]
	public FloatDelegate onScroll;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x2C")]
	public VoidDelegate onDragStart;

	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x30")]
	public VectorDelegate onDrag;

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x34")]
	public VoidDelegate onDragOver;

	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x38")]
	public VoidDelegate onDragOut;

	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x3C")]
	public VoidDelegate onDragEnd;

	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x40")]
	public ObjectDelegate onDrop;

	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x44")]
	public KeyCodeDelegate onKey;

	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x48")]
	public BoolDelegate onTooltip;

	[Token(Token = "0x170002CA")]
	private bool isColliderEnabled
	{
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x16EB290", Offset = "0x16EB290", VA = "0x16EB290")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x16EB288", Offset = "0x16EB288", VA = "0x16EB288")]
	public UIEventListener()
	{
	}

	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x16EB40C", Offset = "0x16EB40C", VA = "0x16EB40C")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x16EB4EC", Offset = "0x16EB4EC", VA = "0x16EB4EC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x16EB534", Offset = "0x16EB534", VA = "0x16EB534")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x16EB57C", Offset = "0x16EB57C", VA = "0x16EB57C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x16EB690", Offset = "0x16EB690", VA = "0x16EB690")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x16EB6E0", Offset = "0x16EB6E0", VA = "0x16EB6E0")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x16EB730", Offset = "0x16EB730", VA = "0x16EB730")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x16EB844", Offset = "0x16EB844", VA = "0x16EB844")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x16EB874", Offset = "0x16EB874", VA = "0x16EB874")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x16EB99C", Offset = "0x16EB99C", VA = "0x16EB99C")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x16EB9E4", Offset = "0x16EB9E4", VA = "0x16EB9E4")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x16EBA2C", Offset = "0x16EBA2C", VA = "0x16EBA2C")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x16EBA5C", Offset = "0x16EBA5C", VA = "0x16EBA5C")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x16EBB70", Offset = "0x16EBB70", VA = "0x16EBB70")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x16EBC84", Offset = "0x16EBC84", VA = "0x16EBC84")]
	private void OnTooltip(bool show)
	{
	}

	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x16EBCD4", Offset = "0x16EBCD4", VA = "0x16EBCD4")]
	public static UIEventListener Get(GameObject go)
	{
		return null;
	}
}
