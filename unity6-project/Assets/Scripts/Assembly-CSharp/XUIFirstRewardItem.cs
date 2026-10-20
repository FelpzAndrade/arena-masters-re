using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001020")]
public class XUIFirstRewardItem : MonoBehaviour
{
	[Token(Token = "0x400566B")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x400566C")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprTierIcon;

	[Token(Token = "0x400566D")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprRewardIcon_1;

	[Token(Token = "0x400566E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRewardCount_1;

	[Token(Token = "0x400566F")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprRewardIcon_2;

	[Token(Token = "0x4005670")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblRewardCount_2;

	[Token(Token = "0x4005671")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_Button widgetRecieveButton;

	[Token(Token = "0x4005672")]
	[FieldOffset(Offset = "0x28")]
	public GameObject completeButton;

	[Token(Token = "0x4005673")]
	[FieldOffset(Offset = "0x2C")]
	private CSFirstRankReward m_firstRankRewardItemInfo;

	[Token(Token = "0x4005674")]
	[FieldOffset(Offset = "0x30")]
	private RankType m_rankType;

	[Token(Token = "0x4005675")]
	[FieldOffset(Offset = "0x34")]
	private FirstRankRewardRecieveState m_firstRankRewardRecieveState;

	[Token(Token = "0x17000EF8")]
	public CSFirstRankReward firstRankRewardItemInfo
	{
		[Token(Token = "0x6007834")]
		[Address(RVA = "0x1A437D0", Offset = "0x1A437D0", VA = "0x1A437D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007833")]
	[Address(RVA = "0x1A437C8", Offset = "0x1A437C8", VA = "0x1A437C8")]
	public XUIFirstRewardItem()
	{
	}

	[Token(Token = "0x6007835")]
	[Address(RVA = "0x1A437D8", Offset = "0x1A437D8", VA = "0x1A437D8")]
	public void Build(RankType rankType, CSFirstRankReward firstRankRewardItemInfo, FirstRankRewardRecieveState firstRankRewardRecieveState)
	{
	}

	[Token(Token = "0x6007836")]
	[Address(RVA = "0x1A43C08", Offset = "0x1A43C08", VA = "0x1A43C08")]
	private void ChangeState(FirstRankRewardRecieveState state)
	{
	}

	[Token(Token = "0x6007837")]
	[Address(RVA = "0x1A43D44", Offset = "0x1A43D44", VA = "0x1A43D44")]
	public void OnClick_RecieveReward()
	{
	}

	[Token(Token = "0x6007838")]
	[Address(RVA = "0x1A43FE4", Offset = "0x1A43FE4", VA = "0x1A43FE4")]
	private void _003COnClick_RecieveReward_003Em__4FF(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
