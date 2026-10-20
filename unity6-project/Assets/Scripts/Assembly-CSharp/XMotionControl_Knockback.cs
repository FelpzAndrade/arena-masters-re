using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000497")]
public class XMotionControl_Knockback : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x3C")]
	private float m_knockBackSpeed;

	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x40")]
	private float m_normalizedElapsed;

	[Token(Token = "0x1700064A")]
	public override MotionControlType Type
	{
		[Token(Token = "0x6002796")]
		[Address(RVA = "0xB9B3E8", Offset = "0xB9B3E8", VA = "0xB9B3E8", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x1700064B")]
	public override string AnimationName
	{
		[Token(Token = "0x6002797")]
		[Address(RVA = "0xB9B3F0", Offset = "0xB9B3F0", VA = "0xB9B3F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0xB9B3E0", Offset = "0xB9B3E0", VA = "0xB9B3E0")]
	public XMotionControl_Knockback()
	{
	}

	[Token(Token = "0x6002798")]
	[Address(RVA = "0xB9B468", Offset = "0xB9B468", VA = "0xB9B468", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002799")]
	[Address(RVA = "0xB9B6B0", Offset = "0xB9B6B0", VA = "0xB9B6B0", Slot = "12")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x600279A")]
	[Address(RVA = "0xB9B808", Offset = "0xB9B808", VA = "0xB9B808", Slot = "14")]
	public override void Release()
	{
	}
}
