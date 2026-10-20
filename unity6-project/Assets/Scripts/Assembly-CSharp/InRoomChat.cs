using System.Collections.Generic;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x20002FF")]
public class InRoomChat : Photon.MonoBehaviour
{
	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x10")]
	public Rect GuiRect;

	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x20")]
	public bool IsVisible;

	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x21")]
	public bool AlignBottom;

	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x24")]
	public List<string> messages;

	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x28")]
	private string inputLine;

	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 scrollPos;

	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ChatRPC;

	[Token(Token = "0x6001A12")]
	[Address(RVA = "0xD8B888", Offset = "0xD8B888", VA = "0xD8B888")]
	public InRoomChat()
	{
	}

	[Token(Token = "0x6001A14")]
	[Address(RVA = "0xD8BA80", Offset = "0xD8BA80", VA = "0xD8BA80")]
	public void Start()
	{
	}

	[Token(Token = "0x6001A15")]
	[Address(RVA = "0xD8BADC", Offset = "0xD8BADC", VA = "0xD8BADC")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6001A16")]
	[Address(RVA = "0xD8C2DC", Offset = "0xD8C2DC", VA = "0xD8C2DC")]
	[PunRPC]
	public void Chat(string newLine, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6001A17")]
	[Address(RVA = "0xD8C518", Offset = "0xD8C518", VA = "0xD8C518")]
	public void AddLine(string newLine)
	{
	}
}
