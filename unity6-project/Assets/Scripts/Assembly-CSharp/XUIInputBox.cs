using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C60")]
public class XUIInputBox : ICommonBackableUI
{
	[Token(Token = "0x2000C61")]
	public enum InputBoxType
	{
		[Token(Token = "0x4003EB6")]
		none = 0,
		[Token(Token = "0x4003EB7")]
		friendlyMatch = 1,
		[Token(Token = "0x4003EB8")]
		nickName = 2
	}

	[Token(Token = "0x2000C62")]
	private enum cacheObjType
	{
		[Token(Token = "0x4003EBA")]
		Anchor_Center = 0,
		[Token(Token = "0x4003EBB")]
		Input = 1,
		[Token(Token = "0x4003EBC")]
		btnOK = 2,
		[Token(Token = "0x4003EBD")]
		btnCancel = 3,
		[Token(Token = "0x4003EBE")]
		btnOnlyOK = 4,
		[Token(Token = "0x4003EBF")]
		lblTitle = 5,
		[Token(Token = "0x4003EC0")]
		lblMessage = 6,
		[Token(Token = "0x4003EC1")]
		backgroundDim = 7,
		[Token(Token = "0x4003EC2")]
		lblGuide = 8,
		[Token(Token = "0x4003EC3")]
		end = 9
	}

	[Token(Token = "0x2000C63")]
	public delegate void XInputBoxDelegate(string strInputText);

