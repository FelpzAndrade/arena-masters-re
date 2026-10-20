using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FAB")]
public class XWidget_MissionElement : MonoBehaviour
{
	[Token(Token = "0x40052F4")]
	[FieldOffset(Offset = "0xC")]
	public XUISound sound;

	[Token(Token = "0x40052F5")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblStage;

	[Token(Token = "0x40052F6")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridStar;

	[Token(Token = "0x40052F7")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Button btn;

	[Token(Token = "0x40052F8")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprActive;

	[Token(Token = "0x40052F9")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprClear;

	[Token(Token = "0x40052FA")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite sprDisable;

	[Token(Token = "0x40052FB")]
	[FieldOffset(Offset = "0x28")]
	public float scaleDuration;

	[Token(Token = "0x40052FC")]
	[FieldOffset(Offset = "0x2C")]
	private CSStageInfo m_stageInfo;

	[Token(Token = "0x40052FD")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsPrevClear;

	[Token(Token = "0x40052FE")]
	[FieldOffset(Offset = "0x34")]
	private int m_bestScore;

	[Token(Token = "0x40052FF")]
	[FieldOffset(Offset = "0x38")]
	private TweenScale m_tweenScale;

	[Token(Token = "0x4005300")]
	[FieldOffset(Offset = "0x3C")]
	private List<XWidget_MissionPathElement> m_pathList;

	[Token(Token = "0x60074A3")]
	[Address(RVA = "0x1466400", Offset = "0x1466400", VA = "0x1466400")]
	public XWidget_MissionElement()
	{
	}

	[Token(Token = "0x60074A4")]
	[Address(RVA = "0x1466D74", Offset = "0x1466D74", VA = "0x1466D74")]
	private void OnApplicationFocus(bool isFocus)
	{
	}

	[Token(Token = "0x60074A5")]
	[Address(RVA = "0x1466840", Offset = "0x1466840", VA = "0x1466840", Slot = "4")]
	public virtual void Show(CSStageInfo stageInfo, int bestScore, bool isPrevClear, List<XWidget_MissionPathElement> pathList)
	{
	}

	[Token(Token = "0x60074A6")]
	[Address(RVA = "0x1466F28", Offset = "0x1466F28", VA = "0x1466F28")]
	private void BuildActive()
	{
	}

	[Token(Token = "0x60074A7")]
	[Address(RVA = "0x1467178", Offset = "0x1467178", VA = "0x1467178")]
	private void BuildStar(int userStar)
	{
	}

	[Token(Token = "0x60074A8")]
	[Address(RVA = "0x1466AB8", Offset = "0x1466AB8", VA = "0x1466AB8")]
	protected void SetActiveScale(bool active)
	{
	}

	[Token(Token = "0x60074A9")]
	[Address(RVA = "0x14671F8", Offset = "0x14671F8", VA = "0x14671F8")]
	public void SetSound(bool enterable)
	{
	}

	[Token(Token = "0x60074AA")]
	[Address(RVA = "0x146752C", Offset = "0x146752C", VA = "0x146752C")]
	public void OnClick_GoToMissionDetail()
	{
	}
}
