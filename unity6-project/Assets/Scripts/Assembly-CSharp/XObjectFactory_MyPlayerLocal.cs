using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C3")]
public class XObjectFactory_MyPlayerLocal : XObjectFactory_MyPlayer
{
	[Token(Token = "0x1700052B")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x1681234", Offset = "0x1681234", VA = "0x1681234", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x16811F0", Offset = "0x16811F0", VA = "0x16811F0")]
	public XObjectFactory_MyPlayerLocal(XModuleActor.CreationDesc desc, Vector3 position, Vector3 rotation)
	{
	}
}
