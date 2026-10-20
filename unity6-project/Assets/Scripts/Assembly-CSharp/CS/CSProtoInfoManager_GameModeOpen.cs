using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AF3")]
	public class CSProtoInfoManager_GameModeOpen : Dictionary<int, CSGameOpenModeInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0x34")]
		public List<CSGameOpenModeInfo> normalOpenModeInfo;

		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0x38")]
		public List<CSGameOpenModeInfo> rankOpenModeInfo;

		[Token(Token = "0x60050CF")]
		[Address(RVA = "0x1FC1D84", Offset = "0x1FC1D84", VA = "0x1FC1D84")]
		public CSProtoInfoManager_GameModeOpen()
		{
		}

		[Token(Token = "0x60050D0")]
		[Address(RVA = "0x1FDC158", Offset = "0x1FDC158", VA = "0x1FDC158", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60050D1")]
		[Address(RVA = "0x1FDC168", Offset = "0x1FDC168", VA = "0x1FDC168", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60050D2")]
		[Address(RVA = "0x1FDC16C", Offset = "0x1FDC16C", VA = "0x1FDC16C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60050D3")]
		[Address(RVA = "0x1FDC5F8", Offset = "0x1FDC5F8", VA = "0x1FDC5F8", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60050D4")]
		[Address(RVA = "0x1FDC968", Offset = "0x1FDC968", VA = "0x1FDC968")]
		private List<CSGameOpenModeInfo> SetSearchTargetList(bool isRank)
		{
			return null;
		}

		[Token(Token = "0x60050D5")]
		[Address(RVA = "0x1FDC97C", Offset = "0x1FDC97C", VA = "0x1FDC97C")]
		public bool IsAlwaysOpenMode(XGameModeType modeType, bool isRank)
		{
			return default(bool);
		}

		[Token(Token = "0x60050D6")]
		[Address(RVA = "0x1FDCA88", Offset = "0x1FDCA88", VA = "0x1FDCA88")]
		public bool IsModeOpenTimeInfo(XGameModeType modeType, DateTime serverNowLocalTime, bool isRank)
		{
			return default(bool);
		}

		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x1FDCD04", Offset = "0x1FDCD04", VA = "0x1FDCD04")]
		public bool TryModeOpenTimeInfo(ProtoInfoManager_GameModeInstance gameModeInstance, DateTime serverNowLocalTime, bool isRank, out CSGameOpenModeInfo gameOpenModeInfo)
		{
			gameOpenModeInfo = default;
			return default(bool);
		}

		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x1FDD0FC", Offset = "0x1FDD0FC", VA = "0x1FDD0FC")]
		public bool TryNearestModeOpenTimeInfo(ProtoInfoManager_GameModeInstance gameModeInstance, DateTime serverNowLocalTime, bool isRank, out CSGameOpenModeInfo gameOpenModeInfo)
		{
			gameOpenModeInfo = default;
			return default(bool);
		}

		[Token(Token = "0x60050D9")]
		[Address(RVA = "0x1FDCE68", Offset = "0x1FDCE68", VA = "0x1FDCE68")]
		public bool TryModeOpenTimeInfo(XGameModeType modeType, DateTime serverNowLocalTime, bool isRank, out CSGameOpenModeInfo gameOpenModeInfo)
		{
			gameOpenModeInfo = default;
			return default(bool);
		}

		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x1FDD578", Offset = "0x1FDD578", VA = "0x1FDD578")]
		public bool IsNearestModeOpenTimeInfo(XGameModeType modeType, DateTime serverNowLocalTime, bool isRank)
		{
			return default(bool);
		}

		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x1FDD364", Offset = "0x1FDD364", VA = "0x1FDD364")]
		public bool TryNearestModeOpenTimeInfo(XGameModeType modeType, DateTime serverNowLocalTime, bool isRank, out CSGameOpenModeInfo gameOpenModeInfo)
		{
			gameOpenModeInfo = default;
			return default(bool);
		}

		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x1FDD784", Offset = "0x1FDD784", VA = "0x1FDD784")]
		private void _003CLoadFromLocalFile_003Em__203(CSGameOpenModeInfo e)
		{
		}
	}
}
