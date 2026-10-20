using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200106C")]
public class ActionManager
{
	[Token(Token = "0x40058B8")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly ActionManager Instance;

	[Token(Token = "0x40058B9")]
	[FieldOffset(Offset = "0x8")]
	private Queue<Action> Actions;

	[Token(Token = "0x6007C0B")]
	[Address(RVA = "0x20B3FFC", Offset = "0x20B3FFC", VA = "0x20B3FFC")]
	public ActionManager()
	{
	}

	[Token(Token = "0x6007C0D")]
	[Address(RVA = "0x20B4130", Offset = "0x20B4130", VA = "0x20B4130")]
	public void Add(Action action)
	{
	}

	[Token(Token = "0x6007C0E")]
	[Address(RVA = "0x20B4230", Offset = "0x20B4230", VA = "0x20B4230")]
	public void Update()
	{
	}
}
