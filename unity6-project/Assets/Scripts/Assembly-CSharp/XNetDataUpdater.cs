using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000763")]
public abstract class XNetDataUpdater
{
	[Token(Token = "0x6003C3F")]
	[Address(RVA = "0x2126C78", Offset = "0x2126C78", VA = "0x2126C78")]
	protected XNetDataUpdater()
	{
	}

	[Token(Token = "0x6003C40")]
	protected abstract string GetTypeKey();

	[Token(Token = "0x6003C41")]
	protected abstract bool UpdateFromServer(JToken source);

	[Token(Token = "0x6003C42")]
	[Address(RVA = "0x2126C80", Offset = "0x2126C80", VA = "0x2126C80")]
	protected bool CheckKey(JToken json, string strKey)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C43")]
	[Address(RVA = "0x2126C8C", Offset = "0x2126C8C", VA = "0x2126C8C")]
	protected long ParseLong(JToken data, string key)
	{
		return default(long);
	}

	[Token(Token = "0x6003C44")]
	[Address(RVA = "0x2126D2C", Offset = "0x2126D2C", VA = "0x2126D2C")]
	protected int ParseInt(JToken data, string key)
	{
		return default(int);
	}

	[Token(Token = "0x6003C45")]
	[Address(RVA = "0x2126DCC", Offset = "0x2126DCC", VA = "0x2126DCC")]
	protected string ParseString(JToken data, string key)
	{
		return null;
	}

	[Token(Token = "0x6003C46")]
	[Address(RVA = "0x2126E64", Offset = "0x2126E64", VA = "0x2126E64")]
	protected bool ParseIntList(JToken data, string key, List<int> value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C47")]
	[Address(RVA = "0x2126FD4", Offset = "0x2126FD4", VA = "0x2126FD4")]
	protected bool ParseIntHashSet(JToken data, string key, HashSet<int> value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C48")]
	[Address(RVA = "0x2127160", Offset = "0x2127160", VA = "0x2127160")]
	protected bool IsValid(JToken source)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C49")]
	[Address(RVA = "0x21272C0", Offset = "0x21272C0", VA = "0x21272C0")]
	public static void Update_UserData(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C4A")]
	[Address(RVA = "0x21275D0", Offset = "0x21275D0", VA = "0x21275D0")]
	public static void Update_Characters(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C4B")]
	[Address(RVA = "0x21278E0", Offset = "0x21278E0", VA = "0x21278E0")]
	public static void Update_Items(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C4C")]
	[Address(RVA = "0x2127BF0", Offset = "0x2127BF0", VA = "0x2127BF0")]
	public static void Update_UserResource(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C4D")]
	[Address(RVA = "0x2127F00", Offset = "0x2127F00", VA = "0x2127F00")]
	public static void Update_Character(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C4E")]
	[Address(RVA = "0x2128214", Offset = "0x2128214", VA = "0x2128214")]
	public static void Update_StallItems(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C4F")]
	[Address(RVA = "0x2128454", Offset = "0x2128454", VA = "0x2128454")]
	public static void Update_AchievementClearedList(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C50")]
	[Address(RVA = "0x2128768", Offset = "0x2128768", VA = "0x2128768")]
	public static void Update_HottimeEventList(JToken Source)
	{
	}

	[Token(Token = "0x6003C51")]
	[Address(RVA = "0x21289A4", Offset = "0x21289A4", VA = "0x21289A4")]
	public static void Update_Pets(JToken source, bool IsByDiff = false)
	{
	}

	[Token(Token = "0x6003C52")]
	[Address(RVA = "0x2128CB4", Offset = "0x2128CB4", VA = "0x2128CB4")]
	public static void Update_Pet(JToken source, bool IsByDiff = false)
	{
	}
}
