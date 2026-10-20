using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000523")]
public class XHideAndSeekState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x2000524")]
	private enum RemainTImeSound
	{
		[Token(Token = "0x40019FC")]
		None = 0,
		[Token(Token = "0x40019FD")]
		Ready = 1,
		[Token(Token = "0x40019FE")]
		Done = 2
	}

	[Token(Token = "0x40019ED")]
	private const float m_taggerCheckTime = 2.5f;

	[Token(Token = "0x40019EE")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x40019EF")]
	[FieldOffset(Offset = "0x28")]
	private PeriodUpdaterAdjustTime m_periodUpdater;

	[Token(Token = "0x40019F0")]
	[FieldOffset(Offset = "0x2C")]
	private string endCountDownSoundKey;

	[Token(Token = "0x40019F1")]
	[FieldOffset(Offset = "0x30")]
	private XHideAndSeekRule m_Rule;

	[Token(Token = "0x40019F2")]
	[FieldOffset(Offset = "0x34")]
	private List<XHelper.XIntervalUpdater> intervalTimers;

	[Token(Token = "0x40019F3")]
	[FieldOffset(Offset = "0x38")]
	private CSSectorInfo m_sectorInfo;

	[Token(Token = "0x40019F4")]
	[FieldOffset(Offset = "0x3C")]
	private RemainTImeSound m_eRemainTimeState;

	[Token(Token = "0x40019F5")]
	[FieldOffset(Offset = "0x40")]
	private string endEffectSoundKey;

	[Token(Token = "0x40019F6")]
	[FieldOffset(Offset = "0x44")]
	private int effectDelayTime;

	[Token(Token = "0x40019F7")]
	[FieldOffset(Offset = "0x48")]
	private readonly float m_sendHumanAliveScoreIntervalTime;

	[Token(Token = "0x40019F8")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_bStartTaggerCheck;

	[Token(Token = "0x40019F9")]
	[FieldOffset(Offset = "0x50")]
	private float m_taggerCheckElapsedTime;

	[Token(Token = "0x40019FA")]
	[FieldOffset(Offset = "0x0")]
	private static Action<float> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x1D20070", Offset = "0x1D20070", VA = "0x1D20070")]
	public XHideAndSeekState_Play()
	{
	}

	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x1D203BC", Offset = "0x1D203BC", VA = "0x1D203BC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x1D20A88", Offset = "0x1D20A88", VA = "0x1D20A88")]
	public void MakeTaggerHostOnStart(int ignoreChoosePhotonID = -1, int itemID = 0, bool isDieEvent = false)
	{
	}

	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x1D20CB8", Offset = "0x1D20CB8", VA = "0x1D20CB8")]
	private void SetTaggerHost(int nRandPhotonID, int itemID)
	{
	}

	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x1D20F98", Offset = "0x1D20F98", VA = "0x1D20F98", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x1D2134C", Offset = "0x1D2134C", VA = "0x1D2134C")]
	private void UpdatePeriodList()
	{
	}

	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x1D2125C", Offset = "0x1D2125C", VA = "0x1D2125C")]
	private void UpdateIntervalTimers()
	{
	}

	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x1D211F0", Offset = "0x1D211F0", VA = "0x1D211F0")]
	private void UpdateTaggerCheckTimer()
	{
	}

	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x1D210E8", Offset = "0x1D210E8", VA = "0x1D210E8")]
	private void UpdatePlayEffectBGM_Timer(int fullTime, int remainTime)
	{
	}

	[Token(Token = "0x6002C0D")]
	[Address(RVA = "0x1D2162C", Offset = "0x1D2162C", VA = "0x1D2162C")]
	public void ActiveTaggerCheckTimer()
	{
	}

	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x1D213AC", Offset = "0x1D213AC", VA = "0x1D213AC")]
	private bool CheckNonTagger()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x1D21640", Offset = "0x1D21640", VA = "0x1D21640")]
	private bool SendHpRatio()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x1D21798", Offset = "0x1D21798", VA = "0x1D21798", Slot = "14")]
	public override void OnBeforeFinish()
	{
	}

	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x1D21A44", Offset = "0x1D21A44", VA = "0x1D21A44")]
	public new void SetPlayerState(CSPlayerState state)
	{
	}

	[Token(Token = "0x6002C12")]
	[Address(RVA = "0x1D21B58", Offset = "0x1D21B58", VA = "0x1D21B58", Slot = "9")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6002C13")]
	[Address(RVA = "0x1D21BFC", Offset = "0x1D21BFC", VA = "0x1D21BFC")]
	private static void _003CXHideAndSeekState_Play_003Em__11A(float dt)
	{
	}
}
