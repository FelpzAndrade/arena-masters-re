using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005DD")]
public class XZombieState_Play : XPVPGameModeState_Play
{
	[Token(Token = "0x20005DE")]
	private sealed class _003CSetPlayerAsZombieHostDelayed_003Ec__Iterator66 : IDisposable
	{
		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0x8")]
		internal float delay;

		[Token(Token = "0x4001C58")]
		[FieldOffset(Offset = "0xC")]
		internal int newZombieHostID;

		[Token(Token = "0x4001C59")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x18")]
		internal float _003C_0024_003Edelay;

		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003C_0024_003EnewZombieHostID;

		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x20")]
		internal XZombieState_Play _003C_003Ef__this;

		[Token(Token = "0x1700077F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003208")]
			[Address(RVA = "0x23DBBB0", Offset = "0x23DBBB0", VA = "0x23DBBB0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000780")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003209")]
			[Address(RVA = "0x23DBBB8", Offset = "0x23DBBB8", VA = "0x23DBBB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003207")]
		[Address(RVA = "0x23DB1A8", Offset = "0x23DB1A8", VA = "0x23DB1A8")]
		public _003CSetPlayerAsZombieHostDelayed_003Ec__Iterator66()
		{
		}

		[Token(Token = "0x6003208")]
		[Address(RVA = "0x23DBBB0", Offset = "0x23DBBB0", VA = "0x23DBBB0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003209")]
		[Address(RVA = "0x23DBBB8", Offset = "0x23DBBB8", VA = "0x23DBBB8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600320A")]
		[Address(RVA = "0x23DBBC0", Offset = "0x23DBBC0", VA = "0x23DBBC0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600320B")]
		[Address(RVA = "0x23DBCC0", Offset = "0x23DBCC0", VA = "0x23DBCC0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600320C")]
		[Address(RVA = "0x23DBCCC", Offset = "0x23DBCCC", VA = "0x23DBCCC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001C4E")]
	[FieldOffset(Offset = "0x24")]
	private XMasterClientCountDownMessageSender m_MasterClientCountDownMessageSender;

	[Token(Token = "0x4001C4F")]
	[FieldOffset(Offset = "0x28")]
	private PeriodUpdaterAdjustTime m_periodUpdater;

	[Token(Token = "0x4001C50")]
	[FieldOffset(Offset = "0x2C")]
	private string endCountDownSoundKey;

	[Token(Token = "0x4001C51")]
	[FieldOffset(Offset = "0x30")]
	private IEnumerator _setPlayerAsZombieHostDelayed;

	[Token(Token = "0x4001C52")]
	[FieldOffset(Offset = "0x0")]
	private static Action<float> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4001C53")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4001C54")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4001C55")]
	[FieldOffset(Offset = "0xC")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4001C56")]
	[FieldOffset(Offset = "0x10")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x23DA038", Offset = "0x23DA038", VA = "0x23DA038")]
	public XZombieState_Play()
	{
	}

	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x23DA1C0", Offset = "0x23DA1C0", VA = "0x23DA1C0", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60031F8")]
	[Address(RVA = "0x23DA520", Offset = "0x23DA520", VA = "0x23DA520")]
	private void MakeOneZombieHostOnStart()
	{
	}

	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x23DA6A4", Offset = "0x23DA6A4", VA = "0x23DA6A4")]
	private void SetPlayerAsZombieHost(int nRandPhotonID)
	{
	}

	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x23DA9C4", Offset = "0x23DA9C4", VA = "0x23DA9C4")]
	public void OnZombieHostEscaped()
	{
	}

	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x23DAE98", Offset = "0x23DAE98", VA = "0x23DAE98")]
	private void SetPlayerAsZombieHostOnZombieHostEscaped(int newZombieHostID)
	{
	}

	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x23DB0E8", Offset = "0x23DB0E8", VA = "0x23DB0E8")]
	[DebuggerHidden]
	private IEnumerator SetPlayerAsZombieHostDelayed(float delay, int newZombieHostID)
	{
		return null;
	}

	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x23DB1B0", Offset = "0x23DB1B0", VA = "0x23DB1B0", Slot = "23")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x23DB328", Offset = "0x23DB328", VA = "0x23DB328", Slot = "17")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x23DB440", Offset = "0x23DB440", VA = "0x23DB440", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003200")]
	[Address(RVA = "0x23DB568", Offset = "0x23DB568", VA = "0x23DB568")]
	public void CheckGameFinish()
	{
	}

	[Token(Token = "0x6003201")]
	[Address(RVA = "0x23DB590", Offset = "0x23DB590", VA = "0x23DB590")]
	public bool CheckGameEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x6003202")]
	[Address(RVA = "0x23DB740", Offset = "0x23DB740", VA = "0x23DB740")]
	private static void _003CXZombieState_Play_003Em__14D(float dt)
	{
	}

	[Token(Token = "0x6003203")]
	[Address(RVA = "0x23DBA90", Offset = "0x23DBA90", VA = "0x23DBA90")]
	private static bool _003COnZombieHostEscaped_003Em__14E(XPlayer p)
	{
		return default(bool);
	}

	[Token(Token = "0x6003204")]
	[Address(RVA = "0x23DBAD8", Offset = "0x23DBAD8", VA = "0x23DBAD8")]
	private static bool _003COnZombieHostEscaped_003Em__14F(XPlayer p)
	{
		return default(bool);
	}

	[Token(Token = "0x6003205")]
	[Address(RVA = "0x23DBB20", Offset = "0x23DBB20", VA = "0x23DBB20")]
	private static bool _003COnZombieHostEscaped_003Em__150(XPlayer p)
	{
		return default(bool);
	}

	[Token(Token = "0x6003206")]
	[Address(RVA = "0x23DBB68", Offset = "0x23DBB68", VA = "0x23DBB68")]
	private static bool _003COnZombieHostEscaped_003Em__151(XPlayer p)
	{
		return default(bool);
	}
}
