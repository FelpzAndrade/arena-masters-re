using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D69")]
public class XPanel_RankPointDirection : XCommonBackUI
{
	[Token(Token = "0x2000D6A")]
	private enum RankResultState
	{
		[Token(Token = "0x400453D")]
		none = 0,
		[Token(Token = "0x400453E")]
		maintain = 1,
		[Token(Token = "0x400453F")]
		promotion = 2,
		[Token(Token = "0x4004540")]
		demotion = 3,
		[Token(Token = "0x4004541")]
		placement_end = 4
	}

	[Token(Token = "0x2000D6B")]
	private sealed class _003CShow_003Ec__AnonStorey1A8
	{
		[Token(Token = "0x4004542")]
		[FieldOffset(Offset = "0x8")]
		internal int beforeScore;

		[Token(Token = "0x4004543")]
		[FieldOffset(Offset = "0xC")]
		internal int currentScore;

		[Token(Token = "0x600629B")]
		[Address(RVA = "0xAB266C", Offset = "0xAB266C", VA = "0xAB266C")]
		public _003CShow_003Ec__AnonStorey1A8()
		{
		}

		[Token(Token = "0x600629C")]
		[Address(RVA = "0xAB3FFC", Offset = "0xAB3FFC", VA = "0xAB3FFC")]
		internal bool _003C_003Em__307(int tierScore)
		{
			return default(bool);
		}

		[Token(Token = "0x600629D")]
		[Address(RVA = "0xAB4010", Offset = "0xAB4010", VA = "0xAB4010")]
		internal bool _003C_003Em__308(int tierScore)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D6C")]
	private sealed class _003CAddScoreLableDirection_003Ec__AnonStorey1A9
	{
		[Token(Token = "0x4004544")]
		[FieldOffset(Offset = "0x8")]
		internal int currentScore;

		[Token(Token = "0x4004545")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_RankPointDirection _003C_003Ef__this;

		[Token(Token = "0x600629E")]
		[Address(RVA = "0xAB38DC", Offset = "0xAB38DC", VA = "0xAB38DC")]
		public _003CAddScoreLableDirection_003Ec__AnonStorey1A9()
		{
		}

		[Token(Token = "0x600629F")]
		[Address(RVA = "0xAB3CE0", Offset = "0xAB3CE0", VA = "0xAB3CE0")]
		internal void _003C_003Em__309()
		{
		}

		[Token(Token = "0x60062A0")]
		[Address(RVA = "0xAB3D98", Offset = "0xAB3D98", VA = "0xAB3D98")]
		internal void _003C_003Em__30A()
		{
		}
	}

	[Token(Token = "0x2000D6D")]
	private sealed class _003CAddFluctuationDirection_003Ec__AnonStorey1AA
	{
		[Token(Token = "0x4004546")]
		[FieldOffset(Offset = "0x8")]
		internal int fluctuation;

		[Token(Token = "0x4004547")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_RankPointDirection _003C_003Ef__this;

		[Token(Token = "0x60062A1")]
		[Address(RVA = "0xAB38E4", Offset = "0xAB38E4", VA = "0xAB38E4")]
		public _003CAddFluctuationDirection_003Ec__AnonStorey1AA()
		{
		}

		[Token(Token = "0x60062A2")]
		[Address(RVA = "0xAB3930", Offset = "0xAB3930", VA = "0xAB3930")]
		internal void _003C_003Em__30B()
		{
		}
	}

	[Token(Token = "0x2000D6E")]
	private sealed class _003CAddTierChangeDirection_003Ec__AnonStorey1AB
	{
		[Token(Token = "0x4004548")]
		[FieldOffset(Offset = "0x8")]
		internal CSTrophyReward currentTrophyRewardInfo;

