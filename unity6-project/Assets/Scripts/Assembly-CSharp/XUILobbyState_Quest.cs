using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E5D")]
internal class XUILobbyState_Quest : XUILobbyState
{
	[Token(Token = "0x4004B62")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Quest pnlDailyQuest;

	[Token(Token = "0x17000DC4")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0x10A9368", Offset = "0x10A9368", VA = "0x10A9368", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC5")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006B32")]
		[Address(RVA = "0x10A94F8", Offset = "0x10A94F8", VA = "0x10A94F8", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006B2D")]
	[Address(RVA = "0x10A9360", Offset = "0x10A9360", VA = "0x10A9360")]
	public XUILobbyState_Quest()
	{
	}

	[Token(Token = "0x6006B2F")]
	[Address(RVA = "0x10A9450", Offset = "0x10A9450", VA = "0x10A9450", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B30")]
	[Address(RVA = "0x10A9458", Offset = "0x10A9458", VA = "0x10A9458", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B31")]
	[Address(RVA = "0x10A94DC", Offset = "0x10A94DC", VA = "0x10A94DC", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B33")]
	[Address(RVA = "0x10A9500", Offset = "0x10A9500", VA = "0x10A9500", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B34")]
	[Address(RVA = "0x10A95B4", Offset = "0x10A95B4", VA = "0x10A95B4", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B35")]
	[Address(RVA = "0x10A97C0", Offset = "0x10A97C0", VA = "0x10A97C0", Slot = "16")]
	public override void OnHide()
	{
	}
}
