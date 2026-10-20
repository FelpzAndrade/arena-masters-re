using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000640")]
public class XProtoInfoFactory : CSProtoInfoFactory
{
	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x1C859DC", Offset = "0x1C859DC", VA = "0x1C859DC")]
	public XProtoInfoFactory()
	{
	}

	[Token(Token = "0x60035B8")]
	[Address(RVA = "0x1C859E4", Offset = "0x1C859E4", VA = "0x1C859E4", Slot = "4")]
	public override CSProtoInfoManagerBase Create(ProtoInfoTypes type)
	{
		switch (type)
		{
			case ProtoInfoTypes.Character:
				return new XProtoInfoManager_Character();
			case ProtoInfoTypes.Skill:
				return new XProtoInfoManager_Skill();
			case ProtoInfoTypes.Buff:
				return new XProtoInfoManager_Buff();
			case ProtoInfoTypes.GameConst:
				return new XProtoInfoManager_GameConst();
			case ProtoInfoTypes.Quest:
				return new XProtoInfoManager_Quest();
			case ProtoInfoTypes.SkillSpecialization:
				return new XProtoInfoManager_SkillSpecialization();
			case ProtoInfoTypes.Skin:
				return new XProtoInfoManager_Skin();
			case ProtoInfoTypes.ClanMark:
				return new XProtoInfoManager_ClanMark();
			case ProtoInfoTypes.ClanLevel:
				return new XProtoInfoManager_ClanLevel();
			case ProtoInfoTypes.BattleRecord:
				return new XProtoInfoManager_BattleRecord();
			case ProtoInfoTypes.GameModeUISort:
				return new ProtoInfoManager_GameModeSort();
			case ProtoInfoTypes.LobbyButton:
				return new XProtoInfoManager_LobbyButton();
			case ProtoInfoTypes.GameMode:
				return new ProtoInfoManager_GameMode();
			case ProtoInfoTypes.Sector:
				return new CSProtoInfoManager_Sector();
			case ProtoInfoTypes.PackageDetail:
				return new XProtoInfoManager_PackageDetail();
			case ProtoInfoTypes.Sound:
				return new XProtoInfoManager_Sound();
			case ProtoInfoTypes.Tips:
				return new XProtoInfoManager_Tips();
			case ProtoInfoTypes.KillStreak:
				return new XProtoInfoManager_KillStreak();
			case ProtoInfoTypes.Help:
				return new XProtoInfoManager_Help();
			case ProtoInfoTypes.CharacterSound:
				return new CSProtoInfoManager_CharacterSound();
			case ProtoInfoTypes.CharAnim:
				return new CSProtoInfoManager_CharAnim();
			case ProtoInfoTypes.ShowBox:
				return new XProtoInfoManager_ShowBox();
			case ProtoInfoTypes.TutorialScript:
				return new XProtoInfoManager_TutorialScript();
			case ProtoInfoTypes.Language:
				return new XProtoInfoManager_Language();
			case ProtoInfoTypes.Abuse:
				return new XProtoInfoManager_Abuse();
			case ProtoInfoTypes.DownloadImg:
				return new XProtoInfoManager_DownloadImg();
			case ProtoInfoTypes.Country:
				return new XProtoInfoManager_Country();
			case ProtoInfoTypes.CharacterFreeRotation:
				return new XProtoInfoManager_CharacterFreeRotation();
			default:
				return base.Create(type);
		}
	}
}
