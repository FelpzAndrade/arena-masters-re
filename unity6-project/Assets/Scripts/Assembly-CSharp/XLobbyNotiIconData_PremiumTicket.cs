using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FD0")]
public class XLobbyNotiIconData_PremiumTicket : IBaseLobbyNotiIconData
{
	[Token(Token = "0x4005411")]
	[FieldOffset(Offset = "0x8")]
	private PremiumTicketData m_ticketData;

	[Token(Token = "0x4005412")]
	[FieldOffset(Offset = "0xC")]
	private PremiumTicketInfo m_ticketInfo;

	[Token(Token = "0x60075CC")]
	[Address(RVA = "0x1E1A084", Offset = "0x1E1A084", VA = "0x1E1A084")]
	public XLobbyNotiIconData_PremiumTicket(PremiumTicketData ticketData, PremiumTicketInfo ticketInfo)
	{
	}

	[Token(Token = "0x60075CD")]
	[Address(RVA = "0x1E1A0AC", Offset = "0x1E1A0AC", VA = "0x1E1A0AC", Slot = "4")]
	public string GetIconName()
	{
		return null;
	}

	[Token(Token = "0x60075CE")]
	[Address(RVA = "0x1E1A0D0", Offset = "0x1E1A0D0", VA = "0x1E1A0D0", Slot = "5")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60075CF")]
	[Address(RVA = "0x1E1A0F4", Offset = "0x1E1A0F4", VA = "0x1E1A0F4")]
	private string GetTicketString(PremiumTicketInfo info)
	{
		return null;
	}

	[Token(Token = "0x60075D0")]
	[Address(RVA = "0x1E1A2D8", Offset = "0x1E1A2D8", VA = "0x1E1A2D8")]
	private string GetTicketContentString(CSContentType type, int count)
	{
		return null;
	}

	[Token(Token = "0x60075D1")]
	[Address(RVA = "0x1E1A478", Offset = "0x1E1A478", VA = "0x1E1A478", Slot = "7")]
	public string GetTooltipText()
	{
		return null;
	}

	[Token(Token = "0x60075D2")]
	[Address(RVA = "0x1E1A480", Offset = "0x1E1A480", VA = "0x1E1A480", Slot = "6")]
	public string GetText()
	{
		return null;
	}
}
