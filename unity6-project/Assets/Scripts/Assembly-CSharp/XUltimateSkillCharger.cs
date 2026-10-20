using Il2CppDummyDll;

[Token(Token = "0x2000BAE")]
public class XUltimateSkillCharger
{
	[Token(Token = "0x4003B5D")]
	[FieldOffset(Offset = "0x8")]
	private float m_maxUltimateDamageConvRatio;

	[Token(Token = "0x4003B5E")]
	[FieldOffset(Offset = "0xC")]
	private float m_modifier;

	[Token(Token = "0x4003B5F")]
	[FieldOffset(Offset = "0x10")]
	private float m_maxChargeDefault;

	[Token(Token = "0x4003B60")]
	[FieldOffset(Offset = "0x14")]
	private float m_ultimateMaxChargeModifier;

	[Token(Token = "0x4003B61")]
	[FieldOffset(Offset = "0x18")]
	private float m_maxCharge;

	[Token(Token = "0x4003B62")]
	[FieldOffset(Offset = "0x1C")]
	private float m_chargePoint;

	[Token(Token = "0x4003B63")]
	[FieldOffset(Offset = "0x20")]
	private bool Enable__BackingField;

	[Token(Token = "0x17000C7A")]
	public bool Enable
	{
		[Token(Token = "0x6005492")]
		[Address(RVA = "0x193B22C", Offset = "0x193B22C", VA = "0x193B22C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005493")]
		[Address(RVA = "0x193B234", Offset = "0x193B234", VA = "0x193B234")]
		set
		{
		}
	}

	[Token(Token = "0x17000C7B")]
	public float MaxUltimateDamageConvRatio
	{
		[Token(Token = "0x6005494")]
		[Address(RVA = "0x193B23C", Offset = "0x193B23C", VA = "0x193B23C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000C7C")]
	public float ChargePoint
	{
		[Token(Token = "0x6005496")]
		[Address(RVA = "0x193B2A0", Offset = "0x193B2A0", VA = "0x193B2A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000C7D")]
	public float ChargePercent
	{
		[Token(Token = "0x6005497")]
		[Address(RVA = "0x193AEB4", Offset = "0x193AEB4", VA = "0x193AEB4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6005491")]
	[Address(RVA = "0x193B1C8", Offset = "0x193B1C8", VA = "0x193B1C8")]
	public XUltimateSkillCharger(float maxChargeDefault, float ultimateMaxChargeModifier = 1f)
	{
	}

	[Token(Token = "0x6005495")]
	[Address(RVA = "0x193B244", Offset = "0x193B244", VA = "0x193B244")]
	public void ChargeOnBeaten(float attackerDamage, float maxHp)
	{
	}

	[Token(Token = "0x6005498")]
	[Address(RVA = "0x193B2A8", Offset = "0x193B2A8", VA = "0x193B2A8")]
	public void ChargeOnHit(float ultimateCharge)
	{
	}

	[Token(Token = "0x6005499")]
	[Address(RVA = "0x193B138", Offset = "0x193B138", VA = "0x193B138")]
	public bool CheckActivate()
	{
		return default(bool);
	}

	[Token(Token = "0x600549A")]
	[Address(RVA = "0x193B2C4", Offset = "0x193B2C4", VA = "0x193B2C4")]
	public bool Use()
	{
		return default(bool);
	}

	[Token(Token = "0x600549B")]
	[Address(RVA = "0x193B2E4", Offset = "0x193B2E4", VA = "0x193B2E4")]
	public void Activate()
	{
	}

	[Token(Token = "0x600549C")]
	[Address(RVA = "0x193B2F8", Offset = "0x193B2F8", VA = "0x193B2F8")]
	public void SetChargePointForce(float point)
	{
	}
}
