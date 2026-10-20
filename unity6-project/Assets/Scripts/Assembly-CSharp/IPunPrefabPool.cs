using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C4")]
public interface IPunPrefabPool
{
	[Token(Token = "0x60017E7")]
	GameObject Instantiate(string prefabId, Vector3 position, Quaternion rotation);

	[Token(Token = "0x60017E8")]
	void Destroy(GameObject gameObject);
}
