using System;
using System.Runtime.InteropServices;
using I2.Loc;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F99")]
public abstract class XWidget_ItemQuantityInputBoxBase : XUIBaseWidget
{
	[Token(Token = "0x4005282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected XItem m_item;

	[Token(Token = "0x4005283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform icon;

	[Token(Token = "0x4005284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected XWidget_ItemIcon m_icon;

	[Token(Token = "0x4005285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblTitle;

	[Token(Token = "0x4005286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblUseText;

	[Token(Token = "0x4005287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblExtra;

	[Token(Token = "0x4005288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public XWidget_QuantityInputBox quantityInputBox;

	[Token(Token = "0x4005289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject InputRootObject;

	[Token(Token = "0x400528A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public GameObject confirmRootObject;

	[Token(Token = "0x400528B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblConfirmComment;

	[Token(Token = "0x400528C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Localize confirmCommentLocalize;

	[Token(Token = "0x400528D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Action<string, int, int> m_onClickInputConfirm;

	[Token(Token = "0x400528E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected Action m_onResultConfirm;

	[Token(Token = "0x400528F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButton btnOK;

	[Token(Token = "0x4005290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UIButton btnOKDisable;

	[Token(Token = "0x6007435")]
	[Address(RVA = "0x1456550", Offset = "0x1456550", VA = "0x1456550")]
	protected XWidget_ItemQuantityInputBoxBase()
	{
	}

	[Token(Token = "0x6007436")]
	[Address(RVA = "0x1456558", Offset = "0x1456558", VA = "0x1456558")]
	protected void SetTitle(bool bActive)
	{
	}

	[Token(Token = "0x6007437")]
	[Address(RVA = "0x1456648", Offset = "0x1456648", VA = "0x1456648", Slot = "18")]
	public virtual void BuildIcon(XItem item)
	{
	}

	[Token(Token = "0x6007438")]
	[Address(RVA = "0x1456894", Offset = "0x1456894", VA = "0x1456894")]
	protected string GetItemName()
	{
		return null;
	}

	[Token(Token = "0x6007439")]
	[Address(RVA = "0x14568C8", Offset = "0x14568C8", VA = "0x14568C8", Slot = "19")]
	protected virtual void SetConfirmTitle()
	{
	}

	[Token(Token = "0x600743A")]
	[Address(RVA = "0x14568D0", Offset = "0x14568D0", VA = "0x14568D0", Slot = "20")]
	protected virtual void SetInputTitle()
	{
	}

	[Token(Token = "0x600743B")]
	protected abstract void SetQuantityInputBox(XItem item);

	[Token(Token = "0x600743C")]
	[Address(RVA = "0x14568D8", Offset = "0x14568D8", VA = "0x14568D8", Slot = "22")]
	public virtual void Build(XItem item, Action<string, int, int> onClickOK, int limitValue = -1)
	{
	}

	[Token(Token = "0x600743D")]
	[Address(RVA = "0x1456B6C", Offset = "0x1456B6C", VA = "0x1456B6C")]
	private void BuildOKButton()
	{
	}

	[Token(Token = "0x600743E")]
	[Address(RVA = "0x144F1BC", Offset = "0x144F1BC", VA = "0x144F1BC")]
	public void ShowConfirm([Optional] Action onResultConfirm)
	{
	}

	[Token(Token = "0x600743F")]
	protected abstract int GetTotal();

	[Token(Token = "0x6007440")]
	protected abstract void RefreshTotal();

	[Token(Token = "0x6007441")]
	protected abstract void ShowMsgMax();

	[Token(Token = "0x6007442")]
	[Address(RVA = "0x1456BD8", Offset = "0x1456BD8", VA = "0x1456BD8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007443")]
	public abstract void OnClick_InputConfirm();

	[Token(Token = "0x6007444")]
	public abstract void OnClick_ResultConfirm();
}
