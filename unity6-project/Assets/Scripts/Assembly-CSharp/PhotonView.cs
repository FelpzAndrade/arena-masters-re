using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x20002D8")]
public class PhotonView : Photon.MonoBehaviour
{
	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x10")]
	public int ownerId;

	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x14")]
	public byte group;

	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0x15")]
	protected internal bool mixedModeIsReliable;

	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x16")]
	public bool OwnerShipWasTransfered;

	[Token(Token = "0x4000F17")]
	[FieldOffset(Offset = "0x18")]
	public int prefixBackup;

	[Token(Token = "0x4000F18")]
	[FieldOffset(Offset = "0x1C")]
	internal object[] instantiationDataField;

	[Token(Token = "0x4000F19")]
	[FieldOffset(Offset = "0x20")]
	protected internal object[] lastOnSerializeDataSent;

	[Token(Token = "0x4000F1A")]
	[FieldOffset(Offset = "0x24")]
	protected internal object[] lastOnSerializeDataReceived;

	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x28")]
	public ViewSynchronization synchronization;

	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0x2C")]
	public OnSerializeTransform onSerializeTransformOption;

	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x30")]
	public OnSerializeRigidBody onSerializeRigidBodyOption;

	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x34")]
	public OwnershipOption ownershipTransfer;

	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x38")]
	public List<Component> ObservedComponents;

	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<Component, MethodInfo> m_OnSerializeMethodInfos;

	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int viewIdField;

	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x44")]
	public int instantiationId;

	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x48")]
	public int currentMasterID;

	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x4C")]
	protected internal bool didAwake;

	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x4D")]
	[SerializeField]
	protected internal bool isRuntimeInstantiated;

	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x4E")]
	protected internal bool removedFromLocalViewList;

	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x50")]
	internal UnityEngine.MonoBehaviour[] RpcMonoBehaviours;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x54")]
	private MethodInfo OnSerializeMethodInfo;

	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x58")]
	private bool failedToFindOnSerialize;

	[Token(Token = "0x1700044B")]
	public int prefix
	{
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x1BA246C", Offset = "0x1BA246C", VA = "0x1BA246C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x1BA2590", Offset = "0x1BA2590", VA = "0x1BA2590")]
		set
		{
		}
	}

