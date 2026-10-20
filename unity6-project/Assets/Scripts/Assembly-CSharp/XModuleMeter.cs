using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000475")]
public class XModuleMeter : XModuleBase
{
	[Token(Token = "0x2000476")]
	public class AggroTable
	{
		[Token(Token = "0x2000477")]
		public class Entry
		{
			[Token(Token = "0x400167F")]
			[FieldOffset(Offset = "0x8")]
			public XModuleEntity enemyMe;

			[Token(Token = "0x4001680")]
			[FieldOffset(Offset = "0xC")]
			private float m_pureAggro;

			[Token(Token = "0x4001681")]
			[FieldOffset(Offset = "0x10")]
			private float m_multiplierByDistance;

			[Token(Token = "0x17000623")]
			public float pureAggro
			{
				[Token(Token = "0x60025BE")]
				[Address(RVA = "0xB711C0", Offset = "0xB711C0", VA = "0xB711C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60025BF")]
				[Address(RVA = "0xB711C8", Offset = "0xB711C8", VA = "0xB711C8")]
				set
				{
				}
			}

			[Token(Token = "0x17000624")]
			public float multiplierByDistance
			{
				[Token(Token = "0x60025C0")]
				[Address(RVA = "0xB71210", Offset = "0xB71210", VA = "0xB71210")]
				set
				{
				}
			}

			[Token(Token = "0x17000625")]
			public float aggro
			{
				[Token(Token = "0x60025C1")]
				[Address(RVA = "0xB730C4", Offset = "0xB730C4", VA = "0xB730C4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60025BD")]
			[Address(RVA = "0xB72D64", Offset = "0xB72D64", VA = "0xB72D64")]
			public Entry()
			{
			}
		}

		[Token(Token = "0x400167C")]
		[FieldOffset(Offset = "0x8")]
		private float m_lastSortTimeStamp;

		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<XModuleEntity, Entry> m_table;

		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0x10")]
		private List<Entry> m_rank;

