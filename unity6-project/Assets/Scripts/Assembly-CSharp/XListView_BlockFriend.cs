using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F10")]
public class XListView_BlockFriend : XUIListView
{
	[Token(Token = "0x4004FC3")]
	[FieldOffset(Offset = "0x78")]
	private List<Friend> m_list;

	[Token(Token = "0x17000E3B")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007060")]
		[Address(RVA = "0x20376D4", Offset = "0x20376D4", VA = "0x20376D4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E3C")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007061")]
		[Address(RVA = "0x203774C", Offset = "0x203774C", VA = "0x203774C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E3D")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007062")]
		[Address(RVA = "0x2037754", Offset = "0x2037754", VA = "0x2037754", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600705F")]
	[Address(RVA = "0x20375FC", Offset = "0x20375FC", VA = "0x20375FC")]
	public XListView_BlockFriend()
	{
	}

	[Token(Token = "0x6007063")]
	[Address(RVA = "0x20377EC", Offset = "0x20377EC", VA = "0x20377EC")]
	public void Build(List<Friend> user_data)
	{
	}

	[Token(Token = "0x6007064")]
	[Address(RVA = "0x20377F8", Offset = "0x20377F8", VA = "0x20377F8", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
