using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000496")]
public class XMotionControl_Beaten : XMotionControlBase
{
	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x3C")]
	private float m_knockBackSpeed;

	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x40")]
	private float m_normalizedElapsed;

	[Token(Token = "0x17000645")]
	public override MotionControlType Type
	{
		[Token(Token = "0x600278D")]
		[Address(RVA = "0xB9ACDC", Offset = "0xB9ACDC", VA = "0xB9ACDC", Slot = "10")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000646")]
	public override string AnimationName
	{
		[Token(Token = "0x600278E")]
		[Address(RVA = "0xB9ACE4", Offset = "0xB9ACE4", VA = "0xB9ACE4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000647")]
	public override float? AnimationLenthModifier
	{
		[Token(Token = "0x600278F")]
		[Address(RVA = "0xB9AD5C", Offset = "0xB9AD5C", VA = "0xB9AD5C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000648")]
	public override float AnimationStartFadeTime
	{
		[Token(Token = "0x6002790")]
		[Address(RVA = "0xB9ADF0", Offset = "0xB9ADF0", VA = "0xB9ADF0", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000649")]
	public override float AnimationEndFadeTime
	{
		[Token(Token = "0x6002791")]
		[Address(RVA = "0xB9AE1C", Offset = "0xB9AE1C", VA = "0xB9AE1C", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600278C")]
	[Address(RVA = "0xB9ACD4", Offset = "0xB9ACD4", VA = "0xB9ACD4")]
	public XMotionControl_Beaten()
	{
	}

	[Token(Token = "0x6002792")]
	[Address(RVA = "0xB9AE48", Offset = "0xB9AE48", VA = "0xB9AE48", Slot = "13")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0xB9B178", Offset = "0xB9B178", VA = "0xB9B178", Slot = "12")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002794")]
	[Address(RVA = "0xB9B318", Offset = "0xB9B318", VA = "0xB9B318", Slot = "14")]
	public override void Release()
	{
	}
}
