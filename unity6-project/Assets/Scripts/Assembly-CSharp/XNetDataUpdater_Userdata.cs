using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200076D")]
public class XNetDataUpdater_Userdata : XNetDataUpdater
{
	[Token(Token = "0x40022EC")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003C7C")]
	[Address(RVA = "0x2127350", Offset = "0x2127350", VA = "0x2127350")]
	public XNetDataUpdater_Userdata(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C7D")]
	[Address(RVA = "0x212CA38", Offset = "0x212CA38", VA = "0x212CA38", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C7E")]
	[Address(RVA = "0x212CAE8", Offset = "0x212CAE8", VA = "0x212CAE8", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C7F")]
	[Address(RVA = "0x212C5CC", Offset = "0x212C5CC", VA = "0x212C5CC")]
	private bool UpdateFromServerByDiff(JToken data)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C80")]
	[Address(RVA = "0x212CC50", Offset = "0x212CC50", VA = "0x212CC50")]
	private static void _003CUpdateFromServerByDiff_003Em__1AC(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
