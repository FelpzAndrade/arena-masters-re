using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001077")]
internal static class XObjectHelper
{
	[Token(Token = "0x6007C38")]
	[Address(RVA = "0x1683B68", Offset = "0x1683B68", VA = "0x1683B68")]
	public static XModuleEntity GetME(this GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6007C39")]
	[Address(RVA = "0x1683C00", Offset = "0x1683C00", VA = "0x1683C00")]
	public static XModuleActor GetActor(this GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6007C3A")]
	[Address(RVA = "0x1683CE0", Offset = "0x1683CE0", VA = "0x1683CE0")]
	public static bool IsDead(this GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C3B")]
	[Address(RVA = "0x1681BA0", Offset = "0x1681BA0", VA = "0x1681BA0")]
	public static GameObject InstantiateSceneObject(string prefabName, int actorID, int level, XTeamEnum team, Vector3 position, Vector3 rotation, bool isSceneObject)
	{
		return null;
	}

	[Token(Token = "0x6007C3C")]
	[Address(RVA = "0x167DEAC", Offset = "0x167DEAC", VA = "0x167DEAC")]
	public static GameObject Instantiate(string prefabName, Vector3 position, Vector3 rotation, bool isNetworkObject)
	{
		return null;
	}

	[Token(Token = "0x6007C3D")]
	[Address(RVA = "0x1683F28", Offset = "0x1683F28", VA = "0x1683F28")]
	public static void ResetPlayerLayerAndTag(GameObject obj)
	{
	}

	[Token(Token = "0x6007C3E")]
	[Address(RVA = "0x168400C", Offset = "0x168400C", VA = "0x168400C")]
	public static void ResetPetLayerAndTag(GameObject obj)
	{
	}

	[Token(Token = "0x6007C3F")]
	[Address(RVA = "0x16840F0", Offset = "0x16840F0", VA = "0x16840F0")]
	public static void ResetDropObjectLayerAndTag(GameObject obj)
	{
	}
}
