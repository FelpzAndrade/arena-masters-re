using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x2000519")]
public class XGameModeCooperation : XGameModePVP
{
	[Token(Token = "0x200051A")]
	private sealed class _003CChangeTeamSpectatorMode_003Ec__Iterator4B : IDisposable
	{
		[Token(Token = "0x40019D3")]
		[FieldOffset(Offset = "0x8")]
		internal XPVPGameModeState_Play _003CstatePlay_003E__0;

		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeCooperation _003C_003Ef__this;

		[Token(Token = "0x170006D3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002BCA")]
			[Address(RVA = "0x1404EDC", Offset = "0x1404EDC", VA = "0x1404EDC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BCB")]
			[Address(RVA = "0x1404EE4", Offset = "0x1404EE4", VA = "0x1404EE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x1404ED4", Offset = "0x1404ED4", VA = "0x1404ED4")]
		public _003CChangeTeamSpectatorMode_003Ec__Iterator4B()
		{
		}

		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x1404EDC", Offset = "0x1404EDC", VA = "0x1404EDC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x1404EE4", Offset = "0x1404EE4", VA = "0x1404EE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x1404EEC", Offset = "0x1404EEC", VA = "0x1404EEC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0x1405260", Offset = "0x1405260", VA = "0x1405260", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002BCE")]
		[Address(RVA = "0x140526C", Offset = "0x140526C", VA = "0x140526C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200051B")]
	private sealed class _003CXGameModeCooperation_003Ec__AnonStorey11D
	{
		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x8")]
		internal bool hasBoss;

		[Token(Token = "0x40019D8")]
		[FieldOffset(Offset = "0xC")]
		internal XGameModeCooperation _003C_003Ef__this;

		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x140481C", Offset = "0x140481C", VA = "0x140481C")]
		public _003CXGameModeCooperation_003Ec__AnonStorey11D()
		{
		}

		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x1405300", Offset = "0x1405300", VA = "0x1405300")]
		internal void _003C_003Em__119(XLevelLoader levelLoader)
		{
		}
	}

	[Token(Token = "0x40019CF")]
	public const int MAX_PLAYER = 4;

	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_Clear;

	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x80")]
	protected XLevelLoader m_levelLoader;

	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x84")]
	private LevelData m_defenseStageLevelData;

	[Token(Token = "0x170006D2")]
	public XLevelLoader LevelLoader
	{
		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x1404824", Offset = "0x1404824", VA = "0x1404824")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002BC1")]
	[Address(RVA = "0x14042DC", Offset = "0x14042DC", VA = "0x14042DC")]
	public XGameModeCooperation(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002BC3")]
	[Address(RVA = "0x140482C", Offset = "0x140482C", VA = "0x140482C")]
	public XModuleLevelObject ObjectLoader(LevelObjectData obj)
	{
		return null;
	}

	[Token(Token = "0x6002BC4")]
	[Address(RVA = "0x1404D90", Offset = "0x1404D90", VA = "0x1404D90")]
	protected void OnObjDie(XModuleLevelObject obj)
	{
	}

	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x1404D94", Offset = "0x1404D94", VA = "0x1404D94", Slot = "24")]
	public override void SetClear()
	{
	}

	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x1404DCC", Offset = "0x1404DCC", VA = "0x1404DCC", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x1404DD4", Offset = "0x1404DD4", VA = "0x1404DD4", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x1404E30", Offset = "0x1404E30", VA = "0x1404E30")]
	[DebuggerHidden]
	private IEnumerator ChangeTeamSpectatorMode()
	{
		return null;
	}
}
