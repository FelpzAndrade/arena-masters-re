using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B0")]
public class LookAtTarget : MonoBehaviour
{
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0xC")]
	public int level;

	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x10")]
	public Transform target;

	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x14")]
	public float speed;

	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x18")]
	private Transform mTrans;

	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x135A84C", Offset = "0x135A84C", VA = "0x135A84C")]
	public LookAtTarget()
	{
	}

	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x135A85C", Offset = "0x135A85C", VA = "0x135A85C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x135A878", Offset = "0x135A878", VA = "0x135A878")]
	private void LateUpdate()
	{
	}
}
