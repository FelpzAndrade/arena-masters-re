using Il2CppDummyDll;

[Token(Token = "0x20004CD")]
public class XComboManager
{
	[Token(Token = "0x4001836")]
	[FieldOffset(Offset = "0x8")]
	private float lastHitTime;

	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0xC")]
	private float comboTime;

	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0x10")]
	private int curCombo;

	[Token(Token = "0x6002930")]
	[Address(RVA = "0x198A0F4", Offset = "0x198A0F4", VA = "0x198A0F4")]
	public XComboManager()
	{
	}

	[Token(Token = "0x6002931")]
	[Address(RVA = "0x198A104", Offset = "0x198A104", VA = "0x198A104")]
	public void Init()
	{
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x198A244", Offset = "0x198A244", VA = "0x198A244")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x198A254", Offset = "0x198A254", VA = "0x198A254")]
	public void ApplyCombo(float curTime)
	{
	}
}
