using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20005C1")]
public class NetData_PlayerTeamSetting
{
	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x8")]
	public List<XPlayerTeamData> liPlayerTeam;

	[Token(Token = "0x6003107")]
	[Address(RVA = "0x135DE98", Offset = "0x135DE98", VA = "0x135DE98")]
	public NetData_PlayerTeamSetting()
	{
	}

	[Token(Token = "0x6003108")]
	[Address(RVA = "0x135DF44", Offset = "0x135DF44", VA = "0x135DF44")]
	public NetData_PlayerTeamSetting(List<XPlayerTeamData> _liPlayerTeam)
	{
	}
}
