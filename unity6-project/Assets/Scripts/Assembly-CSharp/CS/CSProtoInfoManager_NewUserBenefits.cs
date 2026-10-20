using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B14")]
	public class CSProtoInfoManager_NewUserBenefits : Dictionary<string, CSNewUserBenefitInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x34")]
		private List<CSNewUserBenefitInfo> m_Benefits;

		[Token(Token = "0x6005159")]
		[Address(RVA = "0x1CB6B98", Offset = "0x1CB6B98", VA = "0x1CB6B98")]
		public CSProtoInfoManager_NewUserBenefits()
		{
		}

		[Token(Token = "0x600515A")]
		[Address(RVA = "0x1CB6C50", Offset = "0x1CB6C50", VA = "0x1CB6C50", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x600515B")]
		[Address(RVA = "0x1CB6C60", Offset = "0x1CB6C60", VA = "0x1CB6C60", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x600515C")]
		[Address(RVA = "0x1CB6C64", Offset = "0x1CB6C64", VA = "0x1CB6C64", Slot = "44")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x600515D")]
		[Address(RVA = "0x1CB7168", Offset = "0x1CB7168", VA = "0x1CB7168", Slot = "45")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x600515E")]
		[Address(RVA = "0x1CB7338", Offset = "0x1CB7338", VA = "0x1CB7338", Slot = "46")]
		protected virtual void AddContent(CSNewUserBenefitInfo benefit)
		{
		}

		[Token(Token = "0x600515F")]
		[Address(RVA = "0x1CB73D8", Offset = "0x1CB73D8", VA = "0x1CB73D8")]
		public List<CSNewUserBenefitInfo> GetBenefits()
		{
			return null;
		}
	}
}
