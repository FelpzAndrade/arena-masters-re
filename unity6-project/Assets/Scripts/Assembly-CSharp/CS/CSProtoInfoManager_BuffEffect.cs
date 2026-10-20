using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A9B")]
	public class CSProtoInfoManager_BuffEffect : Dictionary<int, List<CSBuffEffectInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x1FC14D4", Offset = "0x1FC14D4", VA = "0x1FC14D4")]
		public CSProtoInfoManager_BuffEffect()
		{
		}

		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x1FC4D84", Offset = "0x1FC4D84", VA = "0x1FC4D84", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x1FC4D94", Offset = "0x1FC4D94", VA = "0x1FC4D94", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x1FC4D98", Offset = "0x1FC4D98", VA = "0x1FC4D98", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x1FC4FE0", Offset = "0x1FC4FE0", VA = "0x1FC4FE0", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}
	}
}
