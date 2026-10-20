using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D2")]
public class XUIModelPreview
{
	[Token(Token = "0x20006D3")]
	private sealed class _003CShowModel_003Ec__AnonStorey133
	{
		[Token(Token = "0x40020A2")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x40020A3")]
		[FieldOffset(Offset = "0xC")]
		internal XModuleActor.CreationDesc desc;

		[Token(Token = "0x40020A4")]
		[FieldOffset(Offset = "0x10")]
		internal bool playIntro;

		[Token(Token = "0x40020A5")]
		[FieldOffset(Offset = "0x14")]
		internal XUIModelPreview _003C_003Ef__this;

		[Token(Token = "0x6003942")]
		[Address(RVA = "0x10D48BC", Offset = "0x10D48BC", VA = "0x10D48BC")]
		public _003CShowModel_003Ec__AnonStorey133()
		{
		}

		[Token(Token = "0x6003943")]
		[Address(RVA = "0x10D4FEC", Offset = "0x10D4FEC", VA = "0x10D4FEC")]
		internal void _003C_003Em__194()
		{
		}
	}

	[Token(Token = "0x4002097")]
	[FieldOffset(Offset = "0x8")]
	public string ModelPreviewName;

	[Token(Token = "0x4002098")]
	[FieldOffset(Offset = "0xC")]
	public float DragSensitivity;

	[Token(Token = "0x4002099")]
	[FieldOffset(Offset = "0x10")]
	public string ModelPreviewEffectName;

