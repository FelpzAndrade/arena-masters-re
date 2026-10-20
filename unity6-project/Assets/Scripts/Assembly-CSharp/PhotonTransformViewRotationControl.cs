using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F3")]
public class PhotonTransformViewRotationControl
{
	[Token(Token = "0x4000FB8")]
	[FieldOffset(Offset = "0x8")]
	private PhotonTransformViewRotationModel m_Model;

	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0xC")]
	private Quaternion m_NetworkRotation;

	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x1BA02D8", Offset = "0x1BA02D8", VA = "0x1BA02D8")]
	public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel model)
	{
	}

	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x1BA1A74", Offset = "0x1BA1A74", VA = "0x1BA1A74")]
	public Quaternion GetNetworkRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x1BA0E94", Offset = "0x1BA0E94", VA = "0x1BA0E94")]
	public Quaternion GetRotation(Quaternion currentRotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x1BA1474", Offset = "0x1BA1474", VA = "0x1BA1474")]
	public void OnPhotonSerializeView(Quaternion currentRotation, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x1BA09EC", Offset = "0x1BA09EC", VA = "0x1BA09EC")]
	public void SetRotation(Quaternion rotation)
	{
	}
}
