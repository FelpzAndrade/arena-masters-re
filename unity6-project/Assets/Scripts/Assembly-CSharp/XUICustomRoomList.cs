using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F19")]
public class XUICustomRoomList : XUIListView
{
	[Token(Token = "0x4004FE2")]
	[FieldOffset(Offset = "0x78")]
	private int numberOnAline;

	[Token(Token = "0x4004FE3")]
	[FieldOffset(Offset = "0x7C")]
	private List<XUICustomRoomInfo> m_list;

	[Token(Token = "0x4004FE4")]
	[FieldOffset(Offset = "0x80")]
	private RelicInfo m_initInfo;

	[Token(Token = "0x17000E43")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007084")]
		[Address(RVA = "0x1A3AEDC", Offset = "0x1A3AEDC", VA = "0x1A3AEDC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E44")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007085")]
		[Address(RVA = "0x1A3AF54", Offset = "0x1A3AF54", VA = "0x1A3AF54", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E45")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007086")]
		[Address(RVA = "0x1A3AF5C", Offset = "0x1A3AF5C", VA = "0x1A3AF5C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007083")]
	[Address(RVA = "0x1A3ADFC", Offset = "0x1A3ADFC", VA = "0x1A3ADFC")]
	public XUICustomRoomList()
	{
	}

	[Token(Token = "0x6007087")]
	[Address(RVA = "0x1A3B000", Offset = "0x1A3B000", VA = "0x1A3B000")]
	public void Build(List<XUICustomRoomInfo> list)
	{
	}

	[Token(Token = "0x6007088")]
	[Address(RVA = "0x1A3B00C", Offset = "0x1A3B00C", VA = "0x1A3B00C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}
}
