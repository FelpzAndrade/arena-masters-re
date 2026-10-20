using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA8")]
public class XWidget_TitleMessage : XUIAsyncLoadBase
{
	[Token(Token = "0x400407D")]
	[FieldOffset(Offset = "0x20")]
	public List<UITweener> tweenList;

	[Token(Token = "0x400407E")]
	[FieldOffset(Offset = "0x24")]
	public string EffectPath;

	[Token(Token = "0x400407F")]
	[FieldOffset(Offset = "0x28")]
	public Transform effectRoot;

	[Token(Token = "0x4004080")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblMessage_white;

	[Token(Token = "0x4004081")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblMessage;

	[Token(Token = "0x4004082")]
	[FieldOffset(Offset = "0x34")]
	private float m_durationTime;

	[Token(Token = "0x6005B62")]
	[Address(RVA = "0x1B2578C", Offset = "0x1B2578C", VA = "0x1B2578C")]
	public XWidget_TitleMessage()
	{
	}

	[Token(Token = "0x6005B63")]
	[Address(RVA = "0x1B25884", Offset = "0x1B25884", VA = "0x1B25884")]
	public void ResetPlayTween()
	{
	}

	[Token(Token = "0x6005B64")]
	[Address(RVA = "0x1B25A04", Offset = "0x1B25A04", VA = "0x1B25A04")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6005B65")]
	[Address(RVA = "0x1B25A7C", Offset = "0x1B25A7C", VA = "0x1B25A7C")]
	public void SetTitleMassage(string text, float duration)
	{
	}

	[Token(Token = "0x6005B66")]
	[Address(RVA = "0x1B25AE0", Offset = "0x1B25AE0", VA = "0x1B25AE0")]
	public bool CheckDurationTimeEnd(float delta)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B67")]
	[Address(RVA = "0x1B25B18", Offset = "0x1B25B18", VA = "0x1B25B18", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6005B68")]
	[Address(RVA = "0x1B25B40", Offset = "0x1B25B40", VA = "0x1B25B40")]
	public void RequestEfffect()
	{
	}
}
