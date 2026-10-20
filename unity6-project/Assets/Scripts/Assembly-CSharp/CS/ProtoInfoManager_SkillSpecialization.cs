using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B66")]
	public class ProtoInfoManager_SkillSpecialization : Dictionary<TripleKey, SkillSpecializationInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003973")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<int, List<int>> groupList;

		[Token(Token = "0x4003974")]
		[FieldOffset(Offset = "0x0")]
		private static Func<FieldInfo, string> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x60052FC")]
		[Address(RVA = "0x21B46E8", Offset = "0x21B46E8", VA = "0x21B46E8")]
		public ProtoInfoManager_SkillSpecialization()
		{
		}

		[Token(Token = "0x60052FD")]
		[Address(RVA = "0x21B47A0", Offset = "0x21B47A0", VA = "0x21B47A0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60052FE")]
		[Address(RVA = "0x21B47A4", Offset = "0x21B47A4", VA = "0x21B47A4", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60052FF")]
		[Address(RVA = "0x21B4A04", Offset = "0x21B4A04", VA = "0x21B4A04")]
		private void CookTargetID(SkillSpecializationInfo skillSpecializationInfoInfo)
		{
		}

		[Token(Token = "0x6005300")]
		[Address(RVA = "0x21B4C88", Offset = "0x21B4C88", VA = "0x21B4C88", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005301")]
		[Address(RVA = "0x21B4C98", Offset = "0x21B4C98", VA = "0x21B4C98", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005302")]
		[Address(RVA = "0x21B5B50", Offset = "0x21B5B50", VA = "0x21B5B50")]
		private void ParseGrowth(CSFileLoaderBase loader)
		{
		}

		[Token(Token = "0x6005303")]
		[Address(RVA = "0x21B6388", Offset = "0x21B6388", VA = "0x21B6388")]
		public SkillSpecializationInfo GetSpecializeInfo(int skillID, int group_id, int level)
		{
			return null;
		}

		[Token(Token = "0x6005304")]
		[Address(RVA = "0x21B6464", Offset = "0x21B6464", VA = "0x21B6464")]
		public List<int> GetSpecializeGroup(int skill_id)
		{
			return null;
		}

		[Token(Token = "0x6005305")]
		[Address(RVA = "0x21B651C", Offset = "0x21B651C", VA = "0x21B651C")]
		public void MergeTotalSpecializeStatusGrowth_Skill(CharStatus status, CSSkillInfo skillInfo, SkillSpecialized skillSpecialized)
		{
		}

		[Token(Token = "0x6005306")]
		[Address(RVA = "0x21B6A4C", Offset = "0x21B6A4C", VA = "0x21B6A4C")]
		public void MergeTotalSpecializeStatusGrowth_Buff(CharStatus status, CSSkillInfo skillInfo, CSBuffInfo buffInfo, SkillSpecialized skillSpecialized, float multiplier = 1f)
		{
		}

		[Token(Token = "0x6005307")]
		[Address(RVA = "0x21B6FF8", Offset = "0x21B6FF8", VA = "0x21B6FF8")]
		public float GetTotalDamageRatio(CSSkillInfo skillInfo, SkillSpecialized skillSpecialized, SpecializeType specializeType)
		{
			return default(float);
		}

		[Token(Token = "0x6005308")]
		[Address(RVA = "0x21B7598", Offset = "0x21B7598", VA = "0x21B7598")]
		private static string _003CParseGrowth_003Em__212(FieldInfo field)
		{
			return null;
		}
	}
}
