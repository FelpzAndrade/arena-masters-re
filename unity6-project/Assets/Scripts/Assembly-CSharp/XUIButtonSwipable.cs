using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DE")]
public class XUIButtonSwipable : UIButton
{
	[Token(Token = "0x40020B9")]
	[FieldOffset(Offset = "0xA4")]
	public List<EventDelegate> onSwipeLeft;

	[Token(Token = "0x40020BA")]
	[FieldOffset(Offset = "0xA8")]
	public List<EventDelegate> onSwipeRight;

	[Token(Token = "0x40020BB")]
	[FieldOffset(Offset = "0xAC")]
	public float SwipeSpeedThreshold;

	[Token(Token = "0x40020BC")]
	[FieldOffset(Offset = "0xB0")]
	public float SwipeDistanceThreshold;

	[Token(Token = "0x40020BD")]
	[FieldOffset(Offset = "0xB4")]
	private float accumuatedDeltaX;

	[Token(Token = "0x40020BE")]
	[FieldOffset(Offset = "0xB8")]
	private float dragStartTime;

	[Token(Token = "0x6003981")]
	[Address(RVA = "0x1A2F8C4", Offset = "0x1A2F8C4", VA = "0x1A2F8C4")]
	public XUIButtonSwipable()
	{
	}

	[Token(Token = "0x6003982")]
	[Address(RVA = "0x1A2F988", Offset = "0x1A2F988", VA = "0x1A2F988")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6003983")]
	[Address(RVA = "0x1A2F99C", Offset = "0x1A2F99C", VA = "0x1A2F99C")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x6003984")]
	[Address(RVA = "0x1A2F9BC", Offset = "0x1A2F9BC", VA = "0x1A2F9BC")]
	private void OnDragEnd()
	{
	}
}
