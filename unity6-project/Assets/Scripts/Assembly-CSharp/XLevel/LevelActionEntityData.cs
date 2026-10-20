using System;
using CS;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000723")]
	public class LevelActionEntityData : LevelSpawnableData
	{
		[Token(Token = "0x40021D1")]
		[FieldOffset(Offset = "0x20")]
		public ActionType levelAction;

		[Token(Token = "0x40021D2")]
		[FieldOffset(Offset = "0x24")]
		public string actorTag;

		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x28")]
		public string followTargetTag;

		[Token(Token = "0x40021D4")]
		[FieldOffset(Offset = "0x2C")]
		public string words;

		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x30")]
		public string arg;

		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0x34")]
		public XTeamEnum targetTeam;

		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0x38")]
		public GameUIOption[] optionList;

		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0x3C")]
		public XKeyEnum useInput;

		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x201D464", Offset = "0x201D464", VA = "0x201D464")]
		public LevelActionEntityData()
		{
		}

		[Token(Token = "0x6003AD0")]
		[Address(RVA = "0x201D534", Offset = "0x201D534", VA = "0x201D534", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x201D5F0", Offset = "0x201D5F0", VA = "0x201D5F0", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
