using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AF6")]
	public class CSProtoInfoManager_GameModeReward : Dictionary<int, List<CSGameModeRewardInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x1FC1F78", Offset = "0x1FC1F78", VA = "0x1FC1F78")]
		public CSProtoInfoManager_GameModeReward()
		{
		}

		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x1FDD828", Offset = "0x1FDD828", VA = "0x1FDD828", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60050E2")]
		[Address(RVA = "0x1FDD838", Offset = "0x1FDD838", VA = "0x1FDD838", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60050E3")]
		[Address(RVA = "0x1FDD83C", Offset = "0x1FDD83C", VA = "0x1FDD83C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60050E4")]
		[Address(RVA = "0x1FDD844", Offset = "0x1FDD844", VA = "0x1FDD844", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x1FDDE50", Offset = "0x1FDDE50", VA = "0x1FDDE50")]
		public CSGameModeRewardInfo GetGameModeRewardInfo_ByTeamLevel(int groupId, int teamLevel)
		{
			return null;
		}
	}
}
