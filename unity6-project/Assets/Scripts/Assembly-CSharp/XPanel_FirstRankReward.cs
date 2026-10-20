using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000DDA")]
public class XPanel_FirstRankReward : XUIBaseWidget
{
	[Token(Token = "0x2000DDB")]
	private sealed class _003CShow_003Ec__AnonStorey1C5
	{
		[Token(Token = "0x4004824")]
		[FieldOffset(Offset = "0x8")]
		internal RankType rankType;

		[Token(Token = "0x4004825")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_FirstRankReward _003C_003Ef__this;

		[Token(Token = "0x600662F")]
		[Address(RVA = "0x16B78F8", Offset = "0x16B78F8", VA = "0x16B78F8")]
		public _003CShow_003Ec__AnonStorey1C5()
		{
		}

		[Token(Token = "0x6006630")]
		[Address(RVA = "0x16B83B0", Offset = "0x16B83B0", VA = "0x16B83B0")]
		internal void _003C_003Em__35C(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000DDC")]
	private sealed class _003CBuildTab_003Ec__AnonStorey1C6
	{
		[Token(Token = "0x4004826")]
		[FieldOffset(Offset = "0x8")]
		internal RankType rankType;

		[Token(Token = "0x4004827")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_FirstRankReward _003C_003Ef__this;

		[Token(Token = "0x6006631")]
		[Address(RVA = "0x16B8368", Offset = "0x16B8368", VA = "0x16B8368")]
		public _003CBuildTab_003Ec__AnonStorey1C6()
		{
		}

		[Token(Token = "0x6006632")]
		[Address(RVA = "0x16B8380", Offset = "0x16B8380", VA = "0x16B8380")]
		internal void _003C_003Em__35D()
		{
		}
	}

	[Token(Token = "0x400481D")]
	[FieldOffset(Offset = "0x1C")]
	public XUIFirstRewardItemList m_firstRewardItemList;

	[Token(Token = "0x400481E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblNextRewardDesc;

	[Token(Token = "0x400481F")]
	[FieldOffset(Offset = "0x24")]
	private int m_duelBestScore;

	[Token(Token = "0x4004820")]
	[FieldOffset(Offset = "0x28")]
	private int m_teamBestScore;

	[Token(Token = "0x4004821")]
	[FieldOffset(Offset = "0x2C")]
	private RankType m_selectedRankType;

	[Token(Token = "0x4004822")]
	[FieldOffset(Offset = "0x30")]
	public XWiget_GridBuilder gridMainTab;

	[Token(Token = "0x4004823")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<RankType, XWidget_ToggleTab> m_modeTabs;

	[Token(Token = "0x6006629")]
	[Address(RVA = "0x16B7528", Offset = "0x16B7528", VA = "0x16B7528")]
	public XPanel_FirstRankReward()
	{
	}

	[Token(Token = "0x600662A")]
	[Address(RVA = "0x16B75D4", Offset = "0x16B75D4", VA = "0x16B75D4")]
	public void Show(bool bShow, RankType rankType = RankType.Duel)
	{
	}

	[Token(Token = "0x600662B")]
	[Address(RVA = "0x16B7C98", Offset = "0x16B7C98", VA = "0x16B7C98")]
	public void BuildFirstRankRewardItemList(RankType rankType, List<CSFirstRankReward> firstRankRewardList, List<int> firstRankRewardRecievedItemIDList, int bestScore, bool isPlacementTest)
	{
	}

	[Token(Token = "0x600662C")]
	[Address(RVA = "0x16B7CE0", Offset = "0x16B7CE0", VA = "0x16B7CE0")]
	private void SelectMainTab(RankType rankType)
	{
	}

	[Token(Token = "0x600662D")]
	[Address(RVA = "0x16B7900", Offset = "0x16B7900", VA = "0x16B7900")]
	private void BuildTab()
	{
	}

	[Token(Token = "0x600662E")]
	[Address(RVA = "0x16B8370", Offset = "0x16B8370", VA = "0x16B8370", Slot = "12")]
	public override void Hide()
	{
	}
}
