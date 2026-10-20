using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C2")]
public class XNetProcess_SellItem : XNetProcess_GameBase
{
	[Token(Token = "0x4002307")]
	[FieldOffset(Offset = "0x34")]
	private string m_IID;

	[Token(Token = "0x4002308")]
	[FieldOffset(Offset = "0x38")]
	private int m_amount;

	[Token(Token = "0x170008AC")]
	public override string Name
	{
		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0x1EC6FF0", Offset = "0x1EC6FF0", VA = "0x1EC6FF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E9C")]
	[Address(RVA = "0x1EC6E08", Offset = "0x1EC6E08", VA = "0x1EC6E08")]
	public XNetProcess_SellItem()
	{
	}

	[Token(Token = "0x6003E9D")]
	[Address(RVA = "0x1EC6E10", Offset = "0x1EC6E10", VA = "0x1EC6E10", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E9E")]
	[Address(RVA = "0x1EC6ECC", Offset = "0x1EC6ECC", VA = "0x1EC6ECC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EA0")]
	[Address(RVA = "0x1EC7068", Offset = "0x1EC7068", VA = "0x1EC7068", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EA1")]
	[Address(RVA = "0x1EC7070", Offset = "0x1EC7070", VA = "0x1EC7070", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
