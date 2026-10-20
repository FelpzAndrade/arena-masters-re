using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A1")]
public class InvEquipment : MonoBehaviour
{
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0xC")]
	private InvGameItem[] mItems;

	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x10")]
	private InvAttachmentPoint[] mAttachments;

	[Token(Token = "0x17000241")]
	public InvGameItem[] equippedItems
	{
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0xD914A4", Offset = "0xD914A4", VA = "0xD914A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0xD9149C", Offset = "0xD9149C", VA = "0xD9149C")]
	public InvEquipment()
	{
	}

	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0xD914AC", Offset = "0xD914AC", VA = "0xD914AC")]
	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000E90")]
	[Address(RVA = "0xD91AEC", Offset = "0xD91AEC", VA = "0xD91AEC")]
	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000E91")]
	[Address(RVA = "0xD91C60", Offset = "0xD91C60", VA = "0xD91C60")]
	public InvGameItem Unequip(InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000E92")]
	[Address(RVA = "0xD91CAC", Offset = "0xD91CAC", VA = "0xD91CAC")]
	public InvGameItem Unequip(InvBaseItem.Slot slot)
	{
		return null;
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0xD91CB4", Offset = "0xD91CB4", VA = "0xD91CB4")]
	public bool HasEquipped(InvGameItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0xD91D3C", Offset = "0xD91D3C", VA = "0xD91D3C")]
	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0xD91DDC", Offset = "0xD91DDC", VA = "0xD91DDC")]
	public InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		return null;
	}
}
