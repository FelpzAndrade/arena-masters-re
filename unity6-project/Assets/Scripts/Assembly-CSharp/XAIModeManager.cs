using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XLevel;

[Token(Token = "0x20004BF")]
public class XAIModeManager : MonoSingleton<XAIModeManager>
{
	[Token(Token = "0x20004C0")]
	private sealed class _003CSpawnAIPlayer_003Ec__AnonStorey10A
	{
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor.CreationDesc desc;

		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0xC")]
		internal XAIModeManager _003C_003Ef__this;

		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x1EE0BE8", Offset = "0x1EE0BE8", VA = "0x1EE0BE8")]
		public _003CSpawnAIPlayer_003Ec__AnonStorey10A()
		{
		}
	}

	[Token(Token = "0x20004C1")]
	private sealed class _003CSpawnAIPlayer_003Ec__AnonStorey109
	{
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor.CreationDesc aiDesc;

		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0xC")]
		internal _003CSpawnAIPlayer_003Ec__AnonStorey10A _003C_003Ef__ref_0024266;

		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0x10")]
		internal XAIModeManager _003C_003Ef__this;

		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x1EE0BF0", Offset = "0x1EE0BF0", VA = "0x1EE0BF0")]
		public _003CSpawnAIPlayer_003Ec__AnonStorey109()
		{
		}

		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x1EE1F04", Offset = "0x1EE1F04", VA = "0x1EE1F04")]
		internal void _003C_003Em__F0()
		{
		}
	}

	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0xC")]
	public int MyUID;

	[Token(Token = "0x40017CB")]
	[FieldOffset(Offset = "0x10")]
	private int m_uid;

	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, XModuleEntity> m_actors;

	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, int> charList;

	[Token(Token = "0x40017CE")]
	[FieldOffset(Offset = "0x1C")]
	private RandomBox<int> aiSelector;

	[Token(Token = "0x40017CF")]
	[FieldOffset(Offset = "0x20")]
	private List<string> nameList;

	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0x24")]
	private Queue<string> m_nameQueue;

	[Token(Token = "0x40017D1")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<XModuleEntity, int> m_uIDCache;

	[Token(Token = "0x40017D2")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, XModuleEntity> m_actorUIDCache;

	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0x30")]
	private bool m_fixChar;

	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0x34")]
	private int m_index;

	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0x38")]
	private List<KeyValuePair<XModuleActor, float>> m_reviveEntry;

	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x3C")]
	private Action<XModuleActor> m_respawn;

	[Token(Token = "0x1700066E")]
	private Queue<string> nameQueue
	{
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x1EDFD38", Offset = "0x1EDFD38", VA = "0x1EDFD38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700066F")]
	public Dictionary<string, XModuleEntity> ActorList
	{
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x1EE0308", Offset = "0x1EE0308", VA = "0x1EE0308")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60028C5")]
	[Address(RVA = "0x1EDFA18", Offset = "0x1EDFA18", VA = "0x1EDFA18")]
	public XAIModeManager()
	{
	}

	[Token(Token = "0x60028C7")]
	[Address(RVA = "0x1EE0110", Offset = "0x1EE0110", VA = "0x1EE0110", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x60028C8")]
	[Address(RVA = "0x1EDFE34", Offset = "0x1EDFE34", VA = "0x1EDFE34")]
	private void InitNameList()
	{
	}

	[Token(Token = "0x60028CA")]
	[Address(RVA = "0x1EE0310", Offset = "0x1EE0310", VA = "0x1EE0310")]
	public void FixCharID()
	{
	}

	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x1EE031C", Offset = "0x1EE031C", VA = "0x1EE031C")]
	private List<int> GetAICharIDS(XModuleActor.CreationDesc desc, int count)
	{
		return null;
	}

	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x1EE0750", Offset = "0x1EE0750", VA = "0x1EE0750")]
	public void SpawnAIPlayer(XModuleActor.CreationDesc desc, int count)
	{
	}

	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x1EE0BF8", Offset = "0x1EE0BF8", VA = "0x1EE0BF8")]
	private void RegisterActor(XModuleActor actor, string name, int id1, int skin1, short lev1, int id2, int skin2, short lev2, int relicId, short relicLevel, XTeamEnum team, int petId)
	{
	}

	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x1EE112C", Offset = "0x1EE112C", VA = "0x1EE112C")]
	public int GetUID(XModuleEntity me)
	{
		return default(int);
	}

	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x1EE1250", Offset = "0x1EE1250", VA = "0x1EE1250")]
	public GameObject GetActorGO(int uid)
	{
		return null;
	}

	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x1EE1338", Offset = "0x1EE1338", VA = "0x1EE1338")]
	public XModuleEntity GetActorME(int uid)
	{
		return null;
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x1EE1518", Offset = "0x1EE1518", VA = "0x1EE1518")]
	public XModuleEntity SpawnLevelActorPlayer(LevelActorData lvo, int fieldLev)
	{
		return null;
	}

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x1EE17CC", Offset = "0x1EE17CC", VA = "0x1EE17CC")]
	public void ReserveRevive(XModuleActor me, float respawnDelay)
	{
	}

	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x1EE18D0", Offset = "0x1EE18D0", VA = "0x1EE18D0")]
	public string GetAccountID(XModuleEntity me)
	{
		return null;
	}

	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x1EE1A88", Offset = "0x1EE1A88", VA = "0x1EE1A88")]
	public void RegisterRespawn(Action<XModuleActor> respawn)
	{
	}

	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x1EE1A90", Offset = "0x1EE1A90", VA = "0x1EE1A90")]
	private void Update()
	{
	}

	[Token(Token = "0x60028D6")]
	[Address(RVA = "0x1EE1D58", Offset = "0x1EE1D58", VA = "0x1EE1D58")]
	public void Clear()
	{
	}

	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x1EE1E64", Offset = "0x1EE1E64", VA = "0x1EE1E64")]
	public void ClearRespawn()
	{
	}
}
