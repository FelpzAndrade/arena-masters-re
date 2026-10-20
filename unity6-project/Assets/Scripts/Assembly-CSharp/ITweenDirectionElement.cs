using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE0")]
public class ITweenDirectionElement : UIDirectionElement
{
	[Token(Token = "0x400419B")]
	[FieldOffset(Offset = "0x0")]
	private static string namePrefix;

	[Token(Token = "0x400419C")]
	[FieldOffset(Offset = "0x4")]
	private static int increment;

	[Token(Token = "0x400419D")]
	[FieldOffset(Offset = "0x8")]
	private Action<GameObject, Hashtable> tween;

	[Token(Token = "0x400419E")]
	[FieldOffset(Offset = "0xC")]
	private GameObject go;

	[Token(Token = "0x400419F")]
	[FieldOffset(Offset = "0x10")]
	private Hashtable args;

	[Token(Token = "0x40041A0")]
	[FieldOffset(Offset = "0x14")]
	private bool isFinished;

	[Token(Token = "0x40041A1")]
	[FieldOffset(Offset = "0x18")]
	private string name;

	[Token(Token = "0x6005CF8")]
	[Address(RVA = "0xDCD628", Offset = "0xDCD628", VA = "0xDCD628")]
	public ITweenDirectionElement(Action<GameObject, Hashtable> tween, GameObject go, Hashtable args)
	{
	}

	[Token(Token = "0x6005CFA")]
	[Address(RVA = "0xDCD544", Offset = "0xDCD544", VA = "0xDCD544")]
	public void SetFinished()
	{
	}

	[Token(Token = "0x6005CFB")]
	[Address(RVA = "0xDCDA18", Offset = "0xDCDA18", VA = "0xDCDA18", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x6005CFC")]
	[Address(RVA = "0xDCDAB8", Offset = "0xDCDAB8", VA = "0xDCDAB8", Slot = "7")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005CFD")]
	[Address(RVA = "0xDCDC00", Offset = "0xDCDC00", VA = "0xDCDC00", Slot = "5")]
	public void Update()
	{
	}

	[Token(Token = "0x6005CFE")]
	[Address(RVA = "0xDCDC04", Offset = "0xDCDC04", VA = "0xDCDC04", Slot = "6")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
