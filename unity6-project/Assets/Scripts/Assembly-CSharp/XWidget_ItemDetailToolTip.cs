using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F97")]
public class XWidget_ItemDetailToolTip : XWidget_ItemDetail
{
	[Token(Token = "0x2000F98")]
	private sealed class _003CBuildSelectLevelBtn_003Ec__AnonStorey23E
	{
		[Token(Token = "0x4005280")]
		[FieldOffset(Offset = "0x8")]
		internal int maxLv;

		[Token(Token = "0x4005281")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_ItemDetailToolTip _003C_003Ef__this;

		[Token(Token = "0x6007432")]
		[Address(RVA = "0x145558C", Offset = "0x145558C", VA = "0x145558C")]
		public _003CBuildSelectLevelBtn_003Ec__AnonStorey23E()
		{
		}

		[Token(Token = "0x6007433")]
		[Address(RVA = "0x1455BDC", Offset = "0x1455BDC", VA = "0x1455BDC")]
		internal void _003C_003Em__4B7()
		{
		}

		[Token(Token = "0x6007434")]
		[Address(RVA = "0x1455C38", Offset = "0x1455C38", VA = "0x1455C38")]
		internal void _003C_003Em__4B8()
		{
		}
	}

	[Token(Token = "0x4005271")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH_ITEMDETAILPOPUP;

	[Token(Token = "0x4005272")]
	[FieldOffset(Offset = "0xB4")]
	public UIPanel panel;

	[Token(Token = "0x4005273")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject goDefaultAreaRoot;

	[Token(Token = "0x4005274")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject goSetRoot;

	[Token(Token = "0x4005275")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject goBtnClose;

	[Token(Token = "0x4005276")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject goTouchHide;

	[Token(Token = "0x4005277")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject goColiderBG;

	[Token(Token = "0x4005278")]
	[FieldOffset(Offset = "0xCC")]
	public float defaultInfo_YPos;

	[Token(Token = "0x4005279")]
	[FieldOffset(Offset = "0xD0")]
	public float setInfo_YPos;

	[Token(Token = "0x400527A")]
	[FieldOffset(Offset = "0xD4")]
	public XWiget_GridBuilder selectlvBuilder;

	[Token(Token = "0x400527B")]
	[FieldOffset(Offset = "0xD8")]
	private XWidget_Button[] m_showLvButtons;

	[Token(Token = "0x400527C")]
	[FieldOffset(Offset = "0xDC")]
	public TweenAlpha tween;

	[Token(Token = "0x400527D")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject goPrice;

	[Token(Token = "0x400527E")]
	[FieldOffset(Offset = "0xE4")]
	public UI2DSprite sprPriceIcon;

	[Token(Token = "0x400527F")]
	[FieldOffset(Offset = "0xE8")]
	private bool UseSellTypePrice__BackingField;

	[Token(Token = "0x17000ECC")]
	public bool UseSellTypePrice
	{
		[Token(Token = "0x6007422")]
		[Address(RVA = "0x14548B0", Offset = "0x14548B0", VA = "0x14548B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007423")]
		[Address(RVA = "0x14548B8", Offset = "0x14548B8", VA = "0x14548B8")]
		set
		{
		}
	}

	[Token(Token = "0x600741F")]
	[Address(RVA = "0x1454554", Offset = "0x1454554", VA = "0x1454554")]
	public XWidget_ItemDetailToolTip()
	{
	}

	[Token(Token = "0x6007421")]
	[Address(RVA = "0x14545E8", Offset = "0x14545E8", VA = "0x14545E8")]
	public static XWidget_ItemDetailToolTip CreateToolTip(Transform parent, int depth = 300)
	{
		return null;
	}

	[Token(Token = "0x6007424")]
	[Address(RVA = "0x14548C0", Offset = "0x14548C0", VA = "0x14548C0", Slot = "20")]
	protected override void BuildPrice(XItem item)
	{
	}

	[Token(Token = "0x6007425")]
	[Address(RVA = "0x14547A8", Offset = "0x14547A8", VA = "0x14547A8")]
	private void SetDepth(int depth)
	{
	}

	[Token(Token = "0x6007426")]
	[Address(RVA = "0x1454B74", Offset = "0x1454B74", VA = "0x1454B74")]
	private void ResetShow()
	{
	}

	[Token(Token = "0x6007427")]
	[Address(RVA = "0x1454BC4", Offset = "0x1454BC4", VA = "0x1454BC4")]
	public void Show(XItem item, float showDuration = 0f, int depth = 300)
	{
	}

	[Token(Token = "0x6007428")]
	[Address(RVA = "0x1454D9C", Offset = "0x1454D9C", VA = "0x1454D9C")]
	public void ShowTouchHide(XItem item, float hideDelay = 5f)
	{
	}

	[Token(Token = "0x6007429")]
	[Address(RVA = "0x1454FD4", Offset = "0x1454FD4", VA = "0x1454FD4")]
	public void ShowIllustBook(XItem item)
	{
	}

	[Token(Token = "0x600742A")]
	[Address(RVA = "0x145544C", Offset = "0x145544C", VA = "0x145544C")]
	private void BuildPosAndSetActive()
	{
	}

	[Token(Token = "0x600742B")]
	[Address(RVA = "0x1455544", Offset = "0x1455544", VA = "0x1455544")]
	private void BuildSetItemInfo()
	{
	}

	[Token(Token = "0x600742C")]
	[Address(RVA = "0x1455584", Offset = "0x1455584", VA = "0x1455584")]
	private void BuildItemSkillInfo()
	{
	}

	[Token(Token = "0x600742D")]
	[Address(RVA = "0x1454D6C", Offset = "0x1454D6C", VA = "0x1454D6C")]
	public new void Build(XItem item)
	{
	}

	[Token(Token = "0x600742E")]
	[Address(RVA = "0x1455000", Offset = "0x1455000", VA = "0x1455000")]
	private void BuildSelectLevelBtn()
	{
	}

	[Token(Token = "0x600742F")]
	[Address(RVA = "0x1455594", Offset = "0x1455594", VA = "0x1455594")]
	private void OnClick_LevelButton(XWidget_Button clickBtn, int lv, int transcendCnt = 0)
	{
	}

	[Token(Token = "0x6007430")]
	[Address(RVA = "0x14558B8", Offset = "0x14558B8", VA = "0x14558B8")]
	public void SelectLevelExp(XItem item, int level)
	{
	}

	[Token(Token = "0x6007431")]
	[Address(RVA = "0x1455B98", Offset = "0x1455B98", VA = "0x1455B98")]
	private void _003CShowTouchHide_003Em__4B6()
	{
	}
}
