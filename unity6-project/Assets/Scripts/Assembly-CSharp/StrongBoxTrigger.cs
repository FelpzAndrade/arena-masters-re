using System.Collections.Generic;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000541")]
public class StrongBoxTrigger : Photon.MonoBehaviour
{
	[Token(Token = "0x4001A43")]
	[FieldOffset(Offset = "0x0")]
	public static SortedDictionary<int, StrongBoxTrigger> StrongBoxes;

	[Token(Token = "0x4001A44")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4001A45")]
	[FieldOffset(Offset = "0x14")]
	public float triggingTime;

	[Token(Token = "0x4001A46")]
	[FieldOffset(Offset = "0x18")]
	public float accumulated;

	[Token(Token = "0x4001A47")]
	[FieldOffset(Offset = "0x1C")]
	public Collider bound;

	[Token(Token = "0x4001A48")]
	[FieldOffset(Offset = "0x20")]
	private XModuleEntity _box;

	[Token(Token = "0x4001A49")]
	[FieldOffset(Offset = "0x24")]
	private HashSet<XPlayer> police;

	[Token(Token = "0x4001A4A")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<XPlayer> thief;

	[Token(Token = "0x4001A4B")]
	[FieldOffset(Offset = "0x2C")]
	public bool allyInteracting;

	[Token(Token = "0x4001A4C")]
	[FieldOffset(Offset = "0x2D")]
	public bool localInteracting;

	[Token(Token = "0x4001A4D")]
	[FieldOffset(Offset = "0x2E")]
	private bool rpcSended;

	[Token(Token = "0x4001A4E")]
	[FieldOffset(Offset = "0x30")]
	private UIProgressBar _prb;

	[Token(Token = "0x4001A4F")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 progressBaroffset;

	[Token(Token = "0x4001A50")]
	[FieldOffset(Offset = "0x40")]
	private IStrongBoxEventReciver reciever;

	[Token(Token = "0x170006FE")]
	public XModuleEntity box
	{
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x1D45708", Offset = "0x1D45708", VA = "0x1D45708")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FF")]
	public float Percent
	{
		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x1D45A48", Offset = "0x1D45A48", VA = "0x1D45A48")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000700")]
	private UIProgressBar prb
	{
		[Token(Token = "0x6002CE0")]
		[Address(RVA = "0x1D460E4", Offset = "0x1D460E4", VA = "0x1D460E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002CCC")]
	[Address(RVA = "0x1D45580", Offset = "0x1D45580", VA = "0x1D45580")]
	public StrongBoxTrigger()
	{
	}

	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x1D45A5C", Offset = "0x1D45A5C", VA = "0x1D45A5C")]
	public void OnPhotonInstantiate(PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6002CD1")]
	[Address(RVA = "0x1D45B24", Offset = "0x1D45B24", VA = "0x1D45B24")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002CD2")]
	[Address(RVA = "0x1D45CBC", Offset = "0x1D45CBC", VA = "0x1D45CBC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002CD3")]
	[Address(RVA = "0x1D4648C", Offset = "0x1D4648C", VA = "0x1D4648C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x1D46868", Offset = "0x1D46868", VA = "0x1D46868")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
	{
	}

	[Token(Token = "0x6002CD5")]
	[Address(RVA = "0x1D463DC", Offset = "0x1D463DC", VA = "0x1D463DC")]
	private void UpdateAnimation()
	{
	}

	[Token(Token = "0x6002CD6")]
	[Address(RVA = "0x1D46A1C", Offset = "0x1D46A1C", VA = "0x1D46A1C")]
	private bool IsOccupying()
	{
		return default(bool);
	}

	[Token(Token = "0x6002CD7")]
	[Address(RVA = "0x1D46AF8", Offset = "0x1D46AF8", VA = "0x1D46AF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6002CD8")]
	[Address(RVA = "0x1D46C98", Offset = "0x1D46C98", VA = "0x1D46C98")]
	private void OpenBox()
	{
	}

	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x1D46D88", Offset = "0x1D46D88", VA = "0x1D46D88")]
	[PunRPC]
	private void _OpenBox(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002CDA")]
	[Address(RVA = "0x1D47454", Offset = "0x1D47454", VA = "0x1D47454")]
	public void SyncBox(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002CDB")]
	[Address(RVA = "0x1D47648", Offset = "0x1D47648", VA = "0x1D47648")]
	[PunRPC]
	private void _SyncBox(float accumulated, bool enabled, PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002CDC")]
	[Address(RVA = "0x1D47880", Offset = "0x1D47880", VA = "0x1D47880")]
	public void ReqResetBox(bool enable)
	{
	}

	[Token(Token = "0x6002CDD")]
	[Address(RVA = "0x1D479E0", Offset = "0x1D479E0", VA = "0x1D479E0")]
	[PunRPC]
	public void _ResetBox(bool enable)
	{
	}

	[Token(Token = "0x6002CDE")]
	[Address(RVA = "0x1D47774", Offset = "0x1D47774", VA = "0x1D47774")]
	private void ResetBox(bool enable)
	{
	}

	[Token(Token = "0x6002CDF")]
	[Address(RVA = "0x1D4718C", Offset = "0x1D4718C", VA = "0x1D4718C")]
	private void EnableBox(bool b)
	{
	}

	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x1D47B7C", Offset = "0x1D47B7C", VA = "0x1D47B7C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x1D47D7C", Offset = "0x1D47D7C", VA = "0x1D47D7C")]
	public void RegisterReciever(IStrongBoxEventReciver reciever)
	{
	}
}
