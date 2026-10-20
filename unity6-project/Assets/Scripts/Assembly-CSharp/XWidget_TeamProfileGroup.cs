using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FF9")]
public class XWidget_TeamProfileGroup : MonoBehaviour
{
	[Token(Token = "0x400553E")]
	[FieldOffset(Offset = "0xC")]
	private int groupNumber;

	[Token(Token = "0x400553F")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x4005540")]
	[FieldOffset(Offset = "0x14")]
	public List<XUITeamInformationItem> items;

	[Token(Token = "0x17000EE7")]
	private string m_BookItemPrefabPath
	{
		[Token(Token = "0x600771D")]
		[Address(RVA = "0x1B1B444", Offset = "0x1B1B444", VA = "0x1B1B444")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600771C")]
	[Address(RVA = "0x1B1B390", Offset = "0x1B1B390", VA = "0x1B1B390")]
	public XWidget_TeamProfileGroup()
	{
	}

	[Token(Token = "0x600771E")]
	[Address(RVA = "0x1B1B4BC", Offset = "0x1B1B4BC", VA = "0x1B1B4BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600771F")]
	[Address(RVA = "0x1B1B7D8", Offset = "0x1B1B7D8", VA = "0x1B1B7D8")]
	public void Build(List<int> profileIconList, Action<XUITeamInformationItem> action)
	{
	}
}
