using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F68")]
public class XWidget_BoosterButton : MonoBehaviour
{
	[Token(Token = "0x2000F69")]
	public enum BoosterType
	{
		[Token(Token = "0x400510F")]
		Gold = 0,
		[Token(Token = "0x4005110")]
		Item = 1,
		[Token(Token = "0x4005111")]
		Promstone = 2
	}

	[Token(Token = "0x40050FD")]
	[FieldOffset(Offset = "0xC")]
	private BoosterType boosterType;

	[Token(Token = "0x40050FE")]
	[FieldOffset(Offset = "0x10")]
	public XUISound sound;

	[Token(Token = "0x40050FF")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprBoosterIcon;

	[Token(Token = "0x4005100")]
	[FieldOffset(Offset = "0x18")]
	public GameObject sprHighlight;

	[Token(Token = "0x4005101")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject sprCheckMark;

	[Token(Token = "0x4005102")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprDisable;

	[Token(Token = "0x4005103")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblCount;

	[Token(Token = "0x4005104")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblCost;

	[Token(Token = "0x4005105")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goCostRoot;

	[Token(Token = "0x4005106")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isClick;

	[Token(Token = "0x4005107")]
	[FieldOffset(Offset = "0x31")]
	private bool m_isLackCount;

	[Token(Token = "0x4005108")]
	[FieldOffset(Offset = "0x32")]
	private bool m_isForceDisable;

	[Token(Token = "0x4005109")]
	[FieldOffset(Offset = "0x33")]
	private bool m_isEnable;

	[Token(Token = "0x400510A")]
	[FieldOffset(Offset = "0x34")]
	private int m_needCount;

	[Token(Token = "0x400510B")]
	[FieldOffset(Offset = "0x38")]
	private int m_currCount;

	[Token(Token = "0x400510C")]
	[FieldOffset(Offset = "0x3C")]
	private Action<bool> onChecked;

	[Token(Token = "0x400510D")]
	[FieldOffset(Offset = "0x40")]
	private bool isChecked__BackingField;

	[Token(Token = "0x17000E9C")]
	public bool isChecked
	{
		[Token(Token = "0x600727C")]
		[Address(RVA = "0x15BC81C", Offset = "0x15BC81C", VA = "0x15BC81C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600727D")]
		[Address(RVA = "0x15BC824", Offset = "0x15BC824", VA = "0x15BC824")]
		private set
		{
		}
	}

	[Token(Token = "0x600727B")]
	[Address(RVA = "0x15BC80C", Offset = "0x15BC80C", VA = "0x15BC80C")]
	public XWidget_BoosterButton()
	{
	}

	[Token(Token = "0x600727E")]
	[Address(RVA = "0x15BC82C", Offset = "0x15BC82C", VA = "0x15BC82C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600727F")]
	[Address(RVA = "0x15BC9E8", Offset = "0x15BC9E8", VA = "0x15BC9E8")]
	public void Build(XMyInfo myinfo, BoosterType type, bool isBeforeChecked, Action<bool> onChecked, bool forceDisable = false)
	{
	}

	[Token(Token = "0x6007280")]
	[Address(RVA = "0x15BCA18", Offset = "0x15BCA18", VA = "0x15BCA18")]
	private void Build(XMyInfo myInfo, bool isBeforeChecked, bool forceDisable)
	{
	}

	[Token(Token = "0x6007281")]
	[Address(RVA = "0x15BCD80", Offset = "0x15BCD80", VA = "0x15BCD80")]
	private void ShowCheckMark(bool isShow)
	{
	}

	[Token(Token = "0x6007282")]
	[Address(RVA = "0x15BD030", Offset = "0x15BD030", VA = "0x15BD030")]
	public void ShowCheckMark()
	{
	}

	[Token(Token = "0x6007283")]
	[Address(RVA = "0x15BCC90", Offset = "0x15BCC90", VA = "0x15BCC90")]
	private void ShowDisable(bool enable)
	{
	}

	[Token(Token = "0x6007284")]
	[Address(RVA = "0x15BCAA0", Offset = "0x15BCAA0", VA = "0x15BCAA0")]
	private void SetCount(XMyInfo myInfo, BoosterType boosterType)
	{
	}

	[Token(Token = "0x6007285")]
	[Address(RVA = "0x15BD128", Offset = "0x15BD128", VA = "0x15BD128")]
	public void OnClick_Button()
	{
	}

	[Token(Token = "0x6007286")]
	[Address(RVA = "0x15BD044", Offset = "0x15BD044", VA = "0x15BD044")]
	private void SetSound(bool isEnable)
	{
	}

	[Token(Token = "0x6007287")]
	[Address(RVA = "0x15BCEFC", Offset = "0x15BCEFC", VA = "0x15BCEFC")]
	private void SetBoosterIcon()
	{
	}
}
