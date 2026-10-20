using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CC3")]
public class XPanel_PetDirectionRoot : MonoBehaviour
{
	[Token(Token = "0x2000CC4")]
	private sealed class _003CShowGet_003Ec__AnonStorey18D
	{
		[Token(Token = "0x40040EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleActor.CreationDesc petDescription;

		[Token(Token = "0x40040ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_PetDirectionRoot _003C_003Ef__this;

		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x1016F0C", Offset = "0x1016F0C", VA = "0x1016F0C")]
		public _003CShowGet_003Ec__AnonStorey18D()
		{
		}

		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x1017E2C", Offset = "0x1017E2C", VA = "0x1017E2C")]
		internal void _003C_003Em__27E()
		{
		}

		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x1017E60", Offset = "0x1017E60", VA = "0x1017E60")]
		internal void _003C_003Em__27F()
		{
		}

		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x1017E88", Offset = "0x1017E88", VA = "0x1017E88")]
		internal void _003C_003Em__280()
		{
		}
	}

	[Token(Token = "0x2000CC5")]
	private sealed class _003CBuildCommonDirection_003Ec__AnonStorey18E
	{
		[Token(Token = "0x40040EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XModuleActor.CreationDesc petDescription;

		[Token(Token = "0x40040EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_PetDirectionRoot _003C_003Ef__this;

		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x10174F0", Offset = "0x10174F0", VA = "0x10174F0")]
		public _003CBuildCommonDirection_003Ec__AnonStorey18E()
		{
		}

		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x1017D1C", Offset = "0x1017D1C", VA = "0x1017D1C")]
		internal void _003C_003Em__282()
		{
		}

		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x1017D50", Offset = "0x1017D50", VA = "0x1017D50")]
		internal void _003C_003Em__283()
		{
		}
	}

	[Token(Token = "0x2000CC6")]
	private sealed class _003CShowDirectionAndOtherUIOpen_003Ec__AnonStorey18F
	{
		[Token(Token = "0x40040F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action directionShowUIAction;

		[Token(Token = "0x40040F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XModuleActor.CreationDesc petDescription;

		[Token(Token = "0x40040F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_PetDirectionRoot _003C_003Ef__this;

		[Token(Token = "0x6005C12")]
		[Address(RVA = "0x1017BCC", Offset = "0x1017BCC", VA = "0x1017BCC")]
		public _003CShowDirectionAndOtherUIOpen_003Ec__AnonStorey18F()
		{
		}

		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x1017DBC", Offset = "0x1017DBC", VA = "0x1017DBC")]
		internal void _003C_003Em__284()
		{
		}

		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x1017DD0", Offset = "0x1017DD0", VA = "0x1017DD0")]
		internal void _003C_003Em__285()
		{
		}
	}

	[Token(Token = "0x40040E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XUIPetCamera getPetCamera;

	[Token(Token = "0x40040E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject petNameObject;

	[Token(Token = "0x40040E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblPetName;

	[Token(Token = "0x40040E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TweenAlpha blackTexture;

	[Token(Token = "0x40040E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private UIDirector m_directions;

	[Token(Token = "0x40040E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isSkipPermit;

	[Token(Token = "0x40040E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float cardDirectionFadeOutTime;

	[Token(Token = "0x40040E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject prenevtClick;

	[Token(Token = "0x40040EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Action m_endDirectionEndAction;

	[Token(Token = "0x40040EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache9;

	[Token(Token = "0x6005BFD")]
	[Address(RVA = "0x101693C", Offset = "0x101693C", VA = "0x101693C")]
	public XPanel_PetDirectionRoot()
	{
	}

	[Token(Token = "0x6005BFE")]
	[Address(RVA = "0x10169E8", Offset = "0x10169E8", VA = "0x10169E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005BFF")]
	[Address(RVA = "0xFD02A4", Offset = "0xFD02A4", VA = "0xFD02A4")]
	public void ShowPetGet(XModuleActor.CreationDesc petDescription, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005C00")]
	[Address(RVA = "0x1016B3C", Offset = "0x1016B3C", VA = "0x1016B3C")]
	public void ShowGet(XModuleActor.CreationDesc petDescription, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005C01")]
	[Address(RVA = "0x1016B5C", Offset = "0x1016B5C", VA = "0x1016B5C")]
	public void ShowGet(XModuleActor.CreationDesc petDescription, float showDelay, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6005C02")]
	[Address(RVA = "0x10170FC", Offset = "0x10170FC", VA = "0x10170FC")]
	private void BuildCommonDirection(UIDirector director, XModuleActor.CreationDesc petDescription, bool isLevelUp = false)
	{
	}

	[Token(Token = "0x6005C03")]
	[Address(RVA = "0x10174F8", Offset = "0x10174F8", VA = "0x10174F8")]
	private void DirectionEnviromentSetting()
	{
	}

	[Token(Token = "0x6005C04")]
	[Address(RVA = "0x1016F14", Offset = "0x1016F14", VA = "0x1016F14")]
	private void DirectionReady()
	{
	}

	[Token(Token = "0x6005C05")]
	[Address(RVA = "0x10149B0", Offset = "0x10149B0", VA = "0x10149B0")]
	public void ShowDirectionAndOtherUIOpen(XModuleActor petModuleActor, [Optional] Action directionShowUIAction)
	{
	}

	[Token(Token = "0x6005C06")]
	[Address(RVA = "0x10178D0", Offset = "0x10178D0", VA = "0x10178D0")]
	public void ShowDirectionAndOtherUIOpen(XModuleActor.CreationDesc petDescription, [Optional] Action directionShowUIAction)
	{
	}

	[Token(Token = "0x6005C07")]
	[Address(RVA = "0x1014AB4", Offset = "0x1014AB4", VA = "0x1014AB4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005C08")]
	[Address(RVA = "0x1017674", Offset = "0x1017674", VA = "0x1017674")]
	private void ShowPetName(bool isShow, [Optional] XModuleActor.CreationDesc petDescription)
	{
	}

	[Token(Token = "0x6005C09")]
	[Address(RVA = "0x1017BD4", Offset = "0x1017BD4", VA = "0x1017BD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6005C0A")]
	[Address(RVA = "0x1017C00", Offset = "0x1017C00", VA = "0x1017C00")]
	private static void _003CBuildCommonDirection_003Em__281()
	{
	}
}
