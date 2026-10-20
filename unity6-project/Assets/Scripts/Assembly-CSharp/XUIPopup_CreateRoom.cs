using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD5")]
public class XUIPopup_CreateRoom : XUIBaseWidget
{
	[Token(Token = "0x400415F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblPrivateRoomDesc;

	[Token(Token = "0x4004160")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblCombatPowerCorrectionDesc;

	[Token(Token = "0x4004161")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblInputRoomName;

	[Token(Token = "0x4004162")]
	[FieldOffset(Offset = "0x28")]
	public UIInput inputRoomName;

	[Token(Token = "0x4004163")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput inputPassword;

	[Token(Token = "0x4004164")]
	[FieldOffset(Offset = "0x30")]
	public UIInput inputPasswordDisable;

	[Token(Token = "0x4004165")]
	[FieldOffset(Offset = "0x34")]
	public UILabel selectedMode;

	[Token(Token = "0x4004166")]
	[FieldOffset(Offset = "0x38")]
	public UILabel selectedMap;

	[Token(Token = "0x4004167")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject goSetKill;

	[Token(Token = "0x4004168")]
	[FieldOffset(Offset = "0x40")]
	public GameObject goSetTime;

	[Token(Token = "0x4004169")]
	[FieldOffset(Offset = "0x44")]
	public GameObject goDisableKill;

	[Token(Token = "0x400416A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject goDisableTime;

	[Token(Token = "0x400416B")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel setKill;

	[Token(Token = "0x400416C")]
	[FieldOffset(Offset = "0x50")]
	public UILabel setTime;

	[Token(Token = "0x400416D")]
	[FieldOffset(Offset = "0x54")]
	public UILabel disableKill;

	[Token(Token = "0x400416E")]
	[FieldOffset(Offset = "0x58")]
	public UILabel disableTime;

	[Token(Token = "0x400416F")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject cbPrivate;

	[Token(Token = "0x4004170")]
	[FieldOffset(Offset = "0x60")]
	public GameObject goCombatPowerCorrectionOn;

	[Token(Token = "0x4004171")]
	[FieldOffset(Offset = "0x64")]
	public GameObject goCombatPowerCorrectionOff;

	[Token(Token = "0x4004172")]
	[FieldOffset(Offset = "0x68")]
	public GameObject goCombatPowerCorrectionOnDisable;

	[Token(Token = "0x4004173")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject goCombatPowerCorrectionOffDisable;

	[Token(Token = "0x4004174")]
	[FieldOffset(Offset = "0x70")]
	public XWidget_Button btnCreate;

	[Token(Token = "0x4004175")]
	[FieldOffset(Offset = "0x74")]
	public XUISelectMode ModeSelect;

	[Token(Token = "0x4004176")]
	[FieldOffset(Offset = "0x78")]
	public XUISelectMap MapSelect;

	[Token(Token = "0x4004177")]
	[FieldOffset(Offset = "0x7C")]
	private XWidget_CustomRoomMaker m_Controller;

	[Token(Token = "0x6005CAB")]
	[Address(RVA = "0x190F610", Offset = "0x190F610", VA = "0x190F610")]
	public XUIPopup_CreateRoom()
	{
	}

	[Token(Token = "0x6005CAC")]
	[Address(RVA = "0x190F6AC", Offset = "0x190F6AC", VA = "0x190F6AC")]
	public void Build()
	{
	}

	[Token(Token = "0x6005CAD")]
	[Address(RVA = "0x190F8E8", Offset = "0x190F8E8", VA = "0x190F8E8")]
	private void BuildDesc()
	{
	}

	[Token(Token = "0x6005CAE")]
	[Address(RVA = "0x190FFB0", Offset = "0x190FFB0", VA = "0x190FFB0")]
	public void Show()
	{
	}

	[Token(Token = "0x6005CAF")]
	[Address(RVA = "0x190FA44", Offset = "0x190FA44", VA = "0x190FA44")]
	private void SyncUI()
	{
	}

	[Token(Token = "0x6005CB0")]
	[Address(RVA = "0x190FFFC", Offset = "0x190FFFC", VA = "0x190FFFC")]
	private void ChangeCBPrivateAbleState()
	{
	}

	[Token(Token = "0x6005CB1")]
	[Address(RVA = "0x190FF48", Offset = "0x190FF48", VA = "0x190FF48")]
	private void ChangeCombatPowerCorrectionAbleState()
	{
	}

	[Token(Token = "0x6005CB2")]
	[Address(RVA = "0x1910728", Offset = "0x1910728", VA = "0x1910728")]
	private void SetCombatPowerCorrectionDisableState()
	{
	}

	[Token(Token = "0x6005CB3")]
	[Address(RVA = "0x19107C0", Offset = "0x19107C0", VA = "0x19107C0")]
	private void SetCombatPowerCorrectionOnOffState()
	{
	}

	[Token(Token = "0x6005CB4")]
	[Address(RVA = "0x19108D4", Offset = "0x19108D4", VA = "0x19108D4")]
	private bool IsCombatPowerCorrectionOnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CB5")]
	[Address(RVA = "0x19109A8", Offset = "0x19109A8", VA = "0x19109A8")]
	public void ChangeCPCorrectionState(bool isOnOff)
	{
	}

	[Token(Token = "0x6005CB6")]
	[Address(RVA = "0x1910AA0", Offset = "0x1910AA0", VA = "0x1910AA0")]
	public void OnClick_CombatPowerCorrectionOn()
	{
	}

	[Token(Token = "0x6005CB7")]
	[Address(RVA = "0x1910AA8", Offset = "0x1910AA8", VA = "0x1910AA8")]
	public void OnClick_CombatPowerCorrectionOff()
	{
	}

	[Token(Token = "0x6005CB8")]
	[Address(RVA = "0x1910AB0", Offset = "0x1910AB0", VA = "0x1910AB0")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x6005CB9")]
	[Address(RVA = "0x1910BEC", Offset = "0x1910BEC", VA = "0x1910BEC")]
	public void OnClick_LeftModeSelect()
	{
	}

	[Token(Token = "0x6005CBA")]
	[Address(RVA = "0x1910D78", Offset = "0x1910D78", VA = "0x1910D78")]
	public void OnClick_RightModeSelect()
	{
	}

	[Token(Token = "0x6005CBB")]
	[Address(RVA = "0x1910ECC", Offset = "0x1910ECC", VA = "0x1910ECC")]
	public void OnClick_LeftMapSelect()
	{
	}

	[Token(Token = "0x6005CBC")]
	[Address(RVA = "0x1910F04", Offset = "0x1910F04", VA = "0x1910F04")]
	public void OnClick_RightMapSelect()
	{
	}

	[Token(Token = "0x6005CBD")]
	[Address(RVA = "0x1910F3C", Offset = "0x1910F3C", VA = "0x1910F3C")]
	public void OnClickCreateRoom()
	{
	}

	[Token(Token = "0x6005CBE")]
	[Address(RVA = "0x191180C", Offset = "0x191180C", VA = "0x191180C")]
	private CustomRoomInfo MakeRoomInfo()
	{
		return null;
	}

	[Token(Token = "0x6005CBF")]
	[Address(RVA = "0x1911BF0", Offset = "0x1911BF0", VA = "0x1911BF0")]
	private bool IsCostomAble()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CC0")]
	[Address(RVA = "0x1911C3C", Offset = "0x1911C3C", VA = "0x1911C3C")]
	public void OnChangePassword()
	{
	}

	[Token(Token = "0x6005CC1")]
	[Address(RVA = "0x1910D40", Offset = "0x1910D40", VA = "0x1910D40")]
	private void ChangeCustomAble()
	{
	}

	[Token(Token = "0x6005CC2")]
	[Address(RVA = "0x1911C40", Offset = "0x1911C40", VA = "0x1911C40")]
	public void OnClick_IncrementKill()
	{
	}

	[Token(Token = "0x6005CC3")]
	[Address(RVA = "0x1911C78", Offset = "0x1911C78", VA = "0x1911C78")]
	public void OnClick_DecrementKill()
	{
	}

	[Token(Token = "0x6005CC4")]
	[Address(RVA = "0x1911CB0", Offset = "0x1911CB0", VA = "0x1911CB0")]
	public void OnClick_IncrementTime()
	{
	}

	[Token(Token = "0x6005CC5")]
	[Address(RVA = "0x1911CE8", Offset = "0x1911CE8", VA = "0x1911CE8")]
	public void OnClick_DecrementTime()
	{
	}

	[Token(Token = "0x6005CC6")]
	[Address(RVA = "0x1911D20", Offset = "0x1911D20", VA = "0x1911D20")]
	public void OnClick_Private()
	{
	}

	[Token(Token = "0x6005CC7")]
	[Address(RVA = "0x1911D24", Offset = "0x1911D24", VA = "0x1911D24")]
	private void ChangePrivate()
	{
	}

	[Token(Token = "0x6005CC8")]
	[Address(RVA = "0x1911E90", Offset = "0x1911E90", VA = "0x1911E90")]
	public void OnSelectMode(int index)
	{
	}

	[Token(Token = "0x6005CC9")]
	[Address(RVA = "0x1912008", Offset = "0x1912008", VA = "0x1912008")]
	public void OnSelectMap(int index)
	{
	}

	[Token(Token = "0x6005CCA")]
	[Address(RVA = "0x1912064", Offset = "0x1912064", VA = "0x1912064")]
	public void OnClick_Help()
	{
	}
}
