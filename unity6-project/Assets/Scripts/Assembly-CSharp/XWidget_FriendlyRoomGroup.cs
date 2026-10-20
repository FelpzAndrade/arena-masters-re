using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F87")]
public class XWidget_FriendlyRoomGroup : MonoBehaviour
{
	[Token(Token = "0x4005200")]
	[FieldOffset(Offset = "0xC")]
	private int groupNumber;

	[Token(Token = "0x4005201")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x4005202")]
	[FieldOffset(Offset = "0x14")]
	public List<XWidget_FriendlyMatchRoom> widgetFriendlyMatchRoomList;

	[Token(Token = "0x17000EB8")]
	private string m_FriendlyMatchRoomPrefabPath
	{
		[Token(Token = "0x600738C")]
		[Address(RVA = "0x142D84C", Offset = "0x142D84C", VA = "0x142D84C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600738B")]
	[Address(RVA = "0x142D798", Offset = "0x142D798", VA = "0x142D798")]
	public XWidget_FriendlyRoomGroup()
	{
	}

	[Token(Token = "0x600738D")]
	[Address(RVA = "0x142D8C4", Offset = "0x142D8C4", VA = "0x142D8C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600738E")]
	[Address(RVA = "0x142DBEC", Offset = "0x142DBEC", VA = "0x142DBEC")]
	public void Build(List<FriendlyRoomInfo> infoList)
	{
	}
}
