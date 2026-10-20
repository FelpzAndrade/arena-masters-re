using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CC0")]
public class XPanel_CardDirectionRootTest : MonoBehaviour
{
	[Token(Token = "0x2000CC1")]
	private sealed class _003CShow_003Ec__AnonStorey18C
	{
		[Token(Token = "0x40040DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string UIGetCharacterSoundKey;

		[Token(Token = "0x40040DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_CardDirectionRootTest _003C_003Ef__this;

		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0x16982D8", Offset = "0x16982D8", VA = "0x16982D8")]
		public _003CShow_003Ec__AnonStorey18C()
		{
		}

		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0x169830C", Offset = "0x169830C", VA = "0x169830C")]
		internal void _003C_003Em__279()
		{
		}

		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x16984AC", Offset = "0x16984AC", VA = "0x16984AC")]
		internal void _003C_003Em__27A()
		{
		}

		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x1698580", Offset = "0x1698580", VA = "0x1698580")]
		internal void _003C_003Em__27B()
		{
		}

		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x16985B4", Offset = "0x16985B4", VA = "0x16985B4")]
		internal void _003C_003Em__27C()
		{
		}

		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0x16985E8", Offset = "0x16985E8", VA = "0x16985E8")]
		internal void _003C_003Em__27D()
		{
		}
	}

	[Token(Token = "0x40040D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int charID;

	[Token(Token = "0x40040D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int skinID;

	[Token(Token = "0x40040D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XUICharacterCamera getCharacterCamera;

	[Token(Token = "0x40040D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TweenAlpha blackTexture;

	[Token(Token = "0x40040D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private UIDirector m_directions;

	[Token(Token = "0x40040D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isSkipPermit;

	[Token(Token = "0x40040D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float cardDirectionFadeOutTime;

	[Token(Token = "0x40040DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject prenevtClick;

	[Token(Token = "0x40040DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Action m_endDirectionEndAction;

	[Token(Token = "0x40040DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XModuleActor characterModuleActor;

	[Token(Token = "0x40040DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float characterShowTime;

	[Token(Token = "0x6005BED")]
	[Address(RVA = "0x169780C", Offset = "0x169780C", VA = "0x169780C")]
	public XPanel_CardDirectionRootTest()
	{
	}

	[Token(Token = "0x6005BEE")]
	[Address(RVA = "0x16978C4", Offset = "0x16978C4", VA = "0x16978C4")]
	public void CreateCharacterData()
	{
	}

	[Token(Token = "0x6005BEF")]
	[Address(RVA = "0x1697AA0", Offset = "0x1697AA0", VA = "0x1697AA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005BF0")]
	[Address(RVA = "0x1697A74", Offset = "0x1697A74", VA = "0x1697A74")]
	public void Show(XModuleActor characterModuleActor, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005BF1")]
	[Address(RVA = "0x1697BF4", Offset = "0x1697BF4", VA = "0x1697BF4")]
	public void Show(XModuleActor.CreationDesc characterDescription, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005BF2")]
	[Address(RVA = "0x16982E0", Offset = "0x16982E0", VA = "0x16982E0")]
	private void Update()
	{
	}
}
