using Il2CppDummyDll;

[Token(Token = "0x2000487")]
public class XModuleRevive : XModuleBase
{
	[Token(Token = "0x40016C1")]
	[FieldOffset(Offset = "0x10")]
	private XModuleEntity m_ReviveTargetPlayer;

	[Token(Token = "0x40016C2")]
	[FieldOffset(Offset = "0x14")]
	private float fTime;

	[Token(Token = "0x40016C3")]
	[FieldOffset(Offset = "0x18")]
	private float fReviveTime;

	[Token(Token = "0x40016C4")]
	[FieldOffset(Offset = "0x1C")]
	private UIProgressBar m_ReviveProgressBar;

	[Token(Token = "0x1700062E")]
	private float Percent
	{
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0xB8D3B0", Offset = "0xB8D3B0", VA = "0xB8D3B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0xB8D3A0", Offset = "0xB8D3A0", VA = "0xB8D3A0")]
	public XModuleRevive()
	{
	}

	[Token(Token = "0x60026C0")]
	[Address(RVA = "0xB8D3C4", Offset = "0xB8D3C4", VA = "0xB8D3C4", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60026C1")]
	[Address(RVA = "0xB8D7E8", Offset = "0xB8D7E8", VA = "0xB8D7E8", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60026C2")]
	[Address(RVA = "0xB8DACC", Offset = "0xB8DACC", VA = "0xB8DACC", Slot = "7")]
	public override void OnLateUpdate(float dt)
	{
	}

	[Token(Token = "0x60026C3")]
	[Address(RVA = "0xB8DCBC", Offset = "0xB8DCBC", VA = "0xB8DCBC", Slot = "57")]
	public override void OnReviveStart(XModuleEntity srcEntity)
	{
	}

	[Token(Token = "0x60026C4")]
	[Address(RVA = "0xB8DE28", Offset = "0xB8DE28", VA = "0xB8DE28", Slot = "58")]
	public override void OnReviveCancel(XModuleEntity srcEntity)
	{
	}

	[Token(Token = "0x60026C5")]
	[Address(RVA = "0xB8DF64", Offset = "0xB8DF64", VA = "0xB8DF64", Slot = "44")]
	public override void OnGameModeFinishStateEnter()
	{
	}

	[Token(Token = "0x60026C6")]
	[Address(RVA = "0xB8D95C", Offset = "0xB8D95C", VA = "0xB8D95C")]
	private void ReviveFinish(XModuleEntity srcEntity)
	{
	}

	[Token(Token = "0x60026C7")]
	[Address(RVA = "0xB8D6F4", Offset = "0xB8D6F4", VA = "0xB8D6F4")]
	private void ResetReviveData()
	{
	}

	[Token(Token = "0x60026C8")]
	[Address(RVA = "0xB8DF68", Offset = "0xB8DF68", VA = "0xB8DF68")]
	private void OnDestroy()
	{
	}
}
