using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200102E")]
public class XUIQuestItem : MonoBehaviour
{
	[Token(Token = "0x200102F")]
	private sealed class _003CSetLinkButton_003Ec__AnonStorey256
	{
		[Token(Token = "0x40056F7")]
		[FieldOffset(Offset = "0x8")]
		internal string link;

		[Token(Token = "0x40056F8")]
		[FieldOffset(Offset = "0xC")]
		internal XUIQuestItem _003C_003Ef__this;

		[Token(Token = "0x60078B5")]
		[Address(RVA = "0x1913594", Offset = "0x1913594", VA = "0x1913594")]
		public _003CSetLinkButton_003Ec__AnonStorey256()
		{
		}

		[Token(Token = "0x60078B6")]
		[Address(RVA = "0x19138D4", Offset = "0x19138D4", VA = "0x19138D4")]
		internal void _003C_003Em__508()
		{
		}
	}

	[Token(Token = "0x40056E7")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x40056E8")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprQuestIcon;

	[Token(Token = "0x40056E9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblQuestTitle;

	[Token(Token = "0x40056EA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblQuestCondition;

	[Token(Token = "0x40056EB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblQuestDesc;

	[Token(Token = "0x40056EC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblClearGroupProgress;

	[Token(Token = "0x40056ED")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridRewards;

	[Token(Token = "0x40056EE")]
	[FieldOffset(Offset = "0x28")]
	public UIButton btnGo;

	[Token(Token = "0x40056EF")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_Button btnComplete;

	[Token(Token = "0x40056F0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject btnReceived;

	[Token(Token = "0x40056F1")]
	[FieldOffset(Offset = "0x34")]
	public QuestInfo m_QuestItem;

	[Token(Token = "0x40056F2")]
	[FieldOffset(Offset = "0x38")]
	public List<CSContent> m_rewardsList;

	[Token(Token = "0x40056F3")]
	[FieldOffset(Offset = "0x3C")]
	public string UIQuestRewardFailSoundKey;

	[Token(Token = "0x40056F4")]
	[FieldOffset(Offset = "0x40")]
	public UIProgressBar progressbar;

	[Token(Token = "0x40056F5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject[] effectCompletable;

	[Token(Token = "0x40056F6")]
	[FieldOffset(Offset = "0x48")]
	private Action m_hideAction;

	[Token(Token = "0x60078AD")]
	[Address(RVA = "0x1912148", Offset = "0x1912148", VA = "0x1912148")]
	public XUIQuestItem()
	{
	}

	[Token(Token = "0x60078AE")]
	[Address(RVA = "0x19121D4", Offset = "0x19121D4", VA = "0x19121D4")]
	public void enableEffectCompletable(bool enable)
	{
	}

	[Token(Token = "0x60078AF")]
	[Address(RVA = "0x19122F0", Offset = "0x19122F0", VA = "0x19122F0")]
	public void Build(QuestInfo QuestItem, Action hideAction)
	{
	}

	[Token(Token = "0x60078B0")]
	[Address(RVA = "0x1912FB4", Offset = "0x1912FB4", VA = "0x1912FB4")]
	private void SetProgressbar(QuestInfo questInfo, int progressCount, int totalCount, bool complete)
	{
	}

	[Token(Token = "0x60078B1")]
	[Address(RVA = "0x1913318", Offset = "0x1913318", VA = "0x1913318")]
	private void SetLinkButton(string link)
	{
	}

	[Token(Token = "0x60078B2")]
	[Address(RVA = "0x191359C", Offset = "0x191359C", VA = "0x191359C")]
	private void OnClick_HideLink()
	{
	}

	[Token(Token = "0x60078B3")]
	[Address(RVA = "0x19135C8", Offset = "0x19135C8", VA = "0x19135C8")]
	public void OnClick_Complete()
	{
	}

	[Token(Token = "0x60078B4")]
	[Address(RVA = "0x1913798", Offset = "0x1913798", VA = "0x1913798")]
	public void OnClick_RewardFail()
	{
	}
}
