using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005F6")]
public class XZombieTagState_CountDown : XPVPGameModeState_CountDown
{
	[Token(Token = "0x20005F7")]
	private sealed class _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator6D : IDisposable
	{
		[Token(Token = "0x4001CB2")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001CB4")]
		[FieldOffset(Offset = "0x10")]
		internal XZombieTagState_CountDown _003C_003Ef__this;

		[Token(Token = "0x17000796")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60032E2")]
			[Address(RVA = "0x23E007C", Offset = "0x23E007C", VA = "0x23E007C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000797")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032E3")]
			[Address(RVA = "0x23E0084", Offset = "0x23E0084", VA = "0x23E0084", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x23DE59C", Offset = "0x23DE59C", VA = "0x23DE59C")]
		public _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator6D()
		{
		}

		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x23E007C", Offset = "0x23E007C", VA = "0x23E007C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x23E0084", Offset = "0x23E0084", VA = "0x23E0084", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x23E008C", Offset = "0x23E008C", VA = "0x23E008C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x23E0240", Offset = "0x23E0240", VA = "0x23E0240", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x23E024C", Offset = "0x23E024C", VA = "0x23E024C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20005F8")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator6E : IDisposable
	{
		[Token(Token = "0x4001CB5")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001CB6")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001CB8")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001CB9")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001CBA")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001CBB")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001CBC")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x17000798")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60032E8")]
			[Address(RVA = "0x23DFE44", Offset = "0x23DFE44", VA = "0x23DFE44", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000799")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032E9")]
			[Address(RVA = "0x23DFE4C", Offset = "0x23DFE4C", VA = "0x23DFE4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x23DE870", Offset = "0x23DE870", VA = "0x23DE870")]
		public _003CRepositionMyPlayer_003Ec__Iterator6E()
		{
		}

		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x23DFE44", Offset = "0x23DFE44", VA = "0x23DFE44", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x23DFE4C", Offset = "0x23DFE4C", VA = "0x23DFE4C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x23DFE54", Offset = "0x23DFE54", VA = "0x23DFE54", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x23DFFDC", Offset = "0x23DFFDC", VA = "0x23DFFDC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60032EC")]
		[Address(RVA = "0x23DFFE8", Offset = "0x23DFFE8", VA = "0x23DFFE8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20005F9")]
	private sealed class _003CDivideTeam_003Ec__AnonStorey125
	{
		[Token(Token = "0x4001CBD")]
		[FieldOffset(Offset = "0x8")]
		internal XTeamEnum t;

		[Token(Token = "0x60032ED")]
		[Address(RVA = "0x23DDBE8", Offset = "0x23DDBE8", VA = "0x23DDBE8")]
		public _003CDivideTeam_003Ec__AnonStorey125()
		{
		}

		[Token(Token = "0x60032EE")]
		[Address(RVA = "0x23DF478", Offset = "0x23DF478", VA = "0x23DF478")]
		internal void _003C_003Em__154(KeyValuePair<string, XPlayer> e)
		{
		}

		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x23DF7BC", Offset = "0x23DF7BC", VA = "0x23DF7BC")]
		internal void _003C_003Em__155(KeyValuePair<string, XPlayer> e)
		{
		}

		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x23DFB00", Offset = "0x23DFB00", VA = "0x23DFB00")]
		internal void _003C_003Em__15E(KeyValuePair<string, XPlayer> e)
		{
		}
	}

	[Token(Token = "0x4001CA5")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<string, XPlayer>, short> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4001CA6")]
	[FieldOffset(Offset = "0x4")]
	private static Action<KeyValuePair<string, XPlayer>> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0x8")]
	private static Func<KeyValuePair<string, XPlayer>, XTeamEnum> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4001CA8")]
	[FieldOffset(Offset = "0xC")]
	private static Func<IGrouping<XTeamEnum, KeyValuePair<string, XPlayer>>, _003C_003E__AnonType1<XTeamEnum, double>> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4001CA9")]
	[FieldOffset(Offset = "0x10")]
	private static Func<_003C_003E__AnonType1<XTeamEnum, double>, bool> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0x14")]
	private static Func<_003C_003E__AnonType1<XTeamEnum, double>, double> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x18")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<KeyValuePair<string, XPlayer>, KeyValuePair<string, XPlayer>> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0x20")]
	private static Func<KeyValuePair<string, XPlayer>, bool> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0x24")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4001CAF")]
	[FieldOffset(Offset = "0x28")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4001CB0")]
	[FieldOffset(Offset = "0x2C")]
	private static Func<KeyValuePair<string, XPlayer>, XPlayer> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x4001CB1")]
	[FieldOffset(Offset = "0x30")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x23DCA6C", Offset = "0x23DCA6C", VA = "0x23DCA6C")]
	public XZombieTagState_CountDown()
	{
	}

	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x23DCA74", Offset = "0x23DCA74", VA = "0x23DCA74", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60032CB")]
	[Address(RVA = "0x23DCCCC", Offset = "0x23DCCCC", VA = "0x23DCCCC", Slot = "20")]
	protected virtual void DevideIntoTeam()
	{
	}

	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x23DD118", Offset = "0x23DD118", VA = "0x23DD118")]
	private void DivideMatchingInfoTeam(List<XPlayer> liPlayer)
	{
	}

	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x23DD11C", Offset = "0x23DD11C", VA = "0x23DD11C")]
	private void DivideTeam(ref List<KeyValuePair<string, XPlayer>> list)
	{
	}

	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x23DDBF0", Offset = "0x23DDBF0", VA = "0x23DDBF0")]
	private void MakePlayersTeam()
	{
	}

	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x23DE2A0", Offset = "0x23DE2A0", VA = "0x23DE2A0")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeam, bool onReconnect)
	{
	}

	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x23DCC28", Offset = "0x23DCC28", VA = "0x23DCC28")]
	[DebuggerHidden]
	private IEnumerator RespawnMyPlayerOnRoundStart()
	{
		return null;
	}

