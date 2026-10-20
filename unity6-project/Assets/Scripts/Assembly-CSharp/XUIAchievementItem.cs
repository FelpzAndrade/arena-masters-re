using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001015")]
public class XUIAchievementItem : MonoBehaviour
{
	[Token(Token = "0x400561D")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprAchieveIcon;

	[Token(Token = "0x400561E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblAchieveTitle;

	[Token(Token = "0x400561F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblAchieveDesc;

	[Token(Token = "0x4005620")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblClearGroupProgress;

	[Token(Token = "0x4005621")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblCondition;

	[Token(Token = "0x4005622")]
	[FieldOffset(Offset = "0x20")]
	public XWiget_GridBuilder gridRewards;

	[Token(Token = "0x4005623")]
	[FieldOffset(Offset = "0x24")]
	public CSContent[] m_rewardsList;

	[Token(Token = "0x4005624")]
	[FieldOffset(Offset = "0x28")]
	public QuestInfo m_achieveInfo;

	[Token(Token = "0x4005625")]
	[FieldOffset(Offset = "0x2C")]
	private int m_nAchieveId;

	[Token(Token = "0x4005626")]
	[FieldOffset(Offset = "0x30")]
	private bool m_complete;

	[Token(Token = "0x4005627")]
	[FieldOffset(Offset = "0x34")]
	public UIProgressBar progressbar;

	[Token(Token = "0x4005628")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_Button btnComplete;

	[Token(Token = "0x60077FA")]
	[Address(RVA = "0x185978C", Offset = "0x185978C", VA = "0x185978C")]
	public XUIAchievementItem()
	{
	}

	[Token(Token = "0x60077FB")]
	[Address(RVA = "0x1859794", Offset = "0x1859794", VA = "0x1859794")]
	public void Build(QuestInfo questInfo, UserDataBase data)
	{
	}

	[Token(Token = "0x60077FC")]
	[Address(RVA = "0x1859FF4", Offset = "0x1859FF4", VA = "0x1859FF4")]
	private void SetProgressbar(QuestInfo achieveInfo, int progressCount, int totalCount, bool clear)
	{
	}

	[Token(Token = "0x60077FD")]
	[Address(RVA = "0x185A2C4", Offset = "0x185A2C4", VA = "0x185A2C4")]
	public void OnClick_Complete()
	{
	}

	[Token(Token = "0x60077FE")]
	[Address(RVA = "0x185A3A8", Offset = "0x185A3A8", VA = "0x185A3A8")]
	public void OnClick_RewardFail()
	{
	}
}
