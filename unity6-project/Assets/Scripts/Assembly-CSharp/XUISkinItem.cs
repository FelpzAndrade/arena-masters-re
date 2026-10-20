using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F58")]
public class XUISkinItem : MonoBehaviour
{
	[Token(Token = "0x400508B")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x400508C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblCondition;

	[Token(Token = "0x400508D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject sprSelectFrame;

	[Token(Token = "0x400508E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject sprLock;

	[Token(Token = "0x400508F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goUnlockableText;

	[Token(Token = "0x4005090")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goEquipped;

	[Token(Token = "0x4005091")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_NGUITween equipTween;

	[Token(Token = "0x4005092")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_RemainPeriod goRemainPeriod;

	[Token(Token = "0x4005093")]
	[FieldOffset(Offset = "0x2C")]
	private Action<GameObject, int> itemSelectAction;

	[Token(Token = "0x4005094")]
	[FieldOffset(Offset = "0x30")]
	private Action<SkinInfo> itemSkinInfo;

	[Token(Token = "0x4005095")]
	[FieldOffset(Offset = "0x34")]
	private Action<int> m_acExpirePeriodSkin;

	[Token(Token = "0x4005096")]
	[FieldOffset(Offset = "0x38")]
	private SkinInfo m_skinInfo;

	[Token(Token = "0x4005097")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_unlock;

	[Token(Token = "0x4005098")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_havePeriodSkin;

	[Token(Token = "0x4005099")]
	[FieldOffset(Offset = "0x3E")]
	private bool m_characterPreview;

	[Token(Token = "0x400509A")]
	[FieldOffset(Offset = "0x40")]
	private Regulator periodUpdater;

	[Token(Token = "0x400509B")]
	[FieldOffset(Offset = "0x44")]
	private string strSkin;

	[Token(Token = "0x60071F3")]
	[Address(RVA = "0x192B544", Offset = "0x192B544", VA = "0x192B544")]
	public XUISkinItem()
	{
	}

	[Token(Token = "0x60071F4")]
	[Address(RVA = "0x192B644", Offset = "0x192B644", VA = "0x192B644")]
	public void Build(SkinInfo skinInfo, Action<GameObject, int> selAction, Action<SkinInfo> selInfo, int selSkinID, bool unlock, int equippedID, bool characterPreview, ExpireNode periodSkinData, Action<int> onExpireFunc)
	{
	}

	[Token(Token = "0x60071F5")]
	[Address(RVA = "0x192BEC0", Offset = "0x192BEC0", VA = "0x192BEC0")]
	private void BuildRemainPeriod(bool isUnlockable, ExpireNode periodSkinData, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x60071F6")]
	[Address(RVA = "0x192BB90", Offset = "0x192BB90", VA = "0x192BB90")]
	public void RefreshSelectCheck(int selSkinID)
	{
	}

	[Token(Token = "0x60071F7")]
	[Address(RVA = "0x192BE20", Offset = "0x192BE20", VA = "0x192BE20")]
	public void RefreshEquippedCheck(int equippedID, bool tween, bool characterPreview)
	{
	}

	[Token(Token = "0x60071F8")]
	[Address(RVA = "0x192BC64", Offset = "0x192BC64", VA = "0x192BC64")]
	public void RefreshLockUI(bool unlock, bool havePeriodItem, bool characterPreview)
	{
	}

	[Token(Token = "0x60071F9")]
	[Address(RVA = "0x192C0F4", Offset = "0x192C0F4", VA = "0x192C0F4")]
	private bool CheckUnlockSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x60071FA")]
	[Address(RVA = "0x192C1D0", Offset = "0x192C1D0", VA = "0x192C1D0")]
	private bool IsHavePeriodSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x60071FB")]
	[Address(RVA = "0x192BB64", Offset = "0x192BB64", VA = "0x192BB64")]
	public void RefreshSelect(bool select)
	{
	}

	[Token(Token = "0x60071FC")]
	[Address(RVA = "0x192C2AC", Offset = "0x192C2AC", VA = "0x192C2AC")]
	public SkinInfo GetSkinItemInfo()
	{
		return null;
	}

	[Token(Token = "0x60071FD")]
	[Address(RVA = "0x192C2B4", Offset = "0x192C2B4", VA = "0x192C2B4")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60071FE")]
	[Address(RVA = "0x192C39C", Offset = "0x192C39C", VA = "0x192C39C")]
	public void Update()
	{
	}

	[Token(Token = "0x60071FF")]
	[Address(RVA = "0x192C3A0", Offset = "0x192C3A0", VA = "0x192C3A0")]
	private void UpdateRemainPeriod()
	{
	}

	[Token(Token = "0x6007200")]
	[Address(RVA = "0x192C584", Offset = "0x192C584", VA = "0x192C584")]
	private void OnExpriePreiod()
	{
	}
}
