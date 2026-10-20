using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000769")]
public class XNetDataUpdater_PetList : XNetDataUpdater
{
	[Token(Token = "0x40022EA")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003C6A")]
	[Address(RVA = "0x2128A34", Offset = "0x2128A34", VA = "0x2128A34")]
	public XNetDataUpdater_PetList(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C6B")]
	[Address(RVA = "0x212BC20", Offset = "0x212BC20", VA = "0x212BC20", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C6C")]
	[Address(RVA = "0x212BCD0", Offset = "0x212BCD0", VA = "0x212BCD0", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C6D")]
	[Address(RVA = "0x212B798", Offset = "0x212B798", VA = "0x212B798")]
	protected bool UpdateFromServerByDiff(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C6E")]
	[Address(RVA = "0x212BE3C", Offset = "0x212BE3C", VA = "0x212BE3C")]
	private void UpdatePetInventoryNotowned()
	{
	}

	[Token(Token = "0x6003C6F")]
	[Address(RVA = "0x212C278", Offset = "0x212C278", VA = "0x212C278")]
	private static void _003CUpdateFromServerByDiff_003Em__1AA(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
