using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000768")]
public class XNetDataUpdater_ItemList : XNetDataUpdater
{
	[Token(Token = "0x40022E9")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003C65")]
	[Address(RVA = "0x2127970", Offset = "0x2127970", VA = "0x2127970")]
	public XNetDataUpdater_ItemList(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C66")]
	[Address(RVA = "0x212B060", Offset = "0x212B060", VA = "0x212B060", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C67")]
	[Address(RVA = "0x212B110", Offset = "0x212B110", VA = "0x212B110", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C68")]
	[Address(RVA = "0x212ABDC", Offset = "0x212ABDC", VA = "0x212ABDC")]
	private bool UpdateFromServerByDiff(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C69")]
	[Address(RVA = "0x212B278", Offset = "0x212B278", VA = "0x212B278")]
	private static void _003CUpdateFromServerByDiff_003Em__1A9(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