	[Token(Token = "0x60032D1")]
	[Address(RVA = "0x23DE5A4", Offset = "0x23DE5A4", VA = "0x23DE5A4")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x23DE6E0", Offset = "0x23DE6E0", VA = "0x23DE6E0")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x23DE7AC", Offset = "0x23DE7AC", VA = "0x23DE7AC")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}

	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x23DE878", Offset = "0x23DE878", VA = "0x23DE878")]
	private static short _003CDevideIntoTeam_003Em__152(KeyValuePair<string, XPlayer> e)
	{
		return default(short);
	}

	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x23DE980", Offset = "0x23DE980", VA = "0x23DE980")]
	private static void _003CDivideTeam_003Em__153(KeyValuePair<string, XPlayer> e)
	{
	}

	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x23DECA4", Offset = "0x23DECA4", VA = "0x23DECA4")]
	private static XTeamEnum _003CDivideTeam_003Em__156(KeyValuePair<string, XPlayer> e)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x60032D7")]
	[Address(RVA = "0x23DED54", Offset = "0x23DED54", VA = "0x23DED54")]
	private static _003C_003E__AnonType1<XTeamEnum, double> _003CDivideTeam_003Em__157(IGrouping<XTeamEnum, KeyValuePair<string, XPlayer>> n)
	{
		return null;
	}

	[Token(Token = "0x60032D8")]
	[Address(RVA = "0x23DEF68", Offset = "0x23DEF68", VA = "0x23DEF68")]
	private static bool _003CDivideTeam_003Em__158(_003C_003E__AnonType1<XTeamEnum, double> e)
	{
		return default(bool);
	}

	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x23DF008", Offset = "0x23DF008", VA = "0x23DF008")]
	private static double _003CDivideTeam_003Em__159(_003C_003E__AnonType1<XTeamEnum, double> n)
	{
		return default(double);
	}

	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x23DF0A0", Offset = "0x23DF0A0", VA = "0x23DF0A0")]
	private static int _003CDivideTeam_003Em__15A(KeyValuePair<string, XPlayer> e)
	{
		return default(int);
	}

	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x23DF140", Offset = "0x23DF140", VA = "0x23DF140")]
	private static KeyValuePair<string, XPlayer> _003CDivideTeam_003Em__15B(KeyValuePair<string, XPlayer> e)
	{
		return default(KeyValuePair<string, XPlayer>);
	}

	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x23DF148", Offset = "0x23DF148", VA = "0x23DF148")]
	private static bool _003CDivideTeam_003Em__15C(KeyValuePair<string, XPlayer> e)
	{
		return default(bool);
	}

	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x23DF20C", Offset = "0x23DF20C", VA = "0x23DF20C")]
	private static int _003CDivideTeam_003Em__15D(KeyValuePair<string, XPlayer> e)
	{
		return default(int);
	}

	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x23DF2AC", Offset = "0x23DF2AC", VA = "0x23DF2AC")]
	private static int _003CMakePlayersTeam_003Em__15F(KeyValuePair<string, XPlayer> elem)
	{
		return default(int);
	}

	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x23DF34C", Offset = "0x23DF34C", VA = "0x23DF34C")]
	private static XPlayer _003CMakePlayersTeam_003Em__160(KeyValuePair<string, XPlayer> elem)
	{
		return null;
	}

	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x23DF3D8", Offset = "0x23DF3D8", VA = "0x23DF3D8")]
	private static int _003CDivideTeam_003Em__161(KeyValuePair<string, XPlayer> x)
	{
		return default(int);
	}
}
