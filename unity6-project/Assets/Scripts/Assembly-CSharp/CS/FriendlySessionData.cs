using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000961")]
	public class FriendlySessionData
	{
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x8")]
		private bool IsFriendlyMatch__BackingField;

		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0xC")]
		private string RoomName__BackingField;

		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x10")]
		private string Password__BackingField;

		[Token(Token = "0x17000A8D")]
		public bool IsFriendlyMatch
		{
			[Token(Token = "0x6004B67")]
			[Address(RVA = "0x2333BEC", Offset = "0x2333BEC", VA = "0x2333BEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B68")]
			[Address(RVA = "0x2333B94", Offset = "0x2333B94", VA = "0x2333B94")]
			set
			{
			}
		}

		[Token(Token = "0x17000A8E")]
		public string RoomName
		{
			[Token(Token = "0x6004B69")]
			[Address(RVA = "0x2333BF4", Offset = "0x2333BF4", VA = "0x2333BF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B6A")]
			[Address(RVA = "0x2333B9C", Offset = "0x2333B9C", VA = "0x2333B9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A8F")]
		public string Password
		{
			[Token(Token = "0x6004B6B")]
			[Address(RVA = "0x2333BFC", Offset = "0x2333BFC", VA = "0x2333BFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B6C")]
			[Address(RVA = "0x2333BA4", Offset = "0x2333BA4", VA = "0x2333BA4")]
			set
			{
			}
		}

		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x2333AA8", Offset = "0x2333AA8", VA = "0x2333AA8")]
		public FriendlySessionData()
		{
		}

		[Token(Token = "0x6004B66")]
		[Address(RVA = "0x2333BAC", Offset = "0x2333BAC", VA = "0x2333BAC")]
		public FriendlySessionData(bool isFriendlyMatch, string roomName = "", string password = "")
		{
		}

		[Token(Token = "0x6004B6D")]
		[Address(RVA = "0x2333BDC", Offset = "0x2333BDC", VA = "0x2333BDC")]
		public void SetData(bool isFriendlyMatch, string roomName = "", string password = "")
		{
		}
	}
}
