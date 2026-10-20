using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000766")]
public class XNetDataUpdater_Character : XNetDataUpdater
{
	[Token(Token = "0x6003C5E")]
	[Address(RVA = "0x2127F90", Offset = "0x2127F90", VA = "0x2127F90")]
	public XNetDataUpdater_Character(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C5F")]
	[Address(RVA = "0x2129A30", Offset = "0x2129A30", VA = "0x2129A30", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C60")]
	[Address(RVA = "0x2129AE0", Offset = "0x2129AE0", VA = "0x2129AE0", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C61")]
	[Address(RVA = "0x2129710", Offset = "0x2129710", VA = "0x2129710")]
	private bool UpdateFromServerByDiff(JToken source)
	{
		return default(bool);
	}
}
