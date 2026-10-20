using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200029F")]
public static class Extensions
{
	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<MethodInfo, ParameterInfo[]> ParametersOfMethods;

	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x1E7FB3C", Offset = "0x1E7FB3C", VA = "0x1E7FB3C")]
	public static ParameterInfo[] GetCachedParemeters(this MethodInfo mo)
	{
		return null;
	}

	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x1E7FCFC", Offset = "0x1E7FCFC", VA = "0x1E7FCFC")]
	public static PhotonView[] GetPhotonViewsInChildren(this GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x1E7FD98", Offset = "0x1E7FD98", VA = "0x1E7FD98")]
	public static PhotonView GetPhotonView(this GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x1E7FE30", Offset = "0x1E7FE30", VA = "0x1E7FE30")]
	public static bool AlmostEquals(this Vector3 target, Vector3 second, float sqrMagnitudePrecision)
	{
		return default(bool);
	}

	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x1E7FEB4", Offset = "0x1E7FEB4", VA = "0x1E7FEB4")]
	public static bool AlmostEquals(this Vector2 target, Vector2 second, float sqrMagnitudePrecision)
	{
		return default(bool);
	}

	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x1E7FF24", Offset = "0x1E7FF24", VA = "0x1E7FF24")]
	public static bool AlmostEquals(this Quaternion target, Quaternion second, float maxAngle)
	{
		return default(bool);
	}

	[Token(Token = "0x60016C9")]
	[Address(RVA = "0x1E7FF84", Offset = "0x1E7FF84", VA = "0x1E7FF84")]
	public static bool AlmostEquals(this float target, float second, float floatDiff)
	{
		return default(bool);
	}

	[Token(Token = "0x60016CA")]
	[Address(RVA = "0x1E6F3FC", Offset = "0x1E6F3FC", VA = "0x1E6F3FC")]
	public static void Merge(this IDictionary target, IDictionary addHash)
	{
	}

	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x1E80050", Offset = "0x1E80050", VA = "0x1E80050")]
	public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
	{
	}

	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x1E805BC", Offset = "0x1E805BC", VA = "0x1E805BC")]
	public static string ToStringFull(this IDictionary origin)
	{
		return null;
	}

	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x1E80668", Offset = "0x1E80668", VA = "0x1E80668")]
	public static string ToStringFull(this object[] data)
	{
		return null;
	}

	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x1E80884", Offset = "0x1E80884", VA = "0x1E80884")]
	public static ExitGames.Client.Photon.Hashtable StripToStringKeys(this IDictionary original)
	{
		return null;
	}

	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x1E80D64", Offset = "0x1E80D64", VA = "0x1E80D64")]
	public static void StripKeysWithNullValues(this IDictionary original)
	{
	}

	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x1E81404", Offset = "0x1E81404", VA = "0x1E81404")]
	public static bool Contains(this int[] target, int nr)
	{
		return default(bool);
	}
}
