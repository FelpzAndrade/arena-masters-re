using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200070F")]
	public class XInputTrigger : XTimeTrigger
	{
		[Token(Token = "0x4002185")]
		[FieldOffset(Offset = "0x20")]
		public XKeyEnum inputKey;

		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x24")]
		public string actionEntity;

		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x202A7FC", Offset = "0x202A7FC", VA = "0x202A7FC")]
		public XInputTrigger()
		{
		}

		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x202A804", Offset = "0x202A804", VA = "0x202A804", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x202A890", Offset = "0x202A890", VA = "0x202A890", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
