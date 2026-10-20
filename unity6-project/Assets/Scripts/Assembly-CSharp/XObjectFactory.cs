using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B9")]
public abstract class XObjectFactory
{
		protected XObjectFactory()
		{
		}

	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x8")]
	protected Vector3 position;

	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x14")]
	protected Vector3 rotation;

	[Token(Token = "0x1700050F")]
	protected abstract string PrefabName
	{
		[Token(Token = "0x6001E73")]
		get;
	}

	[Token(Token = "0x17000510")]
	protected abstract bool IsNetworkObject
	{
		[Token(Token = "0x6001E74")]
		get;
	}

	[Token(Token = "0x6001E72")]
	[Address(RVA = "0x167DC3C", Offset = "0x167DC3C", VA = "0x167DC3C")]
	public XObjectFactory(Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x6001E75")]
	public abstract XModuleEntity Run();

	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x167DC84", Offset = "0x167DC84", VA = "0x167DC84", Slot = "7")]
	protected virtual GameObject CreateGameObject(Vector3 position, Vector3 rotation)
	{
		return null;
	}
}
