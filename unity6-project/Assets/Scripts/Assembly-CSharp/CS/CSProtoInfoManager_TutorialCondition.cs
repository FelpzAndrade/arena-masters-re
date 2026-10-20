using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B8B")]
	public class CSProtoInfoManager_TutorialCondition : Dictionary<int, TutorialConditionInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000B8C")]
		private sealed class _003CGetInfo_003Ec__AnonStorey15B
		{
			[Token(Token = "0x4003A74")]
			[FieldOffset(Offset = "0x8")]
			internal TutorialType type;

			[Token(Token = "0x6005387")]
			[Address(RVA = "0x1CCA6A0", Offset = "0x1CCA6A0", VA = "0x1CCA6A0")]
			public _003CGetInfo_003Ec__AnonStorey15B()
			{
			}

			[Token(Token = "0x6005388")]
			[Address(RVA = "0x1CCA834", Offset = "0x1CCA834", VA = "0x1CCA834")]
			internal bool _003C_003Em__215(TutorialConditionInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003A72")]
		[FieldOffset(Offset = "0x34")]
		private List<TutorialType> nextTutoImmediateCommitTypes;

		[Token(Token = "0x4003A73")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, List<TutorialConditionInfo>> enterConditionDic;

		[Token(Token = "0x600537E")]
		[Address(RVA = "0x1CC9880", Offset = "0x1CC9880", VA = "0x1CC9880")]
		public CSProtoInfoManager_TutorialCondition()
		{
		}

		[Token(Token = "0x600537F")]
		[Address(RVA = "0x1CC996C", Offset = "0x1CC996C", VA = "0x1CC996C", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005380")]
		[Address(RVA = "0x1CC997C", Offset = "0x1CC997C", VA = "0x1CC997C", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005381")]
		[Address(RVA = "0x1CC9980", Offset = "0x1CC9980", VA = "0x1CC9980", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005382")]
		[Address(RVA = "0x1CC9B70", Offset = "0x1CC9B70", VA = "0x1CC9B70", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005383")]
		[Address(RVA = "0x1CCA234", Offset = "0x1CCA234", VA = "0x1CCA234")]
		public List<TutorialConditionInfo> GetEnterableTutorialConditionList(string condition)
		{
			return null;
		}

		[Token(Token = "0x6005384")]
		[Address(RVA = "0x1CCA32C", Offset = "0x1CCA32C", VA = "0x1CCA32C")]
		public TutorialConditionInfo GetInfo(TutorialType type)
		{
			return null;
		}

		[Token(Token = "0x6005385")]
		[Address(RVA = "0x1CCA6A8", Offset = "0x1CCA6A8", VA = "0x1CCA6A8")]
		public TutorialConditionInfo GetPrevConditionTutorialInfo(int tutorialID)
		{
			return null;
		}

		[Token(Token = "0x6005386")]
		[Address(RVA = "0x1CCA78C", Offset = "0x1CCA78C", VA = "0x1CCA78C")]
		public List<TutorialType> GetNextTutoImmediatlyCommitTypes()
		{
			return null;
		}
	}
}
