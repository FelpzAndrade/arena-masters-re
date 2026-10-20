using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200008C")]
public class ITweenCallBackReciever : MonoSingleton<ITweenCallBackReciever>
{
	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, ITweenDirectionElement> directions;

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xDCD2D0", Offset = "0xDCD2D0", VA = "0xDCD2D0")]
	public ITweenCallBackReciever()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xDCD3C0", Offset = "0xDCD3C0", VA = "0xDCD3C0")]
	public void Register(string name, ITweenDirectionElement element)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xDCD468", Offset = "0xDCD468", VA = "0xDCD468")]
	public void SetFinished(string name)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xDCD550", Offset = "0xDCD550", VA = "0xDCD550")]
	public void Remove(string name)
	{
	}
}
