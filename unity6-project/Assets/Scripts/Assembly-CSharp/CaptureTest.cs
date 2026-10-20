using Il2CppDummyDll;
using SharpRaven;
using UnityEngine;

[Token(Token = "0x2000BD0")]
public class CaptureTest : MonoBehaviour
{
	[Token(Token = "0x4003BFB")]
	private const string dsnUrl = "http://ef96c1bff6194467bfd566bef1506d42:012cd70cf2f7447a973ea018219a6850@ser4kakao.gameus.co.kr:9000/2";

	[Token(Token = "0x4003BFC")]
	[FieldOffset(Offset = "0x0")]
	private static RavenClient ravenClient;

	[Token(Token = "0x6005556")]
	[Address(RVA = "0x20C34AC", Offset = "0x20C34AC", VA = "0x20C34AC")]
	public CaptureTest()
	{
	}

	[Token(Token = "0x6005557")]
	[Address(RVA = "0x20C34B4", Offset = "0x20C34B4", VA = "0x20C34B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6005558")]
	[Address(RVA = "0x20C34CC", Offset = "0x20C34CC", VA = "0x20C34CC")]
	private static void setup()
	{
	}

	[Token(Token = "0x6005559")]
	[Address(RVA = "0x20C39A4", Offset = "0x20C39A4", VA = "0x20C39A4")]
	private static void testWithoutStacktrace()
	{
	}

	[Token(Token = "0x600555A")]
	[Address(RVA = "0x20C38E8", Offset = "0x20C38E8", VA = "0x20C38E8")]
	private static void testWithStacktrace()
	{
	}

	[Token(Token = "0x600555B")]
	[Address(RVA = "0x20C3B6C", Offset = "0x20C3B6C", VA = "0x20C3B6C")]
	private static void PerformDivideByZero()
	{
	}
}
