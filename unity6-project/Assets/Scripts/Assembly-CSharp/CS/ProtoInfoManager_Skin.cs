using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B69")]
	public class ProtoInfoManager_Skin : Dictionary<int, SkinInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6005312")]
		[Address(RVA = "0x21B75F0", Offset = "0x21B75F0", VA = "0x21B75F0")]
		public ProtoInfoManager_Skin()
		{
		}

		[Token(Token = "0x6005313")]
		[Address(RVA = "0x21B7674", Offset = "0x21B7674", VA = "0x21B7674", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6005314")]
		[Address(RVA = "0x21B7684", Offset = "0x21B7684", VA = "0x21B7684", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6005315")]
		[Address(RVA = "0x21B7688", Offset = "0x21B7688", VA = "0x21B7688", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6005316")]
		[Address(RVA = "0x21B77E4", Offset = "0x21B77E4", VA = "0x21B77E4", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6005317")]
		[Address(RVA = "0x21B7AFC", Offset = "0x21B7AFC", VA = "0x21B7AFC")]
		public SkinInfo GetSkinInfo(int nID)
		{
			return null;
		}

		[Token(Token = "0x6005318")]
		[Address(RVA = "0x21B7BCC", Offset = "0x21B7BCC", VA = "0x21B7BCC")]
		public SkinInfo GetSkinInfoByCardID(int conditionItemID)
		{
			return null;
		}

		[Token(Token = "0x6005319")]
		[Address(RVA = "0x21B7D30", Offset = "0x21B7D30", VA = "0x21B7D30", Slot = "46")]
		public virtual void CookingList(List<SkinInfo> list)
		{
		}
	}
}
