using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000498")]
public class XMotionControl_Throwup : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x4001713")]
	[FieldOffset(Offset = "0x3C")]
	private float m_horizontalSpeed;

	[Token(Token = "0x1700064C")]
	public override MotionControlType Type
	{
		[Token(Token = "0x600279C")]
		[Address(RVA = "0xB9D854", Offset = "0xB9D854", VA = "0xB9D854", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x1700064D")]
	public override string AnimationName
	{
		[Token(Token = "0x600279D")]
		[Address(RVA = "0xB9D85C", Offset = "0xB9D85C", VA = "0xB9D85C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600279B")]
	[Address(RVA = "0xB9D84C", Offset = "0xB9D84C", VA = "0xB9D84C")]
	public XMotionControl_Throwup()
	{
	}

	[Token(Token = "0x600279E")]
	[Address(RVA = "0xB9D8D4", Offset = "0xB9D8D4", VA = "0xB9D8D4", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0xB9DC60", Offset = "0xB9DC60", VA = "0xB9DC60", Slot = "12")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A0")]
	[Address(RVA = "0xB9DD34", Offset = "0xB9DD34", VA = "0xB9DD34", Slot = "14")]
	public override void Release()
	{
	}
}
