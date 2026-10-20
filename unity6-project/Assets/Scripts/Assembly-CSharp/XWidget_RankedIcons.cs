using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D43")]
public class XWidget_RankedIcons : MonoBehaviour
{
	[Token(Token = "0x4004439")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder grid;

	[Token(Token = "0x400443A")]
	[FieldOffset(Offset = "0x10")]
	public UISprite select;

	[Token(Token = "0x400443B")]
	[FieldOffset(Offset = "0x14")]
	private List<XPlayer> m_playerList;

	[Token(Token = "0x400443C")]
	[FieldOffset(Offset = "0x18")]
	private XWidget_RankedIcon[] rankedIconArray;

	[Token(Token = "0x600617B")]
	[Address(RVA = "0x132FD48", Offset = "0x132FD48", VA = "0x132FD48")]
	public XWidget_RankedIcons()
	{
	}

	[Token(Token = "0x600617C")]
	[Address(RVA = "0x132FD50", Offset = "0x132FD50", VA = "0x132FD50")]
	public void Build(List<XPlayer> players, IRecordUISetter setter)
	{
	}

	[Token(Token = "0x600617D")]
	[Address(RVA = "0x133041C", Offset = "0x133041C", VA = "0x133041C")]
	public void UpdateRankedIcon()
	{
	}

	[Token(Token = "0x600617E")]
	[Address(RVA = "0x13302A4", Offset = "0x13302A4", VA = "0x13302A4")]
	private Sprite GetRankIcon(int rank)
	{
		return null;
	}
}
