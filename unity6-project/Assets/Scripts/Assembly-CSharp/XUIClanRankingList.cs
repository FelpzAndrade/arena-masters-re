using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000F15")]
public class XUIClanRankingList : XUIListView
{
	[Token(Token = "0x2000F16")]
	public class ClanRankData
	{
		[Token(Token = "0x4004FDC")]
		[FieldOffset(Offset = "0x8")]
		public ClanRankMetaData clanRankMetaData;

		[Token(Token = "0x4004FDD")]
		[FieldOffset(Offset = "0xC")]
		public int rank;

		[Token(Token = "0x600707C")]
		[Address(RVA = "0x1A3A100", Offset = "0x1A3A100", VA = "0x1A3A100")]
		public ClanRankData()
		{
		}
	}

	[Token(Token = "0x2000F17")]
	private sealed class _003COnClick_Detail_003Ec__AnonStorey227
	{
		[Token(Token = "0x4004FDE")]
		[FieldOffset(Offset = "0x8")]
		internal RankListViewType viewType;

		[Token(Token = "0x4004FDF")]
		[FieldOffset(Offset = "0xC")]
		internal XUIClanRankingList _003C_003Ef__this;

		[Token(Token = "0x600707D")]
		[Address(RVA = "0x1A3A364", Offset = "0x1A3A364", VA = "0x1A3A364")]
		public _003COnClick_Detail_003Ec__AnonStorey227()
		{
		}

		[Token(Token = "0x600707E")]
		[Address(RVA = "0x1A3A47C", Offset = "0x1A3A47C", VA = "0x1A3A47C")]
		internal void _003C_003Em__462(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004FD4")]
	[FieldOffset(Offset = "0x78")]
	public Transform rankingRoot;

	[Token(Token = "0x4004FD5")]
	[FieldOffset(Offset = "0x7C")]
	private readonly string Path_ClanMemPopup;

	[Token(Token = "0x4004FD6")]
	[FieldOffset(Offset = "0x80")]
	private XWidget_ClanMemListPopup _clanMemPopup;

	[Token(Token = "0x4004FD7")]
	[FieldOffset(Offset = "0x84")]
	private ClanRankingList data;

	[Token(Token = "0x4004FD8")]
	[FieldOffset(Offset = "0x88")]
	private List<ClanRankData> m_list;

	[Token(Token = "0x4004FD9")]
	[FieldOffset(Offset = "0x8C")]
	private RankListViewType m_ViewType;

	[Token(Token = "0x4004FDA")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ClanRankData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4004FDB")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<ClanRankData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x17000E3F")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007072")]
		[Address(RVA = "0x1A39694", Offset = "0x1A39694", VA = "0x1A39694", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E40")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007073")]
		[Address(RVA = "0x1A3970C", Offset = "0x1A3970C", VA = "0x1A3970C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E41")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007074")]
		[Address(RVA = "0x1A39714", Offset = "0x1A39714", VA = "0x1A39714", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E42")]
	public XWidget_ClanMemListPopup m_clanMemPopup
	{
		[Token(Token = "0x6007075")]
		[Address(RVA = "0x1A397AC", Offset = "0x1A397AC", VA = "0x1A397AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007071")]
	[Address(RVA = "0x1A395A8", Offset = "0x1A395A8", VA = "0x1A395A8")]
	public XUIClanRankingList()
	{
	}

	[Token(Token = "0x6007076")]
	[Address(RVA = "0x1A39AE4", Offset = "0x1A39AE4", VA = "0x1A39AE4", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007077")]
	[Address(RVA = "0x1A39C4C", Offset = "0x1A39C4C", VA = "0x1A39C4C")]
	public void Build(ClanRankingList data, RankListViewType viewType = RankListViewType.ThisWeek)
	{
	}

	[Token(Token = "0x6007078")]
	[Address(RVA = "0x1A3A108", Offset = "0x1A3A108", VA = "0x1A3A108")]
	public void OnClick_Detail(string clanId, RankListViewType viewType = RankListViewType.ThisWeek)
	{
	}

	[Token(Token = "0x6007079")]
	[Address(RVA = "0x1A3A36C", Offset = "0x1A3A36C", VA = "0x1A3A36C")]
	public void ShowClanMemberPopup(string clanName, List<CompletedClanMember> memList, RankListViewType viewType)
	{
	}

	[Token(Token = "0x600707A")]
	[Address(RVA = "0x1A3A3D8", Offset = "0x1A3A3D8", VA = "0x1A3A3D8")]
	private static int _003CBuild_003Em__460(ClanRankData a, ClanRankData b)
	{
		return default(int);
	}

	[Token(Token = "0x600707B")]
	[Address(RVA = "0x1A3A448", Offset = "0x1A3A448", VA = "0x1A3A448")]
	private static int _003CBuild_003Em__461(ClanRankData a, ClanRankData b)
	{
		return default(int);
	}
}
