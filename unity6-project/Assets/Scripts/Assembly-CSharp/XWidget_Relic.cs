using System;
using System.Collections.Generic;
using CS;
using CS.Constant;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FD8")]
public class XWidget_Relic : XUIBaseWidget
{
	[Token(Token = "0x2000FD9")]
	private sealed class _003CSetItemQuickSlot_003Ec__AnonStorey249
	{
		[Token(Token = "0x4005492")]
		[FieldOffset(Offset = "0x8")]
		internal int relic_id;

		[Token(Token = "0x4005493")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_Relic _003C_003Ef__this;

		[Token(Token = "0x600764C")]
		[Address(RVA = "0x133E578", Offset = "0x133E578", VA = "0x133E578")]
		public _003CSetItemQuickSlot_003Ec__AnonStorey249()
		{
		}

		[Token(Token = "0x600764D")]
		[Address(RVA = "0x13418BC", Offset = "0x13418BC", VA = "0x13418BC")]
		internal void _003C_003Em__4DD(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000FDA")]
	private sealed class _003CSetRelicTutorialObject_003Ec__AnonStorey24A
	{
		[Token(Token = "0x4005494")]
		[FieldOffset(Offset = "0x8")]
		internal string relicTutoKey;

		[Token(Token = "0x4005495")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_Relic _003C_003Ef__this;

		[Token(Token = "0x600764E")]
		[Address(RVA = "0x1341478", Offset = "0x1341478", VA = "0x1341478")]
		public _003CSetRelicTutorialObject_003Ec__AnonStorey24A()
		{
		}

		[Token(Token = "0x600764F")]
		[Address(RVA = "0x1341A80", Offset = "0x1341A80", VA = "0x1341A80")]
		internal void _003C_003Em__4E2()
		{
		}
	}

	[Token(Token = "0x400545F")]
	private const int quickSlotItemCount = 4;

	[Token(Token = "0x4005460")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string Path_slotItem;

	[Token(Token = "0x4005461")]
	[FieldOffset(Offset = "0x1C")]
	public Transform quickRoot;

	[Token(Token = "0x4005462")]
	[FieldOffset(Offset = "0x20")]
	private List<XUIRelicSlotItem> m_slotItem;

	[Token(Token = "0x4005463")]
	[FieldOffset(Offset = "0x24")]
	public XUIRelicList relicList;

	[Token(Token = "0x4005464")]
	[FieldOffset(Offset = "0x28")]
	private Action m_relicBadgeAction;

	[Token(Token = "0x4005465")]
	[FieldOffset(Offset = "0x2C")]
	private bool netdata_list;

	[Token(Token = "0x4005466")]
	[FieldOffset(Offset = "0x30")]
	public string UIRelicQuickSlotEquipSoundKey;

	[Token(Token = "0x4005467")]
	[FieldOffset(Offset = "0x34")]
	private List<RelicInfo> m_list;

	[Token(Token = "0x4005468")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_Button btnRelicOpen;

	[Token(Token = "0x4005469")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_Button btnRelicUpgrade;

	[Token(Token = "0x400546A")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_Button btnRelicSetSlot;

	[Token(Token = "0x400546B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject relicDetailButtons;

	[Token(Token = "0x400546C")]
	[FieldOffset(Offset = "0x48")]
	public UIPanel panelRelicItemClippedView;

	[Token(Token = "0x400546D")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblDailyRelicNotice;

	[Token(Token = "0x400546E")]
	[FieldOffset(Offset = "0x50")]
	public int quickSlotWidth;

	[Token(Token = "0x400546F")]
	[FieldOffset(Offset = "0x54")]
	public int listFirstOffsetY;

	[Token(Token = "0x4005470")]
	[FieldOffset(Offset = "0x58")]
	private RelicInfo selRelic;

	[Token(Token = "0x4005471")]
	[FieldOffset(Offset = "0x5C")]
	private XUIRelicItem m_selObject;

	[Token(Token = "0x4005472")]
	[FieldOffset(Offset = "0x60")]
	private int m_selIndex;

	[Token(Token = "0x4005473")]
	[FieldOffset(Offset = "0x64")]
	private bool m_setSlot;

	[Token(Token = "0x4005474")]
	[FieldOffset(Offset = "0x68")]
	public GameObject goSlotHighLight;

	[Token(Token = "0x4005475")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel lblSlotSetAndCancel;

	[Token(Token = "0x4005476")]
	[FieldOffset(Offset = "0x70")]
	public UI2DSprite sprDetailIcon;

	[Token(Token = "0x4005477")]
	[FieldOffset(Offset = "0x74")]
	public UILabel lblDetailName;

	[Token(Token = "0x4005478")]
	[FieldOffset(Offset = "0x78")]
	public UILabel lblDetailCoolTime;

	[Token(Token = "0x4005479")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel lblDetailSkillName;

	[Token(Token = "0x400547A")]
	[FieldOffset(Offset = "0x80")]
	public UILabel lblDetailSkillDesc;

	[Token(Token = "0x400547B")]
	[FieldOffset(Offset = "0x84")]
	public UILabel lblDetailNow;

	[Token(Token = "0x400547C")]
	[FieldOffset(Offset = "0x88")]
	public UILabel lblDetailNext;

	[Token(Token = "0x400547D")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel lblDetailLevel;

	[Token(Token = "0x400547E")]
	[FieldOffset(Offset = "0x90")]
	public UIScrollView nowScrollView;

	[Token(Token = "0x400547F")]
	[FieldOffset(Offset = "0x94")]
	public UIScrollView nextScrollView;

	[Token(Token = "0x4005480")]
	[FieldOffset(Offset = "0x98")]
	public UIButton btnUnlock;

	[Token(Token = "0x4005481")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton btnUpgrade;

	[Token(Token = "0x4005482")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton btnSetSlot;

	[Token(Token = "0x4005483")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel lblUpgradePrice;

	[Token(Token = "0x4005484")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel lblMax;

	[Token(Token = "0x4005485")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject sprPhysic;

	[Token(Token = "0x4005486")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject sprMagic;

	[Token(Token = "0x4005487")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel lblType;

	[Token(Token = "0x4005488")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel lblDetailRelicDesc;

	[Token(Token = "0x4005489")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject goEffect;

	[Token(Token = "0x400548A")]
	[FieldOffset(Offset = "0xC0")]
	private bool selectState;

	[Token(Token = "0x400548B")]
	[FieldOffset(Offset = "0xC4")]
	private XMakeDescription skillDesc;

	[Token(Token = "0x400548C")]
	[FieldOffset(Offset = "0xC8")]
	private int change_slot_index;

	[Token(Token = "0x400548D")]
	[FieldOffset(Offset = "0xCC")]
	private bool change_slot_state;

	[Token(Token = "0x400548E")]
	[FieldOffset(Offset = "0xD0")]
	public string effectSoundKey;

	[Token(Token = "0x400548F")]
	[FieldOffset(Offset = "0xD4")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x4005490")]
	[FieldOffset(Offset = "0x4")]
	private static Func<RelicInfo, ItemRarity> _003C_003Ef__am_0024cache30;

	[Token(Token = "0x4005491")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache31;

	[Token(Token = "0x6007616")]
	[Address(RVA = "0x133B0E4", Offset = "0x133B0E4", VA = "0x133B0E4")]
	public XWidget_Relic()
	{
	}

	[Token(Token = "0x6007618")]
	[Address(RVA = "0x133B27C", Offset = "0x133B27C", VA = "0x133B27C", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6007619")]
	[Address(RVA = "0x133BA14", Offset = "0x133BA14", VA = "0x133BA14")]
	public void Build(Action relicBadgeAction)
	{
	}

	[Token(Token = "0x600761A")]
	[Address(RVA = "0x133BD24", Offset = "0x133BD24", VA = "0x133BD24")]
	private void BuildInit()
	{
	}

	[Token(Token = "0x600761B")]
	[Address(RVA = "0x133CB10", Offset = "0x133CB10", VA = "0x133CB10")]
	private void SetRepositionClippedView(int selectIndex)
	{
	}

	[Token(Token = "0x600761C")]
	[Address(RVA = "0x133D494", Offset = "0x133D494", VA = "0x133D494")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x600761D")]
	[Address(RVA = "0x133C668", Offset = "0x133C668", VA = "0x133C668")]
	private void BuildSlot()
	{
	}

	[Token(Token = "0x600761E")]
	[Address(RVA = "0x133D49C", Offset = "0x133D49C", VA = "0x133D49C")]
	public void HideRelicAllEffect()
	{
	}

	[Token(Token = "0x600761F")]
	[Address(RVA = "0x133D4DC", Offset = "0x133D4DC", VA = "0x133D4DC", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007620")]
	[Address(RVA = "0x133D4EC", Offset = "0x133D4EC", VA = "0x133D4EC")]
	public void OnClick_RelicOpen()
	{
	}

	[Token(Token = "0x6007621")]
	[Address(RVA = "0x133D97C", Offset = "0x133D97C", VA = "0x133D97C")]
	public void SetSelectSlotIndex(int index)
	{
	}

	[Token(Token = "0x6007622")]
	[Address(RVA = "0x133D984", Offset = "0x133D984", VA = "0x133D984")]
	private void SetQuickSlot()
	{
	}

	[Token(Token = "0x6007623")]
	[Address(RVA = "0x133DE98", Offset = "0x133DE98", VA = "0x133DE98")]
	private void SaveFirstSelectedRelic(int selectRelicId)
	{
	}

	[Token(Token = "0x6007624")]
	[Address(RVA = "0x133E128", Offset = "0x133E128", VA = "0x133E128")]
	private void SaveSelectedRelic(int selectRelicId)
	{
	}

	[Token(Token = "0x6007625")]
	[Address(RVA = "0x133E298", Offset = "0x133E298", VA = "0x133E298")]
	private void SaveSelectedRelicIndex(int selectRelicIndex)
	{
	}

	[Token(Token = "0x6007626")]
	[Address(RVA = "0x133E408", Offset = "0x133E408", VA = "0x133E408")]
	private void SaveSelectedRelicPageIndex(int selectRelicIndex)
	{
	}

	[Token(Token = "0x6007627")]
	[Address(RVA = "0x133C9D0", Offset = "0x133C9D0", VA = "0x133C9D0")]
	private int GetSelectedRelicPageIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6007628")]
	[Address(RVA = "0x133D988", Offset = "0x133D988", VA = "0x133D988")]
	private void SetItemQuickSlot()
	{
	}

	[Token(Token = "0x6007629")]
	[Address(RVA = "0x133E580", Offset = "0x133E580", VA = "0x133E580")]
	private void RefreshAllSlotItem()
	{
	}

	[Token(Token = "0x600762A")]
	[Address(RVA = "0x133D4F0", Offset = "0x133D4F0", VA = "0x133D4F0")]
	public void OnClick_RelicUpgrade()
	{
	}

	[Token(Token = "0x600762B")]
	[Address(RVA = "0x133E8DC", Offset = "0x133E8DC", VA = "0x133E8DC")]
	public void OpenBuySlotPopup()
	{
	}

	[Token(Token = "0x600762C")]
	[Address(RVA = "0x133EC38", Offset = "0x133EC38", VA = "0x133EC38")]
	private void BuySlot()
	{
	}

	[Token(Token = "0x600762D")]
	[Address(RVA = "0x133EFF8", Offset = "0x133EFF8", VA = "0x133EFF8")]
	public void OnClick_SetSlot()
	{
	}

	[Token(Token = "0x600762E")]
	[Address(RVA = "0x133F4B4", Offset = "0x133F4B4", VA = "0x133F4B4")]
	public bool RelicUnlockCheck(RelicInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x600762F")]
	[Address(RVA = "0x133F5CC", Offset = "0x133F5CC", VA = "0x133F5CC")]
	public void RefreshUnlock(XUIRelicItem relicItem)
	{
	}

	[Token(Token = "0x6007630")]
	[Address(RVA = "0x133F714", Offset = "0x133F714", VA = "0x133F714")]
	private bool NoSetSlotRelic()
	{
		return default(bool);
	}

	[Token(Token = "0x6007631")]
	[Address(RVA = "0x133F888", Offset = "0x133F888", VA = "0x133F888")]
	public void SelectRelicObject(XUIRelicItem selObject)
	{
	}

	[Token(Token = "0x6007632")]
	[Address(RVA = "0x133CD2C", Offset = "0x133CD2C", VA = "0x133CD2C")]
	public void RefreshDetail(RelicInfo relicItem, bool m_open)
	{
	}

	[Token(Token = "0x6007633")]
	[Address(RVA = "0x133FE20", Offset = "0x133FE20", VA = "0x133FE20")]
	public void RefreshRelicInfoDetailOnSlotClick(int index)
	{
	}

	[Token(Token = "0x6007634")]
	[Address(RVA = "0x13400B8", Offset = "0x13400B8", VA = "0x13400B8")]
	public void RefreshDailyRelicInfoDetail(int index)
	{
	}

	[Token(Token = "0x6007635")]
	[Address(RVA = "0x133FA88", Offset = "0x133FA88", VA = "0x133FA88")]
	public void RefreshDetailStat(RelicInfo relicItem, bool m_open, int relicLevel)
	{
	}

	[Token(Token = "0x6007636")]
	[Address(RVA = "0x133FA28", Offset = "0x133FA28", VA = "0x133FA28")]
	private void SingleQuickSlotSetButtonHide(int id)
	{
	}

	[Token(Token = "0x6007637")]
	[Address(RVA = "0x13408C8", Offset = "0x13408C8", VA = "0x13408C8")]
	private void SetDetailSkillBuff(RelicInfo relicItem, int relicLevel)
	{
	}

	[Token(Token = "0x6007638")]
	[Address(RVA = "0x1340D20", Offset = "0x1340D20", VA = "0x1340D20")]
	private CSSkillInfo GetRelicSkill(int relic_SkillID)
	{
		return null;
	}

	[Token(Token = "0x6007639")]
	[Address(RVA = "0x133E7CC", Offset = "0x133E7CC", VA = "0x133E7CC")]
	private RelicInfo GetNextRelic(int id, int level)
	{
		return null;
	}

	[Token(Token = "0x600763A")]
	[Address(RVA = "0x133B6AC", Offset = "0x133B6AC", VA = "0x133B6AC")]
	public void RefreshSlotArrow(bool state, int id = -1)
	{
	}

	[Token(Token = "0x600763B")]
	[Address(RVA = "0x133B324", Offset = "0x133B324", VA = "0x133B324")]
	public void ChangeSlot(int index)
	{
	}

	[Token(Token = "0x600763C")]
	[Address(RVA = "0x133B848", Offset = "0x133B848", VA = "0x133B848")]
	private void DisableSlotBlock()
	{
	}

	[Token(Token = "0x600763D")]
	[Address(RVA = "0x133F2A8", Offset = "0x133F2A8", VA = "0x133F2A8")]
	private void EnableSlotBlock(int id)
	{
	}

	[Token(Token = "0x600763E")]
	[Address(RVA = "0x1340F28", Offset = "0x1340F28", VA = "0x1340F28")]
	private void ChangeHideSetting(bool state)
	{
	}

	[Token(Token = "0x600763F")]
	[Address(RVA = "0x133E6B0", Offset = "0x133E6B0", VA = "0x133E6B0")]
	private int GetCurrentlyRelicLevel(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6007640")]
	[Address(RVA = "0x133F120", Offset = "0x133F120", VA = "0x133F120")]
	private int GetSetSlotCount(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6007641")]
	[Address(RVA = "0x133EB08", Offset = "0x133EB08", VA = "0x133EB08")]
	private int GetGameConstValue(key key)
	{
		return default(int);
	}

	[Token(Token = "0x6007642")]
	[Address(RVA = "0x1341024", Offset = "0x1341024", VA = "0x1341024")]
	public void GetRelicPopup()
	{
	}

	[Token(Token = "0x6007643")]
	[Address(RVA = "0x133B940", Offset = "0x133B940", VA = "0x133B940")]
	private void SetSlotButtonText(bool state)
	{
	}

	[Token(Token = "0x6007644")]
	[Address(RVA = "0x1341398", Offset = "0x1341398", VA = "0x1341398")]
	private void GetUpgradeEffect()
	{
	}

	[Token(Token = "0x6007645")]
	[Address(RVA = "0x133D374", Offset = "0x133D374", VA = "0x133D374")]
	private void SetParticleEffect(bool bShow)
	{
	}

	[Token(Token = "0x6007646")]
	[Address(RVA = "0x133C54C", Offset = "0x133C54C", VA = "0x133C54C")]
	private void SetRelicTutorialObject()
	{
	}

	[Token(Token = "0x6007647")]
	[Address(RVA = "0x1341480", Offset = "0x1341480", VA = "0x1341480")]
	private static ItemRarity _003CBuildInit_003Em__4DC(RelicInfo o)
	{
		return default(ItemRarity);
	}

	[Token(Token = "0x6007648")]
	[Address(RVA = "0x13414A0", Offset = "0x13414A0", VA = "0x13414A0")]
	private void _003COnClick_RelicUpgrade_003Em__4DE(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6007649")]
	[Address(RVA = "0x1341768", Offset = "0x1341768", VA = "0x1341768")]
	private void _003COpenBuySlotPopup_003Em__4DF()
	{
	}

	[Token(Token = "0x600764A")]
	[Address(RVA = "0x134176C", Offset = "0x134176C", VA = "0x134176C")]
	private void _003CBuySlot_003Em__4E0(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x600764B")]
	[Address(RVA = "0x13418B8", Offset = "0x13418B8", VA = "0x13418B8")]
	private static void _003CGetRelicPopup_003Em__4E1()
	{
	}
}
