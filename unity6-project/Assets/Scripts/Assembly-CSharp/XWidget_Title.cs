using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001002")]
public class XWidget_Title : XUIBaseWidget
{
	[Token(Token = "0x2001003")]
	public static class UILogic
	{
		[Token(Token = "0x6007778")]
		[Address(RVA = "0x1B24B7C", Offset = "0x1B24B7C", VA = "0x1B24B7C")]
		public static bool IsDetailButtonEnabled(bool titleOpened, bool titleUnlockable, bool titleChecked)
		{
			return default(bool);
		}

		[Token(Token = "0x6007779")]
		[Address(RVA = "0x1B241B4", Offset = "0x1B241B4", VA = "0x1B241B4")]
		public static bool IsTitleOpened(int nTitleId)
		{
			return default(bool);
		}

		[Token(Token = "0x600777A")]
		[Address(RVA = "0x1B24404", Offset = "0x1B24404", VA = "0x1B24404")]
		public static bool IsCurrentMyTitle(int nTitleId)
		{
			return default(bool);
		}

		[Token(Token = "0x600777B")]
		[Address(RVA = "0x1B2386C", Offset = "0x1B2386C", VA = "0x1B2386C")]
		public static TitleInfo GetCurrentMyTitleInfo()
		{
			return null;
		}

