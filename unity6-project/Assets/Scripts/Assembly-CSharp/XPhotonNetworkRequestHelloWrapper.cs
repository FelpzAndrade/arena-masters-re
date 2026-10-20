using CS;
using Il2CppDummyDll;

[Token(Token = "0x200084F")]
public class XPhotonNetworkRequestHelloWrapper : XPhotonNetworkRequestHello
{
	[Token(Token = "0x60044EC")]
	[Address(RVA = "0xB0B5D8", Offset = "0xB0B5D8", VA = "0xB0B5D8")]
	public XPhotonNetworkRequestHelloWrapper(XPhotonNetwork photon)
	{
	}

	[Token(Token = "0x60044ED")]
	[Address(RVA = "0xB2010C", Offset = "0xB2010C", VA = "0xB2010C", Slot = "4")]
	public override void SyncToMasterClient()
	{
	}

	[Token(Token = "0x60044EE")]
	[Address(RVA = "0xB206B0", Offset = "0xB206B0", VA = "0xB206B0", Slot = "5")]
	public override void _SyncToMasterClient(int nTargetPhotonID, PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60044EF")]
	[Address(RVA = "0xB21764", Offset = "0xB21764", VA = "0xB21764", Slot = "6")]
	public override void HelloToMasterClient()
	{
	}

	[Token(Token = "0x60044F0")]
	[Address(RVA = "0xB21C20", Offset = "0xB21C20", VA = "0xB21C20", Slot = "7")]
	public override void _HelloToMasterClient(int nTargetPhotonID, PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60044F1")]
	[Address(RVA = "0xB2243C", Offset = "0xB2243C", VA = "0xB2243C", Slot = "8")]
	public override void _WelcomeAgain(XModuleEntity myMe, NetData_Record[] records, NetData_TeamInfo[] teamInfos, int MasterClientPhotonID)
	{
	}

	[Token(Token = "0x60044F2")]
	[Address(RVA = "0xB243BC", Offset = "0xB243BC", VA = "0xB243BC", Slot = "9")]
	public override void _RequestHelloAll()
	{
	}

	[Token(Token = "0x60044F3")]
	[Address(RVA = "0xB24680", Offset = "0xB24680", VA = "0xB24680")]
	private void RequestHello(PhotonPlayer player, bool igoreRequestHello = false)
	{
	}

	[Token(Token = "0x60044F4")]
	[Address(RVA = "0xB23BD4", Offset = "0xB23BD4", VA = "0xB23BD4")]
	private void DieHPSync(XModuleEntity me, int nCurrentHP)
	{
	}
}
