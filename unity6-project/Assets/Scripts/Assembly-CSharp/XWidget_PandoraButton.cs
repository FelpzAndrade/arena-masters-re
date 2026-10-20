using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FC3")]
public class XWidget_PandoraButton : MonoBehaviour
{
	[Token(Token = "0x2000FC4")]
	private sealed class _003CBuild_003Ec__AnonStorey247
	{
		[Token(Token = "0x40053D7")]
		[FieldOffset(Offset = "0x8")]
		internal Action onClick;

		[Token(Token = "0x6007575")]
		[Address(RVA = "0x1315A94", Offset = "0x1315A94", VA = "0x1315A94")]
		public _003CBuild_003Ec__AnonStorey247()
		{
		}

		[Token(Token = "0x6007576")]
		[Address(RVA = "0x1315FE8", Offset = "0x1315FE8", VA = "0x1315FE8")]
		internal void _003C_003Em__4D5()
		{
		}
	}

	[Token(Token = "0x40053CD")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goEffect;

	[Token(Token = "0x40053CE")]
	[FieldOffset(Offset = "0x10")]
	public XUIButton btnPandora;

	[Token(Token = "0x40053CF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblContentsName;

	[Token(Token = "0x40053D0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblInfo;

	[Token(Token = "0x40053D1")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition tweenPosition;

	[Token(Token = "0x40053D2")]
	[FieldOffset(Offset = "0x20")]
	public TweenScale tweenScale;

	[Token(Token = "0x40053D3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject btnEffect;

	[Token(Token = "0x40053D4")]
	[FieldOffset(Offset = "0x28")]
	private bool isTweenPlaying;

	[Token(Token = "0x40053D5")]
	[FieldOffset(Offset = "0x2C")]
	private float elaspedTime;

	[Token(Token = "0x40053D6")]
	[FieldOffset(Offset = "0x30")]
	private bool coolEnd;

	[Token(Token = "0x600756D")]
	[Address(RVA = "0x131563C", Offset = "0x131563C", VA = "0x131563C")]
	public XWidget_PandoraButton()
	{
	}

	[Token(Token = "0x600756E")]
	[Address(RVA = "0x1315644", Offset = "0x1315644", VA = "0x1315644")]
	public void Build(Action onClick)
	{
	}

	[Token(Token = "0x600756F")]
	[Address(RVA = "0x1315C18", Offset = "0x1315C18", VA = "0x1315C18")]
	private void SetPandoraContentName(string name)
	{
	}

	[Token(Token = "0x6007570")]
	[Address(RVA = "0x1315A9C", Offset = "0x1315A9C", VA = "0x1315A9C")]
	private void TweenReset()
	{
	}

	[Token(Token = "0x6007571")]
	[Address(RVA = "0x1315C2C", Offset = "0x1315C2C", VA = "0x1315C2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6007572")]
	[Address(RVA = "0x1315E28", Offset = "0x1315E28", VA = "0x1315E28")]
	private void SetTweenRot(bool isEnable)
	{
	}

	[Token(Token = "0x6007573")]
	[Address(RVA = "0x1315ED8", Offset = "0x1315ED8", VA = "0x1315ED8")]
	private string GetCoolTimeText(int remainSec)
	{
		return null;
	}

	[Token(Token = "0x6007574")]
	[Address(RVA = "0x1315BE0", Offset = "0x1315BE0", VA = "0x1315BE0")]
	public void SetActive(bool active)
	{
	}
}
