using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C53")]
public class XPanel_QuestNotification : MonoBehaviour
{
	[Token(Token = "0x4003E67")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_NGUITween tweens;

	[Token(Token = "0x4003E68")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x4003E69")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblDesc;

	[Token(Token = "0x4003E6A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblGoto;

	[Token(Token = "0x4003E6B")]
	[FieldOffset(Offset = "0x1C")]
	public Transform transformConentIconRoot;

	[Token(Token = "0x4003E6C")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_ContentIcon m_contentIcon;

	[Token(Token = "0x4003E6D")]
	[FieldOffset(Offset = "0x24")]
	private XQuestNotificationItem reserveItem;

	[Token(Token = "0x600591D")]
	[Address(RVA = "0x101CB00", Offset = "0x101CB00", VA = "0x101CB00")]
	public XPanel_QuestNotification()
	{
	}

	[Token(Token = "0x600591E")]
	[Address(RVA = "0x101CB08", Offset = "0x101CB08", VA = "0x101CB08")]
	public void ImmediatelyShow(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x600591F")]
	[Address(RVA = "0x101CB48", Offset = "0x101CB48", VA = "0x101CB48")]
	public void ImmediatelyShow(TitleInfo titleInfo)
	{
	}

	[Token(Token = "0x6005920")]
	[Address(RVA = "0x101CB88", Offset = "0x101CB88", VA = "0x101CB88")]
	public void Reserve(QuestInfo reserveQuestInfo)
	{
	}

	[Token(Token = "0x6005921")]
	[Address(RVA = "0x101CD2C", Offset = "0x101CD2C", VA = "0x101CD2C")]
	public void Reserve(TitleInfo reserveTitleInfo)
	{
	}

	[Token(Token = "0x6005922")]
	[Address(RVA = "0x101CE78", Offset = "0x101CE78", VA = "0x101CE78")]
	public void ReserveInfoShow()
	{
	}

	[Token(Token = "0x6005923")]
	[Address(RVA = "0x101CBA0", Offset = "0x101CBA0", VA = "0x101CBA0")]
	private XQuestNotificationItem NewItem(QuestInfo questInfo)
	{
		return null;
	}

	[Token(Token = "0x6005924")]
	[Address(RVA = "0x101CD44", Offset = "0x101CD44", VA = "0x101CD44")]
	private XQuestNotificationItem NewItem(TitleInfo titleInfo)
	{
		return null;
	}

	[Token(Token = "0x6005925")]
	[Address(RVA = "0x101CEA4", Offset = "0x101CEA4", VA = "0x101CEA4")]
	private void Show(XQuestNotificationItem item)
	{
	}

	[Token(Token = "0x6005926")]
	[Address(RVA = "0x101CB28", Offset = "0x101CB28", VA = "0x101CB28")]
	private void Show(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x6005927")]
	[Address(RVA = "0x101CB68", Offset = "0x101CB68", VA = "0x101CB68")]
	private void Show(TitleInfo titleInfo)
	{
	}

	[Token(Token = "0x6005928")]
	[Address(RVA = "0x101D27C", Offset = "0x101D27C", VA = "0x101D27C")]
	private string GetString_QuestType(QuestInfo questInfo)
	{
		return null;
	}

	[Token(Token = "0x6005929")]
	[Address(RVA = "0x101D47C", Offset = "0x101D47C", VA = "0x101D47C")]
	private void _003CShow_003Em__253()
	{
	}
}
