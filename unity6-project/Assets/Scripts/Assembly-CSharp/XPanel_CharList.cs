using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DC0")]
public class XPanel_CharList : MonoBehaviour
{
	[Token(Token = "0x2000DC1")]
	private sealed class _003CRefresh_003Ec__AnonStorey1BC
	{
		[Token(Token = "0x400477B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int selectedCharID;

		[Token(Token = "0x400477C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Func<int, bool> onClickItem;

		[Token(Token = "0x400477D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool moveSelectedToBoundary;

		[Token(Token = "0x400477E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XPanel_CharList _003C_003Ef__this;

		[Token(Token = "0x600653F")]
		[Address(RVA = "0x169F430", Offset = "0x169F430", VA = "0x169F430")]
		public _003CRefresh_003Ec__AnonStorey1BC()
		{
		}

		[Token(Token = "0x6006540")]
		[Address(RVA = "0x169F56C", Offset = "0x169F56C", VA = "0x169F56C")]
		internal void _003C_003Em__342(int id)
		{
		}

		[Token(Token = "0x6006541")]
		[Address(RVA = "0x169F670", Offset = "0x169F670", VA = "0x169F670")]
		internal void _003C_003Em__343()
		{
		}
	}

	[Token(Token = "0x4004773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x4004774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TweenPosition tweenPos;

	[Token(Token = "0x4004775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XWidget_CharItem[] charItems;

	[Token(Token = "0x4004776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Func<int, bool> onClickItem;

	[Token(Token = "0x4004777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int selectedCharID;

	[Token(Token = "0x4004778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UIPanel panel;

	[Token(Token = "0x4004779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Transform checkRoot;

	[Token(Token = "0x400477A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool slideOut;

	[Token(Token = "0x6006534")]
	[Address(RVA = "0x169E5E4", Offset = "0x169E5E4", VA = "0x169E5E4")]
	public XPanel_CharList()
	{
	}

	[Token(Token = "0x6006535")]
	[Address(RVA = "0x169E5EC", Offset = "0x169E5EC", VA = "0x169E5EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006536")]
	[Address(RVA = "0x169E674", Offset = "0x169E674", VA = "0x169E674")]
	public void Build(int selectedCharID, Func<int, bool> onClickItem, [Optional] Transform checkRoot, bool moveSelectedToBoundary = false)
	{
	}

	[Token(Token = "0x6006537")]
	[Address(RVA = "0x169EFD4", Offset = "0x169EFD4", VA = "0x169EFD4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006538")]
	[Address(RVA = "0x169F008", Offset = "0x169F008", VA = "0x169F008")]
	private void Update()
	{
	}

	[Token(Token = "0x6006539")]
	[Address(RVA = "0x169F3B0", Offset = "0x169F3B0", VA = "0x169F3B0")]
	public void SlideOut()
	{
	}

	[Token(Token = "0x600653A")]
	[Address(RVA = "0x169F3F0", Offset = "0x169F3F0", VA = "0x169F3F0")]
	public void SlideIn()
	{
	}

	[Token(Token = "0x600653B")]
	[Address(RVA = "0x169E8C4", Offset = "0x169E8C4", VA = "0x169E8C4")]
	public void Refresh(int selectedCharID, Func<int, bool> onClickItem, bool moveSelectedToBoundary)
	{
	}

	[Token(Token = "0x600653C")]
	[Address(RVA = "0x169F448", Offset = "0x169F448", VA = "0x169F448")]
	private bool OnClickItem(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600653D")]
	[Address(RVA = "0x169F438", Offset = "0x169F438", VA = "0x169F438")]
	private void SetOnClick(Func<int, bool> onClickItem)
	{
	}

	[Token(Token = "0x600653E")]
	[Address(RVA = "0x169F4E8", Offset = "0x169F4E8", VA = "0x169F4E8")]
	private void RefreshSelect(int id)
	{
	}
}