	[Token(Token = "0x400209A")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_goBackgoundEffect;

	[Token(Token = "0x400209B")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_ModelPreviewParent;

	[Token(Token = "0x400209C")]
	[FieldOffset(Offset = "0x1C")]
	private XModuleActor m_SelectedActor;

	[Token(Token = "0x400209D")]
	[FieldOffset(Offset = "0x20")]
	private List<Transform> m_actorParents;

	[Token(Token = "0x400209E")]
	[FieldOffset(Offset = "0x24")]
	private List<XModuleActor> m_ActorList;

	[Token(Token = "0x400209F")]
	[FieldOffset(Offset = "0x28")]
	private List<XAsyncLoadOperator> m_asyncOpList;

	[Token(Token = "0x40020A0")]
	[FieldOffset(Offset = "0x2C")]
	private Camera camera;

	[Token(Token = "0x40020A1")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture rt;

	[Token(Token = "0x17000815")]
	private Transform modelPreviewParent
	{
		[Token(Token = "0x600392C")]
		[Address(RVA = "0x10D2E8C", Offset = "0x10D2E8C", VA = "0x10D2E8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600392B")]
	[Address(RVA = "0x10BF6BC", Offset = "0x10BF6BC", VA = "0x10BF6BC")]
	public XUIModelPreview()
	{
	}

	[Token(Token = "0x600392D")]
	[Address(RVA = "0x10D2F4C", Offset = "0x10D2F4C", VA = "0x10D2F4C")]
	public RenderTexture GetRenderTexture()
	{
		return null;
	}

	[Token(Token = "0x600392E")]
	[Address(RVA = "0x10BF934", Offset = "0x10BF934", VA = "0x10BF934")]
	public void ReleaseRenderTexture()
	{
	}

	[Token(Token = "0x600392F")]
	[Address(RVA = "0x10C4AD8", Offset = "0x10C4AD8", VA = "0x10C4AD8")]
	public void Init()
	{
	}

	[Token(Token = "0x6003930")]
	[Address(RVA = "0x10D346C", Offset = "0x10D346C", VA = "0x10D346C")]
	private void DestroyModel(int index)
	{
	}

	[Token(Token = "0x6003931")]
	[Address(RVA = "0x10D35F0", Offset = "0x10D35F0", VA = "0x10D35F0")]
	private XModuleActor CreateModelPreview(int transformIndex, XModuleActor.CreationDesc eachCreationDesc)
	{
		return null;
	}

	[Token(Token = "0x6003932")]
	[Address(RVA = "0x10D387C", Offset = "0x10D387C", VA = "0x10D387C")]
	private void SetModelPreviewPosition(int modelListCount, bool bCenter)
	{
	}

	[Token(Token = "0x6003933")]
	[Address(RVA = "0x10D30BC", Offset = "0x10D30BC", VA = "0x10D30BC")]
	private void CreateAttatchBackgroundEffect()
	{
	}

	[Token(Token = "0x6003934")]
	[Address(RVA = "0x10D3A98", Offset = "0x10D3A98", VA = "0x10D3A98")]
	private void ShowModelImpl(int transformIndex, XModuleActor.CreationDesc creationDesc, bool playIntro = false)
	{
	}

	[Token(Token = "0x6003935")]
	[Address(RVA = "0x10D3C14", Offset = "0x10D3C14", VA = "0x10D3C14")]
	private void AddCreationDesc(ref List<XModuleActor.CreationDesc> creationDescList, XModuleActor moduleActor)
	{
	}

	[Token(Token = "0x6003936")]
	[Address(RVA = "0x10D3D54", Offset = "0x10D3D54", VA = "0x10D3D54")]
	public void ShowModel()
	{
	}

	[Token(Token = "0x6003937")]
	[Address(RVA = "0x10D402C", Offset = "0x10D402C", VA = "0x10D402C")]
	public void ShowModel(XModuleActor moduleActor, bool bCenter = false, bool playIntro = false)
	{
	}

	[Token(Token = "0x6003938")]
	[Address(RVA = "0x10D412C", Offset = "0x10D412C", VA = "0x10D412C")]
	public void ShowModel(List<XModuleActor> list, bool bCenter = false, bool playIntro = false)
	{
	}

	[Token(Token = "0x6003939")]
	[Address(RVA = "0x10D4318", Offset = "0x10D4318", VA = "0x10D4318")]
	private void ShowModel(int index, XModuleActor.CreationDesc desc, bool playIntro = false)
	{
	}

	[Token(Token = "0x600393A")]
	[Address(RVA = "0x10D48C4", Offset = "0x10D48C4", VA = "0x10D48C4")]
	private void RemoveAsyncComplete(int index)
	{
	}

	[Token(Token = "0x600393B")]
	[Address(RVA = "0x10D3EA4", Offset = "0x10D3EA4", VA = "0x10D3EA4")]
	private void ShowModel(List<XModuleActor.CreationDesc> creationDescList, bool bCenter = false, bool playIntro = false)
	{
	}

	[Token(Token = "0x600393C")]
	[Address(RVA = "0x10D49D8", Offset = "0x10D49D8", VA = "0x10D49D8")]
	public void ShowSkinModel(XModuleActor moduleActor, int skinId, bool bCenter)
	{
	}

	[Token(Token = "0x600393D")]
	[Address(RVA = "0x10D4B28", Offset = "0x10D4B28", VA = "0x10D4B28")]
	public void DestroyModels()
	{
	}

	[Token(Token = "0x600393E")]
	[Address(RVA = "0x10D4BE8", Offset = "0x10D4BE8", VA = "0x10D4BE8")]
	public void Rotate(float delta)
	{
	}

	[Token(Token = "0x600393F")]
	[Address(RVA = "0x10D4CA4", Offset = "0x10D4CA4", VA = "0x10D4CA4")]
	public void ResetRotate()
	{
	}

	[Token(Token = "0x6003940")]
	[Address(RVA = "0x10D4D4C", Offset = "0x10D4D4C", VA = "0x10D4D4C")]
	public void SetActorsToList(int charID)
	{
	}

	[Token(Token = "0x6003941")]
	[Address(RVA = "0x10D4E98", Offset = "0x10D4E98", VA = "0x10D4E98")]
	public void SetScale(float scaleFactor)
	{
	}
}
