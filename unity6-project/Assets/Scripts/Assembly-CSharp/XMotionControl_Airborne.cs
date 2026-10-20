using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200049A")]
public class XMotionControl_Airborne : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x17000650")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0xB9A750", Offset = "0xB9A750", VA = "0xB9A750", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000651")]
	public override string AnimationName
	{
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0xB9A758", Offset = "0xB9A758", VA = "0xB9A758", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0xB9A740", Offset = "0xB9A740", VA = "0xB9A740")]
	public XMotionControl_Airborne()
	{
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0xB9A7D0", Offset = "0xB9A7D0", VA = "0xB9A7D0", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027AA")]
	[Address(RVA = "0xB9ABD8", Offset = "0xB9ABD8", VA = "0xB9ABD8", Slot = "14")]
	public override void Release()
	{
	}
}
