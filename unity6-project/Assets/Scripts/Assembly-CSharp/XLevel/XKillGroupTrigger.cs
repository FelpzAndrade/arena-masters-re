using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000711")]
	public class XKillGroupTrigger : XTimeTrigger
	{
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x20")]
		public string targetEntity;

		[Token(Token = "0x6003AA1")]
		[Address(RVA = "0x202A96C", Offset = "0x202A96C", VA = "0x202A96C")]
		public XKillGroupTrigger()
		{
		}

		[Token(Token = "0x6003AA2")]
		[Address(RVA = "0x202A974", Offset = "0x202A974", VA = "0x202A974", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AA3")]
		[Address(RVA = "0x202AA00", Offset = "0x202AA00", VA = "0x202AA00", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
