using Il2CppDummyDll;

[Token(Token = "0x20002FB")]
public class CellTree
{
	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0x8")]
	private CellTreeNode RootNode__BackingField;

	[Token(Token = "0x1700047E")]
	public CellTreeNode RootNode
	{
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x20C3BA0", Offset = "0x20C3BA0", VA = "0x20C3BA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x20C3B98", Offset = "0x20C3B98", VA = "0x20C3B98")]
		private set
		{
		}
	}

	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x20C3B70", Offset = "0x20C3B70", VA = "0x20C3B70")]
	public CellTree()
	{
	}

	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x20C3B78", Offset = "0x20C3B78", VA = "0x20C3B78")]
	public CellTree(CellTreeNode root)
	{
	}
}
