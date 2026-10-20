using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DEE")]
public class XPanel_Help : MonoBehaviour
{
	[Token(Token = "0x40048C6")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x40048C7")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblDesc;

	[Token(Token = "0x40048C8")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView itemScrollview;

	[Token(Token = "0x40048C9")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView descScrollview;

	[Token(Token = "0x40048CA")]
	[FieldOffset(Offset = "0x1C")]
	public UITable table;

	[Token(Token = "0x40048CB")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_itmeList;

	[Token(Token = "0x40048CC")]
	[FieldOffset(Offset = "0x24")]
	private bool m_initPos;

	[Token(Token = "0x40048CD")]
	[FieldOffset(Offset = "0x28")]
	private int m_prevHelpID;

	[Token(Token = "0x17000D6D")]
	private string m_HelpItemPath
	{
		[Token(Token = "0x600670A")]
		[Address(RVA = "0xFF4DB0", Offset = "0xFF4DB0", VA = "0xFF4DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006709")]
	[Address(RVA = "0xFF4D04", Offset = "0xFF4D04", VA = "0xFF4D04")]
	public XPanel_Help()
	{
	}

	[Token(Token = "0x600670B")]
	[Address(RVA = "0xFF4E28", Offset = "0xFF4E28", VA = "0xFF4E28")]
	public void Build(int id)
	{
	}

	[Token(Token = "0x600670C")]
	[Address(RVA = "0xFF568C", Offset = "0xFF568C", VA = "0xFF568C")]
	public void Build(HelpLink nLink)
	{
	}

	[Token(Token = "0x600670D")]
	[Address(RVA = "0xFF501C", Offset = "0xFF501C", VA = "0xFF501C")]
	private void BuildMainCategory(List<int> mainList)
	{
	}

	[Token(Token = "0x600670E")]
	[Address(RVA = "0xFF53D8", Offset = "0xFF53D8", VA = "0xFF53D8")]
	private void BuildItem(List<int> mainList, int selectID)
	{
	}

	[Token(Token = "0x600670F")]
	[Address(RVA = "0xFF57BC", Offset = "0xFF57BC", VA = "0xFF57BC")]
	private void BuildDetail(XHelpInfo helpInfo, int index)
	{
	}

	[Token(Token = "0x6006710")]
	[Address(RVA = "0xFF5A24", Offset = "0xFF5A24", VA = "0xFF5A24")]
	private void SetScrollViewPos(int index)
	{
	}

	[Token(Token = "0x6006711")]
	[Address(RVA = "0xFF5978", Offset = "0xFF5978", VA = "0xFF5978")]
	private string SetReplaceDesc(string strDesc)
	{
		return null;
	}

	[Token(Token = "0x6006712")]
	[Address(RVA = "0xFF5B14", Offset = "0xFF5B14", VA = "0xFF5B14")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006713")]
	[Address(RVA = "0xFF5BE4", Offset = "0xFF5BE4", VA = "0xFF5BE4")]
	public void OnClickHelpItem(XHelpInfo helpInfo, int index)
	{
	}
}
