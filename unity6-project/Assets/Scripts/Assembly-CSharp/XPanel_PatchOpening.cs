using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200104A")]
public class XPanel_PatchOpening : MonoBehaviour
{
	[Token(Token = "0x40057CF")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprBG1;

	[Token(Token = "0x40057D0")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprBG2;

	[Token(Token = "0x40057D1")]
	[FieldOffset(Offset = "0x14")]
	public UITable bgTable;

	[Token(Token = "0x40057D2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblPercent;

	[Token(Token = "0x40057D3")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar prbAll;

	[Token(Token = "0x40057D4")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_Builder textBuilder;

	[Token(Token = "0x40057D5")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_Builder imageBuilder;

	[Token(Token = "0x40057D6")]
	[FieldOffset(Offset = "0x28")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x40057D7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goProgress;

	[Token(Token = "0x40057D8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goComplteTouch;

	[Token(Token = "0x40057D9")]
	[FieldOffset(Offset = "0x34")]
	public float NextImageShowInterval;

	[Token(Token = "0x40057DA")]
	[FieldOffset(Offset = "0x38")]
	public bool UseAutoNext;

	[Token(Token = "0x40057DB")]
	[FieldOffset(Offset = "0x39")]
	public bool UseTweenNext;

	[Token(Token = "0x40057DC")]
	[FieldOffset(Offset = "0x3C")]
	private Action m_onCompleteDisapper;

	[Token(Token = "0x40057DD")]
	[FieldOffset(Offset = "0x40")]
	private Action m_onHideCallback;

	[Token(Token = "0x40057DE")]
	[FieldOffset(Offset = "0x44")]
	public int TotalPageCount;

	[Token(Token = "0x40057DF")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsTweening;

	[Token(Token = "0x40057E0")]
	[FieldOffset(Offset = "0x4C")]
	private float m_elaspedTime;

	[Token(Token = "0x40057E1")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, XDownloadEpisodeInfo> downImgInfos;

	[Token(Token = "0x40057E2")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<int, int> cacheEpisodeIndex;

	[Token(Token = "0x40057E3")]
	[FieldOffset(Offset = "0x58")]
	private int CurShowIndex__BackingField;

	[Token(Token = "0x17000F0B")]
	public int CurShowIndex
	{
		[Token(Token = "0x6007989")]
		[Address(RVA = "0x1010588", Offset = "0x1010588", VA = "0x1010588")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600798A")]
		[Address(RVA = "0x1010590", Offset = "0x1010590", VA = "0x1010590")]
		private set
		{
		}
	}

	[Token(Token = "0x6007988")]
	[Address(RVA = "0x10104C8", Offset = "0x10104C8", VA = "0x10104C8")]
	public XPanel_PatchOpening()
	{
	}

	[Token(Token = "0x600798B")]
	[Address(RVA = "0x1010598", Offset = "0x1010598", VA = "0x1010598")]
	private void BuildDisplayInfo(int index)
	{
	}

	[Token(Token = "0x600798C")]
	[Address(RVA = "0x1010CC8", Offset = "0x1010CC8", VA = "0x1010CC8")]
	private void CalcCacheEpisodeIndexAndTotalCnt()
	{
	}

	[Token(Token = "0x600798D")]
	[Address(RVA = "0x1010ECC", Offset = "0x1010ECC", VA = "0x1010ECC")]
	public void TryGetEpisodeParam(int curShowIndex, out int episode, out int page)
	{
		episode = default;
		page = default;
	}

	[Token(Token = "0x600798E")]
	[Address(RVA = "0x1010BA4", Offset = "0x1010BA4", VA = "0x1010BA4")]
	public XDownloadPageInfo GetPageInfo(int curShowIndex)
	{
		return null;
	}

	[Token(Token = "0x600798F")]
	[Address(RVA = "0x1011128", Offset = "0x1011128", VA = "0x1011128")]
	private void BuildBackImage(int index)
	{
	}

	[Token(Token = "0x6007990")]
	[Address(RVA = "0x1011268", Offset = "0x1011268", VA = "0x1011268")]
	private void BuildBG(UI2DSprite sprBG, string path)
	{
	}

	[Token(Token = "0x6007991")]
	[Address(RVA = "0x10113CC", Offset = "0x10113CC", VA = "0x10113CC")]
	public void Update()
	{
	}

	[Token(Token = "0x6007992")]
	[Address(RVA = "0x1011454", Offset = "0x1011454", VA = "0x1011454")]
	public void Show(Dictionary<int, XDownloadEpisodeInfo> infos, int defaultIndex = 0)
	{
	}

	[Token(Token = "0x6007993")]
	[Address(RVA = "0x10117EC", Offset = "0x10117EC", VA = "0x10117EC")]
	public void ChangeCompleteDownloadPatchOpening(Action onHideCallback)
	{
	}

	[Token(Token = "0x6007994")]
	[Address(RVA = "0x10116A4", Offset = "0x10116A4", VA = "0x10116A4")]
	private void ChangeBottomUI(bool isTouch)
	{
	}

	[Token(Token = "0x6007995")]
	[Address(RVA = "0x101180C", Offset = "0x101180C", VA = "0x101180C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007996")]
	[Address(RVA = "0x1011548", Offset = "0x1011548", VA = "0x1011548")]
	public void UpdateProgress(float curPercent)
	{
	}

	[Token(Token = "0x6007997")]
	[Address(RVA = "0x1011524", Offset = "0x1011524", VA = "0x1011524")]
	public void UpdateImage()
	{
	}

	[Token(Token = "0x6007998")]
	[Address(RVA = "0x1011858", Offset = "0x1011858", VA = "0x1011858")]
	private void DisapperImage()
	{
	}

	[Token(Token = "0x6007999")]
	[Address(RVA = "0x1011A34", Offset = "0x1011A34", VA = "0x1011A34")]
	private void ApperImage()
	{
	}

	[Token(Token = "0x600799A")]
	[Address(RVA = "0x1011B9C", Offset = "0x1011B9C", VA = "0x1011B9C")]
	public void OnClick_Prev()
	{
	}

	[Token(Token = "0x600799B")]
	[Address(RVA = "0x101142C", Offset = "0x101142C", VA = "0x101142C")]
	public void OnClick_Next()
	{
	}

	[Token(Token = "0x600799C")]
	[Address(RVA = "0x1011BC0", Offset = "0x1011BC0", VA = "0x1011BC0")]
	private void _003CDisapperImage_003Em__512()
	{
	}

	[Token(Token = "0x600799D")]
	[Address(RVA = "0x1011C7C", Offset = "0x1011C7C", VA = "0x1011C7C")]
	private void _003CApperImage_003Em__513()
	{
	}
}
