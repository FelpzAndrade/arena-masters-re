using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000CDA")]
public class UIDirector
{
	[Token(Token = "0x2000CDB")]
	public enum BaseType
	{
		[Token(Token = "0x4004193")]
		Sequence = 0,
		[Token(Token = "0x4004194")]
		Pararell = 1
	}

	[Token(Token = "0x400418E")]
	[FieldOffset(Offset = "0x8")]
	private bool isStarted;

	[Token(Token = "0x400418F")]
	[FieldOffset(Offset = "0xC")]
	private List<UIDirectionElement> removeList;

	[Token(Token = "0x4004190")]
	[FieldOffset(Offset = "0x10")]
	private UIDirectionElement baseDirectionContainer;

	[Token(Token = "0x4004191")]
	[FieldOffset(Offset = "0x14")]
	private BaseType type;

	[Token(Token = "0x17000CEE")]
	public bool IsStarted
	{
		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x16DE468", Offset = "0x16DE468", VA = "0x16DE468")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005CDB")]
	[Address(RVA = "0x16DE008", Offset = "0x16DE008", VA = "0x16DE008")]
	public UIDirector(BaseType type)
	{
	}

	[Token(Token = "0x6005CDC")]
	[Address(RVA = "0x16DE0C8", Offset = "0x16DE0C8", VA = "0x16DE0C8")]
	public void SetBaseContainer(BaseType type)
	{
	}

	[Token(Token = "0x6005CDD")]
	[Address(RVA = "0x16DE190", Offset = "0x16DE190", VA = "0x16DE190")]
	public void Start()
	{
	}

	[Token(Token = "0x6005CDE")]
	[Address(RVA = "0x16DE2A8", Offset = "0x16DE2A8", VA = "0x16DE2A8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6005CDF")]
	[Address(RVA = "0x16DE2B8", Offset = "0x16DE2B8", VA = "0x16DE2B8")]
	public void Update()
	{
	}

	[Token(Token = "0x6005CE0")]
	[Address(RVA = "0x16DE470", Offset = "0x16DE470", VA = "0x16DE470")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005CE1")]
	[Address(RVA = "0x16DE608", Offset = "0x16DE608", VA = "0x16DE608")]
	public bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6005CE3")]
	[Address(RVA = "0x16DE710", Offset = "0x16DE710", VA = "0x16DE710")]
	public void Add(UIDirectionElement element)
	{
	}
}
