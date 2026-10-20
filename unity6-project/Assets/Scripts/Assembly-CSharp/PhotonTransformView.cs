using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EE")]
public class PhotonTransformView : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private PhotonTransformViewPositionModel m_PositionModel;

	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private PhotonTransformViewRotationModel m_RotationModel;

	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private PhotonTransformViewScaleModel m_ScaleModel;

	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x18")]
	private PhotonTransformViewPositionControl m_PositionControl;

	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x1C")]
	private PhotonTransformViewRotationControl m_RotationControl;

	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x20")]
	private PhotonTransformViewScaleControl m_ScaleControl;

	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x24")]
	private PhotonView m_PhotonView;

	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x28")]
	private XModulePhoton m_ModulePhoton;

	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_ReceivedNetworkUpdate;

	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_firstTake;

	[Token(Token = "0x60019C9")]
	[Address(RVA = "0x1B9FD10", Offset = "0x1B9FD10", VA = "0x1B9FD10")]
	public PhotonTransformView()
	{
	}

	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x1BA00C0", Offset = "0x1BA00C0", VA = "0x1BA00C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x1BA0344", Offset = "0x1BA0344", VA = "0x1BA0344")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x1BA0350", Offset = "0x1BA0350", VA = "0x1BA0350")]
	private void Update()
	{
	}

	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x1BA08E0", Offset = "0x1BA08E0", VA = "0x1BA08E0")]
	public void SetPosition(Vector3 position)
	{
	}

	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x1BA09C0", Offset = "0x1BA09C0", VA = "0x1BA09C0")]
	public void SetDirection(Quaternion dir)
	{
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x1BA04DC", Offset = "0x1BA04DC", VA = "0x1BA04DC")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x1BA0674", Offset = "0x1BA0674", VA = "0x1BA0674")]
	private void UpdateRotation()
	{
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x1BA0820", Offset = "0x1BA0820", VA = "0x1BA0820")]
	private void UpdateScale()
	{
	}

	[Token(Token = "0x60019D2")]
	[Address(RVA = "0x1BA10D0", Offset = "0x1BA10D0", VA = "0x1BA10D0")]
	public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
	{
	}

	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x1BA1114", Offset = "0x1BA1114", VA = "0x1BA1114", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x1BA16D8", Offset = "0x1BA16D8", VA = "0x1BA16D8")]
	private void DoDrawEstimatedPositionError()
	{
	}

	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x1BA1A98", Offset = "0x1BA1A98", VA = "0x1BA1A98")]
	internal void SetCharacterController(XModulePhoton modulePhoton)
	{
	}

	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x1BA1AA0", Offset = "0x1BA1AA0", VA = "0x1BA1AA0")]
	public void ClearOldNetworkPositions()
	{
	}

	[Token(Token = "0x60019D7")]
	[Address(RVA = "0x1BA1B60", Offset = "0x1BA1B60", VA = "0x1BA1B60")]
	public void SetExtrapolateOption(int option)
	{
	}
}
