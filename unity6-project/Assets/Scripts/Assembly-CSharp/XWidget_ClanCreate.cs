using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E89")]
public class XWidget_ClanCreate : XUIBaseWidget, IClanListener
{
	[Token(Token = "0x2000E8A")]
	private sealed class _003COnClick_ClanCreate_003Ec__AnonStorey1F7
	{
		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x8")]
		internal string clanName;

		[Token(Token = "0x4004C3B")]
		[FieldOffset(Offset = "0xC")]
		internal string introStr;

		[Token(Token = "0x4004C3C")]
		[FieldOffset(Offset = "0x10")]
		internal string msg;

		[Token(Token = "0x4004C3D")]
		[FieldOffset(Offset = "0x14")]
		internal string title;

		[Token(Token = "0x4004C3E")]
		[FieldOffset(Offset = "0x18")]
		internal XWidget_ClanCreate _003C_003Ef__this;

		[Token(Token = "0x6006C78")]
		[Address(RVA = "0x15D1C80", Offset = "0x15D1C80", VA = "0x15D1C80")]
		public _003COnClick_ClanCreate_003Ec__AnonStorey1F7()
		{
		}

		[Token(Token = "0x6006C79")]
		[Address(RVA = "0x15D2118", Offset = "0x15D2118", VA = "0x15D2118")]
		internal void _003C_003Em__3E1()
		{
		}

		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0x15D24EC", Offset = "0x15D24EC", VA = "0x15D24EC")]
		internal void _003C_003Em__3E2(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004C2A")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput inputClanName;

	[Token(Token = "0x4004C2B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblClanNameWarningText;

	[Token(Token = "0x4004C2C")]
	[FieldOffset(Offset = "0x24")]
	public UIInput inputClanIntroduce;

	[Token(Token = "0x4004C2D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblClanIntroduceWarningText;

	[Token(Token = "0x4004C2E")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_QuantityInputBox lvInputBox;

	[Token(Token = "0x4004C2F")]
	[FieldOffset(Offset = "0x30")]
	public XWiget_GridBuilder joinConditionBuilder;

	[Token(Token = "0x4004C30")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblCost;

	[Token(Token = "0x4004C31")]
	[FieldOffset(Offset = "0x38")]
	public Transform transformClanMark;

	[Token(Token = "0x4004C32")]
	[FieldOffset(Offset = "0x3C")]
	private XWidget_ClanMark defaultClanMark;

	[Token(Token = "0x4004C33")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_Selectable_Label[] joinConditions;

	[Token(Token = "0x4004C34")]
	[FieldOffset(Offset = "0x44")]
	private XWidget_Selectable_Label selectCondition;

	[Token(Token = "0x4004C35")]
	[FieldOffset(Offset = "0x48")]
	private Action<Netdata_Clan> m_onCompleteClanCreate;

	[Token(Token = "0x4004C36")]
	[FieldOffset(Offset = "0x4C")]
	private ApiReturnCode clanNameRetCode;

	[Token(Token = "0x4004C37")]
	[FieldOffset(Offset = "0x50")]
	private bool isClanNameFocus;

	[Token(Token = "0x4004C38")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x4004C39")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x6006C68")]
	[Address(RVA = "0x15D0384", Offset = "0x15D0384", VA = "0x15D0384")]
	public XWidget_ClanCreate()
	{
	}

	[Token(Token = "0x6006C69")]
	[Address(RVA = "0x15D038C", Offset = "0x15D038C", VA = "0x15D038C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006C6A")]
	[Address(RVA = "0x15D04A0", Offset = "0x15D04A0", VA = "0x15D04A0")]
	private void InitClanNameRetCode()
	{
	}

	[Token(Token = "0x6006C6B")]
	[Address(RVA = "0x15D04AC", Offset = "0x15D04AC", VA = "0x15D04AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6006C6C")]
	[Address(RVA = "0x15D082C", Offset = "0x15D082C", VA = "0x15D082C")]
	public void Show(int defaultMarkID, int defaultColorID, Action<Netdata_Clan> onCompleteClanCreate)
	{
	}

	[Token(Token = "0x6006C6D")]
	[Address(RVA = "0x15D0EA8", Offset = "0x15D0EA8", VA = "0x15D0EA8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006C6E")]
	[Address(RVA = "0x15D08A0", Offset = "0x15D08A0", VA = "0x15D08A0")]
	private void Build(int defaultMarkID, int defaultColorID, Action<Netdata_Clan> onCompleteClanCreate)
	{
	}

	[Token(Token = "0x6006C6F")]
	[Address(RVA = "0x15D0510", Offset = "0x15D0510", VA = "0x15D0510")]
	private void CheckClanName()
	{
	}

	[Token(Token = "0x6006C70")]
	[Address(RVA = "0x15D14C0", Offset = "0x15D14C0", VA = "0x15D14C0")]
	private string GetWarningText(ApiReturnCode retCode)
	{
		return null;
	}

	[Token(Token = "0x6006C71")]
	[Address(RVA = "0x15D0F88", Offset = "0x15D0F88", VA = "0x15D0F88")]
	private void BuildJoinCondition()
	{
	}

	[Token(Token = "0x6006C72")]
	[Address(RVA = "0x15D1674", Offset = "0x15D1674", VA = "0x15D1674")]
	private void ToggleJoinCondition(bool toggle, int condition)
	{
	}

	[Token(Token = "0x6006C73")]
	[Address(RVA = "0x15D17B8", Offset = "0x15D17B8", VA = "0x15D17B8")]
	public void OnClick_ClanCreate()
	{
	}

	[Token(Token = "0x6006C74")]
	[Address(RVA = "0x15D1C88", Offset = "0x15D1C88", VA = "0x15D1C88", Slot = "18")]
	public void OnUpdateClanData(Netdata_Clan clanData)
	{
	}

	[Token(Token = "0x6006C75")]
	[Address(RVA = "0x15D1DA8", Offset = "0x15D1DA8", VA = "0x15D1DA8")]
	private static void _003CBuild_003Em__3DE()
	{
	}

	[Token(Token = "0x6006C76")]
	[Address(RVA = "0x15D1EE4", Offset = "0x15D1EE4", VA = "0x15D1EE4")]
	private static void _003CBuild_003Em__3DF()
	{
	}

	[Token(Token = "0x6006C77")]
	[Address(RVA = "0x15D2020", Offset = "0x15D2020", VA = "0x15D2020")]
	private void _003CCheckClanName_003Em__3E0(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
