using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D51")]
public class XWidget_VirtualJoystick : MonoBehaviour
{
	[Token(Token = "0x4004477")]
	[FieldOffset(Offset = "0xC")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x4004478")]
	[FieldOffset(Offset = "0x10")]
	public float stickMargin;

	[Token(Token = "0x4004479")]
	[FieldOffset(Offset = "0x14")]
	public UISprite sprJoystickBackground;

	[Token(Token = "0x400447A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite sprJoystick;

	[Token(Token = "0x400447B")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 m_inputVector;

	[Token(Token = "0x400447C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_isStaticMode;

	[Token(Token = "0x400447D")]
	[FieldOffset(Offset = "0x2C")]
	private float m_nguiScreenX;

	[Token(Token = "0x400447E")]
	[FieldOffset(Offset = "0x30")]
	private float m_nguiScreenY;

	[Token(Token = "0x400447F")]
	[FieldOffset(Offset = "0x34")]
	public Transform staticModeTransform;

	[Token(Token = "0x60061BF")]
	[Address(RVA = "0x1B333B4", Offset = "0x1B333B4", VA = "0x1B333B4")]
	public XWidget_VirtualJoystick()
	{
	}

	[Token(Token = "0x60061C0")]
	[Address(RVA = "0x1B334B0", Offset = "0x1B334B0", VA = "0x1B334B0")]
	public void Init(UIRoot UIRoot, bool isStaticMode)
	{
	}

	[Token(Token = "0x60061C1")]
	[Address(RVA = "0x1B336BC", Offset = "0x1B336BC", VA = "0x1B336BC")]
	public float GetStickSize()
	{
		return default(float);
	}

	[Token(Token = "0x60061C2")]
	[Address(RVA = "0x1B336F4", Offset = "0x1B336F4", VA = "0x1B336F4")]
	public void InputTouchPosition(Vector2 currTouchPosition)
	{
	}

	[Token(Token = "0x60061C3")]
	[Address(RVA = "0x1B3391C", Offset = "0x1B3391C", VA = "0x1B3391C")]
	public void OnPressEvent(bool isDown)
	{
	}

	[Token(Token = "0x60061C4")]
	[Address(RVA = "0x1B33710", Offset = "0x1B33710", VA = "0x1B33710")]
	private void ConversionInputVectorPosition(Vector2 currTouchPosition)
	{
	}

	[Token(Token = "0x60061C5")]
	[Address(RVA = "0x1B33888", Offset = "0x1B33888", VA = "0x1B33888")]
	private void MoveJoystick()
	{
	}

	[Token(Token = "0x60061C6")]
	[Address(RVA = "0x1B33BC8", Offset = "0x1B33BC8", VA = "0x1B33BC8")]
	public void ShowVirtualStick(bool isShow)
	{
	}

	[Token(Token = "0x60061C7")]
	[Address(RVA = "0x1B33C60", Offset = "0x1B33C60", VA = "0x1B33C60")]
	public Vector3 GetStickDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60061C8")]
	[Address(RVA = "0x1B33C74", Offset = "0x1B33C74", VA = "0x1B33C74")]
	public float GetTilt()
	{
		return default(float);
	}
}
