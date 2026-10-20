using Il2CppDummyDll;

[Token(Token = "0x20007FF")]
public class XNetProcess_NexonToyInit : XNetProcessLoginBase
{
	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x35")]
	private bool m_bRequestUserInfo;

	[Token(Token = "0x170008E9")]
	public override string Name
	{
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x1EBED74", Offset = "0x1EBED74", VA = "0x1EBED74", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EA")]
	public override bool IsProcessed
	{
		[Token(Token = "0x6004007")]
		[Address(RVA = "0x1EBEDEC", Offset = "0x1EBEDEC", VA = "0x1EBEDEC", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004005")]
	[Address(RVA = "0x1EBED6C", Offset = "0x1EBED6C", VA = "0x1EBED6C")]
	public XNetProcess_NexonToyInit()
	{
	}

	[Token(Token = "0x6004008")]
	[Address(RVA = "0x1EBEED8", Offset = "0x1EBEED8", VA = "0x1EBEED8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004009")]
	[Address(RVA = "0x1EBF14C", Offset = "0x1EBF14C", VA = "0x1EBF14C", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0x1EBF150", Offset = "0x1EBF150", VA = "0x1EBF150", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0x1EBF180", Offset = "0x1EBF180", VA = "0x1EBF180")]
	private void SetFirstRecommandRegion()
	{
	}

	[Token(Token = "0x600400C")]
	[Address(RVA = "0x1EBF4A0", Offset = "0x1EBF4A0", VA = "0x1EBF4A0")]
	private void GetNetConfigAndAutoConnectGamePlatform()
	{
	}
}
