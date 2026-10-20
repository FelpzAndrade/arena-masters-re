using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F6A")]
public class XWidget_BoxDirection : MonoBehaviour
{
	[Token(Token = "0x2000F6B")]
	private sealed class _003CShow_BoxDirection_003Ec__AnonStorey236
	{
		[Token(Token = "0x4005132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<CSContent> contents;

		[Token(Token = "0x4005133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_BoxDirection _003C_003Ef__this;

		[Token(Token = "0x60072B8")]
		[Address(RVA = "0x15BEB2C", Offset = "0x15BEB2C", VA = "0x15BEB2C")]
		public _003CShow_BoxDirection_003Ec__AnonStorey236()
		{
		}
	}

	[Token(Token = "0x2000F6C")]
	private sealed class _003CShow_BoxDirection_003Ec__AnonStorey235
	{
		[Token(Token = "0x4005134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal CSContent content;

		[Token(Token = "0x4005135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int index;

		[Token(Token = "0x4005136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal _003CShow_BoxDirection_003Ec__AnonStorey236 _003C_003Ef__ref_0024566;

		[Token(Token = "0x4005137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XWidget_BoxDirection _003C_003Ef__this;

		[Token(Token = "0x60072B9")]
		[Address(RVA = "0x15BEBD4", Offset = "0x15BEBD4", VA = "0x15BEBD4")]
		public _003CShow_BoxDirection_003Ec__AnonStorey235()
		{
		}

		[Token(Token = "0x60072BA")]
		[Address(RVA = "0x15C0E44", Offset = "0x15C0E44", VA = "0x15C0E44")]
		internal void _003C_003Em__49A()
		{
		}

		[Token(Token = "0x60072BB")]
		[Address(RVA = "0x15C0EBC", Offset = "0x15C0EBC", VA = "0x15C0EBC")]
		internal void _003C_003Em__49B()
		{
		}

		[Token(Token = "0x60072BC")]
		[Address(RVA = "0x15C0EE4", Offset = "0x15C0EE4", VA = "0x15C0EE4")]
		internal void _003C_003Em__49C()
		{
		}

		[Token(Token = "0x60072BD")]
		[Address(RVA = "0x15C0F0C", Offset = "0x15C0F0C", VA = "0x15C0F0C")]
		internal void _003C_003Em__49D()
		{
		}

		[Token(Token = "0x60072BE")]
		[Address(RVA = "0x15C1074", Offset = "0x15C1074", VA = "0x15C1074")]
		internal void _003C_003Em__49E()
		{
		}

		[Token(Token = "0x60072BF")]
		[Address(RVA = "0x15C109C", Offset = "0x15C109C", VA = "0x15C109C")]
		internal void _003C_003Em__49F()
		{
		}
	}

	[Token(Token = "0x4005112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UIGrid noticeMessagGridBtns;

	[Token(Token = "0x4005113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XWidget_Button confirmButton;

	[Token(Token = "0x4005114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UITexture boxDirectionRenderTexture;

	[Token(Token = "0x4005115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_GachaCardItem gachaItem;

	[Token(Token = "0x4005116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float openBoxEffectDelay;

	[Token(Token = "0x4005117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float firstOpenBoxEffectDelay;

	[Token(Token = "0x4005118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float totalMoveCardTime;

	[Token(Token = "0x4005119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float intervalMoveCardTime;

	[Token(Token = "0x400511A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public string openAnimationName;

	[Token(Token = "0x400511B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cardNumberObject;

	[Token(Token = "0x400511C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GameObject goldObj;

	[Token(Token = "0x400511D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject itemObj;

	[Token(Token = "0x400511E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UILabel notifyMessageObject;

	[Token(Token = "0x400511F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblRemainCardCount;

	[Token(Token = "0x4005120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UILabel lblToMail;

	[Token(Token = "0x4005121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblArenaCoinInsteadOf;

	[Token(Token = "0x4005122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UILabel lblGoldBonusInsteadOf;

	[Token(Token = "0x4005123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UILabel lblItemExpTotal;

	[Token(Token = "0x4005124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UILabel lblItemLevel;

	[Token(Token = "0x4005125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public XWidget_TweenCost goldTweenCost;

	[Token(Token = "0x4005126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public XWidget_TweenProgressBar itemTweenProgressBar;

	[Token(Token = "0x4005127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int acquireSkinArenaCoin;

	[Token(Token = "0x4005128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int m_restoreGoldCount;

	[Token(Token = "0x4005129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private UIDirector m_direction;

	[Token(Token = "0x400512A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private XPanel_GachaCardDirectionCamera panel_GachaCardDirectionCamera;

	[Token(Token = "0x400512B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 miniGachaBoxPosition;

	[Token(Token = "0x400512C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x400512D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action m_endAction;

	[Token(Token = "0x400512E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool m_toMail;

	[Token(Token = "0x400512F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private XUIGachaItem _gachaItem;

	[Token(Token = "0x4005130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private XWidget_GachaEffect _gachaEffect;

	[Token(Token = "0x4005131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private DelayDirectionElement m_directionDelay;

	[Token(Token = "0x17000E9D")]
	public XUIGachaItem GachaItem
	{
		[Token(Token = "0x6007289")]
		[Address(RVA = "0x15BD3A0", Offset = "0x15BD3A0", VA = "0x15BD3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9E")]
	public XWidget_GachaEffect GachaEffect
	{
		[Token(Token = "0x600728A")]
		[Address(RVA = "0x15BD4A4", Offset = "0x15BD4A4", VA = "0x15BD4A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007288")]
	[Address(RVA = "0x15BD2AC", Offset = "0x15BD2AC", VA = "0x15BD2AC")]
	public XWidget_BoxDirection()
	{
	}

	[Token(Token = "0x600728B")]
	[Address(RVA = "0x15BD7A4", Offset = "0x15BD7A4", VA = "0x15BD7A4")]
	private void SetLabelInsteadof(string keyString, ref UILabel lblInsteadOf, int count)
	{
	}

	[Token(Token = "0x600728C")]
	[Address(RVA = "0x15BD980", Offset = "0x15BD980", VA = "0x15BD980")]
	private void SetActiveArenaCoinInsteadOf(bool bActive)
	{
	}

	[Token(Token = "0x600728D")]
	[Address(RVA = "0x15BDA54", Offset = "0x15BDA54", VA = "0x15BDA54")]
	private void SetSkinTreasureLabel(bool bActive)
	{
	}

	[Token(Token = "0x600728E")]
	[Address(RVA = "0x15BDBE4", Offset = "0x15BDBE4", VA = "0x15BDBE4")]
	private void SetActiveGoldBonusInsteadOf(bool bActive, int goldBonus = 0)
	{
	}

	[Token(Token = "0x600728F")]
	[Address(RVA = "0x15BDCBC", Offset = "0x15BDCBC", VA = "0x15BDCBC")]
	private void SetRenderTextureCamera()
	{
	}

	[Token(Token = "0x6007290")]
	[Address(RVA = "0x15BDDA4", Offset = "0x15BDDA4", VA = "0x15BDDA4")]
	private void OnCardDirecting()
	{
	}

	[Token(Token = "0x6007291")]
	[Address(RVA = "0x15BDF08", Offset = "0x15BDF08", VA = "0x15BDF08")]
	private void ShowMailNotification(bool isShow)
	{
	}

	[Token(Token = "0x6007292")]
	[Address(RVA = "0x15BDFF8", Offset = "0x15BDFF8", VA = "0x15BDFF8")]
	public void Build(List<CSContent> contents, int restoreGoldCount, [Optional][DefaultParameterValue(false)] bool toMail, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x6007293")]
	[Address(RVA = "0x15BE8C0", Offset = "0x15BE8C0", VA = "0x15BE8C0")]
	private void RepositionGacha(Vector3 miniGachaBoxPosition)
	{
	}

	[Token(Token = "0x6007294")]
	[Address(RVA = "0x15BE910", Offset = "0x15BE910", VA = "0x15BE910")]
	public void PlayFirstOpenEffect()
	{
	}

	[Token(Token = "0x6007295")]
	[Address(RVA = "0x15BE97C", Offset = "0x15BE97C", VA = "0x15BE97C")]
	private void PlayNext()
	{
	}

	[Token(Token = "0x6007296")]
	[Address(RVA = "0x15BE9B4", Offset = "0x15BE9B4", VA = "0x15BE9B4")]
	public void PlaySoundDelayed()
	{
	}

	[Token(Token = "0x6007297")]
	[Address(RVA = "0x15BEA44", Offset = "0x15BEA44", VA = "0x15BEA44")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6007298")]
	[Address(RVA = "0x15BE0A0", Offset = "0x15BE0A0", VA = "0x15BE0A0")]
	public void Show_BoxDirection(List<CSContent> contents)
	{
	}

	[Token(Token = "0x6007299")]
	[Address(RVA = "0x15BEB34", Offset = "0x15BEB34", VA = "0x15BEB34")]
	private void HideObjs()
	{
	}

	[Token(Token = "0x600729A")]
	[Address(RVA = "0x15BEBDC", Offset = "0x15BEBDC", VA = "0x15BEBDC")]
	private int OverlapHaveSkin(CSContent content)
	{
		return default(int);
	}

	[Token(Token = "0x600729B")]
	[Address(RVA = "0x15BEC2C", Offset = "0x15BEC2C", VA = "0x15BEC2C")]
	private bool CheckHaveSkinAndShowSkinDirection(XWidget_GachaCardItem card, bool alreadySkinGetDirection)
	{
		return default(bool);
	}

	[Token(Token = "0x600729C")]
	[Address(RVA = "0x15BEED8", Offset = "0x15BEED8", VA = "0x15BEED8")]
	private bool CheckGetSkinFromCardsAndEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x600729D")]
	[Address(RVA = "0x15BF044", Offset = "0x15BF044", VA = "0x15BF044")]
	private int GetProfileOverlapBonusGold()
	{
		return default(int);
	}

	[Token(Token = "0x600729E")]
	[Address(RVA = "0x15BF1B0", Offset = "0x15BF1B0", VA = "0x15BF1B0")]
	private void CheckProfileIconOverlap()
	{
	}

	[Token(Token = "0x600729F")]
	[Address(RVA = "0x15BF1DC", Offset = "0x15BF1DC", VA = "0x15BF1DC")]
	private void CheckSkinTreasureForNJ()
	{
	}

	[Token(Token = "0x60072A0")]
	[Address(RVA = "0x15BF318", Offset = "0x15BF318", VA = "0x15BF318")]
	private void RunTweenCost(XWidget_TweenCost tweenCost, int addGoldCount)
	{
	}

	[Token(Token = "0x60072A1")]
	[Address(RVA = "0x15BF370", Offset = "0x15BF370", VA = "0x15BF370")]
	private void RunTweenProgressBar(XWidget_TweenProgressBar tweenProgressBar, int restoreCount, int addItemCount, int maxCost)
	{
	}

	[Token(Token = "0x60072A2")]
	[Address(RVA = "0x15BF3C4", Offset = "0x15BF3C4", VA = "0x15BF3C4")]
	private void CheckItemAndGold()
	{
	}

	[Token(Token = "0x60072A3")]
	[Address(RVA = "0x15BF4D8", Offset = "0x15BF4D8", VA = "0x15BF4D8")]
	private void AddRestoreItemCount(CSContent content)
	{
	}

	[Token(Token = "0x60072A4")]
	[Address(RVA = "0x15BFC5C", Offset = "0x15BFC5C", VA = "0x15BFC5C")]
	private int GetCharSoulStoneCount(int charID)
	{
		return default(int);
	}

	[Token(Token = "0x60072A5")]
	[Address(RVA = "0x15BFD38", Offset = "0x15BFD38", VA = "0x15BFD38")]
	private int GetCharSoulStoneRequireCount(XModuleActor characterActor, int charLevel)
	{
		return default(int);
	}

	[Token(Token = "0x60072A6")]
	[Address(RVA = "0x15BFEC4", Offset = "0x15BFEC4", VA = "0x15BFEC4")]
	private bool IsOwnedCharacter(string charUID)
	{
		return default(bool);
	}

	[Token(Token = "0x60072A7")]
	[Address(RVA = "0x15BFF88", Offset = "0x15BFF88", VA = "0x15BFF88")]
	private XModuleActor GetCharacterInfo(int charID)
	{
		return null;
	}

	[Token(Token = "0x60072A8")]
	[Address(RVA = "0x15C00FC", Offset = "0x15C00FC", VA = "0x15C00FC")]
	private void SetActiveShowItemObj(int currentLevel, int maxLevel)
	{
	}

	[Token(Token = "0x60072A9")]
	[Address(RVA = "0x15BF670", Offset = "0x15BF670", VA = "0x15BF670")]
	private void AddRestoreSoulStone(CSContent content)
	{
	}

	[Token(Token = "0x60072AA")]
	[Address(RVA = "0x15BF9E4", Offset = "0x15BF9E4", VA = "0x15BF9E4")]
	private void AddRelicPiece(CSContent content)
	{
	}

	[Token(Token = "0x60072AB")]
	[Address(RVA = "0x15C0134", Offset = "0x15C0134", VA = "0x15C0134")]
	private int GetRelicID(int relicPieceID)
	{
		return default(int);
	}

	[Token(Token = "0x60072AC")]
	[Address(RVA = "0x15C023C", Offset = "0x15C023C", VA = "0x15C023C")]
	private int GetRelicLevel(int relicID)
	{
		return default(int);
	}

	[Token(Token = "0x60072AD")]
	[Address(RVA = "0x15C035C", Offset = "0x15C035C", VA = "0x15C035C")]
	private int GetRelicPieceCount(int relicPieceID)
	{
		return default(int);
	}

	[Token(Token = "0x60072AE")]
	[Address(RVA = "0x15C0438", Offset = "0x15C0438", VA = "0x15C0438")]
	private int GetRelicPieceTotalCount(int relicID, int relicLevel)
	{
		return default(int);
	}

	[Token(Token = "0x60072AF")]
	[Address(RVA = "0x15BF168", Offset = "0x15BF168", VA = "0x15BF168")]
	private void AddRestoreGoldCount(int addGoldCount)
	{
	}

	[Token(Token = "0x60072B0")]
	[Address(RVA = "0x15BEC90", Offset = "0x15BEC90", VA = "0x15BEC90")]
	public void ShowSkinChracterDirection(int itemId)
	{
	}

	[Token(Token = "0x60072B1")]
	[Address(RVA = "0x15C0558", Offset = "0x15C0558", VA = "0x15C0558")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x60072B2")]
	[Address(RVA = "0x15C05B0", Offset = "0x15C05B0", VA = "0x15C05B0")]
	public string GetRemainCountString(int remainCount)
	{
		return null;
	}

	[Token(Token = "0x60072B3")]
	[Address(RVA = "0x15C06F8", Offset = "0x15C06F8", VA = "0x15C06F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60072B4")]
	[Address(RVA = "0x15C0724", Offset = "0x15C0724", VA = "0x15C0724")]
	public void End()
	{
	}

	[Token(Token = "0x60072B5")]
	[Address(RVA = "0x15C0A3C", Offset = "0x15C0A3C", VA = "0x15C0A3C")]
	public void EnableNextCardTouch()
	{
	}

	[Token(Token = "0x60072B6")]
	[Address(RVA = "0x15C092C", Offset = "0x15C092C", VA = "0x15C092C")]
	public void Hide()
	{
	}

	[Token(Token = "0x60072B7")]
	[Address(RVA = "0x15C0CE0", Offset = "0x15C0CE0", VA = "0x15C0CE0")]
	private void OnDisable()
	{
	}
}
