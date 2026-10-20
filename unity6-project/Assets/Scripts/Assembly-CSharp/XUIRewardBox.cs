using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C69")]
public class XUIRewardBox : XUIMessageBox
{
	[Token(Token = "0x2000C6A")]
	private sealed class _003CBuildCharacterCardModel_003Ec__AnonStorey17E
	{
		[Token(Token = "0x4003EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string strTitle;

		[Token(Token = "0x4003EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string strMessage;

		[Token(Token = "0x4003EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XMessageBoxButtons nButtons;

		[Token(Token = "0x4003EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal string bottomText;

		[Token(Token = "0x4003EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Action delegateOK;

		[Token(Token = "0x4003EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal CSContent[] rewards;

		[Token(Token = "0x4003EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool mail;

		[Token(Token = "0x4003EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		internal bool bCenter;

		[Token(Token = "0x4003EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal XUIRewardBox _003C_003Ef__this;

		[Token(Token = "0x60059A5")]
		[Address(RVA = "0x191CF88", Offset = "0x191CF88", VA = "0x191CF88")]
		public _003CBuildCharacterCardModel_003Ec__AnonStorey17E()
		{
		}

		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x191D220", Offset = "0x191D220", VA = "0x191D220")]
		internal void _003C_003Em__258()
		{
		}
	}

	[Token(Token = "0x4003EE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public XWiget_GridBuilder gridRewards;

	[Token(Token = "0x4003EE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string soundKey;

	[Token(Token = "0x4003EE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public UILabel lblMail;

	[Token(Token = "0x4003EE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UILabel lblBottomText;

	[Token(Token = "0x4003EE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public TweenAlpha tweenHide;

	[Token(Token = "0x4003EE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TweenScale tweenScale;

	[Token(Token = "0x4003EEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public UISprite sprDecoTop;

	[Token(Token = "0x4003EEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UISprite sprDecoBottom;

	[Token(Token = "0x4003EEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int rewardItemWidthInterval;

	[Token(Token = "0x4003EED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject tweenrPanel;

	[Token(Token = "0x4003EEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Action onHideDelegate;

	[Token(Token = "0x4003EEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x6005996")]
	[Address(RVA = "0x191BFB8", Offset = "0x191BFB8", VA = "0x191BFB8")]
	public XUIRewardBox()
	{
	}

	[Token(Token = "0x6005997")]
	[Address(RVA = "0x191C044", Offset = "0x191C044", VA = "0x191C044")]
	public void Show(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] CSContentReward[] rewards, bool mail = false, bool bCenter = false)
	{
	}

	[Token(Token = "0x6005998")]
	[Address(RVA = "0x191C9F0", Offset = "0x191C9F0", VA = "0x191C9F0")]
	public void Show(string strTitle, string strMessage, XMessageBoxButtons nButtons, string bottomText, [Optional] Action delegateOK, [Optional] CSContent[] rewards, bool mail = false, bool bCenter = false)
	{
	}

	[Token(Token = "0x6005999")]
	[Address(RVA = "0x191CB00", Offset = "0x191CB00", VA = "0x191CB00")]
	private bool InVaildGridReward(ref CSContent[] rewards)
	{
		return default(bool);
	}

	[Token(Token = "0x600599A")]
	[Address(RVA = "0x191CC28", Offset = "0x191CC28", VA = "0x191CC28")]
	private void SetDecoWidth(ref CSContent[] rewards)
	{
	}

	[Token(Token = "0x600599B")]
	[Address(RVA = "0x191C6D4", Offset = "0x191C6D4", VA = "0x191C6D4")]
	private void ShowRewardBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, string bottomText, Action delegateOK, CSContent[] rewards, bool mail, bool bCenter)
	{
	}

	[Token(Token = "0x600599C")]
	[Address(RVA = "0x191CF54", Offset = "0x191CF54", VA = "0x191CF54")]
	private XWidget_ContentIcon.Option GetContentOption()
	{
		return default(XWidget_ContentIcon.Option);
	}

	[Token(Token = "0x600599D")]
	[Address(RVA = "0x191C4C4", Offset = "0x191C4C4", VA = "0x191C4C4")]
	private void BuildCharacterCardModel(int charId, int skinId, string strTitle, string strMessage, XMessageBoxButtons nButtons, string bottomText, Action delegateOK, CSContent[] rewards, bool mail, bool bCenter)
	{
	}

	[Token(Token = "0x600599E")]
	[Address(RVA = "0x191CF90", Offset = "0x191CF90", VA = "0x191CF90")]
	private int GetCharacterID(CSContent[] rewards)
	{
		return default(int);
	}

	[Token(Token = "0x600599F")]
	[Address(RVA = "0x191C384", Offset = "0x191C384", VA = "0x191C384")]
	private void GetCharModelInfo(CSContent[] beforeRewards, CSContent[] afterRewards, out int charID, out int skinID)
	{
		charID = default;
		skinID = default;
	}

	[Token(Token = "0x60059A0")]
	[Address(RVA = "0x191CCC0", Offset = "0x191CCC0", VA = "0x191CCC0")]
	public void BuildTweenAlpha()
	{
	}

	[Token(Token = "0x60059A1")]
	[Address(RVA = "0x191D0F8", Offset = "0x191D0F8", VA = "0x191D0F8")]
	public new void Hide()
	{
	}

	[Token(Token = "0x60059A2")]
	[Address(RVA = "0x191D000", Offset = "0x191D000", VA = "0x191D000")]
	private UITweener[] GetTweeners(GameObject m_object)
	{
		return null;
	}

	[Token(Token = "0x60059A3")]
	[Address(RVA = "0x191D148", Offset = "0x191D148", VA = "0x191D148")]
	private void _003CBuildTweenAlpha_003Em__259()
	{
	}

	[Token(Token = "0x60059A4")]
	[Address(RVA = "0x191D14C", Offset = "0x191D14C", VA = "0x191D14C")]
	private void _003CBuildTweenAlpha_003Em__25A()
	{
	}
}
