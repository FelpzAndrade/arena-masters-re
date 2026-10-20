using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200049B")]
public class XMotionControl_Paralysis : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x17000652")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0xB9B8D8", Offset = "0xB9B8D8", VA = "0xB9B8D8", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000653")]
	public override string AnimationName
	{
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0xB9B8E0", Offset = "0xB9B8E0", VA = "0xB9B8E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027AB")]
	[Address(RVA = "0xB9B8D0", Offset = "0xB9B8D0", VA = "0xB9B8D0")]
	public XMotionControl_Paralysis()
	{
	}

	[Token(Token = "0x60027AE")]
	[Address(RVA = "0xB9B958", Offset = "0xB9B958", VA = "0xB9B958", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027AF")]
	[Address(RVA = "0xB9BBF8", Offset = "0xB9BBF8", VA = "0xB9BBF8", Slot = "14")]
	public override void Release()
	{
	}
}
