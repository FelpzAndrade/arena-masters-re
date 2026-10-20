using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20003E4")]
public class XChattingManager
{
	[Token(Token = "0x20003E5")]
	private sealed class _003CLoadChattingMessage_003Ec__AnonStoreyED
	{
		[Token(Token = "0x400138F")]
		[FieldOffset(Offset = "0x8")]
		internal Action<List<CSChattingMessage>> fncCallback;

		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0xC")]
		internal XChattingManager _003C_003Ef__this;

		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x1AC5010", Offset = "0x1AC5010", VA = "0x1AC5010")]
		public _003CLoadChattingMessage_003Ec__AnonStoreyED()
		{
		}

		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x1AC5340", Offset = "0x1AC5340", VA = "0x1AC5340")]
		internal void _003C_003Em__A4(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x8")]
	private long GetLastUtcTimeMS__BackingField;

	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x10")]
	private List<CSChattingMessage> liMsg__BackingField;

	[Token(Token = "0x400138E")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000566")]
	public long GetLastUtcTimeMS
	{
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x1AC4D20", Offset = "0x1AC4D20", VA = "0x1AC4D20")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x1AC4D08", Offset = "0x1AC4D08", VA = "0x1AC4D08")]
		set
		{
		}
	}

	[Token(Token = "0x17000567")]
	public List<CSChattingMessage> liMsg
	{
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x1AC4D28", Offset = "0x1AC4D28", VA = "0x1AC4D28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x1AC4D18", Offset = "0x1AC4D18", VA = "0x1AC4D18")]
		private set
		{
		}
	}

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x1AC4C50", Offset = "0x1AC4C50", VA = "0x1AC4C50")]
	public XChattingManager()
	{
	}

	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x1AC4D30", Offset = "0x1AC4D30", VA = "0x1AC4D30")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x1AC4D40", Offset = "0x1AC4D40", VA = "0x1AC4D40")]
	public bool LoadChattingMessage(string _chattingChannel, Action<List<CSChattingMessage>> fncCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x1AC5018", Offset = "0x1AC5018", VA = "0x1AC5018")]
	public void WriteChattingMessage(string _chattingChannel, XChatObject chatObj)
	{
	}

	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x1AC533C", Offset = "0x1AC533C", VA = "0x1AC533C")]
	private static void _003CWriteChattingMessage_003Em__A5(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
