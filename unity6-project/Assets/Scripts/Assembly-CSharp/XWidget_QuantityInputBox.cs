using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FD2")]
public class XWidget_QuantityInputBox : MonoBehaviour
{
	[Token(Token = "0x400541B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UIInput inputBox;

	[Token(Token = "0x400541C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XButton_OnPress btnIncrese;

	[Token(Token = "0x400541D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XButton_OnPress btnDecrese;

	[Token(Token = "0x400541E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject btnHideIncrese;

	[Token(Token = "0x400541F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject btnHideDecrese;

	[Token(Token = "0x4005420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action m_onSetValue;

	[Token(Token = "0x4005421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Action m_onPressMax;

	[Token(Token = "0x4005422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action m_onPressLimit;

	[Token(Token = "0x4005423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int m_minValue;

	[Token(Token = "0x4005424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int m_hasCount;

	[Token(Token = "0x4005425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int m_packCount;

	[Token(Token = "0x4005426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_limitValue;

	[Token(Token = "0x4005427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int m_oneValue;

	[Token(Token = "0x17000EE0")]
	public int LimitValue
	{
		[Token(Token = "0x60075DE")]
		[Address(RVA = "0x132B250", Offset = "0x132B250", VA = "0x132B250")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60075DD")]
	[Address(RVA = "0x132B23C", Offset = "0x132B23C", VA = "0x132B23C")]
	public XWidget_QuantityInputBox()
	{
	}

	[Token(Token = "0x60075DF")]
	[Address(RVA = "0x132B258", Offset = "0x132B258", VA = "0x132B258")]
	private void Awake()
	{
	}

	[Token(Token = "0x60075E0")]
	[Address(RVA = "0x132B518", Offset = "0x132B518", VA = "0x132B518")]
	public void Build(int startValue, int hasCount, int limitValue, [Optional] Action onSetValue, [Optional] Action onPressMax, [Optional] Action onPressLimit, int packCount = 1)
	{
	}

	[Token(Token = "0x60075E1")]
	[Address(RVA = "0x132B694", Offset = "0x132B694", VA = "0x132B694")]
	public void SetMinValue(int minValue)
	{
	}

	[Token(Token = "0x60075E2")]
	[Address(RVA = "0x132B69C", Offset = "0x132B69C", VA = "0x132B69C")]
	private int GetHasQuantity()
	{
		return default(int);
	}

	[Token(Token = "0x60075E3")]
	[Address(RVA = "0x132B6AC", Offset = "0x132B6AC", VA = "0x132B6AC")]
	private int GetLimitQuantity()
	{
		return default(int);
	}

	[Token(Token = "0x60075E4")]
	[Address(RVA = "0x132B6F8", Offset = "0x132B6F8", VA = "0x132B6F8")]
	public int GetTotal(int oneValue)
	{
		return default(int);
	}

	[Token(Token = "0x60075E5")]
	[Address(RVA = "0x132B710", Offset = "0x132B710", VA = "0x132B710")]
	public int GetValue()
	{
		return default(int);
	}

	[Token(Token = "0x60075E6")]
	[Address(RVA = "0x132B77C", Offset = "0x132B77C", VA = "0x132B77C")]
	public void RefreshValues()
	{
	}

	[Token(Token = "0x60075E7")]
	[Address(RVA = "0x132B79C", Offset = "0x132B79C", VA = "0x132B79C")]
	private void GetMaxQuantity(out bool isLimit, out int maxQuantity)
	{
		isLimit = default;
		maxQuantity = default;
	}

	[Token(Token = "0x60075E8")]
	[Address(RVA = "0x132B54C", Offset = "0x132B54C", VA = "0x132B54C")]
	public void SetValue(int quantity)
	{
	}

	[Token(Token = "0x60075E9")]
	[Address(RVA = "0x132B81C", Offset = "0x132B81C", VA = "0x132B81C")]
	public void SetArrowForMaxValue(int quantity)
	{
	}

	[Token(Token = "0x60075EA")]
	[Address(RVA = "0x132B8AC", Offset = "0x132B8AC", VA = "0x132B8AC")]
	public void OnClick_IncreseQuantity()
	{
	}

	[Token(Token = "0x60075EB")]
	[Address(RVA = "0x132B8F4", Offset = "0x132B8F4", VA = "0x132B8F4")]
	public void OnClick_DisableIncreseQuantity()
	{
	}

	[Token(Token = "0x60075EC")]
	[Address(RVA = "0x132B984", Offset = "0x132B984", VA = "0x132B984")]
	public void OnClick_DecreseQuantity()
	{
	}

	[Token(Token = "0x60075ED")]
	[Address(RVA = "0x132B9A4", Offset = "0x132B9A4", VA = "0x132B9A4")]
	public bool IsClickPressCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60075EE")]
	[Address(RVA = "0x132B9F8", Offset = "0x132B9F8", VA = "0x132B9F8")]
	private void _003CAwake_003Em__4DA()
	{
	}

	[Token(Token = "0x60075EF")]
	[Address(RVA = "0x132BA18", Offset = "0x132BA18", VA = "0x132BA18")]
	private void _003CAwake_003Em__4DB()
	{
	}
}
