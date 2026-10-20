using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000758")]
public class XGimmickManager
{
	[Token(Token = "0x2000759")]
	public struct GimmickBuffInfo
	{
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x0")]
		public int buffID;

		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x4")]
		public XModuleEntity moduleEntity;
	}

	[Token(Token = "0x40022B0")]
	[FieldOffset(Offset = "0x8")]
	private bool m_hasGimmick;

	[Token(Token = "0x40022B1")]
	[FieldOffset(Offset = "0xC")]
	private List<XModuleGimmick> m_gimmickList;

	[Token(Token = "0x40022B2")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<XMapGimmickType, List<XModuleGimmick>> m_gimmickDictionary;

	[Token(Token = "0x40022B3")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, Dictionary<int, GimmickBuffInfo>> m_gimmickCollitionEventDictionary;

	[Token(Token = "0x40022B4")]
	[FieldOffset(Offset = "0x18")]
	private XModuleEntity m_myModuleEntity;

	[Token(Token = "0x40022B5")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_isSync;

	[Token(Token = "0x1700083E")]
	public bool IsSync
	{
		[Token(Token = "0x6003BFB")]
		[Address(RVA = "0x1D12BCC", Offset = "0x1D12BCC", VA = "0x1D12BCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003BFA")]
	[Address(RVA = "0x1D12AEC", Offset = "0x1D12AEC", VA = "0x1D12AEC")]
	public XGimmickManager()
	{
	}

	[Token(Token = "0x6003BFC")]
	[Address(RVA = "0x1D12BD4", Offset = "0x1D12BD4", VA = "0x1D12BD4")]
	public void Init(XSector sector)
	{
	}

	[Token(Token = "0x6003BFD")]
	[Address(RVA = "0x1D12D44", Offset = "0x1D12D44", VA = "0x1D12D44")]
	public void SetMyModuleEntity(XModuleEntity myModuleEntity)
	{
	}

	[Token(Token = "0x6003BFE")]
	[Address(RVA = "0x1D12D4C", Offset = "0x1D12D4C", VA = "0x1D12D4C")]
	public XModuleGimmick GetGimmick(int index)
	{
		return null;
	}

	[Token(Token = "0x6003BFF")]
	[Address(RVA = "0x1D12E34", Offset = "0x1D12E34", VA = "0x1D12E34")]
	public XMapGimmickWorkingState GetWorkingStateGimmick(int index)
	{
		return default(XMapGimmickWorkingState);
	}

	[Token(Token = "0x6003C00")]
	[Address(RVA = "0x1D12F28", Offset = "0x1D12F28", VA = "0x1D12F28")]
	public void StartGimmickTimer(float modeFullTime, float modeRemainedTime, Action<int, XMapGimmickWorkingState> workingStateExitAction)
	{
	}

	[Token(Token = "0x6003C01")]
	[Address(RVA = "0x1D130AC", Offset = "0x1D130AC", VA = "0x1D130AC")]
	public int GetCurrGimmickTimeLineIndex(int gimmickIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6003C02")]
	[Address(RVA = "0x1D131A0", Offset = "0x1D131A0", VA = "0x1D131A0")]
	public XMapGimmickWorkingState FindGimmickWorkingState_UseTimeLine(int gimmickIndex, int timeLineIndex)
	{
		return default(XMapGimmickWorkingState);
	}

	[Token(Token = "0x6003C03")]
	[Address(RVA = "0x1D1329C", Offset = "0x1D1329C", VA = "0x1D1329C")]
	public int GetGimmickAddScheduleCount(int gimmickIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6003C04")]
	[Address(RVA = "0x1D13390", Offset = "0x1D13390", VA = "0x1D13390")]
	public void SetGimmickAddScheduleCount(int gimmickIndex, int scheduleCount)
	{
	}

	[Token(Token = "0x6003C05")]
	[Address(RVA = "0x1D13488", Offset = "0x1D13488", VA = "0x1D13488")]
	public void OnEnterWorkingState(int gimmickIndex, XMapGimmickWorkingState enterGimmickWorkingState)
	{
	}

	[Token(Token = "0x6003C06")]
	[Address(RVA = "0x1D13898", Offset = "0x1D13898", VA = "0x1D13898")]
	public void RecordEnterGimmick(string uid, int gimmickIndex, int buffID, XModuleEntity moduleEntity)
	{
	}

	[Token(Token = "0x6003C07")]
	[Address(RVA = "0x1D13BDC", Offset = "0x1D13BDC", VA = "0x1D13BDC")]
	public void RemoveEnterGimmick(string uid, int gimmickIndex)
	{
	}

	[Token(Token = "0x6003C08")]
	[Address(RVA = "0x1D1363C", Offset = "0x1D1363C", VA = "0x1D1363C")]
	public void OffTheGimmick(int gimmickIndex)
	{
	}

	[Token(Token = "0x6003C09")]
	[Address(RVA = "0x1D13D20", Offset = "0x1D13D20", VA = "0x1D13D20")]
	public void OnUpdateGimmickList(float modeRemainedTime)
	{
	}

	[Token(Token = "0x6003C0A")]
	[Address(RVA = "0x1D13E1C", Offset = "0x1D13E1C", VA = "0x1D13E1C")]
	public void SyncGimmickWorkingInfo(NetData_GimmickWorkingInfo gimmickWorkingInfo)
	{
	}

	[Token(Token = "0x6003C0B")]
	[Address(RVA = "0x1D14018", Offset = "0x1D14018", VA = "0x1D14018")]
	public NetData_GimmickWorkingInfo GenerateGimmickWorkingInfo()
	{
		return null;
	}
}
