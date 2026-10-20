using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CA")]
public interface IVirtualStick
{
	[Token(Token = "0x60038FC")]
	Vector3 GetStickDirection();

	[Token(Token = "0x60038FD")]
	float GetTilt();
}