		[Token(Token = "0x17000622")]
		public List<Entry> RankList
		{
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0xB6FD10", Offset = "0xB6FD10", VA = "0xB6FD10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025AF")]
		[Address(RVA = "0xB6EE58", Offset = "0xB6EE58", VA = "0xB6EE58")]
		public AggroTable()
		{
		}

		[Token(Token = "0x60025B1")]
		[Address(RVA = "0xB72C8C", Offset = "0xB72C8C", VA = "0xB72C8C")]
		private void AddEntry(Entry entry)
		{
		}

		[Token(Token = "0x60025B2")]
		[Address(RVA = "0xB71C80", Offset = "0xB71C80", VA = "0xB71C80")]
		public XModuleEntity PushAggro(XModuleEntity actor, float pureAggro, float multiplierByDistance, float time)
		{
			return null;
		}

		[Token(Token = "0x60025B3")]
		[Address(RVA = "0xB72D6C", Offset = "0xB72D6C", VA = "0xB72D6C")]
		public void Move(Entry entry, int to)
		{
		}

		[Token(Token = "0x60025B4")]
		[Address(RVA = "0xB71218", Offset = "0xB71218", VA = "0xB71218")]
		public void Sort(float time, bool immediately = false)
		{
		}

		[Token(Token = "0x60025B5")]
		[Address(RVA = "0xB72EFC", Offset = "0xB72EFC", VA = "0xB72EFC")]
		public void ResetSortTimeStamp(float time)
		{
		}

		[Token(Token = "0x60025B6")]
		[Address(RVA = "0xB72E44", Offset = "0xB72E44", VA = "0xB72E44")]
		private void Sort(List<Entry> list)
		{
		}

		[Token(Token = "0x60025B7")]
		[Address(RVA = "0xB72F04", Offset = "0xB72F04", VA = "0xB72F04")]
		private void QuickSortRecursive(List<Entry> list, int low, int high)
		{
		}

		[Token(Token = "0x60025B8")]
		[Address(RVA = "0xB730D8", Offset = "0xB730D8", VA = "0xB730D8")]
		private void Swap(List<Entry> list, int idxI, int idxJ)
		{
		}

		[Token(Token = "0x60025B9")]
		[Address(RVA = "0xB71E50", Offset = "0xB71E50", VA = "0xB71E50")]
		public void RemoveAggro(XModuleEntity enemy)
		{
		}

		[Token(Token = "0x60025BA")]
		[Address(RVA = "0xB716F0", Offset = "0xB716F0", VA = "0xB716F0")]
		public GameObject GetTarget()
		{
			return null;
		}

		[Token(Token = "0x60025BB")]
		[Address(RVA = "0xB714F4", Offset = "0xB714F4", VA = "0xB714F4")]
		public XModuleEntity GetTargetEntity()
		{
			return null;
		}

		[Token(Token = "0x60025BC")]
		[Address(RVA = "0xB709C8", Offset = "0xB709C8", VA = "0xB709C8")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0x10")]
	private AggroTable m_aggroTable;

	[Token(Token = "0x400166C")]
	[FieldOffset(Offset = "0x14")]
	private HashSet<XModuleMeter> m_enemiesWhoKnowsMe;

	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0x18")]
	public bool isBattle;

	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0x19")]
	private bool isHitOrDamage;

	[Token(Token = "0x400166F")]
	[FieldOffset(Offset = "0x1C")]
	private float battleIntervalTime;

	[Token(Token = "0x4001670")]
	[FieldOffset(Offset = "0x20")]
	private float battleTime;

	[Token(Token = "0x4001671")]
	[FieldOffset(Offset = "0x24")]
	private float m_assistTime;

	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0x28")]
	private float m_deltaTime;

	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<string, float> m_assistEnemyDictionary;

	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, float> m_assistFriendlyDictionary;

	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0x34")]
	private int[] m_playerHitDamages;

	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0x38")]
	private int multiKillCount;

	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x3C")]
	private int instantRespawnCount;

	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x40")]
	private List<Dictionary<int, int>> m_useSkillCountDictionaryList;

	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0x44")]
	private List<Dictionary<int, int>> m_mySkillDamageRecordDictionaryList;

	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0x48")]
	private float revengeCheckTime;

	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0x4C")]
	private Queue<float> m_targettedTimeStamp;

	[Token(Token = "0x1700061B")]
	public float PlayTime
	{
		[Token(Token = "0x6002583")]
		[Address(RVA = "0xB6EF38", Offset = "0xB6EF38", VA = "0xB6EF38")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700061C")]
	public int[] PlayerHitDamges
	{
		[Token(Token = "0x6002584")]
		[Address(RVA = "0xB6EF40", Offset = "0xB6EF40", VA = "0xB6EF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061D")]
	public int MultiKillCount
	{
		[Token(Token = "0x6002585")]
		[Address(RVA = "0xB6EF48", Offset = "0xB6EF48", VA = "0xB6EF48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700061E")]
	public int InstantRespawnCount
	{
		[Token(Token = "0x6002586")]
		[Address(RVA = "0xB6EF50", Offset = "0xB6EF50", VA = "0xB6EF50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700061F")]
	public List<Dictionary<int, int>> UseSkillCountDictionaryList
	{
		[Token(Token = "0x6002587")]
		[Address(RVA = "0xB6EF58", Offset = "0xB6EF58", VA = "0xB6EF58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000620")]
	public List<Dictionary<int, int>> MySkillDamageRecordDictionaryList
	{
		[Token(Token = "0x6002588")]
		[Address(RVA = "0xB6EF60", Offset = "0xB6EF60", VA = "0xB6EF60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000621")]
	public List<AggroTable.Entry> RankList
	{
		[Token(Token = "0x600258F")]
		[Address(RVA = "0xB6FCEC", Offset = "0xB6FCEC", VA = "0xB6FCEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0xB6EC7C", Offset = "0xB6EC7C", VA = "0xB6EC7C")]
	public XModuleMeter()
	{
	}

	[Token(Token = "0x6002589")]
	[Address(RVA = "0xB6EF68", Offset = "0xB6EF68", VA = "0xB6EF68", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x600258A")]
	[Address(RVA = "0xB633A0", Offset = "0xB633A0", VA = "0xB633A0")]
	public void OnApplyAssistPlayerRecord(string victimUID, string attackerUID)
	{
	}

	[Token(Token = "0x600258B")]
	[Address(RVA = "0xB6F254", Offset = "0xB6F254", VA = "0xB6F254")]
	private void AddAssistCandidatePlayer(XModuleEntity moduleEntity, bool isFriendly)
	{
	}

	[Token(Token = "0x600258C")]
	[Address(RVA = "0xB6F85C", Offset = "0xB6F85C", VA = "0xB6F85C")]
	private void UpdateAssistPlayer(float dt)
	{
	}

	[Token(Token = "0x600258D")]
	[Address(RVA = "0xB6FB40", Offset = "0xB6FB40", VA = "0xB6FB40")]
	public void AddUseSkillLog(int skillId)
	{
	}

	[Token(Token = "0x600258E")]
	[Address(RVA = "0xB6F890", Offset = "0xB6F890", VA = "0xB6F890")]
	private void CheckAssistDictionary(Dictionary<string, float> dictionary)
	{
	}

	[Token(Token = "0x6002590")]
	[Address(RVA = "0xB6FD18", Offset = "0xB6FD18", VA = "0xB6FD18")]
	public void AddEnemyWhoKnowsMe(XModuleMeter enemyMeter)
	{
	}

	[Token(Token = "0x6002591")]
	[Address(RVA = "0xB6FDB8", Offset = "0xB6FDB8", VA = "0xB6FDB8")]
	public void RemoveEnemyWhoKnowsMe(XModuleMeter enemyMeter)
	{
	}

	[Token(Token = "0x6002592")]
	[Address(RVA = "0xB6FE58", Offset = "0xB6FE58", VA = "0xB6FE58")]
	public void SetMyMultiKillCount(int multiKill)
	{
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0xB6FE68", Offset = "0xB6FE68", VA = "0xB6FE68")]
	public void AddInstantCount()
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0xB6FE78", Offset = "0xB6FE78", VA = "0xB6FE78", Slot = "34")]
	public override void OnHitActor(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002595")]
	[Address(RVA = "0xB70118", Offset = "0xB70118", VA = "0xB70118")]
	protected void RecordMySkillDamage(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0xB704A4", Offset = "0xB704A4", VA = "0xB704A4", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002597")]
	[Address(RVA = "0xB706BC", Offset = "0xB706BC", VA = "0xB706BC", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6002598")]
	[Address(RVA = "0xB70778", Offset = "0xB70778", VA = "0xB70778", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0xB70834", Offset = "0xB70834", VA = "0xB70834", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0xB70BE8", Offset = "0xB70BE8", VA = "0xB70BE8", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0xB70C90", Offset = "0xB70C90", VA = "0xB70C90", Slot = "45")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0xB70A8C", Offset = "0xB70A8C", VA = "0xB70A8C")]
	private void DeleteMeFromEnemyMeter()
	{
	}

	[Token(Token = "0x600259D")]
	[Address(RVA = "0xB70CE0", Offset = "0xB70CE0", VA = "0xB70CE0", Slot = "29")]
	public override void SetVisible(bool isInvisible, bool isEnemy)
	{
	}

	[Token(Token = "0x600259E")]
	[Address(RVA = "0xB70CEC", Offset = "0xB70CEC", VA = "0xB70CEC", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x600259F")]
	[Address(RVA = "0xB70D68", Offset = "0xB70D68", VA = "0xB70D68")]
	private void UpdateAggroTable(float dt)
	{
	}

	[Token(Token = "0x60025A0")]
	[Address(RVA = "0xB7135C", Offset = "0xB7135C", VA = "0xB7135C", Slot = "50")]
	public override void OnStuck(XModuleEntity stuckME)
	{
	}

	[Token(Token = "0x60025A1")]
	[Address(RVA = "0xB711D0", Offset = "0xB711D0", VA = "0xB711D0")]
	private void ResetRevengeCheckTime()
	{
	}

	[Token(Token = "0x60025A2")]
	[Address(RVA = "0xB714CC", Offset = "0xB714CC", VA = "0xB714CC")]
	public XModuleEntity GetTargetEntity()
	{
		return null;
	}

	[Token(Token = "0x60025A3")]
	[Address(RVA = "0xB715D8", Offset = "0xB715D8", VA = "0xB715D8")]
	public bool InBattle()
	{
		return default(bool);
	}

	[Token(Token = "0x60025A4")]
	[Address(RVA = "0xB717DC", Offset = "0xB717DC", VA = "0xB717DC")]
	public void PushAggroFromTeam(XModuleEntity enemy, float time)
	{
	}

	[Token(Token = "0x60025A5")]
	[Address(RVA = "0xB705A8", Offset = "0xB705A8", VA = "0xB705A8")]
	public void PushAggro(XModuleEntity enemy, float aggro, float time)
	{
	}

	[Token(Token = "0x60025A6")]
	[Address(RVA = "0xB717FC", Offset = "0xB717FC", VA = "0xB717FC")]
	private XModuleEntity PushAggroImpl(XModuleEntity enemy, float aggro, float time)
	{
		return null;
	}

	[Token(Token = "0x60025A7")]
	[Address(RVA = "0xB70CB8", Offset = "0xB70CB8", VA = "0xB70CB8")]
	public void RemoveAggro(XModuleEntity enemy)
	{
	}

	[Token(Token = "0x60025A8")]
	[Address(RVA = "0xB71204", Offset = "0xB71204", VA = "0xB71204")]
	public float CalcMultiplierByDistance(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x60025A9")]
	[Address(RVA = "0xB71FC0", Offset = "0xB71FC0", VA = "0xB71FC0")]
	private float CalcMultiplierByDistance(float distance, float affectableDistance)
	{
		return default(float);
	}

	[Token(Token = "0x60025AA")]
	[Address(RVA = "0xB72020", Offset = "0xB72020", VA = "0xB72020")]
	public void CheckBattleCondition(GameObject goOwner, XInstanceType nInstanceType, out int allyCount, out int enemyCount, float fDistance = 999999f)
	{
		allyCount = default;
		enemyCount = default;
	}

	[Token(Token = "0x60025AB")]
	[Address(RVA = "0xB7232C", Offset = "0xB7232C", VA = "0xB7232C", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x60025AC")]
	[Address(RVA = "0xB72618", Offset = "0xB72618", VA = "0xB72618")]
	public void RegisterTargettedHitTimeStamp(float time)
	{
	}

	[Token(Token = "0x60025AD")]
	[Address(RVA = "0xB72718", Offset = "0xB72718", VA = "0xB72718")]
	public bool IsTimeToDodge()
	{
		return default(bool);
	}

	[Token(Token = "0x60025AE")]
	[Address(RVA = "0xB7288C", Offset = "0xB7288C", VA = "0xB7288C")]
	private void _003COnApplyAssistPlayerRecord_003Em__D9()
	{
	}
}
