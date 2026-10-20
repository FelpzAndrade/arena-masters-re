using Il2CppDummyDll;
using IniFile;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20008E4")]
public class AMConfigIniFile
{
	[Token(Token = "0x4002B1A")]
	[FieldOffset(Offset = "0x8")]
	private global::IniFile.IniFile ini;

	[Token(Token = "0x4002B1B")]
	[FieldOffset(Offset = "0xC")]
	private string platform;

	[Token(Token = "0x4002B1C")]
	[FieldOffset(Offset = "0x10")]
	public readonly string SECTOR;

	[Token(Token = "0x4002B1D")]
	[FieldOffset(Offset = "0x14")]
	public readonly string WEBSERVER_URL_KEY;

	[Token(Token = "0x4002B1E")]
	[FieldOffset(Offset = "0x18")]
	public readonly string PHOTONSERVER_URL_KEY;

	[Token(Token = "0x4002B1F")]
	[FieldOffset(Offset = "0x1C")]
	public readonly string GAMEDATA_KEY;

	[Token(Token = "0x4002B20")]
	[FieldOffset(Offset = "0x20")]
	public readonly string ASSETBUNDLE_KEY;

	[Token(Token = "0x4002B21")]
	[FieldOffset(Offset = "0x24")]
	public readonly string BYVERSION_POST_FIX;

	[Token(Token = "0x4002B22")]
	[FieldOffset(Offset = "0x28")]
	public readonly string IOS_POST_FIX;

	[Token(Token = "0x6004757")]
	[Address(RVA = "0x20B95F0", Offset = "0x20B95F0", VA = "0x20B95F0")]
	public AMConfigIniFile(string text, string platform)
	{
	}

	[Token(Token = "0x6004758")]
	[Address(RVA = "0x20B97A0", Offset = "0x20B97A0", VA = "0x20B97A0")]
	public string GetWebServerAddress(string version)
	{
		return null;
	}

	[Token(Token = "0x6004759")]
	[Address(RVA = "0x20B9994", Offset = "0x20B9994", VA = "0x20B9994")]
	public string GetPhotonServerAddress(string version)
	{
		return null;
	}

	[Token(Token = "0x600475A")]
	[Address(RVA = "0x20B99CC", Offset = "0x20B99CC", VA = "0x20B99CC")]
	public int GetServerGameDataVersion(string version)
	{
		return default(int);
	}

	[Token(Token = "0x600475B")]
	[Address(RVA = "0x20B9A14", Offset = "0x20B9A14", VA = "0x20B9A14")]
	public int GetAssetBundleVersion(string version)
	{
		return default(int);
	}

	[Token(Token = "0x600475C")]
	[Address(RVA = "0x20B9F34", Offset = "0x20B9F34", VA = "0x20B9F34")]
	public void SetGameDataVersion(string version, string value, bool isIOS)
	{
	}

	[Token(Token = "0x600475D")]
	[Address(RVA = "0x20BA508", Offset = "0x20BA508", VA = "0x20BA508")]
	public void SetAssetBundleVersionETC(string version, string value)
	{
	}

	[Token(Token = "0x600475E")]
	[Address(RVA = "0x20BA78C", Offset = "0x20BA78C", VA = "0x20BA78C")]
	public void SetAssetBundleVersionIOS(string version, string value)
	{
	}

	[Token(Token = "0x600475F")]
	[Address(RVA = "0x20BACF4", Offset = "0x20BACF4", VA = "0x20BACF4")]
	public void RemoveGameDataByVersion(string version, bool isIOS)
	{
	}

	[Token(Token = "0x6004760")]
	[Address(RVA = "0x20BAF44", Offset = "0x20BAF44", VA = "0x20BAF44")]
	public void RemoveAssetBundleByVersion(string version, bool isIOS)
	{
	}

	[Token(Token = "0x6004761")]
	[Address(RVA = "0x20BB018", Offset = "0x20BB018", VA = "0x20BB018")]
	public void SetActiveByVersionURL(bool active, bool isIOS)
	{
	}

