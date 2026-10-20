using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000484")]
public class XModulePhotonForNetAI : XModulePhoton
{
	[Token(Token = "0x600267A")]
	[Address(RVA = "0xB8386C", Offset = "0xB8386C", VA = "0xB8386C")]
	public XModulePhotonForNetAI()
	{
	}

	[Token(Token = "0x600267B")]
	[Address(RVA = "0xB83870", Offset = "0xB83870", VA = "0xB83870", Slot = "4")]
	public override bool IsNetAIHost()
	{
		return default(bool);
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0xB839D8", Offset = "0xB839D8", VA = "0xB839D8", Slot = "5")]
	public override bool IsNetAI()
	{
		return default(bool);
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0xB839E0", Offset = "0xB839E0", VA = "0xB839E0")]
	public void OnPhotonInstantiate(PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600267E")]
	[Address(RVA = "0xB83CD4", Offset = "0xB83CD4", VA = "0xB83CD4")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600267F")]
	[Address(RVA = "0xB83DE8", Offset = "0xB83DE8", VA = "0xB83DE8")]
	private void SyncToMasterClient()
	{
	}

	[Token(Token = "0x6002680")]
	[Address(RVA = "0xB83B38", Offset = "0xB83B38", VA = "0xB83B38")]
	private void InitNetMonster(int actorID, int level, XTeamEnum team)
	{
	}

	[Token(Token = "0x6002681")]
	[Address(RVA = "0xB83E98", Offset = "0xB83E98", VA = "0xB83E98", Slot = "19")]
	public override void NetAISetTarget(XModuleEntity target)
	{
	}

	[Token(Token = "0x6002682")]
	[Address(RVA = "0xB8427C", Offset = "0xB8427C", VA = "0xB8427C")]
	[PunRPC]
	public void _NetAISetTarget(int targetPhotonViewID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002683")]
	[Address(RVA = "0xB8461C", Offset = "0xB8461C", VA = "0xB8461C", Slot = "7")]
	protected override void _DieFunc(int nVictimPhotonID, int streakKillCount, int nAttackerPhotonID, int nAttackerPhotonViewID)
	{
	}
}
