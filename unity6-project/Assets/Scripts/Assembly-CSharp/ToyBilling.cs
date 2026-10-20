using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using NPA;
using Newtonsoft.Json.Linq;
using SimpleJSON;

[Token(Token = "0x2000BD5")]
public class ToyBilling : INPListenerType, INPListener
{
	[Token(Token = "0x2000BD6")]
	private sealed class _003CRequestBillingProductToServer_003Ec__AnonStorey163
	{
		[Token(Token = "0x4003C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal NetCallback netCallback;

		[Token(Token = "0x4003C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string productId;

		[Token(Token = "0x4003C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string stampToken;

		[Token(Token = "0x4003C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal string currency_code;

		[Token(Token = "0x4003C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float price;

		[Token(Token = "0x4003C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal ToyBilling _003C_003Ef__this;

		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x1D53D40", Offset = "0x1D53D40", VA = "0x1D53D40")]
		public _003CRequestBillingProductToServer_003Ec__AnonStorey163()
		{
		}

		[Token(Token = "0x60055AF")]
		[Address(RVA = "0x1D54840", Offset = "0x1D54840", VA = "0x1D54840")]
		internal void _003C_003Em__227(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x4003C06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool UseToyBilling;

	[Token(Token = "0x4003C07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly ToyBilling Instance;

	[Token(Token = "0x4003C08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Dictionary<string, ToySku> m_skuList;

	[Token(Token = "0x4003C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private NetCallback m_NetCallback;

	[Token(Token = "0x4003C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private string requestProductID;

	[Token(Token = "0x4003C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isShowPlayStoreAccountErr;

	[Token(Token = "0x4003C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool BillingIsEnabled__BackingField;

	[Token(Token = "0x4003C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	private bool ShouldShowEmptyRestoreListNotification__BackingField;

	[Token(Token = "0x4003C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Func<CSShopItem, bool> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4003C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Func<CSShopItem, string> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4003C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Func<PackageShopInfo, bool> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4003C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Func<PackageShopInfo, string> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x4003C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Func<string, bool> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x4003C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static NetCallback _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x17000C88")]
	private bool BillingIsEnabled
	{
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x1D4F834", Offset = "0x1D4F834", VA = "0x1D4F834")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x1D4F83C", Offset = "0x1D4F83C", VA = "0x1D4F83C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C89")]
	private bool ShouldShowEmptyRestoreListNotification
	{
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x1D4F844", Offset = "0x1D4F844", VA = "0x1D4F844")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x1D4F84C", Offset = "0x1D4F84C", VA = "0x1D4F84C")]
		set
		{
		}
	}

	[Token(Token = "0x600558D")]
	[Address(RVA = "0x1D4F6A4", Offset = "0x1D4F6A4", VA = "0x1D4F6A4")]
	public ToyBilling()
	{
	}

	[Token(Token = "0x6005593")]
	[Address(RVA = "0x1D4F854", Offset = "0x1D4F854", VA = "0x1D4F854")]
	public void OnLobbyEntered()
	{
	}

	[Token(Token = "0x6005594")]
	[Address(RVA = "0x1D4F934", Offset = "0x1D4F934", VA = "0x1D4F934")]
	public void OnShopEntered()
	{
	}

	[Token(Token = "0x6005595")]
	[Address(RVA = "0x1D4FAE0", Offset = "0x1D4FAE0", VA = "0x1D4FAE0")]
	private void OnBillingIsEnabled()
	{
	}

	[Token(Token = "0x6005596")]
	[Address(RVA = "0x1D4FBD4", Offset = "0x1D4FBD4", VA = "0x1D4FBD4")]
	public ToySku GetBillingProductSku(string productId)
	{
		return null;
	}

	[Token(Token = "0x6005597")]
	[Address(RVA = "0x1D4FCB4", Offset = "0x1D4FCB4", VA = "0x1D4FCB4")]
	private void RequestBillingProductSkuList()
	{
	}

	[Token(Token = "0x6005598")]
	[Address(RVA = "0x1D50690", Offset = "0x1D50690", VA = "0x1D50690")]
	public void RequestBillingPayment(string productId, [Optional] NetCallback callback)
	{
	}

	[Token(Token = "0x6005599")]
	[Address(RVA = "0x1D50E18", Offset = "0x1D50E18", VA = "0x1D50E18")]
	public void RequestBillingRestore()
	{
	}

	[Token(Token = "0x600559A")]
	[Address(RVA = "0x1D50E20", Offset = "0x1D50E20", VA = "0x1D50E20")]
	public void RequestBillingRestore(bool isUserAction)
	{
	}

	[Token(Token = "0x600559B")]
	[Address(RVA = "0x1D50C68", Offset = "0x1D50C68", VA = "0x1D50C68")]
	private Dictionary<string, string> CreateMetaForCS()
	{
		return null;
	}

	[Token(Token = "0x600559C")]
	[Address(RVA = "0x1D51124", Offset = "0x1D51124", VA = "0x1D51124", Slot = "4")]
	public void OnResult(NPResult npResult)
	{
	}

	[Token(Token = "0x600559D")]
	[Address(RVA = "0x1D51F6C", Offset = "0x1D51F6C", VA = "0x1D51F6C")]
	private void OnResultBillingProduct(NPResult npResult)
	{
	}

	[Token(Token = "0x600559E")]
	[Address(RVA = "0x1D52510", Offset = "0x1D52510", VA = "0x1D52510")]
	private void OnResultBillingPayment(NPResult npResult)
	{
	}

	[Token(Token = "0x600559F")]
	[Address(RVA = "0x1D527DC", Offset = "0x1D527DC", VA = "0x1D527DC")]
	private void OnResultBillingRestore(NPResult npResult)
	{
	}

	[Token(Token = "0x60055A0")]
	[Address(RVA = "0x1D52D68", Offset = "0x1D52D68", VA = "0x1D52D68")]
	private void OnResultBillingFinish(NPResult npResult)
	{
	}

	[Token(Token = "0x60055A1")]
	[Address(RVA = "0x1D512D8", Offset = "0x1D512D8", VA = "0x1D512D8")]
	private bool TryBillingResponseError(NPResult npResult)
	{
		return default(bool);
	}

	[Token(Token = "0x60055A2")]
	[Address(RVA = "0x1D53070", Offset = "0x1D53070", VA = "0x1D53070")]
	private bool TryBillingPaymentTransactionError(JSONNode transaction)
	{
		return default(bool);
	}

	[Token(Token = "0x60055A3")]
	[Address(RVA = "0x1D53754", Offset = "0x1D53754", VA = "0x1D53754")]
	public void RequestBillingProductToServer(string productId, string stampToken)
	{
	}

	[Token(Token = "0x60055A4")]
	[Address(RVA = "0x1D53A38", Offset = "0x1D53A38", VA = "0x1D53A38")]
	public void RequestBillingProductToServer(string productId, string stampToken, Cash.Market market, string country, string currency_code, float price, NetCallback netCallback)
	{
	}

	[Token(Token = "0x60055A5")]
	[Address(RVA = "0x1D53D48", Offset = "0x1D53D48", VA = "0x1D53D48")]
	private void SendSDKPurchaseLog(string productId, string stampToken, string currencyCode, float price)
	{
	}

	[Token(Token = "0x60055A6")]
	[Address(RVA = "0x1D53F9C", Offset = "0x1D53F9C", VA = "0x1D53F9C")]
	private bool TryResponseError(ApiReturnCode errno, string errmsg, JObject json)
	{
		return default(bool);
	}

	[Token(Token = "0x60055A7")]
	[Address(RVA = "0x1D54444", Offset = "0x1D54444", VA = "0x1D54444")]
	private bool IsFinishBillingProcess(ApiReturnCode errno, JObject json)
	{
		return default(bool);
	}

	[Token(Token = "0x60055A8")]
	[Address(RVA = "0x1D5450C", Offset = "0x1D5450C", VA = "0x1D5450C")]
	private static bool _003CRequestBillingProductSkuList_003Em__221(CSShopItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x60055A9")]
	[Address(RVA = "0x1D54538", Offset = "0x1D54538", VA = "0x1D54538")]
	private static string _003CRequestBillingProductSkuList_003Em__222(CSShopItem item)
	{
		return null;
	}

	[Token(Token = "0x60055AA")]
	[Address(RVA = "0x1D54564", Offset = "0x1D54564", VA = "0x1D54564")]
	private static bool _003CRequestBillingProductSkuList_003Em__223(PackageShopInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x60055AB")]
	[Address(RVA = "0x1D54590", Offset = "0x1D54590", VA = "0x1D54590")]
	private static string _003CRequestBillingProductSkuList_003Em__224(PackageShopInfo item)
	{
		return null;
	}

	[Token(Token = "0x60055AC")]
	[Address(RVA = "0x1D545BC", Offset = "0x1D545BC", VA = "0x1D545BC")]
	private static bool _003CRequestBillingProductSkuList_003Em__225(string productId)
	{
		return default(bool);
	}

	[Token(Token = "0x60055AD")]
	[Address(RVA = "0x1D54668", Offset = "0x1D54668", VA = "0x1D54668")]
	private static void _003CRequestBillingRestore_003Em__226(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
