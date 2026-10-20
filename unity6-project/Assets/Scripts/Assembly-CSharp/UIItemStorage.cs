using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019B")]
public class UIItemStorage : MonoBehaviour
{
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0xC")]
	public int maxItemCount;

	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x10")]
	public int maxRows;

	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x14")]
	public int maxColumns;

	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject template;

	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget background;

	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x20")]
	public int spacing;

	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x24")]
	public int padding;

	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x28")]
	private List<InvGameItem> mItems;

	[Token(Token = "0x1700023E")]
	public List<InvGameItem> items
	{
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x16FDB04", Offset = "0x16FDB04", VA = "0x16FDB04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x16FDA34", Offset = "0x16FDA34", VA = "0x16FDA34")]
	public UIItemStorage()
	{
	}

	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x16FDBE8", Offset = "0x16FDBE8", VA = "0x16FDBE8")]
	public InvGameItem GetItem(int slot)
	{
		return null;
	}

	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x16FDCC8", Offset = "0x16FDCC8", VA = "0x16FDCC8")]
	public InvGameItem Replace(int slot, InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x16FDDC0", Offset = "0x16FDDC0", VA = "0x16FDDC0")]
	private void Start()
	{
	}
}
