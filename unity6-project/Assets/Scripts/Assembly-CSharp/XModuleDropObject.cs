using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000459")]
public class XModuleDropObject : XModuleBase
{
	[Token(Token = "0x400156E")]
	[FieldOffset(Offset = "0x10")]
	private List<XModuleEntity> m_playerModuleEntityList;

	[Token(Token = "0x400156F")]
	[FieldOffset(Offset = "0x14")]
	private bool bLooting;

	[Token(Token = "0x4001570")]
	[FieldOffset(Offset = "0x18")]
	private XModuleEntity m_lootingPlayer;

	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x1C")]
	private float fLootingTime;

	[Token(Token = "0x4001572")]
	[FieldOffset(Offset = "0x20")]
	private float fAccumulated;

	[Token(Token = "0x4001573")]
	[FieldOffset(Offset = "0x24")]
	private UIProgressBar m_LootingProgressBar;

	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x28")]
	private string lootingSoundKey;

	[Token(Token = "0x4001575")]
	[FieldOffset(Offset = "0x2C")]
	private bool isFinish;

	[Token(Token = "0x17000606")]
	public float Percent
	{
		[Token(Token = "0x600240F")]
		[Address(RVA = "0xB561FC", Offset = "0xB561FC", VA = "0xB561FC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600240E")]
	[Address(RVA = "0xB56134", Offset = "0xB56134", VA = "0xB56134")]
	public XModuleDropObject()
	{
	}

	[Token(Token = "0x6002410")]
	[Address(RVA = "0xB56210", Offset = "0xB56210", VA = "0xB56210", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0xB5667C", Offset = "0xB5667C", VA = "0xB5667C", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0xB567BC", Offset = "0xB567BC", VA = "0xB567BC")]
	private bool UpdateEscapedPlayerLootingInteraction()
	{
		return default(bool);
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0xB573AC", Offset = "0xB573AC", VA = "0xB573AC")]
	public void OnPlayerDisconnected(string playerNick)
	{
	}

	[Token(Token = "0x6002414")]
	[Address(RVA = "0xB573B0", Offset = "0xB573B0", VA = "0xB573B0", Slot = "7")]
	public override void OnLateUpdate(float dt)
	{
	}

	[Token(Token = "0x6002415")]
	[Address(RVA = "0xB57560", Offset = "0xB57560", VA = "0xB57560", Slot = "54")]
	public override void OnLootingStart(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x6002416")]
	[Address(RVA = "0xB57788", Offset = "0xB57788", VA = "0xB57788", Slot = "55")]
	public override void OnLootingCancel(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x6002417")]
	[Address(RVA = "0xB57868", Offset = "0xB57868", VA = "0xB57868", Slot = "44")]
	public override void OnGameModeFinishStateEnter()
	{
	}

	[Token(Token = "0x6002418")]
	[Address(RVA = "0xB57278", Offset = "0xB57278", VA = "0xB57278")]
	private void UpdateLootingProgress()
	{
	}

	[Token(Token = "0x6002419")]
	[Address(RVA = "0xB57884", Offset = "0xB57884", VA = "0xB57884", Slot = "56")]
	public override void OnLootingFinish(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x600241A")]
	[Address(RVA = "0xB56A70", Offset = "0xB56A70", VA = "0xB56A70")]
	private void LootFinishDropObject(XModuleEntity playerModuleEntity)
	{
	}

	[Token(Token = "0x600241B")]
	[Address(RVA = "0xB5655C", Offset = "0xB5655C", VA = "0xB5655C")]
	private void ResetDropObjectLooting()
	{
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0xB57888", Offset = "0xB57888", VA = "0xB57888")]
	private void OnDestroy()
	{
	}
}
