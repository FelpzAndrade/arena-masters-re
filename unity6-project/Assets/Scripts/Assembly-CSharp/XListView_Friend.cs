using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1E")]
public class XListView_Friend : XUIListView
{
	[Token(Token = "0x4005003")]
	[FieldOffset(Offset = "0x78")]
	private List<XFriendData> m_list;

	[Token(Token = "0x4005004")]
	[FieldOffset(Offset = "0x7C")]
	private List<string> coolTimeFriendList;

	[Token(Token = "0x17000E4C")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070B1")]
		[Address(RVA = "0x1E0C3A0", Offset = "0x1E0C3A0", VA = "0x1E0C3A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E4D")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070B2")]
		[Address(RVA = "0x1E0C418", Offset = "0x1E0C418", VA = "0x1E0C418", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E4E")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0x1E0C420", Offset = "0x1E0C420", VA = "0x1E0C420", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60070B0")]
	[Address(RVA = "0x1E0C294", Offset = "0x1E0C294", VA = "0x1E0C294")]
	public XListView_Friend()
	{
	}

	[Token(Token = "0x60070B4")]
	[Address(RVA = "0x1E0C4B8", Offset = "0x1E0C4B8", VA = "0x1E0C4B8")]
	public void Build(List<XFriendData> user_data)
	{
	}

	[Token(Token = "0x60070B5")]
	[Address(RVA = "0x1E0C4C4", Offset = "0x1E0C4C4", VA = "0x1E0C4C4", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60070B6")]
	[Address(RVA = "0x1E0C5C4", Offset = "0x1E0C5C4", VA = "0x1E0C5C4")]
	private bool GetCoolTimeItme(XFriendData friend)
	{
		return default(bool);
	}

	[Token(Token = "0x60070B7")]
	[Address(RVA = "0x1E0C748", Offset = "0x1E0C748", VA = "0x1E0C748")]
	public void BuildCoolTimeFriendList(string aid)
	{
	}

	[Token(Token = "0x60070B8")]
	[Address(RVA = "0x1E0C7E8", Offset = "0x1E0C7E8", VA = "0x1E0C7E8")]
	public void CoolTimeFriendListClear()
	{
	}
}
