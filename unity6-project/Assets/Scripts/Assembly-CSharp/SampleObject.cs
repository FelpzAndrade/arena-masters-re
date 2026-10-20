using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000097")]
public class SampleObject
{
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x8")]
	private string StringProperty__BackingField;

	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0xC")]
	private float FloatProperty__BackingField;

	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x10")]
	private Guid GuidProperty__BackingField;

	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 VectorProperty__BackingField;

	[Token(Token = "0x17000099")]
	public string StringProperty
	{
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x20EF268", Offset = "0x20EF268", VA = "0x20EF268")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x20EF270", Offset = "0x20EF270", VA = "0x20EF270")]
		set
		{
		}
	}

	[Token(Token = "0x1700009A")]
	public float FloatProperty
	{
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x20EF278", Offset = "0x20EF278", VA = "0x20EF278")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x20EF280", Offset = "0x20EF280", VA = "0x20EF280")]
		set
		{
		}
	}

	[Token(Token = "0x1700009B")]
	public Guid GuidProperty
	{
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x20EF288", Offset = "0x20EF288", VA = "0x20EF288")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x20EF298", Offset = "0x20EF298", VA = "0x20EF298")]
		set
		{
		}
	}

	[Token(Token = "0x1700009C")]
	public Vector3 VectorProperty
	{
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x20EF2B0", Offset = "0x20EF2B0", VA = "0x20EF2B0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x20EF2C4", Offset = "0x20EF2C4", VA = "0x20EF2C4")]
		set
		{
		}
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x20EF260", Offset = "0x20EF260", VA = "0x20EF260")]
	public SampleObject()
	{
	}
}
