using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000489")]
public class XModuleSensor : MonoBehaviour
{
	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0xC")]
	public string strSoundKeyName;

	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0x10")]
	public XMapSensorType m_Type;

	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x14")]
	public int BuffID;

	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x18")]
	public int LostBuffID_OnExit;

	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x1C")]
	public int PortalExitBuffID;

	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] PortalExitPoints;

	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x24")]
	public string strEffectPath;

	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0x28")]
	public Transform effectTransformOffset;

	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0x2C")]
	private float m_durationTime;

	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0x30")]
	private float m_elapsedTime;

	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isPlaying;

	[Token(Token = "0x60026C9")]
	[Address(RVA = "0xB8E094", Offset = "0xB8E094", VA = "0xB8E094")]
	public XModuleSensor()
	{
	}

	[Token(Token = "0x60026CA")]
	[Address(RVA = "0xB8E180", Offset = "0xB8E180", VA = "0xB8E180")]
	public bool IsHaveEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60026CB")]
	[Address(RVA = "0xB8E230", Offset = "0xB8E230", VA = "0xB8E230")]
	public bool IsHaveSound()
	{
		return default(bool);
	}

	[Token(Token = "0x60026CC")]
	[Address(RVA = "0xB54D7C", Offset = "0xB54D7C", VA = "0xB54D7C")]
	public void PlaySound()
	{
	}

	[Token(Token = "0x60026CD")]
	[Address(RVA = "0xB54F6C", Offset = "0xB54F6C", VA = "0xB54F6C")]
	public void PlayEffectAndSound()
	{
	}

	[Token(Token = "0x60026CE")]
	[Address(RVA = "0xB8E2E0", Offset = "0xB8E2E0", VA = "0xB8E2E0")]
	private void Update()
	{
	}
}
