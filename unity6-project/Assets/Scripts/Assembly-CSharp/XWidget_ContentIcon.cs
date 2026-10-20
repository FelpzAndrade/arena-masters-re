using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C71")]
public class XWidget_ContentIcon : MonoBehaviour
{
	[Token(Token = "0x2000C72")]
	public enum Option
	{
		[Token(Token = "0x4003F1C")]
		None = 0,
		[Token(Token = "0x4003F1D")]
		Background = 1,
		[Token(Token = "0x4003F1E")]
		Quantity = 2,
		[Token(Token = "0x4003F1F")]
		OwnedCount = 4,
		[Token(Token = "0x4003F20")]
		Tooltip = 8,
		[Token(Token = "0x4003F21")]
		Name = 16,
		[Token(Token = "0x4003F22")]
		NotIncludeOne = 32,
		[Token(Token = "0x4003F23")]
		Grade = 64,
		[Token(Token = "0x4003F24")]
		NameCountQuantityBG = 128,
		[Token(Token = "0x4003F25")]
		IconWithBackGround = 256,
		[Token(Token = "0x4003F26")]
		EnableFrame = 512,
		[Token(Token = "0x4003F27")]
		QuantityBeforeX = 1024,
		[Token(Token = "0x4003F28")]
		NameAndQuantityOneLine = 2048,
		[Token(Token = "0x4003F29")]
		All = 65535
	}

	[Token(Token = "0x4003F10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject goBG;

	[Token(Token = "0x4003F11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject bgFrame;

	[Token(Token = "0x4003F12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UI2DSprite sprDefaultIcon;

	[Token(Token = "0x4003F13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UI2DSprite sprContentIcon;

	[Token(Token = "0x4003F14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject itemIconParent;

	[Token(Token = "0x4003F15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblQuantity;

	[Token(Token = "0x4003F16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblName;

	[Token(Token = "0x4003F17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblReceived;

	[Token(Token = "0x4003F18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private CSContent m_content;

	[Token(Token = "0x4003F19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XWidget_ItemIcon m_icon;

	[Token(Token = "0x4003F1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Action<object> m_onClick;

	[Token(Token = "0x60059C7")]
	[Address(RVA = "0x15E9AF8", Offset = "0x15E9AF8", VA = "0x15E9AF8")]
	public XWidget_ContentIcon()
	{
	}

	[Token(Token = "0x60059C8")]
	[Address(RVA = "0x15E9B00", Offset = "0x15E9B00", VA = "0x15E9B00")]
	public static XWidget_ContentIcon CreateOneline(Transform parent, int fontSize, UIWidget.Pivot cellAlignment = UIWidget.Pivot.Center)
	{
		return null;
	}

	[Token(Token = "0x60059C9")]
	[Address(RVA = "0x15E9E88", Offset = "0x15E9E88", VA = "0x15E9E88")]
	public XWidget_ItemIcon GetItemIcon()
	{
		return null;
	}

	[Token(Token = "0x60059CA")]
	[Address(RVA = "0x15E9E90", Offset = "0x15E9E90", VA = "0x15E9E90")]
	public static XWidget_ContentIcon Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60059CB")]
	[Address(RVA = "0x15E9FFC", Offset = "0x15E9FFC", VA = "0x15E9FFC")]
	public void BuildWithOption(CSContent content, Option option)
	{
	}

	[Token(Token = "0x60059CC")]
	[Address(RVA = "0x15C1530", Offset = "0x15C1530", VA = "0x15C1530")]
	public void Build(CSContent content, Option option, [Optional] Action<object> onClick, bool bEnter = false, bool ItemContentIsUseItemIconQuantity = true)
	{
	}

	[Token(Token = "0x60059CD")]
	[Address(RVA = "0x15EA890", Offset = "0x15EA890", VA = "0x15EA890")]
	private void BuildContentIcon(CSContent content, bool bBackGround)
	{
	}

	[Token(Token = "0x60059CE")]
	[Address(RVA = "0x15EAACC", Offset = "0x15EAACC", VA = "0x15EAACC")]
	public void Hide()
	{
	}

	[Token(Token = "0x60059CF")]
	[Address(RVA = "0x15EA024", Offset = "0x15EA024", VA = "0x15EA024")]
	public void BuildQuantity(Option option, CSContent content)
	{
	}

	[Token(Token = "0x60059D0")]
	[Address(RVA = "0x15EA6B8", Offset = "0x15EA6B8", VA = "0x15EA6B8")]
	public void EnableBgFrame(Option option)
	{
	}

	[Token(Token = "0x60059D1")]
	[Address(RVA = "0x15EA79C", Offset = "0x15EA79C", VA = "0x15EA79C")]
	public void BuildBackground(Option option)
	{
	}

	[Token(Token = "0x60059D2")]
	[Address(RVA = "0x15EA380", Offset = "0x15EA380", VA = "0x15EA380")]
	private void BuildName(Option option, string name, bool bEnter, int quantity)
	{
	}

	[Token(Token = "0x60059D3")]
	[Address(RVA = "0x15EAB00", Offset = "0x15EAB00", VA = "0x15EAB00")]
	private string ReplaceEmptyName(string name)
	{
		return null;
	}

	[Token(Token = "0x60059D4")]
	[Address(RVA = "0x15EA87C", Offset = "0x15EA87C", VA = "0x15EA87C")]
	private bool HasOption(Option option1, Option option2)
	{
		return default(bool);
	}

	[Token(Token = "0x60059D5")]
	[Address(RVA = "0x15EAC04", Offset = "0x15EAC04", VA = "0x15EAC04")]
	public static Option RemoveOption(Option option, Option remove)
	{
		return default(Option);
	}

	[Token(Token = "0x60059D6")]
	[Address(RVA = "0x15EAC0C", Offset = "0x15EAC0C", VA = "0x15EAC0C")]
	public void BuildReceived(bool bShow)
	{
	}

	[Token(Token = "0x60059D7")]
	[Address(RVA = "0x15EACFC", Offset = "0x15EACFC", VA = "0x15EACFC")]
	public void OnClick()
	{
	}
}
