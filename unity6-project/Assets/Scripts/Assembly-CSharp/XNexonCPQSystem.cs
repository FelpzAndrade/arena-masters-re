using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000BEE")]
public class XNexonCPQSystem
{
	[Token(Token = "0x2000BEF")]
	public class CPQCommand
	{
		[Token(Token = "0x4003C52")]
		[FieldOffset(Offset = "0x8")]
		public int QuestID;

		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0xC")]
		public string NPSN;

		[Token(Token = "0x4003C54")]
		[FieldOffset(Offset = "0x10")]
		public string AndroidID;

		[Token(Token = "0x600562C")]
		[Address(RVA = "0x1ED4A34", Offset = "0x1ED4A34", VA = "0x1ED4A34")]
		public CPQCommand(int questID, string npsn, string androidID)
		{
		}
	}

	[Token(Token = "0x2000BF0")]
	private sealed class _003CCpqComplete_003Ec__AnonStorey165
	{
		[Token(Token = "0x4003C55")]
		[FieldOffset(Offset = "0x8")]
		internal int questID;

		[Token(Token = "0x4003C56")]
		[FieldOffset(Offset = "0xC")]
		internal XNexonCPQSystem _003C_003Ef__this;

		[Token(Token = "0x600562D")]
		[Address(RVA = "0x1ED4A64", Offset = "0x1ED4A64", VA = "0x1ED4A64")]
		public _003CCpqComplete_003Ec__AnonStorey165()
		{
		}

		[Token(Token = "0x600562E")]
		[Address(RVA = "0x1ED4A6C", Offset = "0x1ED4A6C", VA = "0x1ED4A6C")]
		internal void _003C_003Em__22D(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4003C4F")]
	[FieldOffset(Offset = "0x8")]
	private Regulator regCpqCommandProcessor;

	[Token(Token = "0x4003C50")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, CPQCommand> dicCPQCompleteQuestID;

	[Token(Token = "0x4003C51")]
	[FieldOffset(Offset = "0x10")]
	private HashSet<int> setProcessingCPQCmd;

	[Token(Token = "0x6005627")]
	[Address(RVA = "0x1ED4408", Offset = "0x1ED4408", VA = "0x1ED4408")]
	public XNexonCPQSystem()
	{
	}

	[Token(Token = "0x6005628")]
	[Address(RVA = "0x1ED4524", Offset = "0x1ED4524", VA = "0x1ED4524")]
	public void UpdateCPQCompleteProcess()
	{
	}

	[Token(Token = "0x6005629")]
	[Address(RVA = "0x1ED42EC", Offset = "0x1ED42EC", VA = "0x1ED42EC")]
	public void AddCpqComplete(int questID, string npsn, string androidID)
	{
	}

	[Token(Token = "0x600562A")]
	[Address(RVA = "0x1ED47C4", Offset = "0x1ED47C4", VA = "0x1ED47C4")]
	public void CpqComplete(int questID, string npsn, string androidID)
	{
	}

	[Token(Token = "0x600562B")]
	[Address(RVA = "0x1ED3FDC", Offset = "0x1ED3FDC", VA = "0x1ED3FDC")]
	public bool IsNexonCPQUseAlbe(UserDataBase userData)
	{
		return default(bool);
	}
}
