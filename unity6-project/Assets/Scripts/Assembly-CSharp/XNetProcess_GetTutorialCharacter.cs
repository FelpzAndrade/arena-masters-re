using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200077A")]
public class XNetProcess_GetTutorialCharacter : XNetProcess_GameBase
{
	[Token(Token = "0x1700085A")]
	public override string Name
	{
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x1EB5320", Offset = "0x1EB5320", VA = "0x1EB5320", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CD8")]
	[Address(RVA = "0x1EB5138", Offset = "0x1EB5138", VA = "0x1EB5138")]
	public XNetProcess_GetTutorialCharacter()
	{
	}

	[Token(Token = "0x6003CD9")]
	[Address(RVA = "0x1EB5140", Offset = "0x1EB5140", VA = "0x1EB5140", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CDA")]
	[Address(RVA = "0x1EB51FC", Offset = "0x1EB51FC", VA = "0x1EB51FC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CDC")]
	[Address(RVA = "0x1EB5398", Offset = "0x1EB5398", VA = "0x1EB5398", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CDD")]
	[Address(RVA = "0x1EB53A0", Offset = "0x1EB53A0", VA = "0x1EB53A0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
