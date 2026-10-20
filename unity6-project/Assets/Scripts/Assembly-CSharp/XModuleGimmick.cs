using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000464")]
public class XModuleGimmick : MonoBehaviour
{
	[Token(Token = "0x40015C0")]
	protected const string m_forwardAnimationName = "Forward";

	[Token(Token = "0x40015C1")]
	protected const string m_reverseAnimationName = "Reverse";

	[Token(Token = "0x40015C2")]
	[FieldOffset(Offset = "0xC")]
	protected float m_gameModeFullTime;

	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0x10")]
	protected float m_gameModeElapsedTime;

	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0x14")]
	protected int m_registeredIndex;

	[Token(Token = "0x40015C5")]
	[FieldOffset(Offset = "0x18")]
	public XMapGimmickType Type;

	[Token(Token = "0x40015C6")]
	[FieldOffset(Offset = "0x1C")]
	public XMapGimmickWorkingMode WorkingType;

	[Token(Token = "0x40015C7")]
	[FieldOffset(Offset = "0x20")]
	public XMapGimmickLoopMode WorkingLoopType;

	[Token(Token = "0x40015C8")]
	[FieldOffset(Offset = "0x24")]
	public float StartTime;

	[Token(Token = "0x40015C9")]
	[FieldOffset(Offset = "0x28")]
	public float WorkingTime;

	[Token(Token = "0x40015CA")]
	[FieldOffset(Offset = "0x2C")]
	public float RestartTime;

	[Token(Token = "0x40015CB")]
	[FieldOffset(Offset = "0x30")]
	public string strSoundKeyName;

	[Token(Token = "0x40015CC")]
	[FieldOffset(Offset = "0x34")]
	public int BuffID;

	[Token(Token = "0x40015CD")]
	[FieldOffset(Offset = "0x38")]
	public int LostBuffID_OnExit;

	[Token(Token = "0x40015CE")]
	[FieldOffset(Offset = "0x3C")]
	protected XMapGimmickWorkingState m_workingState;

	[Token(Token = "0x40015CF")]
	[FieldOffset(Offset = "0x40")]
	public bool isDebug;

	[Token(Token = "0x40015D0")]
	[FieldOffset(Offset = "0x44")]
	public Collider GimmickCollider;

	[Token(Token = "0x40015D1")]
	[FieldOffset(Offset = "0x48")]
	public Animation GimmickAnimation;

