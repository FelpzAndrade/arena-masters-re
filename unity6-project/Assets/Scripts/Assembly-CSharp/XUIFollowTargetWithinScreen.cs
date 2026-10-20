using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D78")]
public class XUIFollowTargetWithinScreen : XUIFollowTarget
{
	[Token(Token = "0x400457D")]
	[FieldOffset(Offset = "0x30")]
	private UIWidget m_constrainTarget;

	[Token(Token = "0x400457E")]
	[FieldOffset(Offset = "0x34")]
	private UIPanel m_panel;

	[Token(Token = "0x60062E2")]
	[Address(RVA = "0x1A45D40", Offset = "0x1A45D40", VA = "0x1A45D40")]
	public XUIFollowTargetWithinScreen()
	{
	}

	[Token(Token = "0x60062E3")]
	[Address(RVA = "0x1A45D50", Offset = "0x1A45D50", VA = "0x1A45D50")]
	public void Init(GameObject goTarget, float yWorldOffset, UIWidget constrainTarget, UIPanel panel)
	{
	}

	[Token(Token = "0x60062E4")]
	[Address(RVA = "0x1A45D74", Offset = "0x1A45D74", VA = "0x1A45D74", Slot = "4")]
	protected override void OnUpdate(bool isVisible)
	{
	}
}
