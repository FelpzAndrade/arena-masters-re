using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000E51")]
internal class XUILobbyState_Mail : XUILobbyState
{
	[Token(Token = "0x4004B4F")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Mail mailWindow;

	[Token(Token = "0x17000DB8")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0x10A3C40", Offset = "0x10A3C40", VA = "0x10A3C40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DB9")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0x10A3DA8", Offset = "0x10A3DA8", VA = "0x10A3DA8", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006AB2")]
	[Address(RVA = "0x10A3BAC", Offset = "0x10A3BAC", VA = "0x10A3BAC")]
	public XUILobbyState_Mail()
	{
	}

	[Token(Token = "0x6006AB3")]
	[Address(RVA = "0x10A3BB4", Offset = "0x10A3BB4", VA = "0x10A3BB4", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AB4")]
	[Address(RVA = "0x10A3BBC", Offset = "0x10A3BBC", VA = "0x10A3BBC", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AB6")]
	[Address(RVA = "0x10A3D8C", Offset = "0x10A3D8C", VA = "0x10A3D8C", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AB8")]
	[Address(RVA = "0x10A3DB0", Offset = "0x10A3DB0", VA = "0x10A3DB0", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AB9")]
	[Address(RVA = "0x10A3E64", Offset = "0x10A3E64", VA = "0x10A3E64", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006ABA")]
	[Address(RVA = "0x10A40AC", Offset = "0x10A40AC", VA = "0x10A40AC", Slot = "16")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x6006ABB")]
	[Address(RVA = "0x10A4194", Offset = "0x10A4194", VA = "0x10A4194")]
	private void _003COnShow_003Em__3D5(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
