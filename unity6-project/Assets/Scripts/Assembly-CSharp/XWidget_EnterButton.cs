using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E9")]
public class XWidget_EnterButton : MonoBehaviour
{
	[Token(Token = "0x4002114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UITweener[] tweenList;

	[Token(Token = "0x4002115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<EventDelegate> onClick;

	[Token(Token = "0x4002116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UISprite sprPress;

	[Token(Token = "0x4002117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UI2DSprite sprMode;

	[Token(Token = "0x4002118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject goDisable;

	[Token(Token = "0x4002119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject goReqLv;

	[Token(Token = "0x400211A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject goLock;

	[Token(Token = "0x400211B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject goEffectOutline;

	[Token(Token = "0x400211C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GameObject goEffectGlass;

	[Token(Token = "0x400211D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel requireTeamLev;

	[Token(Token = "0x400211E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblName;

	[Token(Token = "0x400211F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UILabel lblTop;

	[Token(Token = "0x4002120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public TweenAlpha tweenTopLbl;

	[Token(Token = "0x4002121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblBottomDesc;

	[Token(Token = "0x4002122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public XUISound sound;

	[Token(Token = "0x4002123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject goMid;

	[Token(Token = "0x4002124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UILabel lblMidTop;

	[Token(Token = "0x4002125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject midLockGo;

	[Token(Token = "0x4002126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public GameObject openModeEventLogoObject;

	[Token(Token = "0x4002127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UILabel lblOpenModeDesc;

	[Token(Token = "0x4002128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public GameObject goReward;

	[Token(Token = "0x4002129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UI2DSprite sprRewarItemIcon;

	[Token(Token = "0x400212A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public UISprite sprFrame;

	[Token(Token = "0x400212B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool IsEnable__BackingField;

	[Token(Token = "0x1700081D")]
	public bool IsEnable
	{
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x15F4A30", Offset = "0x15F4A30", VA = "0x15F4A30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x15F4A38", Offset = "0x15F4A38", VA = "0x15F4A38")]
		private set
		{
		}
	}

	[Token(Token = "0x60039DB")]
	[Address(RVA = "0x15F459C", Offset = "0x15F459C", VA = "0x15F459C")]
	public XWidget_EnterButton()
	{
	}

	[Token(Token = "0x60039DC")]
	[Address(RVA = "0x15F4648", Offset = "0x15F4648", VA = "0x15F4648")]
	public void SetRewardIcon(bool isShow, string iconPath, Color frameColor)
	{
	}

	[Token(Token = "0x60039DD")]
	[Address(RVA = "0x15F4794", Offset = "0x15F4794", VA = "0x15F4794")]
	public void ShowModeEventLogo(bool isShow)
	{
	}

	[Token(Token = "0x60039DE")]
	[Address(RVA = "0x15F4874", Offset = "0x15F4874", VA = "0x15F4874")]
	public void SetOpenModeDescription(string text, bool isShowBackgroundSprite)
	{
	}

	[Token(Token = "0x60039E1")]
	[Address(RVA = "0x15F4A40", Offset = "0x15F4A40", VA = "0x15F4A40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60039E2")]
	[Address(RVA = "0x15F4A9C", Offset = "0x15F4A9C", VA = "0x15F4A9C")]
	public void SetLock(bool isLock)
	{
	}

	[Token(Token = "0x60039E3")]
	[Address(RVA = "0x15F4B7C", Offset = "0x15F4B7C", VA = "0x15F4B7C")]
	public void SetEnable(bool bEnable)
	{
	}

	[Token(Token = "0x60039E4")]
	[Address(RVA = "0x15F4D1C", Offset = "0x15F4D1C", VA = "0x15F4D1C")]
	public void ResetTween()
	{
	}

	[Token(Token = "0x60039E5")]
	[Address(RVA = "0x15F4D98", Offset = "0x15F4D98", VA = "0x15F4D98")]
	public void SetName(string title, [Optional] Color? color)
	{
	}

	[Token(Token = "0x60039E6")]
	[Address(RVA = "0x15F4F18", Offset = "0x15F4F18", VA = "0x15F4F18")]
	public void SetEffectGlass(bool isActive)
	{
	}

	[Token(Token = "0x60039E7")]
	[Address(RVA = "0x15F4FF8", Offset = "0x15F4FF8", VA = "0x15F4FF8")]
	public void SetEffectOutLine(bool isActive)
	{
	}

	[Token(Token = "0x60039E8")]
	[Address(RVA = "0x15F50D8", Offset = "0x15F50D8", VA = "0x15F50D8")]
	public void SetTop(string title, bool isTween, Color color)
	{
	}

	[Token(Token = "0x60039E9")]
	[Address(RVA = "0x15F5248", Offset = "0x15F5248", VA = "0x15F5248")]
	public void SetMidDesc(bool enable, string midTop, bool midLock)
	{
	}

	[Token(Token = "0x60039EA")]
	[Address(RVA = "0x15F53BC", Offset = "0x15F53BC", VA = "0x15F53BC")]
	public void SetBottomDesc(string title, [Optional] Color? color)
	{
	}

	[Token(Token = "0x60039EB")]
	[Address(RVA = "0x15F553C", Offset = "0x15F553C", VA = "0x15F553C")]
	public void SetImage(Sprite spr)
	{
	}

	[Token(Token = "0x60039EC")]
	[Address(RVA = "0x15F561C", Offset = "0x15F561C", VA = "0x15F561C")]
	public void SetReqLevel(int reqLevel, bool isShowed)
	{
	}

	[Token(Token = "0x60039ED")]
	[Address(RVA = "0x15F4BC0", Offset = "0x15F4BC0", VA = "0x15F4BC0")]
	private void SetSound(bool isEnable)
	{
	}

	[Token(Token = "0x60039EE")]
	[Address(RVA = "0x15F57D0", Offset = "0x15F57D0", VA = "0x15F57D0")]
	public void OnClick()
	{
	}
}
