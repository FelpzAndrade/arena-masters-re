using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200076C")]
public class XNetDataUpdater_UserResource : XNetDataUpdater
{
	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003C77")]
	[Address(RVA = "0x2127C80", Offset = "0x2127C80", VA = "0x2127C80")]
	public XNetDataUpdater_UserResource(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C78")]
	[Address(RVA = "0x212D0C0", Offset = "0x212D0C0", VA = "0x212D0C0", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C79")]
	[Address(RVA = "0x212D170", Offset = "0x212D170", VA = "0x212D170", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C7A")]
	[Address(RVA = "0x212CC54", Offset = "0x212CC54", VA = "0x212CC54")]
	private bool UpdateFromServerByDiff(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C7B")]
	[Address(RVA = "0x212D45C", Offset = "0x212D45C", VA = "0x212D45C")]
	private static void _003CUpdateFromServerByDiff_003Em__1AB(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
