using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200040B")]
public class XCouponManager
{
	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x19A1A7C", Offset = "0x19A1A7C", VA = "0x19A1A7C")]
	public XCouponManager()
	{
	}

	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x199A940", Offset = "0x199A940", VA = "0x199A940")]
	public void UseCoupon(string couponNum)
	{
	}

	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x19A1A84", Offset = "0x19A1A84", VA = "0x19A1A84")]
	internal void ShowCouponInputBox()
	{
	}

	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x19A1C38", Offset = "0x19A1C38", VA = "0x19A1C38")]
	private bool CheckUseCoupon(string couponNumber)
	{
		return default(bool);
	}

	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x19A1CE4", Offset = "0x19A1CE4", VA = "0x19A1CE4")]
	private void ShowUseCouponFailPopup(string title, string message)
	{
	}

	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x19A1E84", Offset = "0x19A1E84", VA = "0x19A1E84")]
	private void UseCouponFail(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x19A2340", Offset = "0x19A2340", VA = "0x19A2340")]
	private void _003CUseCoupon_003Em__CC(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x19A287C", Offset = "0x19A287C", VA = "0x19A287C")]
	private void _003CShowCouponInputBox_003Em__CD(string couponNumber)
	{
	}
}
