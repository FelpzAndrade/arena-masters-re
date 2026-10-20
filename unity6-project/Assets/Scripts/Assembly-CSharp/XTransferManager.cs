using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000BFD")]
public class XTransferManager
{
	[Token(Token = "0x2000BFE")]
	public delegate void Callback(UserTransferData userTransferData);

	[Token(Token = "0x2000BFF")]
	public delegate void BaseCallback();

	[Token(Token = "0x2000C00")]
	private sealed class _003CReservationTransfer_003Ec__AnonStorey166
	{
		[Token(Token = "0x4003CB4")]
		[FieldOffset(Offset = "0x8")]
		internal Callback callback;

		[Token(Token = "0x60056E1")]
		[Address(RVA = "0x184A2C8", Offset = "0x184A2C8", VA = "0x184A2C8")]
		public _003CReservationTransfer_003Ec__AnonStorey166()
		{
		}

		[Token(Token = "0x60056E2")]
		[Address(RVA = "0x184ABF4", Offset = "0x184ABF4", VA = "0x184ABF4")]
		internal void _003C_003Em__22F(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000C01")]
	private sealed class _003CEnterToFindTransferKey_003Ec__AnonStorey167
	{
		[Token(Token = "0x4003CB5")]
		[FieldOffset(Offset = "0x8")]
		internal BaseCallback callback;

		[Token(Token = "0x60056E3")]
		[Address(RVA = "0x184A868", Offset = "0x184A868", VA = "0x184A868")]
		public _003CEnterToFindTransferKey_003Ec__AnonStorey167()
		{
		}

		[Token(Token = "0x60056E4")]
		[Address(RVA = "0x184AB30", Offset = "0x184AB30", VA = "0x184AB30")]
		internal void _003C_003Em__230(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4003CB3")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60056D2")]
	[Address(RVA = "0x1849ED4", Offset = "0x1849ED4", VA = "0x1849ED4")]
	public XTransferManager()
	{
	}

	[Token(Token = "0x60056D3")]
	[Address(RVA = "0x1849EDC", Offset = "0x1849EDC", VA = "0x1849EDC")]
	public void GetTransferData()
	{
	}

	[Token(Token = "0x60056D4")]
	[Address(RVA = "0x184A0D8", Offset = "0x184A0D8", VA = "0x184A0D8")]
	public void ReservationTransfer(Callback callback)
	{
	}

	[Token(Token = "0x60056D5")]
	[Address(RVA = "0x184A2D0", Offset = "0x184A2D0", VA = "0x184A2D0")]
	public void EnterToFindTransferKey(string email, BaseCallback callback)
	{
	}

	[Token(Token = "0x60056D6")]
	[Address(RVA = "0x184A920", Offset = "0x184A920", VA = "0x184A920")]
	public void RequestTransfer(string transferKey)
	{
	}

	[Token(Token = "0x60056D7")]
	[Address(RVA = "0x184A870", Offset = "0x184A870", VA = "0x184A870")]
	private bool CheckEmail(string email)
	{
		return default(bool);
	}

	[Token(Token = "0x60056D8")]
	[Address(RVA = "0x184A924", Offset = "0x184A924", VA = "0x184A924")]
	private static void _003CGetTransferData_003Em__22E(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
