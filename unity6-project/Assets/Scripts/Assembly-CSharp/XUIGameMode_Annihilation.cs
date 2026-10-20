using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CF4")]
public class XUIGameMode_Annihilation : XUIGameMode
{
	[Token(Token = "0x4004211")]
	[FieldOffset(Offset = "0x50")]
	protected XPanel_Annihilation m_pnlAnnihilation;

	[Token(Token = "0x4004212")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<MatchPlayerInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004213")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<MatchPlayerInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6005DF9")]
	[Address(RVA = "0x1A51D58", Offset = "0x1A51D58", VA = "0x1A51D58")]
	public XUIGameMode_Annihilation()
	{
	}

	[Token(Token = "0x6005DFA")]
	[Address(RVA = "0x1A51D68", Offset = "0x1A51D68", VA = "0x1A51D68", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005DFB")]
	[Address(RVA = "0x1A51D84", Offset = "0x1A51D84", VA = "0x1A51D84", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005DFC")]
	[Address(RVA = "0x1A51D8C", Offset = "0x1A51D8C", VA = "0x1A51D8C", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005DFD")]
	[Address(RVA = "0x1A51E38", Offset = "0x1A51E38", VA = "0x1A51E38", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005DFE")]
	[Address(RVA = "0x1A51F48", Offset = "0x1A51F48", VA = "0x1A51F48", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005DFF")]
	[Address(RVA = "0x1A51F94", Offset = "0x1A51F94", VA = "0x1A51F94", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E00")]
	[Address(RVA = "0x1A520B8", Offset = "0x1A520B8", VA = "0x1A520B8", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005E01")]
	[Address(RVA = "0x1A520DC", Offset = "0x1A520DC", VA = "0x1A520DC", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005E02")]
	[Address(RVA = "0x1A52218", Offset = "0x1A52218", VA = "0x1A52218")]
	private void BuildClanInfo(List<MatchPlayerInfo> liMatchPlayerInfo)
	{
	}

	[Token(Token = "0x6005E03")]
	[Address(RVA = "0x1A52A34", Offset = "0x1A52A34", VA = "0x1A52A34")]
	private void BuildClanInfo(MatchPlayerInfo clanInfo, XTeamEnum teamEnum)
	{
	}

	[Token(Token = "0x6005E04")]
	[Address(RVA = "0x1A51FB4", Offset = "0x1A51FB4", VA = "0x1A51FB4")]
	private void ShowPanelAnnihilation(bool bShow)
	{
	}

	[Token(Token = "0x6005E05")]
	[Address(RVA = "0x1A52B40", Offset = "0x1A52B40", VA = "0x1A52B40", Slot = "55")]
	public override void RefreshTopUI()
	{
	}

	[Token(Token = "0x6005E06")]
	[Address(RVA = "0x1A52D68", Offset = "0x1A52D68", VA = "0x1A52D68", Slot = "52")]
	public override void RefreshGameLifeUI()
	{
	}

	[Token(Token = "0x6005E07")]
	[Address(RVA = "0x1A52F50", Offset = "0x1A52F50", VA = "0x1A52F50", Slot = "66")]
	protected override int GetCurrentRound()
	{
		return default(int);
	}

	[Token(Token = "0x6005E08")]
	[Address(RVA = "0x1A53044", Offset = "0x1A53044", VA = "0x1A53044")]
	private static bool _003CBuildClanInfo_003Em__2A1(MatchPlayerInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E09")]
	[Address(RVA = "0x1A53070", Offset = "0x1A53070", VA = "0x1A53070")]
	private static bool _003CBuildClanInfo_003Em__2A2(MatchPlayerInfo item)
	{
		return default(bool);
	}
}
