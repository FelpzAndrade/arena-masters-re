using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200101B")]
public class XUIBaseWidget : XCommonBackUI
{
	[Token(Token = "0x400564B")]
	[FieldOffset(Offset = "0x18")]
	private Action m_AllClearPopup;

	[Token(Token = "0x600781E")]
	[Address(RVA = "0x1A2C12C", Offset = "0x1A2C12C", VA = "0x1A2C12C")]
	public XUIBaseWidget()
	{
	}

	[Token(Token = "0x600781F")]
	public T MakePopup<T>(string filePath, Transform transform) where T : XUIBaseWidget
	{
		return null;
	}

	[Token(Token = "0x6007820")]
	public T MakePopup<T>(GameObject prefab, Transform transform) where T : XUIBaseWidget
	{
		return null;
	}

	[Token(Token = "0x6007821")]
	[Address(RVA = "0x1A2B810", Offset = "0x1A2B810", VA = "0x1A2B810")]
	public void SetRegisterFunc(Action<ICommonBackableUI> registerFunc, Action<ICommonBackableUI> releaseFunc, Action allClearPopup)
	{
	}

	[Token(Token = "0x6007822")]
	[Address(RVA = "0x1A2C134", Offset = "0x1A2C134", VA = "0x1A2C134")]
	public void SetParentRegisterFunc(XUIBaseWidget widget)
	{
	}

	[Token(Token = "0x6007823")]
	[Address(RVA = "0x1A2C184", Offset = "0x1A2C184", VA = "0x1A2C184")]
	public void AllClearPopup()
	{
	}
}
