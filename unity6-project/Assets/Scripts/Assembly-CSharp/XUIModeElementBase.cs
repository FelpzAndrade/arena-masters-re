using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E4")]
public abstract class XUIModeElementBase : MonoBehaviour
{
	[Token(Token = "0x40020EB")]
	[FieldOffset(Offset = "0xC")]
	public List<EventDelegate> onClick;

	[Token(Token = "0x40020EC")]
	[FieldOffset(Offset = "0x10")]
	public UITweener[] tweenList;

	[Token(Token = "0x40020ED")]
	[FieldOffset(Offset = "0x14")]
	public XGameModeType modeType;

	[Token(Token = "0x40020EE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject disableSpr;

	[Token(Token = "0x40020EF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel requireTeamLev;

	[Token(Token = "0x40020F0")]
	[FieldOffset(Offset = "0x20")]
	public XUISound sound;

	[Token(Token = "0x40020F1")]
	[FieldOffset(Offset = "0x24")]
	public BoxCollider boxCollider;

	[Token(Token = "0x40020F2")]
	[FieldOffset(Offset = "0x28")]
	private bool IsEnable__BackingField;

	[Token(Token = "0x1700081C")]
	public bool IsEnable
	{
		[Token(Token = "0x60039AE")]
		[Address(RVA = "0x10D2ADC", Offset = "0x10D2ADC", VA = "0x10D2ADC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60039AF")]
		[Address(RVA = "0x1096DD4", Offset = "0x1096DD4", VA = "0x1096DD4")]
		protected set
		{
		}
	}

	[Token(Token = "0x60039AD")]
	[Address(RVA = "0x1096AB0", Offset = "0x1096AB0", VA = "0x1096AB0")]
	protected XUIModeElementBase()
	{
	}

	[Token(Token = "0x60039B0")]
	[Address(RVA = "0x1096DDC", Offset = "0x1096DDC", VA = "0x1096DDC")]
	protected void RefreshEnable(int reqLv)
	{
	}

	[Token(Token = "0x60039B1")]
	[Address(RVA = "0x10D2C7C", Offset = "0x10D2C7C", VA = "0x10D2C7C")]
	public void ResetTween()
	{
	}

	[Token(Token = "0x60039B2")]
	[Address(RVA = "0x10D2AE4", Offset = "0x10D2AE4", VA = "0x10D2AE4")]
	protected void SetReqLevel(int reqLevel, bool isUnlock)
	{
	}

	[Token(Token = "0x60039B3")]
	[Address(RVA = "0x1097930", Offset = "0x1097930", VA = "0x1097930")]
	protected void SetSound(bool isEnable)
	{
	}

	[Token(Token = "0x60039B4")]
	[Address(RVA = "0x1097850", Offset = "0x1097850", VA = "0x1097850")]
	protected void SetDisable(bool isDiasble)
	{
	}

	[Token(Token = "0x60039B5")]
	[Address(RVA = "0x10D2CF8", Offset = "0x10D2CF8", VA = "0x10D2CF8")]
	protected void SetEnableBoxColider(bool enable)
	{
	}

	[Token(Token = "0x60039B6")]
	[Address(RVA = "0x10D2DD4", Offset = "0x10D2DD4", VA = "0x10D2DD4")]
	public void OnClick()
	{
	}
}
