using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C73")]
public class XWidget_CoolTime : MonoBehaviour
{
	[Token(Token = "0x4003F2A")]
	[FieldOffset(Offset = "0xC")]
	private UILabel _lblCooltime;

	[Token(Token = "0x4003F2B")]
	[FieldOffset(Offset = "0x10")]
	private DateTime startDateTime;

	[Token(Token = "0x4003F2C")]
	[FieldOffset(Offset = "0x20")]
	private DateTime endDateTime;

	[Token(Token = "0x4003F2D")]
	[FieldOffset(Offset = "0x30")]
	private Action coolEndCallBack;

	[Token(Token = "0x4003F2E")]
	[FieldOffset(Offset = "0x34")]
	private float elaspedTime;

	[Token(Token = "0x4003F2F")]
	[FieldOffset(Offset = "0x38")]
	private bool CoolDownEnable;

	[Token(Token = "0x17000CBE")]
	public UILabel lblCoolTime
	{
		[Token(Token = "0x60059D9")]
		[Address(RVA = "0x15EAD94", Offset = "0x15EAD94", VA = "0x15EAD94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60059D8")]
	[Address(RVA = "0x15EAD8C", Offset = "0x15EAD8C", VA = "0x15EAD8C")]
	public XWidget_CoolTime()
	{
	}

	[Token(Token = "0x60059DA")]
	[Address(RVA = "0x15EAE98", Offset = "0x15EAE98", VA = "0x15EAE98")]
	public void Build(bool coolDown, long startTick, int coolSec, Action coolEndCallBack)
	{
	}

	[Token(Token = "0x60059DB")]
	[Address(RVA = "0x15EB004", Offset = "0x15EB004", VA = "0x15EB004")]
	private DateTime GetNowLocalTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60059DC")]
	[Address(RVA = "0x15EAF00", Offset = "0x15EAF00", VA = "0x15EAF00")]
	public void Build(bool coolDown, DateTime startDateTime, int coolSec, Action coolEndCallBack, bool forceUpdate = true)
	{
	}

	[Token(Token = "0x60059DD")]
	[Address(RVA = "0x15EB294", Offset = "0x15EB294", VA = "0x15EB294")]
	public void UpdateText(int remainSec)
	{
	}

	[Token(Token = "0x60059DE")]
	[Address(RVA = "0x15EB0D8", Offset = "0x15EB0D8", VA = "0x15EB0D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60059DF")]
	[Address(RVA = "0x15EB174", Offset = "0x15EB174", VA = "0x15EB174")]
	private double GetRemainSec()
	{
		return default(double);
	}
}
