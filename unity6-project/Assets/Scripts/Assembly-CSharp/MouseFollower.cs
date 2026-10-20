using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PigeonCoopToolkit.Effects.Trails;
using UnityEngine;

[Token(Token = "0x200034A")]
public class MouseFollower : MonoBehaviour
{
	[Token(Token = "0x400114A")]
	[FieldOffset(Offset = "0xC")]
	public List<TrailRenderer_Base> Trails;

	[Token(Token = "0x400114B")]
	[FieldOffset(Offset = "0x0")]
	private static Action<TrailRenderer_Base> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400114C")]
	[FieldOffset(Offset = "0x4")]
	private static Action<TrailRenderer_Base> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0x135C478", Offset = "0x135C478", VA = "0x135C478")]
	public MouseFollower()
	{
	}

	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x135C480", Offset = "0x135C480", VA = "0x135C480")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x135C484", Offset = "0x135C484", VA = "0x135C484")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x135C7DC", Offset = "0x135C7DC", VA = "0x135C7DC")]
	private static void _003CUpdate_003Em__87(TrailRenderer_Base a)
	{
	}

	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x135C800", Offset = "0x135C800", VA = "0x135C800")]
	private static void _003CUpdate_003Em__88(TrailRenderer_Base a)
	{
	}
}
