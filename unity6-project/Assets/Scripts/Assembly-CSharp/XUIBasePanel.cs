using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200101A")]
public class XUIBasePanel : XUIBase
{
	[Token(Token = "0x400564A")]
	[FieldOffset(Offset = "0xC")]
	private Stack<ICommonBackableUI> backStack;

	[Token(Token = "0x17000EF7")]
	protected virtual int BackableStackCount
	{
		[Token(Token = "0x6007814")]
		[Address(RVA = "0x1A2B658", Offset = "0x1A2B658", VA = "0x1A2B658", Slot = "18")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007813")]
	[Address(RVA = "0x1A2B5AC", Offset = "0x1A2B5AC", VA = "0x1A2B5AC")]
	public XUIBasePanel()
	{
	}

	[Token(Token = "0x6007815")]
	public T MakePopup<T>(string filePath, Transform transform) where T : XUIBaseWidget
	{
		return null;
	}

	[Token(Token = "0x6007816")]
	public T MakePopup<T>(GameObject prefab, Transform transform) where T : XUIBaseWidget
	{
		return null;
	}

	[Token(Token = "0x6007817")]
	[Address(RVA = "0x1A2B660", Offset = "0x1A2B660", VA = "0x1A2B660")]
	protected void SetPopupRegisterFunc(XUIBaseWidget widget)
	{
	}

	[Token(Token = "0x6007818")]
	[Address(RVA = "0x1A2B838", Offset = "0x1A2B838", VA = "0x1A2B838")]
	protected void RegisterPopup(ICommonBackableUI widget)
	{
	}

	[Token(Token = "0x6007819")]
	[Address(RVA = "0x1A2B9E4", Offset = "0x1A2B9E4", VA = "0x1A2B9E4")]
	public void AllClearPopup()
	{
	}

	[Token(Token = "0x600781A")]
	[Address(RVA = "0x1A2BB60", Offset = "0x1A2BB60", VA = "0x1A2BB60", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x600781B")]
	[Address(RVA = "0x1A2BE94", Offset = "0x1A2BE94", VA = "0x1A2BE94")]
	public void ReleasePopup(ICommonBackableUI popup)
	{
	}

	[Token(Token = "0x600781C")]
	[Address(RVA = "0x1A2B908", Offset = "0x1A2B908", VA = "0x1A2B908")]
	private void TryPeek(out ICommonBackableUI popup)
	{
		popup = default;
	}

	[Token(Token = "0x600781D")]
	[Address(RVA = "0x1A2C110", Offset = "0x1A2C110", VA = "0x1A2C110", Slot = "12")]
	public override void Hide()
	{
	}
}
