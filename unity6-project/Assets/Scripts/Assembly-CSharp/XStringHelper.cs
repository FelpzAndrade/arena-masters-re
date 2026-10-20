using Il2CppDummyDll;

[Token(Token = "0x20006AA")]
public static class XStringHelper
{
	[Token(Token = "0x400203F")]
	[FieldOffset(Offset = "0x0")]
	private static string m_stMyKillCheckText;

	[Token(Token = "0x60037F5")]
	[Address(RVA = "0x1830D10", Offset = "0x1830D10", VA = "0x1830D10")]
	public static string MakeTimerString(int nTimeSec)
	{
		return null;
	}

	[Token(Token = "0x60037F6")]
	[Address(RVA = "0x1830E34", Offset = "0x1830E34", VA = "0x1830E34")]
	public static bool CheckMyKill_FromInGameChatSystemMsg(string strChatMsg, string strMyName)
	{
		return default(bool);
	}

	[Token(Token = "0x60037F7")]
	[Address(RVA = "0x1831058", Offset = "0x1831058", VA = "0x1831058")]
	public static string AddCommaByLanguage(int num)
	{
		return null;
	}

	[Token(Token = "0x60037F8")]
	[Address(RVA = "0x1831308", Offset = "0x1831308", VA = "0x1831308")]
	public static string AddCommaByLanguage(float num)
	{
		return null;
	}

	[Token(Token = "0x60037F9")]
	[Address(RVA = "0x183154C", Offset = "0x183154C", VA = "0x183154C")]
	public static string MakeInGameChatSystemMsg_Kill(string strAttacker, string strVictim)
	{
		return null;
	}

	[Token(Token = "0x60037FA")]
	[Address(RVA = "0x1831624", Offset = "0x1831624", VA = "0x1831624")]
	public static string MakeInGameChatSystemMsg_Die(string strVictim)
	{
		return null;
	}

	[Token(Token = "0x60037FB")]
	[Address(RVA = "0x18316E8", Offset = "0x18316E8", VA = "0x18316E8")]
	public static string MakeInGameChatMsg(XChatMsgType msgType, string strName, string strText)
	{
		return null;
	}

	[Token(Token = "0x60037FC")]
	[Address(RVA = "0x18318B0", Offset = "0x18318B0", VA = "0x18318B0")]
	public static string GetProfileIcon(int profileIconID)
	{
		return null;
	}

	[Token(Token = "0x60037FD")]
	[Address(RVA = "0x18319BC", Offset = "0x18319BC", VA = "0x18319BC")]
	public static string GetDeathProfileIcon()
	{
		return null;
	}

	[Token(Token = "0x60037FE")]
	[Address(RVA = "0x1831A34", Offset = "0x1831A34", VA = "0x1831A34")]
	public static void ParseEmoticonString(string text, out int setID, out int subID)
	{
		setID = default;
		subID = default;
	}
}
