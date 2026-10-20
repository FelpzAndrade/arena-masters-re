using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000767")]
public class XNetDataUpdater_HottimeEventList : XNetDataUpdater
{
	[Token(Token = "0x6003C62")]
	[Address(RVA = "0x21287F4", Offset = "0x21287F4", VA = "0x21287F4")]
	public XNetDataUpdater_HottimeEventList(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C63")]
	[Address(RVA = "0x212A8C8", Offset = "0x212A8C8", VA = "0x212A8C8", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C64")]
	[Address(RVA = "0x212A978", Offset = "0x212A978", VA = "0x212A978", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}
}
