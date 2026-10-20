using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010ED")]
[IntegrationTest.SucceedWithAssertions]
public class PanelTopBannerTest : MonoBehaviour
{
	[Token(Token = "0x4005CEF")]
	[FieldOffset(Offset = "0xC")]
	public XPanel_TopBanner banner;

	[Token(Token = "0x4005CF0")]
	[FieldOffset(Offset = "0x10")]
	private XMyInfo myInfo;

	[Token(Token = "0x4005CF1")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<XLobbyStateTypes, string> statNameDic;

	[Token(Token = "0x6007F87")]
	[Address(RVA = "0x1B7E50C", Offset = "0x1B7E50C", VA = "0x1B7E50C")]
	public PanelTopBannerTest()
	{
	}

	[Token(Token = "0x6007F88")]
	[Address(RVA = "0x1B7E5B8", Offset = "0x1B7E5B8", VA = "0x1B7E5B8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007F89")]
	[Address(RVA = "0x1B7E858", Offset = "0x1B7E858", VA = "0x1B7E858")]
	private void ResetMyInfo()
	{
	}

	[Token(Token = "0x6007F8A")]
	[Address(RVA = "0x1B7ED90", Offset = "0x1B7ED90", VA = "0x1B7ED90")]
	public void Start()
	{
	}

	[Token(Token = "0x6007F8B")]
	[Address(RVA = "0x1B7EED4", Offset = "0x1B7EED4", VA = "0x1B7EED4")]
	public void Update()
	{
	}

	[Token(Token = "0x6007F8C")]
	[Address(RVA = "0x1B7E8EC", Offset = "0x1B7E8EC", VA = "0x1B7E8EC")]
	private void StateNameSetting()
	{
	}
}
