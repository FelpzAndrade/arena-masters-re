using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

namespace DTOPhoton
{
	[Token(Token = "0x200083B")]
	public class DTOGameSession
	{
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x8")]
		public byte winTeam;

		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0xC")]
		public MatchType matchType;

		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x10")]
		public XGameModeType gameMode;

		[Token(Token = "0x40023A9")]
		[FieldOffset(Offset = "0x14")]
		public RoomType roomType;

		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x18")]
		public int modeInstanceID;

		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x1C")]
		public int eventModeID;

		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x20")]
		public string mvpUserName;

		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<byte, HashSet<string>> TeamList__BackingField;

		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> PlayerAccountID__BackingField;

		[Token(Token = "0x17000934")]
		public Dictionary<byte, HashSet<string>> TeamList
		{
			[Token(Token = "0x60041EA")]
			[Address(RVA = "0x1E66094", Offset = "0x1E66094", VA = "0x1E66094")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041EB")]
			[Address(RVA = "0x1E66084", Offset = "0x1E66084", VA = "0x1E66084")]
			private set
			{
			}
		}

		[Token(Token = "0x17000935")]
		public Dictionary<string, string> PlayerAccountID
		{
			[Token(Token = "0x60041EC")]
			[Address(RVA = "0x1E6609C", Offset = "0x1E6609C", VA = "0x1E6609C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041ED")]
			[Address(RVA = "0x1E6608C", Offset = "0x1E6608C", VA = "0x1E6608C")]
			private set
			{
			}
		}

		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x1E65FA4", Offset = "0x1E65FA4", VA = "0x1E65FA4")]
		public DTOGameSession()
		{
		}

		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x1E660A4", Offset = "0x1E660A4", VA = "0x1E660A4")]
		public void AddTeamPlayer(byte _team, string _playerName)
		{
		}

		[Token(Token = "0x60041EF")]
		[Address(RVA = "0x1E66208", Offset = "0x1E66208", VA = "0x1E66208")]
		public byte GetTeam(string name)
		{
			return default(byte);
		}

		[Token(Token = "0x60041F0")]
		[Address(RVA = "0x1E663AC", Offset = "0x1E663AC", VA = "0x1E663AC")]
		public HashSet<string> GetTeamList(string name)
		{
			return null;
		}

		[Token(Token = "0x60041F1")]
		[Address(RVA = "0x1E6658C", Offset = "0x1E6658C", VA = "0x1E6658C")]
		public HashSet<string> GetOtherTeamList(string name)
		{
			return null;
		}

		[Token(Token = "0x60041F2")]
		[Address(RVA = "0x1E66888", Offset = "0x1E66888", VA = "0x1E66888")]
		public List<string> GetAllPlayer()
		{
			return null;
		}

		[Token(Token = "0x60041F3")]
		[Address(RVA = "0x1E66B18", Offset = "0x1E66B18", VA = "0x1E66B18")]
		public CSWinlose AnalyzeWinLose(string name)
		{
			return default(CSWinlose);
		}

		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x1E66B64", Offset = "0x1E66B64", VA = "0x1E66B64")]
		public XTeamEnum GetPlayerTeamEnum(string name)
		{
			return default(XTeamEnum);
		}

		[Token(Token = "0x60041F5")]
		[Address(RVA = "0x1E66B74", Offset = "0x1E66B74", VA = "0x1E66B74")]
		public bool TryGetTeamPlayerList(XTeamEnum team, out List<string> liTemaPlayer)
		{
			liTemaPlayer = default;
			return default(bool);
		}
	}
}
