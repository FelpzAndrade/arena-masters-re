using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C9A")]
public class XWidget_Select : MonoBehaviour
{
	[Token(Token = "0x400402B")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblText;

	[Token(Token = "0x400402C")]
	[FieldOffset(Offset = "0x10")]
	public UIToggle toggleSelect;

	[Token(Token = "0x400402D")]
	[FieldOffset(Offset = "0x14")]
	private Action m_onSelect;

	[Token(Token = "0x14000060")]
	public event Action onSelect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0x1346530", Offset = "0x1346530", VA = "0x1346530")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0x13466BC", Offset = "0x13466BC", VA = "0x13466BC")]
		remove
		{
		}
	}

	[Token(Token = "0x6005B0A")]
	[Address(RVA = "0x1346528", Offset = "0x1346528", VA = "0x1346528")]
	public XWidget_Select()
	{
	}

	[Token(Token = "0x6005B0D")]
	[Address(RVA = "0x130E5F8", Offset = "0x130E5F8", VA = "0x130E5F8")]
	public void Select(bool isSelect)
	{
	}

	[Token(Token = "0x6005B0E")]
	[Address(RVA = "0x1346848", Offset = "0x1346848", VA = "0x1346848")]
	public void Setting(string text, Sprite spr, bool active, Action onSelect)
	{
	}

	[Token(Token = "0x6005B0F")]
	[Address(RVA = "0x1346A1C", Offset = "0x1346A1C", VA = "0x1346A1C")]
	private void OnChanged()
	{
	}
}
