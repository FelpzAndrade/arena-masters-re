using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000622")]
public class XQuickMatchOptionData
{
	[Token(Token = "0x4001D84")]
	[FieldOffset(Offset = "0x8")]
	public List<XGameModeType> GameModeTypeIgnores;

	[Token(Token = "0x4001D85")]
	[FieldOffset(Offset = "0xC")]
	public List<int> MapThemeIgnores;

	[Token(Token = "0x60034D7")]
	[Address(RVA = "0x1C9EE14", Offset = "0x1C9EE14", VA = "0x1C9EE14")]
	public XQuickMatchOptionData()
	{
	}

	[Token(Token = "0x60034D8")]
	[Address(RVA = "0x1C9EEF4", Offset = "0x1C9EEF4", VA = "0x1C9EEF4")]
	public static bool IsIgnoreSectorList(List<int> ignoreSectorIDList, List<int> candidateSectorIDList)
	{
		return default(bool);
	}
}
