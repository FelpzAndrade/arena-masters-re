using CS;
using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x20005A9")]
public class XPVEGameModeState_Play : XGameModeState_Play
{
	[Token(Token = "0x4001B81")]
	[FieldOffset(Offset = "0x24")]
	protected XLevelLoader m_levelLoader;

	[Token(Token = "0x4001B82")]
	[FieldOffset(Offset = "0x28")]
	protected bool m_clear;

	[Token(Token = "0x4001B83")]
	[FieldOffset(Offset = "0x2C")]
	protected CSStageInfo m_info;

	[Token(Token = "0x6003067")]
	[Address(RVA = "0x1C96000", Offset = "0x1C96000", VA = "0x1C96000")]
	public XPVEGameModeState_Play()
	{
	}

	[Token(Token = "0x6003068")]
	[Address(RVA = "0x1C96008", Offset = "0x1C96008", VA = "0x1C96008", Slot = "19")]
	protected override void RequestStartGameForIntruder()
	{
	}

	[Token(Token = "0x6003069")]
	[Address(RVA = "0x1C9600C", Offset = "0x1C9600C", VA = "0x1C9600C", Slot = "4")]
	public override void SetGameMode(XGameMode owner)
	{
	}

	[Token(Token = "0x600306A")]
	[Address(RVA = "0x1C960CC", Offset = "0x1C960CC", VA = "0x1C960CC", Slot = "12")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x600306B")]
	[Address(RVA = "0x1C961C8", Offset = "0x1C961C8", VA = "0x1C961C8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600306C")]
	[Address(RVA = "0x1C96204", Offset = "0x1C96204", VA = "0x1C96204", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x600306D")]
	[Address(RVA = "0x1C9654C", Offset = "0x1C9654C", VA = "0x1C9654C", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x600306E")]
	[Address(RVA = "0x1C9658C", Offset = "0x1C9658C", VA = "0x1C9658C", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x600306F")]
	[Address(RVA = "0x1C96BAC", Offset = "0x1C96BAC", VA = "0x1C96BAC")]
	private void _003CUpdate_003Em__12E()
	{
	}
}
