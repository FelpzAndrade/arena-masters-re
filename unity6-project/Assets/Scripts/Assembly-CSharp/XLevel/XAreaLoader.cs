using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x200072E")]
	public class XAreaLoader : ITriggerReciever
	{
		[Token(Token = "0x200072F")]
		private struct DelayedEntry
		{
			[Token(Token = "0x4002212")]
			[FieldOffset(Offset = "0x0")]
			public TimeTriggerData trigger;

			[Token(Token = "0x4002213")]
			[FieldOffset(Offset = "0x4")]
			public float remain;
		}

		[Token(Token = "0x2000730")]
		private struct DelayedSpawnObjectEntry
		{
			[Token(Token = "0x4002214")]
			[FieldOffset(Offset = "0x0")]
			public LevelObjectData obj;

			[Token(Token = "0x4002215")]
			[FieldOffset(Offset = "0x4")]
			public ushort groupUID;

			[Token(Token = "0x4002216")]
			[FieldOffset(Offset = "0x8")]
			public XVector? randomPos;

			[Token(Token = "0x4002217")]
			[FieldOffset(Offset = "0x18")]
			public float remain;

			[Token(Token = "0x4002218")]
			[FieldOffset(Offset = "0x1C")]
			public bool trigged;
		}

		[Token(Token = "0x2000731")]
		private struct DelayedActionEntry
		{
			[Token(Token = "0x4002219")]
			[FieldOffset(Offset = "0x0")]
			public LevelActionEntityData aed;

			[Token(Token = "0x400221A")]
			[FieldOffset(Offset = "0x4")]
			public float remain;
		}

		[Token(Token = "0x2000732")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey136
		{
			[Token(Token = "0x400221B")]
			[FieldOffset(Offset = "0x8")]
			internal XModuleSkill moduleSkill;

			[Token(Token = "0x6003B1F")]
			[Address(RVA = "0x2027B30", Offset = "0x2027B30", VA = "0x2027B30")]
			public _003CActionActionEntity_003Ec__AnonStorey136()
			{
			}

			[Token(Token = "0x6003B20")]
			[Address(RVA = "0x2028BDC", Offset = "0x2028BDC", VA = "0x2028BDC")]
			internal bool _003C_003Em__19D(int reserveSkillID)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000733")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey137
		{
			[Token(Token = "0x400221C")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x400221D")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B21")]
			[Address(RVA = "0x2027B38", Offset = "0x2027B38", VA = "0x2027B38")]
			public _003CActionActionEntity_003Ec__AnonStorey137()
			{
			}

			[Token(Token = "0x6003B22")]
			[Address(RVA = "0x2028C98", Offset = "0x2028C98", VA = "0x2028C98")]
			internal void _003C_003Em__19E()
			{
			}
		}

		[Token(Token = "0x2000734")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey138
		{
			[Token(Token = "0x400221E")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x400221F")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B23")]
			[Address(RVA = "0x2027B40", Offset = "0x2027B40", VA = "0x2027B40")]
			public _003CActionActionEntity_003Ec__AnonStorey138()
			{
			}

			[Token(Token = "0x6003B24")]
			[Address(RVA = "0x2028E3C", Offset = "0x2028E3C", VA = "0x2028E3C")]
			internal void _003C_003Em__19F()
			{
			}
		}

		[Token(Token = "0x2000735")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey139
		{
			[Token(Token = "0x4002220")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x4002221")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B25")]
			[Address(RVA = "0x2027B48", Offset = "0x2027B48", VA = "0x2027B48")]
			public _003CActionActionEntity_003Ec__AnonStorey139()
			{
			}

			[Token(Token = "0x6003B26")]
			[Address(RVA = "0x2028F2C", Offset = "0x2028F2C", VA = "0x2028F2C")]
			internal void _003C_003Em__1A0()
			{
			}
		}

		[Token(Token = "0x2000736")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey13A
		{
			[Token(Token = "0x4002222")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x4002223")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B27")]
			[Address(RVA = "0x2027B50", Offset = "0x2027B50", VA = "0x2027B50")]
			public _003CActionActionEntity_003Ec__AnonStorey13A()
			{
			}

			[Token(Token = "0x6003B28")]
			[Address(RVA = "0x202901C", Offset = "0x202901C", VA = "0x202901C")]
			internal void _003C_003Em__1A1()
			{
			}
		}

		[Token(Token = "0x2000737")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey13B
		{
			[Token(Token = "0x4002224")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x4002225")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B29")]
			[Address(RVA = "0x2027B58", Offset = "0x2027B58", VA = "0x2027B58")]
			public _003CActionActionEntity_003Ec__AnonStorey13B()
			{
			}

			[Token(Token = "0x6003B2A")]
			[Address(RVA = "0x202910C", Offset = "0x202910C", VA = "0x202910C")]
			internal void _003C_003Em__1A2()
			{
			}
		}

		[Token(Token = "0x2000738")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey13C
		{
			[Token(Token = "0x4002226")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x4002227")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B2B")]
			[Address(RVA = "0x2027B60", Offset = "0x2027B60", VA = "0x2027B60")]
			public _003CActionActionEntity_003Ec__AnonStorey13C()
			{
			}

			[Token(Token = "0x6003B2C")]
			[Address(RVA = "0x202913C", Offset = "0x202913C", VA = "0x202913C")]
			internal void _003C_003Em__1A3()
			{
			}
		}

		[Token(Token = "0x2000739")]
		private sealed class _003CActionActionEntity_003Ec__AnonStorey13D
		{
			[Token(Token = "0x4002228")]
			[FieldOffset(Offset = "0x8")]
			internal LevelActionEntityData refAed;

			[Token(Token = "0x4002229")]
			[FieldOffset(Offset = "0xC")]
			internal XAreaLoader _003C_003Ef__this;

			[Token(Token = "0x6003B2D")]
			[Address(RVA = "0x2027B68", Offset = "0x2027B68", VA = "0x2027B68")]
			public _003CActionActionEntity_003Ec__AnonStorey13D()
			{
			}

			[Token(Token = "0x6003B2E")]
			[Address(RVA = "0x202916C", Offset = "0x202916C", VA = "0x202916C")]
			internal void _003C_003Em__1A4()
			{
			}
		}

		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x8")]
		private AreaData m_areaData;

		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0xC")]
		private int m_maxMonsterCount;

		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x10")]
		private bool m_groupToTeam;

		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x14")]
		private Func<LevelObjectData, XModuleLevelObject> m_objectLoader;

		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x18")]
		private RandomPositionGenerator m_rpGen;

		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x1C")]
		private ObjectKillCounter m_objectKillCounter;

		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_parent;

		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x24")]
		private Action<XAreaLoader> m_onFinish;

		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x28")]
		private Action m_onClear;

		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x2C")]
		private Action m_onFailure;

		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x30")]
		private Action<XModuleLevelObject> m_onObjDie;

		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<string, LevelDataEntity> m_entityCache;

		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, LevelDataEntity> m_entityUIDCache;

		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x3C")]
		private float? m_groundPos;

		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x44")]
		private ushort m_groupUID;

		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<ushort, List<XModuleLevelObject>> m_groupCache;

		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x4C")]
		private Queue<DelayedSpawnObjectEntry> m_limitedMonster;

		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, XModuleLevelObject> m_moduleLevelObjectInstances;

		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x54")]
		private bool m_pause;

		[Token(Token = "0x4002203")]
		[FieldOffset(Offset = "0x58")]
		private ActionEntityTargetManager m_actionEntityActorManager;

		[Token(Token = "0x4002204")]
		[FieldOffset(Offset = "0x5C")]
		private ActionEntityTriggerManager m_actionEntityTriggerManager;

		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0x60")]
		private HittedTriggerManager m_hittedTriggerManager;

		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x64")]
		private List<XColliderTrigger> m_colliderTriggers;

		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x68")]
		private float m_elapsedTime;

		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x6C")]
		private List<DelayedEntry> m_delayedEntries;

		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x70")]
		private List<DelayedSpawnObjectEntry> m_delayedSpawnObjectEntries;

		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x74")]
		private List<DelayedActionEntry> m_delayedActionEntries;

		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, TimeTriggerData> m_killGroupTriggerEntries;

		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x7C")]
		private Dictionary<int, TimeTriggerData> m_combatTriggerEntries;

		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<int, TimeTriggerData> m_actionTriggerEntries;

		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x84")]
		private Dictionary<int, TimeTriggerData> m_HittedTriggerEntries;

		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<int, TimeTriggerData> m_skillTriggerEntries;

		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x8C")]
		private Dictionary<int, TimeTriggerData> m_inputTriggerEntries;

		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<string, List<SkillTriggerData>> m_skillActorTagDic;

		[Token(Token = "0x1700082F")]
		public float? GroundPos
		{
			[Token(Token = "0x6003AFA")]
			[Address(RVA = "0x2022DFC", Offset = "0x2022DFC", VA = "0x2022DFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x2020C28", Offset = "0x2020C28", VA = "0x2020C28")]
		public XAreaLoader(AreaData data, int maxMonsterCount, bool groupToTeam, Func<LevelObjectData, XModuleLevelObject> objectLoader, Transform parent, Action<XModuleLevelObject> onObjDie, Action<XAreaLoader> onFinish, Action onClear, Action onFailure, ActionEntityTargetManager actionEntityTargetManager)
		{
		}

		[Token(Token = "0x6003AFB")]
		private T GetEntity<T>(string name) where T : LevelDataEntity
		{
			return null;
		}

		[Token(Token = "0x6003AFC")]
		[Address(RVA = "0x2022E10", Offset = "0x2022E10", VA = "0x2022E10")]
		public void Pause()
		{
		}

		[Token(Token = "0x6003AFD")]
		[Address(RVA = "0x2022E1C", Offset = "0x2022E1C", VA = "0x2022E1C")]
		public void Resume()
		{
		}

		[Token(Token = "0x6003AFE")]
		[Address(RVA = "0x2022E28", Offset = "0x2022E28", VA = "0x2022E28")]
		public void Finish()
		{
		}

		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x2022EB8", Offset = "0x2022EB8", VA = "0x2022EB8")]
		public void AreaLoadClear()
		{
		}

		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x2022ECC", Offset = "0x2022ECC", VA = "0x2022ECC")]
		public void CountUpKilled(XModuleLevelObject obj, ModuleEventArgument_Hit hit)
		{
		}

		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x202163C", Offset = "0x202163C", VA = "0x202163C")]
		private void LoadTrigger(List<TimeTriggerData> triggers)
		{
		}

		[Token(Token = "0x6003B02")]
		[Address(RVA = "0x2024268", Offset = "0x2024268", VA = "0x2024268")]
		private List<XColliderTrigger> LoadColliderTriggers(List<ColliderTriggerData> triggers, Transform parent, ITriggerReciever reciever)
		{
			return null;
		}

		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x2024434", Offset = "0x2024434", VA = "0x2024434")]
		private XVector GetRandomPosition(string group)
		{
			return default(XVector);
		}

		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x202445C", Offset = "0x202445C", VA = "0x202445C")]
		public void FixedUpdate(float delta)
		{
		}

		[Token(Token = "0x6003B05")]
		[Address(RVA = "0x2027690", Offset = "0x2027690", VA = "0x2027690", Slot = "4")]
		public void PullTrigger(TimeTriggerData data)
		{
		}

		[Token(Token = "0x6003B06")]
		[Address(RVA = "0x2023208", Offset = "0x2023208", VA = "0x2023208")]
		private void PullTrigger(Dictionary<int, TimeTriggerData> entries, int uid)
		{
		}

		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x2024E48", Offset = "0x2024E48", VA = "0x2024E48")]
		private void HandleGroupObjects(SwitchGroupTriggerData data)
		{
		}

		[Token(Token = "0x6003B08")]
		[Address(RVA = "0x2024E4C", Offset = "0x2024E4C", VA = "0x2024E4C")]
		private void HandleObjects(TimeTriggerData data)
		{
		}

		[Token(Token = "0x6003B09")]
		[Address(RVA = "0x2027A4C", Offset = "0x2027A4C", VA = "0x2027A4C")]
		private void HandleActionEntity(LevelActionEntityData aed)
		{
		}

		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x20251D8", Offset = "0x20251D8", VA = "0x20251D8")]
		private void ActionActionEntity(LevelActionEntityData aed)
		{
		}

		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x2027B70", Offset = "0x2027B70", VA = "0x2027B70")]
		public void CountUpActionEnd(LevelActionEntityData actionEntity)
		{
		}

		[Token(Token = "0x6003B0C")]
		[Address(RVA = "0x20276DC", Offset = "0x20276DC", VA = "0x20276DC")]
		private void HandleSpawnObject(LevelObjectData obj, ushort groupUID, XVector? randomPos)
		{
		}

		[Token(Token = "0x6003B0D")]
		[Address(RVA = "0x2027D3C", Offset = "0x2027D3C", VA = "0x2027D3C")]
		private bool IsEnemy(XTeamEnum team)
		{
			return default(bool);
		}

		[Token(Token = "0x6003B0E")]
		[Address(RVA = "0x20232FC", Offset = "0x20232FC", VA = "0x20232FC")]
		private XModuleLevelObject SpawnObject(LevelObjectData obj, ushort groupUID, XVector? randomPos)
		{
			return null;
		}

		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x2027EA4", Offset = "0x2027EA4", VA = "0x2027EA4")]
		private void CheckInput(XKeyEnum key)
		{
		}

		[Token(Token = "0x6003B10")]
		[Address(RVA = "0x2028430", Offset = "0x2028430", VA = "0x2028430")]
		private void CheckHitted(XModuleLevelObject obj, ModuleEventArgument_Hit arg)
		{
		}

		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x2028230", Offset = "0x2028230", VA = "0x2028230")]
		private bool IsContainActionEntity(string prevActionEntityName)
		{
			return default(bool);
		}

		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x2028618", Offset = "0x2028618", VA = "0x2028618")]
		private void CheckSkill(XModuleLevelObject obj, int skillId, SkillTriggerData.SkillType type)
		{
		}

		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x20288E4", Offset = "0x20288E4", VA = "0x20288E4")]
		private void OntoBattle(XModuleLevelObject obj)
		{
		}

		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x20288F0", Offset = "0x20288F0", VA = "0x20288F0")]
		private void PullCombatTrigger(XModuleLevelObject obj)
		{
		}

		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x2028A0C", Offset = "0x2028A0C", VA = "0x2028A0C")]
		private void DestroyWall(XModuleLevelObject obj)
		{
		}

		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x2027878", Offset = "0x2027878", VA = "0x2027878")]
		private void DespawnObject(int uid)
		{
		}

		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x2024148", Offset = "0x2024148", VA = "0x2024148")]
		private void AddDelayedEntry(TimeTriggerData trigger, float remain)
		{
		}

		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x2027BDC", Offset = "0x2027BDC", VA = "0x2027BDC")]
		private void AddDelayedSpawnObjectEntry(LevelObjectData obj, ushort groupUID, XVector? randomPos)
		{
		}

		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x2027D4C", Offset = "0x2027D4C", VA = "0x2027D4C")]
		private void PushLimitedSpawnMonster(LevelObjectData obj, ushort groupUID, XVector? randomPos)
		{
		}

		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x2027A88", Offset = "0x2027A88", VA = "0x2027A88")]
		private void AddDelayedActionEntry(LevelActionEntityData aed)
		{
		}

		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x2028AE4", Offset = "0x2028AE4", VA = "0x2028AE4")]
		private void _003CLoadTrigger_003Em__19B(int skillId)
		{
		}

		[Token(Token = "0x6003B1C")]
		[Address(RVA = "0x2028B08", Offset = "0x2028B08", VA = "0x2028B08")]
		private void _003CLoadTrigger_003Em__19C(int skillId)
		{
		}

		[Token(Token = "0x6003B1D")]
		[Address(RVA = "0x2028B2C", Offset = "0x2028B2C", VA = "0x2028B2C")]
		private void _003CSpawnObject_003Em__1A5(XModuleLevelObject lvObj, XSkill skill)
		{
		}

		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x2028B84", Offset = "0x2028B84", VA = "0x2028B84")]
		private void _003CSpawnObject_003Em__1A6(XModuleLevelObject lvObj, XSkill skill)
		{
		}
	}
}
