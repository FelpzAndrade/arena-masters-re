using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AA7")]
	public class CSProtoInfoManager_Character : Dictionary<int, CSCharacterInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003211")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<CSCharacterSkillInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x1FC1558", Offset = "0x1FC1558", VA = "0x1FC1558")]
		public CSProtoInfoManager_Character()
		{
		}

		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x1FC55A8", Offset = "0x1FC55A8", VA = "0x1FC55A8", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E80")]
		[Address(RVA = "0x1FC55B8", Offset = "0x1FC55B8", VA = "0x1FC55B8", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x1FC55BC", Offset = "0x1FC55BC", VA = "0x1FC55BC", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E82")]
		[Address(RVA = "0x1FC5BAC", Offset = "0x1FC5BAC", VA = "0x1FC5BAC", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E83")]
		[Address(RVA = "0x1FC622C", Offset = "0x1FC622C", VA = "0x1FC622C")]
		private bool Cook_SkillInfoImpl(CSProtoInfoManagers protos, int id, ref CSSkillInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E84")]
		[Address(RVA = "0x1FC643C", Offset = "0x1FC643C", VA = "0x1FC643C")]
		private bool Cook_BuffInfoImpl(CSProtoInfoManagers protos, int id, ref CSBuffInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E85")]
		[Address(RVA = "0x1FC5754", Offset = "0x1FC5754", VA = "0x1FC5754")]
		private bool CookSkillInfo(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E86")]
		[Address(RVA = "0x1FC696C", Offset = "0x1FC696C", VA = "0x1FC696C")]
		private void CookUpgradableAndCombatSkillInfos(CSCharacterInfo characterInfo, CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E87")]
		[Address(RVA = "0x1FC6844", Offset = "0x1FC6844", VA = "0x1FC6844")]
		private void CookPassiveSkillInfos(CSCharacterInfo characterInfo)
		{
		}

		[Token(Token = "0x6004E88")]
		[Address(RVA = "0x1FC653C", Offset = "0x1FC653C", VA = "0x1FC653C")]
		private void CookUsableSkillInfos(CSCharacterInfo characterInfo, CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E89")]
		[Address(RVA = "0x1FC5A40", Offset = "0x1FC5A40", VA = "0x1FC5A40")]
		private bool CookPassiveBuffInfo(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x1FC6E10", Offset = "0x1FC6E10", VA = "0x1FC6E10")]
		public CSCharacterInfo GetCharacter(int id)
		{
			return null;
		}

		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x1FC6FC0", Offset = "0x1FC6FC0", VA = "0x1FC6FC0")]
		public List<CSCharacterInfo> GetPlayableCharacters(List<int> owned)
		{
			return null;
		}

		[Token(Token = "0x6004E8C")]
		[Address(RVA = "0x1FC7288", Offset = "0x1FC7288", VA = "0x1FC7288")]
		public List<CSCharacterInfo> GetPlayableNowOwnedCharacters(List<int> owned)
		{
			return null;
		}

		[Token(Token = "0x6004E8D")]
		[Address(RVA = "0x1FC749C", Offset = "0x1FC749C", VA = "0x1FC749C")]
		public List<CSCharacterInfo> GetNotOwnedPets(List<int> owned)
		{
			return null;
		}

		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0x1FC76B8", Offset = "0x1FC76B8", VA = "0x1FC76B8")]
		public List<CSCharacterInfo> GetPets()
		{
			return null;
		}

		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0x1FC7890", Offset = "0x1FC7890", VA = "0x1FC7890")]
		private static bool _003CCookUpgradableAndCombatSkillInfos_003Em__A2(CSCharacterSkillInfo skill)
		{
			return default(bool);
		}
	}
}
