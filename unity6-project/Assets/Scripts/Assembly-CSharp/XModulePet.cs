using Il2CppDummyDll;

[Token(Token = "0x2000481")]
public class XModulePet : XModuleBase
{
	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x10")]
	public XModuleEntity PetMe;

	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x14")]
	public bool isActive;

	[Token(Token = "0x6002633")]
	[Address(RVA = "0xB7D228", Offset = "0xB7D228", VA = "0xB7D228")]
	public XModulePet()
	{
	}

	[Token(Token = "0x6002634")]
	[Address(RVA = "0xB54F64", Offset = "0xB54F64", VA = "0xB54F64")]
	public bool GetIsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002635")]
	[Address(RVA = "0xB7D23C", Offset = "0xB7D23C", VA = "0xB7D23C", Slot = "43")]
	public override void OnGameModePlayStateEnter()
	{
	}

	[Token(Token = "0x6002636")]
	[Address(RVA = "0xB63100", Offset = "0xB63100", VA = "0xB63100")]
	public void DieMyPlayer()
	{
	}

	[Token(Token = "0x6002637")]
	[Address(RVA = "0xB6DD40", Offset = "0xB6DD40", VA = "0xB6DD40")]
	public void SetVisible(MeshVisible.State state)
	{
	}

	[Token(Token = "0x6002638")]
	[Address(RVA = "0xB7D428", Offset = "0xB7D428", VA = "0xB7D428")]
	public void Hide()
	{
	}
}
