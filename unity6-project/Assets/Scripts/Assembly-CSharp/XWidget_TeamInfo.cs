using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D4B")]
public class XWidget_TeamInfo : MonoBehaviour
{
	[Token(Token = "0x2000D4C")]
	public class TeamInfo
	{
		[Token(Token = "0x400445F")]
		[FieldOffset(Offset = "0x8")]
		public XPlayer info;

		[Token(Token = "0x4004460")]
		[FieldOffset(Offset = "0xC")]
		public XModuleEntity me;

		[Token(Token = "0x4004461")]
		[FieldOffset(Offset = "0x10")]
		public Sprite charIcon;

		[Token(Token = "0x4004462")]
		[FieldOffset(Offset = "0x14")]
		public InterfaceTeamMember widget;

		[Token(Token = "0x60061AB")]
		[Address(RVA = "0x1B16DF0", Offset = "0x1B16DF0", VA = "0x1B16DF0")]
		public TeamInfo()
		{
		}
	}

	[Token(Token = "0x2000D4D")]
	private sealed class _003CBuild_003Ec__AnonStorey19B
	{
		[Token(Token = "0x4004463")]
		[FieldOffset(Offset = "0x8")]
		internal XPlayer xPlayer;

		[Token(Token = "0x4004464")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_TeamInfo _003C_003Ef__this;

		[Token(Token = "0x60061AC")]
		[Address(RVA = "0x1B16C38", Offset = "0x1B16C38", VA = "0x1B16C38")]
		public _003CBuild_003Ec__AnonStorey19B()
		{
		}

		[Token(Token = "0x60061AD")]
		[Address(RVA = "0x1B17F8C", Offset = "0x1B17F8C", VA = "0x1B17F8C")]
		internal void _003C_003Em__2C0()
		{
		}

		[Token(Token = "0x60061AE")]
		[Address(RVA = "0x1B17FBC", Offset = "0x1B17FBC", VA = "0x1B17FBC")]
		internal void _003C_003Em__2C1()
		{
		}
	}

	[Token(Token = "0x400445B")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder grid;

	[Token(Token = "0x400445C")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, TeamInfo> teamList;

	[Token(Token = "0x400445D")]
	[FieldOffset(Offset = "0x14")]
	private Action<XPlayer> OnEventBanPlayer;

	[Token(Token = "0x400445E")]
	[FieldOffset(Offset = "0x18")]
	private Action<XPlayer> OnEventSpectorPlayer;

	[Token(Token = "0x600619B")]
	[Address(RVA = "0x1B163CC", Offset = "0x1B163CC", VA = "0x1B163CC")]
	public XWidget_TeamInfo()
	{
	}

	[Token(Token = "0x600619C")]
	[Address(RVA = "0x1B16478", Offset = "0x1B16478", VA = "0x1B16478")]
	public void Final()
	{
	}

	[Token(Token = "0x600619D")]
	[Address(RVA = "0x1B16484", Offset = "0x1B16484", VA = "0x1B16484")]
	public void Build(List<XPlayer> list)
	{
	}

	[Token(Token = "0x600619E")]
	[Address(RVA = "0x1B1737C", Offset = "0x1B1737C", VA = "0x1B1737C")]
	public void RefreshFriendlyTeamInfo()
	{
	}

	[Token(Token = "0x600619F")]
	[Address(RVA = "0x1B16DF8", Offset = "0x1B16DF8", VA = "0x1B16DF8")]
	private void RefreshTeamInfo()
	{
	}

	[Token(Token = "0x60061A0")]
	[Address(RVA = "0x1B16C40", Offset = "0x1B16C40", VA = "0x1B16C40")]
	private XModuleEntity FindME(int id)
	{
		return null;
	}

	[Token(Token = "0x60061A1")]
	[Address(RVA = "0x1B16D1C", Offset = "0x1B16D1C", VA = "0x1B16D1C")]
	private XModuleEntity FindME(string aid)
	{
		return null;
	}

	[Token(Token = "0x60061A2")]
	[Address(RVA = "0x1B17504", Offset = "0x1B17504", VA = "0x1B17504")]
	private void Update()
	{
	}

	[Token(Token = "0x60061A3")]
	[Address(RVA = "0x1B1782C", Offset = "0x1B1782C", VA = "0x1B1782C")]
	public void SetBanPlayerEvent(Action<XPlayer> action)
	{
	}

	[Token(Token = "0x60061A4")]
	[Address(RVA = "0x1B17834", Offset = "0x1B17834", VA = "0x1B17834")]
	public void SetSpectatorPlayerEvent(Action<XPlayer> action)
	{
	}

	[Token(Token = "0x60061A5")]
	[Address(RVA = "0x1B1783C", Offset = "0x1B1783C", VA = "0x1B1783C")]
	public void BanPlayer(XPlayer player)
	{
	}

	[Token(Token = "0x60061A6")]
	[Address(RVA = "0x1B178D0", Offset = "0x1B178D0", VA = "0x1B178D0")]
	public void SpectatorPlayer(XPlayer player)
	{
	}

	[Token(Token = "0x60061A7")]
	[Address(RVA = "0x1B17964", Offset = "0x1B17964", VA = "0x1B17964")]
	internal void ShowPlayerBanButton()
	{
	}

	[Token(Token = "0x60061A8")]
	[Address(RVA = "0x1B17B00", Offset = "0x1B17B00", VA = "0x1B17B00")]
	internal void HidePlayerBanButton()
	{
	}

	[Token(Token = "0x60061A9")]
	[Address(RVA = "0x1B17C78", Offset = "0x1B17C78", VA = "0x1B17C78")]
	internal void ShowPlayerSpectatorButton()
	{
	}

	[Token(Token = "0x60061AA")]
	[Address(RVA = "0x1B17E14", Offset = "0x1B17E14", VA = "0x1B17E14")]
	internal void HidePlayerSpectatorButton()
	{
	}
}
