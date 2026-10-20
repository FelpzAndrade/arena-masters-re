using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B5F")]
	public class CSProtoInfoManager_SkillEffect : Dictionary<int, List<CSSkillEffectInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0x1CC40A0", Offset = "0x1CC40A0", VA = "0x1CC40A0")]
		public CSProtoInfoManager_SkillEffect()
		{
		}

		[Token(Token = "0x60052E9")]
		[Address(RVA = "0x1CC4124", Offset = "0x1CC4124", VA = "0x1CC4124", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60052EA")]
		[Address(RVA = "0x1CC4134", Offset = "0x1CC4134", VA = "0x1CC4134", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60052EB")]
		[Address(RVA = "0x1CC4138", Offset = "0x1CC4138", VA = "0x1CC4138", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60052EC")]
		[Address(RVA = "0x1CC4540", Offset = "0x1CC4540", VA = "0x1CC4540", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}
	}
}
