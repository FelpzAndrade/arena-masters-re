using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000EE6")]
public class XWidget_StallChargeConfirm : UIPopup
{
	[Token(Token = "0x2000EE7")]
	private sealed class _003CRequestRefreshPointShopList_003Ec__AnonStorey21C
	{
		[Token(Token = "0x4004EE7")]
		[FieldOffset(Offset = "0x8")]
		internal bool isAdvertisementCharge;

		[Token(Token = "0x4004EE8")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_StallChargeConfirm _003C_003Ef__this;

		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0x1B0E4B8", Offset = "0x1B0E4B8", VA = "0x1B0E4B8")]
		public _003CRequestRefreshPointShopList_003Ec__AnonStorey21C()
		{
		}

		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0x1B0E4C0", Offset = "0x1B0E4C0", VA = "0x1B0E4C0")]
		internal void _003C_003Em__43F(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004EE2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblChargePrice;

	[Token(Token = "0x4004EE3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblContents;

	[Token(Token = "0x4004EE4")]
	[FieldOffset(Offset = "0x28")]
	public UI2DSprite CurrencyIcon;

	[Token(Token = "0x4004EE5")]
	[FieldOffset(Offset = "0x2C")]
	private int m_price;

	[Token(Token = "0x4004EE6")]
	[FieldOffset(Offset = "0x30")]
	private StallShopLogicBase logic;

	[Token(Token = "0x6006F34")]
	[Address(RVA = "0x1B0DB78", Offset = "0x1B0DB78", VA = "0x1B0DB78")]
	public XWidget_StallChargeConfirm()
	{
	}

	[Token(Token = "0x6006F35")]
	[Address(RVA = "0x1B0DB80", Offset = "0x1B0DB80", VA = "0x1B0DB80")]
	public void Show(StallType stallType)
	{
	}

	[Token(Token = "0x6006F36")]
	[Address(RVA = "0x1B0DC00", Offset = "0x1B0DC00", VA = "0x1B0DC00", Slot = "26")]
	protected virtual void Build()
	{
	}

	[Token(Token = "0x6006F37")]
	[Address(RVA = "0x1B0DE84", Offset = "0x1B0DE84", VA = "0x1B0DE84")]
	private void SetChargeText(int price, string currencyName)
	{
	}

	[Token(Token = "0x6006F38")]
	[Address(RVA = "0x1B0DFF0", Offset = "0x1B0DFF0", VA = "0x1B0DFF0")]
	private bool CheckResource()
	{
		return default(bool);
	}

	[Token(Token = "0x6006F39")]
	[Address(RVA = "0x1B0E178", Offset = "0x1B0E178", VA = "0x1B0E178")]
	public void OnClick_ChargeDailyBox()
	{
	}

	[Token(Token = "0x6006F3A")]
	[Address(RVA = "0x1B0E1D8", Offset = "0x1B0E1D8", VA = "0x1B0E1D8")]
	protected void RequestRefreshPointShopList(bool isAdvertisementCharge = false)
	{
	}
}
