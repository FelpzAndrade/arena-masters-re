using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000DB9")]
public class XPanel_CharDetail : XUIBasePanel
{
	[Token(Token = "0x2000DBA")]
	private enum RightDetailType
	{
		[Token(Token = "0x400475F")]
		None = 0,
		[Token(Token = "0x4004760")]
		Inventory = 1,
		[Token(Token = "0x4004761")]
		Skill = 2,
		[Token(Token = "0x4004762")]
		Skin = 3
	}

	[Token(Token = "0x2000DBB")]
	private sealed class _003CLoadAsync_003Ec__IteratorA2 : IDisposable
	{
		[Token(Token = "0x4004763")]
		[FieldOffset(Offset = "0x8")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x4004764")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject _003Cprefab_003E__1;

		[Token(Token = "0x4004765")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleActor character;

		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4004767")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4004768")]
		[FieldOffset(Offset = "0x1C")]
		internal XModuleActor _003C_0024_003Echaracter;

		[Token(Token = "0x4004769")]
		[FieldOffset(Offset = "0x20")]
		internal XPanel_CharDetail _003C_003Ef__this;

		[Token(Token = "0x17000D53")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006525")]
			[Address(RVA = "0x169E110", Offset = "0x169E110", VA = "0x169E110", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D54")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006526")]
			[Address(RVA = "0x169E118", Offset = "0x169E118", VA = "0x169E118", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006524")]
		[Address(RVA = "0x169A33C", Offset = "0x169A33C", VA = "0x169A33C")]
		public _003CLoadAsync_003Ec__IteratorA2()
		{
		}

		[Token(Token = "0x6006525")]
		[Address(RVA = "0x169E110", Offset = "0x169E110", VA = "0x169E110", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006526")]
		[Address(RVA = "0x169E118", Offset = "0x169E118", VA = "0x169E118", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006527")]
		[Address(RVA = "0x169E120", Offset = "0x169E120", VA = "0x169E120", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006528")]
		[Address(RVA = "0x169E378", Offset = "0x169E378", VA = "0x169E378", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006529")]
		[Address(RVA = "0x169E384", Offset = "0x169E384", VA = "0x169E384", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000DBC")]
	private sealed class _003CBuildEquipmentSlot_003Ec__AnonStorey1B8
	{
		[Token(Token = "0x400476A")]
		[FieldOffset(Offset = "0x8")]
		internal XItem item;

		[Token(Token = "0x400476B")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_CharDetail _003C_003Ef__this;

		[Token(Token = "0x600652A")]
		[Address(RVA = "0x169C0CC", Offset = "0x169C0CC", VA = "0x169C0CC")]
		public _003CBuildEquipmentSlot_003Ec__AnonStorey1B8()
		{
		}

		[Token(Token = "0x600652B")]
		[Address(RVA = "0x169DE50", Offset = "0x169DE50", VA = "0x169DE50")]
		internal void _003C_003Em__33A()
		{
		}
	}

	[Token(Token = "0x2000DBD")]
	private sealed class _003CBuildUpgrade_003Ec__AnonStorey1B9
	{
		[Token(Token = "0x400476C")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor character;

		[Token(Token = "0x400476D")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_CharDetail _003C_003Ef__this;

		[Token(Token = "0x600652C")]
		[Address(RVA = "0x169C660", Offset = "0x169C660", VA = "0x169C660")]
		public _003CBuildUpgrade_003Ec__AnonStorey1B9()
		{
		}

		[Token(Token = "0x600652D")]
		[Address(RVA = "0x169DEA8", Offset = "0x169DEA8", VA = "0x169DEA8")]
		internal void _003C_003Em__33B()
		{
		}

		[Token(Token = "0x600652E")]
		[Address(RVA = "0x169DFB8", Offset = "0x169DFB8", VA = "0x169DFB8")]
		internal void _003C_003Em__340()
		{
		}
	}

	[Token(Token = "0x2000DBE")]
	private sealed class _003CShowCardDirection_003Ec__AnonStorey1BA
	{
		[Token(Token = "0x400476E")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor selectedCharacter;

		[Token(Token = "0x400476F")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_CharDetail _003C_003Ef__this;

		[Token(Token = "0x600652F")]
		[Address(RVA = "0x169CA84", Offset = "0x169CA84", VA = "0x169CA84")]
		public _003CShowCardDirection_003Ec__AnonStorey1BA()
		{
		}

		[Token(Token = "0x6006530")]
		[Address(RVA = "0x169E418", Offset = "0x169E418", VA = "0x169E418")]
		internal void _003C_003Em__33D()
		{
		}

		[Token(Token = "0x6006531")]
		[Address(RVA = "0x169E4FC", Offset = "0x169E4FC", VA = "0x169E4FC")]
		internal void _003C_003Em__341()
		{
		}
	}

	[Token(Token = "0x2000DBF")]
	private sealed class _003CAddTutorialObject_003Ec__AnonStorey1BB
	{
		[Token(Token = "0x4004770")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x4004771")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject obj;

		[Token(Token = "0x4004772")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_CharDetail _003C_003Ef__this;

		[Token(Token = "0x6006532")]
		[Address(RVA = "0x169DB48", Offset = "0x169DB48", VA = "0x169DB48")]
		public _003CAddTutorialObject_003Ec__AnonStorey1BB()
		{
		}

		[Token(Token = "0x6006533")]
		[Address(RVA = "0x169DDD8", Offset = "0x169DDD8", VA = "0x169DDD8")]
		internal void _003C_003Em__33F()
		{
		}
	}

	[Token(Token = "0x4004733")]
	[FieldOffset(Offset = "0x10")]
	private readonly string Path_CharDetailEvolutionPopup;

	[Token(Token = "0x4004734")]
	[FieldOffset(Offset = "0x14")]
	private readonly string Path_CharDetailEvolutionResult;

	[Token(Token = "0x4004735")]
	[FieldOffset(Offset = "0x18")]
	private readonly string Path_CharDetailStatDetail;

	[Token(Token = "0x4004736")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_StatDetail _widgetStatDetail;

	[Token(Token = "0x4004737")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_CharacterAcqusition _evolutionPopup;

	[Token(Token = "0x4004738")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_EvolutionResult _evolutionResult;

	[Token(Token = "0x4004739")]
	[FieldOffset(Offset = "0x28")]
	private XWidget_InvenItemDetail _itemDetailPopup;

	[Token(Token = "0x400473A")]
	[FieldOffset(Offset = "0x2C")]
	private XWidget_Inventory m_inventory;

	[Token(Token = "0x400473B")]
	[FieldOffset(Offset = "0x30")]
	public Transform InventoryParent;

	[Token(Token = "0x400473C")]
	[FieldOffset(Offset = "0x34")]
	private string m_selectedCharUid;

	[Token(Token = "0x400473D")]
	[FieldOffset(Offset = "0x38")]
	private int m_selectedCharId;

	[Token(Token = "0x400473E")]
	[FieldOffset(Offset = "0x3C")]
	public Transform itemDetailPopupParent;

	[Token(Token = "0x400473F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject skillNewBadge;

	[Token(Token = "0x4004740")]
	[FieldOffset(Offset = "0x44")]
	public GameObject skinNewBadge;

	[Token(Token = "0x4004741")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] InvisibleObjectsInPreview;

	[Token(Token = "0x4004742")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject goFreeRotationDisplay;

	[Token(Token = "0x4004743")]
	[FieldOffset(Offset = "0x50")]
	public XUIModelPreviewDragZone preview;

	[Token(Token = "0x4004744")]
	[FieldOffset(Offset = "0x54")]
	public XWiget_GridBuilder gridSlot;

	[Token(Token = "0x4004745")]
	[FieldOffset(Offset = "0x58")]
	private XWidget_ButtonEquipmentSlot[] _slotWidgets;

	[Token(Token = "0x4004746")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject goLevel;

	[Token(Token = "0x4004747")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblLevel;

	[Token(Token = "0x4004748")]
	[FieldOffset(Offset = "0x64")]
	public UILabel lblExp;

	[Token(Token = "0x4004749")]
	[FieldOffset(Offset = "0x68")]
	public UIProgressBar prbExp;

	[Token(Token = "0x400474A")]
	[FieldOffset(Offset = "0x6C")]
	public XWidget_Button btnUpgrade;

	[Token(Token = "0x400474B")]
	[FieldOffset(Offset = "0x70")]
	public XWiget_GridBuilder gridDefaultStat;

	[Token(Token = "0x400474C")]
	[FieldOffset(Offset = "0x74")]
	public UILabel lblTitle;

	[Token(Token = "0x400474D")]
	[FieldOffset(Offset = "0x78")]
	public UILabel lblName;

	[Token(Token = "0x400474E")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel lblPreviewName;

	[Token(Token = "0x400474F")]
	[FieldOffset(Offset = "0x80")]
	private int DEFAULT_STATEINFO_COUNT;

	[Token(Token = "0x4004750")]
	[FieldOffset(Offset = "0x84")]
	private Color m_prbInitColor;

	[Token(Token = "0x4004751")]
	[FieldOffset(Offset = "0x94")]
	private int m_goldCost;

	[Token(Token = "0x4004752")]
	[FieldOffset(Offset = "0x98")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x4004753")]
	[FieldOffset(Offset = "0x9C")]
	public string characterEvolutionSoundKey;

	[Token(Token = "0x4004754")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel lblFightingPointValue;

	[Token(Token = "0x4004755")]
	[FieldOffset(Offset = "0xA4")]
	public XWidget_OnPress fightingPointCallBack;

	[Token(Token = "0x4004756")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel lblfightingPoint_ChargeInfo_Stat;

	[Token(Token = "0x4004757")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel lblfightingPoint_ChargeInfo_Skill;

	[Token(Token = "0x4004758")]
	[FieldOffset(Offset = "0xB0")]
	public TweenAlpha tweenAlphafightingPoint;

	[Token(Token = "0x4004759")]
	[FieldOffset(Offset = "0xB4")]
	public UIGrid rightButtonGrid;

	[Token(Token = "0x400475A")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel lblBtnParty;

	[Token(Token = "0x400475B")]
	[FieldOffset(Offset = "0xBC")]
	public XWidget_Button btnBuyChar;

	[Token(Token = "0x400475C")]
	[FieldOffset(Offset = "0xC0")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x400475D")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache2A;

	[Token(Token = "0x17000D4E")]
	private XWidget_StatDetail widgetStatDetail
	{
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0x1699494", Offset = "0x1699494", VA = "0x1699494")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D4F")]
	private XWidget_CharacterAcqusition evolutionPopup
	{
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0x1699594", Offset = "0x1699594", VA = "0x1699594")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D50")]
	private XWidget_EvolutionResult evolutionResult
	{
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0x1699694", Offset = "0x1699694", VA = "0x1699694")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D51")]
	private XWidget_InvenItemDetail itemDetailPopup
	{
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0x1699794", Offset = "0x1699794", VA = "0x1699794")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D52")]
	private XWidget_ButtonEquipmentSlot[] slotWidgets
	{
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x169B5FC", Offset = "0x169B5FC", VA = "0x169B5FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60064EF")]
	[Address(RVA = "0x16993C4", Offset = "0x16993C4", VA = "0x16993C4")]
	public XPanel_CharDetail()
	{
	}

	[Token(Token = "0x60064F4")]
	[Address(RVA = "0x16998E4", Offset = "0x16998E4", VA = "0x16998E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60064F5")]
	[Address(RVA = "0x1699924", Offset = "0x1699924", VA = "0x1699924")]
	public void Show(string uid, int charID, bool playVoiceSound = true)
	{
	}

	[Token(Token = "0x60064F6")]
	[Address(RVA = "0x169A330", Offset = "0x169A330", VA = "0x169A330")]
	public XModuleActor GetCurrentCharacter()
	{
		return null;
	}

	[Token(Token = "0x60064F7")]
	[Address(RVA = "0x1699CBC", Offset = "0x1699CBC", VA = "0x1699CBC")]
	private XModuleActor GetCharacter(string uid, int charID)
	{
		return null;
	}

	[Token(Token = "0x60064F8")]
	[Address(RVA = "0x1699FD8", Offset = "0x1699FD8", VA = "0x1699FD8")]
	[DebuggerHidden]
	private IEnumerator LoadAsync(XModuleActor character)
	{
		return null;
	}

	[Token(Token = "0x60064F9")]
	[Address(RVA = "0x169A344", Offset = "0x169A344", VA = "0x169A344", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60064FA")]
	[Address(RVA = "0x1699D98", Offset = "0x1699D98", VA = "0x1699D98")]
	public void Build(XModuleActor character)
	{
	}

	[Token(Token = "0x60064FB")]
	[Address(RVA = "0x169A83C", Offset = "0x169A83C", VA = "0x169A83C")]
	public void Refresh(string uid, int charID)
	{
	}

	[Token(Token = "0x60064FC")]
	[Address(RVA = "0x169A670", Offset = "0x169A670", VA = "0x169A670")]
	public void Refresh(XModuleActor selectedCharacter)
	{
	}

	[Token(Token = "0x60064FD")]
	[Address(RVA = "0x169B3D0", Offset = "0x169B3D0", VA = "0x169B3D0")]
	private bool IsCharacterNotOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x60064FE")]
	[Address(RVA = "0x169B570", Offset = "0x169B570", VA = "0x169B570")]
	private void OnEquip(EquipmentSlot slot)
	{
	}

	[Token(Token = "0x6006500")]
	[Address(RVA = "0x169B6A8", Offset = "0x169B6A8", VA = "0x169B6A8")]
	public void RefreshCharacterModel()
	{
	}

	[Token(Token = "0x6006501")]
	[Address(RVA = "0x169AA2C", Offset = "0x169AA2C", VA = "0x169AA2C")]
	public void BuildInfo(XModuleActor character)
	{
	}

	[Token(Token = "0x6006502")]
	[Address(RVA = "0x169A9E4", Offset = "0x169A9E4", VA = "0x169A9E4")]
	private void BuildModel(XModuleActor character)
	{
	}

	[Token(Token = "0x6006503")]
	[Address(RVA = "0x169BE54", Offset = "0x169BE54", VA = "0x169BE54")]
	private void BuildEquipmentSlot(XModuleActor character)
	{
	}

	[Token(Token = "0x6006504")]
	[Address(RVA = "0x169C1EC", Offset = "0x169C1EC", VA = "0x169C1EC")]
	private void BuildDefaultStat(XModuleActor character)
	{
	}

	[Token(Token = "0x6006505")]
	[Address(RVA = "0x169B6D0", Offset = "0x169B6D0", VA = "0x169B6D0")]
	private void BuildUpgrade(XModuleActor character)
	{
	}

	[Token(Token = "0x6006506")]
	[Address(RVA = "0x169B454", Offset = "0x169B454", VA = "0x169B454")]
	private void BuildPreviewDetail(XModuleActor character, bool isCharacterNotOwned)
	{
	}

	[Token(Token = "0x6006507")]
	[Address(RVA = "0x169C668", Offset = "0x169C668", VA = "0x169C668")]
	private void SendNetCommand_Levelup(string cid, int itemId)
	{
	}

	[Token(Token = "0x6006508")]
	[Address(RVA = "0x169C8C4", Offset = "0x169C8C4", VA = "0x169C8C4")]
	private void ShowCardDirection(XModuleActor selectedCharacter)
	{
	}

	[Token(Token = "0x6006509")]
	[Address(RVA = "0x169CA8C", Offset = "0x169CA8C", VA = "0x169CA8C")]
	private void EndCardDirection()
	{
	}

	[Token(Token = "0x600650A")]
	[Address(RVA = "0x169CB60", Offset = "0x169CB60", VA = "0x169CB60")]
	public void ShowFightingPointChargeInfo()
	{
	}

	[Token(Token = "0x600650B")]
	[Address(RVA = "0x169CBD0", Offset = "0x169CBD0", VA = "0x169CBD0")]
	public void HideFightingPointChargeInfo()
	{
	}

	[Token(Token = "0x600650C")]
	[Address(RVA = "0x169B1F4", Offset = "0x169B1F4", VA = "0x169B1F4")]
	public void BuildStat(XModuleActor character)
	{
	}

	[Token(Token = "0x600650D")]
	[Address(RVA = "0x169CBFC", Offset = "0x169CBFC", VA = "0x169CBFC")]
	public void RefreshFightingPoint(XModuleActor character)
	{
	}

	[Token(Token = "0x600650E")]
	[Address(RVA = "0x169D0A0", Offset = "0x169D0A0", VA = "0x169D0A0")]
	public void ShowStatDetailPopup()
	{
	}

	[Token(Token = "0x600650F")]
	[Address(RVA = "0x169D0E8", Offset = "0x169D0E8", VA = "0x169D0E8")]
	public void OpenOptionChangePopup(XItem item)
	{
	}

	[Token(Token = "0x6006510")]
	[Address(RVA = "0x169A088", Offset = "0x169A088", VA = "0x169A088")]
	public void BuildInventory(XModuleActor character, Transform leftRoot)
	{
	}

	[Token(Token = "0x6006511")]
	[Address(RVA = "0x169A204", Offset = "0x169A204", VA = "0x169A204")]
	private void ShowRight(RightDetailType detailType)
	{
	}

	[Token(Token = "0x6006512")]
	[Address(RVA = "0x169B1F8", Offset = "0x169B1F8", VA = "0x169B1F8")]
	public void BuildButton(XModuleActor character)
	{
	}

	[Token(Token = "0x6006513")]
	[Address(RVA = "0x169A864", Offset = "0x169A864", VA = "0x169A864")]
	private bool IsFreeRotaChar(int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x6006514")]
	[Address(RVA = "0x169D114", Offset = "0x169D114", VA = "0x169D114")]
	private bool IsShowPartyButton(string charUID, int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x6006515")]
	[Address(RVA = "0x169D314", Offset = "0x169D314", VA = "0x169D314")]
	private bool IsShowBuyCharButton()
	{
		return default(bool);
	}

	[Token(Token = "0x6006516")]
	[Address(RVA = "0x169D68C", Offset = "0x169D68C", VA = "0x169D68C")]
	public void OnClick_PetInventory()
	{
	}

	[Token(Token = "0x6006517")]
	[Address(RVA = "0x169D760", Offset = "0x169D760", VA = "0x169D760")]
	public void OnClick_PartyBtn()
	{
	}

	[Token(Token = "0x6006518")]
	[Address(RVA = "0x169D868", Offset = "0x169D868", VA = "0x169D868")]
	public void OnClick_BuyCharBtn()
	{
	}

	[Token(Token = "0x6006519")]
	[Address(RVA = "0x169D34C", Offset = "0x169D34C", VA = "0x169D34C")]
	private CSShopItem FindCharShopItem(int nCharID)
	{
		return null;
	}

	[Token(Token = "0x600651A")]
	[Address(RVA = "0x169D970", Offset = "0x169D970", VA = "0x169D970")]
	public void OnClick_Equipment()
	{
	}

	[Token(Token = "0x600651B")]
	[Address(RVA = "0x169D978", Offset = "0x169D978", VA = "0x169D978")]
	public void OnClick_Skill()
	{
	}

	[Token(Token = "0x600651C")]
	[Address(RVA = "0x169D980", Offset = "0x169D980", VA = "0x169D980")]
	public void OnClick_Skin()
	{
	}

	[Token(Token = "0x600651D")]
	[Address(RVA = "0x169DA70", Offset = "0x169DA70", VA = "0x169DA70")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x600651E")]
	[Address(RVA = "0x169C0D4", Offset = "0x169C0D4", VA = "0x169C0D4")]
	private void AddTutorialObject(string name, GameObject obj)
	{
	}

	[Token(Token = "0x600651F")]
	[Address(RVA = "0x169B3E0", Offset = "0x169B3E0", VA = "0x169B3E0")]
	private void ShowOrHidePreviewWidgets(bool bThisCharIsPreview)
	{
	}

	[Token(Token = "0x6006520")]
	[Address(RVA = "0x169DB50", Offset = "0x169DB50", VA = "0x169DB50")]
	private static void _003CHide_003Em__338(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006521")]
	[Address(RVA = "0x169DC30", Offset = "0x169DC30", VA = "0x169DC30")]
	private void _003CBuild_003Em__339()
	{
	}

	[Token(Token = "0x6006522")]
	[Address(RVA = "0x169DC58", Offset = "0x169DC58", VA = "0x169DC58")]
	private void _003CSendNetCommand_Levelup_003Em__33C(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006523")]
	[Address(RVA = "0x169DDB0", Offset = "0x169DDB0", VA = "0x169DDB0")]
	private void _003CBuildInventory_003Em__33E()
	{
	}
}
