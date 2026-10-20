using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200070B")]
	public class XCombatTrigger : XTimeTrigger
	{
		[Token(Token = "0x400217F")]
		[FieldOffset(Offset = "0x20")]
		public string targetEntity;

		[Token(Token = "0x6003A8F")]
		[Address(RVA = "0x202A0C0", Offset = "0x202A0C0", VA = "0x202A0C0")]
		public XCombatTrigger()
		{
		}

		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x202A0C8", Offset = "0x202A0C8", VA = "0x202A0C8", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x202A154", Offset = "0x202A154", VA = "0x202A154", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
