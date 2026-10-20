using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E0A")]
public class XPanel_PetList : MonoBehaviour
{
	[Token(Token = "0x2000E0B")]
	private sealed class _003CRefresh_003Ec__AnonStorey1DF
	{
		[Token(Token = "0x40049B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int selectedCharID;

		[Token(Token = "0x40049B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Func<int, bool> onClickItem;

		[Token(Token = "0x40049B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool moveSelectedToBoundary;

		[Token(Token = "0x40049B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XPanel_PetList _003C_003Ef__this;

		[Token(Token = "0x600684D")]
		[Address(RVA = "0x1018CDC", Offset = "0x1018CDC", VA = "0x1018CDC")]
		public _003CRefresh_003Ec__AnonStorey1DF()
		{
		}

		[Token(Token = "0x600684E")]
		[Address(RVA = "0x1018E18", Offset = "0x1018E18", VA = "0x1018E18")]
		internal void _003C_003Em__3AA(int id)
		{
		}

		[Token(Token = "0x600684F")]
		[Address(RVA = "0x1018F20", Offset = "0x1018F20", VA = "0x1018F20")]
		internal void _003C_003Em__3AB()
		{
		}
	}

	[Token(Token = "0x40049A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x40049AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TweenPosition tweenPos;

	[Token(Token = "0x40049AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XWidget_PetItem[] charItems;

	[Token(Token = "0x40049AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Func<int, bool> onClickItem;

	[Token(Token = "0x40049AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int selectedCharID;

	[Token(Token = "0x40049AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UIPanel panel;

	[Token(Token = "0x40049AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Transform checkRoot;

	[Token(Token = "0x40049B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool slideOut;

	[Token(Token = "0x6006841")]
	[Address(RVA = "0x1017EE4", Offset = "0x1017EE4", VA = "0x1017EE4")]
	public XPanel_PetList()
	{
	}

	[Token(Token = "0x6006842")]
	[Address(RVA = "0x1017EEC", Offset = "0x1017EEC", VA = "0x1017EEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006843")]
	[Address(RVA = "0x1017F74", Offset = "0x1017F74", VA = "0x1017F74")]
	public void Build(int selectedCharID, Func<int, bool> onClickItem, [Optional] Transform checkRoot, bool moveSelectedToBoundary = false)
	{
	}

	[Token(Token = "0x6006844")]
	[Address(RVA = "0x1018880", Offset = "0x1018880", VA = "0x1018880")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006845")]
	[Address(RVA = "0x10188B4", Offset = "0x10188B4", VA = "0x10188B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6006846")]
	[Address(RVA = "0x1018C5C", Offset = "0x1018C5C", VA = "0x1018C5C")]
	public void SlideOut()
	{
	}

	[Token(Token = "0x6006847")]
	[Address(RVA = "0x1018C9C", Offset = "0x1018C9C", VA = "0x1018C9C")]
	public void SlideIn()
	{
	}

	[Token(Token = "0x6006848")]
	[Address(RVA = "0x1018188", Offset = "0x1018188", VA = "0x1018188")]
	public void Refresh(int selectedCharID, Func<int, bool> onClickItem, bool moveSelectedToBoundary)
	{
	}

	[Token(Token = "0x6006849")]
	[Address(RVA = "0x101572C", Offset = "0x101572C", VA = "0x101572C")]
	public void Refresh(int charID)
	{
	}

	[Token(Token = "0x600684A")]
	[Address(RVA = "0x1018CF4", Offset = "0x1018CF4", VA = "0x1018CF4")]
	private bool OnClickItem(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600684B")]
	[Address(RVA = "0x1018CE4", Offset = "0x1018CE4", VA = "0x1018CE4")]
	private void SetOnClick(Func<int, bool> onClickItem)
	{
	}

	[Token(Token = "0x600684C")]
	[Address(RVA = "0x1018D94", Offset = "0x1018D94", VA = "0x1018D94")]
	private void RefreshSelect(int id)
	{
	}
}
