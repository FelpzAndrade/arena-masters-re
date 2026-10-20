using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E62")]
public class XUILobbyState_Skin : XUILobbyState
{
	[Token(Token = "0x4004B67")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Skin pnlSkin;

	[Token(Token = "0x4004B68")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_CharList pnlCharList;

	[Token(Token = "0x4004B69")]
	[FieldOffset(Offset = "0x24")]
	private int m_charID;

	[Token(Token = "0x17000DD2")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B60")]
		[Address(RVA = "0x10ABAFC", Offset = "0x10ABAFC", VA = "0x10ABAFC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006B5E")]
	[Address(RVA = "0x10ABAEC", Offset = "0x10ABAEC", VA = "0x10ABAEC")]
	public XUILobbyState_Skin()
	{
	}

	[Token(Token = "0x6006B5F")]
	[Address(RVA = "0x10ABAF4", Offset = "0x10ABAF4", VA = "0x10ABAF4", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B61")]
	[Address(RVA = "0x10ABBF4", Offset = "0x10ABBF4", VA = "0x10ABBF4", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006B62")]
	[Address(RVA = "0x10ABBFC", Offset = "0x10ABBFC", VA = "0x10ABBFC", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B63")]
	[Address(RVA = "0x10ABC80", Offset = "0x10ABC80", VA = "0x10ABC80", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B64")]
	[Address(RVA = "0x10ABC9C", Offset = "0x10ABC9C", VA = "0x10ABC9C", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B65")]
	[Address(RVA = "0x10ABDAC", Offset = "0x10ABDAC", VA = "0x10ABDAC", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B66")]
	[Address(RVA = "0x10AC160", Offset = "0x10AC160", VA = "0x10AC160")]
	private void OnEquipSkin(string uid)
	{
	}

	[Token(Token = "0x6006B67")]
	[Address(RVA = "0x10AC2DC", Offset = "0x10AC2DC", VA = "0x10AC2DC")]
	private bool OnClickCharList(int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B68")]
	[Address(RVA = "0x10AC4C0", Offset = "0x10AC4C0", VA = "0x10AC4C0", Slot = "16")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x6006B69")]
	[Address(RVA = "0x10AC5CC", Offset = "0x10AC5CC", VA = "0x10AC5CC", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B6A")]
	[Address(RVA = "0x10AC2F4", Offset = "0x10AC2F4", VA = "0x10AC2F4")]
	private void Refresh()
	{
	}
}
