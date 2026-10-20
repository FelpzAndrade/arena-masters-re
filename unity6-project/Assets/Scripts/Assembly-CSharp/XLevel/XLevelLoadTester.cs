using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000742")]
	public class XLevelLoadTester : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000743")]
		public class keyBind
		{
			[Token(Token = "0x400226B")]
			[FieldOffset(Offset = "0x8")]
			public KeyCode key;

			[Token(Token = "0x400226C")]
			[FieldOffset(Offset = "0xC")]
			public int buffID;

			[Token(Token = "0x400226D")]
			[FieldOffset(Offset = "0x10")]
			public int useSkillID;

			[Token(Token = "0x400226E")]
			[FieldOffset(Offset = "0x14")]
			public int attackerSkillID;

			[Token(Token = "0x6003B79")]
			[Address(RVA = "0x2031550", Offset = "0x2031550", VA = "0x2031550")]
			public keyBind()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000744")]
		public class Talent
		{
			[Token(Token = "0x400226F")]
			[FieldOffset(Offset = "0x8")]
			public int id;

			[Token(Token = "0x4002270")]
			[FieldOffset(Offset = "0xC")]
			public int level;

			[Token(Token = "0x6003B7A")]
			[Address(RVA = "0x2031558", Offset = "0x2031558", VA = "0x2031558")]
			public Talent()
			{
			}
		}

		[Token(Token = "0x2000745")]
		private sealed class _003CLoadAsync_003Ec__Iterator84 : IDisposable
		{
			[Token(Token = "0x4002271")]
			[FieldOffset(Offset = "0x8")]
			internal LevelData _003Cdata_003E__0;

			[Token(Token = "0x4002272")]
			[FieldOffset(Offset = "0xC")]
			internal Dictionary<int, int> _003CtalentDic_003E__1;

			[Token(Token = "0x4002273")]
			[FieldOffset(Offset = "0x10")]
			internal Talent[] _003C_0024s_308_003E__2;

			[Token(Token = "0x4002274")]
			[FieldOffset(Offset = "0x14")]
			internal int _003C_0024s_309_003E__3;

			[Token(Token = "0x4002275")]
			[FieldOffset(Offset = "0x18")]
			internal Talent _003Ct_003E__4;

			[Token(Token = "0x4002276")]
			[FieldOffset(Offset = "0x1C")]
			internal XModuleActor _003CmyPlayer_003E__5;

			[Token(Token = "0x4002277")]
			[FieldOffset(Offset = "0x20")]
			internal int _0024PC;

			[Token(Token = "0x4002278")]
			[FieldOffset(Offset = "0x24")]
			internal object _0024current;

			[Token(Token = "0x4002279")]
			[FieldOffset(Offset = "0x28")]
			internal XLevelLoadTester _003C_003Ef__this;

			[Token(Token = "0x17000835")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6003B7C")]
				[Address(RVA = "0x2030DA0", Offset = "0x2030DA0", VA = "0x2030DA0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000836")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003B7D")]
				[Address(RVA = "0x2030DA8", Offset = "0x2030DA8", VA = "0x2030DA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6003B7B")]
			[Address(RVA = "0x20300A4", Offset = "0x20300A4", VA = "0x20300A4")]
			public _003CLoadAsync_003Ec__Iterator84()
			{
			}

			[Token(Token = "0x6003B7C")]
			[Address(RVA = "0x2030DA0", Offset = "0x2030DA0", VA = "0x2030DA0", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6003B7D")]
			[Address(RVA = "0x2030DA8", Offset = "0x2030DA8", VA = "0x2030DA8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6003B7E")]
			[Address(RVA = "0x2030DB0", Offset = "0x2030DB0", VA = "0x2030DB0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6003B7F")]
			[Address(RVA = "0x20314B0", Offset = "0x20314B0", VA = "0x20314B0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6003B80")]
			[Address(RVA = "0x20314BC", Offset = "0x20314BC", VA = "0x20314BC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4002252")]
		[FieldOffset(Offset = "0xC")]
		private JsonSerializerSettings m_settings;

		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x10")]
		private XGimmickManager m_GimmickManager;

		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x14")]
		public string path;

		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x18")]
		public int playerCharID;

		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x1C")]
		public int playerSkinID;

		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x20")]
		public int playerTagSkillID;

		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x24")]
		public int playerCharID2;

		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x28")]
		public int playerSkinID2;

		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x2C")]
		public int playerTagSkillID2;

		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x30")]
		public int relicSkillId;

		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x34")]
		public int playerLev;

		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x38")]
		public int skillLev;

		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x3C")]
		public int goalKill;

		[Token(Token = "0x400225F")]
		[FieldOffset(Offset = "0x40")]
		public int goalTime;

		[Token(Token = "0x4002260")]
		[FieldOffset(Offset = "0x44")]
		public Netdata_EquipedItem[] equipItems;

		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0x48")]
		public Talent[] talents;

		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0x4C")]
		public int fieldLevel;

		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x50")]
		public CSStageGameModeType gameModeType;

		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x54")]
		public CSStageType gameType;

		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x58")]
		public int timeLimit;

		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x5C")]
		public bool preloadSound;

		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0x60")]
		public int emoticonSetID;

		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x64")]
		public XModuleActor attacker;

		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x68")]
		public List<keyBind> keyBinds;

		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_loadComplete;

		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x202EE84", Offset = "0x202EE84", VA = "0x202EE84")]
		public XLevelLoadTester()
		{
		}

		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x202F028", Offset = "0x202F028", VA = "0x202F028")]
		private void Start()
		{
		}

		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x2030000", Offset = "0x2030000", VA = "0x2030000")]
		[DebuggerHidden]
		private IEnumerator LoadAsync()
		{
			return null;
		}

		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x20300AC", Offset = "0x20300AC", VA = "0x20300AC")]
		private void OnWorkingStateExitAction(int index, XMapGimmickWorkingState gimmickWorkingState)
		{
		}

		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x20302DC", Offset = "0x20302DC", VA = "0x20302DC")]
		public void OnEnterWorkingState(int index, XMapGimmickWorkingState enterGimmickWorkingState)
		{
		}

		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x2030308", Offset = "0x2030308", VA = "0x2030308")]
		private void Update()
		{
		}

		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x2030CC4", Offset = "0x2030CC4", VA = "0x2030CC4")]
		private void FixedUpdate()
		{
		}
	}
}
