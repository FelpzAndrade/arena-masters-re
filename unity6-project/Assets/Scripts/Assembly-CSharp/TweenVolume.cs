using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000250")]
public class TweenVolume : UITweener
{
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x50")]
	public float from;

	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x54")]
	public float to;

	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x58")]
	private AudioSource mSource;

	[Token(Token = "0x1700030D")]
	public AudioSource audioSource
	{
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x1D60324", Offset = "0x1D60324", VA = "0x1D60324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030E")]
	public float volume
	{
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x1D60524", Offset = "0x1D60524", VA = "0x1D60524")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x1D60610", Offset = "0x1D60610", VA = "0x1D60610")]
		set
		{
		}
	}

	[Token(Token = "0x1700030F")]
	public float value
	{
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x1D60528", Offset = "0x1D60528", VA = "0x1D60528")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x1D60614", Offset = "0x1D60614", VA = "0x1D60614")]
		set
		{
		}
	}

	[Token(Token = "0x6001402")]
	[Address(RVA = "0x1D60310", Offset = "0x1D60310", VA = "0x1D60310")]
	public TweenVolume()
	{
	}

	[Token(Token = "0x6001408")]
	[Address(RVA = "0x1D606FC", Offset = "0x1D606FC", VA = "0x1D606FC", Slot = "5")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6001409")]
	[Address(RVA = "0x1D60780", Offset = "0x1D60780", VA = "0x1D60780")]
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	[Token(Token = "0x600140A")]
	[Address(RVA = "0x1D60888", Offset = "0x1D60888", VA = "0x1D60888", Slot = "6")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x600140B")]
	[Address(RVA = "0x1D608A0", Offset = "0x1D608A0", VA = "0x1D608A0", Slot = "7")]
	public override void SetEndToCurrentValue()
	{
	}
}
