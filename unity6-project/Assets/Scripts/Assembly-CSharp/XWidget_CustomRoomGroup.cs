using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F7C")]
public class XWidget_CustomRoomGroup : MonoBehaviour
{
	[Token(Token = "0x40051C2")]
	[FieldOffset(Offset = "0xC")]
	private int groupNumber;

	[Token(Token = "0x40051C3")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x40051C4")]
	[FieldOffset(Offset = "0x14")]
	public List<XWidget_CustomRoom> widgetCustomRoomList;

	[Token(Token = "0x17000EB6")]
	private string m_CustomRoomPrefabPath
	{
		[Token(Token = "0x6007349")]
		[Address(RVA = "0x15EDFE0", Offset = "0x15EDFE0", VA = "0x15EDFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007348")]
	[Address(RVA = "0x15EDF2C", Offset = "0x15EDF2C", VA = "0x15EDF2C")]
	public XWidget_CustomRoomGroup()
	{
	}

	[Token(Token = "0x600734A")]
	[Address(RVA = "0x15EE058", Offset = "0x15EE058", VA = "0x15EE058")]
	private void Awake()
	{
	}

	[Token(Token = "0x600734B")]
	[Address(RVA = "0x15EE380", Offset = "0x15EE380", VA = "0x15EE380")]
	public void Build(List<XUICustomRoomInfo> infoList)
	{
	}
}
