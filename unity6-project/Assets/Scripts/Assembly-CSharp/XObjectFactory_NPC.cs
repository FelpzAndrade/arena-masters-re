using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C0")]
public class XObjectFactory_NPC : XObjectFactory_Actor
{
	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x17000521")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x16829B4", Offset = "0x16829B4", VA = "0x16829B4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000522")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x1682A2C", Offset = "0x1682A2C", VA = "0x1682A2C", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000523")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x1682A34", Offset = "0x1682A34", VA = "0x1682A34", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000524")]
	protected int Level
	{
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x1682C54", Offset = "0x1682C54", VA = "0x1682C54")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x1682960", Offset = "0x1682960", VA = "0x1682960")]
	public XObjectFactory_NPC(Vector3 position, Vector3 rotation, int actorId)
	{
	}

	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x1682D30", Offset = "0x1682D30", VA = "0x1682D30", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
