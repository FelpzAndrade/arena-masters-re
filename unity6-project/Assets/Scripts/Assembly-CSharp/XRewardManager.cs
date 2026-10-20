using System.Collections;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004F9")]
public class XRewardManager
{
	[Token(Token = "0x4001926")]
	[FieldOffset(Offset = "0x8")]
	private XReward m_ClearReward;

	[Token(Token = "0x4001927")]
	[FieldOffset(Offset = "0xC")]
	private List<XReward> m_TreasureRewardList;

	[Token(Token = "0x4001928")]
	[FieldOffset(Offset = "0x10")]
	private bool m_bEmpty;

	[Token(Token = "0x4001929")]
	[FieldOffset(Offset = "0x14")]
	private int m_score;

	[Token(Token = "0x400192A")]
	[FieldOffset(Offset = "0x18")]
	private int m_maxScore;

	[Token(Token = "0x400192B")]
	[FieldOffset(Offset = "0x1C")]
	private int m_calculatedScore;

	[Token(Token = "0x400192C")]
	[FieldOffset(Offset = "0x20")]
	private int m_nClearXP;

	[Token(Token = "0x400192D")]
	[FieldOffset(Offset = "0x24")]
	private int m_nGoldInGame;

	[Token(Token = "0x400192E")]
	[FieldOffset(Offset = "0x28")]
	private int m_nHeroInGame;

	[Token(Token = "0x400192F")]
	[FieldOffset(Offset = "0x2C")]
	private int m_nItemInGame;

	[Token(Token = "0x4001930")]
	[FieldOffset(Offset = "0x30")]
	private int m_killCnt;

	[Token(Token = "0x170006B8")]
	public bool Empty
	{
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x1CA5E38", Offset = "0x1CA5E38", VA = "0x1CA5E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B9")]
	public int ClearXP
	{
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0x1CA5E40", Offset = "0x1CA5E40", VA = "0x1CA5E40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BA")]
	public int Score
	{
		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0x1CA5E48", Offset = "0x1CA5E48", VA = "0x1CA5E48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BB")]
	public int MaxScore
	{
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x1CA5E50", Offset = "0x1CA5E50", VA = "0x1CA5E50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BC")]
	public int CalculatedScore
	{
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x1CA5E58", Offset = "0x1CA5E58", VA = "0x1CA5E58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BD")]
	public int ClearXPApplyMod
	{
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0x1CA5E60", Offset = "0x1CA5E60", VA = "0x1CA5E60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BE")]
	public List<XReward> TreasureRewardList
	{
		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0x1CA6008", Offset = "0x1CA6008", VA = "0x1CA6008")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BF")]
	public int GoldInGame
	{
		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0x1CA6010", Offset = "0x1CA6010", VA = "0x1CA6010")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C0")]
	public int HeroInGame
	{
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x1CA6018", Offset = "0x1CA6018", VA = "0x1CA6018")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C1")]
	public int ItemInGame
	{
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x1CA6020", Offset = "0x1CA6020", VA = "0x1CA6020")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x1CA4B9C", Offset = "0x1CA4B9C", VA = "0x1CA4B9C")]
	public XRewardManager()
	{
	}

	[Token(Token = "0x6002AE5")]
	[Address(RVA = "0x1CA4C78", Offset = "0x1CA4C78", VA = "0x1CA4C78")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002AE6")]
	[Address(RVA = "0x1CA4D44", Offset = "0x1CA4D44", VA = "0x1CA4D44")]
	public void ClearDataInGame()
	{
	}

	[Token(Token = "0x6002AE7")]
	[Address(RVA = "0x1CA4ADC", Offset = "0x1CA4ADC", VA = "0x1CA4ADC")]
	public void ApplyRewardItem(XReward reward)
	{
	}

	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x1CA4D64", Offset = "0x1CA4D64", VA = "0x1CA4D64")]
	private void ParseReward(JObject json_reward)
	{
	}

	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x1CA5540", Offset = "0x1CA5540", VA = "0x1CA5540")]
	public string AssignRewardToJson(XReward reward)
	{
		return null;
	}

	[Token(Token = "0x6002AEA")]
	[Address(RVA = "0x1CA5670", Offset = "0x1CA5670", VA = "0x1CA5670")]
	public void InitFromJsonData(JObject json)
	{
	}

	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x1CA58D4", Offset = "0x1CA58D4", VA = "0x1CA58D4")]
	public void AddGoldInGame(int nAddedGold)
	{
	}

	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x1CA59BC", Offset = "0x1CA59BC", VA = "0x1CA59BC")]
	public void AddScoreInGame(int nScore)
	{
	}

	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x1CA59D8", Offset = "0x1CA59D8", VA = "0x1CA59D8")]
	public void AddCalculatedScoreInGame(int nScore)
	{
	}

	[Token(Token = "0x6002AEE")]
	[Address(RVA = "0x1CA5AC0", Offset = "0x1CA5AC0", VA = "0x1CA5AC0")]
	public void SetMaxScore(int maxScore)
	{
	}

	[Token(Token = "0x6002AEF")]
	[Address(RVA = "0x1CA535C", Offset = "0x1CA535C", VA = "0x1CA535C")]
	public static CSContentType StringToRewardType(string strValue)
	{
		return default(CSContentType);
	}

	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x1CA5178", Offset = "0x1CA5178", VA = "0x1CA5178")]
	public static XRewardCategory StringToRewardCategory(string strValue)
	{
		return default(XRewardCategory);
	}

	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x1CA5BA0", Offset = "0x1CA5BA0", VA = "0x1CA5BA0")]
	public ArrayList makeRewardJsonData()
	{
		return null;
	}
}
