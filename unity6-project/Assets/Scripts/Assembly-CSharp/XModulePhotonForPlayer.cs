using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000485")]
public class XModulePhotonForPlayer : XModulePhoton
{
	[Token(Token = "0x40016B7")]
	private const float m_checkTime = 4f;

	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x68")]
	private float m_time;

	[Token(Token = "0x40016B9")]
	[FieldOffset(Offset = "0x6C")]
	private bool isResetSpeedHack;

	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0x70")]
	private float m_lastPostTime;

	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_RecvBufPosition;

	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0x80")]
	private HashSet<PhotonPlayer> requestHelloQueue;

	[Token(Token = "0x40016BD")]
	[FieldOffset(Offset = "0x84")]
	private bool readyToSync;

	[Token(Token = "0x6002684")]
	[Address(RVA = "0xB84624", Offset = "0xB84624", VA = "0xB84624")]
	public XModulePhotonForPlayer()
	{
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0xB8470C", Offset = "0xB8470C", VA = "0xB8470C", Slot = "21")]
	public override bool IsReadyToSync()
	{
		return default(bool);
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0xB84714", Offset = "0xB84714", VA = "0xB84714")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002687")]
	[Address(RVA = "0xB84720", Offset = "0xB84720", VA = "0xB84720", Slot = "20")]
	public override void InitSpeedHack()
	{
	}

	[Token(Token = "0x6002688")]
	[Address(RVA = "0xB8472C", Offset = "0xB8472C", VA = "0xB8472C")]
	private void SpeedHackCheck()
	{
	}

	[Token(Token = "0x6002689")]
	[Address(RVA = "0xB84900", Offset = "0xB84900", VA = "0xB84900")]
	private bool CheckResetSpeedHack()
	{
		return default(bool);
	}

