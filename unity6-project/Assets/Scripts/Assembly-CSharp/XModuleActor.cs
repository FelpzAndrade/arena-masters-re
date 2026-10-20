using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

[Token(Token = "0x2000446")]
public class XModuleActor : XModuleBase, IActor
{
	[Token(Token = "0x2000447")]
	public class CharacterInfoMaster
	{
		[Token(Token = "0x40014FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Dictionary<int, CharacterStatus> m_list;

		[Token(Token = "0x40014FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private CreationDesc m_desc;

		[Token(Token = "0x40014FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CharacterStatus m_current;

		[Token(Token = "0x4001500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private CharacterStatus m_next;

		[Token(Token = "0x4001501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CSCharacterInfo m_changedModel;

		[Token(Token = "0x4001502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CSCharacterInfo m_changedModelStatus;

		[Token(Token = "0x4001503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CharStatus m_changedModelPassive;

		[Token(Token = "0x4001504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_swapSKill;

		[Token(Token = "0x4001505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool m_canTag;

		[Token(Token = "0x4001506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharStatus m_status;

		[Token(Token = "0x170005D5")]
		public Dictionary<int, CharacterStatus> List
		{
			[Token(Token = "0x60022B8")]
			[Address(RVA = "0xB3CDBC", Offset = "0xB3CDBC", VA = "0xB3CDBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D6")]
		public CreationDesc Desc
		{
			[Token(Token = "0x60022B9")]
			[Address(RVA = "0xB34DDC", Offset = "0xB34DDC", VA = "0xB34DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D7")]
		public CharacterStatus Current
		{
			[Token(Token = "0x60022BA")]
			[Address(RVA = "0xB34CC8", Offset = "0xB34CC8", VA = "0xB34CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D8")]
		public CharacterStatus Next
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0xB3CF5C", Offset = "0xB3CF5C", VA = "0xB3CF5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D9")]
		public CharacterStatus NextOriginal
		{
			[Token(Token = "0x60022BE")]
			[Address(RVA = "0xB3CF74", Offset = "0xB3CF74", VA = "0xB3CF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DA")]
		public CSCharacterInfo Info
		{
			[Token(Token = "0x60022BF")]
			[Address(RVA = "0xB34CD0", Offset = "0xB34CD0", VA = "0xB34CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DB")]
		public CSCharacterInfo CharInfoStatus
		{
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0xB3CF84", Offset = "0xB3CF84", VA = "0xB3CF84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DC")]
		public CharStatus EquipStatus
		{
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0xB364A0", Offset = "0xB364A0", VA = "0xB364A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DD")]
		public CharStatus PassiveSkillStatus
		{
			[Token(Token = "0x60022C2")]
			[Address(RVA = "0xB3CFC4", Offset = "0xB3CFC4", VA = "0xB3CFC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DE")]
		public CSCharacterInfo SkillInfo
		{
			[Token(Token = "0x60022C3")]
			[Address(RVA = "0xB34D5C", Offset = "0xB34D5C", VA = "0xB34D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DF")]
		public bool HasChangedModel
		{
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0xB38B80", Offset = "0xB38B80", VA = "0xB38B80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005E0")]
		public CSCharacterInfo ChangedModelStatus
		{
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0xB34D2C", Offset = "0xB34D2C", VA = "0xB34D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E1")]
		public bool HasChangedModelStatus
		{
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0xB3D10C", Offset = "0xB3D10C", VA = "0xB3D10C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005E2")]
		public bool DisableSkill
		{
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0xB3D124", Offset = "0xB3D124", VA = "0xB3D124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005E3")]
		public int CurrentIndex
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0xB3CE0C", Offset = "0xB3CE0C", VA = "0xB3CE0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170005E4")]
		public CharStatus Status
		{
			[Token(Token = "0x60022C9")]
			[Address(RVA = "0xB35FD0", Offset = "0xB35FD0", VA = "0xB35FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022B6")]
		[Address(RVA = "0xB37704", Offset = "0xB37704", VA = "0xB37704")]
		public CharacterInfoMaster(CreationDesc desc)
		{
		}

		[Token(Token = "0x60022B7")]
		[Address(RVA = "0xB3986C", Offset = "0xB3986C", VA = "0xB3986C")]
		public void SetOrderList(List<int> orderList, int orderIndex)
		{
		}

		[Token(Token = "0x60022BB")]
		[Address(RVA = "0xB3CDC4", Offset = "0xB3CDC4", VA = "0xB3CDC4")]
		public bool CheckOutOfRange()
		{
			return default(bool);
		}

		[Token(Token = "0x60022BC")]
		[Address(RVA = "0xB3CEC4", Offset = "0xB3CEC4", VA = "0xB3CEC4")]
		public int ListCount()
		{
			return default(int);
		}

		[Token(Token = "0x60022CA")]
		[Address(RVA = "0xB3D154", Offset = "0xB3D154", VA = "0xB3D154")]
		public void SetChangedModel(CSCharacterInfo info, [Optional] CSCharacterInfo changeModelStatus, bool swapSkill = true, bool canTag = true)
		{
		}

		[Token(Token = "0x60022CB")]
		[Address(RVA = "0xB38ED0", Offset = "0xB38ED0", VA = "0xB38ED0")]
		public bool ChangeToNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60022CC")]
		[Address(RVA = "0xB3D228", Offset = "0xB3D228", VA = "0xB3D228")]
		private void SetNextToCurrent()
		{
		}

		[Token(Token = "0x60022CD")]
		[Address(RVA = "0xB3CB94", Offset = "0xB3CB94", VA = "0xB3CB94")]
		private void ChooseNext()
		{
		}

		[Token(Token = "0x60022CE")]
		[Address(RVA = "0xB3B004", Offset = "0xB3B004", VA = "0xB3B004")]
		public void Final()
		{
		}
	}

	[Token(Token = "0x2000448")]
	public class CharacterStatus
	{
		[Token(Token = "0x4001507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private CSCharacterInfo m_CharacterInfo;

		[Token(Token = "0x4001508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SkinInfo m_SkinInfo;

		[Token(Token = "0x4001509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CharStatus m_status;

		[Token(Token = "0x400150A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private CharStatus m_passiveStatus;

		[Token(Token = "0x400150B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EquipSlots m_equipSlots;

		[Token(Token = "0x400150C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private CharStatus m_equipSlotsStatus;

		[Token(Token = "0x400150D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_uid;

		[Token(Token = "0x400150E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ObscuredInt m_level;

		[Token(Token = "0x400150F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private SkillSpecialized m_specialized_skill_list;

		[Token(Token = "0x170005E5")]
		public CSCharacterInfo Info
		{
			[Token(Token = "0x60022D1")]
			[Address(RVA = "0xB3CF7C", Offset = "0xB3CF7C", VA = "0xB3CF7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E6")]
		public SkinInfo SkinInfo
		{
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0xB34DD4", Offset = "0xB34DD4", VA = "0xB34DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E7")]
		public CharStatus Status
		{
			[Token(Token = "0x60022D3")]
			[Address(RVA = "0xB3D14C", Offset = "0xB3D14C", VA = "0xB3D14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E8")]
		public CharStatus PassiveStatus
		{
			[Token(Token = "0x60022D4")]
			[Address(RVA = "0xB3D11C", Offset = "0xB3D11C", VA = "0xB3D11C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E9")]
		public EquipSlots EquipSlots
		{
			[Token(Token = "0x60022D5")]
			[Address(RVA = "0xB388F0", Offset = "0xB388F0", VA = "0xB388F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EA")]
		public CharStatus EquipSlotsStatus
		{
			[Token(Token = "0x60022D6")]
			[Address(RVA = "0xB3CFBC", Offset = "0xB3CFBC", VA = "0xB3CFBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EB")]
		public string UID
		{
			[Token(Token = "0x60022D7")]
			[Address(RVA = "0xB3DCF8", Offset = "0xB3DCF8", VA = "0xB3DCF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EC")]
		public int Level
		{
			[Token(Token = "0x60022D8")]
			[Address(RVA = "0xB34DE4", Offset = "0xB34DE4", VA = "0xB34DE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170005ED")]
		public SkillSpecialized SkillSpecialized
		{
			[Token(Token = "0x60022D9")]
			[Address(RVA = "0xB37348", Offset = "0xB37348", VA = "0xB37348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022CF")]
		[Address(RVA = "0xB3D310", Offset = "0xB3D310", VA = "0xB3D310")]
		public CharacterStatus()
		{
		}

		[Token(Token = "0x60022D0")]
		[Address(RVA = "0xB3C6B8", Offset = "0xB3C6B8", VA = "0xB3C6B8")]
		public CharacterStatus(CreationDesc.CharDesc charDesc, bool isNPC, bool isPVP, bool isBalanceRegulate)
		{
		}

		[Token(Token = "0x60022DA")]
		[Address(RVA = "0xB3D7EC", Offset = "0xB3D7EC", VA = "0xB3D7EC")]
		private CharStatus GetBalanceInfo(CreationDesc.CharDesc desc, bool isNPC)
		{
			return null;
		}

		[Token(Token = "0x60022DB")]
		[Address(RVA = "0xB3DD00", Offset = "0xB3DD00", VA = "0xB3DD00")]
		public CharStatus GetBalanceInfo(int level, bool isNPC)
		{
			return null;
		}

		[Token(Token = "0x60022DC")]
		[Address(RVA = "0xB3D234", Offset = "0xB3D234", VA = "0xB3D234")]
		public void Final()
		{
		}
	}

	[Token(Token = "0x2000449")]
	public class CreationDesc
	{
		[Token(Token = "0x200044A")]
		public class CharDesc
		{
			[Token(Token = "0x400151E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string uid;

			[Token(Token = "0x400151F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int charId;

			[Token(Token = "0x4001520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int level;

			[Token(Token = "0x4001521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public SkillSpecialized specialized_skill_list;

			[Token(Token = "0x4001522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Netdata_EquipedItem[] equiped_items;

			[Token(Token = "0x4001523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int usedSP;

			[Token(Token = "0x4001524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int skinId;

			[Token(Token = "0x60022E9")]
			[Address(RVA = "0xB3E668", Offset = "0xB3E668", VA = "0xB3E668")]
			public CharDesc()
			{
			}

			[Token(Token = "0x60022EA")]
			[Address(RVA = "0xB3F0EC", Offset = "0xB3F0EC", VA = "0xB3F0EC")]
			public CharDesc(CharDesc other)
			{
			}

			[Token(Token = "0x60022EB")]
			[Address(RVA = "0xB3F234", Offset = "0xB3F234", VA = "0xB3F234")]
			public CharDesc(int charId)
			{
			}

			[Token(Token = "0x60022EC")]
			[Address(RVA = "0xB34960", Offset = "0xB34960", VA = "0xB34960")]
			public Netdata_CreationDesc.CharDesc ToNetData()
			{
				return null;
			}

			[Token(Token = "0x60022ED")]
			[Address(RVA = "0xB3F020", Offset = "0xB3F020", VA = "0xB3F020")]
			public static CharDesc FromNetData(Netdata_CreationDesc.CharDesc desc)
			{
				return null;
			}
		}

		[Token(Token = "0x4001510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool isNPC;

		[Token(Token = "0x4001511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool isBalanceRegulate;

		[Token(Token = "0x4001512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public bool isPVP;

		[Token(Token = "0x4001513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int relicId;

		[Token(Token = "0x4001514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int relicLevel;

		[Token(Token = "0x4001515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int charIndex;

		[Token(Token = "0x4001516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int usedSP;

		[Token(Token = "0x4001517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int emblemID;

		[Token(Token = "0x4001518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isShowed;

		[Token(Token = "0x4001519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Dictionary<int, int> talentSkillPage;

		[Token(Token = "0x400151A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<int, CharDesc> List;

		[Token(Token = "0x400151B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public List<int> orderCharIDList;

		[Token(Token = "0x400151C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PetIsNotShowed;

		[Token(Token = "0x400151D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CharDesc petDesc;

		[Token(Token = "0x170005EE")]
		public CharDesc DefaultChar
		{
			[Token(Token = "0x60022E4")]
			[Address(RVA = "0xB34890", Offset = "0xB34890", VA = "0xB34890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EF")]
		public CharDesc IndexedChar
		{
			[Token(Token = "0x60022E5")]
			[Address(RVA = "0xB3EA1C", Offset = "0xB3EA1C", VA = "0xB3EA1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022DD")]
		[Address(RVA = "0xB3E200", Offset = "0xB3E200", VA = "0xB3E200")]
		public CreationDesc(string uid, int charId, int skinId, int level)
		{
		}

		[Token(Token = "0x60022DE")]
		[Address(RVA = "0xB3E468", Offset = "0xB3E468", VA = "0xB3E468")]
		public CreationDesc(int charId, int level)
		{
		}

		[Token(Token = "0x60022DF")]
		[Address(RVA = "0xB3E554", Offset = "0xB3E554", VA = "0xB3E554")]
		public CreationDesc(int charId, int level, Netdata_EquipedItem[] equipedItem)
		{
		}

		[Token(Token = "0x60022E0")]
		[Address(RVA = "0xB3E624", Offset = "0xB3E624", VA = "0xB3E624")]
		public CreationDesc(int charId, int skinId, int level)
		{
		}

		[Token(Token = "0x60022E1")]
		[Address(RVA = "0xB3E248", Offset = "0xB3E248", VA = "0xB3E248")]
		public CreationDesc(bool isNPC, string uid, int charId, int skinId, int level, SkillSpecialized specialized_skill_list, Netdata_EquipedItem[] equiped_items, int usedSP, bool isPVP = false, int charIndex = 0)
		{
		}

		[Token(Token = "0x60022E2")]
		[Address(RVA = "0xB3E764", Offset = "0xB3E764", VA = "0xB3E764")]
		public CreationDesc(bool BalanceRegulate, bool isPVP, int relicId, int relicLevel, Dictionary<int, int> talentSkillPage, Dictionary<int, CharDesc> charDesc, List<int> orderCharIDList, int charIndex = 0, int emblemID = -1)
		{
		}

		[Token(Token = "0x60022E3")]
		[Address(RVA = "0xB3E8B8", Offset = "0xB3E8B8", VA = "0xB3E8B8")]
		public CreationDesc(bool BalanceRegulate, bool isPVP, int relicId, int relicLevel, Dictionary<int, int> talentSkillPage, Dictionary<int, CharDesc> charDesc, List<int> orderCharIDList, CharDesc petDesc, bool petIsNotShowed, int charIndex = 0, int emblemID = -1)
		{
		}

		[Token(Token = "0x60022E6")]
		[Address(RVA = "0xB38658", Offset = "0xB38658", VA = "0xB38658")]
		public CharDesc FindChar(int charIndex)
		{
			return null;
		}

		[Token(Token = "0x60022E7")]
		[Address(RVA = "0xB3EAEC", Offset = "0xB3EAEC", VA = "0xB3EAEC")]
		public Netdata_CreationDesc ToNetData()
		{
			return null;
		}

		[Token(Token = "0x60022E8")]
		[Address(RVA = "0xB3EDC0", Offset = "0xB3EDC0", VA = "0xB3EDC0")]
		public static CreationDesc FromNetData(Netdata_CreationDesc desc, bool isTag = true)
		{
			return null;
		}
	}

	[Token(Token = "0x200044B")]
	public class EquipSlots
	{
		[Token(Token = "0x4001525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool m_isPVP;

		[Token(Token = "0x4001526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private bool m_isBalanceRegulate;

		[Token(Token = "0x4001527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int m_equipSlotCount;

		[Token(Token = "0x4001528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CharacterStatus m_owner;

		[Token(Token = "0x4001529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private XItem[] m_EquipItemList;

		[Token(Token = "0x170005F0")]
		public XItem[] EquipItemList
		{
			[Token(Token = "0x60022EF")]
			[Address(RVA = "0xB388F8", Offset = "0xB388F8", VA = "0xB388F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60022EE")]
		[Address(RVA = "0xB3D318", Offset = "0xB3D318", VA = "0xB3D318")]
		public EquipSlots(bool isBalanceRegulate, bool isPVP, CharacterStatus owner)
		{
		}

		[Token(Token = "0x60022F0")]
		[Address(RVA = "0xB3D408", Offset = "0xB3D408", VA = "0xB3D408")]
		public void EquipAll(Netdata_EquipedItem[] equiped_item)
		{
		}

		[Token(Token = "0x60022F1")]
		[Address(RVA = "0xB3F808", Offset = "0xB3F808", VA = "0xB3F808")]
		private void Equip(XItem itemEquipment)
		{
		}

		[Token(Token = "0x60022F2")]
		[Address(RVA = "0xB3F8D8", Offset = "0xB3F8D8", VA = "0xB3F8D8")]
		private void Unequip(EquipmentSlot nSlotType)
		{
		}

		[Token(Token = "0x60022F3")]
		[Address(RVA = "0xB3F978", Offset = "0xB3F978", VA = "0xB3F978")]
		public XItem GetEquipmentItem(EquipmentSlot nSlotType)
		{
			return null;
		}

		[Token(Token = "0x60022F4")]
		[Address(RVA = "0xB3FA40", Offset = "0xB3FA40", VA = "0xB3FA40")]
		public XItem GetEquipmentItem(string iid)
		{
			return null;
		}

		[Token(Token = "0x60022F5")]
		[Address(RVA = "0xB3FB64", Offset = "0xB3FB64", VA = "0xB3FB64")]
		public Netdata_EquipedItem[] ToNetData()
		{
			return null;
		}

		[Token(Token = "0x60022F6")]
		[Address(RVA = "0xB3F350", Offset = "0xB3F350", VA = "0xB3F350")]
		private List<XItem> ToXitems(Netdata_EquipedItem[] equipedItems)
		{
			return null;
		}

		[Token(Token = "0x60022F7")]
		[Address(RVA = "0xB3D650", Offset = "0xB3D650", VA = "0xB3D650")]
		public CharStatus GetItemStatus()
		{
			return null;
		}

		[Token(Token = "0x60022F8")]
		[Address(RVA = "0xB404F4", Offset = "0xB404F4", VA = "0xB404F4")]
		public void ApplyEquipItemStatus(CharStatus status)
		{
		}

		[Token(Token = "0x60022F9")]
		[Address(RVA = "0xB3FCFC", Offset = "0xB3FCFC", VA = "0xB3FCFC")]
		private void ApplySetItemBuffStatus(CharStatus status)
		{
		}
	}

	[Token(Token = "0x40014D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isNeedShowingOpenTime;

	[Token(Token = "0x40014DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool isHaveOpenTime;

	[Token(Token = "0x40014DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int charId1;

	[Token(Token = "0x40014DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int charId2;

	[Token(Token = "0x40014DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private ObscuredFloat m_nShield;

	[Token(Token = "0x40014DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ObscuredFloat m_finalMaxShield;

	[Token(Token = "0x40014DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ObscuredFloat m_nHP;

	[Token(Token = "0x40014E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CharacterInfoMaster m_CharacterInfoMaster;

	[Token(Token = "0x40014E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isFirstUpdated;

	[Token(Token = "0x40014E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_ATID;

	[Token(Token = "0x40014E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool m_bReady;

	[Token(Token = "0x40014E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private CharStatus m_status;

	[Token(Token = "0x40014E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float SightRange;

	[Token(Token = "0x40014E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float RotationSpeed;

	[Token(Token = "0x40014E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public List<XShieldBuff> ShieldBuffList;

	[Token(Token = "0x40014E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private CharStatus m_talentStatus;

	[Token(Token = "0x40014E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int m_selectedRelicSkillId;

	[Token(Token = "0x40014EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> m_itemPassiveSkillList;

	[Token(Token = "0x40014EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool m_isBalanceRegulate;

	[Token(Token = "0x40014EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	public bool m_isTutorialAIBalanceRegulate;

	[Token(Token = "0x40014ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int m_balanceTalentID;

	[Token(Token = "0x40014EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float m_physicalAtkPower_Stat;

	[Token(Token = "0x40014EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float m_magicalAtkPower_Stat;

	[Token(Token = "0x40014F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float m_physicalDefPower_Stat;

	[Token(Token = "0x40014F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float m_magicalDefPower_Stat;

	[Token(Token = "0x40014F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float m_fightingPower_Stat;

	[Token(Token = "0x40014F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_fightingPower_Skill;

	[Token(Token = "0x40014F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public Action OnDestroyNotification;

	[Token(Token = "0x40014F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float TagCool;

	[Token(Token = "0x40014F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float m_tagCoolTime;

	[Token(Token = "0x40014F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Dictionary<int, bool> autoTargetingSetup;

	[Token(Token = "0x40014F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Action<ModuleEventArgument_Hit> m_onHitMe;

	[Token(Token = "0x40014F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Action<int> m_onSkillStart;

	[Token(Token = "0x40014FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Action<int> m_onSkillFinish;

	[Token(Token = "0x40014FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool Initialized__BackingField;

	[Token(Token = "0x40014FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private string UserName__BackingField;

	[Token(Token = "0x17000599")]
	public int ATID
	{
		[Token(Token = "0x6002243")]
		[Address(RVA = "0xB34C84", Offset = "0xB34C84", VA = "0xB34C84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700059A")]
	public bool IsReady
	{
		[Token(Token = "0x6002244")]
		[Address(RVA = "0xB34C8C", Offset = "0xB34C8C", VA = "0xB34C8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700059B")]
	public bool Initialized
	{
		[Token(Token = "0x6002245")]
		[Address(RVA = "0xB34C94", Offset = "0xB34C94", VA = "0xB34C94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002246")]
		[Address(RVA = "0xB34C9C", Offset = "0xB34C9C", VA = "0xB34C9C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700059C")]
	public string UID
	{
		[Token(Token = "0x6002247")]
		[Address(RVA = "0xB34A28", Offset = "0xB34A28", VA = "0xB34A28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059D")]
	public CharacterStatus OriginalStatus
	{
		[Token(Token = "0x6002248")]
		[Address(RVA = "0xB34CA4", Offset = "0xB34CA4", VA = "0xB34CA4", Slot = "59")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059E")]
	public CSCharacterInfo CharacterInfo
	{
		[Token(Token = "0x6002249")]
		[Address(RVA = "0xB33F2C", Offset = "0xB33F2C", VA = "0xB33F2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059F")]
	public CSCharacterInfo ChangeModelStatusInfo
	{
		[Token(Token = "0x600224A")]
		[Address(RVA = "0xB34D08", Offset = "0xB34D08", VA = "0xB34D08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A0")]
	public CSCharacterInfo SkillInfo
	{
		[Token(Token = "0x600224B")]
		[Address(RVA = "0xB34D34", Offset = "0xB34D34", VA = "0xB34D34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A1")]
	public CharacterInfoMaster InfoMaster
	{
		[Token(Token = "0x600224C")]
		[Address(RVA = "0xB34D9C", Offset = "0xB34D9C", VA = "0xB34D9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A2")]
	public SkinInfo SkinInfo
	{
		[Token(Token = "0x600224D")]
		[Address(RVA = "0xB34DA4", Offset = "0xB34DA4", VA = "0xB34DA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A3")]
	public int Grade
	{
		[Token(Token = "0x600224E")]
		[Address(RVA = "0xB34A84", Offset = "0xB34A84", VA = "0xB34A84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005A4")]
	public int UsedSP
	{
		[Token(Token = "0x600224F")]
		[Address(RVA = "0xB34B24", Offset = "0xB34B24", VA = "0xB34B24")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005A5")]
	public int Level
	{
		[Token(Token = "0x6002250")]
		[Address(RVA = "0xB34AA8", Offset = "0xB34AA8", VA = "0xB34AA8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005A6")]
	public int CharID
	{
		[Token(Token = "0x6002251")]
		[Address(RVA = "0xB34A60", Offset = "0xB34A60", VA = "0xB34A60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005A7")]
	public string Name
	{
		[Token(Token = "0x6002252")]
		[Address(RVA = "0xB34EB0", Offset = "0xB34EB0", VA = "0xB34EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A8")]
	public string UserName
	{
		[Token(Token = "0x6002253")]
		[Address(RVA = "0xB34ED4", Offset = "0xB34ED4", VA = "0xB34ED4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002254")]
		[Address(RVA = "0xB34EDC", Offset = "0xB34EDC", VA = "0xB34EDC")]
		set
		{
		}
	}

	[Token(Token = "0x170005A9")]
	public int SkinID
	{
		[Token(Token = "0x6002255")]
		[Address(RVA = "0xB34AD8", Offset = "0xB34AD8", VA = "0xB34AD8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005AA")]
	public CharStatus Status
	{
		[Token(Token = "0x6002256")]
		[Address(RVA = "0xB33C88", Offset = "0xB33C88", VA = "0xB33C88", Slot = "60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AB")]
	public CreationDesc CreationDescription
	{
		[Token(Token = "0x6002257")]
		[Address(RVA = "0xB3486C", Offset = "0xB3486C", VA = "0xB3486C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AC")]
	public bool IsLocalNPC
	{
		[Token(Token = "0x6002258")]
		[Address(RVA = "0xB34EE4", Offset = "0xB34EE4", VA = "0xB34EE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005AD")]
	public bool IsPlayer
	{
		[Token(Token = "0x6002259")]
		[Address(RVA = "0xB34F40", Offset = "0xB34F40", VA = "0xB34F40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005AE")]
	public float Shield
	{
		[Token(Token = "0x600225A")]
		[Address(RVA = "0xB34F7C", Offset = "0xB34F7C", VA = "0xB34F7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600225B")]
		[Address(RVA = "0xB35054", Offset = "0xB35054", VA = "0xB35054")]
		set
		{
		}
	}

	[Token(Token = "0x170005AF")]
	public float FinalMaxShield
	{
		[Token(Token = "0x600225C")]
		[Address(RVA = "0xB351A4", Offset = "0xB351A4", VA = "0xB351A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B0")]
	public float CurrentHPPercent
	{
		[Token(Token = "0x600225D")]
		[Address(RVA = "0xB3527C", Offset = "0xB3527C", VA = "0xB3527C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B1")]
	public float HP
	{
		[Token(Token = "0x600225E")]
		[Address(RVA = "0xB352E0", Offset = "0xB352E0", VA = "0xB352E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600225F")]
		[Address(RVA = "0xB35400", Offset = "0xB35400", VA = "0xB35400")]
		set
		{
		}
	}

	[Token(Token = "0x170005B2")]
	public float RoamingSpeed
	{
		[Token(Token = "0x6002260")]
		[Address(RVA = "0xB35538", Offset = "0xB35538", VA = "0xB35538")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B3")]
	public float MaxHP
	{
		[Token(Token = "0x6002261")]
		[Address(RVA = "0xB3556C", Offset = "0xB3556C", VA = "0xB3556C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B4")]
	public float MaxHPPerLevel
	{
		[Token(Token = "0x6002262")]
		[Address(RVA = "0xB355A0", Offset = "0xB355A0", VA = "0xB355A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B5")]
	public float FinalMaxHP
	{
		[Token(Token = "0x6002263")]
		[Address(RVA = "0xB353B8", Offset = "0xB353B8", VA = "0xB353B8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B6")]
	public float PhysicalDamage
	{
		[Token(Token = "0x6002264")]
		[Address(RVA = "0xB355D4", Offset = "0xB355D4", VA = "0xB355D4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B7")]
	public float PhysicalDefense
	{
		[Token(Token = "0x6002265")]
		[Address(RVA = "0xB35608", Offset = "0xB35608", VA = "0xB35608")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B8")]
	public float PhysicalDefense_Fix
	{
		[Token(Token = "0x6002266")]
		[Address(RVA = "0xB3563C", Offset = "0xB3563C", VA = "0xB3563C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B9")]
	public float PhysicalPenetration
	{
		[Token(Token = "0x6002267")]
		[Address(RVA = "0xB35670", Offset = "0xB35670", VA = "0xB35670")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BA")]
	public float MagicalDamage
	{
		[Token(Token = "0x6002268")]
		[Address(RVA = "0xB356A4", Offset = "0xB356A4", VA = "0xB356A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BB")]
	public float MagicalDefense
	{
		[Token(Token = "0x6002269")]
		[Address(RVA = "0xB356D8", Offset = "0xB356D8", VA = "0xB356D8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BC")]
	public float MagicalDefense_Fix
	{
		[Token(Token = "0x600226A")]
		[Address(RVA = "0xB3570C", Offset = "0xB3570C", VA = "0xB3570C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BD")]
	public float MagicalPenetration
	{
		[Token(Token = "0x600226B")]
		[Address(RVA = "0xB35740", Offset = "0xB35740", VA = "0xB35740")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BE")]
	public float PhysicalDrain
	{
		[Token(Token = "0x600226C")]
		[Address(RVA = "0xB35774", Offset = "0xB35774", VA = "0xB35774")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005BF")]
	public float MagicalDrain
	{
		[Token(Token = "0x600226D")]
		[Address(RVA = "0xB357A8", Offset = "0xB357A8", VA = "0xB357A8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C0")]
	public float Critical
	{
		[Token(Token = "0x600226E")]
		[Address(RVA = "0xB357DC", Offset = "0xB357DC", VA = "0xB357DC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C1")]
	public float CriticalDamage
	{
		[Token(Token = "0x600226F")]
		[Address(RVA = "0xB35810", Offset = "0xB35810", VA = "0xB35810")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C2")]
	public float CriticalDamageDefense
	{
		[Token(Token = "0x6002270")]
		[Address(RVA = "0xB35844", Offset = "0xB35844", VA = "0xB35844")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C3")]
	public float Flexibility
	{
		[Token(Token = "0x6002271")]
		[Address(RVA = "0xB35878", Offset = "0xB35878", VA = "0xB35878")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C4")]
	public float Agility
	{
		[Token(Token = "0x6002272")]
		[Address(RVA = "0xB358AC", Offset = "0xB358AC", VA = "0xB358AC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C5")]
	public float Accuracy
	{
		[Token(Token = "0x6002273")]
		[Address(RVA = "0xB358E0", Offset = "0xB358E0", VA = "0xB358E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C6")]
	public float AtkSpeed
	{
		[Token(Token = "0x6002274")]
		[Address(RVA = "0xB35914", Offset = "0xB35914", VA = "0xB35914")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C7")]
	public float MovingSpeed
	{
		[Token(Token = "0x6002275")]
		[Address(RVA = "0xB3591C", Offset = "0xB3591C", VA = "0xB3591C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C8")]
	public float SlowResist
	{
		[Token(Token = "0x6002276")]
		[Address(RVA = "0xB35A1C", Offset = "0xB35A1C", VA = "0xB35A1C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005C9")]
	public float UltimateMaxCharge
	{
		[Token(Token = "0x6002277")]
		[Address(RVA = "0xB35A50", Offset = "0xB35A50", VA = "0xB35A50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005CA")]
	public float TagCooltimeReduction
	{
		[Token(Token = "0x6002278")]
		[Address(RVA = "0xB35A84", Offset = "0xB35A84", VA = "0xB35A84")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005CB")]
	public float SkillCoolTimeReduction
	{
		[Token(Token = "0x6002279")]
		[Address(RVA = "0xB35AB8", Offset = "0xB35AB8", VA = "0xB35AB8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005CC")]
	public float DodgeSkillCoolTimeReduction
	{
		[Token(Token = "0x600227A")]
		[Address(RVA = "0xB35AEC", Offset = "0xB35AEC", VA = "0xB35AEC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005CD")]
	public float RelicSkillCoolTimeReduction
	{
		[Token(Token = "0x600227B")]
		[Address(RVA = "0xB35B20", Offset = "0xB35B20", VA = "0xB35B20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005CE")]
	public float AmplyDamageOnDeathsDoor
	{
		[Token(Token = "0x600227C")]
		[Address(RVA = "0xB35B54", Offset = "0xB35B54", VA = "0xB35B54")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005CF")]
	public float AmplyDefenseOnDeathsDoor
	{
		[Token(Token = "0x600227D")]
		[Address(RVA = "0xB35B88", Offset = "0xB35B88", VA = "0xB35B88")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005D0")]
	public float DrainOnDeathsDoor
	{
		[Token(Token = "0x600227E")]
		[Address(RVA = "0xB35BBC", Offset = "0xB35BBC", VA = "0xB35BBC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005D1")]
	public CharStatus TalentStatus
	{
		[Token(Token = "0x600227F")]
		[Address(RVA = "0xB35BF0", Offset = "0xB35BF0", VA = "0xB35BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D2")]
	public int SelectedRelicSkillId
	{
		[Token(Token = "0x6002280")]
		[Address(RVA = "0xB35BF8", Offset = "0xB35BF8", VA = "0xB35BF8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005D3")]
	public List<int> ItemPassiveSkillList
	{
		[Token(Token = "0x6002281")]
		[Address(RVA = "0xB35C00", Offset = "0xB35C00", VA = "0xB35C00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D4")]
	public float TagRemainCoolTime
	{
		[Token(Token = "0x6002291")]
		[Address(RVA = "0xB38A18", Offset = "0xB38A18", VA = "0xB38A18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002240")]
	[Address(RVA = "0xB3453C", Offset = "0xB3453C", VA = "0xB3453C")]
	public XModuleActor()
	{
	}

	[Token(Token = "0x6002241")]
	[Address(RVA = "0xB34704", Offset = "0xB34704", VA = "0xB34704")]
	public Netdata_Char ToNetDataChar()
	{
		return null;
	}

	[Token(Token = "0x6002242")]
	[Address(RVA = "0xB34B54", Offset = "0xB34B54", VA = "0xB34B54")]
	public Netdata_Pet ToNetDataPet()
	{
		return null;
	}

	[Token(Token = "0x6002282")]
	[Address(RVA = "0xB35C08", Offset = "0xB35C08", VA = "0xB35C08")]
	public void RefreshStatus()
	{
	}

	[Token(Token = "0x6002283")]
	[Address(RVA = "0xB365EC", Offset = "0xB365EC", VA = "0xB365EC")]
	private void MergeBalanceTalentStatus()
	{
	}

	[Token(Token = "0x6002284")]
	[Address(RVA = "0xB368F8", Offset = "0xB368F8", VA = "0xB368F8")]
	private void CharStatusBalanceRegulate()
	{
	}

	[Token(Token = "0x6002285")]
	[Address(RVA = "0xB36D98", Offset = "0xB36D98", VA = "0xB36D98")]
	private void CharStatusBalanceApply(float pDamange, float mDatamge, float pDefFix, float mDefFix, float maxHP)
	{
	}

	[Token(Token = "0x6002286")]
	[Address(RVA = "0xB36A1C", Offset = "0xB36A1C", VA = "0xB36A1C")]
	private void CharStatusBalanceForAITutorial()
	{
	}

	[Token(Token = "0x6002287")]
	[Address(RVA = "0xB36E64", Offset = "0xB36E64", VA = "0xB36E64")]
	public void RefreshStatusWithHP()
	{
	}

	[Token(Token = "0x6002288")]
	[Address(RVA = "0xB36EDC", Offset = "0xB36EDC", VA = "0xB36EDC")]
	public int CalcFightingPower_Stat()
	{
		return default(int);
	}

	[Token(Token = "0x6002289")]
	[Address(RVA = "0xB37144", Offset = "0xB37144", VA = "0xB37144")]
	public int CalcFightingPower_Skill()
	{
		return default(int);
	}

	[Token(Token = "0x600228A")]
	[Address(RVA = "0xB37350", Offset = "0xB37350", VA = "0xB37350")]
	public int CalcFightingPower()
	{
		return default(int);
	}

	[Token(Token = "0x600228B")]
	[Address(RVA = "0xB37374", Offset = "0xB37374", VA = "0xB37374", Slot = "17")]
	public override void OnActorInit(CreationDesc desc)
	{
	}

	[Token(Token = "0x600228C")]
	[Address(RVA = "0xB37A00", Offset = "0xB37A00", VA = "0xB37A00")]
	private int GetSelectRelicSkillID(int selectRelicID, int selectRelicLevel)
	{
		return default(int);
	}

	[Token(Token = "0x600228D")]
	[Address(RVA = "0xB3849C", Offset = "0xB3849C", VA = "0xB3849C")]
	private void CreateItemPassiveSkillList()
	{
	}

	[Token(Token = "0x600228E")]
	[Address(RVA = "0xB37DA4", Offset = "0xB37DA4", VA = "0xB37DA4")]
	public void CreateTalentStatus(Dictionary<int, int> talentSkillPage)
	{
	}

	[Token(Token = "0x600228F")]
	[Address(RVA = "0xB38900", Offset = "0xB38900", VA = "0xB38900")]
	private void CreateItemPassiveSkill()
	{
	}

	[Token(Token = "0x6002290")]
	[Address(RVA = "0xB38904", Offset = "0xB38904", VA = "0xB38904", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x6002292")]
	[Address(RVA = "0xB38AE8", Offset = "0xB38AE8", VA = "0xB38AE8")]
	public void Tag()
	{
	}

	[Token(Token = "0x6002293")]
	[Address(RVA = "0xB38778", Offset = "0xB38778", VA = "0xB38778")]
	private void SetTagCool()
	{
	}

	[Token(Token = "0x6002294")]
	[Address(RVA = "0xB38B90", Offset = "0xB38B90", VA = "0xB38B90")]
	public void _ActorTag()
	{
	}

	[Token(Token = "0x6002295")]
	[Address(RVA = "0xB394FC", Offset = "0xB394FC", VA = "0xB394FC")]
	public void TagWithoutTagSkill()
	{
	}

	[Token(Token = "0x6002296")]
	[Address(RVA = "0xB39560", Offset = "0xB39560", VA = "0xB39560")]
	public void ActorTagWithoutTagSkill()
	{
	}

	[Token(Token = "0x6002297")]
	[Address(RVA = "0xB397A4", Offset = "0xB397A4", VA = "0xB397A4")]
	public void SetOrderList(List<int> orderList, int orderIndex)
	{
	}

	[Token(Token = "0x6002298")]
	[Address(RVA = "0xB39ACC", Offset = "0xB39ACC", VA = "0xB39ACC", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x6002299")]
	[Address(RVA = "0xB39C68", Offset = "0xB39C68", VA = "0xB39C68")]
	private void RefreshCurrShield()
	{
	}

	[Token(Token = "0x600229A")]
	[Address(RVA = "0xB39F04", Offset = "0xB39F04", VA = "0xB39F04")]
	public int CalcShieldDamage(int damage)
	{
		return default(int);
	}

	[Token(Token = "0x600229B")]
	[Address(RVA = "0xB3A3CC", Offset = "0xB3A3CC", VA = "0xB3A3CC")]
	public void DeleteShiled(int buffID)
	{
	}

	[Token(Token = "0x600229C")]
	[Address(RVA = "0xB3A64C", Offset = "0xB3A64C", VA = "0xB3A64C", Slot = "25")]
	public override void OnGainBuff(XBuff buff)
	{
	}

	[Token(Token = "0x600229D")]
	[Address(RVA = "0xB3A670", Offset = "0xB3A670", VA = "0xB3A670")]
	private void GainShieldBuff(XBuff buff)
	{
	}

	[Token(Token = "0x600229E")]
	[Address(RVA = "0xB3AA70", Offset = "0xB3AA70", VA = "0xB3AA70")]
	private void LostShieldBuff(XBuff buff)
	{
	}

	[Token(Token = "0x600229F")]
	[Address(RVA = "0xB3AC70", Offset = "0xB3AC70", VA = "0xB3AC70", Slot = "28")]
	public override void OnLostBuff(XBuff buff)
	{
	}

	[Token(Token = "0x60022A0")]
	[Address(RVA = "0xB3AC94", Offset = "0xB3AC94", VA = "0xB3AC94")]
	public Netdata_XShieldBuff ToNetData_XShieldBuff()
	{
		return null;
	}

	[Token(Token = "0x60022A1")]
	[Address(RVA = "0xB3AE10", Offset = "0xB3AE10", VA = "0xB3AE10")]
	public void SyncShieldBuff(Netdata_XShieldBuff shieldBuffData)
	{
	}

	[Token(Token = "0x60022A2")]
	[Address(RVA = "0xB3AE3C", Offset = "0xB3AE3C", VA = "0xB3AE3C", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x60022A3")]
	[Address(RVA = "0xB3AE40", Offset = "0xB3AE40", VA = "0xB3AE40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60022A4")]
	[Address(RVA = "0xB388A0", Offset = "0xB388A0", VA = "0xB388A0")]
	public void SetFullHP(bool bMaxHPExactly = false)
	{
	}

	[Token(Token = "0x60022A5")]
	[Address(RVA = "0xB3B1F8", Offset = "0xB3B1F8", VA = "0xB3B1F8", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60022A6")]
	[Address(RVA = "0xB3B6CC", Offset = "0xB3B6CC", VA = "0xB3B6CC")]
	public XModuleEntity GetTarget(CSSkillInfo skillInfo)
	{
		return null;
	}

	[Token(Token = "0x60022A7")]
	[Address(RVA = "0xB3B888", Offset = "0xB3B888", VA = "0xB3B888")]
	public bool IsEnableSkill(int nSkillID)
	{
		return default(bool);
	}

	[Token(Token = "0x60022A8")]
	[Address(RVA = "0xB3B8C0", Offset = "0xB3B8C0", VA = "0xB3B8C0")]
	private bool CheckEnableCharacterSkill(int nSkillID)
	{
		return default(bool);
	}

	[Token(Token = "0x60022A9")]
	[Address(RVA = "0xB3BA04", Offset = "0xB3BA04", VA = "0xB3BA04", Slot = "61")]
	public bool IsDeathDoor()
	{
		return default(bool);
	}

	[Token(Token = "0x60022AA")]
	[Address(RVA = "0xB3B9F0", Offset = "0xB3B9F0", VA = "0xB3B9F0")]
	private bool CheckEnableRelicSkill(int nSkillID)
	{
		return default(bool);
	}

	[Token(Token = "0x60022AB")]
	[Address(RVA = "0xB3BB3C", Offset = "0xB3BB3C", VA = "0xB3BB3C")]
	public void RegisterOnHitMeReciver(Action<ModuleEventArgument_Hit> reciever)
	{
	}

	[Token(Token = "0x60022AC")]
	[Address(RVA = "0xB3BB44", Offset = "0xB3BB44", VA = "0xB3BB44", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60022AD")]
	[Address(RVA = "0xB3BBD8", Offset = "0xB3BBD8", VA = "0xB3BBD8", Slot = "51")]
	public override void OnStartUlitmateCinema(int skillID)
	{
	}

	[Token(Token = "0x60022AE")]
	[Address(RVA = "0xB3BC6C", Offset = "0xB3BC6C", VA = "0xB3BC6C", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x60022AF")]
	[Address(RVA = "0xB3BD2C", Offset = "0xB3BD2C", VA = "0xB3BD2C")]
	public void RegisterOnSkillStartReciver(Action<int> reciever)
	{
	}

	[Token(Token = "0x60022B0")]
	[Address(RVA = "0xB3BD34", Offset = "0xB3BD34", VA = "0xB3BD34")]
	public void RegisterOnSkillFinishReciver(Action<int> reciever)
	{
	}

	[Token(Token = "0x60022B1")]
	[Address(RVA = "0xB3BD3C", Offset = "0xB3BD3C", VA = "0xB3BD3C", Slot = "30")]
	public override void OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x60022B2")]
	[Address(RVA = "0xB3BDFC", Offset = "0xB3BDFC", VA = "0xB3BDFC", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60022B3")]
	[Address(RVA = "0xB3BE24", Offset = "0xB3BE24", VA = "0xB3BE24")]
	public void PlayBattleStartSound([Optional] XModuleActor myTeamPlayerActor)
	{
	}

	[Token(Token = "0x60022B4")]
	[Address(RVA = "0xB3C1D8", Offset = "0xB3C1D8", VA = "0xB3C1D8")]
	public void PlayInventoryEnterSound()
	{
	}

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0xB3C448", Offset = "0xB3C448", VA = "0xB3C448")]
	public void PlayPartyJoinSound()
	{
	}
}
