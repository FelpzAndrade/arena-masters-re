using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F5D")]
public class XListView_TeamInformationList : XUIListView
{
	[Token(Token = "0x40050B1")]
	[FieldOffset(Offset = "0x78")]
	private Action<XUITeamInformationItem> m_action;

	[Token(Token = "0x40050B2")]
	[FieldOffset(Offset = "0x7C")]
	private int listLine;

	[Token(Token = "0x40050B3")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_list;

	[Token(Token = "0x17000E94")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007225")]
		[Address(RVA = "0x1E16684", Offset = "0x1E16684", VA = "0x1E16684", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E95")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007226")]
		[Address(RVA = "0x1E166FC", Offset = "0x1E166FC", VA = "0x1E166FC", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E96")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007228")]
		[Address(RVA = "0x1E169A0", Offset = "0x1E169A0", VA = "0x1E169A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007224")]
	[Address(RVA = "0x1E165A4", Offset = "0x1E165A4", VA = "0x1E165A4")]
	public XListView_TeamInformationList()
	{
	}

	[Token(Token = "0x6007227")]
	[Address(RVA = "0x1E16704", Offset = "0x1E16704", VA = "0x1E16704")]
	public void Build(Action<XUITeamInformationItem> action)
	{
	}

	[Token(Token = "0x6007229")]
	[Address(RVA = "0x1E16AB4", Offset = "0x1E16AB4", VA = "0x1E16AB4", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
