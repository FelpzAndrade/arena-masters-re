using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063C")]
public interface IXObjectPoolManager
{
	[Token(Token = "0x600359E")]
	bool Peek(XPoolType type, string goName);

	[Token(Token = "0x600359F")]
	void Destroy(XPoolType type, GameObject target);
}
