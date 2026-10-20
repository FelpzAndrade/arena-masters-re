using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CAE")]
public interface IBase
{
	[Token(Token = "0x17000CCC")]
	Vector2 Size
	{
		[Token(Token = "0x6005B84")]
		get;
	}

	[Token(Token = "0x6005B85")]
	void Show();

	[Token(Token = "0x6005B86")]
	bool IsShow();

	[Token(Token = "0x6005B87")]
	void Hide();

	[Token(Token = "0x6005B88")]
	void Refresh([Optional] UIEvent type, [Optional] object data);
}
