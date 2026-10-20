using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E9B")]
public class XWidget_ClanMark : MonoBehaviour
{
	[Token(Token = "0x4004CB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string PREFAP_PATH;

	[Token(Token = "0x4004CB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite sprClanMark;

	[Token(Token = "0x4004CB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject goBG;

	[Token(Token = "0x4004CB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public BoxCollider colider;

	[Token(Token = "0x4004CB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Action m_onClick;

	[Token(Token = "0x4004CB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int MarkID__BackingField;

	[Token(Token = "0x4004CB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int ColorID__BackingField;

	[Token(Token = "0x17000DF6")]
	public int MarkID
	{
		[Token(Token = "0x6006CFE")]
		[Address(RVA = "0x15D24DC", Offset = "0x15D24DC", VA = "0x15D24DC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006CFF")]
		[Address(RVA = "0x15E0670", Offset = "0x15E0670", VA = "0x15E0670")]
		private set
		{
		}
	}

	[Token(Token = "0x17000DF7")]
	public int ColorID
	{
		[Token(Token = "0x6006D00")]
		[Address(RVA = "0x15D24E4", Offset = "0x15D24E4", VA = "0x15D24E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006D01")]
		[Address(RVA = "0x15E0678", Offset = "0x15E0678", VA = "0x15E0678")]
		private set
		{
		}
	}

	[Token(Token = "0x6006CFB")]
	[Address(RVA = "0x15E05D8", Offset = "0x15E05D8", VA = "0x15E05D8")]
	public XWidget_ClanMark()
	{
	}

	[Token(Token = "0x6006CFD")]
	[Address(RVA = "0x15D12DC", Offset = "0x15D12DC", VA = "0x15D12DC")]
	public static XWidget_ClanMark Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6006D02")]
	[Address(RVA = "0x15D1490", Offset = "0x15D1490", VA = "0x15D1490")]
	public void Build(int markID, int colorID, [Optional][DefaultParameterValue(true)] bool isShowFrame, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x6006D03")]
	[Address(RVA = "0x15E0680", Offset = "0x15E0680", VA = "0x15E0680")]
	private void BuildCommon(bool isShowFrame, Action onClick)
	{
	}

	[Token(Token = "0x6006D04")]
	[Address(RVA = "0x15E0990", Offset = "0x15E0990", VA = "0x15E0990")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6006D05")]
	[Address(RVA = "0x15E0688", Offset = "0x15E0688", VA = "0x15E0688")]
	public void ChangeMark(int markID)
	{
	}

	[Token(Token = "0x6006D06")]
	[Address(RVA = "0x15E09A4", Offset = "0x15E09A4", VA = "0x15E09A4")]
	private void ChangeMark(string markPath)
	{
	}

	[Token(Token = "0x6006D07")]
	[Address(RVA = "0x15E0A98", Offset = "0x15E0A98", VA = "0x15E0A98")]
	public void UnLoadSprite()
	{
	}

	[Token(Token = "0x6006D08")]
	[Address(RVA = "0x15E080C", Offset = "0x15E080C", VA = "0x15E080C")]
	public void ChangeColor(int colorID)
	{
	}

	[Token(Token = "0x6006D09")]
	[Address(RVA = "0x15E0AD4", Offset = "0x15E0AD4", VA = "0x15E0AD4")]
	private void ChangeColor(Color color)
	{
	}

	[Token(Token = "0x6006D0A")]
	[Address(RVA = "0x15E0B10", Offset = "0x15E0B10", VA = "0x15E0B10")]
	public void SetBGActive(bool isActive)
	{
	}

	[Token(Token = "0x6006D0B")]
	[Address(RVA = "0x15E0BF0", Offset = "0x15E0BF0", VA = "0x15E0BF0")]
	public void SetColider(bool isActive)
	{
	}
}
