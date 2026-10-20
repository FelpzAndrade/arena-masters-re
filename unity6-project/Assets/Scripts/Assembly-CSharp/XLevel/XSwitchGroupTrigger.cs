using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000716")]
	public class XSwitchGroupTrigger : XTimeTrigger
	{
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x20")]
		public List<string> switchGroupEntity;

		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x2033044", Offset = "0x2033044", VA = "0x2033044")]
		public XSwitchGroupTrigger()
		{
		}

		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x20330F0", Offset = "0x20330F0", VA = "0x20330F0", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x203317C", Offset = "0x203317C", VA = "0x203317C", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