	[Token(Token = "0x40015D2")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ForwarParticle;

	[Token(Token = "0x40015D3")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ReverseParticle;

	[Token(Token = "0x40015D4")]
	[FieldOffset(Offset = "0x54")]
	protected Action<int, XMapGimmickWorkingState> m_workingStateExitAction;

	[Token(Token = "0x40015D5")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<float, XMapGimmickWorkingState> m_gimmickWorkingSchedule;

	[Token(Token = "0x40015D6")]
	[FieldOffset(Offset = "0x5C")]
	protected List<float> m_gimmickTimeLine;

	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0x60")]
	protected int m_currTimeLineIndex;

	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0x64")]
	protected int m_addScheduleCount;

	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0x68")]
	protected float m_fTimeLineOverrap;

	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0x6C")]
	protected float m_currTimeLine;

	[Token(Token = "0x40015DB")]
	[FieldOffset(Offset = "0x70")]
	private XMapGimmickWorkingState m_workingDirection;

	[Token(Token = "0x17000609")]
	public XMapGimmickWorkingState WorkingState
	{
		[Token(Token = "0x6002485")]
		[Address(RVA = "0xB54D6C", Offset = "0xB54D6C", VA = "0xB54D6C")]
		get
		{
			return default(XMapGimmickWorkingState);
		}
	}

	[Token(Token = "0x1700060A")]
	public int CurrTimeLineIndex
	{
		[Token(Token = "0x6002486")]
		[Address(RVA = "0xB5DED0", Offset = "0xB5DED0", VA = "0xB5DED0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002487")]
		[Address(RVA = "0xB5DED8", Offset = "0xB5DED8", VA = "0xB5DED8")]
		set
		{
		}
	}

	[Token(Token = "0x1700060B")]
	public int AddScheduleCount
	{
		[Token(Token = "0x6002488")]
		[Address(RVA = "0xB5DEE0", Offset = "0xB5DEE0", VA = "0xB5DEE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002489")]
		[Address(RVA = "0xB5DEE8", Offset = "0xB5DEE8", VA = "0xB5DEE8")]
		set
		{
		}
	}

	[Token(Token = "0x6002484")]
	[Address(RVA = "0xB5DD8C", Offset = "0xB5DD8C", VA = "0xB5DD8C")]
	public XModuleGimmick()
	{
	}

	[Token(Token = "0x600248A")]
	[Address(RVA = "0xB5DEF0", Offset = "0xB5DEF0", VA = "0xB5DEF0")]
	public void Init(int index)
	{
	}

	[Token(Token = "0x600248B")]
	[Address(RVA = "0xB5E38C", Offset = "0xB5E38C", VA = "0xB5E38C")]
	public bool IsHaveSound()
	{
		return default(bool);
	}

	[Token(Token = "0x600248C")]
	[Address(RVA = "0xB5E43C", Offset = "0xB5E43C", VA = "0xB5E43C")]
	public void PlaySound()
	{
	}

	[Token(Token = "0x600248D")]
	[Address(RVA = "0xB5DF74", Offset = "0xB5DF74", VA = "0xB5DF74")]
	protected void HideEffect()
	{
	}

	[Token(Token = "0x600248E")]
	[Address(RVA = "0xB5E0D8", Offset = "0xB5E0D8", VA = "0xB5E0D8")]
	protected void StopAnimation()
	{
	}

	[Token(Token = "0x600248F")]
	[Address(RVA = "0xB5E520", Offset = "0xB5E520", VA = "0xB5E520")]
	public XMapGimmickWorkingState FindGimmickWorkingState_UseTimeLine(int timeLineIndex)
	{
		return default(XMapGimmickWorkingState);
	}

	[Token(Token = "0x6002490")]
	[Address(RVA = "0xB5E69C", Offset = "0xB5E69C", VA = "0xB5E69C")]
	protected void AddWorkingSchedule(float timeLine, XMapGimmickWorkingState workingState)
	{
	}

	[Token(Token = "0x6002491")]
	[Address(RVA = "0xB5E1B8", Offset = "0xB5E1B8", VA = "0xB5E1B8")]
	protected void CreateWorkingSchedule()
	{
	}

	[Token(Token = "0x6002492")]
	[Address(RVA = "0xB5E788", Offset = "0xB5E788", VA = "0xB5E788")]
	public void AddSchedule()
	{
	}

	[Token(Token = "0x6002493")]
	[Address(RVA = "0xB5DF50", Offset = "0xB5DF50", VA = "0xB5DF50")]
	protected void Reset()
	{
	}

	[Token(Token = "0x6002494")]
	[Address(RVA = "0xB5E924", Offset = "0xB5E924", VA = "0xB5E924")]
	public void SetGameModeFullTime(float modeFullTime)
	{
	}

	[Token(Token = "0x6002495")]
	[Address(RVA = "0xB5E92C", Offset = "0xB5E92C", VA = "0xB5E92C")]
	public void SetGameModeElapsedTime(float modeElapsedTime)
	{
	}

	[Token(Token = "0x6002496")]
	[Address(RVA = "0xB5E934", Offset = "0xB5E934", VA = "0xB5E934")]
	public void SetWorkingStateExitAction(Action<int, XMapGimmickWorkingState> workingStateExitAction)
	{
	}

	[Token(Token = "0x6002497")]
	[Address(RVA = "0xB54D74", Offset = "0xB54D74", VA = "0xB54D74")]
	public int GetRegisteredIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002498")]
	[Address(RVA = "0xB5E1B0", Offset = "0xB5E1B0", VA = "0xB5E1B0")]
	protected void SetRegisteredIndex(int index)
	{
	}

	[Token(Token = "0x6002499")]
	[Address(RVA = "0xB5E93C", Offset = "0xB5E93C", VA = "0xB5E93C")]
	public void OnStartGimmick(XMapGimmickWorkingState workingState)
	{
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0xB5E364", Offset = "0xB5E364", VA = "0xB5E364")]
	public void OnStopGimmick()
	{
	}

	[Token(Token = "0x600249B")]
	[Address(RVA = "0xB5EC44", Offset = "0xB5EC44", VA = "0xB5EC44")]
	public void RefrashCurrTimeLine()
	{
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0xB5ED2C", Offset = "0xB5ED2C", VA = "0xB5ED2C")]
	public void SetWorkingState(XMapGimmickWorkingState workingState)
	{
	}

	[Token(Token = "0x600249D")]
	[Address(RVA = "0xB5E844", Offset = "0xB5E844", VA = "0xB5E844")]
	protected void EnableCollider(bool isEnable)
	{
	}

	[Token(Token = "0x600249E")]
	[Address(RVA = "0xB5ED34", Offset = "0xB5ED34", VA = "0xB5ED34")]
	public void OnUpdate(float modeRemainedTime)
	{
	}

	[Token(Token = "0x600249F")]
	[Address(RVA = "0xB5EE00", Offset = "0xB5EE00", VA = "0xB5EE00")]
	public void Sync(int addScheduleCount, int currTimeLineIndex)
	{
	}

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0xB5EFCC", Offset = "0xB5EFCC", VA = "0xB5EFCC")]
	private void Start()
	{
	}
}
