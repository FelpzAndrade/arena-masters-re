using System.Text;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FCE")]
public class XLobbyNotiIconData_HotTime : IBaseLobbyNotiIconData
{
	[Token(Token = "0x400540D")]
	[FieldOffset(Offset = "0x8")]
	private CSEventSystemInfo m_eventSystemInfo;

	[Token(Token = "0x400540E")]
	[FieldOffset(Offset = "0xC")]
	private StringBuilder stringBuilder;

	[Token(Token = "0x60075BE")]
	[Address(RVA = "0x1E19894", Offset = "0x1E19894", VA = "0x1E19894")]
	public XLobbyNotiIconData_HotTime(CSEventSystemInfo eventSystemInfo)
	{
	}

	[Token(Token = "0x60075BF")]
	[Address(RVA = "0x1E19938", Offset = "0x1E19938", VA = "0x1E19938", Slot = "4")]
	public string GetIconName()
	{
		return null;
	}

	[Token(Token = "0x60075C0")]
	[Address(RVA = "0x1E1995C", Offset = "0x1E1995C", VA = "0x1E1995C", Slot = "5")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60075C1")]
	[Address(RVA = "0x1E1996C", Offset = "0x1E1996C", VA = "0x1E1996C", Slot = "6")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60075C2")]
	[Address(RVA = "0x1E19A1C", Offset = "0x1E19A1C", VA = "0x1E19A1C", Slot = "7")]
	public string GetTooltipText()
	{
		return null;
	}

	[Token(Token = "0x60075C3")]
	[Address(RVA = "0x1E19F70", Offset = "0x1E19F70", VA = "0x1E19F70")]
	private string GetEventName(CSEventSystemInfo eventSystemInfo)
	{
		return null;
	}

	[Token(Token = "0x60075C4")]
	[Address(RVA = "0x1E19E5C", Offset = "0x1E19E5C", VA = "0x1E19E5C")]
	private string GetEventDescription(CSEventSystemInfo eventSystemInfo)
	{
		return null;
	}
}
