using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CFD")]
public class XUIGameMode_HideAndSeek : XUIGameMode
{
	[Token(Token = "0x400421C")]
	[FieldOffset(Offset = "0x50")]
	private XPanel_HideAndSeek m_pnlHideAndSeek;

	[Token(Token = "0x400421D")]
	[FieldOffset(Offset = "0x54")]
	private IRecordUISetter recordSetter;

	[Token(Token = "0x400421E")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<string, XPlayer>, XPlayer> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400421F")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4004220")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XPlayer, int> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x6005E54")]
	[Address(RVA = "0x1A55794", Offset = "0x1A55794", VA = "0x1A55794")]
	public XUIGameMode_HideAndSeek()
	{
	}

	[Token(Token = "0x6005E55")]
	[Address(RVA = "0x1A55838", Offset = "0x1A55838", VA = "0x1A55838", Slot = "4")]
	public override void Final()
	{
	}

	[Token(Token = "0x6005E56")]
	[Address(RVA = "0x1A55854", Offset = "0x1A55854", VA = "0x1A55854", Slot = "11")]
	public override XGameModeType GetModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6005E57")]
	[Address(RVA = "0x1A5585C", Offset = "0x1A5585C", VA = "0x1A5585C", Slot = "5")]
	protected override void LoadModePrefabs()
	{
	}

	[Token(Token = "0x6005E58")]
	[Address(RVA = "0x1A55908", Offset = "0x1A55908", VA = "0x1A55908", Slot = "7")]
	public override void OnCreated()
	{
	}

	[Token(Token = "0x6005E59")]
	[Address(RVA = "0x1A55A60", Offset = "0x1A55A60", VA = "0x1A55A60", Slot = "9")]
	public override void OnDelayShow()
	{
	}

	[Token(Token = "0x6005E5A")]
	[Address(RVA = "0x1A55B24", Offset = "0x1A55B24", VA = "0x1A55B24", Slot = "47")]
	public override void ShowGameUI(bool bShow, float fadein = 0f)
	{
	}

	[Token(Token = "0x6005E5B")]
	[Address(RVA = "0x1A55B70", Offset = "0x1A55B70", VA = "0x1A55B70", Slot = "14")]
	public override void RefreshRankRecord()
	{
	}

	[Token(Token = "0x6005E5C")]
	[Address(RVA = "0x1A55CEC", Offset = "0x1A55CEC", VA = "0x1A55CEC", Slot = "51")]
	public override void RefreshGameUI()
	{
	}

	[Token(Token = "0x6005E5D")]
	[Address(RVA = "0x1A55F28", Offset = "0x1A55F28", VA = "0x1A55F28", Slot = "21")]
	public override void RefreshGameModeStatus()
	{
	}

	[Token(Token = "0x6005E5E")]
	[Address(RVA = "0x1A55E40", Offset = "0x1A55E40", VA = "0x1A55E40")]
	private void SetTrackingTaggerPlayer()
	{
	}

	[Token(Token = "0x6005E5F")]
	[Address(RVA = "0x1A55F44", Offset = "0x1A55F44", VA = "0x1A55F44")]
	private bool isMyStateSpectator()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E60")]
	[Address(RVA = "0x1A56024", Offset = "0x1A56024", VA = "0x1A56024", Slot = "59")]
	public override void SetTeamSpectatorMode(bool isEnable)
	{
	}

	[Token(Token = "0x6005E61")]
	[Address(RVA = "0x1A56074", Offset = "0x1A56074", VA = "0x1A56074", Slot = "8")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6005E62")]
	[Address(RVA = "0x1A56184", Offset = "0x1A56184", VA = "0x1A56184", Slot = "6")]
	public override void OnShowUI(bool bShow)
	{
	}

	[Token(Token = "0x6005E63")]
	[Address(RVA = "0x1A56094", Offset = "0x1A56094", VA = "0x1A56094")]
	public void ShowPanelDeath(bool bShow)
	{
	}

	[Token(Token = "0x6005E64")]
	[Address(RVA = "0x1A561A8", Offset = "0x1A561A8", VA = "0x1A561A8", Slot = "45")]
	protected override int GetRankForAIMode(XPlayerManager pm)
	{
		return default(int);
	}

	[Token(Token = "0x6005E65")]
	[Address(RVA = "0x1A56858", Offset = "0x1A56858", VA = "0x1A56858", Slot = "27")]
	public override void OnRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6005E66")]
	[Address(RVA = "0x1A5688C", Offset = "0x1A5688C", VA = "0x1A5688C", Slot = "26")]
	public override void OnMyRecordEvent(RecordEvent recordEvent)
	{
	}

	[Token(Token = "0x6005E67")]
	[Address(RVA = "0x1A568C0", Offset = "0x1A568C0", VA = "0x1A568C0")]
	private static XPlayer _003CGetRankForAIMode_003Em__2A6(KeyValuePair<string, XPlayer> item)
	{
		return null;
	}

	[Token(Token = "0x6005E68")]
	[Address(RVA = "0x1A5694C", Offset = "0x1A5694C", VA = "0x1A5694C")]
	private static int _003CGetRankForAIMode_003Em__2A7(XPlayer x)
	{
		return default(int);
	}

	[Token(Token = "0x6005E69")]
	[Address(RVA = "0x1A56A40", Offset = "0x1A56A40", VA = "0x1A56A40")]
	private static int _003CGetRankForAIMode_003Em__2A8(XPlayer x)
	{
		return default(int);
	}
}
