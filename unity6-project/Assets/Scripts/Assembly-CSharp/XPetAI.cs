using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

[Token(Token = "0x20004A0")]
public class XPetAI : MonoBehaviour
{
	[Token(Token = "0x20004A1")]
	public enum PathType
	{
		[Token(Token = "0x4001737")]
		ABPath = 0,
		[Token(Token = "0x4001738")]
		Random = 1,
		[Token(Token = "0x4001739")]
		Flee = 2
	}

	[Token(Token = "0x20004A2")]
	public class Enumerator
	{
		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0x8")]
		private List<Vector3> m_list;

		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0xC")]
		private int m_index;

		[Token(Token = "0x1700065D")]
		public Vector3 Current
		{
			[Token(Token = "0x60027DD")]
			[Address(RVA = "0xADBD9C", Offset = "0xADBD9C", VA = "0xADBD9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60027DA")]
		[Address(RVA = "0xADB518", Offset = "0xADB518", VA = "0xADB518")]
		public Enumerator()
		{
		}

		[Token(Token = "0x60027DB")]
		[Address(RVA = "0xADBB80", Offset = "0xADBB80", VA = "0xADBB80")]
		public void RegisterList(List<Vector3> list)
		{
		}

		[Token(Token = "0x60027DC")]
		[Address(RVA = "0xADBCE8", Offset = "0xADBCE8", VA = "0xADBCE8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60027DE")]
		[Address(RVA = "0xADD0C4", Offset = "0xADD0C4", VA = "0xADD0C4")]
		public void Release()
		{
		}
	}

	[Token(Token = "0x400171B")]
	[FieldOffset(Offset = "0xC")]
	protected Seeker m_seeker;

	[Token(Token = "0x400171C")]
	[FieldOffset(Offset = "0x10")]
	protected XModuleEntity m_me;

	[Token(Token = "0x400171D")]
	[FieldOffset(Offset = "0x14")]
	private GameObject myPlayer;

	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 prePlayerPosition;

	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x24")]
	public float intervalSearchTime;

	[Token(Token = "0x4001720")]
	[FieldOffset(Offset = "0x28")]
	private float curTime;

	[Token(Token = "0x4001721")]
	[FieldOffset(Offset = "0x2C")]
	public int limitDistance;

	[Token(Token = "0x4001722")]
	[FieldOffset(Offset = "0x30")]
	private float defaultRepathInterval;

	[Token(Token = "0x4001723")]
	[FieldOffset(Offset = "0x34")]
	private float m_curRepathInterval;

	[Token(Token = "0x4001724")]
	[FieldOffset(Offset = "0x38")]
	private Path m_path;

	[Token(Token = "0x4001725")]
	[FieldOffset(Offset = "0x3C")]
	private Enumerator m_enumerator;

	[Token(Token = "0x4001726")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_curWayPoint;

	[Token(Token = "0x4001727")]
	[FieldOffset(Offset = "0x4C")]
	private Transform m_target;

	[Token(Token = "0x4001728")]
	[FieldOffset(Offset = "0x50")]
	private bool m_start;

	[Token(Token = "0x4001729")]
	[FieldOffset(Offset = "0x54")]
	private float m_lastRepath;

	[Token(Token = "0x400172A")]
	[FieldOffset(Offset = "0x58")]
	private PathType m_pathType;

	[Token(Token = "0x400172B")]
	[FieldOffset(Offset = "0x5C")]
	public int searchLength;

	[Token(Token = "0x400172C")]
	[FieldOffset(Offset = "0x60")]
	public int spread;

	[Token(Token = "0x400172D")]
	[FieldOffset(Offset = "0x64")]
	public float aimStrength;

	[Token(Token = "0x400172E")]
	[FieldOffset(Offset = "0x68")]
	public float disableDelay;

	[Token(Token = "0x400172F")]
	[FieldOffset(Offset = "0x6C")]
	private XHelper.TimeChecker m_stuckAggroTimeChecker;

	[Token(Token = "0x4001730")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 lastPos;

	[Token(Token = "0x4001731")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3? avoidDirection;

	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x8C")]
	private int stuckThreshold;

	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x90")]
	private int stuckCount;

	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x94")]
	private bool avoid;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x98")]
	public XModuleEntity m_stuckObject;

	[Token(Token = "0x1700065C")]
	public Transform Target
	{
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0xADB64C", Offset = "0xADB64C", VA = "0xADB64C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0xADB71C", Offset = "0xADB71C", VA = "0xADB71C")]
		set
		{
		}
	}

	[Token(Token = "0x60027C8")]
	[Address(RVA = "0xADB418", Offset = "0xADB418", VA = "0xADB418")]
	public XPetAI()
	{
	}

	[Token(Token = "0x60027C9")]
	[Address(RVA = "0xADB5E4", Offset = "0xADB5E4", VA = "0xADB5E4")]
	public void SetMyPlayer(GameObject player)
	{
	}

	[Token(Token = "0x60027CA")]
	[Address(RVA = "0xADB5EC", Offset = "0xADB5EC", VA = "0xADB5EC")]
	private void SearchPlayerPosition()
	{
	}

	[Token(Token = "0x60027CD")]
	[Address(RVA = "0xADB724", Offset = "0xADB724", VA = "0xADB724")]
	public void Enable()
	{
	}

	[Token(Token = "0x60027CE")]
	[Address(RVA = "0xADB73C", Offset = "0xADB73C", VA = "0xADB73C")]
	public void Disable(float delay)
	{
	}

	[Token(Token = "0x60027CF")]
	[Address(RVA = "0xADB744", Offset = "0xADB744", VA = "0xADB744")]
	public void Disable()
	{
	}

	[Token(Token = "0x60027D0")]
	[Address(RVA = "0xADB81C", Offset = "0xADB81C", VA = "0xADB81C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027D1")]
	[Address(RVA = "0xADB8D0", Offset = "0xADB8D0", VA = "0xADB8D0")]
	public void SetTarget(Vector3 pos, PathType pathType = PathType.ABPath, float randomPathRepathInterval = 1f)
	{
	}

	[Token(Token = "0x60027D2")]
	[Address(RVA = "0xADBA1C", Offset = "0xADBA1C", VA = "0xADBA1C")]
	private void SetPath(Path path)
	{
	}

	[Token(Token = "0x60027D3")]
	[Address(RVA = "0xADBE8C", Offset = "0xADBE8C", VA = "0xADBE8C")]
	private void SearchPath()
	{
	}

	[Token(Token = "0x60027D4")]
	[Address(RVA = "0xADC25C", Offset = "0xADC25C", VA = "0xADC25C")]
	private void Update()
	{
	}

	[Token(Token = "0x60027D5")]
	[Address(RVA = "0xADCE8C", Offset = "0xADCE8C", VA = "0xADCE8C")]
	private void ResetStuck()
	{
	}

	[Token(Token = "0x60027D6")]
	[Address(RVA = "0xADB9D4", Offset = "0xADB9D4", VA = "0xADB9D4")]
	private void SetCurrentWayPoint(Vector3 point)
	{
	}

	[Token(Token = "0x60027D7")]
	[Address(RVA = "0xADB790", Offset = "0xADB790", VA = "0xADB790")]
	public void Reset()
	{
	}

	[Token(Token = "0x60027D8")]
	[Address(RVA = "0xADCE54", Offset = "0xADCE54", VA = "0xADCE54")]
	public void Hold()
	{
	}

	[Token(Token = "0x60027D9")]
	[Address(RVA = "0xADCF6C", Offset = "0xADCF6C", VA = "0xADCF6C")]
	public void Final()
	{
	}
}
