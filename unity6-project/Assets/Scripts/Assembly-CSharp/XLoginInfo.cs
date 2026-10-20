using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000635")]
public class XLoginInfo
{
	[Token(Token = "0x4001DDE")]
	private const string keyIsLinkingAccount = "is_Lingking";

	[Token(Token = "0x4001DDF")]
	private const string keyDeviceUid = "device_uid";

	[Token(Token = "0x4001DE0")]
	private const string keyGoogleId = "google_id";

	[Token(Token = "0x4001DE1")]
	private const string keyGoogleToken = "google_token";

	[Token(Token = "0x4001DE2")]
	private const string keyFacebookId = "facebool_id";

	[Token(Token = "0x4001DE3")]
	private const string keyFacebookToken = "facebook_token";

	[Token(Token = "0x4001DE4")]
	private const string keyNXComId = "nx_com_id";

	[Token(Token = "0x4001DE5")]
	private const string keyNXComToken = "nx_com_token";

	[Token(Token = "0x4001DE6")]
	private const string keyGameCenterId = "gameCenter_id";

	[Token(Token = "0x4001DE7")]
	private const string keyGameCenterToken = "gameCenter_token";

	[Token(Token = "0x4001DE8")]
	private const string keyCountry = "country";

	[Token(Token = "0x4001DE9")]
	private const string keyStatus = "status";

	[Token(Token = "0x4001DEA")]
	private const string keySessionId = "session-id";

	[Token(Token = "0x4001DEB")]
	[FieldOffset(Offset = "0x8")]
	private string _DeviceUid;

	[Token(Token = "0x4001DEC")]
	[FieldOffset(Offset = "0xC")]
	public string SID;

	[Token(Token = "0x4001DED")]
	[FieldOffset(Offset = "0x10")]
	public string AID;

	[Token(Token = "0x4001DEE")]
	[FieldOffset(Offset = "0x14")]
	public Queue<string> RefreshXCLog;

	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x18")]
	private string xc;

	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x1C")]
	private float xcTime;

	[Token(Token = "0x4001DF1")]
	[FieldOffset(Offset = "0x20")]
	private string IsLinkingAccount;

	[Token(Token = "0x4001DF2")]
	[FieldOffset(Offset = "0x24")]
	public string GoogleId;

	[Token(Token = "0x4001DF3")]
	[FieldOffset(Offset = "0x28")]
	public string GoogleToken;

	[Token(Token = "0x4001DF4")]
	[FieldOffset(Offset = "0x2C")]
	public string FacebookId;

	[Token(Token = "0x4001DF5")]
	[FieldOffset(Offset = "0x30")]
	public string FacebookToken;

	[Token(Token = "0x4001DF6")]
	[FieldOffset(Offset = "0x34")]
	public string NXComId;

	[Token(Token = "0x4001DF7")]
	[FieldOffset(Offset = "0x38")]
	public string NXComToken;

	[Token(Token = "0x4001DF8")]
	[FieldOffset(Offset = "0x3C")]
	public string WebServerUrl;

	[Token(Token = "0x4001DF9")]
	[FieldOffset(Offset = "0x40")]
	public string PhotonServerUrl;

	[Token(Token = "0x4001DFA")]
	[FieldOffset(Offset = "0x44")]
	public string Country;

	[Token(Token = "0x4001DFB")]
	[FieldOffset(Offset = "0x48")]
	private bool IsLogined__BackingField;

	[Token(Token = "0x170007C5")]
	public string XC
	{
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x1E260DC", Offset = "0x1E260DC", VA = "0x1E260DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x1E260E4", Offset = "0x1E260E4", VA = "0x1E260E4")]
		set
		{
		}
	}

	[Token(Token = "0x170007C6")]
	public bool NeedRefreshXC
	{
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x1E2626C", Offset = "0x1E2626C", VA = "0x1E2626C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007C7")]
	public string DeviceUid
	{
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x1E26B90", Offset = "0x1E26B90", VA = "0x1E26B90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x1E26DDC", Offset = "0x1E26DDC", VA = "0x1E26DDC")]
		set
		{
		}
	}

	[Token(Token = "0x170007C8")]
	public bool IsLogined
	{
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x1E26DE4", Offset = "0x1E26DE4", VA = "0x1E26DE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x1E26DEC", Offset = "0x1E26DEC", VA = "0x1E26DEC")]
		set
		{
		}
	}

	[Token(Token = "0x6003557")]
	[Address(RVA = "0x1E25CAC", Offset = "0x1E25CAC", VA = "0x1E25CAC")]
	public XLoginInfo()
	{
	}

	[Token(Token = "0x6003558")]
	[Address(RVA = "0x1E25E74", Offset = "0x1E25E74", VA = "0x1E25E74")]
	private void AddRefreshXCLog(string log)
	{
	}

	[Token(Token = "0x6003559")]
	[Address(RVA = "0x1E25F74", Offset = "0x1E25F74", VA = "0x1E25F74")]
	public string GetRefreshXCLog()
	{
		return null;
	}

	[Token(Token = "0x600355D")]
	[Address(RVA = "0x1E262B0", Offset = "0x1E262B0", VA = "0x1E262B0")]
	public bool GetIsLinkingAccount()
	{
		return default(bool);
	}

	[Token(Token = "0x600355E")]
	[Address(RVA = "0x1E2676C", Offset = "0x1E2676C", VA = "0x1E2676C")]
	public void SetIsLinkingAccount(bool isLinking)
	{
	}

	[Token(Token = "0x6003563")]
	[Address(RVA = "0x1E26DF4", Offset = "0x1E26DF4", VA = "0x1E26DF4")]
	public void ClearDeviceUid()
	{
	}

	[Token(Token = "0x6003564")]
	[Address(RVA = "0x1E26EAC", Offset = "0x1E26EAC", VA = "0x1E26EAC")]
	public void ClearSessionID()
	{
	}

	[Token(Token = "0x6003565")]
	private void LoadValue<TYPE>(string key, ref TYPE value, TYPE defaultVal)
	{
	}

	[Token(Token = "0x6003566")]
	[Address(RVA = "0x1E263E0", Offset = "0x1E263E0", VA = "0x1E263E0")]
	private void LoadString(string key, ref string value, string defaultVal)
	{
	}

	[Token(Token = "0x6003567")]
	[Address(RVA = "0x1E2680C", Offset = "0x1E2680C", VA = "0x1E2680C")]
	private void SaveString(string key, string value)
	{
	}

	[Token(Token = "0x6003568")]
	[Address(RVA = "0x1E26FA4", Offset = "0x1E26FA4", VA = "0x1E26FA4")]
	private void Load()
	{
	}

	[Token(Token = "0x6003569")]
	[Address(RVA = "0x1E26C98", Offset = "0x1E26C98", VA = "0x1E26C98")]
	public void Save()
	{
	}

	[Token(Token = "0x600356A")]
	[Address(RVA = "0x1E271AC", Offset = "0x1E271AC", VA = "0x1E271AC")]
	public void Init()
	{
	}

	[Token(Token = "0x600356B")]
	[Address(RVA = "0x1E271C8", Offset = "0x1E271C8", VA = "0x1E271C8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600356C")]
	[Address(RVA = "0x1E272A0", Offset = "0x1E272A0", VA = "0x1E272A0")]
	public void ResetLogined()
	{
	}

	[Token(Token = "0x600356D")]
	[Address(RVA = "0x1E272AC", Offset = "0x1E272AC", VA = "0x1E272AC")]
	public bool IsReseted()
	{
		return default(bool);
	}
}
