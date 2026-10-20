using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200049C")]
public class XMotionControl_Root : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x17000654")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0xB9C364", Offset = "0xB9C364", VA = "0xB9C364", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000655")]
	public override string AnimationName
	{
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0xB9C36C", Offset = "0xB9C36C", VA = "0xB9C36C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027B0")]
	[Address(RVA = "0xB9C35C", Offset = "0xB9C35C", VA = "0xB9C35C")]
	public XMotionControl_Root()
	{
	}

	[Token(Token = "0x60027B3")]
	[Address(RVA = "0xB9C3A4", Offset = "0xB9C3A4", VA = "0xB9C3A4", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027B4")]
	[Address(RVA = "0xB9C644", Offset = "0xB9C644", VA = "0xB9C644", Slot = "14")]
	public override void Release()
	{
	}
}
