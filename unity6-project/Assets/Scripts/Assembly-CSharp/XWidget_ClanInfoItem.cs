using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E8D")]
public class XWidget_ClanInfoItem : MonoBehaviour, IClanListener
{
	[Token(Token = "0x2000E8E")]
	private sealed class _003COnClick_CancelJoinRequest_003Ec__AnonStorey1F9
	{
		[Token(Token = "0x4004C69")]
		[FieldOffset(Offset = "0x8")]
		internal string clanID;

		[Token(Token = "0x4004C6A")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ClanInfoItem _003C_003Ef__this;

		[Token(Token = "0x6006CA1")]
		[Address(RVA = "0x15D7734", Offset = "0x15D7734", VA = "0x15D7734")]
		public _003COnClick_CancelJoinRequest_003Ec__AnonStorey1F9()
		{
		}

		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0x15D85C4", Offset = "0x15D85C4", VA = "0x15D85C4")]
		internal void _003C_003Em__3E7(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004C54")]
	[FieldOffset(Offset = "0xC")]
	public Transform transformClanMark;

	[Token(Token = "0x4004C55")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ClanMark clanMark;

	[Token(Token = "0x4004C56")]
	[FieldOffset(Offset = "0x14")]
	private UI2DSprite sprMine;

	[Token(Token = "0x4004C57")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprClanMemberGrade;

	[Token(Token = "0x4004C58")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprClanFlag;

	[Token(Token = "0x4004C59")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMasterLv;

	[Token(Token = "0x4004C5A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblMasterName;

	[Token(Token = "0x4004C5B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblMember;

	[Token(Token = "0x4004C5C")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblLvCondition;

	[Token(Token = "0x4004C5D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblClanName;

	[Token(Token = "0x4004C5E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblClanIntroduce;

	[Token(Token = "0x4004C5F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblRankScore;

	[Token(Token = "0x4004C60")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblRank;

	[Token(Token = "0x4004C61")]
	[FieldOffset(Offset = "0x40")]
	public GameObject btnDetail;

	[Token(Token = "0x4004C62")]
	[FieldOffset(Offset = "0x44")]
	public Action<ClanMetaData> m_onDetail;

	[Token(Token = "0x4004C63")]
	[FieldOffset(Offset = "0x48")]
	public Action<Netdata_Clan> m_onImmediatelyJoin;

	[Token(Token = "0x4004C64")]
	[FieldOffset(Offset = "0x4C")]
	public Action<ClanMetaData> m_onRemoveDataForShowList;

	[Token(Token = "0x4004C65")]
	[FieldOffset(Offset = "0x50")]
	private ClanMetaData m_clanData;

	[Token(Token = "0x4004C66")]
	[FieldOffset(Offset = "0x54")]
	public XWidget_Button btnJoin;

	[Token(Token = "0x4004C67")]
	[FieldOffset(Offset = "0x58")]
	public XWidget_Button btnJoinCancel;

	[Token(Token = "0x4004C68")]
	[FieldOffset(Offset = "0x5C")]
	public Color LevelConditionColor;

	[Token(Token = "0x6006C94")]
	[Address(RVA = "0x15D5668", Offset = "0x15D5668", VA = "0x15D5668")]
	public XWidget_ClanInfoItem()
	{
	}

	[Token(Token = "0x6006C95")]
	[Address(RVA = "0x15D5670", Offset = "0x15D5670", VA = "0x15D5670")]
	public void BuildJoinableItem(ClanMetaData clanData, Action<ClanMetaData> onDetail, Action<Netdata_Clan> onImmediatelyJoin, Action<ClanMetaData> onRemoveDataForShowList)
	{
	}

	[Token(Token = "0x6006C96")]
	[Address(RVA = "0x15D66A0", Offset = "0x15D66A0", VA = "0x15D66A0")]
	public void BuildJoinCancelItem(ClanMetaData clanData, Action<ClanMetaData> onDetail, Action<ClanMetaData> onRemoveDataForShowList)
	{
	}

	[Token(Token = "0x6006C97")]
	[Address(RVA = "0x15D6920", Offset = "0x15D6920", VA = "0x15D6920")]
	public void BuildDisalyItem(int rank, ClanMetaData clanData, Action<ClanMetaData> onDetail)
	{
	}

	[Token(Token = "0x6006C98")]
	[Address(RVA = "0x15D5BC0", Offset = "0x15D5BC0", VA = "0x15D5BC0")]
	private void BuildCommon(ClanMetaData clanData, Action<ClanMetaData> onDetail)
	{
	}

	[Token(Token = "0x6006C99")]
	[Address(RVA = "0x15D6C04", Offset = "0x15D6C04", VA = "0x15D6C04")]
	private void HideRightButton()
	{
	}

	[Token(Token = "0x6006C9A")]
	[Address(RVA = "0x15D6408", Offset = "0x15D6408", VA = "0x15D6408")]
	public void BuildButton(ClanJoinType joinType)
	{
	}

	[Token(Token = "0x6006C9B")]
	[Address(RVA = "0x15D6C70", Offset = "0x15D6C70", VA = "0x15D6C70")]
	private void OnClick_SendJoinRequest()
	{
	}

	[Token(Token = "0x6006C9C")]
	[Address(RVA = "0x15D7170", Offset = "0x15D7170", VA = "0x15D7170")]
	private void ShowJoinClanErrorMessage(ApiReturnCode nErrorCode)
	{
	}

	[Token(Token = "0x6006C9D")]
	[Address(RVA = "0x15D74D0", Offset = "0x15D74D0", VA = "0x15D74D0")]
	private void OnClick_CancelJoinRequest()
	{
	}

	[Token(Token = "0x6006C9E")]
	[Address(RVA = "0x15D773C", Offset = "0x15D773C", VA = "0x15D773C")]
	public void OnClick_ClanDetail()
	{
	}

	[Token(Token = "0x6006C9F")]
	[Address(RVA = "0x15D77CC", Offset = "0x15D77CC", VA = "0x15D77CC", Slot = "4")]
	public void OnUpdateClanData(Netdata_Clan clanData)
	{
	}

	[Token(Token = "0x6006CA0")]
	[Address(RVA = "0x15D7950", Offset = "0x15D7950", VA = "0x15D7950")]
	private void _003COnClick_SendJoinRequest_003Em__3E6(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
