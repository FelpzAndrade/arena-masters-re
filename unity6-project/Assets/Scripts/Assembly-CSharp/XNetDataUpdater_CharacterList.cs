using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000765")]
public class XNetDataUpdater_CharacterList : XNetDataUpdater
{
	[Token(Token = "0x40022E8")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003C58")]
	[Address(RVA = "0x2127660", Offset = "0x2127660", VA = "0x2127660")]
	public XNetDataUpdater_CharacterList(JToken data, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C59")]
	[Address(RVA = "0x212A0B4", Offset = "0x212A0B4", VA = "0x212A0B4", Slot = "4")]
	protected override string GetTypeKey()
	{
		return null;
	}

	[Token(Token = "0x6003C5A")]
	[Address(RVA = "0x212A164", Offset = "0x212A164", VA = "0x212A164", Slot = "5")]
	protected override bool UpdateFromServer(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C5B")]
	[Address(RVA = "0x2129C2C", Offset = "0x2129C2C", VA = "0x2129C2C")]
	protected bool UpdateFromServerByDiff(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C5C")]
	[Address(RVA = "0x212A2D0", Offset = "0x212A2D0", VA = "0x212A2D0")]
	private void UpdateCharacterInventoryNotowned()
	{
	}

	[Token(Token = "0x6003C5D")]
	[Address(RVA = "0x212A8C4", Offset = "0x212A8C4", VA = "0x212A8C4")]
	private static void _003CUpdateFromServerByDiff_003Em__1A8(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
