using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XLevel;

[Token(Token = "0x20004D8")]
public class XGameManager
{
	[Token(Token = "0x20004D9")]
	private sealed class _003COnCloseUpBoss_003Ec__Iterator3D : IDisposable
	{
		[Token(Token = "0x4001883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleLevelObject boss;

		[Token(Token = "0x4001884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XModuleActor _003Cactor_003E__0;

		[Token(Token = "0x4001885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float _003CaniLength_003E__1;

		[Token(Token = "0x4001886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal CSSkillInfo _003CskillInfo_003E__2;

		[Token(Token = "0x4001887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x4001888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x4001889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal XModuleLevelObject _003C_0024_003Eboss;

		[Token(Token = "0x400188A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal XGameManager _003C_003Ef__this;

		[Token(Token = "0x1700069D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A22")]
			[Address(RVA = "0x13FA074", Offset = "0x13FA074", VA = "0x13FA074", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700069E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A23")]
			[Address(RVA = "0x13FA07C", Offset = "0x13FA07C", VA = "0x13FA07C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x13EE020", Offset = "0x13EE020", VA = "0x13EE020")]
		public _003COnCloseUpBoss_003Ec__Iterator3D()
		{
		}

		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x13FA074", Offset = "0x13FA074", VA = "0x13FA074", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x13FA07C", Offset = "0x13FA07C", VA = "0x13FA07C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x13FA084", Offset = "0x13FA084", VA = "0x13FA084", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x13FA460", Offset = "0x13FA460", VA = "0x13FA460", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x13FA46C", Offset = "0x13FA46C", VA = "0x13FA46C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x13FA500", Offset = "0x13FA500", VA = "0x13FA500")]
		internal void _003C_003Em__105()
		{
		}

		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x13FA760", Offset = "0x13FA760", VA = "0x13FA760")]
		internal void _003C_003Em__106()
		{
		}
	}

	[Token(Token = "0x20004DA")]
	private sealed class _003CInitGame_003Ec__Iterator3E : IDisposable
	{
		[Token(Token = "0x400188B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x400188C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400188D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XGameManager _003C_003Ef__this;

		[Token(Token = "0x1700069F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A2A")]
			[Address(RVA = "0x13F86A0", Offset = "0x13F86A0", VA = "0x13F86A0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A2B")]
			[Address(RVA = "0x13F86A8", Offset = "0x13F86A8", VA = "0x13F86A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x13EFB98", Offset = "0x13EFB98", VA = "0x13EFB98")]
		public _003CInitGame_003Ec__Iterator3E()
		{
		}

		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x13F86A0", Offset = "0x13F86A0", VA = "0x13F86A0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x13F86A8", Offset = "0x13F86A8", VA = "0x13F86A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x13F86B0", Offset = "0x13F86B0", VA = "0x13F86B0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x13F8918", Offset = "0x13F8918", VA = "0x13F8918", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x13F8924", Offset = "0x13F8924", VA = "0x13F8924", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20004DB")]
	private sealed class _003CInitGameOnce_003Ec__Iterator3F : IDisposable
	{
		[Token(Token = "0x400188E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XGameMode _003CgameMode_003E__0;

		[Token(Token = "0x400188F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal CSSectorInfo _003CsectorInfo_003E__1;

		[Token(Token = "0x4001890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4001891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4001892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal XGameManager _003C_003Ef__this;

		[Token(Token = "0x170006A1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A30")]
			[Address(RVA = "0x13F89B8", Offset = "0x13F89B8", VA = "0x13F89B8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A31")]
			[Address(RVA = "0x13F89C0", Offset = "0x13F89C0", VA = "0x13F89C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x13F239C", Offset = "0x13F239C", VA = "0x13F239C")]
		public _003CInitGameOnce_003Ec__Iterator3F()
		{
		}

		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x13F89B8", Offset = "0x13F89B8", VA = "0x13F89B8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x13F89C0", Offset = "0x13F89C0", VA = "0x13F89C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x13F89C8", Offset = "0x13F89C8", VA = "0x13F89C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x13F920C", Offset = "0x13F920C", VA = "0x13F920C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x13F9218", Offset = "0x13F9218", VA = "0x13F9218", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20004DC")]
	private sealed class _003CInitMap_003Ec__Iterator40 : IDisposable
	{
		[Token(Token = "0x4001893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal CSSectorInfo _003CsectorInfo_003E__0;

		[Token(Token = "0x4001894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XGameManager _003C_003Ef__this;

		[Token(Token = "0x170006A3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A36")]
			[Address(RVA = "0x13F92AC", Offset = "0x13F92AC", VA = "0x13F92AC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A37")]
			[Address(RVA = "0x13F92B4", Offset = "0x13F92B4", VA = "0x13F92B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x13F2448", Offset = "0x13F2448", VA = "0x13F2448")]
		public _003CInitMap_003Ec__Iterator40()
		{
		}

		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x13F92AC", Offset = "0x13F92AC", VA = "0x13F92AC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A37")]
		[Address(RVA = "0x13F92B4", Offset = "0x13F92B4", VA = "0x13F92B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x13F92BC", Offset = "0x13F92BC", VA = "0x13F92BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x13F94E0", Offset = "0x13F94E0", VA = "0x13F94E0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x13F94EC", Offset = "0x13F94EC", VA = "0x13F94EC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20004DD")]
	private sealed class _003CLoadPreResources_003Ec__Iterator41 : IDisposable
	{
		[Token(Token = "0x4001897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XResourcePreLoader _003Cloader_003E__0;

		[Token(Token = "0x4001898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XMyInfo _003CmyInfo_003E__1;

		[Token(Token = "0x4001899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XCharParty _003CmySelCharParty_003E__2;

		[Token(Token = "0x400189A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _003CmaxPartyMember_003E__3;

		[Token(Token = "0x400189B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int _003Ci_003E__4;

		[Token(Token = "0x400189C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal XModuleActor _003CmoduleActor_003E__5;

		[Token(Token = "0x400189D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal XModuleActor.CreationDesc _003Cdesc_003E__6;

		[Token(Token = "0x400189E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal CSStageInfo _003Cinfo_003E__7;

		[Token(Token = "0x400189F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LevelData _003ClevelData_003E__8;

		[Token(Token = "0x40018A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal Dictionary<int, int> _003CmonsterCount_003E__9;

		[Token(Token = "0x40018A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal List<XModuleActor.CreationDesc> _003CotherPlayerDescs_003E__10;

		[Token(Token = "0x40018A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal PhotonPlayer[] _003Cothers_003E__11;

		[Token(Token = "0x40018A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int _003Ci_003E__12;

		[Token(Token = "0x40018A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal PhotonPlayer _003Cother_003E__13;

		[Token(Token = "0x40018A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Netdata_CreationDesc _003CdescNetdata_003E__14;

		[Token(Token = "0x40018A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal XModuleActor.CreationDesc _003Cdesc_003E__15;

		[Token(Token = "0x40018A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal CSSectorInfo _003CsectorInfo_003E__16;

		[Token(Token = "0x40018A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal CSSectorInfo _003CsectorInfo_003E__17;

		[Token(Token = "0x40018A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int _0024PC;

		[Token(Token = "0x40018AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x170006A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A3C")]
			[Address(RVA = "0x13F9580", Offset = "0x13F9580", VA = "0x13F9580", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A3D")]
			[Address(RVA = "0x13F9588", Offset = "0x13F9588", VA = "0x13F9588", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x13F565C", Offset = "0x13F565C", VA = "0x13F565C")]
		public _003CLoadPreResources_003Ec__Iterator41()
		{
		}

		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x13F9580", Offset = "0x13F9580", VA = "0x13F9580", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x13F9588", Offset = "0x13F9588", VA = "0x13F9588", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x13F9590", Offset = "0x13F9590", VA = "0x13F9590", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x13F9FD4", Offset = "0x13F9FD4", VA = "0x13F9FD4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x13F9FE0", Offset = "0x13F9FE0", VA = "0x13F9FE0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20004DE")]
	private sealed class _003CPlayBossDirection_003Ec__AnonStorey113
	{
		[Token(Token = "0x40018AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleLevelObject boss;

		[Token(Token = "0x40018AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XGameManager _003C_003Ef__this;

		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x13EDD44", Offset = "0x13EDD44", VA = "0x13EDD44")]
		public _003CPlayBossDirection_003Ec__AnonStorey113()
		{
		}

		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x13FA9CC", Offset = "0x13FA9CC", VA = "0x13FA9CC")]
		internal void _003C_003Em__FF()
		{
		}
	}

	[Token(Token = "0x20004DF")]
	private sealed class _003CPlayKillingBossDirectioniStart_003Ec__AnonStorey114
	{
		[Token(Token = "0x40018AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleBT bt;

		[Token(Token = "0x40018AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XGameManager _003C_003Ef__this;

		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x13EE7AC", Offset = "0x13EE7AC", VA = "0x13EE7AC")]
		public _003CPlayKillingBossDirectioniStart_003Ec__AnonStorey114()
		{
		}

		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x13FAA24", Offset = "0x13FAA24", VA = "0x13FAA24")]
		internal void _003C_003Em__100()
		{
		}

		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x13FAC20", Offset = "0x13FAC20", VA = "0x13FAC20")]
		internal void _003C_003Em__107()
		{
		}
	}

	[Token(Token = "0x20004E0")]
	private sealed class _003CRequestStartGame_003Ec__AnonStorey115
	{
		[Token(Token = "0x40018AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string game_session_id;

		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x13F7AB8", Offset = "0x13F7AB8", VA = "0x13F7AB8")]
		public _003CRequestStartGame_003Ec__AnonStorey115()
		{
		}

		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x13FADA0", Offset = "0x13FADA0", VA = "0x13FADA0")]
		internal void _003C_003Em__104(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x400186A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private XGamePlayController m_GamePlayController;

	[Token(Token = "0x400186B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private bool m_bPause;

	[Token(Token = "0x400186C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private XGameState m_nGameState;

	[Token(Token = "0x400186D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XExitState m_nExitState;

	[Token(Token = "0x400186E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XSector m_sector;

	[Token(Token = "0x400186F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private XObjectManager m_ObjectBuilder;

	[Token(Token = "0x4001870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XRewardManager m_RewardManager;

	[Token(Token = "0x4001871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XComboManager m_ComboManager;

	[Token(Token = "0x4001872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XGimmickManager m_gimmickManager;

	[Token(Token = "0x4001873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XGameExitor m_Exitor;

	[Token(Token = "0x4001874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string m_strSceneName;

	[Token(Token = "0x4001875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_isPVP;

	[Token(Token = "0x4001876")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action actionPostPonementRequestStartGame;

	[Token(Token = "0x4001877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool bCallRequestGameStart;

	[Token(Token = "0x4001878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool m_isBossClear;

	[Token(Token = "0x4001879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_diying_delay;

	[Token(Token = "0x400187A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_deltaTime;

	[Token(Token = "0x400187B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_diyingTimeScaleFactor;

	[Token(Token = "0x400187C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Transform m_bossTranform;

	[Token(Token = "0x400187D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_diyingTimeAngle;

	[Token(Token = "0x400187E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Action<bool> m_onPause;

	[Token(Token = "0x400187F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action<XModuleEntity> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x4001880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action<XModuleEntity> _003C_003Ef__am_0024cache16;

	[Token(Token = "0x4001881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action<XModuleEntity> _003C_003Ef__am_0024cache17;

	[Token(Token = "0x4001882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static NetCallback _003C_003Ef__am_0024cache18;

	[Token(Token = "0x17000692")]
	public XGimmickManager GimmickManager
	{
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0x13ECF84", Offset = "0x13ECF84", VA = "0x13ECF84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000693")]
	public bool Pause
	{
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x13F4B90", Offset = "0x13F4B90", VA = "0x13F4B90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x13F4B98", Offset = "0x13F4B98", VA = "0x13F4B98")]
		set
		{
		}
	}

	[Token(Token = "0x17000694")]
	public bool TimePause
	{
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x13F5008", Offset = "0x13F5008", VA = "0x13F5008")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x13EDD4C", Offset = "0x13EDD4C", VA = "0x13EDD4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000695")]
	public XGameState GameState
	{
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x13F2D38", Offset = "0x13F2D38", VA = "0x13F2D38")]
		get
		{
			return default(XGameState);
		}
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x13E7030", Offset = "0x13E7030", VA = "0x13E7030")]
		set
		{
		}
	}

	[Token(Token = "0x17000696")]
	public XExitState ExitState
	{
		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x13F555C", Offset = "0x13F555C", VA = "0x13F555C")]
		get
		{
			return default(XExitState);
		}
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x13F5564", Offset = "0x13F5564", VA = "0x13F5564")]
		set
		{
		}
	}

	[Token(Token = "0x17000697")]
	public XRewardManager RewardManager
	{
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x13F3880", Offset = "0x13F3880", VA = "0x13F3880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000698")]
	public XGamePlayController GamePlayController
	{
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x13F556C", Offset = "0x13F556C", VA = "0x13F556C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000699")]
	public XSector Sector
	{
		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x13ED354", Offset = "0x13ED354", VA = "0x13ED354")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x13F5574", Offset = "0x13F5574", VA = "0x13F5574")]
		set
		{
		}
	}

	[Token(Token = "0x1700069A")]
	public CSSectorInfo CurrSectorInfo
	{
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x13F557C", Offset = "0x13F557C", VA = "0x13F557C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069B")]
	public XObjectManager ObjectManager
	{
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x13DF1F0", Offset = "0x13DF1F0", VA = "0x13DF1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069C")]
	public XGameExitor Exitor
	{
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x13DFAA8", Offset = "0x13DFAA8", VA = "0x13DFAA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x13ECDE8", Offset = "0x13ECDE8", VA = "0x13ECDE8")]
	public XGameManager()
	{
	}

	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x13ECF8C", Offset = "0x13ECF8C", VA = "0x13ECF8C")]
	public void AlarmVibrate()
	{
	}

	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x13ED068", Offset = "0x13ED068", VA = "0x13ED068")]
	public void SetSceneName(string sceneName)
	{
	}

	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x13ED070", Offset = "0x13ED070", VA = "0x13ED070")]
	public string GetSceneName()
	{
		return null;
	}

	[Token(Token = "0x60029B8")]
	[Address(RVA = "0x13ED078", Offset = "0x13ED078", VA = "0x13ED078")]
	public void SetPvpMode(bool isPvp)
	{
	}

	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x13ED080", Offset = "0x13ED080", VA = "0x13ED080")]
	public void BlackOutSector(float offDelay)
	{
	}

	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x13ED094", Offset = "0x13ED094", VA = "0x13ED094")]
	public void SetSpectatorCameraMode(bool isEnable)
	{
	}

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x13ED210", Offset = "0x13ED210", VA = "0x13ED210")]
	public void SetTargetInCamera(GameObject target)
	{
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x13ED52C", Offset = "0x13ED52C", VA = "0x13ED52C")]
	public void CameraMoveTargetPosition(Transform targetTransfrom, Action action, bool isEndReset)
	{
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x13ED90C", Offset = "0x13ED90C", VA = "0x13ED90C")]
	public void PlayBossDirection(XModuleLevelObject boss)
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x13EDEC0", Offset = "0x13EDEC0", VA = "0x13EDEC0")]
	public void PlayTutorialCineamEnemyComeDirection(Transform enemyTransform, [Optional] Action action)
	{
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x13EDF18", Offset = "0x13EDF18", VA = "0x13EDF18")]
	public void PlayUlitmateSkillStartAni(Transform myCharacterTransform, [Optional] Action action)
	{
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x13EDF70", Offset = "0x13EDF70", VA = "0x13EDF70")]
	[DebuggerHidden]
	private IEnumerator OnCloseUpBoss(XModuleLevelObject boss)
	{
		return null;
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x13EE028", Offset = "0x13EE028", VA = "0x13EE028")]
	public void KillAllMonster()
	{
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x13EE2EC", Offset = "0x13EE2EC", VA = "0x13EE2EC")]
	private void PlayKillingBossDirectioniStart()
	{
	}

	[Token(Token = "0x60029C3")]
	[Address(RVA = "0x13EE7B4", Offset = "0x13EE7B4", VA = "0x13EE7B4")]
	public void PlayCameraResultDirection(Transform targetTransform, Action action)
	{
	}

	[Token(Token = "0x60029C4")]
	[Address(RVA = "0x13EEB38", Offset = "0x13EEB38", VA = "0x13EEB38")]
	public void PlayCameraReset()
	{
	}

	[Token(Token = "0x60029C5")]
	[Address(RVA = "0x13EEB8C", Offset = "0x13EEB8C", VA = "0x13EEB8C")]
	public void DisableCamera()
	{
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x13EEBE0", Offset = "0x13EEBE0", VA = "0x13EEBE0")]
	public void PlayClearStageByKillingBoss(Transform boss)
	{
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x13EED40", Offset = "0x13EED40", VA = "0x13EED40")]
	internal void ReConnectToJoinGame(Vector3 spawnPos, Vector3 spawnDir)
	{
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x13EF414", Offset = "0x13EF414", VA = "0x13EF414")]
	public void PlayGameResultExpression()
	{
	}

	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x13EF590", Offset = "0x13EF590", VA = "0x13EF590")]
	public void NotifyToModuleEntityGameFinish()
	{
	}

	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x13EF6E8", Offset = "0x13EF6E8", VA = "0x13EF6E8")]
	public Vector3 GetCameraPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x13EF8F4", Offset = "0x13EF8F4", VA = "0x13EF8F4")]
	public Vector3 GetCharacterAudioSourcePosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x13E2EE8", Offset = "0x13E2EE8", VA = "0x13E2EE8")]
	[DebuggerHidden]
	public IEnumerator InitGame()
	{
		return null;
	}

	[Token(Token = "0x60029CD")]
	[Address(RVA = "0x13EFBA0", Offset = "0x13EFBA0", VA = "0x13EFBA0")]
	private void PreloadSound()
	{
	}

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x13EFDA4", Offset = "0x13EFDA4", VA = "0x13EFDA4")]
	private void InitColoerGrading()
	{
	}

	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x13EFFA0", Offset = "0x13EFFA0", VA = "0x13EFFA0")]
	private void InitLighingMode()
	{
	}

	[Token(Token = "0x60029D0")]
	[Address(RVA = "0x13F019C", Offset = "0x13F019C", VA = "0x13F019C")]
	private void InitMyPlayer(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x60029D1")]
	[Address(RVA = "0x13F030C", Offset = "0x13F030C", VA = "0x13F030C")]
	public XModuleActor.CreationDesc CreateCharDesc()
	{
		return null;
	}

	[Token(Token = "0x60029D2")]
	[Address(RVA = "0x13EF29C", Offset = "0x13EF29C", VA = "0x13EF29C")]
	private void InitMyPlayer(XGameModeType gameModeType, Vector3 spawnPos, Vector3 spawnDir, bool isReJoin)
	{
	}

	[Token(Token = "0x60029D3")]
	[Address(RVA = "0x13F0C6C", Offset = "0x13F0C6C", VA = "0x13F0C6C")]
	private void InitSpawnMyPlayer(XGameModeType gameModeType, XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x60029D4")]
	[Address(RVA = "0x13F1C20", Offset = "0x13F1C20", VA = "0x13F1C20")]
	private void InitSpawnMyPlayer(XModuleActor.CreationDesc desc, Vector3 spawnPos, Vector3 spawnDir, bool isReJoin)
	{
	}

	[Token(Token = "0x60029D5")]
	[Address(RVA = "0x13F1098", Offset = "0x13F1098", VA = "0x13F1098")]
	public void InitInputManager(XModuleActor actor)
	{
	}

	[Token(Token = "0x60029D6")]
	[Address(RVA = "0x13F11E4", Offset = "0x13F11E4", VA = "0x13F11E4")]
	private void AddMyPlayerToPlayerManager(XModuleActor.CreationDesc charDesc)
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x13F22F8", Offset = "0x13F22F8", VA = "0x13F22F8")]
	[DebuggerHidden]
	private IEnumerator InitGameOnce()
	{
		return null;
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x13F23A4", Offset = "0x13F23A4", VA = "0x13F23A4")]
	[DebuggerHidden]
	private IEnumerator InitMap()
	{
		return null;
	}

	[Token(Token = "0x60029D9")]
	[Address(RVA = "0x13F2450", Offset = "0x13F2450", VA = "0x13F2450")]
	private void InitPointObjects()
	{
	}

	[Token(Token = "0x60029DA")]
	[Address(RVA = "0x13F2804", Offset = "0x13F2804", VA = "0x13F2804")]
	private void DyingBossSlowDirection()
	{
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x13E14DC", Offset = "0x13E14DC", VA = "0x13E14DC")]
	public void Update()
	{
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x13E17CC", Offset = "0x13E17CC", VA = "0x13E17CC")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x13F2974", Offset = "0x13F2974", VA = "0x13F2974")]
	public void ClearSpawnPositions()
	{
	}

	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x13F29A0", Offset = "0x13F29A0", VA = "0x13F29A0")]
	public void AddDropObjectSpawnPosition(int nSpawnID, Vector3 vPos, Vector3 vDir)
	{
	}

	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x13F29F4", Offset = "0x13F29F4", VA = "0x13F29F4")]
	public void AddPointObjectSpawnPosition(int nSpawnID, Vector3 vPos, Vector3 vDir)
	{
	}

	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x13F27C4", Offset = "0x13F27C4", VA = "0x13F27C4")]
	public void AddBattleField(Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x13F2A48", Offset = "0x13F2A48", VA = "0x13F2A48")]
	public void AddWayPoint(Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x13F2A88", Offset = "0x13F2A88", VA = "0x13F2A88")]
	public XRandomPosInCircle GetBattlefield()
	{
		return null;
	}

	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x13F2AB4", Offset = "0x13F2AB4", VA = "0x13F2AB4")]
	public XRandomPosInCircle GetRandomWayPoint()
	{
		return null;
	}

	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x13F2AE0", Offset = "0x13F2AE0", VA = "0x13F2AE0")]
	public void AddPlayerSpawnPosition(Vector3 vPos, Vector3 vDir)
	{
	}

	[Token(Token = "0x60029E5")]
	[Address(RVA = "0x13F2B2C", Offset = "0x13F2B2C", VA = "0x13F2B2C")]
	public void AddPlayerTeamSpawnPosition(Vector3 vPos, Vector3 vDir, XTeamEnum nTeamEnum)
	{
	}

	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x13E3C00", Offset = "0x13E3C00", VA = "0x13E3C00")]
	public void Clear()
	{
	}

	[Token(Token = "0x60029E7")]
	[Address(RVA = "0x13F2B8C", Offset = "0x13F2B8C", VA = "0x13F2B8C")]
	private static void ChangeToGameScene(string strSceneName, bool isPhotonSync)
	{
	}

	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x13F2C64", Offset = "0x13F2C64", VA = "0x13F2C64")]
	public void ChangeToGameScene()
	{
	}

	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x13DF1F8", Offset = "0x13DF1F8", VA = "0x13DF1F8")]
	public void GoToLobby()
	{
	}

	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x13F2D40", Offset = "0x13F2D40", VA = "0x13F2D40")]
	public void DoEnterDungeon(JObject jsonData, int eloPt, GameModeInstanceInfo gameModeInstanceInfo, bool previous_game_continue, Action onStartFail)
	{
	}

	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x13F3888", Offset = "0x13F3888", VA = "0x13F3888")]
	public void DoEnterFriendly(JObject jsonData, GameModeInstanceInfo gameModeInstanceInfo, bool previous_game_continue, FriendlySessionData friendlySessionData, string friendlyPhotonRoomName, string friendlyMasterName, Action onStartFail)
	{
	}

	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x13F4180", Offset = "0x13F4180", VA = "0x13F4180")]
	public void DoEnterStage(JObject jsonData, CSStageInfo stageInfo, Action onStartFail)
	{
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x13F434C", Offset = "0x13F434C", VA = "0x13F434C")]
	public void EnterStage(string strLevelData)
	{
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x13DE28C", Offset = "0x13DE28C", VA = "0x13DE28C")]
	public void ClearGameSession()
	{
	}

	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x13F44F8", Offset = "0x13F44F8", VA = "0x13F44F8")]
	internal void FastReconnect(string text)
	{
	}

	[Token(Token = "0x60029F0")]
	[Address(RVA = "0x13F44FC", Offset = "0x13F44FC", VA = "0x13F44FC")]
	public void OnDisconnect(string text)
	{
	}

	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x13F46F4", Offset = "0x13F46F4", VA = "0x13F46F4")]
	public void LoadTitleScene()
	{
	}

	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x13E1990", Offset = "0x13E1990", VA = "0x13E1990")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x13F4A28", Offset = "0x13F4A28", VA = "0x13F4A28")]
	internal void OnCompleteGame()
	{
	}

	[Token(Token = "0x60029F6")]
	[Address(RVA = "0x13F4E7C", Offset = "0x13F4E7C", VA = "0x13F4E7C")]
	public void RegisterOnPause(Action<bool> onPause)
	{
	}

	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x13EF6B8", Offset = "0x13EF6B8", VA = "0x13EF6B8")]
	public void NotifiyToAllActor(Action<XModuleEntity> message)
	{
	}

	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x13F51A0", Offset = "0x13F51A0", VA = "0x13F51A0")]
	private void NotifiyToAllActor(Action<XModuleEntity> message, XInstanceType type)
	{
	}

	[Token(Token = "0x6002A06")]
	[Address(RVA = "0x13E2E3C", Offset = "0x13E2E3C", VA = "0x13E2E3C")]
	public void InitWidgets()
	{
	}

	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x13E3B28", Offset = "0x13E3B28", VA = "0x13E3B28")]
	public void ClearWidgets()
	{
	}

	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x13F55D0", Offset = "0x13F55D0", VA = "0x13F55D0")]
	[DebuggerHidden]
	private IEnumerator LoadPreResources()
	{
		return null;
	}

	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x13F5664", Offset = "0x13F5664", VA = "0x13F5664")]
	public void ApplyCombo()
	{
	}

	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x13F56A4", Offset = "0x13F56A4", VA = "0x13F56A4")]
	public void SwitchCharacter()
	{
	}

	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x13F5910", Offset = "0x13F5910", VA = "0x13F5910")]
	public void TagWithoutTagSkill()
	{
	}

	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x13F5AC4", Offset = "0x13F5AC4", VA = "0x13F5AC4")]
	internal void KickPlayer(string kickPlayerName)
	{
	}

	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x13F6364", Offset = "0x13F6364", VA = "0x13F6364")]
	internal void BanPlayer(string BanPlayerName)
	{
	}

	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x13F5AF0", Offset = "0x13F5AF0", VA = "0x13F5AF0")]
	private bool IsEnableKickOrBanState()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x13F6390", Offset = "0x13F6390", VA = "0x13F6390")]
	public int GetBanRemainCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x13F69E0", Offset = "0x13F69E0", VA = "0x13F69E0")]
	public void OnJoinedGameRoom(bool isRequestStartInGame)
	{
	}

	[Token(Token = "0x6002A11")]
	[Address(RVA = "0x13F76DC", Offset = "0x13F76DC", VA = "0x13F76DC")]
	public int GetGameModeInstanceID()
	{
		return default(int);
	}

	[Token(Token = "0x6002A12")]
	[Address(RVA = "0x13F7930", Offset = "0x13F7930", VA = "0x13F7930")]
	public int GetGameModeInstanceID(int nID)
	{
		return default(int);
	}

	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x13F69EC", Offset = "0x13F69EC", VA = "0x13F69EC")]
	public void RequestStartGame()
	{
	}

	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x13F7AC0", Offset = "0x13F7AC0", VA = "0x13F7AC0")]
	internal bool IsRequestStartInGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x13F7B90", Offset = "0x13F7B90", VA = "0x13F7B90")]
	public bool IsCallRequestStartGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x13F2B80", Offset = "0x13F2B80", VA = "0x13F2B80")]
	public void ResetCallRequestStartGame()
	{
	}

	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x13F7B98", Offset = "0x13F7B98", VA = "0x13F7B98")]
	public void ResetReserveRequestStartGame()
	{
	}

	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x13F7BA4", Offset = "0x13F7BA4", VA = "0x13F7BA4")]
	public bool IsUseServerMatchingGameMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x13F1D3C", Offset = "0x13F1D3C", VA = "0x13F1D3C")]
	public XTeamEnum GetMyMatchingTeam()
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x13F7C70", Offset = "0x13F7C70", VA = "0x13F7C70")]
	internal bool CheckValideByRoomInfo(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x13F8134", Offset = "0x13F8134", VA = "0x13F8134")]
	internal void SetRoomData(Room room)
	{
	}

	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x13F8474", Offset = "0x13F8474", VA = "0x13F8474")]
	private static void _003Cset_Pause_003Em__FD(XModuleEntity me)
	{
	}

	[Token(Token = "0x6002A1D")]
	[Address(RVA = "0x13F84A0", Offset = "0x13F84A0", VA = "0x13F84A0")]
	private static void _003Cset_Pause_003Em__FE(XModuleEntity me)
	{
	}

	[Token(Token = "0x6002A1E")]
	[Address(RVA = "0x13F84CC", Offset = "0x13F84CC", VA = "0x13F84CC")]
	private static void _003CNotifyToModuleEntityGameFinish_003Em__101(XModuleEntity me)
	{
	}

	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0x13F84F8", Offset = "0x13F84F8", VA = "0x13F84F8")]
	private static void _003CClearGameSession_003Em__102(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6002A20")]
	[Address(RVA = "0x13F85D0", Offset = "0x13F85D0", VA = "0x13F85D0")]
	private void _003COnDisconnect_003Em__103()
	{
	}
}
