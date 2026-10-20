using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F51")]
public class XUIQuickMatchMapList : XUIListView
{
	[Token(Token = "0x400505C")]
	[FieldOffset(Offset = "0x78")]
	private int numberOnAline;

	[Token(Token = "0x400505D")]
	[FieldOffset(Offset = "0x7C")]
	private List<QuickMatchThemeInfo> m_list;

	[Token(Token = "0x400505E")]
	[FieldOffset(Offset = "0x80")]
	private Action<List<int>, bool> m_action;

	[Token(Token = "0x400505F")]
	[FieldOffset(Offset = "0x84")]
	private bool m_isFirst;

	[Token(Token = "0x17000E83")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60071BA")]
		[Address(RVA = "0x1913AC0", Offset = "0x1913AC0", VA = "0x1913AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E84")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60071BB")]
		[Address(RVA = "0x1913B38", Offset = "0x1913B38", VA = "0x1913B38", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E85")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60071BC")]
		[Address(RVA = "0x1913B40", Offset = "0x1913B40", VA = "0x1913B40", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60071B9")]
	[Address(RVA = "0x19139E0", Offset = "0x19139E0", VA = "0x19139E0")]
	public XUIQuickMatchMapList()
	{
	}

	[Token(Token = "0x60071BD")]
	[Address(RVA = "0x1913C30", Offset = "0x1913C30", VA = "0x1913C30")]
	public void Build(List<QuickMatchThemeInfo> list, Action<List<int>, bool> action, bool isFirst)
	{
	}

	[Token(Token = "0x60071BE")]
	[Address(RVA = "0x1913CA4", Offset = "0x1913CA4", VA = "0x1913CA4", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
