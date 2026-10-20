using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F22")]
public class XListView_RequestFriend : XUIListView
{
	[Token(Token = "0x4005006")]
	[FieldOffset(Offset = "0x78")]
	private List<Friend> m_list;

	[Token(Token = "0x17000E52")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070C3")]
		[Address(RVA = "0x1E15728", Offset = "0x1E15728", VA = "0x1E15728", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E53")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070C4")]
		[Address(RVA = "0x1E157A0", Offset = "0x1E157A0", VA = "0x1E157A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E54")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070C5")]
		[Address(RVA = "0x1E157A8", Offset = "0x1E157A8", VA = "0x1E157A8", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60070C2")]
	[Address(RVA = "0x1E15650", Offset = "0x1E15650", VA = "0x1E15650")]
	public XListView_RequestFriend()
	{
	}

	[Token(Token = "0x60070C6")]
	[Address(RVA = "0x1E15840", Offset = "0x1E15840", VA = "0x1E15840")]
	public void Build(List<Friend> request_user)
	{
	}

	[Token(Token = "0x60070C7")]
	[Address(RVA = "0x1E1584C", Offset = "0x1E1584C", VA = "0x1E1584C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
