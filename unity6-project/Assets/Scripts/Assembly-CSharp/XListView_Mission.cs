using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F4B")]
public class XListView_Mission : XUIListView
{
	[Token(Token = "0x400504B")]
	[FieldOffset(Offset = "0x78")]
	private int dummyItemCount;

	[Token(Token = "0x400504C")]
	[FieldOffset(Offset = "0x7C")]
	private int lastDummyItemCount;

	[Token(Token = "0x400504D")]
	[FieldOffset(Offset = "0x80")]
	protected List<CSStageInfo> missionList;

	[Token(Token = "0x400504E")]
	[FieldOffset(Offset = "0x84")]
	private List<CSStageInfo> m_pureInfoList;

	[Token(Token = "0x17000E79")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007192")]
		[Address(RVA = "0x1E12B2C", Offset = "0x1E12B2C", VA = "0x1E12B2C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7A")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007193")]
		[Address(RVA = "0x1E12BA4", Offset = "0x1E12BA4", VA = "0x1E12BA4", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E7B")]
	protected List<CSStageInfo> CurrentMissionList
	{
		[Token(Token = "0x6007194")]
		[Address(RVA = "0x1E12BAC", Offset = "0x1E12BAC", VA = "0x1E12BAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7C")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007195")]
		[Address(RVA = "0x1E12BB4", Offset = "0x1E12BB4", VA = "0x1E12BB4", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007191")]
	[Address(RVA = "0x1E12A78", Offset = "0x1E12A78", VA = "0x1E12A78")]
	public XListView_Mission()
	{
	}

	[Token(Token = "0x6007196")]
	[Address(RVA = "0x1E12C4C", Offset = "0x1E12C4C", VA = "0x1E12C4C", Slot = "7")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6007197")]
	[Address(RVA = "0x1E12F88", Offset = "0x1E12F88", VA = "0x1E12F88", Slot = "8")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6007198")]
	[Address(RVA = "0x1E13094", Offset = "0x1E13094", VA = "0x1E13094", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007199")]
	[Address(RVA = "0x1E13224", Offset = "0x1E13224", VA = "0x1E13224")]
	private void InitList()
	{
	}

	[Token(Token = "0x600719A")]
	[Address(RVA = "0x1E13448", Offset = "0x1E13448", VA = "0x1E13448")]
	public void Build(CSStageInfo missionInfo)
	{
	}

	[Token(Token = "0x600719B")]
	[Address(RVA = "0x1E135C0", Offset = "0x1E135C0", VA = "0x1E135C0", Slot = "9")]
	public override void SetIndexToTop(int index)
	{
	}

	[Token(Token = "0x600719C")]
	[Address(RVA = "0x1E13478", Offset = "0x1E13478", VA = "0x1E13478")]
	public void SetIndexToMission(CSStageInfo mission)
	{
	}

	[Token(Token = "0x600719D")]
	[Address(RVA = "0x1E136EC", Offset = "0x1E136EC", VA = "0x1E136EC")]
	public CSStageInfo GetMissionInfo(int index)
	{
		return null;
	}
}
