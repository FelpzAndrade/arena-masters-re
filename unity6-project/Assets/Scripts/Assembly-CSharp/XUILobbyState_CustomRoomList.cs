using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E45")]
public class XUILobbyState_CustomRoomList : XUILobbyState
{
	[Token(Token = "0x4004B42")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_CustomRoomList pnlCustomRoomList;

	[Token(Token = "0x17000DAE")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A46")]
		[Address(RVA = "0x109F57C", Offset = "0x109F57C", VA = "0x109F57C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A44")]
	[Address(RVA = "0x109F56C", Offset = "0x109F56C", VA = "0x109F56C")]
	public XUILobbyState_CustomRoomList()
	{
	}

	[Token(Token = "0x6006A45")]
	[Address(RVA = "0x109F574", Offset = "0x109F574", VA = "0x109F574", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A47")]
	[Address(RVA = "0x109F674", Offset = "0x109F674", VA = "0x109F674", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A48")]
	[Address(RVA = "0x109F6F8", Offset = "0x109F6F8", VA = "0x109F6F8", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A49")]
	[Address(RVA = "0x109F714", Offset = "0x109F714", VA = "0x109F714", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A4A")]
	[Address(RVA = "0x109F834", Offset = "0x109F834", VA = "0x109F834", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A4B")]
	[Address(RVA = "0x109F88C", Offset = "0x109F88C", VA = "0x109F88C", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A4C")]
	[Address(RVA = "0x109F9D8", Offset = "0x109F9D8", VA = "0x109F9D8", Slot = "16")]
	public override void OnHide()
	{
	}
}
