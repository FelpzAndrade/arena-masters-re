using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B32")]
	public class QuestInfo
	{
		[Token(Token = "0x400376F")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x4003770")]
		[FieldOffset(Offset = "0xC")]
		public QuestType nType;

		[Token(Token = "0x4003771")]
		[FieldOffset(Offset = "0x10")]
		public QuestGroup nGroup;

		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x14")]
		public InitializeType nInitializeType;

		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x18")]
		public string strStart;

		[Token(Token = "0x4003774")]
		[FieldOffset(Offset = "0x1C")]
		public string strEnd;

		[Token(Token = "0x4003775")]
		[FieldOffset(Offset = "0x20")]
		public int nNextID;

		[Token(Token = "0x4003776")]
		[FieldOffset(Offset = "0x24")]
		[XmlIgnore]
		public int nBeforeID;

		[Token(Token = "0x4003777")]
		[FieldOffset(Offset = "0x28")]
		[XmlIgnore]
		public int clearGroupUID;

		[Token(Token = "0x4003778")]
		[FieldOffset(Offset = "0x2C")]
		[XmlIgnore]
		public int clearGroupIndex;

		[Token(Token = "0x4003779")]
		[FieldOffset(Offset = "0x30")]
		public string strIcon;

		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x34")]
		public string strTitle;

		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0x38")]
		public string strDesc;

		[Token(Token = "0x400377C")]
		[FieldOffset(Offset = "0x3C")]
		public string strReward;

		[Token(Token = "0x400377D")]
		[FieldOffset(Offset = "0x40")]
		public List<CSContent> RewardContentList;

		[Token(Token = "0x400377E")]
		[FieldOffset(Offset = "0x44")]
		public string strLink;

		[Token(Token = "0x400377F")]
		[FieldOffset(Offset = "0x48")]
		public string strFinishReference;

		[Token(Token = "0x4003780")]
		[FieldOffset(Offset = "0x4C")]
		public Stat.Type nFinishConditionKey;

		[Token(Token = "0x4003781")]
		[FieldOffset(Offset = "0x50")]
		public string strFinishConditionValue;

		[Token(Token = "0x4003782")]
		[FieldOffset(Offset = "0x54")]
		public string strCompleteIf;

		[Token(Token = "0x4003783")]
		[FieldOffset(Offset = "0x58")]
		public string strShowIf;

		[Token(Token = "0x4003784")]
		[FieldOffset(Offset = "0x5C")]
		public int nShowOrder;

		[Token(Token = "0x4003785")]
		[FieldOffset(Offset = "0x60")]
		public AchieveGroup nAchieveGroup;

		[Token(Token = "0x4003786")]
		[FieldOffset(Offset = "0x64")]
		public AchieveShape nAchieveShape;

		[Token(Token = "0x4003787")]
		[FieldOffset(Offset = "0x68")]
		public string strUnable;

		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x6C")]
		[XmlIgnore]
		public int pvpQuestClearPoint;

		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0x70")]
		[XmlIgnore]
		public bool IsAllClear;

		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x71")]
		public bool popup;

		[Token(Token = "0x17000C07")]
		public bool HasClearGroup
		{
			[Token(Token = "0x600520A")]
			[Address(RVA = "0x21BCA94", Offset = "0x21BCA94", VA = "0x21BCA94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005209")]
		[Address(RVA = "0x21BC910", Offset = "0x21BC910", VA = "0x21BC910")]
		public QuestInfo()
		{
		}

		[Token(Token = "0x600520B")]
		[Address(RVA = "0x21BCAA4", Offset = "0x21BCAA4", VA = "0x21BCAA4")]
		public bool IsLastQuest()
		{
			return default(bool);
		}

		[Token(Token = "0x600520C")]
		[Address(RVA = "0x21B1F24", Offset = "0x21B1F24", VA = "0x21B1F24")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
