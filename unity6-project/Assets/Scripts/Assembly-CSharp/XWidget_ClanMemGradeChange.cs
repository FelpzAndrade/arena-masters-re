using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000E9C")]
public class XWidget_ClanMemGradeChange : XUIBaseWidget
{
	[Token(Token = "0x2000E9D")]
	private sealed class _003COnClick_SubMasterDelegate_003Ec__AnonStorey203
	{
		[Token(Token = "0x4004CC0")]
		[FieldOffset(Offset = "0x8")]
		internal bool isMaxSubMaster;

		[Token(Token = "0x4004CC1")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ClanMemGradeChange _003C_003Ef__this;

		[Token(Token = "0x6006D19")]
		[Address(RVA = "0x15E1620", Offset = "0x15E1620", VA = "0x15E1620")]
		public _003COnClick_SubMasterDelegate_003Ec__AnonStorey203()
		{
		}

		[Token(Token = "0x6006D1A")]
		[Address(RVA = "0x15E2168", Offset = "0x15E2168", VA = "0x15E2168")]
		internal void _003C_003Em__3FA()
		{
		}
	}

	[Token(Token = "0x2000E9E")]
	private sealed class _003CRequestKickClanMember_003Ec__AnonStorey204
	{
		[Token(Token = "0x4004CC2")]
		[FieldOffset(Offset = "0x8")]
		internal string nickName;

		[Token(Token = "0x4004CC3")]
		[FieldOffset(Offset = "0xC")]
		internal CompletedClanMember clanMember;

		[Token(Token = "0x4004CC4")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_ClanMemGradeChange _003C_003Ef__this;

		[Token(Token = "0x6006D1B")]
		[Address(RVA = "0x15E1E4C", Offset = "0x15E1E4C", VA = "0x15E1E4C")]
		public _003CRequestKickClanMember_003Ec__AnonStorey204()
		{
		}

		[Token(Token = "0x6006D1C")]
		[Address(RVA = "0x15E24A0", Offset = "0x15E24A0", VA = "0x15E24A0")]
		internal void _003C_003Em__3FD(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E9F")]
	private sealed class _003CRequest_UpdateClanMemberGrade_003Ec__AnonStorey205
	{
		[Token(Token = "0x4004CC5")]
		[FieldOffset(Offset = "0x8")]
		internal ClanMemberGrade targetGrade;

		[Token(Token = "0x4004CC6")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ClanMemGradeChange _003C_003Ef__this;

		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0x15E20F0", Offset = "0x15E20F0", VA = "0x15E20F0")]
		public _003CRequest_UpdateClanMemberGrade_003Ec__AnonStorey205()
		{
		}

		[Token(Token = "0x6006D1E")]
		[Address(RVA = "0x15E21AC", Offset = "0x15E21AC", VA = "0x15E21AC")]
		internal void _003C_003Em__3FE(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004CB8")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_ClanMemInfoItem clanMemInfo;

	[Token(Token = "0x4004CB9")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_Button btnLeft;

	[Token(Token = "0x4004CBA")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_Button btnRight;

	[Token(Token = "0x4004CBB")]
	[FieldOffset(Offset = "0x28")]
	private Action m_refreshMemberList;

	[Token(Token = "0x4004CBC")]
	[FieldOffset(Offset = "0x2C")]
	private Action<CompletedClanMember> m_removeMember;

	[Token(Token = "0x4004CBD")]
	[FieldOffset(Offset = "0x30")]
	private int m_subMasterCnt;

	[Token(Token = "0x4004CBE")]
	[FieldOffset(Offset = "0x34")]
	private ClanMemberGrade m_myGrade;

	[Token(Token = "0x4004CBF")]
	[FieldOffset(Offset = "0x38")]
	private CompletedClanMember m_memData;

	[Token(Token = "0x6006D0C")]
	[Address(RVA = "0x15E0CD0", Offset = "0x15E0CD0", VA = "0x15E0CD0")]
	public XWidget_ClanMemGradeChange()
	{
	}

	[Token(Token = "0x6006D0D")]
	[Address(RVA = "0x15DE598", Offset = "0x15DE598", VA = "0x15DE598")]
	public void Build(ClanMemberGrade myGrade, int subMasterCnt, int rank, CompletedClanMember memData, Action refreshMemberList, Action<CompletedClanMember> removeMember)
	{
	}

	[Token(Token = "0x6006D0E")]
	[Address(RVA = "0x15E0D34", Offset = "0x15E0D34", VA = "0x15E0D34")]
	public void BuildButton(ClanMemberGrade clanMemGrade)
	{
	}

	[Token(Token = "0x6006D0F")]
	[Address(RVA = "0x15E0FF8", Offset = "0x15E0FF8", VA = "0x15E0FF8")]
	private void OnClick_MasterDelegate()
	{
	}

	[Token(Token = "0x6006D10")]
	[Address(RVA = "0x15E120C", Offset = "0x15E120C", VA = "0x15E120C")]
	private void OnClick_SubMasterDelegate()
	{
	}

	[Token(Token = "0x6006D11")]
	[Address(RVA = "0x15E1780", Offset = "0x15E1780", VA = "0x15E1780")]
	private void OnClick_SubMasterDismissal()
	{
	}

	[Token(Token = "0x6006D12")]
	[Address(RVA = "0x15E1628", Offset = "0x15E1628", VA = "0x15E1628")]
	private bool CheckPermission(ClanMemberGrade myGrade, ClanMemberGrade needGrade)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D13")]
	[Address(RVA = "0x15E19A8", Offset = "0x15E19A8", VA = "0x15E19A8")]
	private void OnClick_ClanMemberRemove()
	{
	}

	[Token(Token = "0x6006D14")]
	[Address(RVA = "0x15E1BD0", Offset = "0x15E1BD0", VA = "0x15E1BD0")]
	private void RequestKickClanMember(CompletedClanMember clanMember)
	{
	}

	[Token(Token = "0x6006D15")]
	[Address(RVA = "0x15E1E54", Offset = "0x15E1E54", VA = "0x15E1E54")]
	private void Request_UpdateClanMemberGrade(string nickName, ClanMemberGrade targetGrade)
	{
	}

	[Token(Token = "0x6006D16")]
	[Address(RVA = "0x15E20F8", Offset = "0x15E20F8", VA = "0x15E20F8")]
	private void _003COnClick_MasterDelegate_003Em__3F9()
	{
	}

	[Token(Token = "0x6006D17")]
	[Address(RVA = "0x15E2130", Offset = "0x15E2130", VA = "0x15E2130")]
	private void _003COnClick_SubMasterDismissal_003Em__3FB()
	{
	}

	[Token(Token = "0x6006D18")]
	[Address(RVA = "0x15E2160", Offset = "0x15E2160", VA = "0x15E2160")]
	private void _003COnClick_ClanMemberRemove_003Em__3FC()
	{
	}
}
