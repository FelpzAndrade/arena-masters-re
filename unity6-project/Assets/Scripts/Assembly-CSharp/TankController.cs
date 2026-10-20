using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PigeonCoopToolkit.Effects.Trails;
using UnityEngine;

[Token(Token = "0x200034E")]
public class TankController : MonoBehaviour
{
	[Token(Token = "0x4001157")]
	[FieldOffset(Offset = "0xC")]
	public float TrailMaterialOffsetSpeed;

	[Token(Token = "0x4001158")]
	[FieldOffset(Offset = "0x10")]
	public float MoveSpeed;

	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x14")]
	public float MoveFriction;

	[Token(Token = "0x400115A")]
	[FieldOffset(Offset = "0x18")]
	public float MoveAcceleration;

	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x1C")]
	public float RotateSpeed;

	[Token(Token = "0x400115C")]
	[FieldOffset(Offset = "0x20")]
	public float RotateFriction;

	[Token(Token = "0x400115D")]
	[FieldOffset(Offset = "0x24")]
	public float RotateAcceleration;

	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x28")]
	public Material TrailMaterial;

	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x2C")]
	public Animator Animator;

	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x30")]
	public List<Trail> TankTrackTrails;

	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x34")]
	public TankWeaponController WeaponController;

	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x38")]
	private float _moveSpeed;

	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x3C")]
	private float _rotateSpeed;

	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x40")]
	public bool InControl;

	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x0")]
	private static Action<Trail> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x4")]
	private static Action<Trail> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x1D49F3C", Offset = "0x1D49F3C", VA = "0x1D49F3C")]
	public TankController()
	{
	}

	[Token(Token = "0x6001BDC")]
	[Address(RVA = "0x1D49F44", Offset = "0x1D49F44", VA = "0x1D49F44")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x1D4A810", Offset = "0x1D4A810", VA = "0x1D4A810")]
	private static void _003CUpdate_003Em__89(Trail trail)
	{
	}

	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x1D4A834", Offset = "0x1D4A834", VA = "0x1D4A834")]
	private static void _003CUpdate_003Em__8A(Trail trail)
	{
	}
}