	[Token(Token = "0x6004762")]
	[Address(RVA = "0x20BA2DC", Offset = "0x20BA2DC", VA = "0x20BA2DC")]
	public void SetActiveGameDataByVersion(bool active, bool isIOS)
	{
	}

	[Token(Token = "0x6004763")]
	[Address(RVA = "0x20BA9BC", Offset = "0x20BA9BC", VA = "0x20BA9BC")]
	public void SetActiveAssetBundleByVersionIOS(bool active)
	{
	}

	[Token(Token = "0x6004764")]
	[Address(RVA = "0x20BA6C4", Offset = "0x20BA6C4", VA = "0x20BA6C4")]
	public void SetActiveAssetBundleByVersionETC(bool active)
	{
	}

	[Token(Token = "0x6004765")]
	[Address(RVA = "0x20BA0F4", Offset = "0x20BA0F4", VA = "0x20BA0F4")]
	public string GetInactiveKey(string activeKey)
	{
		return null;
	}

	[Token(Token = "0x6004766")]
	[Address(RVA = "0x20BB17C", Offset = "0x20BB17C", VA = "0x20BB17C")]
	private void SetActiveKey(bool active, string baseKey)
	{
	}

	[Token(Token = "0x6004767")]
	[Address(RVA = "0x20B97D8", Offset = "0x20B97D8", VA = "0x20B97D8")]
	private bool IsPlatformIOS()
	{
		return default(bool);
	}

	[Token(Token = "0x6004768")]
	[Address(RVA = "0x20B9EFC", Offset = "0x20B9EFC", VA = "0x20B9EFC")]
	public string GetValue(string key)
	{
		return null;
	}

	[Token(Token = "0x6004769")]
	[Address(RVA = "0x20B98A0", Offset = "0x20B98A0", VA = "0x20B98A0")]
	private string GetValue(string key, string version, bool isIOS)
	{
		return null;
	}

	[Token(Token = "0x600476A")]
	[Address(RVA = "0x20BA2A4", Offset = "0x20BA2A4", VA = "0x20BA2A4")]
	private void RemoveKey(string key)
	{
	}

	[Token(Token = "0x600476B")]
	[Address(RVA = "0x20BACA8", Offset = "0x20BACA8", VA = "0x20BACA8")]
	public void SetValue(string key, string value)
	{
	}

	[Token(Token = "0x600476C")]
	[Address(RVA = "0x20BA410", Offset = "0x20BA410", VA = "0x20BA410")]
	private void SetValue(string key, string version, string value, bool isIOS)
	{
	}

	[Token(Token = "0x600476D")]
	[Address(RVA = "0x20BAD18", Offset = "0x20BAD18", VA = "0x20BAD18")]
	private void RemoveByVersion(string key, string version, bool isIOS)
	{
	}

	[Token(Token = "0x600476E")]
	[Address(RVA = "0x20B9CD8", Offset = "0x20B9CD8", VA = "0x20B9CD8")]
	private string GetVersionByVersion(string key, string version, bool isIOS)
	{
		return null;
	}

	[Token(Token = "0x600476F")]
	[Address(RVA = "0x20BA1B8", Offset = "0x20BA1B8", VA = "0x20BA1B8")]
	private bool TryGetByVersionValue(string key, out JObject value)
	{
		value = default;
		return default(bool);
	}

	[Token(Token = "0x6004770")]
	[Address(RVA = "0x20BAA98", Offset = "0x20BAA98", VA = "0x20BAA98")]
	private void SetVersionByVersion(string key, string version, string value, bool isIOS)
	{
	}

	[Token(Token = "0x6004771")]
	[Address(RVA = "0x20BB204", Offset = "0x20BB204", VA = "0x20BB204")]
	public void Save(string path)
	{
	}

	[Token(Token = "0x6004772")]
	[Address(RVA = "0x20BB230", Offset = "0x20BB230", VA = "0x20BB230")]
	public string GetText()
	{
		return null;
	}
}
