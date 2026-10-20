using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000DB4")]
public class XPanel_ArenaShop : UIBase
{
	[Token(Token = "0x2000DB5")]
	public enum State
	{
		[Token(Token = "0x4004727")]
		None = 0,
		[Token(Token = "0x4004728")]
		Skin = 1,
		[Token(Token = "0x4004729")]
		Equipment = 2,
		[Token(Token = "0x400472A")]
		Etc = 3,
		[Token(Token = "0x400472B")]
		Goods = 4,
		[Token(Token = "0x400472C")]
		Max = 5
	}

	[Token(Token = "0x400471D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XUITabView TabView;

	[Token(Token = "0x400471E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XUIScrollView ItemView;

	[Token(Token = "0x400471F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblCloseMessage;

	[Token(Token = "0x4004720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIButton btnCommerce;

	[Token(Token = "0x4004721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIButton btnBilling;

	[Token(Token = "0x4004722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private State m_state;

	[Token(Token = "0x4004723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private HashSet<State> m_States;

	[Token(Token = "0x4004724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Func<CSArenaShopItem, int> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4004725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Func<CSArenaShopItem, int> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x17000D4D")]
	public static XPanel_ArenaShop Instance
	{
		[Token(Token = "0x60064CA")]
		[Address(RVA = "0x16931D4", Offset = "0x16931D4", VA = "0x16931D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60064C9")]
	[Address(RVA = "0x16931CC", Offset = "0x16931CC", VA = "0x16931CC")]
	public XPanel_ArenaShop()
	{
	}

	[Token(Token = "0x60064CB")]
	[Address(RVA = "0x16932E0", Offset = "0x16932E0", VA = "0x16932E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60064CC")]
	[Address(RVA = "0x16932E4", Offset = "0x16932E4", VA = "0x16932E4")]
	private void Build()
	{
	}

	[Token(Token = "0x60064CD")]
	[Address(RVA = "0x16932E8", Offset = "0x16932E8", VA = "0x16932E8", Slot = "9")]
	public override void Show()
	{
	}

	[Token(Token = "0x60064CE")]
	[Address(RVA = "0x169333C", Offset = "0x169333C", VA = "0x169333C", Slot = "11")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60064CF")]
	[Address(RVA = "0x169338C", Offset = "0x169338C", VA = "0x169338C")]
	public void SetState(State state)
	{
	}

	[Token(Token = "0x60064D0")]
	[Address(RVA = "0x1693480", Offset = "0x1693480", VA = "0x1693480", Slot = "12")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x60064D1")]
	[Address(RVA = "0x1694208", Offset = "0x1694208", VA = "0x1694208")]
	public void RefreshByTime()
	{
	}

	[Token(Token = "0x60064D2")]
	[Address(RVA = "0x169351C", Offset = "0x169351C", VA = "0x169351C")]
	public void RefreshTabView()
	{
	}

	[Token(Token = "0x60064D3")]
	[Address(RVA = "0x1694000", Offset = "0x1694000", VA = "0x1694000")]
	private void SetTabView()
	{
	}

	[Token(Token = "0x60064D4")]
	[Address(RVA = "0x1694114", Offset = "0x1694114", VA = "0x1694114")]
	private void SetItemViewAndKeepScrollPosition()
	{
	}

	[Token(Token = "0x60064D5")]
	[Address(RVA = "0x1693780", Offset = "0x1693780", VA = "0x1693780")]
	private void SetItemView()
	{
	}

	[Token(Token = "0x60064D6")]
	[Address(RVA = "0x1693E34", Offset = "0x1693E34", VA = "0x1693E34")]
	private void SetButtons()
	{
	}

	[Token(Token = "0x60064D7")]
	[Address(RVA = "0x1694A10", Offset = "0x1694A10", VA = "0x1694A10")]
	private bool IsSaleItem(CSArenaShopItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x60064D8")]
	[Address(RVA = "0x1694A54", Offset = "0x1694A54", VA = "0x1694A54")]
	private bool IsOwnedSkin(CSArenaShopItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x60064D9")]
	[Address(RVA = "0x169420C", Offset = "0x169420C", VA = "0x169420C")]
	private HashSet<State> GetTabCategory()
	{
		return null;
	}

	[Token(Token = "0x60064DA")]
	[Address(RVA = "0x16949FC", Offset = "0x16949FC", VA = "0x16949FC")]
	private State GetStateByCategory(CSArenaShopItem.Category category)
	{
		return default(State);
	}

	[Token(Token = "0x60064DB")]
	[Address(RVA = "0x1694878", Offset = "0x1694878", VA = "0x1694878")]
	private string GetArenaShopTabTitleString(State state)
	{
		return null;
	}

	[Token(Token = "0x60064DC")]
	[Address(RVA = "0x1694B54", Offset = "0x1694B54", VA = "0x1694B54")]
	public void OnClick_Tab(object id)
	{
	}

	[Token(Token = "0x60064DD")]
	[Address(RVA = "0x1694BE8", Offset = "0x1694BE8", VA = "0x1694BE8")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x60064DE")]
	[Address(RVA = "0x1694CC0", Offset = "0x1694CC0", VA = "0x1694CC0")]
	public void OnClick_JapanCommerce()
	{
	}

	[Token(Token = "0x60064DF")]
	[Address(RVA = "0x1694CCC", Offset = "0x1694CCC", VA = "0x1694CCC")]
	public void OnClick_JapanBilling()
	{
	}

	[Token(Token = "0x60064E0")]
	[Address(RVA = "0x1694CD8", Offset = "0x1694CD8", VA = "0x1694CD8")]
	private bool _003CSetItemView_003Em__32F(CSArenaShopItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x60064E1")]
	[Address(RVA = "0x1694CDC", Offset = "0x1694CDC", VA = "0x1694CDC")]
	private static int _003CSetItemView_003Em__330(CSArenaShopItem item)
	{
		return default(int);
	}

	[Token(Token = "0x60064E2")]
	[Address(RVA = "0x1694CFC", Offset = "0x1694CFC", VA = "0x1694CFC")]
	private static int _003CGetTabCategory_003Em__331(CSArenaShopItem item)
	{
		return default(int);
	}
}
