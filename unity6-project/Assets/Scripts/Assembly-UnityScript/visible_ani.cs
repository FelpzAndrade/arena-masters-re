using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000003")]
public class visible_ani : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0xC")]
	public float duration;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	private int lastTime;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2488FB8", Offset = "0x2488FB8", VA = "0x2488FB8")]
	public visible_ani()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2488FD8", Offset = "0x2488FD8", VA = "0x2488FD8", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2489168", Offset = "0x2489168", VA = "0x2489168", Slot = "5")]
	public virtual void Main()
	{
	}
}
