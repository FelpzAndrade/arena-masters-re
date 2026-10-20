using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001073")]
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	[Token(Token = "0x40058C4")]
	[FieldOffset(Offset = "0x0")]
	private static T m_Instance;

	[Token(Token = "0x17000F54")]
	public static T instance
	{
		[Token(Token = "0x6007C27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F55")]
	public virtual bool WillDestroyOnLoad
	{
		[Token(Token = "0x6007C28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007C25")]
	protected MonoSingleton()
	{
	}

	[Token(Token = "0x6007C29")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007C2A")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6007C2B")]
	private void OnApplicationQuit()
	{
	}
}
