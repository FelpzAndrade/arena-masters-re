using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002FA")]
public class CullArea : MonoBehaviour
{
	[Token(Token = "0x4000FCF")]
	private const int MAX_NUMBER_OF_ALLOWED_CELLS = 250;

	[Token(Token = "0x4000FD0")]
	public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;

	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0xC")]
	public readonly byte FIRST_GROUP_ID;

	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x10")]
	public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER;

	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x14")]
	public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER;

	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x18")]
	public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER;

	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 Center;

	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 Size;

	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2[] Subdivisions;

	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x30")]
	public int NumberOfSubdivisions;

	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x34")]
	public bool YIsUpAxis;

	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x35")]
	public bool RecreateCellHierarchy;

	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x36")]
	private byte idCounter;

	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0x38")]
	private int CellCount__BackingField;

	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0x3C")]
	private CellTree CellTree__BackingField;

	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, GameObject> Map__BackingField;

	[Token(Token = "0x1700047B")]
	public int CellCount
	{
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x1E5FE9C", Offset = "0x1E5FE9C", VA = "0x1E5FE9C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x1E5FEA4", Offset = "0x1E5FEA4", VA = "0x1E5FEA4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700047C")]
	public CellTree CellTree
	{
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x1E5FEAC", Offset = "0x1E5FEAC", VA = "0x1E5FEAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x1E5FEB4", Offset = "0x1E5FEB4", VA = "0x1E5FEB4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700047D")]
	public Dictionary<int, GameObject> Map
	{
		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x1E5FEBC", Offset = "0x1E5FEBC", VA = "0x1E5FEBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x1E5FEC4", Offset = "0x1E5FEC4", VA = "0x1E5FEC4")]
		private set
		{
		}
	}

	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x1E5FC98", Offset = "0x1E5FC98", VA = "0x1E5FC98")]
	public CullArea()
	{
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x1E5FECC", Offset = "0x1E5FECC", VA = "0x1E5FECC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x1E60748", Offset = "0x1E60748", VA = "0x1E60748")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x1E5FED8", Offset = "0x1E5FED8", VA = "0x1E5FED8")]
	private void CreateCellHierarchy()
	{
	}

	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x1E6087C", Offset = "0x1E6087C", VA = "0x1E6087C")]
	private void CreateChildCells(CellTreeNode parent, int cellLevelInHierarchy)
	{
	}

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x1E60778", Offset = "0x1E60778", VA = "0x1E60778")]
	private void DrawCells()
	{
	}

	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x1E607E0", Offset = "0x1E607E0", VA = "0x1E607E0")]
	private bool IsCellCountAllowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x1E60CD4", Offset = "0x1E60CD4", VA = "0x1E60CD4")]
	public List<byte> GetActiveCells(Vector3 position)
	{
		return null;
	}
}
