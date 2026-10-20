using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B7")]
public class SpinWithMouse : MonoBehaviour
{
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0xC")]
	public Transform target;

	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x10")]
	public float speed;

	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x14")]
	private Transform mTrans;

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x1D43538", Offset = "0x1D43538", VA = "0x1D43538")]
	public SpinWithMouse()
	{
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x1D43548", Offset = "0x1D43548", VA = "0x1D43548")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x1D43564", Offset = "0x1D43564", VA = "0x1D43564")]
	private void OnDrag(Vector2 delta)
	{
	}
}
