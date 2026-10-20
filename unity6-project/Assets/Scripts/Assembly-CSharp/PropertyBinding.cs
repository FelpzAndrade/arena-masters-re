using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000220")]
[ExecuteInEditMode]
public class PropertyBinding : MonoBehaviour
{
	[Token(Token = "0x2000221")]
	public enum UpdateCondition
	{
		[Token(Token = "0x400092E")]
		OnStart = 0,
		[Token(Token = "0x400092F")]
		OnUpdate = 1,
		[Token(Token = "0x4000930")]
		OnLateUpdate = 2,
		[Token(Token = "0x4000931")]
		OnFixedUpdate = 3
	}

	[Token(Token = "0x2000222")]
	public enum Direction
	{
		[Token(Token = "0x4000933")]
		SourceUpdatesTarget = 0,
		[Token(Token = "0x4000934")]
		TargetUpdatesSource = 1,
		[Token(Token = "0x4000935")]
		BiDirectional = 2
	}

	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0xC")]
	public PropertyReference source;

	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x10")]
	public PropertyReference target;

	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x14")]
	public Direction direction;

	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x18")]
	public UpdateCondition update;

	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x1C")]
	public bool editMode;

	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0x20")]
	private object mLastValue;

	[Token(Token = "0x6001254")]
	[Address(RVA = "0x20E4EC4", Offset = "0x20E4EC4", VA = "0x20E4EC4")]
	public PropertyBinding()
	{
	}

	[Token(Token = "0x6001255")]
	[Address(RVA = "0x20E4ED8", Offset = "0x20E4ED8", VA = "0x20E4ED8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001256")]
	[Address(RVA = "0x20E50D4", Offset = "0x20E50D4", VA = "0x20E50D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001257")]
	[Address(RVA = "0x20E50E4", Offset = "0x20E50E4", VA = "0x20E50E4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001258")]
	[Address(RVA = "0x20E50F4", Offset = "0x20E50F4", VA = "0x20E50F4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001259")]
	[Address(RVA = "0x20E5104", Offset = "0x20E5104", VA = "0x20E5104")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600125A")]
	[Address(RVA = "0x20E4F08", Offset = "0x20E4F08", VA = "0x20E4F08")]
	public void UpdateTarget()
	{
	}
}
