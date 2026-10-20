using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000303")]
public class InputToEvent : MonoBehaviour
{
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0xC")]
	private GameObject lastGo;

	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 inputHitPos;

	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x10")]
	public bool DetectPointedAtGameObject;

	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x14")]
	private Vector2 pressedPosition;

	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 currentPos;

	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x24")]
	public bool Dragging;

	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_Camera;

	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0xC")]
	private static GameObject goPointedAt__BackingField;

	[Token(Token = "0x17000484")]
	public static GameObject goPointedAt
	{
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0xD8AC7C", Offset = "0xD8AC7C", VA = "0xD8AC7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0xD8ACFC", Offset = "0xD8ACFC", VA = "0xD8ACFC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000485")]
	public Vector2 DragVector
	{
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0xD8AD80", Offset = "0xD8AD80", VA = "0xD8AD80")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0xD8AC28", Offset = "0xD8AC28", VA = "0xD8AC28")]
	public InputToEvent()
	{
	}

	[Token(Token = "0x6001A31")]
	[Address(RVA = "0xD8ADF8", Offset = "0xD8ADF8", VA = "0xD8ADF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A32")]
	[Address(RVA = "0xD8AE80", Offset = "0xD8AE80", VA = "0xD8AE80")]
	private void Update()
	{
	}

	[Token(Token = "0x6001A33")]
	[Address(RVA = "0xD8B598", Offset = "0xD8B598", VA = "0xD8B598")]
	private void Press(Vector2 screenPos)
	{
	}

	[Token(Token = "0x6001A34")]
	[Address(RVA = "0xD8B6BC", Offset = "0xD8B6BC", VA = "0xD8B6BC")]
	private void Release(Vector2 screenPos)
	{
	}

	[Token(Token = "0x6001A35")]
	[Address(RVA = "0xD8B414", Offset = "0xD8B414", VA = "0xD8B414")]
	private GameObject RaycastObject(Vector2 screenPos)
	{
		return null;
	}
}
