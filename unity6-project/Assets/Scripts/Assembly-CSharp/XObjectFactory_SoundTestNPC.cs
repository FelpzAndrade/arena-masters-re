using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003CC")]
public class XObjectFactory_SoundTestNPC : XObjectFactory_Actor
{
	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x24")]
	private int level;

	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0x28")]
	private int grade;

	[Token(Token = "0x17000544")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x1683730", Offset = "0x1683730", VA = "0x1683730", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000545")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x16837A8", Offset = "0x16837A8", VA = "0x16837A8", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000546")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x16837B0", Offset = "0x16837B0", VA = "0x16837B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x16836C0", Offset = "0x16836C0", VA = "0x16836C0")]
	public XObjectFactory_SoundTestNPC(Vector3 position, Vector3 rotation, int actorId, int lev)
	{
	}

	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x16839D0", Offset = "0x16839D0", VA = "0x16839D0", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
