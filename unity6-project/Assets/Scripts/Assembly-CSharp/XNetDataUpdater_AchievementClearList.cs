using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000764")]
public class XNetDataUpdater_AchievementClearList : XNetDataUpdater
{
	[Token(Token = "0x40022E7")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003C53")]
	[Address(RVA = "0x21284E4", Offset = "0x21284E4", VA = "0x21284E4")]
	public XNetDataUpdater_AchievementClearList(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C54")]
	[Address(RVA = "0x21294B8", Offset = "0x21294B8", VA = "0x21294B8", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C55")]
	[Address(RVA = "0x2129568", Offset = "0x2129568", VA = "0x2129568", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C56")]
	[Address(RVA = "0x2128FC8", Offset = "0x2128FC8", VA = "0x2128FC8")]
	private bool UpdateFromServerByDiff(JToken data)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C57")]
	[Address(RVA = "0x212970C", Offset = "0x212970C", VA = "0x212970C")]
	private static void _003CUpdateFromServerByDiff_003Em__1A7(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
