using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000457")]
public class XModuleCollisionChild : MonoBehaviour
{
	[Token(Token = "0x4001563")]
	[FieldOffset(Offset = "0xC")]
	public XModuleCollision parent;

	[Token(Token = "0x60023FE")]
	[Address(RVA = "0xB55210", Offset = "0xB55210", VA = "0xB55210")]
	public XModuleCollisionChild()
	{
	}

	[Token(Token = "0x60023FF")]
	[Address(RVA = "0xB55218", Offset = "0xB55218", VA = "0xB55218")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002400")]
	[Address(RVA = "0xB5525C", Offset = "0xB5525C", VA = "0xB5525C")]
	private void OnTriggerEnter(Collider col)
	{
	}
}
