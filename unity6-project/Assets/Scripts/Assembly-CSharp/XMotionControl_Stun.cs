using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000499")]
public class XMotionControl_Stun : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x1700064E")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0xB9CECC", Offset = "0xB9CECC", VA = "0xB9CECC", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x1700064F")]
	public override string AnimationName
	{
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0xB9CED4", Offset = "0xB9CED4", VA = "0xB9CED4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027A1")]
	[Address(RVA = "0xB9CEC4", Offset = "0xB9CEC4", VA = "0xB9CEC4")]
	public XMotionControl_Stun()
	{
	}

	[Token(Token = "0x60027A4")]
	[Address(RVA = "0xB9CF4C", Offset = "0xB9CF4C", VA = "0xB9CF4C", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0xB9D1EC", Offset = "0xB9D1EC", VA = "0xB9D1EC", Slot = "14")]
	public override void Release()
	{
	}
}
