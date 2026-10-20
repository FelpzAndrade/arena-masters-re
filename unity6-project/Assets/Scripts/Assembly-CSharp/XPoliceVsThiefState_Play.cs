using Il2CppDummyDll;
using XCasualModeLogic.PoliceVsThief;

[Token(Token = "0x200053E")]
public class XPoliceVsThiefState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x4001A42")]
	[FieldOffset(Offset = "0x24")]
	private Mode mode;

	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x1C84144", Offset = "0x1C84144", VA = "0x1C84144")]
	public XPoliceVsThiefState_Play()
	{
	}

	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0x1C84154", Offset = "0x1C84154", VA = "0x1C84154", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0x1C85118", Offset = "0x1C85118", VA = "0x1C85118", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002CC2")]
	[Address(RVA = "0x1C8511C", Offset = "0x1C8511C", VA = "0x1C8511C")]
	public void OnMasterClientSwitched(PhotonPlayer player)
	{
	}

	[Token(Token = "0x6002CC3")]
	[Address(RVA = "0x1C851EC", Offset = "0x1C851EC", VA = "0x1C851EC", Slot = "22")]
	protected override bool CheckFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002CC4")]
	[Address(RVA = "0x1C85214", Offset = "0x1C85214", VA = "0x1C85214", Slot = "21")]
	protected override void ShowGameStart()
	{
	}

	[Token(Token = "0x6002CC5")]
	[Address(RVA = "0x1C8444C", Offset = "0x1C8444C", VA = "0x1C8444C")]
	public void InitMode()
	{
	}

	[Token(Token = "0x6002CC6")]
	[Address(RVA = "0x1C85218", Offset = "0x1C85218", VA = "0x1C85218", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002CC7")]
	[Address(RVA = "0x1C853B8", Offset = "0x1C853B8", VA = "0x1C853B8", Slot = "9")]
	public override void Exit()
	{
	}
}
