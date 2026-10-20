using System;
using CS;
using DG.Tweening;
using Il2CppDummyDll;

[Token(Token = "0x200049F")]
public class XMotionControl_Throw : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x3C")]
	private new Sequence m_doTweenSeq;

	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x40")]
	private float m_horizontalSpeed;

	[Token(Token = "0x1700065A")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0xB9D2BC", Offset = "0xB9D2BC", VA = "0xB9D2BC", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x1700065B")]
	public override string AnimationName
	{
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0xB9D2C4", Offset = "0xB9D2C4", VA = "0xB9D2C4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027C2")]
	[Address(RVA = "0xB9D2B4", Offset = "0xB9D2B4", VA = "0xB9D2B4")]
	public XMotionControl_Throw()
	{
	}

	[Token(Token = "0x60027C5")]
	[Address(RVA = "0xB9D33C", Offset = "0xB9D33C", VA = "0xB9D33C", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027C6")]
	[Address(RVA = "0xB9D6B0", Offset = "0xB9D6B0", VA = "0xB9D6B0", Slot = "12")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60027C7")]
	[Address(RVA = "0xB9D784", Offset = "0xB9D784", VA = "0xB9D784", Slot = "14")]
	public override void Release()
	{
	}
}
