using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E67")]
public class XListView_Stage : XUIListView
{
	[Token(Token = "0x4004B6E")]
	[FieldOffset(Offset = "0x78")]
	private bool m_needRefreshList;

	[Token(Token = "0x4004B6F")]
	[FieldOffset(Offset = "0x7C")]
	public List<int> m_list;

	[Token(Token = "0x17000DD5")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6006B94")]
		[Address(RVA = "0x1E163E8", Offset = "0x1E163E8", VA = "0x1E163E8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DD6")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6006B95")]
		[Address(RVA = "0x1E16460", Offset = "0x1E16460", VA = "0x1E16460", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000DD7")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6006B96")]
		[Address(RVA = "0x1E16468", Offset = "0x1E16468", VA = "0x1E16468", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006B93")]
	[Address(RVA = "0x1E16308", Offset = "0x1E16308", VA = "0x1E16308")]
	public XListView_Stage()
	{
	}

	[Token(Token = "0x6006B97")]
	[Address(RVA = "0x1E16500", Offset = "0x1E16500", VA = "0x1E16500")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6006B98")]
	[Address(RVA = "0x1E165A0", Offset = "0x1E165A0", VA = "0x1E165A0", Slot = "12")]
	protected override void PushDatum(GameObject goItem, int index)
	{
	}
}
