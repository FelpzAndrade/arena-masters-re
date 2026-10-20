using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F6")]
public class PhotonTransformViewScaleControl
{
	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0x8")]
	private PhotonTransformViewScaleModel m_Model;

	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 m_NetworkScale;

	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x1BA02F8", Offset = "0x1BA02F8", VA = "0x1BA02F8")]
	public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel model)
	{
	}

	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x1BA1A84", Offset = "0x1BA1A84", VA = "0x1BA1A84")]
	public Vector3 GetNetworkScale()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x1BA0FBC", Offset = "0x1BA0FBC", VA = "0x1BA0FBC")]
	public Vector3 GetScale(Vector3 currentScale)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x1BA15A8", Offset = "0x1BA15A8", VA = "0x1BA15A8")]
	public void OnPhotonSerializeView(Vector3 currentScale, PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
