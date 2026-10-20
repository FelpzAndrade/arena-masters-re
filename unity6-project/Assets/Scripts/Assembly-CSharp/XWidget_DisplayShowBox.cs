using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F7E")]
public class XWidget_DisplayShowBox : MonoBehaviour
{
	[Token(Token = "0x40051C9")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder displayBuilder;

	[Token(Token = "0x600734F")]
	[Address(RVA = "0x15F0078", Offset = "0x15F0078", VA = "0x15F0078")]
	public XWidget_DisplayShowBox()
	{
	}

	[Token(Token = "0x6007350")]
	[Address(RVA = "0x15F0080", Offset = "0x15F0080", VA = "0x15F0080")]
	public void BuildNormal(List<ShowBoxInfo> showBoxInfoList)
	{
	}

	[Token(Token = "0x6007351")]
	[Address(RVA = "0x15F0B38", Offset = "0x15F0B38", VA = "0x15F0B38")]
	public void BuildSelect(List<ShowBoxInfo> showBoxInfoList, int selectedIndex, string prefixLocalKey)
	{
	}

	[Token(Token = "0x6007352")]
	[Address(RVA = "0x15F0840", Offset = "0x15F0840", VA = "0x15F0840")]
	private void BuildDisplayNormal(List<string> descList, List<string> strIconList)
	{
	}

	[Token(Token = "0x6007353")]
	[Address(RVA = "0x15F0B84", Offset = "0x15F0B84", VA = "0x15F0B84")]
	private void BuildDisplaySelect(List<string> descList, List<string> strIconList, int selectedIndex, string prefixLocalKey)
	{
	}

	[Token(Token = "0x6007354")]
	[Address(RVA = "0x15F00B4", Offset = "0x15F00B4", VA = "0x15F00B4")]
	private List<string> MakeDescList(List<ShowBoxInfo> showBoxInfoList)
	{
		return null;
	}

	[Token(Token = "0x6007355")]
	[Address(RVA = "0x15F0614", Offset = "0x15F0614", VA = "0x15F0614")]
	private List<string> MakeIconPathList(List<ShowBoxInfo> showBoxInfoList)
	{
		return null;
	}
}
