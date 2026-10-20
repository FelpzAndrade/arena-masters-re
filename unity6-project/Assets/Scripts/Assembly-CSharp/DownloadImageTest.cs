using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC1")]
public class DownloadImageTest : MonoBehaviour
{
	[Token(Token = "0x4003BD0")]
	[FieldOffset(Offset = "0xC")]
	public XPanel_PatchOpening opening;

	[Token(Token = "0x4003BD1")]
	[FieldOffset(Offset = "0x10")]
	public KeyCode buttonShowToggleKeycode;

	[Token(Token = "0x4003BD2")]
	[FieldOffset(Offset = "0x14")]
	private bool IsShowGUI;

	[Token(Token = "0x4003BD3")]
	[FieldOffset(Offset = "0x18")]
	public string inputText;

	[Token(Token = "0x4003BD4")]
	[FieldOffset(Offset = "0x1C")]
	public string inputEpisode;

	[Token(Token = "0x4003BD5")]
	[FieldOffset(Offset = "0x20")]
	public string inputPage;

	[Token(Token = "0x4003BD6")]
	[FieldOffset(Offset = "0x24")]
	public bool firstAutoNextUse;

	[Token(Token = "0x4003BD7")]
	[FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x4003BD8")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XDownloadEpisodeInfo, int> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x6005505")]
	[Address(RVA = "0x1E63874", Offset = "0x1E63874", VA = "0x1E63874")]
	public DownloadImageTest()
	{
	}

	[Token(Token = "0x6005506")]
	[Address(RVA = "0x1E63938", Offset = "0x1E63938", VA = "0x1E63938")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005507")]
	[Address(RVA = "0x1E63A10", Offset = "0x1E63A10", VA = "0x1E63A10")]
	private void Start()
	{
	}

	[Token(Token = "0x6005508")]
	[Address(RVA = "0x1E63F50", Offset = "0x1E63F50", VA = "0x1E63F50")]
	private void Update()
	{
	}

	[Token(Token = "0x6005509")]
	[Address(RVA = "0x1E6400C", Offset = "0x1E6400C", VA = "0x1E6400C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600550A")]
	[Address(RVA = "0x1E63E2C", Offset = "0x1E63E2C", VA = "0x1E63E2C")]
	public void InitByInput(string language)
	{
	}

	[Token(Token = "0x600550B")]
	[Address(RVA = "0x1E65018", Offset = "0x1E65018", VA = "0x1E65018")]
	private void Init(string language, int episode, int page)
	{
	}

	[Token(Token = "0x600550C")]
	[Address(RVA = "0x1E63B6C", Offset = "0x1E63B6C", VA = "0x1E63B6C")]
	public void LoadDownloadImgFile()
	{
	}

	[Token(Token = "0x600550D")]
	[Address(RVA = "0x1E65490", Offset = "0x1E65490", VA = "0x1E65490")]
	private static int _003CInit_003Em__218(XDownloadEpisodeInfo x)
	{
		return default(int);
	}
}
