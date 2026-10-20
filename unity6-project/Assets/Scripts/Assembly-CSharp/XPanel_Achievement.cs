using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DB2")]
public class XPanel_Achievement : MonoBehaviour
{
	[Token(Token = "0x2000DB3")]
	private sealed class _003CAchieveComplete_003Ec__AnonStorey1B4
	{
		[Token(Token = "0x400471B")]
		[FieldOffset(Offset = "0x8")]
		internal XUIAchievementItem achieveItem;

		[Token(Token = "0x400471C")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Achievement _003C_003Ef__this;

		[Token(Token = "0x60064C7")]
		[Address(RVA = "0x1690188", Offset = "0x1690188", VA = "0x1690188")]
		public _003CAchieveComplete_003Ec__AnonStorey1B4()
		{
		}

		[Token(Token = "0x60064C8")]
		[Address(RVA = "0x1690ED8", Offset = "0x1690ED8", VA = "0x1690ED8")]
		internal void _003C_003Em__32E(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004715")]
	[FieldOffset(Offset = "0xC")]
	public XUIAchievementList m_achievement;

	[Token(Token = "0x4004716")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblNoAchievement;

	[Token(Token = "0x4004717")]
	[FieldOffset(Offset = "0x14")]
	public string soundKey;

	[Token(Token = "0x4004718")]
	[FieldOffset(Offset = "0x18")]
	private QuestGroup m_Type;

	[Token(Token = "0x4004719")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_ToggleTab[] m_Tabs;

	[Token(Token = "0x400471A")]
	[FieldOffset(Offset = "0x20")]
	private QuestGroup temp_group;

	[Token(Token = "0x60064B1")]
	[Address(RVA = "0x168FC98", Offset = "0x168FC98", VA = "0x168FC98")]
	public XPanel_Achievement()
	{
	}

	[Token(Token = "0x60064B2")]
	[Address(RVA = "0x168FD2C", Offset = "0x168FD2C", VA = "0x168FD2C")]
	public void Show()
	{
	}

	[Token(Token = "0x60064B3")]
	[Address(RVA = "0x168FD6C", Offset = "0x168FD6C", VA = "0x168FD6C")]
	public void Build()
	{
	}

	[Token(Token = "0x60064B4")]
	[Address(RVA = "0x168FDB8", Offset = "0x168FDB8", VA = "0x168FDB8")]
	public void Hide()
	{
	}

	[Token(Token = "0x60064B5")]
	[Address(RVA = "0x168FEB0", Offset = "0x168FEB0", VA = "0x168FEB0")]
	public bool ActiveState()
	{
		return default(bool);
	}

	[Token(Token = "0x60064B6")]
	[Address(RVA = "0x168FEE0", Offset = "0x168FEE0", VA = "0x168FEE0")]
	public void AchieveComplete(XUIAchievementItem achieveItem)
	{
	}

	[Token(Token = "0x60064B7")]
	[Address(RVA = "0x1690190", Offset = "0x1690190", VA = "0x1690190")]
	public void SetListBuild(XUIAchievementItem achieveItem)
	{
	}

	[Token(Token = "0x60064B8")]
	[Address(RVA = "0x169030C", Offset = "0x169030C", VA = "0x169030C")]
	public void HideComplete()
	{
	}

	[Token(Token = "0x60064B9")]
	[Address(RVA = "0x1690440", Offset = "0x1690440", VA = "0x1690440")]
	public void NoticeType(QuestGroup group)
	{
	}

	[Token(Token = "0x60064BA")]
	[Address(RVA = "0x168FDB0", Offset = "0x168FDB0", VA = "0x168FDB0")]
	public void BuildList()
	{
	}

	[Token(Token = "0x60064BB")]
	[Address(RVA = "0x16904C4", Offset = "0x16904C4", VA = "0x16904C4")]
	public void ShowGrowthList()
	{
	}

	[Token(Token = "0x60064BC")]
	[Address(RVA = "0x16904CC", Offset = "0x16904CC", VA = "0x16904CC")]
	public void ShowBattleList()
	{
	}

	[Token(Token = "0x60064BD")]
	[Address(RVA = "0x16904D4", Offset = "0x16904D4", VA = "0x16904D4")]
	public void ShowEquipmentList()
	{
	}

	[Token(Token = "0x60064BE")]
	[Address(RVA = "0x16904DC", Offset = "0x16904DC", VA = "0x16904DC")]
	public void ShowSocialList()
	{
	}

	[Token(Token = "0x60064BF")]
	[Address(RVA = "0x1690448", Offset = "0x1690448", VA = "0x1690448")]
	private void BuildTabList(QuestGroup type)
	{
	}

	[Token(Token = "0x60064C0")]
	[Address(RVA = "0x16904E4", Offset = "0x16904E4", VA = "0x16904E4")]
	private void SetNoAchievementLabel()
	{
	}

	[Token(Token = "0x60064C1")]
	[Address(RVA = "0x1690644", Offset = "0x1690644", VA = "0x1690644")]
	public void InitTabsBadge()
	{
	}

	[Token(Token = "0x60064C2")]
	[Address(RVA = "0x1690828", Offset = "0x1690828", VA = "0x1690828")]
	public void SetTabsBadge(int tabs)
	{
	}

	[Token(Token = "0x60064C3")]
	[Address(RVA = "0x16909AC", Offset = "0x16909AC", VA = "0x16909AC")]
	public void RefreshCheckListBadge()
	{
	}

	[Token(Token = "0x60064C4")]
	[Address(RVA = "0x1690B48", Offset = "0x1690B48", VA = "0x1690B48")]
	private QuestGroup CheckListGruop(int id)
	{
		return default(QuestGroup);
	}

	[Token(Token = "0x60064C5")]
	[Address(RVA = "0x1690D2C", Offset = "0x1690D2C", VA = "0x1690D2C")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x60064C6")]
	[Address(RVA = "0x1690E00", Offset = "0x1690E00", VA = "0x1690E00")]
	public void OnClick_Help()
	{
	}
}
