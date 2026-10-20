using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007BB")]
public class XNetProcess_EquipPet : XNetProcess_GameBase
{
	[Token(Token = "0x170008A6")]
	public override string Name
	{
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x21389C8", Offset = "0x21389C8", VA = "0x21389C8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0x21387E0", Offset = "0x21387E0", VA = "0x21387E0")]
	public XNetProcess_EquipPet()
	{
	}

	[Token(Token = "0x6003E75")]
	[Address(RVA = "0x21387E8", Offset = "0x21387E8", VA = "0x21387E8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E76")]
	[Address(RVA = "0x21388A4", Offset = "0x21388A4", VA = "0x21388A4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E78")]
	[Address(RVA = "0x2138A40", Offset = "0x2138A40", VA = "0x2138A40", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E79")]
	[Address(RVA = "0x2138A44", Offset = "0x2138A44", VA = "0x2138A44", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
