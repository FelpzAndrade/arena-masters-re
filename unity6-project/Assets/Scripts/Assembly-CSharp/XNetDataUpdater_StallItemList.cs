using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200076B")]
public class XNetDataUpdater_StallItemList : XNetDataUpdater
{
	[Token(Token = "0x6003C74")]
	[Address(RVA = "0x21282A4", Offset = "0x21282A4", VA = "0x21282A4")]
	public XNetDataUpdater_StallItemList(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C75")]
	[Address(RVA = "0x212C27C", Offset = "0x212C27C", VA = "0x212C27C", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C76")]
	[Address(RVA = "0x212C32C", Offset = "0x212C32C", VA = "0x212C32C", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}
}
