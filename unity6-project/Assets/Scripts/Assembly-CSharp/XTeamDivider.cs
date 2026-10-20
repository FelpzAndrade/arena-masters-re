using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20005D7")]
public class XTeamDivider
{
	[Token(Token = "0x20005D8")]
	private sealed class _003CGetDivideTeamCanEnoughParty_003Ec__AnonStorey123
	{
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x8")]
		internal List<NetMatchPlayerInfo> memberInfo;

		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x18471F8", Offset = "0x18471F8", VA = "0x18471F8")]
		public _003CGetDivideTeamCanEnoughParty_003Ec__AnonStorey123()
		{
		}
	}

	[Token(Token = "0x20005D9")]
	private sealed class _003CGetDivideTeamCanEnoughParty_003Ec__AnonStorey124
	{
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0xC")]
		internal _003CGetDivideTeamCanEnoughParty_003Ec__AnonStorey123 _003C_003Ef__ref_0024291;

		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x1847200", Offset = "0x1847200", VA = "0x1847200")]
		public _003CGetDivideTeamCanEnoughParty_003Ec__AnonStorey124()
		{
		}

		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x184781C", Offset = "0x184781C", VA = "0x184781C")]
		internal bool _003C_003Em__149(XPlayer item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001C40")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XPlayer, XPlayerTeamData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4001C41")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, XPlayerTeamData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4001C42")]
	[FieldOffset(Offset = "0x8")]
	private static Func<KeyValuePair<string, XPlayer>, short> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4001C43")]
	[FieldOffset(Offset = "0xC")]
	private static Func<KeyValuePair<string, XPlayer>, XPlayer> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4001C44")]
	[FieldOffset(Offset = "0x10")]
	private static Func<XPlayer, XPlayerTeamData> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4001C45")]
	[FieldOffset(Offset = "0x14")]
	private static Func<XPlayer, short> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4001C46")]
	[FieldOffset(Offset = "0x18")]
	private static Func<XPlayer, XPlayerTeamData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4001C47")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<XPlayer, XPlayerTeamData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x1824D38", Offset = "0x1824D38", VA = "0x1824D38")]
	public XTeamDivider()
	{
	}

	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x1824D40", Offset = "0x1824D40", VA = "0x1824D40")]
	public NetData_PlayerTeamSetting GetDivideTeamInfo()
	{
		return null;
	}

	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x1845C90", Offset = "0x1845C90", VA = "0x1845C90")]
	protected List<XPlayerTeamData> GetFriendlyMatchTeam(XPlayerManager clonePlayerManager)
	{
		return null;
	}

	[Token(Token = "0x60031CB")]
	[Address(RVA = "0x1846720", Offset = "0x1846720", VA = "0x1846720")]
	private void SetTeamSettingInFriendlyMatch(ref List<XPlayer> liPlayer)
	{
	}

	[Token(Token = "0x60031CC")]
	[Address(RVA = "0x1846388", Offset = "0x1846388", VA = "0x1846388")]
	protected List<XPlayerTeamData> GetDoNotDivideTeam()
	{
		return null;
	}

	[Token(Token = "0x60031CD")]
	[Address(RVA = "0x1845E38", Offset = "0x1845E38", VA = "0x1845E38")]
	protected List<XPlayerTeamData> GetDivideAllATeam(XPlayerManager clonePlayerManager)
	{
		return null;
	}

	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x1846424", Offset = "0x1846424", VA = "0x1846424")]
	protected List<XPlayerTeamData> GetDivideTeamFromClientMaster(XPlayerManager clonePlayerManager)
	{
		return null;
	}

	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x1846218", Offset = "0x1846218", VA = "0x1846218")]
	protected List<XPlayerTeamData> GetDivideTeamFromFriendParty(XPlayerManager clonePlayerManager, DTPartyInfo partyInfo)
	{
		return null;
	}

	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x1846B40", Offset = "0x1846B40", VA = "0x1846B40")]
	private List<XPlayerTeamData> GetDivideTeamCanEnoughParty(XPlayerManager clonePlayerManager, List<NetMatchPlayerInfo> memberInfo)
	{
		return null;
	}

	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x1845FC4", Offset = "0x1845FC4", VA = "0x1845FC4")]
	protected List<XPlayerTeamData> GetDivideTeamFromServerMatching(XPlayerManager clonePlayerManager, List<MatchPlayerInfo> liPlayer)
	{
		return null;
	}

	[Token(Token = "0x60031D2")]
	[Address(RVA = "0x18468D4", Offset = "0x18468D4", VA = "0x18468D4")]
	public void SetDivideTeamByOrder(ref List<KeyValuePair<string, XPlayer>> sortedList)
	{
	}

	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x1847208", Offset = "0x1847208", VA = "0x1847208")]
	private static XPlayerTeamData _003CGetFriendlyMatchTeam_003Em__143(XPlayer item)
	{
		return null;
	}

	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x18472D0", Offset = "0x18472D0", VA = "0x18472D0")]
	private static XPlayerTeamData _003CGetDivideAllATeam_003Em__144(XPlayer item)
	{
		return null;
	}

	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x1847380", Offset = "0x1847380", VA = "0x1847380")]
	private static short _003CGetDivideTeamFromClientMaster_003Em__145(KeyValuePair<string, XPlayer> e)
	{
		return default(short);
	}

	[Token(Token = "0x60031D6")]
	[Address(RVA = "0x1847488", Offset = "0x1847488", VA = "0x1847488")]
	private static XPlayer _003CGetDivideTeamFromClientMaster_003Em__146(KeyValuePair<string, XPlayer> item)
	{
		return null;
	}

	[Token(Token = "0x60031D7")]
	[Address(RVA = "0x1847514", Offset = "0x1847514", VA = "0x1847514")]
	private static XPlayerTeamData _003CGetDivideTeamFromClientMaster_003Em__147(XPlayer item)
	{
		return null;
	}

	[Token(Token = "0x60031D8")]
	[Address(RVA = "0x18475DC", Offset = "0x18475DC", VA = "0x18475DC")]
	private static short _003CGetDivideTeamCanEnoughParty_003Em__148(XPlayer e)
	{
		return default(short);
	}

	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x18476BC", Offset = "0x18476BC", VA = "0x18476BC")]
	private static XPlayerTeamData _003CGetDivideTeamCanEnoughParty_003Em__14A(XPlayer item)
	{
		return null;
	}

	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x184776C", Offset = "0x184776C", VA = "0x184776C")]
	private static XPlayerTeamData _003CGetDivideTeamCanEnoughParty_003Em__14B(XPlayer item)
	{
		return null;
	}
}
