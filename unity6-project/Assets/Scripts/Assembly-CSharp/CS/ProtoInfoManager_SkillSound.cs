using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000B62")]
	public class ProtoInfoManager_SkillSound : Dictionary<int, List<SkillSoundInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x21B3AB0", Offset = "0x21B3AB0", VA = "0x21B3AB0")]
		public ProtoInfoManager_SkillSound()
		{
		}

		[Token(Token = "0x60052F2")]
		[Address(RVA = "0x21B3B34", Offset = "0x21B3B34", VA = "0x21B3B34", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60052F3")]
		[Address(RVA = "0x21B3B44", Offset = "0x21B3B44", VA = "0x21B3B44", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60052F4")]
		[Address(RVA = "0x21B3B48", Offset = "0x21B3B48", VA = "0x21B3B48", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x21B4020", Offset = "0x21B4020", VA = "0x21B4020")]
		public void LoadFromServer(JToken source)
		{
		}

		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x21B40B4", Offset = "0x21B40B4", VA = "0x21B40B4", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}
	}
}
