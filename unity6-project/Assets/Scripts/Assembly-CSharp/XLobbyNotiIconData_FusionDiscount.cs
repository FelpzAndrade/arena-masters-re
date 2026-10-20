using System.Text;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FCF")]
public class XLobbyNotiIconData_FusionDiscount : IBaseLobbyNotiIconData
{
	[Token(Token = "0x400540F")]
	[FieldOffset(Offset = "0x8")]
	private CSEventSystemInfo m_eventSystemInfo;

	[Token(Token = "0x4005410")]
	[FieldOffset(Offset = "0xC")]
	private StringBuilder stringBuilder;

	[Token(Token = "0x60075C5")]
	[Address(RVA = "0x1E19398", Offset = "0x1E19398", VA = "0x1E19398")]
	public XLobbyNotiIconData_FusionDiscount(CSEventSystemInfo eventSystemInfo)
	{
	}

	[Token(Token = "0x60075C6")]
	[Address(RVA = "0x1E1943C", Offset = "0x1E1943C", VA = "0x1E1943C", Slot = "4")]
	public string GetIconName()
	{
		return null;
	}

	[Token(Token = "0x60075C7")]
	[Address(RVA = "0x1E19460", Offset = "0x1E19460", VA = "0x1E19460", Slot = "5")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60075C8")]
	[Address(RVA = "0x1E19470", Offset = "0x1E19470", VA = "0x1E19470", Slot = "6")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x60075C9")]
	[Address(RVA = "0x1E19520", Offset = "0x1E19520", VA = "0x1E19520", Slot = "7")]
	public string GetTooltipText()
	{
		return null;
	}

	[Token(Token = "0x60075CA")]
	[Address(RVA = "0x1E19734", Offset = "0x1E19734", VA = "0x1E19734")]
	private string GetEventName(CSEventSystemInfo eventSystemInfo)
	{
		return null;
	}

	[Token(Token = "0x60075CB")]
	[Address(RVA = "0x1E197E4", Offset = "0x1E197E4", VA = "0x1E197E4")]
	private string GetEventDescription(CSEventSystemInfo eventSystemInfo)
	{
		return null;
	}
}
