using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA0")]
public class XWidget_ClanMemInfoItem : MonoBehaviour
{
	[Token(Token = "0x2000EA1")]
	private sealed class _003CBuildJoinManage_003Ec__AnonStorey206
	{
		[Token(Token = "0x4004CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action<CompletedClanMember> rejectAction;

		[Token(Token = "0x4004CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal CompletedClanMember record;

		[Token(Token = "0x4004CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Action<CompletedClanMember> approvalAction;

		[Token(Token = "0x6006D32")]
		[Address(RVA = "0x15E3EE0", Offset = "0x15E3EE0", VA = "0x15E3EE0")]
		public _003CBuildJoinManage_003Ec__AnonStorey206()
		{
		}

		[Token(Token = "0x6006D33")]
		[Address(RVA = "0x15E49D4", Offset = "0x15E49D4", VA = "0x15E49D4")]
		internal void _003C_003Em__3FF()
		{
		}

		[Token(Token = "0x6006D34")]
		[Address(RVA = "0x15E4A70", Offset = "0x15E4A70", VA = "0x15E4A70")]
		internal void _003C_003Em__400()
		{
		}
	}

	[Token(Token = "0x2000EA2")]
	private sealed class _003CBuildChangeGrade_003Ec__AnonStorey207
	{
		[Token(Token = "0x4004CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action<int, CompletedClanMember> clanMemGradeChangeAction;

		[Token(Token = "0x4004CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int rank;

		[Token(Token = "0x4004CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal CompletedClanMember record;

		[Token(Token = "0x6006D35")]
		[Address(RVA = "0x15E456C", Offset = "0x15E456C", VA = "0x15E456C")]
		public _003CBuildChangeGrade_003Ec__AnonStorey207()
		{
		}

		[Token(Token = "0x6006D36")]
		[Address(RVA = "0x15E4934", Offset = "0x15E4934", VA = "0x15E4934")]
		internal void _003C_003Em__401()
		{
		}
	}

	[Token(Token = "0x4004CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblRank;

	[Token(Token = "0x4004CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UI2DSprite sprChar;

	[Token(Token = "0x4004CC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4004CCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UISprite sprMine;

	[Token(Token = "0x4004CCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprClanMemGrade;

	[Token(Token = "0x4004CCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x4004CCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblNickName;

	[Token(Token = "0x4004CCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblLv;

	[Token(Token = "0x4004CCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblScore;

	[Token(Token = "0x4004CD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblClanBoxScore;

	[Token(Token = "0x4004CD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GameObject scoreRoot;

	[Token(Token = "0x4004CD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UITable scoreTable;

	[Token(Token = "0x4004CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UILabel lblLastConnectionTime;

	[Token(Token = "0x4004CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblJoinDay;

	[Token(Token = "0x4004CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public GameObject goDetail;

	[Token(Token = "0x4004CD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 m_masterPosition;

	[Token(Token = "0x4004CD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 m_normalPosition;

	[Token(Token = "0x4004CD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 m_approvalPosition;

	[Token(Token = "0x4004CD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public XWidget_Button btnChangeGrade;

	[Token(Token = "0x4004CDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public XWidget_Button btnReject;

	[Token(Token = "0x4004CDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public XWidget_Button btnApproval;

	[Token(Token = "0x4004CDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool m_isMine;

	[Token(Token = "0x4004CDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private string UserNickName__BackingField;

	[Token(Token = "0x17000DF8")]
	public string UserNickName
	{
		[Token(Token = "0x6006D20")]
		[Address(RVA = "0x15E2128", Offset = "0x15E2128", VA = "0x15E2128")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0x15E2924", Offset = "0x15E2924", VA = "0x15E2924")]
		private set
		{
		}
	}

	[Token(Token = "0x6006D1F")]
	[Address(RVA = "0x15E2854", Offset = "0x15E2854", VA = "0x15E2854")]
	public XWidget_ClanMemInfoItem()
	{
	}

	[Token(Token = "0x6006D22")]
	[Address(RVA = "0x15E292C", Offset = "0x15E292C", VA = "0x15E292C")]
	private void BuildButton([Optional] Action btnChangeGradeAction, [Optional] Action btnRejectAction, [Optional] Action btnApprovalAction)
	{
	}

	[Token(Token = "0x6006D23")]
	[Address(RVA = "0x15E2C00", Offset = "0x15E2C00", VA = "0x15E2C00")]
	private void SetClanWarPoint(int currentSeasonNum, CompletedClanMember record, RankListViewType viewType)
	{
	}

	[Token(Token = "0x6006D24")]
	[Address(RVA = "0x15E2CF4", Offset = "0x15E2CF4", VA = "0x15E2CF4")]
	private void SetClanBoxPoint(int point)
	{
	}

	[Token(Token = "0x6006D25")]
	[Address(RVA = "0x15E2E10", Offset = "0x15E2E10", VA = "0x15E2E10")]
	private void BuildCommon(CompletedClanMember record, int rank, RankListViewType ViewType = RankListViewType.ThisWeek)
	{
	}

	[Token(Token = "0x6006D26")]
	[Address(RVA = "0x15E3C70", Offset = "0x15E3C70", VA = "0x15E3C70")]
	private void SetActiveMemberScore(bool isActive)
	{
	}

	[Token(Token = "0x6006D27")]
	[Address(RVA = "0x15E3D60", Offset = "0x15E3D60", VA = "0x15E3D60")]
	public void BuildJoinManage(CompletedClanMember record, Action<CompletedClanMember> approvalAction, Action<CompletedClanMember> rejectAction)
	{
	}

	[Token(Token = "0x6006D28")]
	[Address(RVA = "0x15E4348", Offset = "0x15E4348", VA = "0x15E4348")]
	public void BuildChangeGrade(ClanMemberGrade myGrade, int rank, CompletedClanMember record, Action<int, CompletedClanMember> clanMemGradeChangeAction)
	{
	}

	[Token(Token = "0x6006D29")]
	[Address(RVA = "0x15E0CD8", Offset = "0x15E0CD8", VA = "0x15E0CD8")]
	public void BuildRankDisplay(int rank, CompletedClanMember record, RankListViewType viewtype = RankListViewType.ThisWeek)
	{
	}

	[Token(Token = "0x6006D2A")]
	[Address(RVA = "0x15E47BC", Offset = "0x15E47BC", VA = "0x15E47BC")]
	public void BuildNone(CompletedClanMember record)
	{
	}

	[Token(Token = "0x6006D2B")]
	[Address(RVA = "0x15E3EE8", Offset = "0x15E3EE8", VA = "0x15E3EE8")]
	private void SetButtonActive(bool isMine, bool changeGradeActive, bool joinManage)
	{
	}

	[Token(Token = "0x6006D2C")]
	[Address(RVA = "0x15E414C", Offset = "0x15E414C", VA = "0x15E414C")]
	private void SetDetailButtonReposition()
	{
	}

	[Token(Token = "0x6006D2D")]
	[Address(RVA = "0x15E4574", Offset = "0x15E4574", VA = "0x15E4574")]
	private bool IsMine(CompletedClanMember record)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D2E")]
	[Address(RVA = "0x15E46BC", Offset = "0x15E46BC", VA = "0x15E46BC")]
	private bool IsMaster(ClanMemberGrade myGrade)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D2F")]
	[Address(RVA = "0x15E46CC", Offset = "0x15E46CC", VA = "0x15E46CC")]
	private void SetlblLastConnectTimeActive(bool isActive)
	{
	}

	[Token(Token = "0x6006D30")]
	[Address(RVA = "0x15E38F8", Offset = "0x15E38F8", VA = "0x15E38F8")]
	private void BuildLastConnectTime(CompletedClanMember record)
	{
	}

	[Token(Token = "0x6006D31")]
	[Address(RVA = "0x15E47FC", Offset = "0x15E47FC", VA = "0x15E47FC")]
	public void OnClickDetail()
	{
	}
}
