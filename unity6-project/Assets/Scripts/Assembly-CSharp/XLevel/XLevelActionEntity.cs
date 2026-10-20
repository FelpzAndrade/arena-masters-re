using CS;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000722")]
	public class XLevelActionEntity : XLevelSpawnable
	{
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x10")]
		public ActionType levelAction;

		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x14")]
		public string actorTag;

		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x18")]
		public string followTargetTag;

		[Token(Token = "0x40021CC")]
		[FieldOffset(Offset = "0x1C")]
		public string words;

		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x20")]
		public XTeamEnum targetTeam;

		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x24")]
		public string arg;

		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x28")]
		public GameUIOption[] option;

		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0x2C")]
		public XKeyEnum useInput;

		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x202AC8C", Offset = "0x202AC8C", VA = "0x202AC8C")]
		public XLevelActionEntity()
		{
		}

		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x202ACA4", Offset = "0x202ACA4", VA = "0x202ACA4", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x202AD38", Offset = "0x202AD38", VA = "0x202AD38", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
