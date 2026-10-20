using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007CC")]
public class XNetProcess_TranscendenceEquipment : XNetProcess_GameBase
{
	[Token(Token = "0x170008B8")]
	public override string Name
	{
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x1ECA9E4", Offset = "0x1ECA9E4", VA = "0x1ECA9E4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EDA")]
	[Address(RVA = "0x1ECA7FC", Offset = "0x1ECA7FC", VA = "0x1ECA7FC")]
	public XNetProcess_TranscendenceEquipment()
	{
	}

	[Token(Token = "0x6003EDB")]
	[Address(RVA = "0x1ECA804", Offset = "0x1ECA804", VA = "0x1ECA804", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EDC")]
	[Address(RVA = "0x1ECA8C0", Offset = "0x1ECA8C0", VA = "0x1ECA8C0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EDE")]
	[Address(RVA = "0x1ECAA5C", Offset = "0x1ECAA5C", VA = "0x1ECAA5C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EDF")]
	[Address(RVA = "0x1ECAA64", Offset = "0x1ECAA64", VA = "0x1ECAA64", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
