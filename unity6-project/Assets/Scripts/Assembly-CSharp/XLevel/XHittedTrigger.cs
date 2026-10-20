using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200070D")]
	public class XHittedTrigger : XTimeTrigger
	{
		[Token(Token = "0x4002181")]
		[FieldOffset(Offset = "0x20")]
		public string targetTag;

		[Token(Token = "0x4002182")]
		[FieldOffset(Offset = "0x24")]
		public int hittedCount;

		[Token(Token = "0x6003A95")]
		[Address(RVA = "0x202A55C", Offset = "0x202A55C", VA = "0x202A55C")]
		public XHittedTrigger()
		{
		}

		[Token(Token = "0x6003A96")]
		[Address(RVA = "0x202A564", Offset = "0x202A564", VA = "0x202A564", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A97")]
		[Address(RVA = "0x202A5F0", Offset = "0x202A5F0", VA = "0x202A5F0", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