	[Token(Token = "0x600268A")]
	[Address(RVA = "0xB84908", Offset = "0xB84908", VA = "0xB84908")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600268B")]
	[Address(RVA = "0xB84918", Offset = "0xB84918", VA = "0xB84918")]
	private void InitNetPlayer(bool balanceRegulate, bool pvp, int relicId, int relicLevel, Dictionary<int, int> talentSkills, Netdata_CreationDesc creatiionDesc, int charIndex, float ultCharge, Netdata_Buff[] buffData, Netdata_XShieldBuff shieldBuffData, int emblemID)
	{
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0xB84D60", Offset = "0xB84D60", VA = "0xB84D60")]
	private bool IsSyncPositionY()
	{
		return default(bool);
	}

	[Token(Token = "0x600268D")]
	[Address(RVA = "0xB84EB4", Offset = "0xB84EB4", VA = "0xB84EB4")]
	private void Update()
	{
	}

	[Token(Token = "0x600268E")]
	[Address(RVA = "0xB84FB8", Offset = "0xB84FB8", VA = "0xB84FB8")]
	public void OnPhotonInstantiate(PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600268F")]
	[Address(RVA = "0xB85184", Offset = "0xB85184", VA = "0xB85184")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
	{
	}

	[Token(Token = "0x6002690")]
	[Address(RVA = "0xB852B0", Offset = "0xB852B0", VA = "0xB852B0")]
	private void ResetSpeedValues()
	{
	}

	[Token(Token = "0x6002691")]
	[Address(RVA = "0xB852B4", Offset = "0xB852B4", VA = "0xB852B4")]
	private void UpdateMovement()
	{
	}

	[Token(Token = "0x6002692")]
	[Address(RVA = "0xB852B8", Offset = "0xB852B8", VA = "0xB852B8")]
	private void ApplySynchronizedValues()
	{
	}

	[Token(Token = "0x6002693")]
	[Address(RVA = "0xB852BC", Offset = "0xB852BC", VA = "0xB852BC")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6002694")]
	[Address(RVA = "0xB85410", Offset = "0xB85410", VA = "0xB85410")]
	private void UpdateActionState(XMoveState state)
	{
	}

	[Token(Token = "0x6002695")]
	[Address(RVA = "0xB854C4", Offset = "0xB854C4", VA = "0xB854C4")]
	private void RequestHello()
	{
	}

	[Token(Token = "0x6002696")]
	[Address(RVA = "0xB85840", Offset = "0xB85840", VA = "0xB85840", Slot = "6")]
	public override void ReadyToSync()
	{
	}

	[Token(Token = "0x6002697")]
	[Address(RVA = "0xB8708C", Offset = "0xB8708C", VA = "0xB8708C")]
	[PunRPC]
	public void _RequestHello(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002698")]
	[Address(RVA = "0xB859A4", Offset = "0xB859A4", VA = "0xB859A4")]
	private void Hello(PhotonPlayer sender)
	{
	}

	[Token(Token = "0x6002699")]
	[Address(RVA = "0xB87374", Offset = "0xB87374", VA = "0xB87374")]
	[PunRPC]
	public void _Hello(bool balanceRegulate, bool pvp, Dictionary<int, int> talentSkillPage, Netdata_CreationDesc creationDesc, int charIndex, NetData_PlayerInfo playerInfo, Vector3 pos, Vector3 dir, Netdata_Buff[] buffData, Netdata_XShieldBuff shieldBuffData, string countryCode, float hp, float shild, float ultCharge, int emblemID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600269A")]
	[Address(RVA = "0xB88244", Offset = "0xB88244", VA = "0xB88244", Slot = "16")]
	public override void Respawn(float x, float y, float z, bool notFullHp)
	{
	}

	[Token(Token = "0x600269B")]
	[Address(RVA = "0xB8883C", Offset = "0xB8883C", VA = "0xB8883C")]
	[PunRPC]
	public void _Respawn(float x, float y, float z, bool notFullHp, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600269C")]
	[Address(RVA = "0xB890D0", Offset = "0xB890D0", VA = "0xB890D0", Slot = "9")]
	public override void SyncHP(int nCurrentHP)
	{
	}

	[Token(Token = "0x600269D")]
	[Address(RVA = "0xB8940C", Offset = "0xB8940C", VA = "0xB8940C")]
	[PunRPC]
	public void _SyncHP(int nCurrentHP, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x600269E")]
	[Address(RVA = "0xB8821C", Offset = "0xB8821C", VA = "0xB8821C")]
	public void OnShow()
	{
	}

	[Token(Token = "0x600269F")]
	[Address(RVA = "0xB881F4", Offset = "0xB881F4", VA = "0xB881F4")]
	public void OnHide()
	{
	}

	[Token(Token = "0x60026A0")]
	[Address(RVA = "0xB89704", Offset = "0xB89704", VA = "0xB89704")]
	private bool isEscapedIgnore(int photonPlayerID)
	{
		return default(bool);
	}

	[Token(Token = "0x60026A1")]
	[Address(RVA = "0xB897F4", Offset = "0xB897F4", VA = "0xB897F4", Slot = "18")]
	public override void CaughtByTheTagger()
	{
	}

	[Token(Token = "0x60026A2")]
	[Address(RVA = "0xB89A38", Offset = "0xB89A38", VA = "0xB89A38")]
	[PunRPC]
	public void _CaughtByTheTagger(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026A3")]
	[Address(RVA = "0xB89DC4", Offset = "0xB89DC4", VA = "0xB89DC4", Slot = "13")]
	public override void ChangeActorCharacterStatus()
	{
	}

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0xB8A008", Offset = "0xB8A008", VA = "0xB8A008")]
	[PunRPC]
	public void _ChangeActorCharacterStatus(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026A5")]
	[Address(RVA = "0xB8A218", Offset = "0xB8A218", VA = "0xB8A218", Slot = "14")]
	public override void ActorTagWithoutTagSkill()
	{
	}

	[Token(Token = "0x60026A6")]
	[Address(RVA = "0xB8A45C", Offset = "0xB8A45C", VA = "0xB8A45C")]
	[PunRPC]
	public void _ActorTagWithoutTagSkill(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026A7")]
	[Address(RVA = "0xB8A66C", Offset = "0xB8A66C", VA = "0xB8A66C", Slot = "15")]
	public override void SetOrderList(List<int> orderList, int orderIndex)
	{
	}

	[Token(Token = "0x60026A8")]
	[Address(RVA = "0xB8AC70", Offset = "0xB8AC70", VA = "0xB8AC70")]
	[PunRPC]
	public void _SetOrderList(List<int> orderList, int orderIndex, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026A9")]
	[Address(RVA = "0xB8AA80", Offset = "0xB8AA80", VA = "0xB8AA80")]
	private void KOFReadyOK()
	{
	}

	[Token(Token = "0x60026AA")]
	[Address(RVA = "0xB8AEA0", Offset = "0xB8AEA0", VA = "0xB8AEA0", Slot = "17")]
	public override void ChangeCharacter(int nCharID, int nSkinId, int nCharLevel, bool pvp, Dictionary<DoubleKey, int> skills, Netdata_EquipedItem[] equipedItems)
	{
	}

	[Token(Token = "0x60026AB")]
	[Address(RVA = "0xB8B1F4", Offset = "0xB8B1F4", VA = "0xB8B1F4")]
	[PunRPC]
	public void _ChangeCharacter(int nCharID, int nSkinId, int nCharLevel, bool pvp, SkillSpecialized specialized_skill_list, Netdata_EquipedItem[] equipedItems, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026AC")]
	[Address(RVA = "0xB8B3C4", Offset = "0xB8B3C4", VA = "0xB8B3C4", Slot = "10")]
	public override void MultiKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x60026AD")]
	[Address(RVA = "0xB8B72C", Offset = "0xB8B72C", VA = "0xB8B72C")]
	[PunRPC]
	public void _MultiKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026AE")]
	[Address(RVA = "0xB8B7BC", Offset = "0xB8B7BC", VA = "0xB8B7BC", Slot = "11")]
	public override void StreakKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x60026AF")]
	[Address(RVA = "0xB8BB24", Offset = "0xB8BB24", VA = "0xB8BB24")]
	[PunRPC]
	public void _StreakKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026B0")]
	[Address(RVA = "0xB8BBB4", Offset = "0xB8BBB4", VA = "0xB8BBB4", Slot = "12")]
	public override void ShutDownKill(int charID, int contumeID, int profileIconID, int titleID, string userName)
	{
	}

	[Token(Token = "0x60026B1")]
	[Address(RVA = "0xB8BEB4", Offset = "0xB8BEB4", VA = "0xB8BEB4")]
	[PunRPC]
	public void _ShutDownKill(int charID, int contumeID, int profileIconID, int titleID, string userName, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0xB8BF3C", Offset = "0xB8BF3C", VA = "0xB8BF3C", Slot = "7")]
	protected override void _DieFunc(int nVictimPhotonID, int streakKillCount, int nAttackerPhotonID, int nAttackerPhotonViewID)
	{
	}

	[Token(Token = "0x60026B3")]
	[Address(RVA = "0xB8C130", Offset = "0xB8C130", VA = "0xB8C130")]
	private void OnDie(int nVictimPhotonID, int streakKillCount, int nAttackerPhotonID, int nAttackerPhotonViewID)
	{
	}

	[Token(Token = "0x60026B4")]
	[Address(RVA = "0xB8C620", Offset = "0xB8C620", VA = "0xB8C620", Slot = "8")]
	public override void ReviveTargetPlayer(XModuleEntity srcTarget)
	{
	}

	[Token(Token = "0x60026B5")]
	[Address(RVA = "0xB8CA24", Offset = "0xB8CA24", VA = "0xB8CA24")]
	[PunRPC]
	public void _ReviveTargetPlayer(int nTargetPhotonID, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x60026B6")]
	[Address(RVA = "0xB8CCE8", Offset = "0xB8CCE8", VA = "0xB8CCE8")]
	private bool CheckDoRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x60026B7")]
	[Address(RVA = "0xB8CDC4", Offset = "0xB8CDC4", VA = "0xB8CDC4", Slot = "22")]
	public override void ShowPet(bool isNotShow)
	{
	}

	[Token(Token = "0x60026B8")]
	[Address(RVA = "0xB8CF24", Offset = "0xB8CF24", VA = "0xB8CF24")]
	[PunRPC]
	public void _ShowPet(bool isNotShow)
	{
	}
}
