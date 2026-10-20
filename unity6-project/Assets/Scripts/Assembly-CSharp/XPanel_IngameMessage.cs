using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C4A")]
public class XPanel_IngameMessage : MonoBehaviour
{
	[Token(Token = "0x2000C4B")]
	public class IngameMsgInfo : CSPoolEntry
	{
		[Token(Token = "0x4003E4F")]
		[FieldOffset(Offset = "0x8")]
		private Color textColor__BackingField;

		[Token(Token = "0x4003E50")]
		[FieldOffset(Offset = "0x18")]
		private string strText__BackingField;

		[Token(Token = "0x4003E51")]
		[FieldOffset(Offset = "0x1C")]
		private float durationTime__BackingField;

		[Token(Token = "0x4003E52")]
		[FieldOffset(Offset = "0x20")]
		private string strSoundKey__BackingField;

		[Token(Token = "0x17000CB5")]
		public Color textColor
		{
			[Token(Token = "0x60058F0")]
			[Address(RVA = "0xFF6C08", Offset = "0xFF6C08", VA = "0xFF6C08")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60058F1")]
			[Address(RVA = "0xFF71D4", Offset = "0xFF71D4", VA = "0xFF71D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CB6")]
		public string strText
		{
			[Token(Token = "0x60058F2")]
			[Address(RVA = "0xFF6C00", Offset = "0xFF6C00", VA = "0xFF6C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058F3")]
			[Address(RVA = "0xFF71EC", Offset = "0xFF71EC", VA = "0xFF71EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CB7")]
		public float durationTime
		{
			[Token(Token = "0x60058F4")]
			[Address(RVA = "0xFF71F4", Offset = "0xFF71F4", VA = "0xFF71F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60058F5")]
			[Address(RVA = "0xFF71FC", Offset = "0xFF71FC", VA = "0xFF71FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CB8")]
		public string strSoundKey
		{
			[Token(Token = "0x60058F6")]
			[Address(RVA = "0xFF6C18", Offset = "0xFF6C18", VA = "0xFF6C18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058F7")]
			[Address(RVA = "0xFF7204", Offset = "0xFF7204", VA = "0xFF7204")]
			private set
			{
			}
		}

		[Token(Token = "0x60058EF")]
		[Address(RVA = "0xFF71CC", Offset = "0xFF71CC", VA = "0xFF71CC")]
		public IngameMsgInfo()
		{
		}

		[Token(Token = "0x60058F8")]
		[Address(RVA = "0xFF7160", Offset = "0xFF7160", VA = "0xFF7160")]
		public void SetIngameMsgInfo(Color textColor, string strText, float durationTime, string strSoundKey)
		{
		}

		[Token(Token = "0x60058F9")]
		[Address(RVA = "0xFF7194", Offset = "0xFF7194", VA = "0xFF7194")]
		public bool CheckUpdateTime(float delta)
		{
			return default(bool);
		}

		[Token(Token = "0x60058FA")]
		[Address(RVA = "0xFF720C", Offset = "0xFF720C", VA = "0xFF720C", Slot = "4")]
		public void OnCleanupInObjectPool()
		{
		}
	}

	[Token(Token = "0x4003E46")]
	[FieldOffset(Offset = "0xC")]
	private Queue<IngameMsgInfo> m_stackList;

	[Token(Token = "0x4003E47")]
	[FieldOffset(Offset = "0x10")]
	private IngameMsgInfo m_currentTopMsgInfo;

	[Token(Token = "0x4003E48")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_TitleMessage m_Title_A;

	[Token(Token = "0x4003E49")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_TitleMessage m_Title_B;

	[Token(Token = "0x4003E4A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject panelTop;

	[Token(Token = "0x4003E4B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject panelTitle;

	[Token(Token = "0x4003E4C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblMessage;

	[Token(Token = "0x4003E4D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite sprBg;

	[Token(Token = "0x4003E4E")]
	[FieldOffset(Offset = "0x2C")]
	private TitleType currTitleType;

	[Token(Token = "0x60058E3")]
	[Address(RVA = "0xFF6278", Offset = "0xFF6278", VA = "0xFF6278")]
	public XPanel_IngameMessage()
	{
	}

	[Token(Token = "0x60058E4")]
	[Address(RVA = "0xFF6324", Offset = "0xFF6324", VA = "0xFF6324")]
	private void Awake()
	{
	}

	[Token(Token = "0x60058E5")]
	[Address(RVA = "0xFF6344", Offset = "0xFF6344", VA = "0xFF6344")]
	private void InitGameObjects()
	{
	}

	[Token(Token = "0x60058E6")]
	[Address(RVA = "0xFF6620", Offset = "0xFF6620", VA = "0xFF6620")]
	public void Update()
	{
	}

	[Token(Token = "0x60058E7")]
	[Address(RVA = "0xFF6920", Offset = "0xFF6920", VA = "0xFF6920")]
	private void Show(IngameMsgInfo info)
	{
	}

	[Token(Token = "0x60058E8")]
	[Address(RVA = "0xFF6C20", Offset = "0xFF6C20", VA = "0xFF6C20")]
	public void ShowTitle(TitleType titleType, string msgSoundName, string text, float durationtime)
	{
	}

	[Token(Token = "0x60058E9")]
	[Address(RVA = "0xFF6EE0", Offset = "0xFF6EE0", VA = "0xFF6EE0")]
	public void ShowTop(Color color, string text, float durationtime, string msgSoundName)
	{
	}

	[Token(Token = "0x60058EA")]
	[Address(RVA = "0xFF702C", Offset = "0xFF702C", VA = "0xFF702C")]
	private void AddTopMsgQueue(Color color, string text, float durationtime, string msgSoundName)
	{
	}

	[Token(Token = "0x60058EB")]
	[Address(RVA = "0xFF67C4", Offset = "0xFF67C4", VA = "0xFF67C4")]
	private void UpdateTop(float delta)
	{
	}

	[Token(Token = "0x60058EC")]
	[Address(RVA = "0xFF6660", Offset = "0xFF6660", VA = "0xFF6660")]
	private void UpdateTitle(float delta)
	{
	}

	[Token(Token = "0x60058ED")]
	[Address(RVA = "0xFF6364", Offset = "0xFF6364", VA = "0xFF6364")]
	public void HideTop(bool isClearStack = false)
	{
	}

	[Token(Token = "0x60058EE")]
	[Address(RVA = "0xFF6494", Offset = "0xFF6494", VA = "0xFF6494")]
	public void HideTitle()
	{
	}
}