	[Token(Token = "0x2000C64")]
	private sealed class _003CSetupDelegate_003Ec__AnonStorey17D
	{
		[Token(Token = "0x4003EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XInputBoxDelegate delegateOK;

		[Token(Token = "0x4003EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XUIInputBox _003C_003Ef__this;

		[Token(Token = "0x6005981")]
		[Address(RVA = "0x1092CF4", Offset = "0x1092CF4", VA = "0x1092CF4")]
		public _003CSetupDelegate_003Ec__AnonStorey17D()
		{
		}

		[Token(Token = "0x6005982")]
		[Address(RVA = "0x10933D0", Offset = "0x10933D0", VA = "0x10933D0")]
		internal void _003C_003Em__256(GameObject P_0)
		{
		}

		[Token(Token = "0x6005983")]
		[Address(RVA = "0x10934C8", Offset = "0x10934C8", VA = "0x10934C8")]
		internal void _003C_003Em__257(GameObject P_0)
		{
		}
	}

	[Token(Token = "0x4003EAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Action<ICommonBackableUI> m_RegisterPopup;

	[Token(Token = "0x4003EB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Action<ICommonBackableUI> m_ReleasePopup;

	[Token(Token = "0x4003EB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_isBackable;

	[Token(Token = "0x4003EB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private GameObject pnlInputBox;

	[Token(Token = "0x4003EB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject[] cacheObject;

	[Token(Token = "0x4003EB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private string defaultInputValue;

	[Token(Token = "0x6005963")]
	[Address(RVA = "0x1091284", Offset = "0x1091284", VA = "0x1091284")]
	public XUIInputBox()
	{
	}

	[Token(Token = "0x6005964")]
	[Address(RVA = "0x1091350", Offset = "0x1091350", VA = "0x1091350")]
	public void Show(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] InputBoxType inputType, [Optional] XInputBoxDelegate delegateOK, UIInput.KeyboardType keyboardType = UIInput.KeyboardType.Default, UIInput.Validation validation = UIInput.Validation.None)
	{
	}

	[Token(Token = "0x6005965")]
	[Address(RVA = "0x1091974", Offset = "0x1091974", VA = "0x1091974")]
	private void SetupUILayout(InputBoxType inputType)
	{
	}

	[Token(Token = "0x6005966")]
	[Address(RVA = "0x1091C78", Offset = "0x1091C78", VA = "0x1091C78")]
	private void CommonLayout()
	{
	}

	[Token(Token = "0x6005967")]
	[Address(RVA = "0x1092590", Offset = "0x1092590", VA = "0x1092590")]
	private void DefaultLayout()
	{
	}

	[Token(Token = "0x6005968")]
	[Address(RVA = "0x1092370", Offset = "0x1092370", VA = "0x1092370")]
	private void NickNameUILayout()
	{
	}

	[Token(Token = "0x6005969")]
	[Address(RVA = "0x1092870", Offset = "0x1092870", VA = "0x1092870")]
	private void SetDefaultInputValueInNickNameUI()
	{
	}

	[Token(Token = "0x600596A")]
	[Address(RVA = "0x1092A70", Offset = "0x1092A70", VA = "0x1092A70")]
	private void SetDefaultInputValue(string id)
	{
	}

	[Token(Token = "0x600596B")]
	[Address(RVA = "0x1091AA8", Offset = "0x1091AA8", VA = "0x1091AA8")]
	private void SetupButtons(XMessageBoxButtons nButtons)
	{
	}

	[Token(Token = "0x600596C")]
	[Address(RVA = "0x1092BC8", Offset = "0x1092BC8", VA = "0x1092BC8")]
	private void CacheObjectActive(cacheObjType type, bool isActive)
	{
	}

	[Token(Token = "0x600596D")]
	[Address(RVA = "0x1091B2C", Offset = "0x1091B2C", VA = "0x1091B2C")]
	private void SetupDelegate(XInputBoxDelegate delegateOK)
	{
	}

	[Token(Token = "0x600596E")]
	[Address(RVA = "0x1092CFC", Offset = "0x1092CFC", VA = "0x1092CFC")]
	private void CacheObjectSetClickEvent(cacheObjType type, XButtonDelegator.ClickDelegate clickEvent)
	{
	}

	[Token(Token = "0x600596F")]
	[Address(RVA = "0x10918BC", Offset = "0x10918BC", VA = "0x10918BC")]
	private void SetupPanelPosition()
	{
	}

	[Token(Token = "0x6005970")]
	[Address(RVA = "0x10919A4", Offset = "0x10919A4", VA = "0x10919A4")]
	private void SetupLabel(string strMessage, GameObject lblMessage)
	{
	}

	[Token(Token = "0x6005971")]
	[Address(RVA = "0x1092E48", Offset = "0x1092E48", VA = "0x1092E48")]
	private string GetInputText()
	{
		return null;
	}

	[Token(Token = "0x6005972")]
	[Address(RVA = "0x1091618", Offset = "0x1091618", VA = "0x1091618")]
	private GameObject GetShowInputBoxObject(InputBoxType inputType)
	{
		return null;
	}

	[Token(Token = "0x6005973")]
	[Address(RVA = "0x109301C", Offset = "0x109301C", VA = "0x109301C", Slot = "5")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005974")]
	[Address(RVA = "0x1093190", Offset = "0x1093190", VA = "0x1093190", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6005975")]
	[Address(RVA = "0x1093274", Offset = "0x1093274", VA = "0x1093274", Slot = "6")]
	public bool IsBackable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005976")]
	[Address(RVA = "0x109327C", Offset = "0x109327C", VA = "0x109327C", Slot = "7")]
	public bool IsLeaf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005977")]
	[Address(RVA = "0x1093284", Offset = "0x1093284", VA = "0x1093284", Slot = "8")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x6005978")]
	[Address(RVA = "0x10933B4", Offset = "0x10933B4", VA = "0x10933B4", Slot = "9")]
	public bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6005979")]
	[Address(RVA = "0x10933BC", Offset = "0x10933BC", VA = "0x10933BC", Slot = "10")]
	public void SetPopupFunc(Action<ICommonBackableUI> registerPopup, Action<ICommonBackableUI> releasePopup)
	{
	}

	[Token(Token = "0x600597A")]
	[Address(RVA = "0x10933C8", Offset = "0x10933C8", VA = "0x10933C8")]
	public void SetPopupState(bool isBackable)
	{
	}

	[Token(Token = "0x600597B")]
	[Address(RVA = "0x109182C", Offset = "0x109182C", VA = "0x109182C")]
	private void RegisterPopup()
	{
	}

	[Token(Token = "0x600597C")]
	[Address(RVA = "0x1093100", Offset = "0x1093100", VA = "0x1093100")]
	private void ReleasePopup()
	{
	}
}
