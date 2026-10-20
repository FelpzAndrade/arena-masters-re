using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200047E")]
public class XModuleNetControl : XModuleBase
{
	[Token(Token = "0x400169F")]
	[FieldOffset(Offset = "0x10")]
	protected XModulePhoton m_photon;

	[Token(Token = "0x17000627")]
	public virtual XModulePhoton ModulePhoton
	{
		[Token(Token = "0x600261C")]
		[Address(RVA = "0xB78E60", Offset = "0xB78E60", VA = "0xB78E60", Slot = "59")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000628")]
	public string Name
	{
		[Token(Token = "0x600261D")]
		[Address(RVA = "0xB66170", Offset = "0xB66170", VA = "0xB66170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600261A")]
	[Address(RVA = "0xB78DD8", Offset = "0xB78DD8", VA = "0xB78DD8")]
	public XModuleNetControl()
	{
	}

	[Token(Token = "0x600261B")]
	[Address(RVA = "0xB78DE8", Offset = "0xB78DE8", VA = "0xB78DE8", Slot = "4")]
	public override string GetTypeStr()
	{
		return null;
	}

	[Token(Token = "0x600261E")]
	[Address(RVA = "0xB78F9C", Offset = "0xB78F9C", VA = "0xB78F9C", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x600261F")]
	[Address(RVA = "0xB5DD38", Offset = "0xB5DD38", VA = "0xB5DD38")]
	internal bool IsMine()
	{
		return default(bool);
	}

	[Token(Token = "0x6002620")]
	[Address(RVA = "0xB76398", Offset = "0xB76398", VA = "0xB76398")]
	internal void SyncMoveStart(Vector3 dir, float curMoveSpeed)
	{
	}

	[Token(Token = "0x6002621")]
	[Address(RVA = "0xB76414", Offset = "0xB76414", VA = "0xB76414")]
	internal void SyncMoveTurn(Vector3 dir, float curMoveSpeed)
	{
	}

	[Token(Token = "0x6002622")]
	[Address(RVA = "0xB76490", Offset = "0xB76490", VA = "0xB76490")]
	public void SyncStop()
	{
	}

	[Token(Token = "0x6002623")]
	[Address(RVA = "0xB62380", Offset = "0xB62380", VA = "0xB62380")]
	public void MyDie(int nAttackerPhotonID, int nAttackerPhotonViewID)
	{
	}

	[Token(Token = "0x6002624")]
	[Address(RVA = "0xB7A6DC", Offset = "0xB7A6DC", VA = "0xB7A6DC")]
	internal void SyncHP(int p)
	{
	}

	[Token(Token = "0x6002625")]
	[Address(RVA = "0xB602C4", Offset = "0xB602C4", VA = "0xB602C4")]
	internal void DoHitDamage(XModuleEntity attackerME, CSSkillInfo attackerSkillInfo, int nDamage, int pureDamage, bool bIsDropObject, bool bCritical, bool bDodged, bool bDotDamage = false)
	{
	}

	[Token(Token = "0x6002626")]
	[Address(RVA = "0xB6076C", Offset = "0xB6076C", VA = "0xB6076C")]
	internal void DoHitHeal(int nHeal, bool bIsDropObject, bool bCritical)
	{
	}

	[Token(Token = "0x6002627")]
	[Address(RVA = "0xB7B6A0", Offset = "0xB7B6A0", VA = "0xB7B6A0")]
	internal void UseSkill(int nSkillID, Vector3 pos, Vector3 dir, XModuleEntity target, bool cancelCurrent)
	{
	}

	[Token(Token = "0x6002628")]
	[Address(RVA = "0xB7BECC", Offset = "0xB7BECC", VA = "0xB7BECC")]
	internal void UseRelicSkill(int nSkillID, Vector3 pos, Vector3 dir, XModuleEntity target)
	{
	}

	[Token(Token = "0x6002629")]
	[Address(RVA = "0xB7C614", Offset = "0xB7C614", VA = "0xB7C614")]
	internal void UsePassiveSkill(int nSkillID, Vector3 pos, Vector3 dir, XModuleEntity target)
	{
	}

	[Token(Token = "0x600262A")]
	[Address(RVA = "0xB64E84", Offset = "0xB64E84", VA = "0xB64E84")]
	internal void MultiKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x600262B")]
	[Address(RVA = "0xB653C4", Offset = "0xB653C4", VA = "0xB653C4")]
	internal void StreakKill(int charID, int contumeID, int profileIconID, int titleID, string userName, int killCount)
	{
	}

	[Token(Token = "0x600262C")]
	[Address(RVA = "0xB65A4C", Offset = "0xB65A4C", VA = "0xB65A4C")]
	internal void ShutDownKill(int charID, int contumeID, int profileIconID, int titleID, string userName)
	{
	}

	[Token(Token = "0x600262D")]
	[Address(RVA = "0xB76554", Offset = "0xB76554", VA = "0xB76554")]
	internal void Warp(Vector3 vPos, Vector3 vDir)
	{
	}

	[Token(Token = "0x600262E")]
	[Address(RVA = "0xB7CF60", Offset = "0xB7CF60", VA = "0xB7CF60")]
	internal void ShowPet(bool isNotShow)
	{
	}
}
