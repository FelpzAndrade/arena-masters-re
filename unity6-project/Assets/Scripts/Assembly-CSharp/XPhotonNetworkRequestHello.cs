using CS;
using Il2CppDummyDll;

[Token(Token = "0x200084E")]
public class XPhotonNetworkRequestHello
{
		protected XPhotonNetworkRequestHello()
		{
		}

	[Token(Token = "0x40023EA")]
	[FieldOffset(Offset = "0x8")]
	protected XPhotonNetwork m_photon;

	[Token(Token = "0x60044E5")]
	[Address(RVA = "0xB200D4", Offset = "0xB200D4", VA = "0xB200D4")]
	public XPhotonNetworkRequestHello(XPhotonNetwork photon)
	{
	}

	[Token(Token = "0x60044E6")]
	[Address(RVA = "0xB200F4", Offset = "0xB200F4", VA = "0xB200F4", Slot = "4")]
	public virtual void SyncToMasterClient()
	{
	}

	[Token(Token = "0x60044E7")]
	[Address(RVA = "0xB200F8", Offset = "0xB200F8", VA = "0xB200F8", Slot = "5")]
	public virtual void _SyncToMasterClient(int nTargetPhotonID, PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60044E8")]
	[Address(RVA = "0xB200FC", Offset = "0xB200FC", VA = "0xB200FC", Slot = "6")]
	public virtual void HelloToMasterClient()
	{
	}

	[Token(Token = "0x60044E9")]
	[Address(RVA = "0xB20100", Offset = "0xB20100", VA = "0xB20100", Slot = "7")]
	public virtual void _HelloToMasterClient(int nTargetPhotonID, PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60044EA")]
	[Address(RVA = "0xB20104", Offset = "0xB20104", VA = "0xB20104", Slot = "8")]
	public virtual void _WelcomeAgain(XModuleEntity myMe, NetData_Record[] records, NetData_TeamInfo[] teamInfos, int MasterClientPhotonID)
	{
	}

	[Token(Token = "0x60044EB")]
	[Address(RVA = "0xB20108", Offset = "0xB20108", VA = "0xB20108", Slot = "9")]
	public virtual void _RequestHelloAll()
	{
	}
}
