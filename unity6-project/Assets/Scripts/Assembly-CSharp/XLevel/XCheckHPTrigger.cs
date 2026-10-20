using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000702")]
	public class XCheckHPTrigger : XTimeTrigger
	{
		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x20")]
		public string targetTag;

		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0x24")]
		public int hp;

		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x28")]
		public CheckHPTriggerData.Condition condition;

		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0x2029714", Offset = "0x2029714", VA = "0x2029714")]
		public XCheckHPTrigger()
		{
		}

		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x202971C", Offset = "0x202971C", VA = "0x202971C", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x20297A8", Offset = "0x20297A8", VA = "0x20297A8", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
