using System;
using System.Collections.Generic;
using CS;
using CS.ranking;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EFE")]
public class XWidget_TrophyReward : MonoBehaviour
{
	[Token(Token = "0x2000EFF")]
	public enum RewardState
	{
		[Token(Token = "0x4004F8C")]
		None = 0,
		[Token(Token = "0x4004F8D")]
		Point = 1,
		[Token(Token = "0x4004F8E")]
		Active = 2,
		[Token(Token = "0x4004F8F")]
		Cool = 3
	}

	[Token(Token = "0x2000F00")]
	private sealed class _003CBuildMultiContent_003Ec__AnonStorey225
	{
		[Token(Token = "0x4004F90")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSContent> contents;

		[Token(Token = "0x4004F91")]
		[FieldOffset(Offset = "0xC")]
		internal int restoreGoldCount;

		[Token(Token = "0x4004F92")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_TrophyReward _003C_003Ef__this;

		[Token(Token = "0x6007006")]
		[Address(RVA = "0x1B2DA30", Offset = "0x1B2DA30", VA = "0x1B2DA30")]
		public _003CBuildMultiContent_003Ec__AnonStorey225()
		{
		}

		[Token(Token = "0x6007007")]
		[Address(RVA = "0x1B2E274", Offset = "0x1B2E274", VA = "0x1B2E274")]
		internal void _003C_003Em__458()
		{
		}
	}

	[Token(Token = "0x4004F6C")]
	[FieldOffset(Offset = "0xC")]
	private readonly string Path_MultiContents;

	[Token(Token = "0x4004F6D")]
	[FieldOffset(Offset = "0x10")]
	private readonly string Path_SingleGacha_m;

	[Token(Token = "0x4004F6E")]
	[FieldOffset(Offset = "0x14")]
	private GameObject _frameForMulti;

	[Token(Token = "0x4004F6F")]
	[FieldOffset(Offset = "0x18")]
	private XWidget_GachaCardBox _singleContentIcon_Multi;

	[Token(Token = "0x4004F70")]
	[FieldOffset(Offset = "0x1C")]
	private UIDirector m_direction;

	[Token(Token = "0x4004F71")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_GachaItemCardDirection gachaItemCardDirection;

	[Token(Token = "0x4004F72")]
	[FieldOffset(Offset = "0x24")]
	private bool isStartDirection;

	[Token(Token = "0x4004F73")]
	[FieldOffset(Offset = "0x28")]
	private RewardState m_rewardState;

	[Token(Token = "0x4004F74")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblRanking;

	[Token(Token = "0x4004F75")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblTrophyBoxName;

	[Token(Token = "0x4004F76")]
	[FieldOffset(Offset = "0x34")]
	public UI2DSprite sprBoxIcon;

	[Token(Token = "0x4004F77")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PointState;

	[Token(Token = "0x4004F78")]
	[FieldOffset(Offset = "0x3C")]
	public UIProgressBar prb;

	[Token(Token = "0x4004F79")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblProgress;

	[Token(Token = "0x4004F7A")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ActiveState;

	[Token(Token = "0x4004F7B")]
	[FieldOffset(Offset = "0x48")]
	public UILabel lblReceiveReward;

	[Token(Token = "0x4004F7C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject CoolTimeState;

	[Token(Token = "0x4004F7D")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblRemainTime;

	[Token(Token = "0x4004F7E")]
	[FieldOffset(Offset = "0x54")]
	public TweenScale boxTweenScale;

	[Token(Token = "0x4004F7F")]
	[FieldOffset(Offset = "0x58")]
	private bool m_isFullPoint;

	[Token(Token = "0x4004F80")]
	[FieldOffset(Offset = "0x59")]
	private bool m_isCoolEnd;

	[Token(Token = "0x4004F81")]
	[FieldOffset(Offset = "0x5C")]
	private int m_coolTime;

	[Token(Token = "0x4004F82")]
	[FieldOffset(Offset = "0x60")]
	private DateTime m_lastRecieveTime;

	[Token(Token = "0x4004F83")]
	[FieldOffset(Offset = "0x70")]
	private DateTime m_endCoolTime;

	[Token(Token = "0x4004F84")]
	[FieldOffset(Offset = "0x80")]
	private bool m_isCoolTime;

	[Token(Token = "0x4004F85")]
	[FieldOffset(Offset = "0x84")]
	private int m_maxPoint;

	[Token(Token = "0x4004F86")]
	[FieldOffset(Offset = "0x88")]
	private int m_coolTimePassCount;

	[Token(Token = "0x4004F87")]
	[FieldOffset(Offset = "0x90")]
	private TimeSpan m_remainTime;

	[Token(Token = "0x4004F88")]
	[FieldOffset(Offset = "0x98")]
	private bool m_isViewType;

	[Token(Token = "0x4004F89")]
	[FieldOffset(Offset = "0x9C")]
	private Action m_viewAction;

	[Token(Token = "0x4004F8A")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject BackgroundCollider;

	[Token(Token = "0x17000E28")]
	public GameObject frameForMulti
	{
		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0x1B2B8F4", Offset = "0x1B2B8F4", VA = "0x1B2B8F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E29")]
	public XWidget_GachaCardBox singleContentIcon_Multi
	{
		[Token(Token = "0x6006FED")]
		[Address(RVA = "0x1B2BAB0", Offset = "0x1B2BAB0", VA = "0x1B2BAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006FEB")]
	[Address(RVA = "0x1B2B820", Offset = "0x1B2B820", VA = "0x1B2B820")]
	public XWidget_TrophyReward()
	{
	}

	[Token(Token = "0x6006FEE")]
	[Address(RVA = "0x1B2BC94", Offset = "0x1B2BC94", VA = "0x1B2BC94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006FEF")]
	[Address(RVA = "0x1B2BD28", Offset = "0x1B2BD28", VA = "0x1B2BD28")]
	private void Update()
	{
	}

	[Token(Token = "0x6006FF0")]
	[Address(RVA = "0x1B2BF9C", Offset = "0x1B2BF9C", VA = "0x1B2BF9C")]
	private void RecieveDirectionTestCode()
	{
	}

	[Token(Token = "0x6006FF1")]
	[Address(RVA = "0x1B2C5D8", Offset = "0x1B2C5D8", VA = "0x1B2C5D8")]
	private void ChangeState(RewardState trophyRewardState)
	{
	}

	[Token(Token = "0x6006FF2")]
	[Address(RVA = "0x1B2C5EC", Offset = "0x1B2C5EC", VA = "0x1B2C5EC")]
	private void State()
	{
	}

	[Token(Token = "0x6006FF3")]
	[Address(RVA = "0x1B2C7C4", Offset = "0x1B2C7C4", VA = "0x1B2C7C4")]
	public void Build_ForLadderMain(DateTime lastRecieveTimeDictionary, int coolTimePassCountDic, int curPoint, int maxPoint, string boxIconPath, string trophyIconPath, string rankName, string boxName, CSProtoInfoManager_GameConst gameConst)
	{
	}

	[Token(Token = "0x6006FF4")]
	[Address(RVA = "0x1B2CA3C", Offset = "0x1B2CA3C", VA = "0x1B2CA3C")]
	public void Build_ForReadyView(DateTime lastRecieveTimeDictionary, int coolTimePassCountDic, int curPoint, int maxPoint, string boxIconPath, string trophyIconPath, string rankName, string boxName, CSProtoInfoManager_GameConst gameConst, bool isViewType, Action viewAction)
	{
	}

	[Token(Token = "0x6006FF5")]
	[Address(RVA = "0x1B2C830", Offset = "0x1B2C830", VA = "0x1B2C830")]
	private void BuildCommon(DateTime lastRecieveTimeDictionary, int coolTimePassCountDic, int curPoint, int maxPoint, string boxIconPath, string rankName, string boxName, CSProtoInfoManager_GameConst gameConst)
	{
	}

	[Token(Token = "0x6006FF6")]
	[Address(RVA = "0x1B2CAA8", Offset = "0x1B2CAA8", VA = "0x1B2CAA8")]
	private void BuildTitle(string rankName, string boxName)
	{
	}

	[Token(Token = "0x6006FF7")]
	[Address(RVA = "0x1B2CED4", Offset = "0x1B2CED4", VA = "0x1B2CED4")]
	private void BuildRewardBox(string boxIconPath)
	{
	}

	[Token(Token = "0x6006FF8")]
	[Address(RVA = "0x1B2CBF4", Offset = "0x1B2CBF4", VA = "0x1B2CBF4")]
	private void BuildPrb(int curPoint, int maxPoint)
	{
	}

	[Token(Token = "0x6006FF9")]
	[Address(RVA = "0x1B2BC9C", Offset = "0x1B2BC9C", VA = "0x1B2BC9C")]
	private void SetActiveRecieve(bool bActive)
	{
	}

	[Token(Token = "0x6006FFA")]
	[Address(RVA = "0x1B2BD70", Offset = "0x1B2BD70", VA = "0x1B2BD70")]
	private void CalcRemainCoolTime()
	{
	}

	[Token(Token = "0x6006FFB")]
	[Address(RVA = "0x1B2BF38", Offset = "0x1B2BF38", VA = "0x1B2BF38")]
	private void SetState()
	{
	}

	[Token(Token = "0x6006FFC")]
	[Address(RVA = "0x1B2D028", Offset = "0x1B2D028", VA = "0x1B2D028")]
	private void TrophyInfoSync()
	{
	}

	[Token(Token = "0x6006FFD")]
	[Address(RVA = "0x1B2D1EC", Offset = "0x1B2D1EC", VA = "0x1B2D1EC")]
	public void OnClick_Recieve()
	{
	}

	[Token(Token = "0x6006FFE")]
	[Address(RVA = "0x1B2D404", Offset = "0x1B2D404", VA = "0x1B2D404")]
	private void SendNetProcess()
	{
	}

	[Token(Token = "0x6006FFF")]
	[Address(RVA = "0x1B2C554", Offset = "0x1B2C554", VA = "0x1B2C554")]
	private void ResponseRoyalRecieve(RoyalRewardPackage package)
	{
	}

	[Token(Token = "0x6007000")]
	[Address(RVA = "0x1B2D758", Offset = "0x1B2D758", VA = "0x1B2D758")]
	private void BuildMultiContent(List<CSContent> contents, int restoreGoldCount, bool isMail)
	{
	}

	[Token(Token = "0x6007001")]
	[Address(RVA = "0x1B2CFD8", Offset = "0x1B2CFD8", VA = "0x1B2CFD8")]
	private void ResetDirection()
	{
	}

	[Token(Token = "0x6007002")]
	[Address(RVA = "0x1B2DA38", Offset = "0x1B2DA38", VA = "0x1B2DA38")]
	private void EndDirection()
	{
	}

	[Token(Token = "0x6007003")]
	[Address(RVA = "0x1B2D58C", Offset = "0x1B2D58C", VA = "0x1B2D58C")]
	public int GetRestoreGoldCount(List<CSContent> contents)
	{
		return default(int);
	}

	[Token(Token = "0x6007004")]
	[Address(RVA = "0x1B2DA3C", Offset = "0x1B2DA3C", VA = "0x1B2DA3C")]
	private bool IsBonusGold(CSContent content)
	{
		return default(bool);
	}

	[Token(Token = "0x6007005")]
	[Address(RVA = "0x1B2DA8C", Offset = "0x1B2DA8C", VA = "0x1B2DA8C")]
	private void _003CSendNetProcess_003Em__457(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
