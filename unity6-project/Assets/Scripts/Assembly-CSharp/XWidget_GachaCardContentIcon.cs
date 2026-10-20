using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C7B")]
public class XWidget_GachaCardContentIcon : MonoBehaviour
{
	[Token(Token = "0x2000C7C")]
	public enum Option
	{
		[Token(Token = "0x4003F5D")]
		None = 0,
		[Token(Token = "0x4003F5E")]
		Background = 1,
		[Token(Token = "0x4003F5F")]
		Quantity = 2,
		[Token(Token = "0x4003F60")]
		OwnedCount = 4,
		[Token(Token = "0x4003F61")]
		Tooltip = 8,
		[Token(Token = "0x4003F62")]
		Name = 16,
		[Token(Token = "0x4003F63")]
		NotIncludeOne = 32,
		[Token(Token = "0x4003F64")]
		Grade = 64,
		[Token(Token = "0x4003F65")]
		NameCountQuantityBG = 128,
		[Token(Token = "0x4003F66")]
		IconWithBackGround = 256,
		[Token(Token = "0x4003F67")]
		All = 255
	}

	[Token(Token = "0x4003F50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x4003F51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UI2DSprite sprCharIcon;

	[Token(Token = "0x4003F52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject itemIconParent;

	[Token(Token = "0x4003F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject sprBg;

	[Token(Token = "0x4003F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject sprContentBg;

	[Token(Token = "0x4003F55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblQuantity;

	[Token(Token = "0x4003F56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblName;

	[Token(Token = "0x4003F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblItemTypeName;

	[Token(Token = "0x4003F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblReceived;

	[Token(Token = "0x4003F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CSContent m_content;

	[Token(Token = "0x4003F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XWidget_ItemGachaCardIcon m_icon;

	[Token(Token = "0x4003F5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action<object> m_onClick;

	[Token(Token = "0x6005A08")]
	[Address(RVA = "0x1433BAC", Offset = "0x1433BAC", VA = "0x1433BAC")]
	public XWidget_GachaCardContentIcon()
	{
	}

	[Token(Token = "0x6005A09")]
	[Address(RVA = "0x1433BB4", Offset = "0x1433BB4", VA = "0x1433BB4")]
	private void ShowSmallIconName(ref CSContent content, Option option, bool bEnter)
	{
	}

	[Token(Token = "0x6005A0A")]
	[Address(RVA = "0x1433EAC", Offset = "0x1433EAC", VA = "0x1433EAC")]
	public void Build(CSContent content, Option option, [Optional] Action<object> onClick, bool bEnter = false)
	{
	}

	[Token(Token = "0x6005A0B")]
	[Address(RVA = "0x1433D1C", Offset = "0x1433D1C", VA = "0x1433D1C")]
	private bool SameNameAndType(ref CSContent content)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A0C")]
	[Address(RVA = "0x1434580", Offset = "0x1434580", VA = "0x1434580")]
	private void BuildContent(CSContent content, Option option)
	{
	}

	[Token(Token = "0x6005A0D")]
	[Address(RVA = "0x1434CB4", Offset = "0x1434CB4", VA = "0x1434CB4")]
	private void SetItemTypeText(CSContent content)
	{
	}

	[Token(Token = "0x6005A0E")]
	[Address(RVA = "0x1435750", Offset = "0x1435750", VA = "0x1435750")]
	private void BuildContentIcon(CSContent content, bool bBackGround)
	{
	}

	[Token(Token = "0x6005A0F")]
	[Address(RVA = "0x1435E1C", Offset = "0x1435E1C", VA = "0x1435E1C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005A10")]
	[Address(RVA = "0x14341FC", Offset = "0x14341FC", VA = "0x14341FC")]
	private void BuildBackground(Option option)
	{
	}

	[Token(Token = "0x6005A11")]
	[Address(RVA = "0x14342F4", Offset = "0x14342F4", VA = "0x14342F4")]
	private void BuildQuantity(Option option, CSContent content)
	{
	}

	[Token(Token = "0x6005A12")]
	[Address(RVA = "0x1433D5C", Offset = "0x1433D5C", VA = "0x1433D5C")]
	private void BuildName(Option option, string name, bool bEnter)
	{
	}

	[Token(Token = "0x6005A13")]
	[Address(RVA = "0x1435E50", Offset = "0x1435E50", VA = "0x1435E50")]
	private string ReplaceEmptyName(string name)
	{
		return null;
	}

	[Token(Token = "0x6005A14")]
	[Address(RVA = "0x1435030", Offset = "0x1435030", VA = "0x1435030")]
	private bool HasOption(Option option1, Option option2)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A15")]
	[Address(RVA = "0x1435F54", Offset = "0x1435F54", VA = "0x1435F54")]
	public static Option RemoveOption(Option option, Option remove)
	{
		return default(Option);
	}

	[Token(Token = "0x6005A16")]
	[Address(RVA = "0x1435F5C", Offset = "0x1435F5C", VA = "0x1435F5C")]
	public void BuildReceived(bool bShow)
	{
	}

	[Token(Token = "0x6005A17")]
	[Address(RVA = "0x143604C", Offset = "0x143604C", VA = "0x143604C")]
	public void OnClick()
	{
	}
}
