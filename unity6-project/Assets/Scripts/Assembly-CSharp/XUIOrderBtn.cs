using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D2B")]
public class XUIOrderBtn : MonoBehaviour
{
	[Token(Token = "0x2000D2C")]
	public enum OrderBtnState
	{
		[Token(Token = "0x4004362")]
		Normal = 0,
		[Token(Token = "0x4004363")]
		Highlight = 1,
		[Token(Token = "0x4004364")]
		Arrow = 2
	}

	[Token(Token = "0x400435A")]
	[FieldOffset(Offset = "0xC")]
	public TweenPosition arrow;

	[Token(Token = "0x400435B")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x400435C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject sprFrame;

	[Token(Token = "0x400435D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblOrder;

	[Token(Token = "0x400435E")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;

	[Token(Token = "0x400435F")]
	[FieldOffset(Offset = "0x20")]
	private Action<int, int> m_clickAction;

	[Token(Token = "0x4004360")]
	[FieldOffset(Offset = "0x24")]
	private int CharID__BackingField;

	[Token(Token = "0x17000D1C")]
	public int CharID
	{
		[Token(Token = "0x60060A0")]
		[Address(RVA = "0x1906034", Offset = "0x1906034", VA = "0x1906034")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60060A1")]
		[Address(RVA = "0x190603C", Offset = "0x190603C", VA = "0x190603C")]
		private set
		{
		}
	}

	[Token(Token = "0x600609F")]
	[Address(RVA = "0x190602C", Offset = "0x190602C", VA = "0x190602C")]
	public XUIOrderBtn()
	{
	}

	[Token(Token = "0x60060A2")]
	[Address(RVA = "0x1906044", Offset = "0x1906044", VA = "0x1906044")]
	public void Build(int index, int charID, Action<int, int> clickAction)
	{
	}

	[Token(Token = "0x60060A3")]
	[Address(RVA = "0x1906218", Offset = "0x1906218", VA = "0x1906218")]
	public void SetCharID(int charID)
	{
	}

	[Token(Token = "0x60060A4")]
	[Address(RVA = "0x1906054", Offset = "0x1906054", VA = "0x1906054")]
	private void BuildUI()
	{
	}

	[Token(Token = "0x60060A5")]
	[Address(RVA = "0x19063FC", Offset = "0x19063FC", VA = "0x19063FC")]
	public void OnClickBtn()
	{
	}

	[Token(Token = "0x60060A6")]
	[Address(RVA = "0x1906394", Offset = "0x1906394", VA = "0x1906394")]
	public void SetUIState(OrderBtnState state)
	{
	}

	[Token(Token = "0x60060A7")]
	[Address(RVA = "0x1906490", Offset = "0x1906490", VA = "0x1906490")]
	public void SetArrowActive(bool isActive)
	{
	}

	[Token(Token = "0x60060A8")]
	[Address(RVA = "0x19064EC", Offset = "0x19064EC", VA = "0x19064EC")]
	public void SetFrameActive(bool isActive)
	{
	}
}
