using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FD4")]
public class XWidget_QuickMatchMapGroup : MonoBehaviour
{
	[Token(Token = "0x4005432")]
	[FieldOffset(Offset = "0xC")]
	private int groupNumber;

	[Token(Token = "0x4005433")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid grid;

	[Token(Token = "0x4005434")]
	[FieldOffset(Offset = "0x14")]
	public List<XWidget_QuickMatchMap> widgetQuickMatchMapList;

	[Token(Token = "0x17000EE1")]
	private string m_QuickMatchMapPrefabPath
	{
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0x132BE88", Offset = "0x132BE88", VA = "0x132BE88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075F3")]
	[Address(RVA = "0x132BDD4", Offset = "0x132BDD4", VA = "0x132BDD4")]
	public XWidget_QuickMatchMapGroup()
	{
	}

	[Token(Token = "0x60075F5")]
	[Address(RVA = "0x132BF00", Offset = "0x132BF00", VA = "0x132BF00")]
	private void Awake()
	{
	}

	[Token(Token = "0x60075F6")]
	[Address(RVA = "0x132C228", Offset = "0x132C228", VA = "0x132C228")]
	public void Build(List<QuickMatchThemeInfo> infoList, Action<List<int>, bool> action, bool isFirst)
	{
	}
}
