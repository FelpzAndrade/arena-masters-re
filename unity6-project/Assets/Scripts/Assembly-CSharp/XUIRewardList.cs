using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D87")]
public class XUIRewardList : MonoBehaviour
{
	[Token(Token = "0x2000D88")]
	private sealed class _003CBuildGoldReward_003Ec__AnonStorey1AD
	{
		[Token(Token = "0x4004631")]
		[FieldOffset(Offset = "0x8")]
		internal Netdata_CompleteMission gameReward;

		[Token(Token = "0x4004632")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ItemDetailToolTip itemToolTip;

		[Token(Token = "0x4004633")]
		[FieldOffset(Offset = "0x10")]
		internal XUIRewardList _003C_003Ef__this;

		[Token(Token = "0x6006369")]
		[Address(RVA = "0x191DF9C", Offset = "0x191DF9C", VA = "0x191DF9C")]
		public _003CBuildGoldReward_003Ec__AnonStorey1AD()
		{
		}

		[Token(Token = "0x600636A")]
		[Address(RVA = "0x191E5A0", Offset = "0x191E5A0", VA = "0x191E5A0")]
		internal void _003C_003Em__316()
		{
		}
	}

	[Token(Token = "0x2000D89")]
	private sealed class _003CBuildClearReward_003Ec__AnonStorey1AE
	{
		[Token(Token = "0x4004634")]
		[FieldOffset(Offset = "0x8")]
		internal CSContentReward clearContents;

		[Token(Token = "0x4004635")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ItemDetailToolTip itemToolTip;

		[Token(Token = "0x4004636")]
		[FieldOffset(Offset = "0x10")]
		internal XUIRewardList _003C_003Ef__this;

		[Token(Token = "0x600636B")]
		[Address(RVA = "0x191DFA4", Offset = "0x191DFA4", VA = "0x191DFA4")]
		public _003CBuildClearReward_003Ec__AnonStorey1AE()
		{
		}

		[Token(Token = "0x600636C")]
		[Address(RVA = "0x191E16C", Offset = "0x191E16C", VA = "0x191E16C")]
		internal void _003C_003Em__317()
		{
		}
	}

	[Token(Token = "0x2000D8A")]
	private sealed class _003CBuildGachaReward_003Ec__AnonStorey1AF
	{
		[Token(Token = "0x4004637")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_RewardItem widget;

		[Token(Token = "0x4004638")]
		[FieldOffset(Offset = "0xC")]
		internal CSContent reward;

		[Token(Token = "0x4004639")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_ItemDetailToolTip itemToolTip;

		[Token(Token = "0x400463A")]
		[FieldOffset(Offset = "0x14")]
		internal RewardInfo info;

		[Token(Token = "0x400463B")]
		[FieldOffset(Offset = "0x18")]
		internal bool isBooster;

		[Token(Token = "0x400463C")]
		[FieldOffset(Offset = "0x1C")]
		internal XUIRewardList _003C_003Ef__this;

		[Token(Token = "0x600636D")]
		[Address(RVA = "0x191E164", Offset = "0x191E164", VA = "0x191E164")]
		public _003CBuildGachaReward_003Ec__AnonStorey1AF()
		{
		}

		[Token(Token = "0x600636E")]
		[Address(RVA = "0x191E2E4", Offset = "0x191E2E4", VA = "0x191E2E4")]
		internal void _003C_003Em__318()
		{
		}
	}

	[Token(Token = "0x400462C")]
	[FieldOffset(Offset = "0xC")]
	private UIDirectionSequence m_rewardSeq;

	[Token(Token = "0x400462D")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_RewardItem rewardGold;

	[Token(Token = "0x400462E")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridDropRewards;

	[Token(Token = "0x400462F")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_RewardItem rewardClear;

	[Token(Token = "0x4004630")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_ContentIcon.Option m_option;

	[Token(Token = "0x6006363")]
	[Address(RVA = "0x191D27C", Offset = "0x191D27C", VA = "0x191D27C")]
	public XUIRewardList()
	{
	}

	[Token(Token = "0x6006364")]
	[Address(RVA = "0x191D28C", Offset = "0x191D28C", VA = "0x191D28C")]
	public UIDirectionSequence Build(float itemBuildDelay, Netdata_CompleteMission gameReward, XWidget_ItemDetailToolTip itemToolTip)
	{
		return null;
	}

	[Token(Token = "0x6006365")]
	[Address(RVA = "0x191D3FC", Offset = "0x191D3FC", VA = "0x191D3FC")]
	private void BuildGoldReward(Netdata_CompleteMission gameReward, UIDirectionSequence rewardSeq, XWidget_ItemDetailToolTip itemToolTip, float itemBuildDelay)
	{
	}

	[Token(Token = "0x6006366")]
	[Address(RVA = "0x191D5D0", Offset = "0x191D5D0", VA = "0x191D5D0")]
	private void BuildClearReward(Netdata_CompleteMission gameReward, CSStageInfo stageInfo, UIDirectionSequence rewardSeq, XWidget_ItemDetailToolTip itemToolTip, float itemBuildDelay)
	{
	}

	[Token(Token = "0x6006367")]
	[Address(RVA = "0x191D954", Offset = "0x191D954", VA = "0x191D954")]
	private void BuildDropRewards(Netdata_CompleteMission gameReward, UIDirectionSequence rewardSeq, XWidget_ItemDetailToolTip itemToolTip, float itemBuildDelay)
	{
	}

	[Token(Token = "0x6006368")]
	[Address(RVA = "0x191DFAC", Offset = "0x191DFAC", VA = "0x191DFAC")]
	private void BuildGachaReward(XWidget_RewardItem widget, RewardInfo info, bool isBooster, UIDirectionSequence rewardSeq, XWidget_ItemDetailToolTip itemToolTip, float itemBuildDelay = 0.5f)
	{
	}
}
