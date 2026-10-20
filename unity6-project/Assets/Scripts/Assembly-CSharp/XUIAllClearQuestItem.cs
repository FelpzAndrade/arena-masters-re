using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001016")]
public class XUIAllClearQuestItem : MonoBehaviour
{
	[Token(Token = "0x4005629")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblDesc;

	[Token(Token = "0x400562A")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprQuestIcon;

	[Token(Token = "0x400562B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblQuestTitle;

	[Token(Token = "0x400562C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblQuestCondition;

	[Token(Token = "0x400562D")]
	[FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder gridRewards;

	[Token(Token = "0x400562E")]
	[FieldOffset(Offset = "0x20")]
	public QuestInfo m_QuestItem;

	[Token(Token = "0x400562F")]
	[FieldOffset(Offset = "0x24")]
	public List<CSContent> m_rewardsList;

	[Token(Token = "0x4005630")]
	[FieldOffset(Offset = "0x28")]
	public string UIQuestRewardFailSoundKey;

	[Token(Token = "0x4005631")]
	[FieldOffset(Offset = "0x2C")]
	public UIProgressBar progressbar;

	[Token(Token = "0x4005632")]
	[FieldOffset(Offset = "0x30")]
	public GameObject effectCompletable;

	[Token(Token = "0x4005633")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_Button btnComplete;

	[Token(Token = "0x4005634")]
	[FieldOffset(Offset = "0x38")]
	public XPanel_Quest pnlQuest;

	[Token(Token = "0x60077FF")]
	[Address(RVA = "0x1A292C0", Offset = "0x1A292C0", VA = "0x1A292C0")]
	public XUIAllClearQuestItem()
	{
	}

	[Token(Token = "0x6007800")]
	[Address(RVA = "0x1A29344", Offset = "0x1A29344", VA = "0x1A29344")]
	public void Build(QuestInfo QuestItem)
	{
	}

	[Token(Token = "0x6007801")]
	[Address(RVA = "0x1A29A4C", Offset = "0x1A29A4C", VA = "0x1A29A4C")]
	private void SetProgressbar(QuestInfo questInfo, int progressCount, int totalCount)
	{
	}

	[Token(Token = "0x6007802")]
	[Address(RVA = "0x1A29BC0", Offset = "0x1A29BC0", VA = "0x1A29BC0")]
	public void OnClick_Complete()
	{
	}

	[Token(Token = "0x6007803")]
	[Address(RVA = "0x1A29D74", Offset = "0x1A29D74", VA = "0x1A29D74")]
	public void OnClick_Disable()
	{
	}
}
