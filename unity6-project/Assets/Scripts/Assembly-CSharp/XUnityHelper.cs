using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006A6")]
public static class XUnityHelper
{
	[Token(Token = "0x60037D2")]
	public static TYPE AddComponent<TYPE>(GameObject inst, int count = 1) where TYPE : Component
	{
		return null;
	}

	[Token(Token = "0x60037D3")]
	public static TYPE AddModuleBaseIntoEntity<TYPE>(GameObject inst) where TYPE : XModuleBase, new()
	{
		return null;
	}

	[Token(Token = "0x60037D4")]
	private static TYPE NewModuleBase<TYPE>() where TYPE : XModuleBase, new()
	{
		return null;
	}

	[Token(Token = "0x60037D5")]
	[Address(RVA = "0x190A0F4", Offset = "0x190A0F4", VA = "0x190A0F4")]
	public static void UnloadSprite(Sprite sprite)
	{
	}

	[Token(Token = "0x60037D6")]
	[Address(RVA = "0x190C94C", Offset = "0x190C94C", VA = "0x190C94C")]
	public static void SetLocalPositionX(Transform trandsform, float posX)
	{
	}

	[Token(Token = "0x60037D7")]
	[Address(RVA = "0x193B300", Offset = "0x193B300", VA = "0x193B300")]
	public static void SetLocalPositionY(Transform trandsform, float posY)
	{
	}

	[Token(Token = "0x60037D8")]
	[Address(RVA = "0x193B37C", Offset = "0x193B37C", VA = "0x193B37C")]
	public static void SetLocalScaleXYZ(Transform trandsform, float tX, float tY, float tZ)
	{
	}

	[Token(Token = "0x60037D9")]
	[Address(RVA = "0x193B408", Offset = "0x193B408", VA = "0x193B408")]
	public static void SetLocalRotation(Transform trandsform, float rX, float rY, float rZ)
	{
	}

	[Token(Token = "0x60037DA")]
	[Address(RVA = "0x193B490", Offset = "0x193B490", VA = "0x193B490")]
	public static void SetTransformValue(Transform from, Transform to)
	{
	}

	[Token(Token = "0x60037DB")]
	[Address(RVA = "0x190CAEC", Offset = "0x190CAEC", VA = "0x190CAEC")]
	public static void ResetTransform(Transform tr)
	{
	}

	[Token(Token = "0x60037DC")]
	[Address(RVA = "0x190CB84", Offset = "0x190CB84", VA = "0x190CB84")]
	public static GameObject Instantiate(GameObject prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60037DD")]
	[Address(RVA = "0x193B53C", Offset = "0x193B53C", VA = "0x193B53C")]
	public static GameObject CreateGameObject(string name, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60037DE")]
	public static T CreateGameObject<T>(string name, Transform parent) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60037DF")]
	[Address(RVA = "0x193B608", Offset = "0x193B608", VA = "0x193B608")]
	public static void ClearChildren(Transform transform)
	{
	}

	[Token(Token = "0x60037E0")]
	[Address(RVA = "0x193B7D8", Offset = "0x193B7D8", VA = "0x193B7D8")]
	public static void SetEnableRenderer(GameObject go, bool val)
	{
	}

	[Token(Token = "0x60037E1")]
	[Address(RVA = "0x193B914", Offset = "0x193B914", VA = "0x193B914")]
	public static bool IsBehindMe(Transform tr, Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x60037E2")]
	[Address(RVA = "0x193B9F0", Offset = "0x193B9F0", VA = "0x193B9F0")]
	public static string GetAndroidID()
	{
		return null;
	}

	[Token(Token = "0x60037E3")]
	[Address(RVA = "0x193BAC8", Offset = "0x193BAC8", VA = "0x193BAC8")]
	public static int GetPointVersion(ConnectEnum.ServerType serverType)
	{
		return default(int);
	}
}
