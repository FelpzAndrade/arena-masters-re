using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001BD")]
public class WindowDragTilt : MonoBehaviour
{
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0xC")]
	public int updateOrder;

	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x10")]
	public float degrees;

	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 mLastPos;

	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x20")]
	private Transform mTrans;

	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x24")]
	private float mAngle;

	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x17B3EE0", Offset = "0x17B3EE0", VA = "0x17B3EE0")]
	public WindowDragTilt()
	{
	}

	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x17B3EF4", Offset = "0x17B3EF4", VA = "0x17B3EF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x17B3F4C", Offset = "0x17B3F4C", VA = "0x17B3F4C")]
	private void Update()
	{
	}
}
