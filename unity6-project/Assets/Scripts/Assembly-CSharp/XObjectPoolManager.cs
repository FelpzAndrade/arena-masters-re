using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063D")]
public class XObjectPoolManager : IXObjectPoolManager
{
	[Token(Token = "0x200063E")]
	private class XPoolTypeComparer : IEqualityComparer<XPoolType>
	{
		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x168D76C", Offset = "0x168D76C", VA = "0x168D76C")]
		public XPoolTypeComparer()
		{
		}

		[Token(Token = "0x60035AF")]
		[Address(RVA = "0x168E66C", Offset = "0x168E66C", VA = "0x168E66C", Slot = "4")]
		public bool Equals(XPoolType t1, XPoolType t2)
		{
			return default(bool);
		}

		[Token(Token = "0x60035B0")]
		[Address(RVA = "0x168E67C", Offset = "0x168E67C", VA = "0x168E67C", Slot = "5")]
		public int GetHashCode(XPoolType type)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4001E12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Dictionary<XPoolType, XObjectPool> objectsPool;

	[Token(Token = "0x60035A0")]
	[Address(RVA = "0x168D69C", Offset = "0x168D69C", VA = "0x168D69C")]
	public XObjectPoolManager()
	{
	}

	[Token(Token = "0x60035A1")]
	[Address(RVA = "0x168D774", Offset = "0x168D774", VA = "0x168D774")]
	public void CreatePool(XPoolType type, XObjectPool pool)
	{
	}

	[Token(Token = "0x60035A2")]
	[Address(RVA = "0x168D854", Offset = "0x168D854", VA = "0x168D854")]
	public void Clear()
	{
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0x168D9EC", Offset = "0x168D9EC", VA = "0x168D9EC")]
	public void ClearPooledObjects()
	{
	}

	[Token(Token = "0x60035A4")]
	[Address(RVA = "0x168DB58", Offset = "0x168DB58", VA = "0x168DB58")]
	public void ClearPooledObjects(XPoolType exclude)
	{
	}

	[Token(Token = "0x60035A5")]
	[Address(RVA = "0x168DCF0", Offset = "0x168DCF0", VA = "0x168DCF0")]
	public void ClearPool(XPoolType poolType)
	{
	}

	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x168DD0C", Offset = "0x168DD0C", VA = "0x168DD0C")]
	public XObjectPool GetPool(XPoolType type)
	{
		return null;
	}

	[Token(Token = "0x60035A7")]
	[Address(RVA = "0x16882EC", Offset = "0x16882EC", VA = "0x16882EC")]
	public void Reserve(XPoolType type, string goName, int nCount)
	{
	}

	[Token(Token = "0x60035A8")]
	[Address(RVA = "0x168DF18", Offset = "0x168DF18", VA = "0x168DF18")]
	public void ReserveAdd(XPoolType type, string goName, int nCount)
	{
	}

	[Token(Token = "0x60035A9")]
	[Address(RVA = "0x1683DEC", Offset = "0x1683DEC", VA = "0x1683DEC", Slot = "4")]
	public bool Peek(XPoolType type, string goName)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AA")]
	[Address(RVA = "0x168E1BC", Offset = "0x168E1BC", VA = "0x168E1BC")]
	public GameObject Create(XPoolType type, string goName, Vector3 instantiateVector, Quaternion rotation, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60035AB")]
	[Address(RVA = "0x1683EB8", Offset = "0x1683EB8", VA = "0x1683EB8")]
	public GameObject Create(XPoolType type, string goName, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60035AC")]
	[Address(RVA = "0x168E454", Offset = "0x168E454", VA = "0x168E454")]
	public GameObject Create(XPoolType type, string goName, Vector3 instantiateVector, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60035AD")]
	[Address(RVA = "0x168E4D0", Offset = "0x168E4D0", VA = "0x168E4D0", Slot = "5")]
	public void Destroy(XPoolType type, GameObject target)
	{
	}
}
