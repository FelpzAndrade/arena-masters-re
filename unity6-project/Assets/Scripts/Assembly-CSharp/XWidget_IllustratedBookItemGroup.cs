using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F8C")]
public class XWidget_IllustratedBookItemGroup : MonoBehaviour
{
	[Token(Token = "0x4005219")]
	[FieldOffset(Offset = "0xC")]
	public int groupNumber;

	[Token(Token = "0x400521A")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x400521B")]
	[FieldOffset(Offset = "0x14")]
	public List<XUIIllustratedBookItem> items;

	[Token(Token = "0x17000EBE")]
	private string m_BookItemPrefabPath
	{
		[Token(Token = "0x60073B2")]
		[Address(RVA = "0x143F948", Offset = "0x143F948", VA = "0x143F948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073B1")]
	[Address(RVA = "0x143F894", Offset = "0x143F894", VA = "0x143F894")]
	public XWidget_IllustratedBookItemGroup()
	{
	}

	[Token(Token = "0x60073B3")]
	[Address(RVA = "0x143F9C0", Offset = "0x143F9C0", VA = "0x143F9C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60073B4")]
	[Address(RVA = "0x143FCDC", Offset = "0x143FCDC", VA = "0x143FCDC")]
	public void Build(List<CSItemInfo> infoList)
	{
	}
}
