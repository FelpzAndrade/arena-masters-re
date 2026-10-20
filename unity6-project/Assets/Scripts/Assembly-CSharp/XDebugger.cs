using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200069B")]
public class XDebugger : MonoBehaviour
{
	[Token(Token = "0x400202D")]
	[FieldOffset(Offset = "0xC")]
	public XSector m_CurrentSector;

	[Token(Token = "0x400202E")]
	[FieldOffset(Offset = "0x0")]
	public static List<string> mDebugLogList;

	[Token(Token = "0x400202F")]
	[FieldOffset(Offset = "0x4")]
	private static XDebugger mInstance;

	[Token(Token = "0x1700080E")]
	public static XDebugger Instance
	{
		[Token(Token = "0x6003769")]
		[Address(RVA = "0x19A80AC", Offset = "0x19A80AC", VA = "0x19A80AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003765")]
	[Address(RVA = "0x19A7CB0", Offset = "0x19A7CB0", VA = "0x19A7CB0")]
	public XDebugger()
	{
	}

	[Token(Token = "0x6003767")]
	[Address(RVA = "0x19A7D78", Offset = "0x19A7D78", VA = "0x19A7D78")]
	private void Start()
	{
	}

	[Token(Token = "0x6003768")]
	[Address(RVA = "0x19A7ECC", Offset = "0x19A7ECC", VA = "0x19A7ECC")]
	public static void Log(string text)
	{
	}
}
