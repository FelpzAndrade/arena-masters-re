using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B2")]
public class XInstancePool
{
	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_Root;

	[Token(Token = "0x1700050A")]
	public Transform Root
	{
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x1D2B6B8", Offset = "0x1D2B6B8", VA = "0x1D2B6B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x1D2E12C", Offset = "0x1D2E12C", VA = "0x1D2E12C")]
	public XInstancePool(Transform instanceRoot)
	{
	}

	[Token(Token = "0x6001E47")]
	[Address(RVA = "0x1D2BDB4", Offset = "0x1D2BDB4", VA = "0x1D2BDB4")]
	public void Add(GameObject instance)
	{
	}
}
