using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AFB")]
	public class CSProtoInfoManager_IronsMission : Dictionary<int, IronsMission>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40035EB")]
		public const string ServerFilePath = "quest_irons.xml";

		[Token(Token = "0x40035EC")]
		public const string ClientFilePath = "XML/quest_irons_xml";

		[Token(Token = "0x60050F1")]
		[Address(RVA = "0x1FC13CC", Offset = "0x1FC13CC", VA = "0x1FC13CC")]
		public CSProtoInfoManager_IronsMission()
		{
		}

		[Token(Token = "0x60050F2")]
		[Address(RVA = "0x1FDE004", Offset = "0x1FDE004", VA = "0x1FDE004", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60050F3")]
		[Address(RVA = "0x1FDE014", Offset = "0x1FDE014", VA = "0x1FDE014", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x1FDE018", Offset = "0x1FDE018", VA = "0x1FDE018", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x1FDE020", Offset = "0x1FDE020", VA = "0x1FDE020", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x1FDE2F8", Offset = "0x1FDE2F8", VA = "0x1FDE2F8")]
		public void RefreshList(List<IronsMission> list)
		{
		}
	}
}
