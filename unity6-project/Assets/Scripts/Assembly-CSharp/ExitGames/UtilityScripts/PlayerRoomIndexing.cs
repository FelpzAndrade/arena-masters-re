using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon;

namespace ExitGames.UtilityScripts
{
	[Token(Token = "0x200030D")]
	public class PlayerRoomIndexing : PunBehaviour
	{
		[Token(Token = "0x200030E")]
		public delegate void RoomIndexingChanged();

		[Token(Token = "0x4001024")]
		public const string RoomPlayerIndexedProp = "PlayerIndexes";

		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x0")]
		public static PlayerRoomIndexing instance;

		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x10")]
		public RoomIndexingChanged OnRoomIndexingChanged;

		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x14")]
		private int[] _playerIds;

		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x18")]
		private object _indexes;

		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x1C")]
		private Dictionary<int, int> _indexesLUT;

		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x20")]
		private List<bool> _indexesPool;

		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x24")]
		private PhotonPlayer _p;

		[Token(Token = "0x17000488")]
		public int[] PlayerIds
		{
			[Token(Token = "0x6001A5A")]
			[Address(RVA = "0x1E7D95C", Offset = "0x1E7D95C", VA = "0x1E7D95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x1E7D954", Offset = "0x1E7D954", VA = "0x1E7D954")]
		public PlayerRoomIndexing()
		{
		}

		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x1E7D964", Offset = "0x1E7D964", VA = "0x1E7D964")]
		public void Awake()
		{
		}

		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x1E7DE58", Offset = "0x1E7DE58", VA = "0x1E7DE58", Slot = "46")]
		public override void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x1E7EA88", Offset = "0x1E7EA88", VA = "0x1E7EA88", Slot = "34")]
		public override void OnLeftRoom()
		{
		}

		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x1E7EA8C", Offset = "0x1E7EA8C", VA = "0x1E7EA8C", Slot = "47")]
		public override void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
		{
		}

		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x1E7EB48", Offset = "0x1E7EB48", VA = "0x1E7EB48", Slot = "48")]
		public override void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
		{
		}

		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x1E7EE7C", Offset = "0x1E7EE7C", VA = "0x1E7EE7C", Slot = "52")]
		public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x1E7EF38", Offset = "0x1E7EF38", VA = "0x1E7EF38", Slot = "35")]
		public override void OnMasterClientSwitched(PhotonPlayer newMasterClient)
		{
		}

		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x1E7EFF0", Offset = "0x1E7EFF0", VA = "0x1E7EFF0")]
		public int GetRoomIndex(PhotonPlayer player)
		{
			return default(int);
		}

		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x1E7DAF8", Offset = "0x1E7DAF8", VA = "0x1E7DAF8")]
		private void SanitizeIndexing(bool forceIndexing = false)
		{
		}

		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x1E7E5A8", Offset = "0x1E7E5A8", VA = "0x1E7E5A8")]
		private void RefreshData()
		{
		}

		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x1E7DF58", Offset = "0x1E7DF58", VA = "0x1E7DF58")]
		private void AssignIndex(PhotonPlayer player)
		{
		}

		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x1E7EC04", Offset = "0x1E7EC04", VA = "0x1E7EC04")]
		private void UnAssignIndex(PhotonPlayer player)
		{
		}
	}
}
