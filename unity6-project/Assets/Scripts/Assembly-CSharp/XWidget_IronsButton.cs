using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F96")]
public class XWidget_IronsButton : UIBase
{
	[Token(Token = "0x400526B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblMessage;

	[Token(Token = "0x400526C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UIProgressBar progressBar;

	[Token(Token = "0x400526D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblCounting;

	[Token(Token = "0x400526E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TweenPosition tweenPosition;

	[Token(Token = "0x400526F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public TweenScale tweenScale;

	[Token(Token = "0x4005270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject btnEffect;

	[Token(Token = "0x6007417")]
	[Address(RVA = "0x1450348", Offset = "0x1450348", VA = "0x1450348")]
	public XWidget_IronsButton()
	{
	}

	[Token(Token = "0x6007418")]
	[Address(RVA = "0x1450350", Offset = "0x1450350", VA = "0x1450350", Slot = "12")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x6007419")]
	[Address(RVA = "0x14509E8", Offset = "0x14509E8", VA = "0x14509E8")]
	private void TweenPlay()
	{
	}

	[Token(Token = "0x600741A")]
	[Address(RVA = "0x1450A5C", Offset = "0x1450A5C", VA = "0x1450A5C")]
	private void TweenReset()
	{
	}

	[Token(Token = "0x600741B")]
	[Address(RVA = "0x1450580", Offset = "0x1450580", VA = "0x1450580")]
	private void SetShowHide()
	{
	}

	[Token(Token = "0x600741C")]
	[Address(RVA = "0x14506D8", Offset = "0x14506D8", VA = "0x14506D8")]
	private void SetDescription(IronsMission ironsMissionInfo, IronsMissionState ironsMissionState)
	{
	}

	[Token(Token = "0x600741D")]
	[Address(RVA = "0x1450804", Offset = "0x1450804", VA = "0x1450804")]
	private void SetProgressBar(IronsMission ironsMissionInfo, IronsMissionState ironsMissionState)
	{
	}

	[Token(Token = "0x600741E")]
	[Address(RVA = "0x1450BA0", Offset = "0x1450BA0", VA = "0x1450BA0")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}
}
