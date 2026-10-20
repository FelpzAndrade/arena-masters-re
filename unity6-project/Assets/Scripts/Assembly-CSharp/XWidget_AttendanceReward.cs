using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAE")]
public class XWidget_AttendanceReward : MonoBehaviour
{
	[Token(Token = "0x40046F2")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblday7RewardName;

	[Token(Token = "0x40046F3")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblnormalDayRewardName;

	[Token(Token = "0x40046F4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goReward;

	[Token(Token = "0x40046F5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goDay7;

	[Token(Token = "0x40046F6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblDay;

	[Token(Token = "0x40046F7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goStampNormal;

	[Token(Token = "0x40046F8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goStamp7;

	[Token(Token = "0x40046F9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goToday7;

	[Token(Token = "0x40046FA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goTodayNormal;

	[Token(Token = "0x40046FB")]
	[FieldOffset(Offset = "0x30")]
	public UIBasicSprite sprArrow;

	[Token(Token = "0x40046FC")]
	[FieldOffset(Offset = "0x34")]
	public Transform contentItemParent;

	[Token(Token = "0x40046FD")]
	[FieldOffset(Offset = "0x38")]
	private XWidget_ContentIcon _contentIcon;

	[Token(Token = "0x40046FE")]
	[FieldOffset(Offset = "0x3C")]
	public string stampSoundKey;

	[Token(Token = "0x40046FF")]
	[FieldOffset(Offset = "0x40")]
	public float soundPlayTime;

	[Token(Token = "0x4004700")]
	[FieldOffset(Offset = "0x44")]
	private TweenScale tweenScale;

	[Token(Token = "0x4004701")]
	[FieldOffset(Offset = "0x48")]
	private XWidget_ContentIcon.Option option;

	[Token(Token = "0x4004702")]
	[FieldOffset(Offset = "0x4C")]
	private bool isToday;

	[Token(Token = "0x4004703")]
	[FieldOffset(Offset = "0x4D")]
	private bool isLastdayOfWeek;

	[Token(Token = "0x17000D4C")]
	private XWidget_ContentIcon contentIcon
	{
		[Token(Token = "0x6006489")]
		[Address(RVA = "0x193F410", Offset = "0x193F410", VA = "0x193F410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006488")]
	[Address(RVA = "0x193F378", Offset = "0x193F378", VA = "0x193F378")]
	public XWidget_AttendanceReward()
	{
	}

	[Token(Token = "0x600648A")]
	[Address(RVA = "0x193F5EC", Offset = "0x193F5EC", VA = "0x193F5EC")]
	private void BuildCommon(CSContent content, int day, int today)
	{
	}

	[Token(Token = "0x600648B")]
	[Address(RVA = "0x193FC88", Offset = "0x193FC88", VA = "0x193FC88")]
	private void BuildStamp(bool show, bool isLastdayOfWeek)
	{
	}

	[Token(Token = "0x600648C")]
	[Address(RVA = "0x193FCE0", Offset = "0x193FCE0", VA = "0x193FCE0")]
	private TweenScale GetStampScale(bool isLastdayOfWeek)
	{
		return null;
	}

	[Token(Token = "0x600648D")]
	[Address(RVA = "0x193E610", Offset = "0x193E610", VA = "0x193E610")]
	public void Build(CSContent content, int day, int today, UIDirector director)
	{
	}

	[Token(Token = "0x600648E")]
	[Address(RVA = "0x193E880", Offset = "0x193E880", VA = "0x193E880")]
	public void BuildWithoutDirection(CSContent content, int day, int today)
	{
	}

	[Token(Token = "0x600648F")]
	[Address(RVA = "0x193FD88", Offset = "0x193FD88", VA = "0x193FD88")]
	private void _003CBuild_003Em__32A()
	{
	}

	[Token(Token = "0x6006490")]
	[Address(RVA = "0x193FDC4", Offset = "0x193FDC4", VA = "0x193FDC4")]
	private void _003CBuild_003Em__32B()
	{
	}
}
