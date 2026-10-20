using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B5A")]
	public class CSProtoInfoManager_Skill : Dictionary<int, CSSkillInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x1CC2240", Offset = "0x1CC2240", VA = "0x1CC2240")]
		public CSProtoInfoManager_Skill()
		{
		}

		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x1CC22C4", Offset = "0x1CC22C4", VA = "0x1CC22C4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x1CC22D4", Offset = "0x1CC22D4", VA = "0x1CC22D4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x1CC22D8", Offset = "0x1CC22D8", VA = "0x1CC22D8", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x1CC336C", Offset = "0x1CC336C", VA = "0x1CC336C")]
		private void CookHitTime(CSSkillInfo skillInfo)
		{
		}

		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x1CC3848", Offset = "0x1CC3848", VA = "0x1CC3848")]
		private void CookBuff(CSSkillInfo skillInfo)
		{
		}

		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x1CC39D0", Offset = "0x1CC39D0", VA = "0x1CC39D0")]
		private void CookMetaProperty(CSSkillInfo skillInfo)
		{
		}

		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x1CC3A80", Offset = "0x1CC3A80", VA = "0x1CC3A80")]
		public CSSkillInfo GetInfo(int skillId)
		{
			return null;
		}

		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x1CC3C44", Offset = "0x1CC3C44", VA = "0x1CC3C44", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x1CC3FFC", Offset = "0x1CC3FFC", VA = "0x1CC3FFC")]
		private void _003CLoadFromLocalFile_003Em__211(CSSkillInfo e)
		{
		}
	}
}
