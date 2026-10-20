using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DC6")]
public class XPanel_CharSkill : MonoBehaviour
{
	[Token(Token = "0x2000DC7")]
	private class SkillUpChecker
	{
		[Token(Token = "0x6006592")]
		[Address(RVA = "0x16A3194", Offset = "0x16A3194", VA = "0x16A3194")]
		public SkillUpChecker()
		{
		}

		[Token(Token = "0x6006593")]
		[Address(RVA = "0x16A5734", Offset = "0x16A5734", VA = "0x16A5734")]
		public bool IsLock(XModuleActor character, CSCharacterSkillInfo charSkillInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6006594")]
		[Address(RVA = "0x16A5788", Offset = "0x16A5788", VA = "0x16A5788")]
		public bool IsTagSkillable(CSCharacterSkillInfo m_charSkillInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6006595")]
		[Address(RVA = "0x16A67A8", Offset = "0x16A67A8", VA = "0x16A67A8")]
		public bool CanSetAutoTargeting(CSCharacterSkillInfo m_charSkillInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6006596")]
		[Address(RVA = "0x16A54E0", Offset = "0x16A54E0", VA = "0x16A54E0")]
		public int CalcUsedPoint(XModuleActor character, CSCharacterSkillInfo charSkillInfo)
		{
			return default(int);
		}

		[Token(Token = "0x6006597")]
		[Address(RVA = "0x16A87B4", Offset = "0x16A87B4", VA = "0x16A87B4")]
		public int GetSpecializationLevel(XModuleActor character, CSCharacterSkillInfo charSkillInfo, int specializationID)
		{
			return default(int);
		}

		[Token(Token = "0x6006598")]
		[Address(RVA = "0x16A88F4", Offset = "0x16A88F4", VA = "0x16A88F4")]
		public SkillSpecializationInfo[] GetSpecializationGrowthArray(XModuleActor character, CSCharacterSkillInfo charSkillInfo)
		{
			return null;
		}
	}

	[Token(Token = "0x2000DC8")]
	private sealed class _003CBuildSkillItem_003Ec__AnonStorey1BF
	{
		[Token(Token = "0x40047BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XWidget_SkillItem skillItem;

		[Token(Token = "0x40047BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_CharSkill _003C_003Ef__this;

		[Token(Token = "0x6006599")]
		[Address(RVA = "0x16A54D8", Offset = "0x16A54D8", VA = "0x16A54D8")]
		public _003CBuildSkillItem_003Ec__AnonStorey1BF()
		{
		}

		[Token(Token = "0x600659A")]
		[Address(RVA = "0x16A7B3C", Offset = "0x16A7B3C", VA = "0x16A7B3C")]
		internal void _003C_003Em__34D()
		{
		}
	}

	[Token(Token = "0x2000DC9")]
	private sealed class _003CBuildSpecializationInfo_003Ec__AnonStorey1C0
	{
		[Token(Token = "0x40047BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XWidget_SkillSpecializationItem item;

		[Token(Token = "0x40047BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_CharSkill _003C_003Ef__this;

		[Token(Token = "0x600659B")]
		[Address(RVA = "0x16A626C", Offset = "0x16A626C", VA = "0x16A626C")]
		public _003CBuildSpecializationInfo_003Ec__AnonStorey1C0()
		{
		}

		[Token(Token = "0x600659C")]
		[Address(RVA = "0x16A7B6C", Offset = "0x16A7B6C", VA = "0x16A7B6C")]
		internal void _003C_003Em__34E()
		{
		}
	}

	[Token(Token = "0x2000DCA")]
	private sealed class _003COnClick_SkillInit_003Ec__AnonStorey1C1
	{
		[Token(Token = "0x40047C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int reqGold;

		[Token(Token = "0x40047C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_CharSkill _003C_003Ef__this;

		[Token(Token = "0x600659D")]
		[Address(RVA = "0x16A6BE8", Offset = "0x16A6BE8", VA = "0x16A6BE8")]
		public _003COnClick_SkillInit_003Ec__AnonStorey1C1()
		{
		}

		[Token(Token = "0x600659E")]
		[Address(RVA = "0x16A7B9C", Offset = "0x16A7B9C", VA = "0x16A7B9C")]
		internal void _003C_003Em__34F()
		{
		}

		[Token(Token = "0x600659F")]
		[Address(RVA = "0x16A7EF0", Offset = "0x16A7EF0", VA = "0x16A7EF0")]
		internal void _003C_003Em__354(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000DCB")]
	private sealed class _003CSetSkillTutorialObject_003Ec__AnonStorey1C2
	{
		[Token(Token = "0x2000DCC")]
		private sealed class _003CSetSkillTutorialObject_003Ec__AnonStorey1C3
		{
			[Token(Token = "0x40047C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int skillID;

			[Token(Token = "0x40047C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal _003CSetSkillTutorialObject_003Ec__AnonStorey1C2 _003C_003Ef__ref_0024450;

			[Token(Token = "0x60065A3")]
			[Address(RVA = "0x16A8770", Offset = "0x16A8770", VA = "0x16A8770")]
			public _003CSetSkillTutorialObject_003Ec__AnonStorey1C3()
			{
			}

			[Token(Token = "0x60065A4")]
			[Address(RVA = "0x16A8778", Offset = "0x16A8778", VA = "0x16A8778")]
			internal bool _003C_003Em__355(CSCharacterSkillInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40047C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string skill_1Key;

		[Token(Token = "0x40047C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string skill_2Key;

		[Token(Token = "0x40047C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_CharSkill _003C_003Ef__this;

		[Token(Token = "0x60065A0")]
		[Address(RVA = "0x16A76EC", Offset = "0x16A76EC", VA = "0x16A76EC")]
		public _003CSetSkillTutorialObject_003Ec__AnonStorey1C2()
		{
		}

		[Token(Token = "0x60065A1")]
		[Address(RVA = "0x16A8338", Offset = "0x16A8338", VA = "0x16A8338")]
		internal void _003C_003Em__352()
		{
		}

		[Token(Token = "0x60065A2")]
		[Address(RVA = "0x16A84D8", Offset = "0x16A84D8", VA = "0x16A84D8")]
		internal void _003C_003Em__353()
		{
		}
	}

	[Token(Token = "0x400479F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridSkill;

	[Token(Token = "0x40047A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridSpecialize;

	[Token(Token = "0x40047A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblSkillSpecializeTitle;

	[Token(Token = "0x40047A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblSkillName;

	[Token(Token = "0x40047A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblSkillDesc;

	[Token(Token = "0x40047A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblSkillSpecDesc;

	[Token(Token = "0x40047A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblSkillCoolTime;

	[Token(Token = "0x40047A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblSkillPoint;

	[Token(Token = "0x40047A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblDescNow;

	[Token(Token = "0x40047A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblDescNext;

	[Token(Token = "0x40047A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public XWidget_Button btnTagSkillRegister;

	[Token(Token = "0x40047AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XWidget_Button btnAutoTargetingSkillSet;

	[Token(Token = "0x40047AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public XWidget_Button btnSPInit;

	[Token(Token = "0x40047AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIScrollView scrollView;

	[Token(Token = "0x40047AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public XWidget_Button btnSkillUpgrade;

	[Token(Token = "0x40047AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string effectSoundKey;

	[Token(Token = "0x40047AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private XWidget_SkillSpecializationItem m_selectSpecializationItem;

	[Token(Token = "0x40047B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private XWidget_SkillItem m_selectSkillItem;

	[Token(Token = "0x40047B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XModuleActor m_character;

	[Token(Token = "0x40047B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XMakeDescription skillDesckMaker;

	[Token(Token = "0x40047B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private SkillUpChecker skillChecker;

	[Token(Token = "0x40047B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private XWidget_SkillItem[] skillItems;

	[Token(Token = "0x40047B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private XWidget_SkillSpecializationItem[] specializeSkills;

	[Token(Token = "0x40047B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int totalSP;

	[Token(Token = "0x40047B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Action skillSelectCallback;

	[Token(Token = "0x40047B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x40047B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float scrollOffsetY;

	[Token(Token = "0x40047BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject[] InvisibleObjectsInPreview;

	[Token(Token = "0x40047BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache1C;

	[Token(Token = "0x6006569")]
	[Address(RVA = "0x16A30C0", Offset = "0x16A30C0", VA = "0x16A30C0")]
	public XPanel_CharSkill()
	{
	}

	[Token(Token = "0x600656A")]
	[Address(RVA = "0x16A319C", Offset = "0x16A319C", VA = "0x16A319C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600656B")]
	[Address(RVA = "0x16A33A4", Offset = "0x16A33A4", VA = "0x16A33A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600656C")]
	[Address(RVA = "0x16A3414", Offset = "0x16A3414", VA = "0x16A3414")]
	public void RegistSkillSelectCallback(Action action)
	{
	}

	[Token(Token = "0x600656D")]
	[Address(RVA = "0x16A341C", Offset = "0x16A341C", VA = "0x16A341C")]
	public XWidget_SkillItem GetSkillItem(int skillID)
	{
		return null;
	}

	[Token(Token = "0x600656E")]
	[Address(RVA = "0x16A34B8", Offset = "0x16A34B8", VA = "0x16A34B8")]
	public XWidget_SkillSpecializationItem GetSpecializeItem(int idx)
	{
		return null;
	}

	[Token(Token = "0x600656F")]
	[Address(RVA = "0x16A34F8", Offset = "0x16A34F8", VA = "0x16A34F8")]
	public void Show(XModuleActor character)
	{
	}

	[Token(Token = "0x6006570")]
	[Address(RVA = "0x16A3D24", Offset = "0x16A3D24", VA = "0x16A3D24")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x6006571")]
	[Address(RVA = "0x16A425C", Offset = "0x16A425C", VA = "0x16A425C")]
	private void OnNetdataUpdated_Character(object arg)
	{
	}

	[Token(Token = "0x6006572")]
	[Address(RVA = "0x16A435C", Offset = "0x16A435C", VA = "0x16A435C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006573")]
	[Address(RVA = "0x16A3560", Offset = "0x16A3560", VA = "0x16A3560")]
	private void Build(XModuleActor character)
	{
	}

	[Token(Token = "0x6006574")]
	[Address(RVA = "0x16A4ED0", Offset = "0x16A4ED0", VA = "0x16A4ED0")]
	private bool IsCharacterNotOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x6006575")]
	[Address(RVA = "0x16A44F0", Offset = "0x16A44F0", VA = "0x16A44F0")]
	private void BuildSkillList()
	{
	}

	[Token(Token = "0x6006576")]
	[Address(RVA = "0x16A4F54", Offset = "0x16A4F54", VA = "0x16A4F54")]
	private void RefreshSkillList()
	{
	}

	[Token(Token = "0x6006577")]
	[Address(RVA = "0x16A52D0", Offset = "0x16A52D0", VA = "0x16A52D0")]
	private void BuildSkillItem(XWidget_SkillItem skillItem, [Optional] CSCharacterSkillInfo charSkillInfo, [Optional] bool? autoTargetingEnabled)
	{
	}

	[Token(Token = "0x6006578")]
	[Address(RVA = "0x16A5944", Offset = "0x16A5944", VA = "0x16A5944")]
	private void RefreshForTagIcon()
	{
	}

	[Token(Token = "0x6006579")]
	[Address(RVA = "0x16A5AB8", Offset = "0x16A5AB8", VA = "0x16A5AB8")]
	private void RefeshNextLvSpecializationItem(XWidget_SkillSpecializationItem specializationItem)
	{
	}

	[Token(Token = "0x600657A")]
	[Address(RVA = "0x16A4688", Offset = "0x16A4688", VA = "0x16A4688")]
	private void RefreshSkillSelect(XWidget_SkillItem skillItem)
	{
	}

	[Token(Token = "0x600657B")]
	[Address(RVA = "0x16A5D20", Offset = "0x16A5D20", VA = "0x16A5D20")]
	private void RefreshSpecializeSelect(XWidget_SkillSpecializationItem selectSpecializationItem)
	{
	}

	[Token(Token = "0x600657C")]
	[Address(RVA = "0x16A48DC", Offset = "0x16A48DC", VA = "0x16A48DC")]
	public void BuildSpecializationInfo(CSCharacterSkillInfo charSkillInfo)
	{
	}

	[Token(Token = "0x600657D")]
	[Address(RVA = "0x16A5AE4", Offset = "0x16A5AE4", VA = "0x16A5AE4")]
	private void BuildSkillDesc()
	{
	}

	[Token(Token = "0x600657E")]
	[Address(RVA = "0x16A6274", Offset = "0x16A6274", VA = "0x16A6274")]
	private void BuildSkillCoolTime(SkillSpecializationInfo[] upgradedSpecializationInfos)
	{
	}

	[Token(Token = "0x600657F")]
	[Address(RVA = "0x16A5F3C", Offset = "0x16A5F3C", VA = "0x16A5F3C")]
	private void BuildSpecialDesc()
	{
	}

	[Token(Token = "0x6006580")]
	[Address(RVA = "0x16A3E90", Offset = "0x16A3E90", VA = "0x16A3E90")]
	private void BuildButtons()
	{
	}

	[Token(Token = "0x6006581")]
	[Address(RVA = "0x16A6550", Offset = "0x16A6550", VA = "0x16A6550")]
	private void BuildAutoTargetingSetUpButton()
	{
	}

	[Token(Token = "0x6006582")]
	[Address(RVA = "0x16A3D40", Offset = "0x16A3D40", VA = "0x16A3D40")]
	private void BuildSPLabel()
	{
	}

	[Token(Token = "0x6006583")]
	[Address(RVA = "0x16A4390", Offset = "0x16A4390", VA = "0x16A4390")]
	private void RefreshTotalSP()
	{
	}

	[Token(Token = "0x6006584")]
	[Address(RVA = "0x16A6934", Offset = "0x16A6934", VA = "0x16A6934")]
	public void OnClick_SkillInit()
	{
	}

	[Token(Token = "0x6006585")]
	[Address(RVA = "0x16A6BF0", Offset = "0x16A6BF0", VA = "0x16A6BF0")]
	public void OnClick_SetTagSkill()
	{
	}

	[Token(Token = "0x6006586")]
	[Address(RVA = "0x16A7060", Offset = "0x16A7060", VA = "0x16A7060")]
	public void OnClick_AutoTargetingSet()
	{
	}

	[Token(Token = "0x6006587")]
	[Address(RVA = "0x16A67D8", Offset = "0x16A67D8", VA = "0x16A67D8")]
	private void SetAutoTargetButton(bool autoTargetEnabled)
	{
	}

	[Token(Token = "0x6006588")]
	[Address(RVA = "0x16A72A8", Offset = "0x16A72A8", VA = "0x16A72A8")]
	public void OnClick_Upgrade()
	{
	}

	[Token(Token = "0x6006589")]
	[Address(RVA = "0x16A5180", Offset = "0x16A5180", VA = "0x16A5180")]
	private bool? IsAutoTargetingEnabled(CSCharacterSkillInfo skillInfo, CharacterAutoTargetingEnableSetUp autotargetingSetup)
	{
		return null;
	}

	[Token(Token = "0x600658A")]
	[Address(RVA = "0x16A7614", Offset = "0x16A7614", VA = "0x16A7614")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x600658B")]
	[Address(RVA = "0x16A3B50", Offset = "0x16A3B50", VA = "0x16A3B50")]
	private void SetSkillTutorialObject()
	{
	}

	[Token(Token = "0x600658C")]
	[Address(RVA = "0x16A36E8", Offset = "0x16A36E8", VA = "0x16A36E8")]
	private void MoveScroll(int index)
	{
	}

	[Token(Token = "0x600658D")]
	[Address(RVA = "0x16A76F4", Offset = "0x16A76F4", VA = "0x16A76F4")]
	private void SetSpecializeTutorialObject()
	{
	}

	[Token(Token = "0x600658E")]
	[Address(RVA = "0x16A5808", Offset = "0x16A5808", VA = "0x16A5808")]
	private int GetLocalTagSkill(XModuleActor actor)
	{
		return default(int);
	}

	[Token(Token = "0x600658F")]
	[Address(RVA = "0x16A4EE0", Offset = "0x16A4EE0", VA = "0x16A4EE0")]
	private void ShowOrHidePreviewWidgets(bool bThisCharIsPreview)
	{
	}

	[Token(Token = "0x6006590")]
	[Address(RVA = "0x16A77EC", Offset = "0x16A77EC", VA = "0x16A77EC")]
	private static void _003COnClick_SetTagSkill_003Em__350()
	{
	}

	[Token(Token = "0x6006591")]
	[Address(RVA = "0x16A78C0", Offset = "0x16A78C0", VA = "0x16A78C0")]
	private void _003COnClick_Upgrade_003Em__351(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
