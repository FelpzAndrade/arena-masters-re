using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002FC")]
public class CellTreeNode
{
	[Token(Token = "0x20002FD")]
	public enum ENodeType
	{
		[Token(Token = "0x4000FEA")]
		Root = 0,
		[Token(Token = "0x4000FEB")]
		Node = 1,
		[Token(Token = "0x4000FEC")]
		Leaf = 2
	}

	[Token(Token = "0x4000FE0")]
	[FieldOffset(Offset = "0x8")]
	public byte Id;

	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 Center;

	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Size;

	[Token(Token = "0x4000FE3")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 TopLeft;

	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 BottomRight;

	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x3C")]
	public ENodeType NodeType;

	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x40")]
	public CellTreeNode Parent;

	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x44")]
	public List<CellTreeNode> Childs;

	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x48")]
	private float maxDistance;

	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x20C3BA8", Offset = "0x20C3BA8", VA = "0x20C3BA8")]
	public CellTreeNode()
	{
	}

	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x20C3BB0", Offset = "0x20C3BB0", VA = "0x20C3BB0")]
	public CellTreeNode(byte id, ENodeType nodeType, CellTreeNode parent)
	{
	}

	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x20C3BE0", Offset = "0x20C3BE0", VA = "0x20C3BE0")]
	public void AddChild(CellTreeNode child)
	{
	}

	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x20C3CD0", Offset = "0x20C3CD0", VA = "0x20C3CD0")]
	public void Draw()
	{
	}

	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x20C3CD4", Offset = "0x20C3CD4", VA = "0x20C3CD4")]
	public void GetActiveCells(List<byte> activeCells, bool yIsUpAxis, Vector3 position)
	{
	}

	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x20C40D8", Offset = "0x20C40D8", VA = "0x20C40D8")]
	public bool IsPointInsideCell(bool yIsUpAxis, Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x20C4018", Offset = "0x20C4018", VA = "0x20C4018")]
	public bool IsPointNearCell(bool yIsUpAxis, Vector3 point)
	{
		return default(bool);
	}
}
