using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200102A")]
public class XUIMissionItem : MonoBehaviour
{
	[Token(Token = "0x40056D1")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblMissionName;

	[Token(Token = "0x40056D2")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goSprLock;

	[Token(Token = "0x40056D3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goSprBg;

	[Token(Token = "0x40056D4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goSprTenBg;

	[Token(Token = "0x40056D5")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject rewardParent;

	[Token(Token = "0x40056D6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goSprBase;

	[Token(Token = "0x40056D7")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goSprLast;

	[Token(Token = "0x40056D8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goSprLockDoor;

	[Token(Token = "0x40056D9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goSprClearDoor;

	[Token(Token = "0x40056DA")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblLockLevel;

	[Token(Token = "0x40056DB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject goSkyTowerName;

	[Token(Token = "0x40056DC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject goSprEffectWidget;

	[Token(Token = "0x40056DD")]
	[FieldOffset(Offset = "0x3C")]
	private int m_infoIndex;

	[Token(Token = "0x40056DE")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public XWidget_ContentIcon m_reward;

	[Token(Token = "0x40056DF")]
	[FieldOffset(Offset = "0x44")]
	private CSStageInfo m_missionInfo;

	[Token(Token = "0x17000EFE")]
	public int StageIndex
	{
		[Token(Token = "0x60078A0")]
		[Address(RVA = "0x10D1C04", Offset = "0x10D1C04", VA = "0x10D1C04")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600789F")]
	[Address(RVA = "0x10D1BFC", Offset = "0x10D1BFC", VA = "0x10D1BFC")]
	public XUIMissionItem()
	{
	}

	[Token(Token = "0x60078A1")]
	[Address(RVA = "0x10D1C18", Offset = "0x10D1C18", VA = "0x10D1C18")]
	public void Build(CSStageInfo missionInfo, int infoIndex, bool ten, bool lastItem, bool listBaseSprite = false)
	{
	}

	[Token(Token = "0x60078A2")]
	[Address(RVA = "0x10D2928", Offset = "0x10D2928", VA = "0x10D2928")]
	private bool GetMissionTeamLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x60078A3")]
	[Address(RVA = "0x10D2828", Offset = "0x10D2828", VA = "0x10D2828")]
	private void BuildName(XGameModeType mode, string fullName)
	{
	}

	[Token(Token = "0x60078A4")]
	[Address(RVA = "0x10D2A18", Offset = "0x10D2A18", VA = "0x10D2A18")]
	public void OnClick_MissionItem()
	{
	}
}
