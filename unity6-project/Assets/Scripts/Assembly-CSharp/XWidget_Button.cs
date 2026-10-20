using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F6D")]
public class XWidget_Button : MonoBehaviour
{
	[Token(Token = "0x4005138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4005139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel[] lblDesc;

	[Token(Token = "0x400513A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XUISound sound;

	[Token(Token = "0x400513B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprBg;

	[Token(Token = "0x400513C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIBasicSprite sprDisable;

	[Token(Token = "0x400513D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UI2DSprite[] sprIcon;

	[Token(Token = "0x400513E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UISprite sprSelectable;

	[Token(Token = "0x400513F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool UseDisableBtnScaleTween;

	[Token(Token = "0x4005140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected Action m_onClick;

	[Token(Token = "0x4005141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Action m_onDisableClick;

	[Token(Token = "0x4005142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected bool m_isDisable;

	[Token(Token = "0x4005143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UIWidget[] m_widgets;

	[Token(Token = "0x4005144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Color[] m_colors;

	[Token(Token = "0x4005145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UIButtonScale m_buttonScale;

	[Token(Token = "0x4005146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int widgetDepth;

	[Token(Token = "0x4005147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UIDragScrollView dragScrollView_;

	[Token(Token = "0x17000E9F")]
	public bool IsDisable
	{
		[Token(Token = "0x60072C1")]
		[Address(RVA = "0x15C36FC", Offset = "0x15C36FC", VA = "0x15C36FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60072C0")]
	[Address(RVA = "0x15C36E8", Offset = "0x15C36E8", VA = "0x15C36E8")]
	public XWidget_Button()
	{
	}

	[Token(Token = "0x60072C2")]
	[Address(RVA = "0x15C3704", Offset = "0x15C3704", VA = "0x15C3704")]
	private void Awake()
	{
	}

	[Token(Token = "0x60072C3")]
	[Address(RVA = "0x15C39D0", Offset = "0x15C39D0", VA = "0x15C39D0")]
	private void InitWidgetColors()
	{
	}

	[Token(Token = "0x60072C4")]
	[Address(RVA = "0x15C3A7C", Offset = "0x15C3A7C", VA = "0x15C3A7C", Slot = "4")]
	public virtual void Build(string title, Action onClick, [Optional][DefaultParameterValue(false)] bool isDisable, [Optional] Action onDisableClick)
	{
	}

	[Token(Token = "0x60072C5")]
	[Address(RVA = "0x15C3AC0", Offset = "0x15C3AC0", VA = "0x15C3AC0")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x60072C6")]
	[Address(RVA = "0x15C3BAC", Offset = "0x15C3BAC", VA = "0x15C3BAC")]
	public void SetDisable(bool disable)
	{
	}

	[Token(Token = "0x60072C7")]
	[Address(RVA = "0x15C42B0", Offset = "0x15C42B0", VA = "0x15C42B0")]
	public void SetSoundType(XUISound.UISound type)
	{
	}

	[Token(Token = "0x60072C8")]
	[Address(RVA = "0x15C3F8C", Offset = "0x15C3F8C", VA = "0x15C3F8C")]
	private void SetLabelColor(UILabel lblLabel, bool disable)
	{
	}

	[Token(Token = "0x60072C9")]
	[Address(RVA = "0x15C418C", Offset = "0x15C418C", VA = "0x15C418C")]
	private void SetIconAlpha(UIBasicSprite sprIcon, bool disable)
	{
	}

	[Token(Token = "0x60072CA")]
	[Address(RVA = "0x15BE888", Offset = "0x15BE888", VA = "0x15BE888")]
	public void Show(bool bShow)
	{
	}

	[Token(Token = "0x60072CB")]
	[Address(RVA = "0x15C4388", Offset = "0x15C4388", VA = "0x15C4388", Slot = "5")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x60072CC")]
	[Address(RVA = "0x15C43B0", Offset = "0x15C43B0", VA = "0x15C43B0")]
	protected void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x60072CD")]
	[Address(RVA = "0x15C4490", Offset = "0x15C4490", VA = "0x15C4490")]
	protected void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60072CE")]
	[Address(RVA = "0x15C4578", Offset = "0x15C4578", VA = "0x15C4578")]
	public void SetIcon(Sprite spr, int iconIdx = 0)
	{
	}
}
