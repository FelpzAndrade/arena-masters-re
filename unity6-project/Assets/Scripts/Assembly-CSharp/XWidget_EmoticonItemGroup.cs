using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F81")]
public class XWidget_EmoticonItemGroup : MonoBehaviour
{
	[Token(Token = "0x40051D4")]
	[FieldOffset(Offset = "0xC")]
	public int groupNumber;

	[Token(Token = "0x40051D5")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x40051D6")]
	[FieldOffset(Offset = "0x14")]
	public List<XUIEmoticonItem> items;

	[Token(Token = "0x40051D7")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_TeamEmoticon m_title;

	[Token(Token = "0x17000EB7")]
	private string m_emoticonItemPrefabPath
	{
		[Token(Token = "0x6007366")]
		[Address(RVA = "0x15F389C", Offset = "0x15F389C", VA = "0x15F389C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007365")]
	[Address(RVA = "0x15F37E8", Offset = "0x15F37E8", VA = "0x15F37E8")]
	public XWidget_EmoticonItemGroup()
	{
	}

	[Token(Token = "0x6007367")]
	[Address(RVA = "0x15F3914", Offset = "0x15F3914", VA = "0x15F3914")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007368")]
	[Address(RVA = "0x15F3C30", Offset = "0x15F3C30", VA = "0x15F3C30")]
	public void Build(List<CSEmoticonSetInfo> infoList, int selectedID, int usingID, Action<XUIEmoticonItem> onSelect)
	{
	}
}
