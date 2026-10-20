using System;
using Il2CppDummyDll;

[Token(Token = "0x2000800")]
public class XNetProcess_GetNetConfig : XNetProcessLoginBase
{
	[Token(Token = "0x2000801")]
	private sealed class _003CStartCoroutineWWWDownload_003Ec__AnonStorey13E
	{
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x8")]
		internal TestPrefs testPrefs;

		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0xC")]
		internal string versionStr;

		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x10")]
		internal string url;

		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x14")]
		internal int tryCount;

		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x18")]
		internal XNetProcess_GetNetConfig _003C_003Ef__this;

		[Token(Token = "0x6004017")]
		[Address(RVA = "0x213EEB4", Offset = "0x213EEB4", VA = "0x213EEB4")]
		public _003CStartCoroutineWWWDownload_003Ec__AnonStorey13E()
		{
		}

		[Token(Token = "0x6004018")]
		[Address(RVA = "0x214003C", Offset = "0x214003C", VA = "0x214003C")]
		internal void _003C_003Em__1B1(string text)
		{
		}

		[Token(Token = "0x6004019")]
		[Address(RVA = "0x21401E4", Offset = "0x21401E4", VA = "0x21401E4")]
		internal void _003C_003Em__1B2(string errorStr, long tick)
		{
		}
	}

	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x35")]
	private bool m_isShowFailPopup;

	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x38")]
	private string triedConfigUrl;

	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x170008EB")]
	public override string Name
	{
		[Token(Token = "0x600400E")]
		[Address(RVA = "0x213E2D4", Offset = "0x213E2D4", VA = "0x213E2D4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600400D")]
	[Address(RVA = "0x213E2CC", Offset = "0x213E2CC", VA = "0x213E2CC")]
	public XNetProcess_GetNetConfig()
	{
	}

	[Token(Token = "0x600400F")]
	[Address(RVA = "0x213E34C", Offset = "0x213E34C", VA = "0x213E34C", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6004010")]
	[Address(RVA = "0x213E360", Offset = "0x213E360", VA = "0x213E360", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004011")]
	[Address(RVA = "0x213E904", Offset = "0x213E904", VA = "0x213E904")]
	private void StartCoroutineWWWDownload(string versionStr, TestPrefs testPrefs, int tryCount)
	{
	}

	[Token(Token = "0x6004012")]
	[Address(RVA = "0x213EEBC", Offset = "0x213EEBC", VA = "0x213EEBC")]
	private void ShowFailNotiForChangeRegion(string errorStr, long tick)
	{
	}

	[Token(Token = "0x6004013")]
	[Address(RVA = "0x213F1B4", Offset = "0x213F1B4", VA = "0x213F1B4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004014")]
	[Address(RVA = "0x213F27C", Offset = "0x213F27C", VA = "0x213F27C")]
	private bool ParseConfig(string text, string versionStr, int testAssetVer = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6004015")]
	[Address(RVA = "0x213FF5C", Offset = "0x213FF5C", VA = "0x213FF5C")]
	private static void _003CShowFailNotiForChangeRegion_003Em__1B3()
	{
	}

	[Token(Token = "0x6004016")]
	[Address(RVA = "0x2140030", Offset = "0x2140030", VA = "0x2140030")]
	private static void _003CParseConfig_003Em__1B4()
	{
	}
}