	[Token(Token = "0x1700044C")]
	public object[] instantiationData
	{
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x1BA2598", Offset = "0x1BA2598", VA = "0x1BA2598")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x1BA2680", Offset = "0x1BA2680", VA = "0x1BA2680")]
		set
		{
		}
	}

	[Token(Token = "0x1700044D")]
	public int viewID
	{
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x1BA2688", Offset = "0x1BA2688", VA = "0x1BA2688")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x1BA2690", Offset = "0x1BA2690", VA = "0x1BA2690")]
		set
		{
		}
	}

	[Token(Token = "0x1700044E")]
	public bool isSceneView
	{
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x1BA27EC", Offset = "0x1BA27EC", VA = "0x1BA27EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700044F")]
	public PhotonPlayer owner
	{
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x1BA28CC", Offset = "0x1BA28CC", VA = "0x1BA28CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000450")]
	public int OwnerActorNr
	{
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x1BA28D4", Offset = "0x1BA28D4", VA = "0x1BA28D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000451")]
	public bool isOwnerActive
	{
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x1BA28DC", Offset = "0x1BA28DC", VA = "0x1BA28DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000452")]
	public int CreatorActorNr
	{
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x1BA280C", Offset = "0x1BA280C", VA = "0x1BA280C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000453")]
	public bool isMine
	{
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x1B80940", Offset = "0x1B80940", VA = "0x1B80940")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001924")]
	[Address(RVA = "0x1BA2398", Offset = "0x1BA2398", VA = "0x1BA2398")]
	public PhotonView()
	{
	}

	[Token(Token = "0x6001931")]
	[Address(RVA = "0x1BA29E0", Offset = "0x1BA29E0", VA = "0x1BA29E0")]
	protected internal void Awake()
	{
	}

	[Token(Token = "0x6001932")]
	[Address(RVA = "0x1BA2B00", Offset = "0x1BA2B00", VA = "0x1BA2B00")]
	public void RequestOwnership()
	{
	}

	[Token(Token = "0x6001933")]
	[Address(RVA = "0x1BA2BD8", Offset = "0x1BA2BD8", VA = "0x1BA2BD8")]
	public void TransferOwnership(PhotonPlayer newOwner)
	{
	}

	[Token(Token = "0x6001934")]
	[Address(RVA = "0x1BA2C00", Offset = "0x1BA2C00", VA = "0x1BA2C00")]
	public void TransferOwnership(int newOwnerId)
	{
	}

	[Token(Token = "0x6001935")]
	[Address(RVA = "0x1BA2CE0", Offset = "0x1BA2CE0", VA = "0x1BA2CE0")]
	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	[Token(Token = "0x6001936")]
	[Address(RVA = "0x1BA2D50", Offset = "0x1BA2D50", VA = "0x1BA2D50")]
	protected internal void OnDestroy()
	{
	}

	[Token(Token = "0x6001937")]
	[Address(RVA = "0x1BA2FDC", Offset = "0x1BA2FDC", VA = "0x1BA2FDC")]
	public void SerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6001938")]
	[Address(RVA = "0x1BA38A4", Offset = "0x1BA38A4", VA = "0x1BA38A4")]
	public void DeserializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6001939")]
	[Address(RVA = "0x1BA39E8", Offset = "0x1BA39E8", VA = "0x1BA39E8")]
	protected internal void DeserializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600193A")]
	[Address(RVA = "0x1BA3120", Offset = "0x1BA3120", VA = "0x1BA3120")]
	protected internal void SerializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600193B")]
	[Address(RVA = "0x1BA4068", Offset = "0x1BA4068", VA = "0x1BA4068")]
	protected internal void ExecuteComponentOnSerialize(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600193C")]
	[Address(RVA = "0x1BA45A0", Offset = "0x1BA45A0", VA = "0x1BA45A0")]
	public void RefreshRpcMonoBehaviourCache()
	{
	}

	[Token(Token = "0x600193D")]
	[Address(RVA = "0x1BA4628", Offset = "0x1BA4628", VA = "0x1BA4628")]
	public void RPC(string methodName, PhotonTargets target, params object[] parameters)
	{
	}

	[Token(Token = "0x600193E")]
	[Address(RVA = "0x1BA46EC", Offset = "0x1BA46EC", VA = "0x1BA46EC")]
	public void RpcSecure(string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	[Token(Token = "0x600193F")]
	[Address(RVA = "0x1BA47B0", Offset = "0x1BA47B0", VA = "0x1BA47B0")]
	public void RPC(string methodName, PhotonPlayer targetPlayer, params object[] parameters)
	{
	}

	[Token(Token = "0x6001940")]
	[Address(RVA = "0x1BA4874", Offset = "0x1BA4874", VA = "0x1BA4874")]
	public void RpcSecure(string methodName, PhotonPlayer targetPlayer, bool encrypt, params object[] parameters)
	{
	}

	[Token(Token = "0x6001941")]
	[Address(RVA = "0x1B803A0", Offset = "0x1B803A0", VA = "0x1B803A0")]
	public static PhotonView Get(Component component)
	{
		return null;
	}

	[Token(Token = "0x6001942")]
	[Address(RVA = "0x1BA4938", Offset = "0x1BA4938", VA = "0x1BA4938")]
	public static PhotonView Get(GameObject gameObj)
	{
		return null;
	}

	[Token(Token = "0x6001943")]
	[Address(RVA = "0x1BA49D0", Offset = "0x1BA49D0", VA = "0x1BA49D0")]
	public static PhotonView Find(int viewID)
	{
		return null;
	}

	[Token(Token = "0x6001944")]
	[Address(RVA = "0x1BA4AA4", Offset = "0x1BA4AA4", VA = "0x1BA4AA4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
