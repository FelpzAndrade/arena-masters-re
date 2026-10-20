using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D1F")]
public class XPanel_VirtualJoystick : MonoBehaviour, IVirtualStick
{
	[Token(Token = "0x4004333")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_VirtualJoystick widget_VirtualJoystick;

	[Token(Token = "0x4004334")]
	[FieldOffset(Offset = "0x10")]
	private BoxCollider m_boxCollider;

	[Token(Token = "0x6006025")]
	[Address(RVA = "0xAD9C90", Offset = "0xAD9C90", VA = "0xAD9C90")]
	public XPanel_VirtualJoystick()
	{
	}

	[Token(Token = "0x6006026")]
	[Address(RVA = "0xAD9C98", Offset = "0xAD9C98", VA = "0xAD9C98")]
	public void Init(bool isStaticMode)
	{
	}

	[Token(Token = "0x6006027")]
	[Address(RVA = "0xAD9DD0", Offset = "0xAD9DD0", VA = "0xAD9DD0")]
	private void OnPress(bool isDown)
	{
	}

	[Token(Token = "0x6006028")]
	[Address(RVA = "0xAD9DFC", Offset = "0xAD9DFC", VA = "0xAD9DFC")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6006029")]
	[Address(RVA = "0xAD9EDC", Offset = "0xAD9EDC", VA = "0xAD9EDC")]
	public void ShowVirtualStick(bool isShow)
	{
	}

	[Token(Token = "0x600602A")]
	[Address(RVA = "0xAD9FD4", Offset = "0xAD9FD4", VA = "0xAD9FD4", Slot = "4")]
	public Vector3 GetStickDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600602B")]
	[Address(RVA = "0xADA000", Offset = "0xADA000", VA = "0xADA000", Slot = "5")]
	public float GetTilt()
	{
		return default(float);
	}

	[Token(Token = "0x600602C")]
	[Address(RVA = "0xADA02C", Offset = "0xADA02C", VA = "0xADA02C")]
	public float GetStickSize()
	{
		return default(float);
	}

	[Token(Token = "0x600602D")]
	[Address(RVA = "0xADA058", Offset = "0xADA058", VA = "0xADA058")]
	public Vector3 GetStickPosition()
	{
		return default(Vector3);
	}
}
