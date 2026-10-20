using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000E04")]
public class XPanel_Pet : XUIBasePanel
{
	[Token(Token = "0x2000E05")]
	private sealed class _003CLoadAsync_003Ec__IteratorA6 : IDisposable
	{
		[Token(Token = "0x4004999")]
		[FieldOffset(Offset = "0x8")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x400499A")]
		[FieldOffset(Offset = "0xC")]
		internal GameObject _003Cprefab_003E__1;

		[Token(Token = "0x400499B")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleActor pet;

		[Token(Token = "0x400499C")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x400499D")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400499E")]
		[FieldOffset(Offset = "0x1C")]
		internal XModuleActor _003C_0024_003Epet;

		[Token(Token = "0x400499F")]
		[FieldOffset(Offset = "0x20")]
		internal XPanel_Pet _003C_003Ef__this;

		[Token(Token = "0x17000D81")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006832")]
			[Address(RVA = "0x10163A8", Offset = "0x10163A8", VA = "0x10163A8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D82")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006833")]
			[Address(RVA = "0x10163B0", Offset = "0x10163B0", VA = "0x10163B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006831")]
		[Address(RVA = "0x1014240", Offset = "0x1014240", VA = "0x1014240")]
		public _003CLoadAsync_003Ec__IteratorA6()
		{
		}

		[Token(Token = "0x6006832")]
		[Address(RVA = "0x10163A8", Offset = "0x10163A8", VA = "0x10163A8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006833")]
		[Address(RVA = "0x10163B0", Offset = "0x10163B0", VA = "0x10163B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006834")]
		[Address(RVA = "0x10163B8", Offset = "0x10163B8", VA = "0x10163B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006835")]
		[Address(RVA = "0x1016610", Offset = "0x1016610", VA = "0x1016610", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006836")]
		[Address(RVA = "0x101661C", Offset = "0x101661C", VA = "0x101661C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000E06")]
	private sealed class _003CBuildEquipmentSlot_003Ec__AnonStorey1DB
	{
		[Token(Token = "0x40049A0")]
		[FieldOffset(Offset = "0x8")]
		internal XItem item;

		[Token(Token = "0x40049A1")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Pet _003C_003Ef__this;

		[Token(Token = "0x6006837")]
		[Address(RVA = "0x1014248", Offset = "0x1014248", VA = "0x1014248")]
		public _003CBuildEquipmentSlot_003Ec__AnonStorey1DB()
		{
		}

		[Token(Token = "0x6006838")]
		[Address(RVA = "0x1016030", Offset = "0x1016030", VA = "0x1016030")]
		internal void _003C_003Em__3A1()
		{
		}
	}

	[Token(Token = "0x2000E07")]
	private sealed class _003CBuildUpgrade_003Ec__AnonStorey1DC
	{
		[Token(Token = "0x40049A2")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor pet;

		[Token(Token = "0x40049A3")]
		[FieldOffset(Offset = "0xC")]
		internal bool petIsOwned;

		[Token(Token = "0x40049A4")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Pet _003C_003Ef__this;

		[Token(Token = "0x6006839")]
		[Address(RVA = "0x1014250", Offset = "0x1014250", VA = "0x1014250")]
		public _003CBuildUpgrade_003Ec__AnonStorey1DC()
		{
		}

		[Token(Token = "0x600683A")]
		[Address(RVA = "0x1016088", Offset = "0x1016088", VA = "0x1016088")]
		internal void _003C_003Em__3A2()
		{
		}

		[Token(Token = "0x600683B")]
		[Address(RVA = "0x10161A4", Offset = "0x10161A4", VA = "0x10161A4")]
		internal void _003C_003Em__3A8()
		{
		}
	}

	[Token(Token = "0x2000E08")]
	private sealed class _003CSendNetCommand_LevelUPPet_003Ec__AnonStorey1DD
	{
		[Token(Token = "0x40049A5")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor pet;

		[Token(Token = "0x40049A6")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Pet _003C_003Ef__this;

		[Token(Token = "0x600683C")]
		[Address(RVA = "0x10147E0", Offset = "0x10147E0", VA = "0x10147E0")]
		public _003CSendNetCommand_LevelUPPet_003Ec__AnonStorey1DD()
		{
		}

		[Token(Token = "0x600683D")]
		[Address(RVA = "0x10166B0", Offset = "0x10166B0", VA = "0x10166B0")]
		internal void _003C_003Em__3A4(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E09")]
	private sealed class _003CShowCardDirection_003Ec__AnonStorey1DE
	{
		[Token(Token = "0x40049A7")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleActor selectedCharacter;

		[Token(Token = "0x40049A8")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Pet _003C_003Ef__this;

		[Token(Token = "0x600683E")]
		[Address(RVA = "0x10149A8", Offset = "0x10149A8", VA = "0x10149A8")]
		public _003CShowCardDirection_003Ec__AnonStorey1DE()
		{
		}

		[Token(Token = "0x600683F")]
		[Address(RVA = "0x10167F8", Offset = "0x10167F8", VA = "0x10167F8")]
		internal void _003C_003Em__3A5()
		{
		}

		[Token(Token = "0x6006840")]
		[Address(RVA = "0x10168DC", Offset = "0x10168DC", VA = "0x10168DC")]
		internal void _003C_003Em__3A9()
		{
		}
	}

	[Token(Token = "0x400497A")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_Inventory m_inventory;

	[Token(Token = "0x400497B")]
	[FieldOffset(Offset = "0x14")]
	public Transform InventoryParent;

	[Token(Token = "0x400497C")]
	[FieldOffset(Offset = "0x18")]
	public Transform itemDetailPopupParent;

	[Token(Token = "0x400497D")]
	[FieldOffset(Offset = "0x1C")]
	public XUIModelPreviewDragZone preview;

	[Token(Token = "0x400497E")]
	[FieldOffset(Offset = "0x20")]
	private string m_selectedPetUid;

	[Token(Token = "0x400497F")]
	[FieldOffset(Offset = "0x24")]
	private int m_selectedPetId;

	[Token(Token = "0x4004980")]
	[FieldOffset(Offset = "0x28")]
	private int m_goldCost;

	[Token(Token = "0x4004981")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblLevel;

	[Token(Token = "0x4004982")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblTitle;

	[Token(Token = "0x4004983")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblName;

	[Token(Token = "0x4004984")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblTeamExpBuff;

	[Token(Token = "0x4004985")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblMedalOfHonorBuff;

	[Token(Token = "0x4004986")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblGoldBuff;

	[Token(Token = "0x4004987")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblExp;

	[Token(Token = "0x4004988")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar prbExp;

	[Token(Token = "0x4004989")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_Button btnUpgrade;

	[Token(Token = "0x400498A")]
	[FieldOffset(Offset = "0x50")]
	public XWidget_Button btnEquip;

	[Token(Token = "0x400498B")]
	[FieldOffset(Offset = "0x54")]
	public XWiget_GridBuilder gridSlot;

	[Token(Token = "0x400498C")]
	[FieldOffset(Offset = "0x58")]
	public UIToggle showToggle;

	[Token(Token = "0x400498D")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel lblShowToggle;

	[Token(Token = "0x400498E")]
	[FieldOffset(Offset = "0x60")]
	private XPanel_PetList m_petList;

	[Token(Token = "0x400498F")]
	[FieldOffset(Offset = "0x64")]
	private readonly string Path_CharDetailEvolutionPopup;

	[Token(Token = "0x4004990")]
	[FieldOffset(Offset = "0x68")]
	private readonly string Path_CharDetailEvolutionResult;

	[Token(Token = "0x4004991")]
	[FieldOffset(Offset = "0x6C")]
	private readonly string Path_PetDetailStatDetail;

	[Token(Token = "0x4004992")]
	[FieldOffset(Offset = "0x70")]
	private XWidget_ButtonEquipmentSlot[] _slotWidgets;

	[Token(Token = "0x4004993")]
	[FieldOffset(Offset = "0x74")]
	private XWidget_InvenItemDetail _itemDetailPopup;

	[Token(Token = "0x4004994")]
	[FieldOffset(Offset = "0x78")]
	private XWidget_PetAcqusition _evolutionPopup;

	[Token(Token = "0x4004995")]
	[FieldOffset(Offset = "0x7C")]
	private XWidget_PetStatDetail _widgetStatDetail;

	[Token(Token = "0x4004996")]
	[FieldOffset(Offset = "0x80")]
	private XPanel_PetDirectionRoot petDirectionRoot;

	[Token(Token = "0x4004997")]
	[FieldOffset(Offset = "0x84")]
	private XWidget_EvolutionResultPet _evolutionResult;

	[Token(Token = "0x4004998")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache1E;

	[Token(Token = "0x17000D7C")]
	private XWidget_ButtonEquipmentSlot[] slotWidgets
	{
		[Token(Token = "0x600680D")]
		[Address(RVA = "0x1011DF0", Offset = "0x1011DF0", VA = "0x1011DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7D")]
	private XWidget_InvenItemDetail itemDetailPopup
	{
		[Token(Token = "0x600680E")]
		[Address(RVA = "0x1011E9C", Offset = "0x1011E9C", VA = "0x1011E9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7E")]
	private XWidget_PetAcqusition evolutionPopup
	{
		[Token(Token = "0x600680F")]
		[Address(RVA = "0x1011FEC", Offset = "0x1011FEC", VA = "0x1011FEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7F")]
	private XWidget_PetStatDetail widgetStatDetail
	{
		[Token(Token = "0x6006810")]
		[Address(RVA = "0x10120EC", Offset = "0x10120EC", VA = "0x10120EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D80")]
	private XWidget_EvolutionResultPet evolutionResult
	{
		[Token(Token = "0x6006811")]
		[Address(RVA = "0x10121EC", Offset = "0x10121EC", VA = "0x10121EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600680C")]
	[Address(RVA = "0x1011D3C", Offset = "0x1011D3C", VA = "0x1011D3C")]
	public XPanel_Pet()
	{
	}

	[Token(Token = "0x6006812")]
	[Address(RVA = "0x10122EC", Offset = "0x10122EC", VA = "0x10122EC")]
	public void ShowStatDetailPopup()
	{
	}

	[Token(Token = "0x6006813")]
	[Address(RVA = "0x10124D8", Offset = "0x10124D8", VA = "0x10124D8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006814")]
	[Address(RVA = "0x10127B8", Offset = "0x10127B8", VA = "0x10127B8")]
	public void Show(string uid, int charId, XPanel_PetList petList, bool playVoiceSound = true)
	{
	}

	[Token(Token = "0x6006815")]
	[Address(RVA = "0x1012AEC", Offset = "0x1012AEC", VA = "0x1012AEC")]
	public void Build(XModuleActor pet)
	{
	}

	[Token(Token = "0x6006816")]
	[Address(RVA = "0x1013050", Offset = "0x1013050", VA = "0x1013050")]
	private bool CheckSelectedPetUID()
	{
		return default(bool);
	}

	[Token(Token = "0x6006817")]
	[Address(RVA = "0x10131F0", Offset = "0x10131F0", VA = "0x10131F0")]
	private void SetEquipBtn(XModuleActor pet)
	{
	}

	[Token(Token = "0x6006818")]
	[Address(RVA = "0x101328C", Offset = "0x101328C", VA = "0x101328C")]
	public void Refresh(string uid, int petID)
	{
	}

	[Token(Token = "0x6006819")]
	[Address(RVA = "0x1012DDC", Offset = "0x1012DDC", VA = "0x1012DDC")]
	public void BuildInventory(XModuleActor character, Transform leftRoot)
	{
	}

	[Token(Token = "0x600681A")]
	[Address(RVA = "0x10132C4", Offset = "0x10132C4", VA = "0x10132C4")]
	private void OnEquip(EquipmentSlot slot)
	{
	}

	[Token(Token = "0x600681B")]
	[Address(RVA = "0x1012F58", Offset = "0x1012F58", VA = "0x1012F58")]
	public void Refresh(XModuleActor pet)
	{
	}

	[Token(Token = "0x600681C")]
	[Address(RVA = "0x1013594", Offset = "0x1013594", VA = "0x1013594")]
	private void BuildBuffInfo(XModuleActor pet)
	{
	}

	[Token(Token = "0x600681D")]
	[Address(RVA = "0x10133B0", Offset = "0x10133B0", VA = "0x10133B0")]
	private void BuildInfo(XModuleActor pet)
	{
	}

	[Token(Token = "0x600681E")]
	[Address(RVA = "0x1013350", Offset = "0x1013350", VA = "0x1013350")]
	private void BuildModel(XModuleActor pet)
	{
	}

	[Token(Token = "0x600681F")]
	[Address(RVA = "0x1014208", Offset = "0x1014208", VA = "0x1014208")]
	public XModuleActor GetCurrentPet()
	{
		return null;
	}

	[Token(Token = "0x6006820")]
	[Address(RVA = "0x10123FC", Offset = "0x10123FC", VA = "0x10123FC")]
	private XModuleActor GetPet(string uid, int charID)
	{
		return null;
	}

	[Token(Token = "0x6006821")]
	[Address(RVA = "0x1014214", Offset = "0x1014214", VA = "0x1014214")]
	public void OpenOptionChangePopup(XItem item)
	{
	}

	[Token(Token = "0x6006822")]
	[Address(RVA = "0x1012D2C", Offset = "0x1012D2C", VA = "0x1012D2C")]
	[DebuggerHidden]
	private IEnumerator LoadAsync(XModuleActor pet)
	{
		return null;
	}

	[Token(Token = "0x6006823")]
	[Address(RVA = "0x1014000", Offset = "0x1014000", VA = "0x1014000")]
	private void BuildEquipmentSlot(XModuleActor pet)
	{
	}

	[Token(Token = "0x6006824")]
	[Address(RVA = "0x1013778", Offset = "0x1013778", VA = "0x1013778")]
	private void BuildUpgrade(XModuleActor pet)
	{
	}

	[Token(Token = "0x6006825")]
	[Address(RVA = "0x1014258", Offset = "0x1014258", VA = "0x1014258")]
	private void SendNetCommand_GetPet(int itemId)
	{
	}

	[Token(Token = "0x6006826")]
	[Address(RVA = "0x10144CC", Offset = "0x10144CC", VA = "0x10144CC")]
	private void SendNetCommand_LevelUPPet(int itemId)
	{
	}

	[Token(Token = "0x6006827")]
	[Address(RVA = "0x10147E8", Offset = "0x10147E8", VA = "0x10147E8")]
	private void ShowCardDirection(XModuleActor selectedCharacter)
	{
	}

	[Token(Token = "0x6006828")]
	[Address(RVA = "0x10149E0", Offset = "0x10149E0", VA = "0x10149E0")]
	private void EndCardDirection()
	{
	}

	[Token(Token = "0x6006829")]
	[Address(RVA = "0x1014E1C", Offset = "0x1014E1C", VA = "0x1014E1C")]
	public void OnClick_EquipPet()
	{
	}

	[Token(Token = "0x600682A")]
	[Address(RVA = "0x1015050", Offset = "0x1015050", VA = "0x1015050")]
	public void OnClick_IsShowPet()
	{
	}

	[Token(Token = "0x600682B")]
	[Address(RVA = "0x10153AC", Offset = "0x10153AC", VA = "0x10153AC")]
	private static void _003CHide_003Em__39E(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x600682C")]
	[Address(RVA = "0x101548C", Offset = "0x101548C", VA = "0x101548C")]
	private void _003CBuild_003Em__39F()
	{
	}

	[Token(Token = "0x600682D")]
	[Address(RVA = "0x1015498", Offset = "0x1015498", VA = "0x1015498")]
	private void _003CBuildInventory_003Em__3A0()
	{
	}

	[Token(Token = "0x600682E")]
	[Address(RVA = "0x10154A4", Offset = "0x10154A4", VA = "0x10154A4")]
	private void _003CSendNetCommand_GetPet_003Em__3A3(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x600682F")]
	[Address(RVA = "0x1015C4C", Offset = "0x1015C4C", VA = "0x1015C4C")]
	private void _003COnClick_EquipPet_003Em__3A6(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006830")]
	[Address(RVA = "0x1015DB4", Offset = "0x1015DB4", VA = "0x1015DB4")]
	private void _003COnClick_IsShowPet_003Em__3A7(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
