using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000D70")]
public class XPanel_RevivePopup : MonoBehaviour
{
	[Token(Token = "0x400454D")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goFreeReviveDesc;

	[Token(Token = "0x400454E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblFreeRevive;

	[Token(Token = "0x400454F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goCrystalCost;

	[Token(Token = "0x4004550")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblCostCnt;

	[Token(Token = "0x4004551")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblBtnRevive;

	[Token(Token = "0x4004552")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_Button btnRevive;

	[Token(Token = "0x4004553")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_Button btnGiveUp;

	[Token(Token = "0x4004554")]
	[FieldOffset(Offset = "0x28")]
	private Action ReviveCallBack;

	[Token(Token = "0x4004555")]
	[FieldOffset(Offset = "0x2C")]
	private Action GiveUpCallBack;

	[Token(Token = "0x4004556")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_diePos;

	[Token(Token = "0x4004557")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_isFreeRiviveEnable;

	[Token(Token = "0x60062A7")]
	[Address(RVA = "0xAB7924", Offset = "0xAB7924", VA = "0xAB7924")]
	public XPanel_RevivePopup()
	{
	}

	[Token(Token = "0x60062A8")]
	[Address(RVA = "0xAB7968", Offset = "0xAB7968", VA = "0xAB7968")]
	private void RefreshNeedCost()
	{
	}

	[Token(Token = "0x60062A9")]
	[Address(RVA = "0xAB81C0", Offset = "0xAB81C0", VA = "0xAB81C0")]
	public void Show(Vector3 diePos, Action giveUpCallBack)
	{
	}

	[Token(Token = "0x60062AA")]
	[Address(RVA = "0xAB7F04", Offset = "0xAB7F04", VA = "0xAB7F04")]
	private void BuildButton(bool reviveEnable)
	{
	}

	[Token(Token = "0x60062AB")]
	[Address(RVA = "0xAB7C80", Offset = "0xAB7C80", VA = "0xAB7C80")]
	private void BuildCost(int cost, int freeReviveRemainCnt, bool fulfilCost)
	{
	}

	[Token(Token = "0x60062AC")]
	[Address(RVA = "0xAB7B58", Offset = "0xAB7B58", VA = "0xAB7B58")]
	private bool IsFulFilCrystal(int cost)
	{
		return default(bool);
	}

	[Token(Token = "0x60062AD")]
	[Address(RVA = "0xAB8300", Offset = "0xAB8300", VA = "0xAB8300")]
	public void Hide()
	{
	}

	[Token(Token = "0x60062AE")]
	[Address(RVA = "0xAB822C", Offset = "0xAB822C", VA = "0xAB822C")]
	public void TimeStop(bool isStop)
	{
	}

	[Token(Token = "0x60062AF")]
	[Address(RVA = "0xAB833C", Offset = "0xAB833C", VA = "0xAB833C")]
	public void packetRevive()
	{
	}

	[Token(Token = "0x60062B0")]
	[Address(RVA = "0xAB854C", Offset = "0xAB854C", VA = "0xAB854C")]
	public void Revive()
	{
	}

	[Token(Token = "0x60062B1")]
	[Address(RVA = "0xAB86F8", Offset = "0xAB86F8", VA = "0xAB86F8")]
	private void _003CpacketRevive_003Em__30F(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x60062B2")]
	[Address(RVA = "0xAB8AD8", Offset = "0xAB8AD8", VA = "0xAB8AD8")]
	private void _003CpacketRevive_003Em__310()
	{
	}

	[Token(Token = "0x60062B3")]
	[Address(RVA = "0xAB8ADC", Offset = "0xAB8ADC", VA = "0xAB8ADC")]
	private void _003CpacketRevive_003Em__311()
	{
	}
}
