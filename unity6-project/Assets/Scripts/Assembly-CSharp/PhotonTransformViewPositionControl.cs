using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EF")]
public class PhotonTransformViewPositionControl
{
	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x8")]
	private PhotonTransformViewPositionModel m_Model;

	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0xC")]
	private float m_CurrentSpeed;

	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x10")]
	private double m_LastSerializeTime;

	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_SynchronizedSpeed;

	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x24")]
	private float m_SynchronizedTurnSpeed;

	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_NetworkPosition;

	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x34")]
	private Queue<Vector3> m_OldNetworkPositions;

	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x38")]
	private bool m_UpdatedPositionAfterOnSerialize;

	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x1BA01F4", Offset = "0x1BA01F4", VA = "0x1BA01F4")]
	public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel model)
	{
	}

	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x1BA1B84", Offset = "0x1BA1B84", VA = "0x1BA1B84")]
	private Vector3 GetOldestStoredNetworkPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x1BA1100", Offset = "0x1BA1100", VA = "0x1BA1100")]
	public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
	{
	}

	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x1BA0A04", Offset = "0x1BA0A04", VA = "0x1BA0A04")]
	public Vector3 UpdatePosition(Vector3 currentPosition)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x1BA1A60", Offset = "0x1BA1A60", VA = "0x1BA1A60")]
	public Vector3 GetNetworkPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x1BA1C90", Offset = "0x1BA1C90", VA = "0x1BA1C90")]
	public Vector3 GetExtrapolatedPositionOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x1BA1358", Offset = "0x1BA1358", VA = "0x1BA1358")]
	public void OnPhotonSerializeView(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x1BA2024", Offset = "0x1BA2024", VA = "0x1BA2024")]
	private void SerializeData(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x1BA2178", Offset = "0x1BA2178", VA = "0x1BA2178")]
	private void DeserializeData(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x1BA0910", Offset = "0x1BA0910", VA = "0x1BA0910")]
	public void SetPosition(Vector3 currentPosition)
	{
	}

	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x1BA1AC8", Offset = "0x1BA1AC8", VA = "0x1BA1AC8")]
	public void ClearOldNetworkPositions()
	{
	}
}
