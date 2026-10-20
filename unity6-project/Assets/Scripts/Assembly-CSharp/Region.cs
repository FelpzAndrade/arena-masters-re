using Il2CppDummyDll;

[Token(Token = "0x20002DE")]
public class Region
{
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x8")]
	public CloudRegionCode Code;

	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0xC")]
	public string Cluster;

	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x10")]
	public string HostAndPort;

	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x14")]
	public int Ping;

	[Token(Token = "0x6001993")]
	[Address(RVA = "0x20EB33C", Offset = "0x20EB33C", VA = "0x20EB33C")]
	public Region(CloudRegionCode code)
	{
	}

	[Token(Token = "0x6001994")]
	[Address(RVA = "0x20EB428", Offset = "0x20EB428", VA = "0x20EB428")]
	public Region(CloudRegionCode code, string regionCodeString, string address)
	{
	}

	[Token(Token = "0x6001995")]
	[Address(RVA = "0x20EB458", Offset = "0x20EB458", VA = "0x20EB458")]
	public static CloudRegionCode Parse(string codeAsString)
	{
		return default(CloudRegionCode);
	}

	[Token(Token = "0x6001996")]
	[Address(RVA = "0x20EB680", Offset = "0x20EB680", VA = "0x20EB680")]
	internal static CloudRegionFlag ParseFlag(CloudRegionCode region)
	{
		return default(CloudRegionFlag);
	}

	[Token(Token = "0x6001997")]
	[Address(RVA = "0x20EB920", Offset = "0x20EB920", VA = "0x20EB920")]
	internal static CloudRegionFlag ParseFlag(string codeAsString)
	{
		return default(CloudRegionFlag);
	}

	[Token(Token = "0x6001998")]
	[Address(RVA = "0x20EBB10", Offset = "0x20EBB10", VA = "0x20EBB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