		[Token(Token = "0x4004549")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject goTierResultEffect;

		[Token(Token = "0x400454A")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_RankPointDirection _003C_003Ef__this;

		[Token(Token = "0x60062A3")]
		[Address(RVA = "0xAB38EC", Offset = "0xAB38EC", VA = "0xAB38EC")]
		public _003CAddTierChangeDirection_003Ec__AnonStorey1AB()
		{
		}

		[Token(Token = "0x60062A4")]
		[Address(RVA = "0xAB3DE0", Offset = "0xAB3DE0", VA = "0xAB3DE0")]
		internal void _003C_003Em__30C()
		{
		}
	}

	[Token(Token = "0x2000D6F")]
	private sealed class _003CAddPlacementResultDirection_003Ec__AnonStorey1AC
	{
		[Token(Token = "0x400454B")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_PlacementResultItem widget;

		[Token(Token = "0x400454C")]
		[FieldOffset(Offset = "0xC")]
		internal CSWinlose result;

		[Token(Token = "0x60062A5")]
		[Address(RVA = "0xAB38F4", Offset = "0xAB38F4", VA = "0xAB38F4")]
		public _003CAddPlacementResultDirection_003Ec__AnonStorey1AC()
		{
		}

		[Token(Token = "0x60062A6")]
		[Address(RVA = "0xAB3B90", Offset = "0xAB3B90", VA = "0xAB3B90")]
		internal void _003C_003Em__30D()
		{
		}
	}

	[Token(Token = "0x4004525")]
	private const string strTierEffectEnd = "Prefab/UI/Game/TierEffect/Fx_Placement_End";

	[Token(Token = "0x4004526")]
	private const string strTierEffectDown = "Prefab/UI/Game/TierEffect/Fx_Tier_down";

	[Token(Token = "0x4004527")]
	private const string strTierEffectUp = "Prefab/UI/Game/TierEffect/Fx_Tier_up";

	[Token(Token = "0x4004528")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprTierIcon;

	[Token(Token = "0x4004529")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTier;

	[Token(Token = "0x400452A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblTierScore;

	[Token(Token = "0x400452B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblScoreLocale;

	[Token(Token = "0x400452C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goTierScore;

	[Token(Token = "0x400452D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblScoreFluctuation;

	[Token(Token = "0x400452E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject sprScoreFluctuationUP;

	[Token(Token = "0x400452F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject sprScoreFluctuationDOWN;

	[Token(Token = "0x4004530")]
	[FieldOffset(Offset = "0x38")]
	public Transform TierEffectRoot;

	[Token(Token = "0x4004531")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject goPlacementDesc;

	[Token(Token = "0x4004532")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblPmacementComment;

	[Token(Token = "0x4004533")]
	[FieldOffset(Offset = "0x44")]
	public XWiget_GridBuilder placementResultBuilder;

	[Token(Token = "0x4004534")]
	[FieldOffset(Offset = "0x48")]
	public XWidget_ClanPointDirection panel_ClanPointDirection;

	[Token(Token = "0x4004535")]
	[FieldOffset(Offset = "0x4C")]
	private XWidget_PlacementResultItem[] placementResultWidgets;

	[Token(Token = "0x4004536")]
	[FieldOffset(Offset = "0x50")]
	private UIDirector m_direction;

	[Token(Token = "0x4004537")]
	[FieldOffset(Offset = "0x54")]
	private List<int> m_tierTable;

	[Token(Token = "0x4004538")]
	[FieldOffset(Offset = "0x58")]
	public float m_labelIncreaseSpeed;

	[Token(Token = "0x4004539")]
	[FieldOffset(Offset = "0x5C")]
	public float m_speed;

	[Token(Token = "0x400453A")]
	[FieldOffset(Offset = "0x60")]
	public float m_placementResultDelay;

	[Token(Token = "0x400453B")]
	[FieldOffset(Offset = "0x64")]
	private bool m_isKickedClan;

	[Token(Token = "0x6006286")]
	[Address(RVA = "0xAB1D0C", Offset = "0xAB1D0C", VA = "0xAB1D0C")]
	public XPanel_RankPointDirection()
	{
	}

	[Token(Token = "0x6006287")]
	[Address(RVA = "0xAB1DC8", Offset = "0xAB1DC8", VA = "0xAB1DC8", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006288")]
	[Address(RVA = "0xAB1FCC", Offset = "0xAB1FCC", VA = "0xAB1FCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006289")]
	[Address(RVA = "0xAB20DC", Offset = "0xAB20DC", VA = "0xAB20DC")]
	private void SetRankUI(bool isPlacement, CSTrophyReward trophyInfo, List<CSWinlose> placementResult, int socre)
	{
	}

	[Token(Token = "0x600628A")]
	[Address(RVA = "0xAB2274", Offset = "0xAB2274", VA = "0xAB2274")]
	public void ShowClanPoint(int beforeClanScore, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x600628B")]
	[Address(RVA = "0xAB22A0", Offset = "0xAB22A0", VA = "0xAB22A0")]
	public void HideClanPoint()
	{
	}

	[Token(Token = "0x600628C")]
	[Address(RVA = "0xAB22CC", Offset = "0xAB22CC", VA = "0xAB22CC")]
	public void Show(CSTrophyReward beforeTrophyRewardInfo, CSTrophyReward currentTrophyRewardInfo, List<CSWinlose> placementResult, List<int> tierTable, int beforeScore, int currentScore, bool _isKickedClan = false)
	{
	}

	[Token(Token = "0x600628D")]
	[Address(RVA = "0xAB3780", Offset = "0xAB3780", VA = "0xAB3780")]
	private void BuildTierIcon(string path)
	{
	}

	[Token(Token = "0x600628E")]
	[Address(RVA = "0xAB21E4", Offset = "0xAB21E4", VA = "0xAB21E4")]
	private void SetBeforeDataUI(CSTrophyReward beforeTrophyRewardInfo, int score, string strScoreLocale)
	{
	}

	[Token(Token = "0x600628F")]
	[Address(RVA = "0xAB2954", Offset = "0xAB2954", VA = "0xAB2954")]
	private void AddPlacementLableDirection(UIDirector direction, int playcount, float speed = 100f, float limitDuration = 0.5f)
	{
	}

	[Token(Token = "0x6006290")]
	[Address(RVA = "0xAB2DDC", Offset = "0xAB2DDC", VA = "0xAB2DDC")]
	private void AddScoreLableDirection(UIDirector direction, int beforeScore, int currentScore)
	{
	}

	[Token(Token = "0x6006291")]
	[Address(RVA = "0xAB35F0", Offset = "0xAB35F0", VA = "0xAB35F0")]
	private void AddFluctuationDirection(UIDirector direction, int beforeScore, int currentScore)
	{
	}

	[Token(Token = "0x6006292")]
	[Address(RVA = "0xAB3174", Offset = "0xAB3174", VA = "0xAB3174")]
	private void AddTierChangeDirection(UIDirector direction, RankResultState resultState, CSTrophyReward currentTrophyRewardInfo)
	{
	}

	[Token(Token = "0x6006293")]
	[Address(RVA = "0xAB2674", Offset = "0xAB2674", VA = "0xAB2674")]
	private void HideObject()
	{
	}

	[Token(Token = "0x6006294")]
	[Address(RVA = "0xAB2850", Offset = "0xAB2850", VA = "0xAB2850")]
	private void InitPlacementResult(bool isPlacement)
	{
	}

	[Token(Token = "0x6006295")]
	[Address(RVA = "0xAB2B08", Offset = "0xAB2B08", VA = "0xAB2B08")]
	private void AddPlacementResultDirection(UIDirector direction, List<CSWinlose> placementResult)
	{
	}

	[Token(Token = "0x6006296")]
	[Address(RVA = "0xAB34AC", Offset = "0xAB34AC", VA = "0xAB34AC")]
	private int GetTierTableIndex(List<int> tierTable, Func<int, bool> checkCondition)
	{
		return default(int);
	}

	[Token(Token = "0x6006297")]
	[Address(RVA = "0xAB35CC", Offset = "0xAB35CC", VA = "0xAB35CC")]
	private RankResultState GetRankResultState(int beforeTableIndex, int currentTableIndex)
	{
		return default(RankResultState);
	}

	[Token(Token = "0x6006298")]
	[Address(RVA = "0xAB1E24", Offset = "0xAB1E24", VA = "0xAB1E24")]
	public void OnClick_GoOut()
	{
	}

	[Token(Token = "0x6006299")]
	[Address(RVA = "0xAB38FC", Offset = "0xAB38FC", VA = "0xAB38FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600629A")]
	[Address(RVA = "0xAB3928", Offset = "0xAB3928", VA = "0xAB3928")]
	private void _003COnClick_GoOut_003Em__30E()
	{
	}
}
