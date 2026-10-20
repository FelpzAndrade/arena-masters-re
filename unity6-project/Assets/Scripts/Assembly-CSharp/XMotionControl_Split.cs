using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200049E")]
public class XMotionControl_Split : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 splitDirection;

	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x48")]
	private float m_horizontalSpeed;

	[Token(Token = "0x17000658")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0xB9C714", Offset = "0xB9C714", VA = "0xB9C714", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000659")]
	public override string AnimationName
	{
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0xB9C71C", Offset = "0xB9C71C", VA = "0xB9C71C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027BC")]
	[Address(RVA = "0xB9C70C", Offset = "0xB9C70C", VA = "0xB9C70C")]
	public XMotionControl_Split()
	{
	}

	[Token(Token = "0x60027BF")]
	[Address(RVA = "0xB9C794", Offset = "0xB9C794", VA = "0xB9C794", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027C0")]
	[Address(RVA = "0xB9CD1C", Offset = "0xB9CD1C", VA = "0xB9CD1C", Slot = "12")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60027C1")]
	[Address(RVA = "0xB9CDFC", Offset = "0xB9CDFC", VA = "0xB9CDFC", Slot = "14")]
	public override void Release()
	{
	}
}
