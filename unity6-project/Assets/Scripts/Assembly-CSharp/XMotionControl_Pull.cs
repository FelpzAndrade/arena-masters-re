using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200049D")]
public class XMotionControl_Pull : XMotionControlBase, IDisposable, CSPoolEntry
{
	[Token(Token = "0x4001714")]
	[FieldOffset(Offset = "0x3C")]
	public float m_pullDuration;

	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x40")]
	public int m_phase;

	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x44")]
	private Action m_onBounce;

	[Token(Token = "0x17000656")]
	public override MotionControlType Type
	{
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0xB9BCC8", Offset = "0xB9BCC8", VA = "0xB9BCC8", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000657")]
	public override string AnimationName
	{
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0xB9BCD0", Offset = "0xB9BCD0", VA = "0xB9BCD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0xB9BCC0", Offset = "0xB9BCC0", VA = "0xB9BCC0")]
	public XMotionControl_Pull()
	{
	}

	[Token(Token = "0x60027B8")]
	[Address(RVA = "0xB4CAE4", Offset = "0xB4CAE4", VA = "0xB4CAE4")]
	public void OnBounceStart(Action onBounce)
	{
	}

	[Token(Token = "0x60027B9")]
	[Address(RVA = "0xB9BD48", Offset = "0xB9BD48", VA = "0xB9BD48", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60027BA")]
	[Address(RVA = "0xB9C058", Offset = "0xB9C058", VA = "0xB9C058", Slot = "12")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60027BB")]
	[Address(RVA = "0xB9C294", Offset = "0xB9C294", VA = "0xB9C294", Slot = "14")]
	public override void Release()
	{
	}
}
