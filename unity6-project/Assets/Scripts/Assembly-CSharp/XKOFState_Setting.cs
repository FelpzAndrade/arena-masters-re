using Il2CppDummyDll;

[Token(Token = "0x200057A")]
public class XKOFState_Setting : XGameModeState_Setting
{
	[Token(Token = "0x4001B09")]
	[FieldOffset(Offset = "0x14")]
	private int m_readyCnt;

	[Token(Token = "0x4001B0A")]
	[FieldOffset(Offset = "0x18")]
	private XRoundTimer m_RoundTimer;

	[Token(Token = "0x4001B0B")]
	[FieldOffset(Offset = "0x1C")]
	private float constTime;

	[Token(Token = "0x4001B0C")]
	[FieldOffset(Offset = "0x20")]
	private float m_time;

	[Token(Token = "0x17000732")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002EA5")]
		[Address(RVA = "0x1D3F12C", Offset = "0x1D3F12C", VA = "0x1D3F12C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0x1D3EA64", Offset = "0x1D3EA64", VA = "0x1D3EA64")]
	public XKOFState_Setting()
	{
	}

	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0x1D3EB0C", Offset = "0x1D3EB0C", VA = "0x1D3EB0C", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0x1D3EEE4", Offset = "0x1D3EEE4", VA = "0x1D3EEE4", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x1D3F158", Offset = "0x1D3F158", VA = "0x1D3F158")]
	public void ReadyOk()
	{
	}
}
