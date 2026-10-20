using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C9")]
public class PhotonStream
{
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x8")]
	private bool write;

	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0xC")]
	private Queue<object> writeData;

	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x10")]
	private object[] readData;

	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x14")]
	internal byte currentItem;

	[Token(Token = "0x17000401")]
	public bool isWriting
	{
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x1B83700", Offset = "0x1B83700", VA = "0x1B83700")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000402")]
	public bool isReading
	{
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x1B9DB2C", Offset = "0x1B9DB2C", VA = "0x1B9DB2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000403")]
	public int Count
	{
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x1B9DB40", Offset = "0x1B9DB40", VA = "0x1B9DB40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600180D")]
	[Address(RVA = "0x1B9D9B8", Offset = "0x1B9D9B8", VA = "0x1B9D9B8")]
	public PhotonStream(bool write, object[] incomingData)
	{
	}

	[Token(Token = "0x600180E")]
	[Address(RVA = "0x1B9DA80", Offset = "0x1B9DA80", VA = "0x1B9DA80")]
	public void SetReadStream(object[] incomingData, byte pos = 0)
	{
	}

	[Token(Token = "0x600180F")]
	[Address(RVA = "0x1B9DA94", Offset = "0x1B9DA94", VA = "0x1B9DA94")]
	internal void ResetWriteStream()
	{
	}

	[Token(Token = "0x6001813")]
	[Address(RVA = "0x1B82E70", Offset = "0x1B82E70", VA = "0x1B82E70")]
	public object ReceiveNext()
	{
		return null;
	}

	[Token(Token = "0x6001814")]
	[Address(RVA = "0x1B82F90", Offset = "0x1B82F90", VA = "0x1B82F90")]
	public object PeekNext()
	{
		return null;
	}

	[Token(Token = "0x6001815")]
	[Address(RVA = "0x1B828A4", Offset = "0x1B828A4", VA = "0x1B828A4")]
	public void SendNext(object obj)
	{
	}

	[Token(Token = "0x6001816")]
	[Address(RVA = "0x1B9DBF4", Offset = "0x1B9DBF4", VA = "0x1B9DBF4")]
	public object[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6001817")]
	[Address(RVA = "0x1B9DCA0", Offset = "0x1B9DCA0", VA = "0x1B9DCA0")]
	public void Serialize(ref bool myBool)
	{
	}

	[Token(Token = "0x6001818")]
	[Address(RVA = "0x1B9DDF4", Offset = "0x1B9DDF4", VA = "0x1B9DDF4")]
	public void Serialize(ref int myInt)
	{
	}

	[Token(Token = "0x6001819")]
	[Address(RVA = "0x1B9DF40", Offset = "0x1B9DF40", VA = "0x1B9DF40")]
	public void Serialize(ref string value)
	{
	}

	[Token(Token = "0x600181A")]
	[Address(RVA = "0x1B9E23C", Offset = "0x1B9E23C", VA = "0x1B9E23C")]
	public void Serialize(ref char value)
	{
	}

	[Token(Token = "0x600181B")]
	[Address(RVA = "0x1B9E388", Offset = "0x1B9E388", VA = "0x1B9E388")]
	public void Serialize(ref short value)
	{
	}

	[Token(Token = "0x600181C")]
	[Address(RVA = "0x1B9E4D4", Offset = "0x1B9E4D4", VA = "0x1B9E4D4")]
	public void Serialize(ref float obj)
	{
	}

	[Token(Token = "0x600181D")]
	[Address(RVA = "0x1B9E620", Offset = "0x1B9E620", VA = "0x1B9E620")]
	public void Serialize(ref PhotonPlayer obj)
	{
	}

	[Token(Token = "0x600181E")]
	[Address(RVA = "0x1B9E744", Offset = "0x1B9E744", VA = "0x1B9E744")]
	public void Serialize(ref Vector3 obj)
	{
	}

	[Token(Token = "0x600181F")]
	[Address(RVA = "0x1B9E8A0", Offset = "0x1B9E8A0", VA = "0x1B9E8A0")]
	public void Serialize(ref Vector2 obj)
	{
	}

	[Token(Token = "0x6001820")]
	[Address(RVA = "0x1B9E9F4", Offset = "0x1B9E9F4", VA = "0x1B9E9F4")]
	public void Serialize(ref Quaternion obj)
	{
	}
}
