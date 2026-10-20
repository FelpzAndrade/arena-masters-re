using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000DF1")]
public class XPanel_IronsMission : UIPopup
{
	[Token(Token = "0x40048E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XUITabView TabView;

	[Token(Token = "0x40048E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public XUIScrollView ItemView;

	[Token(Token = "0x40048E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HashSet<int> MissionGroups;

	[Token(Token = "0x40048E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int CurrentGroup;

	[Token(Token = "0x40048E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Func<IronsMission, int> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x17000D6E")]
	public static XPanel_IronsMission Instance
	{
		[Token(Token = "0x600672B")]
		[Address(RVA = "0xFF7EE8", Offset = "0xFF7EE8", VA = "0xFF7EE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600672A")]
	[Address(RVA = "0xFF7E3C", Offset = "0xFF7E3C", VA = "0xFF7E3C")]
	public XPanel_IronsMission()
	{
	}

	[Token(Token = "0x600672C")]
	[Address(RVA = "0xFF7FF4", Offset = "0xFF7FF4", VA = "0xFF7FF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600672D")]
	[Address(RVA = "0xFF7FF8", Offset = "0xFF7FF8", VA = "0xFF7FF8")]
	public void Build()
	{
	}

	[Token(Token = "0x600672E")]
	[Address(RVA = "0xFF82E0", Offset = "0xFF82E0", VA = "0xFF82E0", Slot = "23")]
	public override void Show()
	{
	}

	[Token(Token = "0x600672F")]
	[Address(RVA = "0xFF8354", Offset = "0xFF8354", VA = "0xFF8354")]
	private void SetGroup(int group)
	{
	}

	[Token(Token = "0x6006730")]
	[Address(RVA = "0xFF844C", Offset = "0xFF844C", VA = "0xFF844C", Slot = "25")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x6006731")]
	[Address(RVA = "0xFF8488", Offset = "0xFF8488", VA = "0xFF8488")]
	public void RefreshTabView()
	{
	}

	[Token(Token = "0x6006732")]
	[Address(RVA = "0xFF8DE0", Offset = "0xFF8DE0", VA = "0xFF8DE0")]
	private string GetTitleString(int groupId, int tabNo)
	{
		return null;
	}

	[Token(Token = "0x6006733")]
	[Address(RVA = "0xFF8CCC", Offset = "0xFF8CCC", VA = "0xFF8CCC")]
	private void SetTabView()
	{
	}

	[Token(Token = "0x6006734")]
	[Address(RVA = "0xFF87A0", Offset = "0xFF87A0", VA = "0xFF87A0")]
	private void SetItemView()
	{
	}

	[Token(Token = "0x6006735")]
	[Address(RVA = "0xFF9160", Offset = "0xFF9160", VA = "0xFF9160")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x6006736")]
	[Address(RVA = "0xFF91A4", Offset = "0xFF91A4", VA = "0xFF91A4")]
	private void OnClick_Tab(object group)
	{
	}

	[Token(Token = "0x6006737")]
	[Address(RVA = "0xFF9238", Offset = "0xFF9238", VA = "0xFF9238")]
	private void OnDataChanged()
	{
	}

	[Token(Token = "0x6006738")]
	[Address(RVA = "0xFF833C", Offset = "0xFF833C", VA = "0xFF833C")]
	private void MoveLastMissionGroup()
	{
	}

	[Token(Token = "0x6006739")]
	[Address(RVA = "0xFF8F08", Offset = "0xFF8F08", VA = "0xFF8F08")]
	private int GetLastMissionGroup()
	{
		return default(int);
	}

	[Token(Token = "0x600673A")]
	[Address(RVA = "0xFF80B0", Offset = "0xFF80B0", VA = "0xFF80B0")]
	private HashSet<int> GetMissionGroups()
	{
		return null;
	}

	[Token(Token = "0x600673B")]
	[Address(RVA = "0xFF9400", Offset = "0xFF9400", VA = "0xFF9400")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x600673C")]
	[Address(RVA = "0xFF94D8", Offset = "0xFF94D8", VA = "0xFF94D8")]
	private bool _003CSetItemView_003Em__386(IronsMission item)
	{
		return default(bool);
	}

	[Token(Token = "0x600673D")]
	[Address(RVA = "0xFF950C", Offset = "0xFF950C", VA = "0xFF950C")]
	private static int _003CSetItemView_003Em__387(IronsMission item)
	{
		return default(int);
	}
}
