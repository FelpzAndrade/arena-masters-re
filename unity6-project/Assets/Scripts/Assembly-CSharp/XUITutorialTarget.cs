using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C26")]
public class XUITutorialTarget
{
	[Token(Token = "0x4003D74")]
	[FieldOffset(Offset = "0x8")]
	private XTutorialObjContainer tutorialConnectPanel;

	[Token(Token = "0x4003D75")]
	[FieldOffset(Offset = "0xC")]
	private string name;

	[Token(Token = "0x4003D76")]
	[FieldOffset(Offset = "0x10")]
	private List<PanelReturnData> panelList;

	[Token(Token = "0x4003D77")]
	[FieldOffset(Offset = "0x14")]
	private GameObject targetObject__BackingField;

	[Token(Token = "0x17000CA6")]
	public GameObject targetObject
	{
		[Token(Token = "0x60057F1")]
		[Address(RVA = "0x193A1D4", Offset = "0x193A1D4", VA = "0x193A1D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x193A1CC", Offset = "0x193A1CC", VA = "0x193A1CC")]
		private set
		{
		}
	}

	[Token(Token = "0x60057F0")]
	[Address(RVA = "0x193A108", Offset = "0x193A108", VA = "0x193A108")]
	public XUITutorialTarget(XTutorialObjContainer connectPanel, string name, GameObject obj)
	{
	}

	[Token(Token = "0x60057F3")]
	[Address(RVA = "0x193A1DC", Offset = "0x193A1DC", VA = "0x193A1DC")]
	public void ReconnectTargetParent()
	{
	}

	[Token(Token = "0x60057F4")]
	[Address(RVA = "0x193A3A8", Offset = "0x193A3A8", VA = "0x193A3A8")]
	public void SetPanelDictionary(int setDepth)
	{
	}

	[Token(Token = "0x60057F5")]
	[Address(RVA = "0x193A540", Offset = "0x193A540", VA = "0x193A540")]
	public void ReturnPanelDepth()
	{
	}
}
