using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200046D")]
public class XHealthBarMgr : CSPoolEntry
{
	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x8")]
	private Camera m_GameCam;

	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0xC")]
	private Camera m_UICam;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x10")]
	private InterfaceCharacter m_interfaceCharacter;

	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0x14")]
	private float m_fOffsetHeight;

	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0x18")]
	public float m_HealthBarOffset;

	[Token(Token = "0x4001619")]
	[FieldOffset(Offset = "0x1C")]
	private int m_charId;

	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0x20")]
	private string m_strName;

	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x24")]
	private bool m_hasTag;

	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0x25")]
	private bool m_isEnemy;

	[Token(Token = "0x600250B")]
	[Address(RVA = "0x1D175B0", Offset = "0x1D175B0", VA = "0x1D175B0")]
	public XHealthBarMgr()
	{
	}

	[Token(Token = "0x600250C")]
	[Address(RVA = "0x1D175C4", Offset = "0x1D175C4", VA = "0x1D175C4", Slot = "4")]
	public void OnCleanupInObjectPool()
	{
	}

	[Token(Token = "0x600250D")]
	[Address(RVA = "0x1D175C8", Offset = "0x1D175C8", VA = "0x1D175C8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600250E")]
	[Address(RVA = "0x1D175CC", Offset = "0x1D175CC", VA = "0x1D175CC")]
	public void PlayHittedTween()
	{
	}

	[Token(Token = "0x600250F")]
	[Address(RVA = "0x1D176A4", Offset = "0x1D176A4", VA = "0x1D176A4")]
	public void InitUltOnGameObject()
	{
	}

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x1D1777C", Offset = "0x1D1777C", VA = "0x1D1777C")]
	public string GetNickName()
	{
		return null;
	}

	[Token(Token = "0x6002511")]
	[Address(RVA = "0x1D17784", Offset = "0x1D17784", VA = "0x1D17784")]
	public void InitHealthBar(Camera gameCam, Camera uiCam, string name, int level, bool isEnemy, float fOffectHeight, int charId, Sprite tagCharIcon, bool ultOn, int emblemID)
	{
	}

	[Token(Token = "0x6002512")]
	[Address(RVA = "0x1D17C64", Offset = "0x1D17C64", VA = "0x1D17C64")]
	public void UpdateHealthBar(Vector3 vMyPos, bool isEnemy, float curHp, float maxHp, float curShield, float maxShield, bool hide, float tagCool, float remainTagCool)
	{
	}

	[Token(Token = "0x6002513")]
	[Address(RVA = "0x1D17DF8", Offset = "0x1D17DF8", VA = "0x1D17DF8")]
	private void UpdateHealthBar(Vector3 vEntityPosition, float nCurrentHP, float nMaxHP, float nCurrentShield, float tagRemain, float tagCool, bool isEnemy)
	{
	}

	[Token(Token = "0x6002514")]
	[Address(RVA = "0x1D17F90", Offset = "0x1D17F90", VA = "0x1D17F90")]
	private void UpdatePlayerDebugInfo(float nCurrentHP, float nMaxHP, float nCurrentShield, float nMaxShield)
	{
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x1D17B84", Offset = "0x1D17B84", VA = "0x1D17B84")]
	public void SetName(string strName)
	{
	}

	[Token(Token = "0x6002516")]
	[Address(RVA = "0x1D17F94", Offset = "0x1D17F94", VA = "0x1D17F94")]
	public void SetTagCharacterThumbnail(Sprite spr)
	{
	}

	[Token(Token = "0x6002517")]
	[Address(RVA = "0x1D17FC0", Offset = "0x1D17FC0", VA = "0x1D17FC0")]
	public void Final()
	{
	}

	[Token(Token = "0x6002518")]
	[Address(RVA = "0x1D18174", Offset = "0x1D18174", VA = "0x1D18174")]
	public void Hide(bool val)
	{
	}

	[Token(Token = "0x6002519")]
	[Address(RVA = "0x1D18254", Offset = "0x1D18254", VA = "0x1D18254")]
	public void UpdateUltOn(bool ultOn)
	{
	}
}
