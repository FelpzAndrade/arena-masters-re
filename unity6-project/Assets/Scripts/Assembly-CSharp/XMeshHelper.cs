using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006A4")]
public class XMeshHelper : MonoBehaviour
{
	[Token(Token = "0x60037CA")]
	[Address(RVA = "0x1E30194", Offset = "0x1E30194", VA = "0x1E30194")]
	public XMeshHelper()
	{
	}

	[Token(Token = "0x60037CB")]
	[Address(RVA = "0x1E3019C", Offset = "0x1E3019C", VA = "0x1E3019C")]
	public static Transform FindChildByName(string ThisName, Transform ThisGObj)
	{
		return null;
	}

	[Token(Token = "0x60037CC")]
	[Address(RVA = "0x1E30574", Offset = "0x1E30574", VA = "0x1E30574")]
	public static GameObject CreateEffect(string strPrefabName, Vector3 vPos, Quaternion qRot, float fDestroyTime = -1f, float scale = 1f, float expiredTime = 0f)
	{
		return null;
	}

	[Token(Token = "0x60037CD")]
	[Address(RVA = "0x1E30D00", Offset = "0x1E30D00", VA = "0x1E30D00")]
	public static GameObject CreateEffect(string strPrefabName, Vector3 vPos, Quaternion qRot, out float flongestPSDuration, float fDestroyTime = -1f, float scale = 1f, float expiredTime = 0f)
	{
		flongestPSDuration = default;
		return null;
	}

	[Token(Token = "0x60037CE")]
	[Address(RVA = "0x1E305E8", Offset = "0x1E305E8", VA = "0x1E305E8")]
	private static GameObject CreateEffectByPool(ref string strPrefabName, Vector3 vPos, Quaternion qRot, ref float fDestroyTime, out float flongestPSDuration, float scale, float expiredTime)
	{
		flongestPSDuration = default;
		return null;
	}
}
