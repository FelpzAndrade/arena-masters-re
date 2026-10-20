using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200061A")]
public class XGameFlowBehaviour : MonoBehaviour
{
	[Token(Token = "0x4001D36")]
	[FieldOffset(Offset = "0xC")]
	public GameFlowTypes type;

	[Token(Token = "0x4001D37")]
	[FieldOffset(Offset = "0x0")]
	private static bool pause_status;

	[Token(Token = "0x4001D38")]
	[FieldOffset(Offset = "0x10")]
	private bool mainCamOn;

	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x14")]
	private int cullingMask;

	[Token(Token = "0x600348F")]
	[Address(RVA = "0x13E9990", Offset = "0x13E9990", VA = "0x13E9990")]
	public XGameFlowBehaviour()
	{
	}

	[Token(Token = "0x6003491")]
	[Address(RVA = "0x13E999C", Offset = "0x13E999C", VA = "0x13E999C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003492")]
	[Address(RVA = "0x13E9AC8", Offset = "0x13E9AC8", VA = "0x13E9AC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003493")]
	[Address(RVA = "0x13E9CF4", Offset = "0x13E9CF4", VA = "0x13E9CF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003494")]
	[Address(RVA = "0x13E9E18", Offset = "0x13E9E18", VA = "0x13E9E18")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003495")]
	[Address(RVA = "0x13E9ECC", Offset = "0x13E9ECC", VA = "0x13E9ECC")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6003496")]
	[Address(RVA = "0x13E9F74", Offset = "0x13E9F74", VA = "0x13E9F74")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x6003497")]
	[Address(RVA = "0x13EA064", Offset = "0x13EA064", VA = "0x13EA064")]
	private void ToggleGameCamera()
	{
	}

	[Token(Token = "0x6003498")]
	[Address(RVA = "0x13EA0F0", Offset = "0x13EA0F0", VA = "0x13EA0F0")]
	private void DebugInputProcess()
	{
	}
}
