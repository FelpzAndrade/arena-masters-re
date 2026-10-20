using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B4")]
public class XInstanceManager
{
	[Token(Token = "0x20003B5")]
	private class XInstanceTypeComparer : IEqualityComparer<XInstanceType>
	{
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x1D2AFA0", Offset = "0x1D2AFA0", VA = "0x1D2AFA0")]
		public XInstanceTypeComparer()
		{
		}

		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x1D2E114", Offset = "0x1D2E114", VA = "0x1D2E114", Slot = "4")]
		public bool Equals(XInstanceType t1, XInstanceType t2)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x1D2E124", Offset = "0x1D2E124", VA = "0x1D2E124", Slot = "5")]
		public int GetHashCode(XInstanceType type)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4001304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Dictionary<XInstanceType, XInstancePool> m_InstancePools;

	[Token(Token = "0x4001305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Dictionary<XInstanceType, XCharacterInstancePool> m_CharacterInstancePools;

	[Token(Token = "0x4001306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<XModuleEntity> removeList;

	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x1D2AE4C", Offset = "0x1D2AE4C", VA = "0x1D2AE4C")]
	public XInstanceManager()
	{
	}

	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x1D2AFA8", Offset = "0x1D2AFA8", VA = "0x1D2AFA8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x1D2B06C", Offset = "0x1D2B06C", VA = "0x1D2B06C")]
	public void ClearGameObjects([Optional] GameObject exceptGO)
	{
	}

	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x1D2B6C0", Offset = "0x1D2B6C0", VA = "0x1D2B6C0")]
	public void ClearCharacterPool(XInstanceType type)
	{
	}

	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x1D2B904", Offset = "0x1D2B904", VA = "0x1D2B904")]
	public void CreatePool(XInstanceType type, XInstancePool pool)
	{
	}

	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x1D2B9E4", Offset = "0x1D2B9E4", VA = "0x1D2B9E4")]
	public void CreatePool(XInstanceType type, XCharacterInstancePool pool)
	{
	}

	[Token(Token = "0x6001E54")]
	[Address(RVA = "0x1D2BAC4", Offset = "0x1D2BAC4", VA = "0x1D2BAC4")]
	public XInstancePool GetPool(XInstanceType type)
	{
		return null;
	}

	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x1D2B824", Offset = "0x1D2B824", VA = "0x1D2B824")]
	public XCharacterInstancePool GetCharacterPool(XInstanceType type)
	{
		return null;
	}

	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x1D2BBA4", Offset = "0x1D2BBA4", VA = "0x1D2BBA4")]
	public void Push(XInstanceType nInstanceType, GameObject goInstance)
	{
	}

	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x1D2BDF8", Offset = "0x1D2BDF8", VA = "0x1D2BDF8")]
	public void Push(XInstanceType nInstanceType, XModuleEntity instance)
	{
	}

	[Token(Token = "0x6001E58")]
	[Address(RVA = "0x1D2C020", Offset = "0x1D2C020", VA = "0x1D2C020")]
	public void Remove(XModuleEntity instance)
	{
	}

	[Token(Token = "0x6001E59")]
	[Address(RVA = "0x1D2C11C", Offset = "0x1D2C11C", VA = "0x1D2C11C")]
	public XModuleEntity FindNearestEnemy(XModuleEntity owner, XInstanceType nInstanceType, float fDistance = 999999f)
	{
		return null;
	}

	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0x1D2C7E8", Offset = "0x1D2C7E8", VA = "0x1D2C7E8", Slot = "4")]
	protected virtual bool IsHittable(XModuleEntity player1, XModuleEntity player2)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0x1D2C7F4", Offset = "0x1D2C7F4", VA = "0x1D2C7F4")]
	public XModuleEntity FindNearestEnemy(XModuleEntity owner, float fDistance = 999999f)
	{
		return null;
	}

	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0x1D2CA2C", Offset = "0x1D2CA2C", VA = "0x1D2CA2C")]
	public XModuleEntity FindPlayer(int nPhotonPlayerID)
	{
		return null;
	}

	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x1D2CEFC", Offset = "0x1D2CEFC", VA = "0x1D2CEFC")]
	public List<XModuleEntity> FindAllPlayersModuleEntity()
	{
		return null;
	}

	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x1D2D17C", Offset = "0x1D2D17C", VA = "0x1D2D17C")]
	public XModuleEntity FindPlayerUseXPlayerAid(string xPlayerAid)
	{
		return null;
	}

	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x1D2D6A0", Offset = "0x1D2D6A0", VA = "0x1D2D6A0")]
	public XModuleEntity FindPlayer(string strNickname)
	{
		return null;
	}

	[Token(Token = "0x6001E60")]
	[Address(RVA = "0x1D2DBE0", Offset = "0x1D2DBE0", VA = "0x1D2DBE0")]
	public void Foreach(XInstanceType nInstanceType, Action<GameObject> action)
	{
	}

	[Token(Token = "0x6001E61")]
	[Address(RVA = "0x1D2DF54", Offset = "0x1D2DF54", VA = "0x1D2DF54")]
	public void Foreach(XInstanceType nInstanceType, Action<XModuleEntity> action)
	{
	}
}
