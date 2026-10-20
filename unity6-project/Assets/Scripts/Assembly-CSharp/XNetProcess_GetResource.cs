using System;
using Il2CppDummyDll;
using XAssetBundle;

[Token(Token = "0x2000807")]
public class XNetProcess_GetResource : XNetProcessLoginBase
{
	[Token(Token = "0x2000808")]
	private sealed class _003CAssetbundleDataDownload_003Ec__AnonStorey13F
	{
		[Token(Token = "0x4002324")]
		[FieldOffset(Offset = "0x8")]
		internal bool isShowPatchOpening;

		[Token(Token = "0x4002325")]
		[FieldOffset(Offset = "0xC")]
		internal XNetProcess_GetResource _003C_003Ef__this;

		[Token(Token = "0x600404B")]
		[Address(RVA = "0x2143D08", Offset = "0x2143D08", VA = "0x2143D08")]
		public _003CAssetbundleDataDownload_003Ec__AnonStorey13F()
		{
		}

		[Token(Token = "0x600404C")]
		[Address(RVA = "0x2145154", Offset = "0x2145154", VA = "0x2145154")]
		internal void _003C_003Em__1BA(string group, int cur, int total, float downloadedByte)
		{
		}
	}

	[Token(Token = "0x400231D")]
	[FieldOffset(Offset = "0x35")]
	private bool m_bDataLoaded;

	[Token(Token = "0x400231E")]
	[FieldOffset(Offset = "0x36")]
	private bool m_waitPopup;

	[Token(Token = "0x400231F")]
	[FieldOffset(Offset = "0x37")]
	private bool m_waitWebtoonHide;

	[Token(Token = "0x4002320")]
	[FieldOffset(Offset = "0x38")]
	private bool m_showMessage;

	[Token(Token = "0x4002321")]
	[FieldOffset(Offset = "0x3C")]
	private float m_totalFileSize;

	[Token(Token = "0x4002322")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4002323")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x170008F2")]
	public override string Name
	{
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x21434A4", Offset = "0x21434A4", VA = "0x21434A4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F3")]
	public override bool IsProcessed
	{
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x214351C", Offset = "0x214351C", VA = "0x214351C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600403C")]
	[Address(RVA = "0x2143370", Offset = "0x2143370", VA = "0x2143370")]
	public XNetProcess_GetResource()
	{
	}

	[Token(Token = "0x600403F")]
	[Address(RVA = "0x2143540", Offset = "0x2143540", VA = "0x2143540", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004040")]
	[Address(RVA = "0x2143944", Offset = "0x2143944", VA = "0x2143944", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6004041")]
	[Address(RVA = "0x2143968", Offset = "0x2143968", VA = "0x2143968")]
	private void ProgressCheckFlow(AssetbundlePatcher.Flow flow)
	{
	}

	[Token(Token = "0x6004042")]
	[Address(RVA = "0x2143A64", Offset = "0x2143A64", VA = "0x2143A64")]
	private void AssetbundleDataDownload()
	{
	}

	[Token(Token = "0x6004043")]
	[Address(RVA = "0x2143D10", Offset = "0x2143D10", VA = "0x2143D10")]
	private void CompleteCheckNewAssetbundle(AssetbundlePatcher.Result result, int fileCnt, float totalFileSize)
	{
	}

	[Token(Token = "0x6004044")]
	[Address(RVA = "0x214484C", Offset = "0x214484C", VA = "0x214484C")]
	private void CompleteUpdateAssetbundle(AssetbundlePatcher.Result result)
	{
	}

	[Token(Token = "0x6004045")]
	[Address(RVA = "0x2144794", Offset = "0x2144794", VA = "0x2144794")]
	private void CompleteDataLoad()
	{
	}

	[Token(Token = "0x6004046")]
	[Address(RVA = "0x2144D00", Offset = "0x2144D00", VA = "0x2144D00", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004047")]
	[Address(RVA = "0x2144E0C", Offset = "0x2144E0C", VA = "0x2144E0C")]
	protected void Timeout(float _delta)
	{
	}

	[Token(Token = "0x6004048")]
	[Address(RVA = "0x2144E50", Offset = "0x2144E50", VA = "0x2144E50", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6004049")]
	[Address(RVA = "0x214508C", Offset = "0x214508C", VA = "0x214508C")]
	private static void _003CCompleteCheckNewAssetbundle_003Em__1BB()
	{
	}

	[Token(Token = "0x600404A")]
	[Address(RVA = "0x2145098", Offset = "0x2145098", VA = "0x2145098")]
	private static void _003CCompleteCheckNewAssetbundle_003Em__1BC()
	{
	}
}
