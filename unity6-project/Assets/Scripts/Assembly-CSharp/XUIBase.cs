using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DA4")]
public class XUIBase : MonoBehaviour, ICommonBackableUI
{
	[Token(Token = "0x6006449")]
	[Address(RVA = "0x1A2B4F4", Offset = "0x1A2B4F4", VA = "0x1A2B4F4")]
	public XUIBase()
	{
	}

	[Token(Token = "0x600644A")]
	[Address(RVA = "0x1A2B4FC", Offset = "0x1A2B4FC", VA = "0x1A2B4FC", Slot = "11")]
	public virtual bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600644B")]
	[Address(RVA = "0x1A2B52C", Offset = "0x1A2B52C", VA = "0x1A2B52C", Slot = "12")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x600644C")]
	[Address(RVA = "0x1A2B560", Offset = "0x1A2B560", VA = "0x1A2B560", Slot = "13")]
	public virtual bool IsBackable()
	{
		return default(bool);
	}

	[Token(Token = "0x600644D")]
	[Address(RVA = "0x1A2B568", Offset = "0x1A2B568", VA = "0x1A2B568", Slot = "14")]
	public virtual bool IsLeaf()
	{
		return default(bool);
	}

	[Token(Token = "0x600644E")]
	[Address(RVA = "0x1A2B570", Offset = "0x1A2B570", VA = "0x1A2B570", Slot = "15")]
	public virtual string GetName()
	{
		return null;
	}

	[Token(Token = "0x600644F")]
	[Address(RVA = "0x1A2B5A0", Offset = "0x1A2B5A0", VA = "0x1A2B5A0", Slot = "16")]
	public virtual bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006450")]
	[Address(RVA = "0x1A2B5A8", Offset = "0x1A2B5A8", VA = "0x1A2B5A8", Slot = "17")]
	public virtual void SetPopupFunc(Action<ICommonBackableUI> registerPopup, Action<ICommonBackableUI> releasePopup)
	{
	}
}
