using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D37")]
public class XWidget_FriendlyTeamSetting : MonoBehaviour
{
	[Token(Token = "0x40043A2")]
	[FieldOffset(Offset = "0xC")]
	public UIToggle[] toggles;

	[Token(Token = "0x40043A3")]
	[FieldOffset(Offset = "0x10")]
	private XTeamEnum setedTeam;

	[Token(Token = "0x60060ED")]
	[Address(RVA = "0x142FAF8", Offset = "0x142FAF8", VA = "0x142FAF8")]
	public XWidget_FriendlyTeamSetting()
	{
	}

	[Token(Token = "0x60060EE")]
	[Address(RVA = "0x142FB00", Offset = "0x142FB00", VA = "0x142FB00")]
	public void Init()
	{
	}

	[Token(Token = "0x60060EF")]
	[Address(RVA = "0x142FC68", Offset = "0x142FC68", VA = "0x142FC68")]
	public void RecvMasterClientTeamInfo(byte teamInfo)
	{
	}

	[Token(Token = "0x60060F0")]
	[Address(RVA = "0x142FE48", Offset = "0x142FE48", VA = "0x142FE48")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x60060F1")]
	[Address(RVA = "0x142FE80", Offset = "0x142FE80", VA = "0x142FE80")]
	public void OnClickTeamRed()
	{
	}

	[Token(Token = "0x60060F2")]
	[Address(RVA = "0x142FE98", Offset = "0x142FE98", VA = "0x142FE98")]
	private void SelectRedTeam()
	{
	}

	[Token(Token = "0x60060F3")]
	[Address(RVA = "0x1430008", Offset = "0x1430008", VA = "0x1430008")]
	public void OnClickTeamBlue()
	{
	}

	[Token(Token = "0x60060F4")]
	[Address(RVA = "0x1430020", Offset = "0x1430020", VA = "0x1430020")]
	private void SelectBlueTeam()
	{
	}
}
