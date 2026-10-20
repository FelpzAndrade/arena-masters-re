using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003F1")]
public class ClanListenerNull : IClanListener
{
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x0")]
	public static ClanListenerNull INST;

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x20C58D4", Offset = "0x20C58D4", VA = "0x20C58D4")]
	private ClanListenerNull()
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x20C5970", Offset = "0x20C5970", VA = "0x20C5970", Slot = "4")]
	public void OnUpdateClanData(Netdata_Clan clanData)
	{
	}
}
