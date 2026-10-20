using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CAC")]
public class XWidget_TweenPosItemIcon : MonoBehaviour
{
	[Token(Token = "0x4004092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string PATH_ITEMDETAILPOPUP;

	[Token(Token = "0x4004093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Transform iconParent;

	[Token(Token = "0x4004094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblName;

	[Token(Token = "0x4004095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XItem m_item;

	[Token(Token = "0x4004096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XWidget_ItemIcon m_itemIcon;

	[Token(Token = "0x4004097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 originlocalPos;

	[Token(Token = "0x4004098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TweenPosition m_tweenPos;

	[Token(Token = "0x4004099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Action<XItem> m_onClick;

	[Token(Token = "0x400409A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int originSprGradeDepth;

	[Token(Token = "0x6005B78")]
	[Address(RVA = "0x1B320C4", Offset = "0x1B320C4", VA = "0x1B320C4")]
	public XWidget_TweenPosItemIcon()
	{
	}

	[Token(Token = "0x6005B7A")]
	[Address(RVA = "0x1B28010", Offset = "0x1B28010", VA = "0x1B28010")]
	public static XWidget_TweenPosItemIcon CreateItem(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6005B7B")]
	[Address(RVA = "0x1B3215C", Offset = "0x1B3215C", VA = "0x1B3215C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005B7C")]
	[Address(RVA = "0x1B32370", Offset = "0x1B32370", VA = "0x1B32370")]
	public void InitItemIcon(XWidget_ItemIcon itemIcon)
	{
	}

	[Token(Token = "0x6005B7D")]
	[Address(RVA = "0x1B32160", Offset = "0x1B32160", VA = "0x1B32160")]
	private void InitTweenPos()
	{
	}

	[Token(Token = "0x6005B7E")]
	[Address(RVA = "0x1B29B0C", Offset = "0x1B29B0C", VA = "0x1B29B0C")]
	public void Build(XItem item, Action<XItem> onClick, bool showInnerGrade = true)
	{
	}

	[Token(Token = "0x6005B7F")]
	[Address(RVA = "0x1B325D4", Offset = "0x1B325D4", VA = "0x1B325D4")]
	public void ShowCoolTimIcon(bool showIcon)
	{
	}

	[Token(Token = "0x6005B80")]
	[Address(RVA = "0x1B326B4", Offset = "0x1B326B4", VA = "0x1B326B4")]
	private void SetDefaultSprGrade(UIBasicSprite sprGrade, bool showGrade = false)
	{
	}

	[Token(Token = "0x6005B81")]
	[Address(RVA = "0x1B2B028", Offset = "0x1B2B028", VA = "0x1B2B028")]
	public void PlayTweenPos(Vector3 to, [Optional] EventDelegate finishDelegate)
	{
	}

	[Token(Token = "0x6005B82")]
	[Address(RVA = "0x1B32738", Offset = "0x1B32738", VA = "0x1B32738")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6005B83")]
	[Address(RVA = "0x1B327D0", Offset = "0x1B327D0", VA = "0x1B327D0")]
	private void _003CPlayTweenPos_003Em__270()
	{
	}
}
