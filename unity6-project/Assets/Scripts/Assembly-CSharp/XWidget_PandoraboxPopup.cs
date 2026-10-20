using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FC6")]
public class XWidget_PandoraboxPopup : XUIBaseWidget
{
	[Token(Token = "0x40053D9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblCurReciveRewardName;

	[Token(Token = "0x40053DA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblCurReciveRewardDesc;

	[Token(Token = "0x40053DB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblRemainCount;

	[Token(Token = "0x40053DC")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_Button btnReceive;

	[Token(Token = "0x40053DD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goRoot;

	[Token(Token = "0x40053DE")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_CoolTime curCooltime;

	[Token(Token = "0x40053DF")]
	[FieldOffset(Offset = "0x34")]
	public XWiget_GridBuilder rewardIconBuilder;

	[Token(Token = "0x40053E0")]
	[FieldOffset(Offset = "0x38")]
	public TweenRotation tweenCoolEnd;

	[Token(Token = "0x40053E1")]
	[FieldOffset(Offset = "0x3C")]
	private Action onShowDetailPopup;

	[Token(Token = "0x40053E2")]
	[FieldOffset(Offset = "0x40")]
	private string strTitle;

	[Token(Token = "0x40053E3")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x6007579")]
	[Address(RVA = "0x1313478", Offset = "0x1313478", VA = "0x1313478")]
	public XWidget_PandoraboxPopup()
	{
	}

	[Token(Token = "0x600757A")]
	[Address(RVA = "0x1313480", Offset = "0x1313480", VA = "0x1313480")]
	private void TweenClockReset()
	{
	}

	[Token(Token = "0x600757B")]
	[Address(RVA = "0x1313508", Offset = "0x1313508", VA = "0x1313508")]
	private void Awake()
	{
	}

	[Token(Token = "0x600757C")]
	[Address(RVA = "0x131359C", Offset = "0x131359C", VA = "0x131359C")]
	public void Show(Action onShowDetailPopup)
	{
	}

	[Token(Token = "0x600757D")]
	[Address(RVA = "0x1313B74", Offset = "0x1313B74", VA = "0x1313B74")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600757E")]
	[Address(RVA = "0x13135F4", Offset = "0x13135F4", VA = "0x13135F4")]
	private void Build()
	{
	}

	[Token(Token = "0x600757F")]
	[Address(RVA = "0x1314178", Offset = "0x1314178", VA = "0x1314178")]
	private void BuildCoolTime(CSPandoraBoxData pandoradata, long lastCoolStamp)
	{
	}

	[Token(Token = "0x6007580")]
	[Address(RVA = "0x1313B78", Offset = "0x1313B78", VA = "0x1313B78")]
	private void BuildPandoraRewardContentImgs(CSPandoraBoxData pandoradata)
	{
	}

	[Token(Token = "0x6007581")]
	[Address(RVA = "0x1314280", Offset = "0x1314280", VA = "0x1314280")]
	private void EndCoolTime()
	{
	}

	[Token(Token = "0x6007582")]
	[Address(RVA = "0x1314380", Offset = "0x1314380", VA = "0x1314380")]
	private void ShowRewardBox(string titleText, CSContentReward[] contents)
	{
	}

	[Token(Token = "0x6007583")]
	[Address(RVA = "0x1314534", Offset = "0x1314534", VA = "0x1314534")]
	private void HideByLastRecieved()
	{
	}

	[Token(Token = "0x6007584")]
	[Address(RVA = "0x131467C", Offset = "0x131467C", VA = "0x131467C")]
	private void ShowErrorMessage(ApiReturnCode errorcode)
	{
	}

	[Token(Token = "0x6007585")]
	[Address(RVA = "0x1314988", Offset = "0x1314988", VA = "0x1314988")]
	public void OnClick_Recive()
	{
	}

	[Token(Token = "0x6007586")]
	[Address(RVA = "0x1314BAC", Offset = "0x1314BAC", VA = "0x1314BAC")]
	private void SendLocalPushForFreeItem()
	{
	}

	[Token(Token = "0x6007587")]
	[Address(RVA = "0x13151C8", Offset = "0x13151C8", VA = "0x13151C8")]
	public void OnClick_ShowDeatilPopup()
	{
	}

	[Token(Token = "0x6007588")]
	[Address(RVA = "0x13151DC", Offset = "0x13151DC", VA = "0x13151DC")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6007589")]
	[Address(RVA = "0x13152B4", Offset = "0x13152B4", VA = "0x13152B4")]
	private static void _003CBuild_003Em__4D6()
	{
	}

	[Token(Token = "0x600758A")]
	[Address(RVA = "0x13153F0", Offset = "0x13153F0", VA = "0x13153F0")]
	private void _003COnClick_Recive_003Em__4D7(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
