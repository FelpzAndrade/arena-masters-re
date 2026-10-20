using System;
using CS;
using Il2CppDummyDll;
using XLevel;

[Token(Token = "0x2000594")]
public class XGameModePVE : XGameMode
{
		protected XGameModePVE()
		{
		}

	[Token(Token = "0x2000595")]
	private sealed class _003CXGameModePVE_003Ec__AnonStorey11F
	{
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x8")]
		internal bool hasBoss;

		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0xC")]
		internal XGameModePVE _003C_003Ef__this;

		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x1410C28", Offset = "0x1410C28", VA = "0x1410C28")]
		public _003CXGameModePVE_003Ec__AnonStorey11F()
		{
		}

		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x141130C", Offset = "0x141130C", VA = "0x141130C")]
		internal void _003C_003Em__12B(XLevelLoader levelLoader)
		{
		}
	}

	[Token(Token = "0x4001B54")]
	[FieldOffset(Offset = "0x78")]
	protected XLevelLoader m_levelLoader;

	[Token(Token = "0x4001B55")]
	[FieldOffset(Offset = "0x7C")]
	protected CSStageInfo m_info;

	[Token(Token = "0x4001B56")]
	[FieldOffset(Offset = "0x80")]
	protected bool m_Clear;

	[Token(Token = "0x4001B57")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x1700075F")]
	public XLevelLoader LevelLoader
	{
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x140EA84", Offset = "0x140EA84", VA = "0x140EA84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000760")]
	public override bool IsCleared
	{
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x1410C64", Offset = "0x1410C64", VA = "0x1410C64", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000761")]
	public override float GameFullTime
	{
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x1410C6C", Offset = "0x1410C6C", VA = "0x1410C6C", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x140DE40", Offset = "0x140DE40", VA = "0x140DE40")]
	public XGameModePVE(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x1410C30", Offset = "0x1410C30", VA = "0x1410C30", Slot = "24")]
	public override void SetClear()
	{
	}

	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x140EA8C", Offset = "0x140EA8C", VA = "0x140EA8C", Slot = "48")]
	public virtual XModuleLevelObject ObjectLoader(LevelObjectData obj)
	{
		return null;
	}

	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x1410DBC", Offset = "0x1410DBC", VA = "0x1410DBC", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002FD2")]
	[Address(RVA = "0x140F3D0", Offset = "0x140F3D0", VA = "0x140F3D0", Slot = "49")]
	protected virtual void OnObjDie(XModuleLevelObject obj)
	{
	}

	[Token(Token = "0x6002FD3")]
	[Address(RVA = "0x1411044", Offset = "0x1411044", VA = "0x1411044", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x141104C", Offset = "0x141104C", VA = "0x141104C", Slot = "11")]
	public override void OnGameInit()
	{
	}

	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x1411240", Offset = "0x1411240", VA = "0x1411240")]
	private static void _003COnMyDie_003Em__12C()
	{
	}
}
