using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB2")]
public class XWidget_EventMilestoneReward : MonoBehaviour
{
	[Token(Token = "0x2000EB3")]
	private sealed class _003CBuildReward_003Ec__AnonStorey20C
	{
		[Token(Token = "0x4004D41")]
		[FieldOffset(Offset = "0x8")]
		internal Transform targetTransform;

		[Token(Token = "0x4004D42")]
		[FieldOffset(Offset = "0xC")]
		internal CSContent content;

		[Token(Token = "0x4004D43")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_EventMilestoneReward _003C_003Ef__this;

		[Token(Token = "0x6006D95")]
		[Address(RVA = "0x1428F64", Offset = "0x1428F64", VA = "0x1428F64")]
		public _003CBuildReward_003Ec__AnonStorey20C()
		{
		}

		[Token(Token = "0x6006D96")]
		[Address(RVA = "0x1429184", Offset = "0x1429184", VA = "0x1429184")]
		internal void _003C_003Em__40E(object obj)
		{
		}
	}

	[Token(Token = "0x4004D32")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Tooltip toolTip;

	[Token(Token = "0x4004D33")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goNowReward;

	[Token(Token = "0x4004D34")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goNextReward;

	[Token(Token = "0x4004D35")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goMaxReward;

	[Token(Token = "0x4004D36")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblNowWin;

	[Token(Token = "0x4004D37")]
	[FieldOffset(Offset = "0x20")]
	public Transform nowRewardParent;

	[Token(Token = "0x4004D38")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_ContentIcon nowContentIcon;

	[Token(Token = "0x4004D39")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblNextWin;

	[Token(Token = "0x4004D3A")]
	[FieldOffset(Offset = "0x2C")]
	public Transform nextRewardParent;

	[Token(Token = "0x4004D3B")]
	[FieldOffset(Offset = "0x30")]
	private XWidget_ContentIcon nextContentIcon;

	[Token(Token = "0x4004D3C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblMaxWin;

	[Token(Token = "0x4004D3D")]
	[FieldOffset(Offset = "0x38")]
	public Transform maxRewardParent;

	[Token(Token = "0x4004D3E")]
	[FieldOffset(Offset = "0x3C")]
	private XWidget_ContentIcon maxContentIcon;

	[Token(Token = "0x4004D3F")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget.Pivot contentOnelineAlignment;

	[Token(Token = "0x4004D40")]
	[FieldOffset(Offset = "0x44")]
	public int contentFontSize;

	[Token(Token = "0x6006D87")]
	[Address(RVA = "0x1428338", Offset = "0x1428338", VA = "0x1428338")]
	public XWidget_EventMilestoneReward()
	{
	}

	[Token(Token = "0x6006D88")]
	[Address(RVA = "0x1428348", Offset = "0x1428348", VA = "0x1428348")]
	private RewardType GetMilestoneRewardType()
	{
		return default(RewardType);
	}

	[Token(Token = "0x6006D89")]
	[Address(RVA = "0x1428350", Offset = "0x1428350", VA = "0x1428350")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006D8A")]
	[Address(RVA = "0x142843C", Offset = "0x142843C", VA = "0x142843C")]
	public void BuildOnlyNowReward(EventGameRewardGroup rewardInfo, int currentWin)
	{
	}

	[Token(Token = "0x6006D8B")]
	[Address(RVA = "0x14287AC", Offset = "0x14287AC", VA = "0x14287AC")]
	public void BuildOnlyNextReward(EventGameRewardGroup rewardInfo, int currentWin)
	{
	}

	[Token(Token = "0x6006D8C")]
	[Address(RVA = "0x1428968", Offset = "0x1428968", VA = "0x1428968")]
	public void BuildOnlyMaxReward(EventGameRewardGroup rewardInfo, int maxWin)
	{
	}

	[Token(Token = "0x6006D8D")]
	[Address(RVA = "0x1428B0C", Offset = "0x1428B0C", VA = "0x1428B0C")]
	public void BuildThreeReward(EventGameRewardGroup rewardInfo, int currentStep, int maxStep)
	{
	}

	[Token(Token = "0x6006D8E")]
	[Address(RVA = "0x142872C", Offset = "0x142872C", VA = "0x142872C")]
	private void BuildNowReward(EventGameRewardGroup rewardInfo, int winConditionCount, CSContent buildReward)
	{
	}

	[Token(Token = "0x6006D8F")]
	[Address(RVA = "0x14288E8", Offset = "0x14288E8", VA = "0x14288E8")]
	private void BuildNextReward(EventGameRewardGroup rewardInfo, int winConditionCount, CSContent buildReward)
	{
	}

	[Token(Token = "0x6006D90")]
	[Address(RVA = "0x1428A8C", Offset = "0x1428A8C", VA = "0x1428A8C")]
	private void BuildMaxReward(EventGameRewardGroup rewardInfo, int winConditionCount, CSContent buildReward)
	{
	}

	[Token(Token = "0x6006D91")]
	[Address(RVA = "0x1428D38", Offset = "0x1428D38", VA = "0x1428D38")]
	private void BuildReward(Transform targetTransform, ref XWidget_ContentIcon targetContentIcon, CSContent content)
	{
	}

	[Token(Token = "0x6006D92")]
	[Address(RVA = "0x1428F6C", Offset = "0x1428F6C", VA = "0x1428F6C")]
	private XWidget_ContentIcon.Option GetContentIconOption(CSContentType contentType)
	{
		return default(XWidget_ContentIcon.Option);
	}

	[Token(Token = "0x6006D93")]
	[Address(RVA = "0x1428574", Offset = "0x1428574", VA = "0x1428574")]
	private void SetActiveRewardRoot(bool activeNow, bool activeNext, bool activeMax)
	{
	}

	[Token(Token = "0x6006D94")]
	[Address(RVA = "0x1429024", Offset = "0x1429024", VA = "0x1429024")]
	private void ShowToolTip(Transform parent, CSContent content)
	{
	}
}