		[Token(Token = "0x600777C")]
		[Address(RVA = "0x1B24278", Offset = "0x1B24278", VA = "0x1B24278")]
		public static bool IsUnlockableTitle(TitleInfo titleInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001004")]
	private sealed class _003CReqSelectTitle_003Ec__AnonStorey255
	{
		[Token(Token = "0x400558C")]
		[FieldOffset(Offset = "0x8")]
		internal int nSelectedTitleId;

		[Token(Token = "0x400558D")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_Title _003C_003Ef__this;

		[Token(Token = "0x600777D")]
		[Address(RVA = "0x1B24048", Offset = "0x1B24048", VA = "0x1B24048")]
		public _003CReqSelectTitle_003Ec__AnonStorey255()
		{
		}

		[Token(Token = "0x600777E")]
		[Address(RVA = "0x1B2504C", Offset = "0x1B2504C", VA = "0x1B2504C")]
		internal void _003C_003Em__4FB(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x400557B")]
	[FieldOffset(Offset = "0x1C")]
	private TitleInfo m_SelectedTitleInfo;

	[Token(Token = "0x400557C")]
	[FieldOffset(Offset = "0x20")]
	private XUITitleItem m_SelectedTitleItem;

	[Token(Token = "0x400557D")]
	[FieldOffset(Offset = "0x24")]
	private XUITitleItem m_checkedTitleItem;

	[Token(Token = "0x400557E")]
	[FieldOffset(Offset = "0x28")]
	public XUITitleListView m_TitleListView;

	[Token(Token = "0x400557F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblSlotSetAndCancel;

	[Token(Token = "0x4005580")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite sprDetailIcon;

	[Token(Token = "0x4005581")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblDetailName;

	[Token(Token = "0x4005582")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblProgress;

	[Token(Token = "0x4005583")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject goDetailUnlock;

	[Token(Token = "0x4005584")]
	[FieldOffset(Offset = "0x40")]
	public UIProgressBar detailProgress;

	[Token(Token = "0x4005585")]
	[FieldOffset(Offset = "0x44")]
	public GameObject goBtnDisableSprite;

	[Token(Token = "0x4005586")]
	[FieldOffset(Offset = "0x48")]
	public UIButton btnSelect;

	[Token(Token = "0x4005587")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblDetailTitleDesc;

	[Token(Token = "0x4005588")]
	[FieldOffset(Offset = "0x50")]
	private Action getTitleAction;

	[Token(Token = "0x4005589")]
	[FieldOffset(Offset = "0x54")]
	public GameObject goTitleUnlockDesc;

	[Token(Token = "0x400558A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject goTitleDesc;

	[Token(Token = "0x400558B")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache10;

	[Token(Token = "0x6007768")]
	[Address(RVA = "0x1B231A8", Offset = "0x1B231A8", VA = "0x1B231A8")]
	public XWidget_Title()
	{
	}

	[Token(Token = "0x6007769")]
	[Address(RVA = "0x1B231B0", Offset = "0x1B231B0", VA = "0x1B231B0")]
	public void Build(Action getTitle)
	{
	}

	[Token(Token = "0x600776A")]
	[Address(RVA = "0x1B23D20", Offset = "0x1B23D20", VA = "0x1B23D20")]
	public void OnClick_UnlockTitleBtn()
	{
	}

	[Token(Token = "0x600776B")]
	[Address(RVA = "0x1B23D24", Offset = "0x1B23D24", VA = "0x1B23D24")]
	public void OnClick_SelectTitleBtn()
	{
	}

	[Token(Token = "0x600776C")]
	[Address(RVA = "0x1B23E20", Offset = "0x1B23E20", VA = "0x1B23E20")]
	private void ReqSelectTitle(int nSelectedTitleId)
	{
	}

	[Token(Token = "0x600776D")]
	[Address(RVA = "0x1B233B8", Offset = "0x1B233B8", VA = "0x1B233B8")]
	public void InitDetail()
	{
	}

	[Token(Token = "0x600776E")]
	[Address(RVA = "0x1B24050", Offset = "0x1B24050", VA = "0x1B24050")]
	private void RefreshTitleItem(XUITitleItem titleItem)
	{
	}

	[Token(Token = "0x600776F")]
	[Address(RVA = "0x1B244E4", Offset = "0x1B244E4", VA = "0x1B244E4")]
	public void OnSelect(XUITitleItem uiTitleItem)
	{
	}

	[Token(Token = "0x6007770")]
	[Address(RVA = "0x1B239D8", Offset = "0x1B239D8", VA = "0x1B239D8")]
	public void SelectTitleItem(XUITitleItem uiTitleItem)
	{
	}

	[Token(Token = "0x6007771")]
	[Address(RVA = "0x1B23B88", Offset = "0x1B23B88", VA = "0x1B23B88")]
	public void CheckTitleItem(XUITitleItem uiTitleItem)
	{
	}

	[Token(Token = "0x6007772")]
	[Address(RVA = "0x1B244E8", Offset = "0x1B244E8", VA = "0x1B244E8")]
	public void RefreshDetail(TitleInfo titleInfo)
	{
	}

	[Token(Token = "0x6007773")]
	[Address(RVA = "0x1B24544", Offset = "0x1B24544", VA = "0x1B24544")]
	private void RefreshDetail(TitleInfo titleInfo, bool titleOpened, bool titleUnlockable, bool titleChecked)
	{
	}

	[Token(Token = "0x6007774")]
	[Address(RVA = "0x1B24814", Offset = "0x1B24814", VA = "0x1B24814")]
	private void RefreshDetailStat(TitleInfo titleInfo, bool titleOpened, bool titleUnlockable, bool titleChecked)
	{
	}

	[Token(Token = "0x6007775")]
	[Address(RVA = "0x1B24D7C", Offset = "0x1B24D7C", VA = "0x1B24D7C")]
	public void PopupTitleRewards(int nTitleId)
	{
	}

	[Token(Token = "0x6007776")]
	[Address(RVA = "0x1B24B8C", Offset = "0x1B24B8C", VA = "0x1B24B8C")]
	private void SetDetailButton(bool bTitleOpened, bool bEnabled)
	{
	}

	[Token(Token = "0x6007777")]
	[Address(RVA = "0x1B25048", Offset = "0x1B25048", VA = "0x1B25048")]
	private static void _003CPopupTitleRewards_003Em__4FC()
	{
	}
}
