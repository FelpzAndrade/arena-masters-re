using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000482")]
public class XModulePhoton : Photon.MonoBehaviour
{
	[Token(Token = "0x2000483")]
	public class XDelayedHitDamageData
	{
		[Token(Token = "0x40016AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m_fElapsedTime;

		[Token(Token = "0x40016AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m_fTime;

		[Token(Token = "0x40016AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bDone;

		[Token(Token = "0x40016B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int nAttackerPhotonViewID;

		[Token(Token = "0x40016B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int nAttackerSkillInfoID;

		[Token(Token = "0x40016B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int nDamage;

		[Token(Token = "0x40016B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int nPureDamage;

		[Token(Token = "0x40016B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool bIsDropObject;

		[Token(Token = "0x40016B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool bCritical;

		[Token(Token = "0x40016B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool bDodged;

		[Token(Token = "0x6002679")]
		[Address(RVA = "0xB81964", Offset = "0xB81964", VA = "0xB81964")]
		public XDelayedHitDamageData()
		{
		}
	}

	[Token(Token = "0x40016A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XModuleEntity me;

	[Token(Token = "0x40016A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Transform m_transform;

	[Token(Token = "0x40016A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Vector3 m_SyncPosition;

	[Token(Token = "0x40016A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected Quaternion m_SyncRotation;

	[Token(Token = "0x40016A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected Quaternion m_LastSyncRotation;

	[Token(Token = "0x40016A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected Vector3 m_SyncStartPosition;

	[Token(Token = "0x40016A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector3 m_SyncEndPosition;

	[Token(Token = "0x40016A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected bool m_init;

	[Token(Token = "0x40016AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool m_destroyed;

	[Token(Token = "0x40016AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public PhotonTransformView m_TransformView;

	[Token(Token = "0x40016AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public List<XDelayedHitDamageData> m_DelayedHitDamageData;

	[Token(Token = "0x1700062B")]
	public Quaternion SyncRotation
	{
		[Token(Token = "0x600263C")]
		[Address(RVA = "0xB7D66C", Offset = "0xB7D66C", VA = "0xB7D66C")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700062C")]
	public string Name
	{
		[Token(Token = "0x600263F")]
		[Address(RVA = "0xB64C4C", Offset = "0xB64C4C", VA = "0xB64C4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700062D")]
	public string NameField
	{
		[Token(Token = "0x6002640")]
		[Address(RVA = "0xB6F12C", Offset = "0xB6F12C", VA = "0xB6F12C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002639")]
	[Address(RVA = "0xB7D504", Offset = "0xB7D504", VA = "0xB7D504")]
	public XModulePhoton()
	{
	}

	[Token(Token = "0x600263A")]
	[Address(RVA = "0xB7D65C", Offset = "0xB7D65C", VA = "0xB7D65C", Slot = "4")]
	public virtual bool IsNetAIHost()
	{
		return default(bool);
	}

	[Token(Token = "0x600263B")]
	[Address(RVA = "0xB7D664", Offset = "0xB7D664", VA = "0xB7D664", Slot = "5")]
	public virtual bool IsNetAI()
	{
		return default(bool);
	}

	[Token(Token = "0x600263D")]
	[Address(RVA = "0xB7D67C", Offset = "0xB7D67C", VA = "0xB7D67C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600263E")]
	[Address(RVA = "0xB78F6C", Offset = "0xB78F6C", VA = "0xB78F6C")]
	public void OnInit()
	{
	}

	[Token(Token = "0x6002641")]
	[Address(RVA = "0xB78FF0", Offset = "0xB78FF0", VA = "0xB78FF0")]
	public bool IsMine()
	{
		return default(bool);
	}

	[Token(Token = "0x6002642")]
	[Address(RVA = "0xB62358", Offset = "0xB62358", VA = "0xB62358")]
	public int GetPhotonViewOwnerID()
	{
		return default(int);
	}

	[Token(Token = "0x6002643")]
	[Address(RVA = "0xB57164", Offset = "0xB57164", VA = "0xB57164")]
	public string GetPhotonViewOwnerName()
	{
		return null;
	}

	[Token(Token = "0x6002644")]
	[Address(RVA = "0xB4A010", Offset = "0xB4A010", VA = "0xB4A010")]
	public int GetPhotonViewID()
	{
		return default(int);
	}

	[Token(Token = "0x6002645")]
	[Address(RVA = "0xB7D698", Offset = "0xB7D698", VA = "0xB7D698")]
	protected bool IsInvalidState(PhotonMessageInfo mi)
	{
		return default(bool);
	}

	[Token(Token = "0x6002646")]
	[Address(RVA = "0xB7D770", Offset = "0xB7D770", VA = "0xB7D770")]
	public void MoveTo(Vector3 vPos)
	{
	}

	[Token(Token = "0x6002647")]
	[Address(RVA = "0xB7D874", Offset = "0xB7D874", VA = "0xB7D874")]
	private void Update()
	{
	}

	[Token(Token = "0x6002648")]
	[Address(RVA = "0xB7DC98", Offset = "0xB7DC98", VA = "0xB7DC98", Slot = "6")]
	public virtual void ReadyToSync()
	{
	}

	[Token(Token = "0x6002649")]
	[Address(RVA = "0xB79020", Offset = "0xB79020", VA = "0xB79020")]
	internal void SyncMoveStart(Vector3 dir, float curMoveSpeed)
	{
	}

	[Token(Token = "0x600264A")]
	[Address(RVA = "0xB7DC9C", Offset = "0xB7DC9C", VA = "0xB7DC9C")]
	[PunRPC]
	public void _SyncMoveStart(Vector3 pos, Vector3 dir, float moveSpeed, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0xB79620", Offset = "0xB79620", VA = "0xB79620")]
	internal void SyncMoveTurn(Vector3 dir, float curMoveSpeed)
	{
	}

	[Token(Token = "0x600264C")]
	[Address(RVA = "0xB7E050", Offset = "0xB7E050", VA = "0xB7E050")]
	[PunRPC]
	public void _SyncMoveTurn(Vector3 pos, Vector3 dir, float moveSpeed, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0xB79C24", Offset = "0xB79C24", VA = "0xB79C24")]
	public void SyncStop()
	{
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0xB7E404", Offset = "0xB7E404", VA = "0xB7E404")]
	[PunRPC]
	public void _SyncStop(Vector3 pos, float dirY, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0xB7E658", Offset = "0xB7E658", VA = "0xB7E658")]
	protected void SetPosition(Vector3 vPos)
	{
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0xB7E6E4", Offset = "0xB7E6E4", VA = "0xB7E6E4")]
	protected void SetDir(float eulerDir)
	{
	}

	[Token(Token = "0x6002651")]
	[Address(RVA = "0xB7CD5C", Offset = "0xB7CD5C", VA = "0xB7CD5C")]
	public void Warp(Vector3 vPos, Vector3 vDir)
	{
	}

	[Token(Token = "0x6002652")]
	[Address(RVA = "0xB7E7D0", Offset = "0xB7E7D0", VA = "0xB7E7D0")]
	[PunRPC]
	public void _Warp(Vector3 vPos, float eulerDir, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002653")]
	[Address(RVA = "0xB7B73C", Offset = "0xB7B73C", VA = "0xB7B73C")]
	public void UseSkill(int nSkillID, Vector3 pos, Vector3 dir, XModuleEntity target, bool cancelCurrent)
	{
	}

	[Token(Token = "0x6002654")]
	[Address(RVA = "0xB7E840", Offset = "0xB7E840", VA = "0xB7E840")]
	[PunRPC]
	public void _UseSkill(int nSkillID, Vector3 pos, float eulerDir, int targetPhotonViewID, bool cancelCurrent, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002655")]
	[Address(RVA = "0xB7BF68", Offset = "0xB7BF68", VA = "0xB7BF68")]
	public void UseRelicSkill(int nSkillID, Vector3 pos, Vector3 dir, XModuleEntity target)
	{
	}

	[Token(Token = "0x6002656")]
	[Address(RVA = "0xB7F688", Offset = "0xB7F688", VA = "0xB7F688")]
	[PunRPC]
	public void _UseRelicSkill(int nSkillID, Vector3 pos, float eulerDir, int targetPhotonViewID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002657")]
	[Address(RVA = "0xB7C6B0", Offset = "0xB7C6B0", VA = "0xB7C6B0")]
	public void UsePassiveSkill(int nSkillID, Vector3 pos, Vector3 dir, XModuleEntity target)
	{
	}

	[Token(Token = "0x6002658")]
	[Address(RVA = "0xB8010C", Offset = "0xB8010C", VA = "0xB8010C")]
	[PunRPC]
	public void _UsePassiveSkill(int nSkillID, Vector3 pos, float eulerDir, int targetPhotonViewID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002659")]
	[Address(RVA = "0xB7A76C", Offset = "0xB7A76C", VA = "0xB7A76C")]
	public void DoHitDamage(XModuleEntity attackerME, CSSkillInfo attackerSkillInfo, int nDamage, int nPureDamage, bool bIsDropObject, bool bCritical, bool bDodged, bool bDotDamage = false)
	{
	}

	[Token(Token = "0x600265A")]
	[Address(RVA = "0xB7D944", Offset = "0xB7D944", VA = "0xB7D944")]
	protected void UpdateDelayedHitDamage(float dt)
	{
	}

	[Token(Token = "0x600265B")]
	[Address(RVA = "0xB80A18", Offset = "0xB80A18", VA = "0xB80A18")]
	private void DelayedHitDamage(int nAttackerPhotonViewID, int nAttackerSkillInfoID, int nDamage, int nPureDamage, bool bIsDropObject, bool bCritical, bool bDodged)
	{
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0xB80DB4", Offset = "0xB80DB4", VA = "0xB80DB4")]
	[PunRPC]
	public void _DoHitDamage(int nAttackerPhotonViewID, int nAttackerSkillInfoID, int nDamage, int nPureDamage, bool bIsDropObject, bool bCritical, bool bDodged, bool bDotDamage, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600265D")]
	[Address(RVA = "0xB816AC", Offset = "0xB816AC", VA = "0xB816AC")]
	private void AddDamageLog(int damage)
	{
	}

	[Token(Token = "0x600265E")]
	[Address(RVA = "0xB7B194", Offset = "0xB7B194", VA = "0xB7B194")]
	public void DoHitHeal(int nHeal, bool bIsDropObject, bool bCritical)
	{
	}

	[Token(Token = "0x600265F")]
	[Address(RVA = "0xB8196C", Offset = "0xB8196C", VA = "0xB8196C")]
	[PunRPC]
	public void _DoHitHeal(int nHeal, bool bIsDropObject, bool bCritical, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002660")]
	[Address(RVA = "0xB45D50", Offset = "0xB45D50", VA = "0xB45D50")]
	public void LostBuff(int nBuffID)
	{
	}

	[Token(Token = "0x6002661")]
	[Address(RVA = "0xB81F3C", Offset = "0xB81F3C", VA = "0xB81F3C")]
	[PunRPC]
	public void _LostBuff(int nBuffID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002662")]
	[Address(RVA = "0xB4A040", Offset = "0xB4A040", VA = "0xB4A040")]
	public void GainBuff(int userId, int nBuffID, Vector3 colPos, Vector3 colDir, int usingSkillId, float duration)
	{
	}

	[Token(Token = "0x6002663")]
	[Address(RVA = "0xB821C4", Offset = "0xB821C4", VA = "0xB821C4")]
	[PunRPC]
	public void _GainBuff(int userPhotonViewId, int nBuffID, Vector3 colPos, Vector3 colDir, int usingSkillId, float duration, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002664")]
	[Address(RVA = "0xB4A9BC", Offset = "0xB4A9BC", VA = "0xB4A9BC")]
	public void ReapplyBuff(int userId, int nBuffID, Vector3 colPos, Vector3 colDir, int usingSkillId, int stackCount)
	{
	}

	[Token(Token = "0x6002665")]
	[Address(RVA = "0xB82B9C", Offset = "0xB82B9C", VA = "0xB82B9C")]
	[PunRPC]
	public void _ReapplyBuff(int userPhotonViewId, int nBuffID, Vector3 colPos, Vector3 colDir, int usingSkillId, int stackCount, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002666")]
	[Address(RVA = "0xB7A0C8", Offset = "0xB7A0C8", VA = "0xB7A0C8")]
	public void Die(int nAttackerPhotonID, int nAttackerPhotonViewID)
	{
	}

	[Token(Token = "0x6002667")]
	[Address(RVA = "0xB831D8", Offset = "0xB831D8", VA = "0xB831D8")]
	[PunRPC]
	public void _Die(int nVictimPhotonID, int streakKillCount, int nAttackerPhotonID, int nAttackerPhotonViewID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002668")]
	[Address(RVA = "0xB835CC", Offset = "0xB835CC", VA = "0xB835CC", Slot = "7")]
	protected virtual void _DieFunc(int nVictimPhotonID, int streakKillCount, int nAttackerPhotonID, int nAttackerPhotonViewID)
	{
	}

	[Token(Token = "0x6002669")]
	[Address(RVA = "0xB835D0", Offset = "0xB835D0", VA = "0xB835D0")]
	protected void OnDieEventToModule([Optional] CSSkillInfo attackerSkillInfo)
	{
	}

	[Token(Token = "0x600266A")]
	[Address(RVA = "0xB8382C", Offset = "0xB8382C", VA = "0xB8382C", Slot = "8")]
	public virtual void ReviveTargetPlayer(XModuleEntity srcTarget)
	{
	}

	[Token(Token = "0x600266B")]
	[Address(RVA = "0xB83830", Offset = "0xB83830", VA = "0xB83830", Slot = "9")]
	public virtual void SyncHP(int nCurrentHP)
	{
	}

	[Token(Token = "0x600266C")]
	[Address(RVA = "0xB83834", Offset = "0xB83834", VA = "0xB83834", Slot = "10")]
	public virtual void MultiKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x600266D")]
	[Address(RVA = "0xB83838", Offset = "0xB83838", VA = "0xB83838", Slot = "11")]
	public virtual void StreakKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x600266E")]
	[Address(RVA = "0xB8383C", Offset = "0xB8383C", VA = "0xB8383C", Slot = "12")]
	public virtual void ShutDownKill(int charID, int contumeID, int profileIconID, int titleID, string userName)
	{
	}

	[Token(Token = "0x600266F")]
	[Address(RVA = "0xB83840", Offset = "0xB83840", VA = "0xB83840", Slot = "13")]
	public virtual void ChangeActorCharacterStatus()
	{
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0xB83844", Offset = "0xB83844", VA = "0xB83844", Slot = "14")]
	public virtual void ActorTagWithoutTagSkill()
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0xB83848", Offset = "0xB83848", VA = "0xB83848", Slot = "15")]
	public virtual void SetOrderList(List<int> orderList, int orderIndex)
	{
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0xB8384C", Offset = "0xB8384C", VA = "0xB8384C", Slot = "16")]
	public virtual void Respawn(float x, float y, float z, bool notFullHp)
	{
	}

	[Token(Token = "0x6002673")]
	[Address(RVA = "0xB83850", Offset = "0xB83850", VA = "0xB83850", Slot = "17")]
	public virtual void ChangeCharacter(int nCharID, int nSkinId, int nCharLevel, bool pvp, Dictionary<DoubleKey, int> skills, Netdata_EquipedItem[] equipedItems)
	{
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0xB83854", Offset = "0xB83854", VA = "0xB83854", Slot = "18")]
	public virtual void CaughtByTheTagger()
	{
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0xB83858", Offset = "0xB83858", VA = "0xB83858", Slot = "19")]
	public virtual void NetAISetTarget(XModuleEntity target)
	{
	}

	[Token(Token = "0x6002676")]
	[Address(RVA = "0xB8385C", Offset = "0xB8385C", VA = "0xB8385C", Slot = "20")]
	public virtual void InitSpeedHack()
	{
	}

	[Token(Token = "0x6002677")]
	[Address(RVA = "0xB83860", Offset = "0xB83860", VA = "0xB83860", Slot = "21")]
	public virtual bool IsReadyToSync()
	{
		return default(bool);
	}

	[Token(Token = "0x6002678")]
	[Address(RVA = "0xB83868", Offset = "0xB83868", VA = "0xB83868", Slot = "22")]
	public virtual void ShowPet(bool isNotShow)
	{
	}
}
