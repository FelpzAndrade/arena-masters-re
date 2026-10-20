using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F24")]
public class XUIFriendlyRoomList : XUIListView
{
	[Token(Token = "0x4005007")]
	[FieldOffset(Offset = "0x78")]
	private int numberOnAline;

	[Token(Token = "0x4005008")]
	[FieldOffset(Offset = "0x7C")]
	private List<FriendlyRoomInfo> m_list;

	[Token(Token = "0x4005009")]
	[FieldOffset(Offset = "0x80")]
	private RelicInfo m_initInfo;

	[Token(Token = "0x17000E55")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070CA")]
		[Address(RVA = "0x1A47DE4", Offset = "0x1A47DE4", VA = "0x1A47DE4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E56")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0x1A47E5C", Offset = "0x1A47E5C", VA = "0x1A47E5C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E57")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070CC")]
		[Address(RVA = "0x1A47E64", Offset = "0x1A47E64", VA = "0x1A47E64", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60070C9")]
	[Address(RVA = "0x1A47D04", Offset = "0x1A47D04", VA = "0x1A47D04")]
	public XUIFriendlyRoomList()
	{
	}

	[Token(Token = "0x60070CD")]
	[Address(RVA = "0x1A47F08", Offset = "0x1A47F08", VA = "0x1A47F08")]
	public void Build(List<FriendlyRoomInfo> list)
	{
	}

	[Token(Token = "0x60070CE")]
	[Address(RVA = "0x1A47F14", Offset = "0x1A47F14", VA = "0x1A47F14", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
