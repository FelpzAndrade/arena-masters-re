using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20006D0")]
public class XVirtualJoyStickCustom : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[Token(Token = "0x400208B")]
	[FieldOffset(Offset = "0xC")]
	public RectTransform stickObject;

	[Token(Token = "0x400208C")]
	[FieldOffset(Offset = "0x10")]
	public float stickMargin;

	[Token(Token = "0x400208D")]
	[FieldOffset(Offset = "0x14")]
	public Image touchArea;

	[Token(Token = "0x400208E")]
	[FieldOffset(Offset = "0x18")]
	public Image joystickBackground;

	[Token(Token = "0x400208F")]
	[FieldOffset(Offset = "0x1C")]
	public Image joystick;

	[Token(Token = "0x4002090")]
	[FieldOffset(Offset = "0x20")]
	public Image joystickDirection;

	[Token(Token = "0x4002091")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_inputVector;

	[Token(Token = "0x4002092")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isMovable;

	[Token(Token = "0x6003916")]
	[Address(RVA = "0x193BBE8", Offset = "0x193BBE8", VA = "0x193BBE8")]
	public XVirtualJoyStickCustom()
	{
	}

	[Token(Token = "0x6003917")]
	[Address(RVA = "0x193BCE4", Offset = "0x193BCE4", VA = "0x193BCE4")]
	public void Init()
	{
	}

	[Token(Token = "0x6003918")]
	[Address(RVA = "0x193BE28", Offset = "0x193BE28", VA = "0x193BE28")]
	private void SetIsMovableMode()
	{
	}

	[Token(Token = "0x6003919")]
	[Address(RVA = "0x193BEF8", Offset = "0x193BEF8", VA = "0x193BEF8")]
	private void DeleteParent()
	{
	}

	[Token(Token = "0x600391A")]
	[Address(RVA = "0x193C014", Offset = "0x193C014", VA = "0x193C014")]
	private void Start()
	{
	}

	[Token(Token = "0x600391B")]
	[Address(RVA = "0x193C060", Offset = "0x193C060", VA = "0x193C060")]
	public void ShowStick(bool isShow)
	{
	}

	[Token(Token = "0x600391C")]
	[Address(RVA = "0x193C0DC", Offset = "0x193C0DC", VA = "0x193C0DC", Slot = "7")]
	public virtual void OnDrag(PointerEventData pointerEventData)
	{
	}

	[Token(Token = "0x600391D")]
	[Address(RVA = "0x193C348", Offset = "0x193C348", VA = "0x193C348")]
	private void MoveJoyStick()
	{
	}

	[Token(Token = "0x600391E")]
	[Address(RVA = "0x193C46C", Offset = "0x193C46C", VA = "0x193C46C")]
	private void ShowJoystickDirection()
	{
	}

	[Token(Token = "0x600391F")]
	[Address(RVA = "0x193C5BC", Offset = "0x193C5BC", VA = "0x193C5BC", Slot = "8")]
	public virtual void OnPointerDown(PointerEventData pointerEventData)
	{
	}

	[Token(Token = "0x6003920")]
	[Address(RVA = "0x193C8D4", Offset = "0x193C8D4", VA = "0x193C8D4", Slot = "9")]
	public virtual void OnPointerUp(PointerEventData pointerEventData)
	{
	}

	[Token(Token = "0x6003921")]
	[Address(RVA = "0x193C9D8", Offset = "0x193C9D8", VA = "0x193C9D8")]
	public Vector3 GetStickDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003922")]
	[Address(RVA = "0x193C9EC", Offset = "0x193C9EC", VA = "0x193C9EC")]
	public float GetTilt()
	{
		return default(float);
	}
}
