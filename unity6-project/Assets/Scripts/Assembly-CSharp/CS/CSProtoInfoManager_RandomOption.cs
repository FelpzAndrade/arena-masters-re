using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B37")]
	public class CSProtoInfoManager_RandomOption : Dictionary<int, CSRandomOptionData>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003795")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<EquipmentSlot, List<CSRandomOptionData>> RandomOptionDictionary;

		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<EquipmentSlot, Dictionary<int, CSRandomOptionData>> minDictionary;

		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x3C")]
		private Dictionary<EquipmentSlot, Dictionary<int, CSRandomOptionData>> maxDictionary;

		[Token(Token = "0x6005219")]
		[Address(RVA = "0x1CBC170", Offset = "0x1CBC170", VA = "0x1CBC170")]
		public CSProtoInfoManager_RandomOption()
		{
		}

		[Token(Token = "0x600521A")]
		[Address(RVA = "0x1CBC274", Offset = "0x1CBC274", VA = "0x1CBC274", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x600521B")]
		[Address(RVA = "0x1CBC284", Offset = "0x1CBC284", VA = "0x1CBC284", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x600521C")]
		[Address(RVA = "0x1CBC288", Offset = "0x1CBC288", VA = "0x1CBC288", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x600521D")]
		[Address(RVA = "0x1CBCA44", Offset = "0x1CBCA44", VA = "0x1CBCA44", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x600521E")]
		[Address(RVA = "0x1CBCD1C", Offset = "0x1CBCD1C", VA = "0x1CBCD1C")]
		protected void CookingList(List<CSRandomOptionData> dataList)
		{
		}

		[Token(Token = "0x600521F")]
		[Address(RVA = "0x1CBCFE8", Offset = "0x1CBCFE8", VA = "0x1CBCFE8")]
		public List<CSRandomOptionData> GetRandomOptionList(EquipmentSlot slot)
		{
			return null;
		}

		[Token(Token = "0x6005220")]
		[Address(RVA = "0x1CBD104", Offset = "0x1CBD104", VA = "0x1CBD104")]
		public Dictionary<int, CSRandomOptionData> GetRandomOptionMaxList(EquipmentSlot slot)
		{
			return null;
		}

		[Token(Token = "0x6005221")]
		[Address(RVA = "0x1CBD1E4", Offset = "0x1CBD1E4", VA = "0x1CBD1E4")]
		public Dictionary<int, CSRandomOptionData> GetRandomOptionMinList(EquipmentSlot slot)
		{
			return null;
		}
	}
}
