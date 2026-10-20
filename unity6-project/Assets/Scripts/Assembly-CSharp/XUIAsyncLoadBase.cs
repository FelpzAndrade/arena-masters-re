using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2001065")]
public class XUIAsyncLoadBase : MonoBehaviour
{
	[Token(Token = "0x4005888")]
	[FieldOffset(Offset = "0xC")]
	protected string m_resPath;

	[Token(Token = "0x4005889")]
	[FieldOffset(Offset = "0x10")]
	protected GameObject m_resObj;

	[Token(Token = "0x400588A")]
	[FieldOffset(Offset = "0x14")]
	protected Transform m_resRootTr;

	[Token(Token = "0x400588B")]
	[FieldOffset(Offset = "0x18")]
	private XHelper.XIntervalUpdater m_intervalUpdater;

	[Token(Token = "0x400588C")]
	[FieldOffset(Offset = "0x1C")]
	private XAssetBundleLoadAssetOperation m_assetReq;

	[Token(Token = "0x6007BDE")]
	[Address(RVA = "0x1A2AB3C", Offset = "0x1A2AB3C", VA = "0x1A2AB3C")]
	public XUIAsyncLoadBase()
	{
	}

	[Token(Token = "0x6007BDF")]
	[Address(RVA = "0x1A2AC00", Offset = "0x1A2AC00", VA = "0x1A2AC00")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007BE0")]
	[Address(RVA = "0x1A2AC44", Offset = "0x1A2AC44", VA = "0x1A2AC44")]
	private void Update()
	{
	}

	[Token(Token = "0x6007BE1")]
	[Address(RVA = "0x1A2AC58", Offset = "0x1A2AC58", VA = "0x1A2AC58")]
	public void RequestAsyncLoad()
	{
	}

	[Token(Token = "0x6007BE2")]
	[Address(RVA = "0x1A2AD38", Offset = "0x1A2AD38", VA = "0x1A2AD38", Slot = "4")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6007BE3")]
	[Address(RVA = "0x1A2AD54", Offset = "0x1A2AD54", VA = "0x1A2AD54", Slot = "5")]
	protected virtual void ReqestResource()
	{
	}

	[Token(Token = "0x6007BE4")]
	[Address(RVA = "0x1A2B14C", Offset = "0x1A2B14C", VA = "0x1A2B14C")]
	private bool CheckLoadEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x6007BE5")]
	[Address(RVA = "0x1A2AF50", Offset = "0x1A2AF50", VA = "0x1A2AF50")]
	private void RequestDone()
	{
	}

	[Token(Token = "0x6007BE6")]
	[Address(RVA = "0x1A2B1B4", Offset = "0x1A2B1B4", VA = "0x1A2B1B4", Slot = "6")]
	protected virtual void GetParsorObj()
	{
	}
}
