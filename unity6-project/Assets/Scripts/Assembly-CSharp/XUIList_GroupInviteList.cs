using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D9C")]
public class XUIList_GroupInviteList : XUIListView
{
	[Token(Token = "0x2000D9D")]
	private sealed class _003CFindUIWidget_003Ec__AnonStorey1B0
	{
		[Token(Token = "0x40046B6")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x6006425")]
		[Address(RVA = "0x1098750", Offset = "0x1098750", VA = "0x1098750")]
		public _003CFindUIWidget_003Ec__AnonStorey1B0()
		{
		}

		[Token(Token = "0x6006426")]
		[Address(RVA = "0x1098758", Offset = "0x1098758", VA = "0x1098758")]
		internal bool _003C_003Em__321(XFriendData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40046B2")]
	[FieldOffset(Offset = "0x78")]
	private List<XFriendData> m_list;

	[Token(Token = "0x40046B3")]
	[FieldOffset(Offset = "0x7C")]
	private Dictionary<int, XWidget_GroupInviteUserItem> m_cacheDic;

	[Token(Token = "0x40046B4")]
	[FieldOffset(Offset = "0x80")]
	public GameObject goLabelNoFriend;

	[Token(Token = "0x40046B5")]
	[FieldOffset(Offset = "0x84")]
	private int latelyPlayedFriendCount;

	[Token(Token = "0x17000D46")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x600641C")]
		[Address(RVA = "0x1097C3C", Offset = "0x1097C3C", VA = "0x1097C3C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D47")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x600641D")]
		[Address(RVA = "0x1097CB4", Offset = "0x1097CB4", VA = "0x1097CB4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000D48")]
	protected override int InfoListCount
	{
		[Token(Token = "0x600641E")]
		[Address(RVA = "0x1097CBC", Offset = "0x1097CBC", VA = "0x1097CBC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600641B")]
	[Address(RVA = "0x1097A0C", Offset = "0x1097A0C", VA = "0x1097A0C")]
	public XUIList_GroupInviteList()
	{
	}

	[Token(Token = "0x600641F")]
	[Address(RVA = "0x1097D54", Offset = "0x1097D54", VA = "0x1097D54")]
	public void Build(List<XFriendData> user_data, int latelyPlayedFriendCount = 0)
	{
	}

	[Token(Token = "0x6006420")]
	[Address(RVA = "0x10980D0", Offset = "0x10980D0", VA = "0x10980D0", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6006421")]
	[Address(RVA = "0x1098200", Offset = "0x1098200", VA = "0x1098200")]
	public void RefreshState(List<string> isJoinedMemeber)
	{
	}

	[Token(Token = "0x6006422")]
	[Address(RVA = "0x10983D0", Offset = "0x10983D0", VA = "0x10983D0")]
	public void ChangeRefuse(string name)
	{
	}

	[Token(Token = "0x6006423")]
	[Address(RVA = "0x1098668", Offset = "0x1098668", VA = "0x1098668")]
	public void ChangeAccept(string name)
	{
	}

	[Token(Token = "0x6006424")]
	[Address(RVA = "0x10984B8", Offset = "0x10984B8", VA = "0x10984B8")]
	private XWidget_GroupInviteUserItem FindUIWidget(string name)
	{
		return null;
	}
}
