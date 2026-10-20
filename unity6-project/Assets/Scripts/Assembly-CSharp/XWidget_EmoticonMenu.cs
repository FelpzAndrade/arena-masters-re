using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D34")]
public class XWidget_EmoticonMenu : MonoBehaviour
{
	[Token(Token = "0x2000D35")]
	private sealed class _003CBuild_003Ec__AnonStorey19A
	{
		[Token(Token = "0x400439B")]
		[FieldOffset(Offset = "0x8")]
		internal CSEmoticonSetInfo emoInfo;

		[Token(Token = "0x400439C")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_EmoticonMenu _003C_003Ef__this;

		[Token(Token = "0x60060E8")]
		[Address(RVA = "0x15F41A8", Offset = "0x15F41A8", VA = "0x15F41A8")]
		public _003CBuild_003Ec__AnonStorey19A()
		{
		}

		[Token(Token = "0x60060E9")]
		[Address(RVA = "0x15F42F4", Offset = "0x15F42F4", VA = "0x15F42F4")]
		internal void _003C_003Em__2BF()
		{
		}
	}

	[Token(Token = "0x4004394")]
	[FieldOffset(Offset = "0xC")]
	public new GameObject gameObject;

	[Token(Token = "0x4004395")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder widgetGridBuilder;

	[Token(Token = "0x4004396")]
	[FieldOffset(Offset = "0x14")]
	private float m_duplicatedCount;

	[Token(Token = "0x4004397")]
	[FieldOffset(Offset = "0x18")]
	private bool m_isShowEmoticonMenu;

	[Token(Token = "0x4004398")]
	[FieldOffset(Offset = "0x1C")]
	private float m_menuDuration;

	[Token(Token = "0x4004399")]
	[FieldOffset(Offset = "0x20")]
	private float m_showEmoticonMenu_ElapsedTime;

	[Token(Token = "0x400439A")]
	[FieldOffset(Offset = "0x24")]
	private List<CSEmoticonSetInfo> m_emoticons;

	[Token(Token = "0x60060E1")]
	[Address(RVA = "0x15F3E9C", Offset = "0x15F3E9C", VA = "0x15F3E9C")]
	public XWidget_EmoticonMenu()
	{
	}

	[Token(Token = "0x60060E2")]
	[Address(RVA = "0x15F3EB0", Offset = "0x15F3EB0", VA = "0x15F3EB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60060E3")]
	[Address(RVA = "0x15F3EE8", Offset = "0x15F3EE8", VA = "0x15F3EE8")]
	public void Build(List<CSEmoticonSetInfo> emoticonInfos)
	{
	}

	[Token(Token = "0x60060E4")]
	[Address(RVA = "0x15F41E8", Offset = "0x15F41E8", VA = "0x15F41E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60060E5")]
	[Address(RVA = "0x15F423C", Offset = "0x15F423C", VA = "0x15F423C")]
	private void UpdateEmoticonMenu(float deltaTime)
	{
	}

	[Token(Token = "0x60060E6")]
	[Address(RVA = "0x15F4270", Offset = "0x15F4270", VA = "0x15F4270")]
	public void Hide()
	{
	}

	[Token(Token = "0x60060E7")]
	[Address(RVA = "0x15F42A8", Offset = "0x15F42A8", VA = "0x15F42A8")]
	public void Show(List<CSEmoticonSetInfo> emoticonSet)
	{
	}
}
