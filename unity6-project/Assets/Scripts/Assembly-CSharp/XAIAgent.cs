using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

[Token(Token = "0x200043B")]
public class XAIAgent : MonoBehaviour
{
	[Token(Token = "0x200043C")]
	public enum PathType
	{
		[Token(Token = "0x40014B2")]
		ABPath = 0,
		[Token(Token = "0x40014B3")]
		Random = 1,
		[Token(Token = "0x40014B4")]
		Flee = 2
	}

	[Token(Token = "0x200043D")]
	public class Enumerator
	{
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0x8")]
		private List<Vector3> m_list;

		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0xC")]
		private int m_index;

		[Token(Token = "0x17000591")]
		public Vector3 Current
		{
			[Token(Token = "0x60021E5")]
			[Address(RVA = "0x1EDE3B8", Offset = "0x1EDE3B8", VA = "0x1EDE3B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60021E2")]
		[Address(RVA = "0x1EDDAB4", Offset = "0x1EDDAB4", VA = "0x1EDDAB4")]
		public Enumerator()
		{
		}

		[Token(Token = "0x60021E3")]
		[Address(RVA = "0x1EDE19C", Offset = "0x1EDE19C", VA = "0x1EDE19C")]
		public void RegisterList(List<Vector3> list)
		{
		}

		[Token(Token = "0x60021E4")]
		[Address(RVA = "0x1EDE304", Offset = "0x1EDE304", VA = "0x1EDE304")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x1EDF690", Offset = "0x1EDF690", VA = "0x1EDF690")]
		public void Release()
		{
		}
	}

	[Token(Token = "0x400149B")]
	[FieldOffset(Offset = "0xC")]
	private float defaultRepathInterval;

	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0x10")]
	private float m_curRepathInterval;

	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x14")]
	private XModuleEntity m_me;

	[Token(Token = "0x400149E")]
	[FieldOffset(Offset = "0x18")]
	private Path m_path;

	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x1C")]
	private Enumerator m_enumerator;

	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_curWayPoint;

	[Token(Token = "0x40014A1")]
	[FieldOffset(Offset = "0x2C")]
	private Seeker m_seeker;

	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_target;

	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x34")]
	private bool m_start;

	[Token(Token = "0x40014A4")]
	[FieldOffset(Offset = "0x38")]
	private float m_lastRepath;

	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x3C")]
	private PathType m_pathType;

	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x40")]
	public int searchLength;

	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x44")]
	public int spread;

	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x48")]
	public float aimStrength;

	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0x4C")]
	public float disableDelay;

	[Token(Token = "0x40014AA")]
	[FieldOffset(Offset = "0x50")]
	private XHelper.TimeChecker m_stuckAggroTimeChecker;

	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 lastPos;

	[Token(Token = "0x40014AC")]
	[FieldOffset(Offset = "0x60")]
	private Vector3? avoidDirection;

	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x70")]
	private int stuckThreshold;

	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0x74")]
	private int stuckCount;

	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x78")]
	private bool avoid;

	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0x7C")]
	public XModuleEntity m_stuckObject;

	[Token(Token = "0x17000590")]
	public Transform Target
	{
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x1EDDB80", Offset = "0x1EDDB80", VA = "0x1EDDB80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x1EDDD38", Offset = "0x1EDDD38", VA = "0x1EDDD38")]
		set
		{
		}
	}

	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x1EDD9C4", Offset = "0x1EDD9C4", VA = "0x1EDD9C4")]
	public XAIAgent()
	{
	}

	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x1EDDD40", Offset = "0x1EDDD40", VA = "0x1EDDD40")]
	public void Enable()
	{
	}

	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x1EDDD58", Offset = "0x1EDDD58", VA = "0x1EDDD58")]
	public void Disable(float delay)
	{
	}

	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x1EDDD60", Offset = "0x1EDDD60", VA = "0x1EDDD60")]
	public void Disable()
	{
	}

	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x1EDDE38", Offset = "0x1EDDE38", VA = "0x1EDDE38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x1EDDEEC", Offset = "0x1EDDEEC", VA = "0x1EDDEEC")]
	public void SetTarget(Vector3 pos, PathType pathType = PathType.ABPath, float randomPathRepathInterval = 1f)
	{
	}

	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x1EDE038", Offset = "0x1EDE038", VA = "0x1EDE038")]
	private void SetPath(Path path)
	{
	}

	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x1EDE4A8", Offset = "0x1EDE4A8", VA = "0x1EDE4A8")]
	private void SearchPath()
	{
	}

	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x1EDE878", Offset = "0x1EDE878", VA = "0x1EDE878")]
	private void Update()
	{
	}

	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x1EDF458", Offset = "0x1EDF458", VA = "0x1EDF458")]
	private void ResetStuck()
	{
	}

	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x1EDDFF0", Offset = "0x1EDDFF0", VA = "0x1EDDFF0")]
	private void SetCurrentWayPoint(Vector3 point)
	{
	}

	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x1EDDDAC", Offset = "0x1EDDDAC", VA = "0x1EDDDAC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x1EDF420", Offset = "0x1EDF420", VA = "0x1EDF420")]
	public void Hold()
	{
	}

	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x1EDF538", Offset = "0x1EDF538", VA = "0x1EDF538")]
	public void Final()
	{
	}
}
