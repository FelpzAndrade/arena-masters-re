using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B3")]
public class XCharacterInstancePool
{
	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_Root;

	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0xC")]
	private List<XModuleEntity> m_list;

	[Token(Token = "0x1700050B")]
	public List<XModuleEntity> List
	{
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x1AB5CEC", Offset = "0x1AB5CEC", VA = "0x1AB5CEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050C")]
	public Transform Root
	{
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x1AB613C", Offset = "0x1AB613C", VA = "0x1AB613C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x1AB5C38", Offset = "0x1AB5C38", VA = "0x1AB5C38")]
	public XCharacterInstancePool(Transform instanceRoot)
	{
	}

	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0x1AB5CF4", Offset = "0x1AB5CF4", VA = "0x1AB5CF4")]
	public void Add(XModuleEntity instance)
	{
	}

	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x1AB5FB8", Offset = "0x1AB5FB8", VA = "0x1AB5FB8")]
	public void Remove(XModuleEntity instance)
	{
	}
}
