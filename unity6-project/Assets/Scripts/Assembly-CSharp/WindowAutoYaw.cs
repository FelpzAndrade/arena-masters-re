using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001BC")]
public class WindowAutoYaw : MonoBehaviour
{
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0xC")]
	public int updateOrder;

	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x10")]
	public Camera uiCamera;

	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x14")]
	public float yawAmount;

	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x18")]
	private Transform mTrans;

	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x17B3BC8", Offset = "0x17B3BC8", VA = "0x17B3BC8")]
	public WindowAutoYaw()
	{
	}

	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x17B3BDC", Offset = "0x17B3BDC", VA = "0x17B3BDC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x17B3C34", Offset = "0x17B3C34", VA = "0x17B3C34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x17B3D74", Offset = "0x17B3D74", VA = "0x17B3D74")]
	private void Update()
	{
	}
}
