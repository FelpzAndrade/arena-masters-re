using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BA")]
public abstract class XObjectFactory_Actor : XObjectFactory
{
		protected XObjectFactory_Actor()
		{
		}

	[Token(Token = "0x17000511")]
	protected abstract CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E78")]
		get;
	}

	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x167E448", Offset = "0x167E448", VA = "0x167E448")]
	public XObjectFactory_Actor(Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x6001E79")]
	[Address(RVA = "0x167E490", Offset = "0x167E490", VA = "0x167E490")]
	protected void ApplyActorInfo(GameObject go, CSCharacterInfo info)
	{
	}

	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0x167E5EC", Offset = "0x167E5EC", VA = "0x167E5EC", Slot = "7")]
	protected override GameObject CreateGameObject(Vector3 position, Vector3 rotation)
	{
		return null;
	}
}
