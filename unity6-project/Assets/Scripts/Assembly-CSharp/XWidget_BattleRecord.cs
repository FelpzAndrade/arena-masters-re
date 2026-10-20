using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000F66")]
public class XWidget_BattleRecord : XUIBaseWidget
{
	[Token(Token = "0x2000F67")]
	private sealed class _003CSendGetGameRecord_003Ec__AnonStorey234
	{
		[Token(Token = "0x40050FA")]
		[FieldOffset(Offset = "0x8")]
		internal MatchType matchType;

		[Token(Token = "0x40050FB")]
		[FieldOffset(Offset = "0xC")]
		internal XGameModeType gameMode;

		[Token(Token = "0x40050FC")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_BattleRecord _003C_003Ef__this;

		[Token(Token = "0x6007279")]
		[Address(RVA = "0x15BBFF8", Offset = "0x15BBFF8", VA = "0x15BBFF8")]
		public _003CSendGetGameRecord_003Ec__AnonStorey234()
		{
		}

		[Token(Token = "0x600727A")]
		[Address(RVA = "0x15BC000", Offset = "0x15BC000", VA = "0x15BC000")]
		internal void _003C_003Em__499(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x40050F1")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, XWidget_Selectable_Label> gameModeLabels;

	[Token(Token = "0x40050F2")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_Selectable_Label selectGameModeLabel;

	[Token(Token = "0x40050F3")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder builderGameMode;

	[Token(Token = "0x40050F4")]
	[FieldOffset(Offset = "0x28")]
	public XWiget_GridBuilder builderEtcRecord;

	[Token(Token = "0x40050F5")]
	[FieldOffset(Offset = "0x2C")]
	public XWiget_GridBuilder builderRankRecord;

	[Token(Token = "0x40050F6")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView scrollView;

	[Token(Token = "0x40050F7")]
	[FieldOffset(Offset = "0x34")]
	private ProtoInfoManager_GameMode protoGameMode;

	[Token(Token = "0x40050F8")]
	[FieldOffset(Offset = "0x38")]
	private XProtoInfoManager_BattleRecord protoBattleRecord;

	[Token(Token = "0x40050F9")]
	[FieldOffset(Offset = "0x3C")]
	private XMyInfo myInfo;

	[Token(Token = "0x600726D")]
	[Address(RVA = "0x15BA8B4", Offset = "0x15BA8B4", VA = "0x15BA8B4")]
	public XWidget_BattleRecord()
	{
	}

	[Token(Token = "0x600726E")]
	[Address(RVA = "0x15BA960", Offset = "0x15BA960", VA = "0x15BA960")]
	public void Show(XMyInfo myinfo, ProtoInfoManager_GameMode protoGameMode, XProtoInfoManager_BattleRecord protoBattleRecord)
	{
	}

	[Token(Token = "0x600726F")]
	[Address(RVA = "0x15BA9D4", Offset = "0x15BA9D4", VA = "0x15BA9D4")]
	private void Build(XMyInfo myinfo, ProtoInfoManager_GameMode protoGameMode, XProtoInfoManager_BattleRecord protoBattleRecord)
	{
	}

	[Token(Token = "0x6007270")]
	[Address(RVA = "0x15BAB4C", Offset = "0x15BAB4C", VA = "0x15BAB4C")]
	private void BuildGameTypeList(List<int> order)
	{
	}

	[Token(Token = "0x6007271")]
	[Address(RVA = "0x15BAF98", Offset = "0x15BAF98", VA = "0x15BAF98")]
	private void ChangeSelectGameMode(bool toggle, int viewInfoId)
	{
	}

	[Token(Token = "0x6007272")]
	[Address(RVA = "0x15BB2E0", Offset = "0x15BB2E0", VA = "0x15BB2E0")]
	private void ChangeBattleRecord(XMyInfo myinfo, int viewInfoId)
	{
	}

	[Token(Token = "0x6007273")]
	[Address(RVA = "0x15BB614", Offset = "0x15BB614", VA = "0x15BB614")]
	private void BuildRecord(XBattleRecord_ViewInfo info, GameRecord record)
	{
	}

	[Token(Token = "0x6007274")]
	[Address(RVA = "0x15BBA00", Offset = "0x15BBA00", VA = "0x15BBA00")]
	private void BuildRecord(XWiget_GridBuilder builder, List<GameRecordType> recordList, GameRecord record)
	{
	}

	[Token(Token = "0x6007275")]
	[Address(RVA = "0x15BBC8C", Offset = "0x15BBC8C", VA = "0x15BBC8C")]
	private string GetRecordStringValue(GameRecord record, GameRecordType recordType)
	{
		return null;
	}

	[Token(Token = "0x6007276")]
	[Address(RVA = "0x15BBEB4", Offset = "0x15BBEB4", VA = "0x15BBEB4")]
	private void BuildLabelColor(XWiget_KeyValueLabel label, GameRecordType recordType)
	{
	}

	[Token(Token = "0x6007277")]
	[Address(RVA = "0x15BBDC4", Offset = "0x15BBDC4", VA = "0x15BBDC4")]
	private string GetLabelNumWoard(GameRecordType mode)
	{
		return null;
	}

	[Token(Token = "0x6007278")]
	[Address(RVA = "0x15BB670", Offset = "0x15BB670", VA = "0x15BB670")]
	private void SendGetGameRecord(MatchType matchType, XGameModeType gameMode)
	{
	}
}
