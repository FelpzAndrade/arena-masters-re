using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CBC")]
public class XPanel_CardDirectionRoot : MonoBehaviour
{
	[Token(Token = "0x2000CBD")]
	private sealed class _003CShowGet_003Ec__AnonStorey189
	{
		[Token(Token = "0x40040CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleActor.CreationDesc characterDescription;

		[Token(Token = "0x40040CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_CardDirectionRoot _003C_003Ef__this;

		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x1696424", Offset = "0x1696424", VA = "0x1696424")]
		public _003CShowGet_003Ec__AnonStorey189()
		{
		}

		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x1697754", Offset = "0x1697754", VA = "0x1697754")]
		internal void _003C_003Em__271()
		{
		}

		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x1697788", Offset = "0x1697788", VA = "0x1697788")]
		internal void _003C_003Em__272()
		{
		}

		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x16977B0", Offset = "0x16977B0", VA = "0x16977B0")]
		internal void _003C_003Em__273()
		{
		}
	}

	[Token(Token = "0x2000CBE")]
	private sealed class _003CBuildCommonDirection_003Ec__AnonStorey18A
	{
		[Token(Token = "0x40040CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleActor.CreationDesc characterDescription;

		[Token(Token = "0x40040CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_CardDirectionRoot _003C_003Ef__this;

		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x1696A84", Offset = "0x1696A84", VA = "0x1696A84")]
		public _003CBuildCommonDirection_003Ec__AnonStorey18A()
		{
		}

		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x1697644", Offset = "0x1697644", VA = "0x1697644")]
		internal void _003C_003Em__275()
		{
		}

		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x1697678", Offset = "0x1697678", VA = "0x1697678")]
		internal void _003C_003Em__276()
		{
		}
	}

	[Token(Token = "0x2000CBF")]
	private sealed class _003CShowDirectionAndOtherUIOpen_003Ec__AnonStorey18B
	{
		[Token(Token = "0x40040D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action directionShowUIAction;

		[Token(Token = "0x40040D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XModuleActor.CreationDesc characterDescription;

		[Token(Token = "0x40040D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_CardDirectionRoot _003C_003Ef__this;

		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x1697190", Offset = "0x1697190", VA = "0x1697190")]
		public _003CShowDirectionAndOtherUIOpen_003Ec__AnonStorey18B()
		{
		}

		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x16976E4", Offset = "0x16976E4", VA = "0x16976E4")]
		internal void _003C_003Em__277()
		{
		}

		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x16976F8", Offset = "0x16976F8", VA = "0x16976F8")]
		internal void _003C_003Em__278()
		{
		}
	}

	[Token(Token = "0x40040C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XUICharacterCamera getCharacterCamera;

	[Token(Token = "0x40040C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject characterNameObject;

	[Token(Token = "0x40040C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblCharacterName;

	[Token(Token = "0x40040C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TweenAlpha blackTexture;

	[Token(Token = "0x40040C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private UIDirector m_directions;

	[Token(Token = "0x40040C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isSkipPermit;

	[Token(Token = "0x40040C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float cardDirectionFadeOutTime;

	[Token(Token = "0x40040C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject prenevtClick;

	[Token(Token = "0x40040CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Action m_endDirectionEndAction;

	[Token(Token = "0x40040CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache9;

	[Token(Token = "0x6005BD5")]
	[Address(RVA = "0x1695E34", Offset = "0x1695E34", VA = "0x1695E34")]
	public XPanel_CardDirectionRoot()
	{
	}

	[Token(Token = "0x6005BD6")]
	[Address(RVA = "0x1695EE0", Offset = "0x1695EE0", VA = "0x1695EE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005BD7")]
	[Address(RVA = "0x1696034", Offset = "0x1696034", VA = "0x1696034")]
	public void ShowCharacterGet(XModuleActor.CreationDesc characterDescription, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005BD8")]
	[Address(RVA = "0x1696054", Offset = "0x1696054", VA = "0x1696054")]
	public void ShowGet(XModuleActor.CreationDesc characterDescription, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005BD9")]
	[Address(RVA = "0x1696074", Offset = "0x1696074", VA = "0x1696074")]
	public void ShowGet(XModuleActor.CreationDesc characterDescription, float showDelay, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005BDA")]
	[Address(RVA = "0x1696614", Offset = "0x1696614", VA = "0x1696614")]
	private void BuildCommonDirection(UIDirector director, XModuleActor.CreationDesc characterDescription, bool isLevelUp = false)
	{
	}

	[Token(Token = "0x6005BDB")]
	[Address(RVA = "0x1696A8C", Offset = "0x1696A8C", VA = "0x1696A8C")]
	private void DirectionEnviromentSetting()
	{
	}

	[Token(Token = "0x6005BDC")]
	[Address(RVA = "0x169642C", Offset = "0x169642C", VA = "0x169642C")]
	private void DirectionReady()
	{
	}

	[Token(Token = "0x6005BDD")]
	[Address(RVA = "0x1696E64", Offset = "0x1696E64", VA = "0x1696E64")]
	public void ShowDirectionAndOtherUIOpen(XModuleActor characterModuleActor, [Optional] Action directionShowUIAction)
	{
	}

	[Token(Token = "0x6005BDE")]
	[Address(RVA = "0x1696E94", Offset = "0x1696E94", VA = "0x1696E94")]
	public void ShowDirectionAndOtherUIOpen(XModuleActor.CreationDesc characterDescription, [Optional] Action directionShowUIAction)
	{
	}

	[Token(Token = "0x6005BDF")]
	[Address(RVA = "0x1697198", Offset = "0x1697198", VA = "0x1697198")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005BE0")]
	[Address(RVA = "0x1696C08", Offset = "0x1696C08", VA = "0x1696C08")]
	private void ShowCharacterName(bool isShow, [Optional] XModuleActor.CreationDesc characterDescription)
	{
	}

	[Token(Token = "0x6005BE1")]
	[Address(RVA = "0x16974FC", Offset = "0x16974FC", VA = "0x16974FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6005BE2")]
	[Address(RVA = "0x1697528", Offset = "0x1697528", VA = "0x1697528")]
	private static void _003CBuildCommonDirection_003Em__274()
	{
	}
}
