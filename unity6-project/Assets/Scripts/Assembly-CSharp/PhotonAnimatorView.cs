using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002E1")]
public class PhotonAnimatorView : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x20002E2")]
	public enum ParameterType
	{
		[Token(Token = "0x4000F74")]
		Float = 1,
		[Token(Token = "0x4000F75")]
		Int = 3,
		[Token(Token = "0x4000F76")]
		Bool = 4,
		[Token(Token = "0x4000F77")]
		Trigger = 9
	}

	[Token(Token = "0x20002E3")]
	public enum SynchronizeType
	{
		[Token(Token = "0x4000F79")]
		Disabled = 0,
		[Token(Token = "0x4000F7A")]
		Discrete = 1,
		[Token(Token = "0x4000F7B")]
		Continuous = 2
	}

	[Serializable]
	[Token(Token = "0x20002E4")]
	public class SynchronizedParameter
	{
		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x8")]
		public ParameterType Type;

		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0xC")]
		public SynchronizeType SynchronizeType;

		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x1B822F4", Offset = "0x1B822F4", VA = "0x1B822F4")]
		public SynchronizedParameter()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20002E5")]
	public class SynchronizedLayer
	{
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x8")]
		public SynchronizeType SynchronizeType;

		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0xC")]
		public int LayerIndex;

		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x1B820CC", Offset = "0x1B820CC", VA = "0x1B820CC")]
		public SynchronizedLayer()
		{
		}
	}

	[Token(Token = "0x20002E6")]
	private sealed class _003CDoesLayerSynchronizeTypeExist_003Ec__AnonStoreyE3
	{
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x8")]
		internal int layerIndex;

		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x1B81A58", Offset = "0x1B81A58", VA = "0x1B81A58")]
		public _003CDoesLayerSynchronizeTypeExist_003Ec__AnonStoreyE3()
		{
		}

		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x1B83A94", Offset = "0x1B83A94", VA = "0x1B83A94")]
		internal bool _003C_003Em__80(SynchronizedLayer item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002E7")]
	private sealed class _003CDoesParameterSynchronizeTypeExist_003Ec__AnonStoreyE4
	{
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x1B81BA0", Offset = "0x1B81BA0", VA = "0x1B81BA0")]
		public _003CDoesParameterSynchronizeTypeExist_003Ec__AnonStoreyE4()
		{
		}

		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x1B83AC8", Offset = "0x1B83AC8", VA = "0x1B83AC8")]
		internal bool _003C_003Em__81(SynchronizedParameter item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002E8")]
	private sealed class _003CGetLayerSynchronizeType_003Ec__AnonStoreyE5
	{
		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x8")]
		internal int layerIndex;

		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x1B81D30", Offset = "0x1B81D30", VA = "0x1B81D30")]
		public _003CGetLayerSynchronizeType_003Ec__AnonStoreyE5()
		{
		}

		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x1B83B94", Offset = "0x1B83B94", VA = "0x1B83B94")]
		internal bool _003C_003Em__82(SynchronizedLayer item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002E9")]
	private sealed class _003CGetParameterSynchronizeType_003Ec__AnonStoreyE6
	{
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x1B81EB0", Offset = "0x1B81EB0", VA = "0x1B81EB0")]
		public _003CGetParameterSynchronizeType_003Ec__AnonStoreyE6()
		{
		}

		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x1B83BC8", Offset = "0x1B83BC8", VA = "0x1B83BC8")]
		internal bool _003C_003Em__83(SynchronizedParameter item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002EA")]
	private sealed class _003CSetLayerSynchronized_003Ec__AnonStoreyE7
	{
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x8")]
		internal int layerIndex;

		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x1B820C4", Offset = "0x1B820C4", VA = "0x1B820C4")]
		public _003CSetLayerSynchronized_003Ec__AnonStoreyE7()
		{
		}

		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x1B83C94", Offset = "0x1B83C94", VA = "0x1B83C94")]
		internal bool _003C_003Em__84(SynchronizedLayer item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20002EB")]
	private sealed class _003CSetParameterSynchronized_003Ec__AnonStoreyE8
	{
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x1B822EC", Offset = "0x1B822EC", VA = "0x1B822EC")]
		public _003CSetParameterSynchronized_003Ec__AnonStoreyE8()
		{
		}

		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x1B83CC8", Offset = "0x1B83CC8", VA = "0x1B83CC8")]
		internal bool _003C_003Em__85(SynchronizedParameter item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000F68")]
	[FieldOffset(Offset = "0xC")]
	private Animator m_Animator;

	[Token(Token = "0x4000F69")]
	[FieldOffset(Offset = "0x10")]
	private PhotonStreamQueue m_StreamQueue;

	[Token(Token = "0x4000F6A")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[HideInInspector]
	private bool ShowLayerWeightsInspector;

	[Token(Token = "0x4000F6B")]
	[FieldOffset(Offset = "0x15")]
	[HideInInspector]
	[SerializeField]
	private bool ShowParameterInspector;

	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private List<SynchronizedParameter> m_SynchronizeParameters;

	[Token(Token = "0x4000F6D")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[SerializeField]
	private List<SynchronizedLayer> m_SynchronizeLayers;

	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_ReceiverPosition;

	[Token(Token = "0x4000F6F")]
	[FieldOffset(Offset = "0x2C")]
	private float m_LastDeserializeTime;

	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x30")]
	private bool m_WasSynchronizeTypeChanged;

	[Token(Token = "0x4000F71")]
	[FieldOffset(Offset = "0x34")]
	private PhotonView m_PhotonView;

	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x38")]
	private List<string> m_raisedDiscreteTriggersCache;

	[Token(Token = "0x60019A2")]
	[Address(RVA = "0x1B804B4", Offset = "0x1B804B4", VA = "0x1B804B4")]
	public PhotonAnimatorView()
	{
	}

	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x1B805D8", Offset = "0x1B805D8", VA = "0x1B805D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x1B80770", Offset = "0x1B80770", VA = "0x1B80770")]
	private void Update()
	{
	}

	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x1B813D8", Offset = "0x1B813D8", VA = "0x1B813D8")]
	public void CacheDiscreteTriggers()
	{
	}

	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x1B81918", Offset = "0x1B81918", VA = "0x1B81918")]
	public bool DoesLayerSynchronizeTypeExist(int layerIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x1B81A60", Offset = "0x1B81A60", VA = "0x1B81A60")]
	public bool DoesParameterSynchronizeTypeExist(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x1B81BA8", Offset = "0x1B81BA8", VA = "0x1B81BA8")]
	public List<SynchronizedLayer> GetSynchronizedLayers()
	{
		return null;
	}

	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x1B81BB0", Offset = "0x1B81BB0", VA = "0x1B81BB0")]
	public List<SynchronizedParameter> GetSynchronizedParameters()
	{
		return null;
	}

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x1B81BB8", Offset = "0x1B81BB8", VA = "0x1B81BB8")]
	public SynchronizeType GetLayerSynchronizeType(int layerIndex)
	{
		return default(SynchronizeType);
	}

	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x1B81D38", Offset = "0x1B81D38", VA = "0x1B81D38")]
	public SynchronizeType GetParameterSynchronizeType(string name)
	{
		return default(SynchronizeType);
	}

	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x1B81EB8", Offset = "0x1B81EB8", VA = "0x1B81EB8")]
	public void SetLayerSynchronized(int layerIndex, SynchronizeType synchronizeType)
	{
	}

	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x1B820D4", Offset = "0x1B820D4", VA = "0x1B820D4")]
	public void SetParameterSynchronized(string name, ParameterType type, SynchronizeType synchronizeType)
	{
	}

	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x1B80FE4", Offset = "0x1B80FE4", VA = "0x1B80FE4")]
	private void SerializeDataContinuously()
	{
	}

	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x1B81540", Offset = "0x1B81540", VA = "0x1B81540")]
	private void DeserializeDataContinuously()
	{
	}

	[Token(Token = "0x60019B0")]
	[Address(RVA = "0x1B824DC", Offset = "0x1B824DC", VA = "0x1B824DC")]
	private void SerializeDataDiscretly(PhotonStream stream)
	{
	}

	[Token(Token = "0x60019B1")]
	[Address(RVA = "0x1B829B4", Offset = "0x1B829B4", VA = "0x1B829B4")]
	private void DeserializeDataDiscretly(PhotonStream stream)
	{
	}

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x1B830A0", Offset = "0x1B830A0", VA = "0x1B830A0")]
	private void SerializeSynchronizationTypeState(PhotonStream stream)
	{
	}

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x1B8333C", Offset = "0x1B8333C", VA = "0x1B8333C")]
	private void DeserializeSynchronizationTypeState(PhotonStream stream)
	{
	}

	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x1B83574", Offset = "0x1B83574", VA = "0x1B83574", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
