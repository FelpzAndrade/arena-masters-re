using System;
using Il2CppDummyDll;
using UnityEngine;
using XLevel;

[Serializable]
[Token(Token = "0x2000D82")]
public class XUINavigation
{
	[Token(Token = "0x2000D83")]
	public enum NaviState
	{
		[Token(Token = "0x4004612")]
		Off = 0,
		[Token(Token = "0x4004613")]
		WayPoint = 1,
		[Token(Token = "0x4004614")]
		Monster = 2
	}

	[Token(Token = "0x4004608")]
	[FieldOffset(Offset = "0x8")]
	private GameObject m_goMyTeamIndicator;

	[Token(Token = "0x4004609")]
	[FieldOffset(Offset = "0xC")]
	private XUINavigationArrow m_positionArrow;

	[Token(Token = "0x400460A")]
	[FieldOffset(Offset = "0x10")]
	private Transform m_naviTransform;

	[Token(Token = "0x400460B")]
	[FieldOffset(Offset = "0x14")]
	private XWayPointCalculator m_wayPointCalculator;

	[Token(Token = "0x400460C")]
	[FieldOffset(Offset = "0x18")]
	private XVector[] m_wayPoints;

	[Token(Token = "0x400460D")]
	[FieldOffset(Offset = "0x1C")]
	public NaviState State;

	[Token(Token = "0x400460E")]
	[FieldOffset(Offset = "0x20")]
	private GameObject arroGo;

	[Token(Token = "0x400460F")]
	[FieldOffset(Offset = "0x24")]
	private bool m_enableArrow;

	[Token(Token = "0x4004610")]
	[FieldOffset(Offset = "0x28")]
	private float m_wayPointArrowDelayAccum;

	[Token(Token = "0x17000D39")]
	private bool enableArrow
	{
		[Token(Token = "0x600633C")]
		[Address(RVA = "0x10D56A0", Offset = "0x10D56A0", VA = "0x10D56A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600633D")]
		[Address(RVA = "0x10D56A8", Offset = "0x10D56A8", VA = "0x10D56A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3A")]
	public XVector[] WayPoints
	{
		[Token(Token = "0x6006340")]
		[Address(RVA = "0x10D5AA0", Offset = "0x10D5AA0", VA = "0x10D5AA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600633B")]
	[Address(RVA = "0x10D5698", Offset = "0x10D5698", VA = "0x10D5698")]
	public XUINavigation()
	{
	}

	[Token(Token = "0x600633E")]
	[Address(RVA = "0x10D56EC", Offset = "0x10D56EC", VA = "0x10D56EC")]
	public void Enable(bool b)
	{
	}

	[Token(Token = "0x600633F")]
	[Address(RVA = "0x10D56F4", Offset = "0x10D56F4", VA = "0x10D56F4")]
	public void Init(XVector[] wayPoints)
	{
	}

	[Token(Token = "0x6006341")]
	[Address(RVA = "0x10D5AA8", Offset = "0x10D5AA8", VA = "0x10D5AA8")]
	public void Update(float dt)
	{
	}

	[Token(Token = "0x6006342")]
	[Address(RVA = "0x10D6158", Offset = "0x10D6158", VA = "0x10D6158")]
	private void SetPosition(NaviState state, Vector3 pos, float dt)
	{
	}

	[Token(Token = "0x6006343")]
	[Address(RVA = "0x10D6278", Offset = "0x10D6278", VA = "0x10D6278")]
	private void SetNaviTransform(Vector3 pos)
	{
	}

	[Token(Token = "0x6006344")]
	[Address(RVA = "0x10D60A8", Offset = "0x10D60A8", VA = "0x10D60A8")]
	private bool IsInCameraBounds(Vector3 pos, float offset = 0f)
	{
		return default(bool);
	}
}
