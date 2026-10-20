using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010DA")]
internal class MatchingLoadingTest : MonoBehaviour
{
	[Token(Token = "0x4005CC8")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_goLoadingContents_Matching;

	[Token(Token = "0x4005CC9")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_MatchingLoading m_Widget_MatchingLoading;

	[Token(Token = "0x4005CCA")]
	[FieldOffset(Offset = "0x14")]
	private List<MatchPlayerInfo> m_liMatchPlayerInfo;

	[Token(Token = "0x6007F2E")]
	[Address(RVA = "0x135AFD0", Offset = "0x135AFD0", VA = "0x135AFD0")]
	public MatchingLoadingTest()
	{
	}

	[Token(Token = "0x6007F2F")]
	[Address(RVA = "0x135AFD8", Offset = "0x135AFD8", VA = "0x135AFD8")]
	public void Start()
	{
	}

	[Token(Token = "0x6007F30")]
	[Address(RVA = "0x135B5B4", Offset = "0x135B5B4", VA = "0x135B5B4")]
	private void MakeDummyData()
	{
	}

	[Token(Token = "0x6007F31")]
	[Address(RVA = "0x135BAFC", Offset = "0x135BAFC", VA = "0x135BAFC")]
	public void ShowMatchingLoading()
	{
	}

	[Token(Token = "0x6007F32")]
	[Address(RVA = "0x135BBEC", Offset = "0x135BBEC", VA = "0x135BBEC")]
	public void HideMatchingLoading()
	{
	}
}
