using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C81")]
public class XWidget_GachaItemCardDirection : MonoBehaviour
{
	[Token(Token = "0x2000C82")]
	public enum ClassType
	{
		[Token(Token = "0x4003FB4")]
		XPanel_BuyConfirm = 0,
		[Token(Token = "0x4003FB5")]
		XPanel_ContentList = 1,
		[Token(Token = "0x4003FB6")]
		XPanel_RewardBox = 2
	}

	[Token(Token = "0x2000C83")]
	private sealed class _003CReadyBoxAndCardDirection_003Ec__AnonStorey182
	{
		[Token(Token = "0x4003FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<CSContent> contents;

		[Token(Token = "0x4003FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_GachaItemCardDirection _003C_003Ef__this;

		[Token(Token = "0x6005A80")]
		[Address(RVA = "0x1439B14", Offset = "0x1439B14", VA = "0x1439B14")]
		public _003CReadyBoxAndCardDirection_003Ec__AnonStorey182()
		{
		}

		[Token(Token = "0x6005A81")]
		[Address(RVA = "0x143D01C", Offset = "0x143D01C", VA = "0x143D01C")]
		internal void _003C_003Em__25E()
		{
		}
	}

	[Token(Token = "0x2000C84")]
	private sealed class _003CRunBoxDirection_003Ec__AnonStorey183
	{
		[Token(Token = "0x4003FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<CSContent> contents;

		[Token(Token = "0x4003FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_GachaItemCardDirection _003C_003Ef__this;

		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x1439D44", Offset = "0x1439D44", VA = "0x1439D44")]
		public _003CRunBoxDirection_003Ec__AnonStorey183()
		{
		}

		[Token(Token = "0x6005A83")]
		[Address(RVA = "0x143D04C", Offset = "0x143D04C", VA = "0x143D04C")]
		internal void _003C_003Em__25F()
		{
		}
	}

	[Token(Token = "0x2000C85")]
	private sealed class _003CShow_CardsDirection_003Ec__AnonStorey184
	{
		[Token(Token = "0x4003FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<CSContent> contents;

		[Token(Token = "0x4003FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_GachaItemCardDirection _003C_003Ef__this;

		[Token(Token = "0x6005A84")]
		[Address(RVA = "0x143A07C", Offset = "0x143A07C", VA = "0x143A07C")]
		public _003CShow_CardsDirection_003Ec__AnonStorey184()
		{
		}

		[Token(Token = "0x6005A85")]
		[Address(RVA = "0x143D114", Offset = "0x143D114", VA = "0x143D114")]
		internal void _003C_003Em__260()
		{
		}

		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x143D2B8", Offset = "0x143D2B8", VA = "0x143D2B8")]
		internal void _003C_003Em__261()
		{
		}

		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x143D454", Offset = "0x143D454", VA = "0x143D454")]
		internal void _003C_003Em__262()
		{
		}
	}

	[Token(Token = "0x4003F84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ClassType classType;

	[Token(Token = "0x4003F85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridContents;

	[Token(Token = "0x4003F86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XWidget_GachaCardBox m_singleContentIcon;

	[Token(Token = "0x4003F87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIGrid gridBtns;

	[Token(Token = "0x4003F88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIGrid noticeMessagGridBtns;

	[Token(Token = "0x4003F89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XWidget_Button confirmButton;

	[Token(Token = "0x4003F8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UITexture boxDirectionRenderTexture;

	[Token(Token = "0x4003F8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float openBoxEffectDelay;

	[Token(Token = "0x4003F8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float firstOpenBoxEffectDelay;

	[Token(Token = "0x4003F8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float totalMoveCardTime;

	[Token(Token = "0x4003F8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float intervalMoveCardTime;

	[Token(Token = "0x4003F8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float effectMultiDurationDelayForSound;

	[Token(Token = "0x4003F90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public string openAnimationName;

	[Token(Token = "0x4003F91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject rootGameObject;

	[Token(Token = "0x4003F92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public GameObject cardNumberObject;

	[Token(Token = "0x4003F93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject goldObj;

	[Token(Token = "0x4003F94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GameObject itemObj;

	[Token(Token = "0x4003F95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UILabel notifyMessageObject;

	[Token(Token = "0x4003F96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UILabel lblRemainCardCount;

	[Token(Token = "0x4003F97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UILabel lblToMail;

	[Token(Token = "0x4003F98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public UILabel lblArenaCoinInsteadOf;

	[Token(Token = "0x4003F99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UILabel lblGoldBonusInsteadOf;

	[Token(Token = "0x4003F9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public UILabel lblDimensionSoulStoneBonusInsteadOf;

	[Token(Token = "0x4003F9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public UILabel lblCharToSoul;

	[Token(Token = "0x4003F9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public UILabel lblPetToDust;

	[Token(Token = "0x4003F9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UILabel lblGold;

	[Token(Token = "0x4003F9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public UILabel lblItemExpTotal;

	[Token(Token = "0x4003F9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public UILabel lblItemLevel;

	[Token(Token = "0x4003FA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public XWidget_TweenCost goldTweenCost;

	[Token(Token = "0x4003FA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public XWidget_TweenProgressBar itemTweenProgressBar;

	[Token(Token = "0x4003FA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int m_showCardCount;

	[Token(Token = "0x4003FA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int m_curDirectionIndex;

	[Token(Token = "0x4003FA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int m_maxDirectionCount;

	[Token(Token = "0x4003FA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int acquireSkinArenaCoin;

	[Token(Token = "0x4003FA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int m_restoreGoldCount;

	[Token(Token = "0x4003FA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Dictionary<int, int> m_restoreSouleStoneCount;

	[Token(Token = "0x4003FA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private UIDirector m_direction;

	[Token(Token = "0x4003FA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private XPanel_GachaCardDirectionCamera panel_GachaCardDirectionCamera;

	[Token(Token = "0x4003FAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private XWidget_GachaCardItem[] m_contentIcons;

	[Token(Token = "0x4003FAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float cellWidth;

	[Token(Token = "0x4003FAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float intervalWidth;

	[Token(Token = "0x4003FAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 miniGachaBoxPosition;

	[Token(Token = "0x4003FAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private List<CSContent> m_contents;

	[Token(Token = "0x4003FAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<CSContent> m_originContents;

	[Token(Token = "0x4003FB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x4003FB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private XPanel_PetDirectionRoot petDirectionRoot;

	[Token(Token = "0x4003FB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Action m_endAction;

	[Token(Token = "0x6005A46")]
	[Address(RVA = "0x1438050", Offset = "0x1438050", VA = "0x1438050")]
	public XWidget_GachaItemCardDirection()
	{
	}

	[Token(Token = "0x6005A47")]
	[Address(RVA = "0x143819C", Offset = "0x143819C", VA = "0x143819C")]
	private void SetLabelInsteadof(string keyString, ref UILabel lblInsteadOf, int count)
	{
	}

	[Token(Token = "0x6005A48")]
	[Address(RVA = "0x1438378", Offset = "0x1438378", VA = "0x1438378")]
	private void SetActiveArenaCoinInsteadOf(bool bActive)
	{
	}

	[Token(Token = "0x6005A49")]
	[Address(RVA = "0x143844C", Offset = "0x143844C", VA = "0x143844C")]
	private void SetSkinTreasureLabel(bool bActive)
	{
	}

	[Token(Token = "0x6005A4A")]
	[Address(RVA = "0x14385DC", Offset = "0x14385DC", VA = "0x14385DC")]
	private void SetActiveGoldBonusInsteadOf(bool bActive, int goldBonus = 0)
	{
	}

	[Token(Token = "0x6005A4B")]
	[Address(RVA = "0x14386B4", Offset = "0x14386B4", VA = "0x14386B4")]
	private void SetActiveDimensionSoulStoneBonusInsteadOf(bool bActive)
	{
	}

	[Token(Token = "0x6005A4C")]
	[Address(RVA = "0x1438794", Offset = "0x1438794", VA = "0x1438794")]
	private void SetActiveLabelCharToSoul(bool bActive)
	{
	}

	[Token(Token = "0x6005A4D")]
	[Address(RVA = "0x14388CC", Offset = "0x14388CC", VA = "0x14388CC")]
	private void SetActiveLabelPetToDust(bool bActive)
	{
	}

	[Token(Token = "0x6005A4E")]
	[Address(RVA = "0x1438B08", Offset = "0x1438B08", VA = "0x1438B08")]
	private void SetRenderTextureCamera()
	{
	}

	[Token(Token = "0x6005A4F")]
	[Address(RVA = "0x1438BF0", Offset = "0x1438BF0", VA = "0x1438BF0")]
	private void OnCardDirecting()
	{
	}

	[Token(Token = "0x6005A50")]
	[Address(RVA = "0x1438D54", Offset = "0x1438D54", VA = "0x1438D54")]
	private void GachaBoxDirectionStart()
	{
	}

	[Token(Token = "0x6005A51")]
	[Address(RVA = "0x1438D90", Offset = "0x1438D90", VA = "0x1438D90")]
	private int GetDirectionLoopCount(int cycleCount, ref List<CSContent> contents)
	{
		return default(int);
	}

	[Token(Token = "0x6005A52")]
	[Address(RVA = "0x1438E50", Offset = "0x1438E50", VA = "0x1438E50")]
	private void SetGridUIAndButton()
	{
	}

	[Token(Token = "0x6005A53")]
	[Address(RVA = "0x1438FD0", Offset = "0x1438FD0", VA = "0x1438FD0")]
	public void ShowMailNotification(bool isShow)
	{
	}

	[Token(Token = "0x6005A54")]
	[Address(RVA = "0x14390C0", Offset = "0x14390C0", VA = "0x14390C0")]
	private bool IsChangeCharToSoul(int rewardIndex, int showCount)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A55")]
	[Address(RVA = "0x1439240", Offset = "0x1439240", VA = "0x1439240")]
	private void DisableInsteadOfLabels()
	{
	}

	[Token(Token = "0x6005A56")]
	[Address(RVA = "0x143928C", Offset = "0x143928C", VA = "0x143928C")]
	public void Build(List<CSContent> contents, int cycleCount, int restoreGoldCount, List<CSContent> originContents, [Optional][DefaultParameterValue(false)] bool rebuy, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x6005A57")]
	[Address(RVA = "0x1439898", Offset = "0x1439898", VA = "0x1439898")]
	private void SetCardNumberObject()
	{
	}

	[Token(Token = "0x6005A58")]
	[Address(RVA = "0x1439930", Offset = "0x1439930", VA = "0x1439930")]
	private bool IsLoopDirection()
	{
		return default(bool);
	}

	[Token(Token = "0x6005A59")]
	[Address(RVA = "0x1439944", Offset = "0x1439944", VA = "0x1439944")]
	private void ReadyBoxAndCardDirection(List<CSContent> contents, float boxOpenDelayTime, bool isFirst)
	{
	}

	[Token(Token = "0x6005A5A")]
	[Address(RVA = "0x1439B1C", Offset = "0x1439B1C", VA = "0x1439B1C")]
	private void RunBoxDirection(List<CSContent> contents)
	{
	}

	[Token(Token = "0x6005A5B")]
	[Address(RVA = "0x1439700", Offset = "0x1439700", VA = "0x1439700")]
	public void Show_BoxDirection(List<CSContent> contents)
	{
	}

	[Token(Token = "0x6005A5C")]
	[Address(RVA = "0x1439DB4", Offset = "0x1439DB4", VA = "0x1439DB4")]
	public void Show_CardsDirection(List<CSContent> contents)
	{
	}

	[Token(Token = "0x6005A5D")]
	[Address(RVA = "0x143A084", Offset = "0x143A084", VA = "0x143A084")]
	private int OverlapHaveSkin(CSContent content)
	{
		return default(int);
	}

	[Token(Token = "0x6005A5E")]
	[Address(RVA = "0x143A0D4", Offset = "0x143A0D4", VA = "0x143A0D4")]
	private bool CheckHaveSkinAndShowSkinDirection(XWidget_GachaCardItem card, bool alreadySkinGetDirection)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A5F")]
	[Address(RVA = "0x143A5E8", Offset = "0x143A5E8", VA = "0x143A5E8")]
	private bool CheckCharacter()
	{
		return default(bool);
	}

	[Token(Token = "0x6005A60")]
	[Address(RVA = "0x143AB50", Offset = "0x143AB50", VA = "0x143AB50")]
	private void CheckItemAndGold()
	{
	}

	[Token(Token = "0x6005A61")]
	[Address(RVA = "0x143AF90", Offset = "0x143AF90", VA = "0x143AF90")]
	private bool CheckGetSkinFromCardsAndEnd(out bool isOverlapSkin)
	{
		isOverlapSkin = default;
		return default(bool);
	}

	[Token(Token = "0x6005A62")]
	[Address(RVA = "0x143B110", Offset = "0x143B110", VA = "0x143B110")]
	private bool CheckAndShowCharacterDirectionForCharToSoul()
	{
		return default(bool);
	}

	[Token(Token = "0x6005A63")]
	[Address(RVA = "0x143B198", Offset = "0x143B198", VA = "0x143B198")]
	private int GetProfileOverlapBonusGold()
	{
		return default(int);
	}

	[Token(Token = "0x6005A64")]
	[Address(RVA = "0x143B2E4", Offset = "0x143B2E4", VA = "0x143B2E4")]
	private void CheckProfileIconOverlap()
	{
	}

	[Token(Token = "0x6005A65")]
	[Address(RVA = "0x143B324", Offset = "0x143B324", VA = "0x143B324")]
	private void CheckSkinTreasureForNJ()
	{
	}

	[Token(Token = "0x6005A66")]
	[Address(RVA = "0x143B48C", Offset = "0x143B48C", VA = "0x143B48C")]
	private void RunTweenCost(XWidget_TweenCost tweenCost, int addGoldCount)
	{
	}

	[Token(Token = "0x6005A67")]
	[Address(RVA = "0x143B4E4", Offset = "0x143B4E4", VA = "0x143B4E4")]
	private void RunTweenProgressBar(XWidget_TweenProgressBar tweenProgressBar, int restoreCount, int addItemCount, int maxCost)
	{
	}

	[Token(Token = "0x6005A68")]
	[Address(RVA = "0x143ACD8", Offset = "0x143ACD8", VA = "0x143ACD8")]
	private void AddRestoreItemCount(CSContent content)
	{
	}

	[Token(Token = "0x6005A69")]
	[Address(RVA = "0x143BBCC", Offset = "0x143BBCC", VA = "0x143BBCC")]
	private int GetCharSoulStoneCount(int charID)
	{
		return default(int);
	}

	[Token(Token = "0x6005A6A")]
	[Address(RVA = "0x143BCA8", Offset = "0x143BCA8", VA = "0x143BCA8")]
	private int GetCharSoulStoneRequireCount(XModuleActor characterActor, int charLevel)
	{
		return default(int);
	}

	[Token(Token = "0x6005A6B")]
	[Address(RVA = "0x143BE34", Offset = "0x143BE34", VA = "0x143BE34")]
	private bool IsOwnedCharacter(string charUID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A6C")]
	[Address(RVA = "0x143BEF8", Offset = "0x143BEF8", VA = "0x143BEF8")]
	private XModuleActor GetCharacterInfo(int charID)
	{
		return null;
	}

	[Token(Token = "0x6005A6D")]
	[Address(RVA = "0x143C06C", Offset = "0x143C06C", VA = "0x143C06C")]
	private void SetActiveShowItemObj(int currentLevel, int maxLevel)
	{
	}

	[Token(Token = "0x6005A6E")]
	[Address(RVA = "0x14393CC", Offset = "0x14393CC", VA = "0x14393CC")]
	private void SetPrevSouleStoneCount(List<CSContent> contents)
	{
	}

	[Token(Token = "0x6005A6F")]
	[Address(RVA = "0x143B538", Offset = "0x143B538", VA = "0x143B538")]
	private void AddRestoreSoulStone(CSContent content)
	{
	}

	[Token(Token = "0x6005A70")]
	[Address(RVA = "0x143B954", Offset = "0x143B954", VA = "0x143B954")]
	private void AddRelicPiece(CSContent content)
	{
	}

	[Token(Token = "0x6005A71")]
	[Address(RVA = "0x143C0A4", Offset = "0x143C0A4", VA = "0x143C0A4")]
	private int GetRelicID(int relicPieceID)
	{
		return default(int);
	}

	[Token(Token = "0x6005A72")]
	[Address(RVA = "0x143C1AC", Offset = "0x143C1AC", VA = "0x143C1AC")]
	private int GetRelicLevel(int relicID)
	{
		return default(int);
	}

	[Token(Token = "0x6005A73")]
	[Address(RVA = "0x143C2CC", Offset = "0x143C2CC", VA = "0x143C2CC")]
	private int GetRelicPieceCount(int relicPieceID)
	{
		return default(int);
	}

	[Token(Token = "0x6005A74")]
	[Address(RVA = "0x143C3A8", Offset = "0x143C3A8", VA = "0x143C3A8")]
	private int GetRelicPieceTotalCount(int relicID, int relicLevel)
	{
		return default(int);
	}

	[Token(Token = "0x6005A75")]
	[Address(RVA = "0x143AC90", Offset = "0x143AC90", VA = "0x143AC90")]
	private void AddRestoreGoldCount(int addGoldCount)
	{
	}

	[Token(Token = "0x6005A76")]
	[Address(RVA = "0x1439D4C", Offset = "0x1439D4C", VA = "0x1439D4C")]
	private void DeActiveCards()
	{
	}

	[Token(Token = "0x6005A77")]
	[Address(RVA = "0x143A238", Offset = "0x143A238", VA = "0x143A238")]
	public void ShowChracterDirection(int charID, int skinID)
	{
	}

	[Token(Token = "0x6005A78")]
	[Address(RVA = "0x143C4C8", Offset = "0x143C4C8", VA = "0x143C4C8")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6005A79")]
	[Address(RVA = "0x143C62C", Offset = "0x143C62C", VA = "0x143C62C")]
	public string GetRemainCountString()
	{
		return null;
	}

	[Token(Token = "0x6005A7A")]
	[Address(RVA = "0x143C780", Offset = "0x143C780", VA = "0x143C780")]
	private void Update()
	{
	}

	[Token(Token = "0x6005A7B")]
	[Address(RVA = "0x1439918", Offset = "0x1439918", VA = "0x1439918")]
	private bool IsEndDirection()
	{
		return default(bool);
	}

	[Token(Token = "0x6005A7C")]
	[Address(RVA = "0x143C7AC", Offset = "0x143C7AC", VA = "0x143C7AC")]
	private void End()
	{
	}

	[Token(Token = "0x6005A7D")]
	[Address(RVA = "0x143CB68", Offset = "0x143CB68", VA = "0x143CB68")]
	public void EnableNextCardTouch()
	{
	}

	[Token(Token = "0x6005A7E")]
	[Address(RVA = "0x143CA60", Offset = "0x143CA60", VA = "0x143CA60")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005A7F")]
	[Address(RVA = "0x143CEB8", Offset = "0x143CEB8", VA = "0x143CEB8")]
	private void OnDisable()
	{
	}
}
