using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200039A")]
public class TestPrefs : ScriptableObject
{
	[Token(Token = "0x40012C2")]
	public const string PREFS_NAME = "TestPrefs";

	[Token(Token = "0x40012C3")]
	public const string PREFS_PATH = "Assets/Resources/TestPrefs.asset";

	[Token(Token = "0x40012C4")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	public int testMinorVersion;

	[Token(Token = "0x40012C5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int testAssetbundleVersion;

	[Token(Token = "0x40012C6")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public bool usingLocalAssetdown;

	[Token(Token = "0x40012C7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string testCountry;

	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x1D4C51C", Offset = "0x1D4C51C", VA = "0x1D4C51C")]
	public TestPrefs()
	{
	}

	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x1D4C5A8", Offset = "0x1D4C5A8", VA = "0x1D4C5A8")]
	public static TestPrefs Load()
	{
		return null;
	}
}
