using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000777")]
public class XNetProcess_SelectProfileIcon : XNetProcess_GameBase
{
	[Token(Token = "0x17000857")]
	public override string Name
	{
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x1EC6B10", Offset = "0x1EC6B10", VA = "0x1EC6B10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CC6")]
	[Address(RVA = "0x1EC6928", Offset = "0x1EC6928", VA = "0x1EC6928")]
	public XNetProcess_SelectProfileIcon()
	{
	}

	[Token(Token = "0x6003CC7")]
	[Address(RVA = "0x1EC6930", Offset = "0x1EC6930", VA = "0x1EC6930", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CC8")]
	[Address(RVA = "0x1EC69EC", Offset = "0x1EC69EC", VA = "0x1EC69EC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CCA")]
	[Address(RVA = "0x1EC6B88", Offset = "0x1EC6B88", VA = "0x1EC6B88", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CCB")]
	[Address(RVA = "0x1EC6B90", Offset = "0x1EC6B90", VA = "0x1EC6B90", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
