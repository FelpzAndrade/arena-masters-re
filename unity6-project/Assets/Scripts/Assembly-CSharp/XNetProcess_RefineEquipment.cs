using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C7")]
public class XNetProcess_RefineEquipment : XNetProcess_GameBase
{
	[Token(Token = "0x4002309")]
	[FieldOffset(Offset = "0x34")]
	private string m_cid;

	[Token(Token = "0x400230A")]
	[FieldOffset(Offset = "0x38")]
	private string m_EquipmentSlot;

	[Token(Token = "0x400230B")]
	[FieldOffset(Offset = "0x3C")]
	private List<string> m_materials;

	[Token(Token = "0x170008B3")]
	public override string Name
	{
		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x1EC2834", Offset = "0x1EC2834", VA = "0x1EC2834", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EBC")]
	[Address(RVA = "0x1EC264C", Offset = "0x1EC264C", VA = "0x1EC264C")]
	public XNetProcess_RefineEquipment()
	{
	}

	[Token(Token = "0x6003EBD")]
	[Address(RVA = "0x1EC2654", Offset = "0x1EC2654", VA = "0x1EC2654", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EBE")]
	[Address(RVA = "0x1EC2710", Offset = "0x1EC2710", VA = "0x1EC2710", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EC0")]
	[Address(RVA = "0x1EC28AC", Offset = "0x1EC28AC", VA = "0x1EC28AC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EC1")]
	[Address(RVA = "0x1EC28B4", Offset = "0x1EC28B4", VA = "0x1EC28B4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
