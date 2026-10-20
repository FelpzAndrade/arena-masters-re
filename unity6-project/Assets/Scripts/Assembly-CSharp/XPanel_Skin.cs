using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E2B")]
public class XPanel_Skin : MonoBehaviour
{
	[Token(Token = "0x2000E2C")]
	private sealed class _003CSetSelectSkin_003Ec__AnonStorey1EF
	{
		[Token(Token = "0x4004A81")]
		[FieldOffset(Offset = "0x8")]
		internal int skinID;

		[Token(Token = "0x4004A82")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Skin _003C_003Ef__this;

		[Token(Token = "0x6006958")]
		[Address(RVA = "0xAC88EC", Offset = "0xAC88EC", VA = "0xAC88EC")]
		public _003CSetSelectSkin_003Ec__AnonStorey1EF()
		{
		}

		[Token(Token = "0x6006959")]
		[Address(RVA = "0xACA114", Offset = "0xACA114", VA = "0xACA114")]
		internal void _003C_003Em__3C6(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E2D")]
	private sealed class _003CExpiredPeriodSkinOnSetDefaultSkin_003Ec__AnonStorey1F0
	{
		[Token(Token = "0x4004A83")]
		[FieldOffset(Offset = "0x8")]
		internal int skinID;

		[Token(Token = "0x4004A84")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Skin _003C_003Ef__this;

		[Token(Token = "0x600695A")]
		[Address(RVA = "0xAC8B3C", Offset = "0xAC8B3C", VA = "0xAC8B3C")]
		public _003CExpiredPeriodSkinOnSetDefaultSkin_003Ec__AnonStorey1F0()
		{
		}

		[Token(Token = "0x600695B")]
		[Address(RVA = "0xAC9F00", Offset = "0xAC9F00", VA = "0xAC9F00")]
		internal void _003C_003Em__3C7(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E2E")]
	private sealed class _003CUnlockSkin_003Ec__AnonStorey1F1
	{
		[Token(Token = "0x4004A85")]
		[FieldOffset(Offset = "0x8")]
		internal int skinID;

		[Token(Token = "0x4004A86")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Skin _003C_003Ef__this;

		[Token(Token = "0x600695C")]
		[Address(RVA = "0xAC8D8C", Offset = "0xAC8D8C", VA = "0xAC8D8C")]
		public _003CUnlockSkin_003Ec__AnonStorey1F1()
		{
		}

		[Token(Token = "0x600695D")]
		[Address(RVA = "0xACA2B0", Offset = "0xACA2B0", VA = "0xACA2B0")]
		internal void _003C_003Em__3C8(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E2F")]
	private sealed class _003CRefreshDetail_003Ec__AnonStorey1F2
	{
		[Token(Token = "0x4004A87")]
		[FieldOffset(Offset = "0x8")]
		internal SkinInfo skinInfo;

		[Token(Token = "0x600695E")]
		[Address(RVA = "0xAC9384", Offset = "0xAC9384", VA = "0xAC9384")]
		public _003CRefreshDetail_003Ec__AnonStorey1F2()
		{
		}

		[Token(Token = "0x600695F")]
		[Address(RVA = "0xACA0C4", Offset = "0xACA0C4", VA = "0xACA0C4")]
		internal bool _003C_003Em__3C9(ExpireNode item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004A6F")]
	[FieldOffset(Offset = "0xC")]
	public XUIModelPreviewDragZone preview;

	[Token(Token = "0x4004A70")]
	[FieldOffset(Offset = "0x10")]
	public XUISkinList skinList;

	[Token(Token = "0x4004A71")]
	[FieldOffset(Offset = "0x14")]
	private string m_selectedCharUid;

	[Token(Token = "0x4004A72")]
	[FieldOffset(Offset = "0x18")]
	private int m_selectedCharId;

	[Token(Token = "0x4004A73")]
	[FieldOffset(Offset = "0x1C")]
	private XUISkinItem m_skinItem;

	[Token(Token = "0x4004A74")]
	[FieldOffset(Offset = "0x20")]
	private SkinInfo m_skinInfo;

	[Token(Token = "0x4004A75")]
	[FieldOffset(Offset = "0x24")]
	private XModuleActor m_selectCharActor;

	[Token(Token = "0x4004A76")]
	[FieldOffset(Offset = "0x28")]
	private CSArenaShopItem m_SelectedSkinArenaShopItem;

	[Token(Token = "0x4004A77")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject[] InvisibleObjectsInPreview;

	[Token(Token = "0x4004A78")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArenaCoinPriceGameObject;

	[Token(Token = "0x4004A79")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblArenaCoinPrice;

	[Token(Token = "0x4004A7A")]
	[FieldOffset(Offset = "0x38")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x4004A7B")]
	[FieldOffset(Offset = "0x3C")]
	private Action<string> onEquipSkin;

	[Token(Token = "0x4004A7C")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblTitle;

	[Token(Token = "0x4004A7D")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblName;

	[Token(Token = "0x4004A7E")]
	[FieldOffset(Offset = "0x48")]
	public XWidget_Button btn;

	[Token(Token = "0x4004A7F")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_Button btnBuy;

	[Token(Token = "0x4004A80")]
	[FieldOffset(Offset = "0x50")]
	private XUISkinItem m_item;

	[Token(Token = "0x17000D9A")]
	public string SelectedCharUid
	{
		[Token(Token = "0x600693E")]
		[Address(RVA = "0xAC7DC4", Offset = "0xAC7DC4", VA = "0xAC7DC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000D9B")]
	public int SelectedCharId
	{
		[Token(Token = "0x600693F")]
		[Address(RVA = "0xAC7DCC", Offset = "0xAC7DCC", VA = "0xAC7DCC")]
		set
		{
		}
	}

	[Token(Token = "0x600693D")]
	[Address(RVA = "0xAC7DBC", Offset = "0xAC7DBC", VA = "0xAC7DBC")]
	public XPanel_Skin()
	{
	}

	[Token(Token = "0x6006940")]
	[Address(RVA = "0xAC7DD4", Offset = "0xAC7DD4", VA = "0xAC7DD4")]
	private void SetupSelectedCharModuleActor(int alreadyLookSkinID = 0)
	{
	}

	[Token(Token = "0x6006941")]
	[Address(RVA = "0xAC81C8", Offset = "0xAC81C8", VA = "0xAC81C8")]
	public void Build(bool bShow, Action<string> onEquipSkin, int alreadyLookSkinID = 0)
	{
	}

	[Token(Token = "0x6006942")]
	[Address(RVA = "0xAC866C", Offset = "0xAC866C", VA = "0xAC866C")]
	public void RefreshSkinModel(XModuleActor character, int skinId, bool bCenter)
	{
	}

	[Token(Token = "0x6006943")]
	[Address(RVA = "0xAC86A4", Offset = "0xAC86A4", VA = "0xAC86A4")]
	private void SetSelectSkin(int skinID)
	{
	}

	[Token(Token = "0x6006944")]
	[Address(RVA = "0xAC88F4", Offset = "0xAC88F4", VA = "0xAC88F4")]
	private void ExpiredPeriodSkinOnSetDefaultSkin(int skinID)
	{
	}

	[Token(Token = "0x6006945")]
	[Address(RVA = "0xAC8B44", Offset = "0xAC8B44", VA = "0xAC8B44")]
	private void UnlockSkin(int skinID)
	{
	}

	[Token(Token = "0x6006946")]
	[Address(RVA = "0xAC8D94", Offset = "0xAC8D94", VA = "0xAC8D94")]
	private void ShowCardDirection(int skinID)
	{
	}

	[Token(Token = "0x6006947")]
	[Address(RVA = "0xAC8588", Offset = "0xAC8588", VA = "0xAC8588")]
	private void InitDetail()
	{
	}

	[Token(Token = "0x6006948")]
	[Address(RVA = "0xAC8FB8", Offset = "0xAC8FB8", VA = "0xAC8FB8")]
	public void RefreshDetail(SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x6006949")]
	[Address(RVA = "0xAC938C", Offset = "0xAC938C", VA = "0xAC938C")]
	private bool IsCharacterNotOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x600694A")]
	[Address(RVA = "0xAC93F4", Offset = "0xAC93F4", VA = "0xAC93F4")]
	private bool IsSkinEquipped()
	{
		return default(bool);
	}

	[Token(Token = "0x600694B")]
	[Address(RVA = "0xAC9450", Offset = "0xAC9450", VA = "0xAC9450")]
	public void RefreshButton(bool isCharacterNotOwned, bool unlockState, bool isUnlockableSkin, bool isEquippedSkin)
	{
	}

	[Token(Token = "0x600694C")]
	[Address(RVA = "0xAC8F40", Offset = "0xAC8F40", VA = "0xAC8F40")]
	private void TabSelectSetupModel()
	{
	}

	[Token(Token = "0x600694D")]
	[Address(RVA = "0xAC97D8", Offset = "0xAC97D8", VA = "0xAC97D8")]
	public void OnClick_Buy()
	{
	}

	[Token(Token = "0x600694E")]
	[Address(RVA = "0xAC98C0", Offset = "0xAC98C0", VA = "0xAC98C0")]
	public void OnClick_UnlockSkin()
	{
	}

	[Token(Token = "0x600694F")]
	[Address(RVA = "0xAC98EC", Offset = "0xAC98EC", VA = "0xAC98EC")]
	public void OnClick_SelectSkin()
	{
	}

	[Token(Token = "0x6006950")]
	[Address(RVA = "0xAC80EC", Offset = "0xAC80EC", VA = "0xAC80EC")]
	private XModuleActor GetSelectCharacterActor(string selectedCharUid)
	{
		return null;
	}

	[Token(Token = "0x6006951")]
	[Address(RVA = "0xAC939C", Offset = "0xAC939C", VA = "0xAC939C")]
	private bool IsUnlockSkin(int skinID)
	{
		return default(bool);
	}

	[Token(Token = "0x6006952")]
	[Address(RVA = "0xAC9918", Offset = "0xAC9918", VA = "0xAC9918")]
	public void SelectSkinItem(XUISkinItem item, int skinID)
	{
	}

	[Token(Token = "0x6006953")]
	[Address(RVA = "0xAC9A34", Offset = "0xAC9A34", VA = "0xAC9A34")]
	private void ShowOrHidePreviewWidgets(bool bThisCharIsPreview)
	{
	}

	[Token(Token = "0x6006954")]
	[Address(RVA = "0xAC966C", Offset = "0xAC966C", VA = "0xAC966C")]
	private void RefreshArenaShopItem(SkinInfo skinInfo, bool isCharacterNotOwned, bool unlockState, bool isUnlockableSkin)
	{
	}

	[Token(Token = "0x6006955")]
	[Address(RVA = "0xAC9AA8", Offset = "0xAC9AA8", VA = "0xAC9AA8")]
	public CSArenaShopItem FindSkinArenaShopItem(SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x6006956")]
	[Address(RVA = "0xAC9E4C", Offset = "0xAC9E4C", VA = "0xAC9E4C")]
	private void OnExpirePeriodSkin(int expireSkinID)
	{
	}

	[Token(Token = "0x6006957")]
	[Address(RVA = "0xAC9E50", Offset = "0xAC9E50", VA = "0xAC9E50")]
	private void _003CBuild_003Em__3C5(GameObject obj, int selectID)
	{
	}
}
