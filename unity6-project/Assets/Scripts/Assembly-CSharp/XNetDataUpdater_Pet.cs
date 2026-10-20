using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200076A")]
public class XNetDataUpdater_Pet : XNetDataUpdater
{
	[Token(Token = "0x6003C70")]
	[Address(RVA = "0x2128D44", Offset = "0x2128D44", VA = "0x2128D44")]
	public XNetDataUpdater_Pet(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C71")]
	[Address(RVA = "0x212B59C", Offset = "0x212B59C", VA = "0x212B59C", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C72")]
	[Address(RVA = "0x212B64C", Offset = "0x212B64C", VA = "0x212B64C", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C73")]
	[Address(RVA = "0x212B27C", Offset = "0x212B27C", VA = "0x212B27C")]
	private bool UpdateFromServerByDiff(JToken source)
	{
		return default(bool);
	}
}
