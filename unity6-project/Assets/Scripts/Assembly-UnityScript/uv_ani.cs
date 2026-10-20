using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000002")]
public class uv_ani : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0xC")]
	public float scrollSpeed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2488E94", Offset = "0x2488E94", VA = "0x2488E94")]
	public uv_ani()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2488EB4", Offset = "0x2488EB4", VA = "0x2488EB4", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2488FB4", Offset = "0x2488FB4", VA = "0x2488FB4", Slot = "5")]
	public virtual void Main()
	{
	}
}
