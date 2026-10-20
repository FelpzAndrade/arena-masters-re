using System;
using System.Text;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000874")]
	public class CSConst
	{
		[Token(Token = "0x40026BE")]
		public const string KAKAOAPPKEY = "8db1c2e9268f9d02737d1b8df0dfb27a";

		[Token(Token = "0x40026BF")]
		public const ConnectEnum.RegionType DEFAULT_REGION_TYPE = ConnectEnum.RegionType.Asia;

		[Token(Token = "0x40026C0")]
		public const bool TEST_FUNCTION_ON = true;

		[Token(Token = "0x40026C1")]
		public const bool BUILD_ASSET_BUNDLE = false;

		[Token(Token = "0x40026C2")]
		public const bool PUBLISH_BUILD = false;

		[Token(Token = "0x40026C3")]
		public const bool DEBUG_LOG = true;

		[Token(Token = "0x40026C4")]
		public const int DATA_VERSION = 1;

		[Token(Token = "0x40026C5")]
		public const string PHOTON_VERSION = "1.84.1";

		[Token(Token = "0x40026C6")]
		public const int INVALID_CHAR_ID = 0;

		[Token(Token = "0x40026C7")]
		public const int NULL_OF_PHOTON_VIEW_ID = -1;

		[Token(Token = "0x40026C8")]
		public const int INVALID_ITEM_ID = 0;

		[Token(Token = "0x40026C9")]
		public const int INVALID_ITEM_INVEN_SLOT_ID = -1;

		[Token(Token = "0x40026CA")]
		public const int INVALID_SKILL_ID = 0;

		[Token(Token = "0x40026CB")]
		public const int INVALID_BUFF_ID = 0;

		[Token(Token = "0x40026CC")]
		public const int MAX_NAME_LENGTH = 12;

		[Token(Token = "0x40026CD")]
		public const int MAX_FRIENDLY_ROOM_NAME_LENGTH = 24;

		[Token(Token = "0x40026CE")]
		public const int MAX_PASSWORD_LENGTH = 20;

		[Token(Token = "0x40026CF")]
		public const string LOCALDATA_OPTION_KEY = "option";

		[Token(Token = "0x40026D0")]
		public const string LOCALDATA_KEY = "local";

		[Token(Token = "0x40026D1")]
		public const string LOCALDATA_TUTORIAL_KEY = "tutorialdata";

		[Token(Token = "0x40026D2")]
		public const string LOCALDATA_NEWBADGE_KEY = "newbadgedata";

		[Token(Token = "0x40026D3")]
		public const string LOCALGAMEDATA_KEY = "local_game_data";

		[Token(Token = "0x40026D4")]
		public const string LOCAL_RANKERDATA_KEY = "local_rank_data";

		[Token(Token = "0x40026D5")]
		public const int MAX_CHARACTER_PARTY_MEMBER = 3;

		[Token(Token = "0x40026D6")]
		public const int MAX_TAG_PARTY_MEMBER = 2;

		[Token(Token = "0x40026D7")]
		public const int CHAR_PARTY_COUNT = 3;

		[Token(Token = "0x40026D8")]
		public const int MAX_CHAR_GRADE = 1;

		[Token(Token = "0x40026D9")]
		public const float INGAME_TEAM_MATHCH_RESPAWN_INTERVAL_TIME = 0.2f;

		[Token(Token = "0x40026DA")]
		public const int MAX_ITEM_ENCHANT_LEVEL = 5;

		[Token(Token = "0x40026DB")]
		public const int MAX_ITEM_SKILL_COUNT = 4;

		[Token(Token = "0x40026DC")]
		public const int MAX_CHAR_SKILL_COUNT = 4;

		[Token(Token = "0x40026DD")]
		public const int MAX_SKILL_BUFF = 3;

		[Token(Token = "0x40026DE")]
		public const int MAX_SKILL_EFFECT = 2;

		[Token(Token = "0x40026DF")]
		public const int MAX_CHAR_EQUIPMENT_SLOT = 6;

		[Token(Token = "0x40026E0")]
		public const int MAX_PET_EQUIPMENT_SLOT = 3;

		[Token(Token = "0x40026E1")]
		public const float PET_INVEN_GACHA_SCALE = 1.5f;

		[Token(Token = "0x40026E2")]
		public const float PANEL_PET_SCALE = 1.5f;

		[Token(Token = "0x40026E3")]
		public const int INVALID_SHOP_ITEM_ID = -1;

		[Token(Token = "0x40026E4")]
		public const int OPTION_LOW_FRAME_RATE = 30;

		[Token(Token = "0x40026E5")]
		public const int OPTION_MIDDLE_FRAME_RATE = 45;

		[Token(Token = "0x40026E6")]
		public const int OPTION_HIGH_FRAME_RATE = 60;

		[Token(Token = "0x40026E7")]
		public const int OPTION_LOW_GRAPHIC_QUALITY = 0;

		[Token(Token = "0x40026E8")]
		public const int OPTION_MIDDLE_GRAPHIC_QUALITY = 1;

		[Token(Token = "0x40026E9")]
		public const int OPTION_HIGH_GRAPHIC_QUALITY = 3;

		[Token(Token = "0x40026EA")]
		public const string SCENE_NONE = "";

		[Token(Token = "0x40026EB")]
		public const string SCENE_TITLE = "TitleScene";

		[Token(Token = "0x40026EC")]
		public const string SCENE_LOBBY = "LobbyScene";

		[Token(Token = "0x40026ED")]
		public const string SCENE_GAME = "GameScene";

		[Token(Token = "0x40026EE")]
		public const string SCENE_LOADING = "LoadingScene";

		[Token(Token = "0x40026EF")]
		public const string AUDIOMIXER_PATH = "Sound/AudioMixer/AudioMixer";

		[Token(Token = "0x40026F0")]
		public const string TUTORIAL_ULTIMATE_SKILL_ANI = "ultimate_cinema";

		[Token(Token = "0x40026F1")]
		public const string TUTORIAL_ULTIMATE_SKILL_SOUND = "Tuto_ReinaCinema_01";

		[Token(Token = "0x40026F2")]
		public const string PATH_PREFAB_AUDIO_SOURCE_FROM_POOL = "Prefab/AudioSourceFromPool";

		[Token(Token = "0x40026F3")]
		public const string PATH_PREFAB_GLOBAL_GAMEOBJECT = "Prefab/Logic/GlobalGameObject";

		[Token(Token = "0x40026F4")]
		public const string PATH_PREFAB_MAPOBJECT = "Prefab/MapObject/";

		[Token(Token = "0x40026F5")]
		public const string PATH_PREFAB_SENDBIRD = "Prefab/Logic/SendBird";

		[Token(Token = "0x40026F6")]
		public const string PATH_PREFAB_TAPJOY = "Prefab/Logic/TapjoyUnity";

		[Token(Token = "0x40026F7")]
		public const string PATH_PREFAB_IGAWORKS = "Prefab/Logic/Igaworks";

		[Token(Token = "0x40026F8")]
		public const string PATH_PREFAB_ADJUST = "Prefab/Logic/Adjust";

		[Token(Token = "0x40026F9")]
		public const string PATH_PREFAB_APTELIGENT = "Prefab/Logic/Apteligent";

		[Token(Token = "0x40026FA")]
		public const string PATH_PREFAB_TUNELISTENER = "Prefab/Logic/TuneListener";

		[Token(Token = "0x40026FB")]
		public const string PATH_PREFAB_SYSTEM_DATA = "Prefab/Game/System";

		[Token(Token = "0x40026FC")]
		public const string PATH_PREFAB_SYSTEM_DATA_LEVEL = "Prefab/Game/System_Level";

		[Token(Token = "0x40026FD")]
		public const string PATH_PREFAB_DIE_EFFECT = "Prefab/Effects/Etc/Fx_Die";

		[Token(Token = "0x40026FE")]
		public const string PATH_PREFAB_DIE_MONSTER_EFFECT = "Prefab/Effects/Etc/Fx_Die";

		[Token(Token = "0x40026FF")]
		public const string PATH_PREFAB_TARGET_EFFECT = "Prefab/Effects/Etc/Fx_Target";

		[Token(Token = "0x4002700")]
		public const string PATH_PREFAB_MONSTER_SPAWN_EFFECT = "Prefab/Effects/Etc/Fx_Spawn";

		[Token(Token = "0x4002701")]
		public const string PATH_PREFAB_MAP_OBJECT_SPAWN_EFFECT = "Prefab/Effects/Etc/Fx_Spawn";

		[Token(Token = "0x4002702")]
		public const string PATH_PREFAB_DROP_OBJECT_SPAWN_EFFECT = "Prefab/Effects/Etc/Fx_Spawn";

		[Token(Token = "0x4002703")]
		public const string PATH_PREFAB_TAG_CHAR_CHANGE_EFFECT = "Prefab/Effects/Etc/Fx_Tag";

		[Token(Token = "0x4002704")]
		public const string PATH_PREFAB_RESPAWN_EFFECT = "Prefab/Effects/Etc/Fx_Immune";

		[Token(Token = "0x4002705")]
		public const string PATH_PREFAB_DIE2_EFFECT = "Prefab/Models/Itembox/headstone";

		[Token(Token = "0x4002706")]
		public const string PATH_PREFAB_SHOW_MELEE_SKILL = "Prefab/Models/ShowMeleeSkill";

		[Token(Token = "0x4002707")]
		public const string PATH_PREFAB_SHOW_RANGE_SKILL = "Prefab/Models/ShowRangeSkill";

		[Token(Token = "0x4002708")]
		public const string PATH_PREFAB_TILE_BOTTOM = "Prefab/Tile/Tile_Dummy_Bottom";

		[Token(Token = "0x4002709")]
		public const string PATH_PREFAB_CHARACTER_SHADOW = "Prefab/Models/CharacterShadow";

		[Token(Token = "0x400270A")]
		public const string PATH_PREFAB_CAMERA_ANI = "Prefab/Skills/CameraAni";

		[Token(Token = "0x400270B")]
		public const string PATH_PREFAB_CAMERA_TUTORIAL_CINEMA = "Prefab/CinemaCamera/CameraTutorialEnemyComeAni";

		[Token(Token = "0x400270C")]
		public const string PATH_PREFAB_CAMERA_ULTIMATE_SKILL_CINEMA = "Prefab/CinemaCamera/CameraTutorialUltimateAni";

		[Token(Token = "0x400270D")]
		public const string PATH_PREFAB_INTERFACE_HEALTH_BAR_PLAYER = "Prefab/UI/Game/InterfacePlayer";

		[Token(Token = "0x400270E")]
		public const string PATH_PREFAB_UI_TARGET_INDICATOR = "Prefab/UI/Game/TargetIndicator";

		[Token(Token = "0x400270F")]
		public const string PATH_PREFAB_UI_NAVI_ARROW = "Prefab/UI/Game/UINaviArrow";

		[Token(Token = "0x4002710")]
		public const string PATH_PREFAB_LOBBY_MY_CARD = "Prefab/UI/Lobby/widgetCharacterCard";

		[Token(Token = "0x4002711")]
		public const string PATH_PREFAB_LOBBY_MY_CARDS_GROUP = "Prefab/UI/Lobby/widgetCharacterCardGroup";

		[Token(Token = "0x4002712")]
		public const string PATH_PREFAB_LOBBY_ITEM_ICON = "Prefab/UI/Etc/widgetItemIcon";

		[Token(Token = "0x4002713")]
		public const string PATH_PREFAB_LOBBY_GACHACARD_ICON = "Prefab/UI/Etc/widgetGachaCardIcon";

		[Token(Token = "0x4002714")]
		public const string PATH_PREFAB_LOBBY_CONTENT_ICON = "Prefab/UI/Etc/widgetContentIcon";

		[Token(Token = "0x4002715")]
		public const string PATH_PREFAB_LOBBY_CONTENT_ONELINE_ICON = "Prefab/UI/Etc/widgetContentOnelineIcon";

		[Token(Token = "0x4002716")]
		public const string PATH_PREFAB_TEAM_LEVELUP_POPUP = "Prefab/UI/Etc/widgetTeamLevUPPopup";

		[Token(Token = "0x4002717")]
		public const string PATH_PREFAB_LOBBY_SHOP_ITEM = "Prefab/UI/Lobby/ShopItem";

		[Token(Token = "0x4002718")]
		public const string PATH_PREFAB_LOBBY_MAIL_ITEM = "Prefab/UI/Lobby/MailItem";

		[Token(Token = "0x4002719")]
		public const string PATH_PREFAB_LOBBY_RANKING_ITEM = "Prefab/UI/Lobby/RankingItem";

		[Token(Token = "0x400271A")]
		public const string PATH_PREFAB_LOBBY_CLAN_RANKING_ITEM = "Prefab/UI/Lobby/ClanRankingItem";

		[Token(Token = "0x400271B")]
		public const string PATH_PREFAB_LOBBY_INVEN_ITEM = "Prefab/UI/Lobby/InvenItem";

		[Token(Token = "0x400271C")]
		public const string PATH_PREFAB_LOBBY_QUEST_ITEM = "Prefab/UI/Lobby/QuestItem";

		[Token(Token = "0x400271D")]
		public const string PATH_PREFAB_LOBBY_MISSION_ITEM = "Prefab/UI/Lobby/MissionItem";

		[Token(Token = "0x400271E")]
		public const string PATH_PREFAB_LOBBY_SKYTOWER_ITEM = "Prefab/UI/Lobby/SkyTowerItem";

		[Token(Token = "0x400271F")]
		public const string PATH_PREFAB_LOBBY_FIRST_RANK_REWARD_ITEM = "Prefab/UI/Lobby/FirstRankRewardItem";

		[Token(Token = "0x4002720")]
		public const string PATH_PREFAB_LOBBY_SPECIAL_DUNGEON_ITEM = "Prefab/UI/Lobby/SpecialDungeonItem";

		[Token(Token = "0x4002721")]
		public const string PATH_PREFAB_LOBBY_EVENTBANNER_ITEM = "Prefab/UI/Lobby/EventBannerItem";

		[Token(Token = "0x4002722")]
		public const string PATH_PREFAB_LOBBY_STAGE_BACKGROUND_ITEM = "Prefab/UI/Lobby/StageBgItem";

		[Token(Token = "0x4002723")]
		public const string PATH_PREFAB_LOBBY_BOOK_ITEM_GROUP = "Prefab/UI/Lobby/IllustratedBookItemGroup";

		[Token(Token = "0x4002724")]
		public const string PATH_PREFAB_LOBBY_BOOK_ITEM = "Prefab/UI/Lobby/IllustratedBookItem";

		[Token(Token = "0x4002725")]
		public const string PATH_PREFAB_HUDHEAD_BALLOON = "Prefab/UI/Game/HeadBalloon";

		[Token(Token = "0x4002726")]
		public const string PATH_PREFAB_LOBBY_ACHIEVEMENT_ITEM = "Prefab/UI/Lobby/AchievementItem";

		[Token(Token = "0x4002727")]
		public const string PATH_PREFAB_LOBBY_FRIENDLIST_ITME = "Prefab/UI/Lobby/FriendListItem";

		[Token(Token = "0x4002728")]
		public const string PATH_PREFAB_LOBBY_FRIEND_REQUESTLIST_ITEM = "Prefab/UI/Lobby/FriendRequestListItem";

		[Token(Token = "0x4002729")]
		public const string PATH_PREFAB_LOBBY_FRIEND_RECOMMENDLIST_ITEM = "Prefab/UI/Lobby/FriendRecommendListItem";

		[Token(Token = "0x400272A")]
		public const string PATH_PREFAB_LOBBY_BlOCKFRIENDLIST_ITME = "Prefab/UI/Lobby/BlockFriendListItem";

		[Token(Token = "0x400272B")]
		public const string PATH_PREFAB_LOBBY_TEAMINFORMATION_ITEM = "Prefab/UI/Lobby/TeamCharItem";

		[Token(Token = "0x400272C")]
		public const string PATH_PREFAB_LOBBY_TEAMINFORMATION_GROUP = "Prefab/UI/Lobby/TeamProfileGroup";

		[Token(Token = "0x400272D")]
		public const string PATH_PREFAB_LOBBY_TALENT_ITEM = "Prefab/UI/Lobby/TalentItem";

		[Token(Token = "0x400272E")]
		public const string PATH_PREFAB_LOBBY_TALENT_ITEM_GROUP = "Prefab/UI/Lobby/TalentLineGroup";

		[Token(Token = "0x400272F")]
		public const string PATH_PREFAB_LOBBY_TALENT_PAGE_ITEM = "Prefab/UI/Lobby/TalentPageItem";

		[Token(Token = "0x4002730")]
		public const string PATH_PREFAB_LOBBY_TALENT_PAGE_TAB = "Prefab/UI/Lobby/TalentPageTab";

		[Token(Token = "0x4002731")]
		public const string PATH_PREFAB_TEAMINFOSETTING = "Prefab/UI/Lobby/StageTeamInfoSetting";

		[Token(Token = "0x4002732")]
		public const string PATH_PREFAB_PARTYVIEWER = "Prefab/UI/Lobby/PartyViewer";

		[Token(Token = "0x4002733")]
		public const string PATH_PREFAB_GROUPPARTYINVITEINFO = "Prefab/UI/Lobby/GroupPlay/widgetGroupInvite";

		[Token(Token = "0x4002734")]
		public const string PATH_PREFAB_LOBBY_RELIC_ITEM = "Prefab/UI/Lobby/RelicItem";

		[Token(Token = "0x4002735")]
		public const string PATH_PREFAB_LOBBY_RELIC_ITEM_GROUP = "Prefab/UI/Lobby/RelicItemGroup";

		[Token(Token = "0x4002736")]
		public const string PATH_PREFAB_LOBBY_TITLE_ITEM = "Prefab/UI/Lobby/TitleItem";

		[Token(Token = "0x4002737")]
		public const string PATH_PREFAB_LOBBY_TITLE_ITEM_GROUP = "Prefab/UI/Lobby/TitleItemGroup";

		[Token(Token = "0x4002738")]
		public const string PATH_PREFAB_LOBBY_EMOTICON_ITEM = "Prefab/UI/Lobby/EmoticonItem";

		[Token(Token = "0x4002739")]
		public const string PATH_PREFAB_LOBBY_EMOTICON_ITEM_GROUP = "Prefab/UI/Lobby/EmoticonItemGroup";

		[Token(Token = "0x400273A")]
		public const string PATH_PREFAB_LOBBY_SKIN_ITEM = "Prefab/UI/Lobby/SkinItemCard";

		[Token(Token = "0x400273B")]
		public const string PATH_PREFAB_LOBBY_HELP_ITEM = "Prefab/UI/Lobby/HelpItem";

		[Token(Token = "0x400273C")]
		public const string PATH_PREFAB_LOBBY_RECOMMEND_SHOP_ITEM = "Prefab/UI/Lobby/RecommendShopItem";

		[Token(Token = "0x400273D")]
		public const string PATH_PREFAB_HUDTEXT = "Prefab/UI/Game/HUDText";

		[Token(Token = "0x400273E")]
		public const string PATH_PREFAB_HUDPOINT = "Prefab/UI/Game/HUDPoint";

		[Token(Token = "0x400273F")]
		public const string PATH_PREFAB_HUDTEXT_HITCOMBO = "Prefab/UI/Game/HUDTextHitCombo";

		[Token(Token = "0x4002740")]
		public const string PATH_PREFAB_DEFAULT_HIT_EFFECT = "Prefab/Effects/Etc/Hit_Normal";

		[Token(Token = "0x4002741")]
		public const string PATH_PREFAB_POINT_OBJECT_RED_EFFECT = "Prefab/SFX/PointObjectRed";

		[Token(Token = "0x4002742")]
		public const string PATH_PREFAB_POINT_OBJECT_BLUE_EFFECT = "Prefab/SFX/PointObjectBlue";

		[Token(Token = "0x4002743")]
		public const string PATH_PREFAB_LOBBY_PLAYER = "Prefab/Character/LobbyPlayer";

		[Token(Token = "0x4002744")]
		public const string PATH_PREFAB_MODEL_PREVIEW = "Prefab/Character/ModelPreview";

		[Token(Token = "0x4002745")]
		public const string PATH_PREFAB_NET_PLAYER = "Prefab/Character/NetPlayer";

		[Token(Token = "0x4002746")]
		public const string PATH_PREFAB_PLAYER = "Prefab/Character/Player";

		[Token(Token = "0x4002747")]
		public const string PATH_PREFAB_MONSTER = "Prefab/Character/Monster";

		[Token(Token = "0x4002748")]
		public const string PATH_PREFAB_DROP_OBJECT = "Prefab/Character/DropObject";

		[Token(Token = "0x4002749")]
		public const string PATH_PREFAB_POINT_OBJECT = "Prefab/Character/PointObject";

		[Token(Token = "0x400274A")]
		public const string PATH_PREFAB_UIFOLDER_COMMON = "Prefab/UI/Common/";

		[Token(Token = "0x400274B")]
		public const string PATH_PREFAB_UIFOLDER_TITLE = "Prefab/UI/Title/";

		[Token(Token = "0x400274C")]
		public const string PATH_PREFAB_UIFOLDER_LOBBY = "Prefab/UI/Lobby/";

		[Token(Token = "0x400274D")]
		public const string PATH_PREFAB_UIFOLDER_GAME = "Prefab/UI/Game/";

		[Token(Token = "0x400274E")]
		public const string PATH_PREFAB_UIFOLDER_TUTORIAL = "Prefab/UI/Tutorial/";

		[Token(Token = "0x400274F")]
		public const string PATH_PREFAB_UIFOLDER_BREAKTHROUGH_GOLD = "Prefab/UI/Game/BreakThroughGold";

		[Token(Token = "0x4002750")]
		public const string PATH_PREFAB_UIFOLDER_BREAKTHROUGH_POTION = "Prefab/UI/Game/BreakThroughPotion";

		[Token(Token = "0x4002751")]
		public const string PATH_PREFAB_UIFOLDER_TAG_DIRECTION = "Prefab/UI/Game/TagDirection";

		[Token(Token = "0x4002752")]
		public const string PATH_PREFAB_LobbyMain = "Prefab/UI/Lobby/pnlMain";

		[Token(Token = "0x4002753")]
		public const string PATH_PREFAB_LobbyTop = "Prefab/UI/Lobby/pnlTopBanner";

		[Token(Token = "0x4002754")]
		public const string PATH_PREFAB_GameCommon = "Prefab/UI/Game/pnlGameCommon";

		[Token(Token = "0x4002755")]
		public const string PATH_PREFAB_GameRecords = "Prefab/UI/Game/pnlGameRecords";

		[Token(Token = "0x4002756")]
		public const string PATH_PREFAB_GameResult = "Prefab/UI/Game/pnlGameResult";

		[Token(Token = "0x4002757")]
		public const string PATH_PREFAB_GameResultCharactersDirection = "Prefab/UI/Game/pnlGameResultCharactersDirection";

		[Token(Token = "0x4002758")]
		public const float UI_MESSAGE_BAR_TIME = 5f;

		[Token(Token = "0x4002759")]
		public const string PATH_TEXTURE_SLOT_OUT_LINE = "SlotOutLine/";

		[Token(Token = "0x400275A")]
		public const string PATH_PREFAB_CLEARTICKET_RESULT_x1 = "Prefab/UI/Lobby/pnlClearTicketGameResult_x1";

		[Token(Token = "0x400275B")]
		public const string PATH_PREFAB_CLEARTICKET_RESULT_x5 = "Prefab/UI/Lobby/pnlClearTicketGameResult_x5";

		[Token(Token = "0x400275C")]
		public const string PATH_PREFAB_FRIENDLY_MATCH_ROOM_GROUP = "Prefab/UI/Lobby/FriendlyMatchRoomGroup";

		[Token(Token = "0x400275D")]
		public const string PATH_PREFAB_FRIENDLY_MATCH_ROOM = "Prefab/UI/Lobby/FriendlyMatchRoom";

		[Token(Token = "0x400275E")]
		public const string PATH_PREFAB_CUSTOM_ROOM_GROUP = "Prefab/UI/Lobby/CustomRoomGroup";

		[Token(Token = "0x400275F")]
		public const string PATH_PREFAB_CUSTOM_ROOM = "Prefab/UI/Lobby/CustomRoom";

		[Token(Token = "0x4002760")]
		public const string PATH_PREFAB_QUICK_MATCH_MAP_GROUP = "Prefab/UI/Lobby/QuickMatchMapGroup";

		[Token(Token = "0x4002761")]
		public const string PATH_PREFAB_QUICK_MATCH_MAP_ROOM = "Prefab/UI/Lobby/QuickMatchMap";

		[Token(Token = "0x4002762")]
		public const string PATH_PREFAB_MINI_MAP_MY_PLAYER = "Prefab/UI/Game/miniMyPlayer";

		[Token(Token = "0x4002763")]
		public const string PATH_PREFAB_MINI_MAP_PLAYER = "Prefab/UI/Game/miniPlayer";

		[Token(Token = "0x4002764")]
		public const string PATH_PREFAB_MINI_MAP_ITEM = "Prefab/UI/Game/miniItem";

		[Token(Token = "0x4002765")]
		public const string PATH_PREFAB_MINI_MAP_FLAG_NONE_TEAM = "Prefab/UI/Game/miniFlagTeamNone";

		[Token(Token = "0x4002766")]
		public const string PATH_PREFAB_MINI_MAP_FLAG_A_TEAM = "Prefab/UI/Game/miniFlagTeamAteam";

		[Token(Token = "0x4002767")]
		public const string PATH_PREFAB_MINI_MAP_FLAG_B_TEAM = "Prefab/UI/Game/miniFlagTeamBTeam";

		[Token(Token = "0x4002768")]
		public const string PATH_PREFAB_GAME_RESULT_CHARACTER_CAMERA = "Prefab/UI/Game/GameResultCharacterCamera";

		[Token(Token = "0x4002769")]
		public const string PATH_PREFAB_GET_CHARACTER = "Prefab/UI/Etc/pnlCardDirectionRoot";

		[Token(Token = "0x400276A")]
		public const string PATH_PREFAB_CHAR_RECRUIT = "Prefab/UI/Lobby/pnlCharRecruit";

		[Token(Token = "0x400276B")]
		public const string PATH_PREFAB_GET_PET = "Prefab/UI/Etc/pnlPetDirectionRoot";

		[Token(Token = "0x400276C")]
		public const string PATH_ICON_TIME = "UI_new/icon_time";

		[Token(Token = "0x400276D")]
		public const string PATH_NEW_UI_INGAME = "UI_new/InGame/";

		[Token(Token = "0x400276E")]
		public const string PATH_RANDOM_MODE_MENU_ELEMENT = "UI_new/random";

		[Token(Token = "0x400276F")]
		public const string PATH_AI_MODE_MENU_ELEMENT = "UI_new/practice";

		[Token(Token = "0x4002770")]
		public const string PATH_RESULT_EXPRESSION_DEFEAT = "UI_new/InGame/img_defeat";

		[Token(Token = "0x4002771")]
		public const string PATH_RESULT_EXPRESSION_DRAW = "UI_new/InGame/img_draw";

		[Token(Token = "0x4002772")]
		public const string PATH_RESULT_EXPRESSION_GAMEOVER = "UI_new/InGame/img_over";

		[Token(Token = "0x4002773")]
		public const string PATH_RESULT_EXPRESSION_VICTORY = "UI_new/InGame/img_victory";

		[Token(Token = "0x4002774")]
		public const string PATH_RANK_TIER_SILHOUETTE = "UI_new/silhouette";

		[Token(Token = "0x4002775")]
		public const string PATH_GACHA_RESOURCES = "Gacha/gacha_resources_";

		[Token(Token = "0x4002776")]
		public const float UI_CHARACTER_NAME_HEIGHT = 0.6f;

		[Token(Token = "0x4002777")]
		public const float UI_CHARACTER_NAME_MIN_HEIGHT = 1.5f;

		[Token(Token = "0x4002778")]
		public const float UI_CHARACTER_NAME_MAX_HEIGHT = 2.8f;

		[Token(Token = "0x4002779")]
		public const int PRODUCT_ID_INCREASE_CHARACTER_INVENTORY = 150011;

		[Token(Token = "0x400277A")]
		public const int PRODUCT_ID_INCREASE_ITEM_INVENTORY = 150012;

		[Token(Token = "0x400277B")]
		public const string NOT_OWNED_CHARACTER = "NotOwned";

		[Token(Token = "0x400277C")]
		public const string NOT_OWNED_PET = "NotOwned";

		[Token(Token = "0x400277D")]
		public const string TESTITEM_STRING = "Test";

		[Token(Token = "0x400277E")]
		public const string CHARACTER_GET_DIRECTION_NORMAL = "Prefab/Effects/Han_P/source/han_lv_up";

		[Token(Token = "0x400277F")]
		public const string CHARACTER_GET_DIRECTION_EPIC = "Prefab/Effects/Han_P/source/han_lv_up_epic";

		[Token(Token = "0x4002780")]
		public const string CHARACTER_GET_DIRECTION_LEGEND = "Prefab/Effects/Han_P/source/han_lv_up_legend_ancient";

		[Token(Token = "0x4002781")]
		public const string PET_GET_DIRECTION_NORMAL = "Prefab/Effects/Han_P/source/pet_han_lv_up";

		[Token(Token = "0x4002782")]
		public const string PET_GET_DIRECTION_EPIC = "Prefab/Effects/Han_P/source/pet_han_lv_up_epic";

		[Token(Token = "0x4002783")]
		public const string PET_GET_DIRECTION_LEGEND = "Prefab/Effects/Han_P/source/pet_han_lv_up_legend_ancient";

		[Token(Token = "0x4002784")]
		public const string MATERIAL_DISSOLVE_PATH = "Material/CharacterDissolve";

		[Token(Token = "0x4002785")]
		public const string MATERIAL_HIGH_CHARACTER_PATH = "Material/HightInGameCharacter";

		[Token(Token = "0x4002786")]
		public const string MATERIAL_LOW_CHARACTER_PATH = "Material/LowInGameCharacter";

		[Token(Token = "0x4002787")]
		public const string MATERIAL_LOBBY_CHARACTER_PATH = "Material/LobbyCharacter";

		[Token(Token = "0x4002788")]
		public const string DOUBLE_SIDE_MATERIAL_DISSOLVE_PATH = "Material/DoubleSideCharacterDissolve";

		[Token(Token = "0x4002789")]
		public const string DOUBLE_SIDE_MATERIAL_HIGH_CHARACTER_PATH = "Material/DoubleSideHightInGameCharacter";

		[Token(Token = "0x400278A")]
		public const string DOUBLE_SIDE_MATERIAL_LOW_CHARACTER_PATH = "Material/DoubleSideLowInGameCharacter";

		[Token(Token = "0x400278B")]
		public const string DOUBLE_SIDE_MATERIAL_LOBBY_CHARACTER_PATH = "Material/DoubleSideLobbyCharacter";

		[Token(Token = "0x400278C")]
		public const int OUT_SIDE_RANK = 999;

		[Token(Token = "0x400278D")]
		public const int MAX_PLAYER_COUNT = 6;

		[Token(Token = "0x400278E")]
		public const string defeat = "DEFEAT";

		[Token(Token = "0x400278F")]
		public const string draw = "DRAW";

		[Token(Token = "0x4002790")]
		public const string finish = "FINISH";

		[Token(Token = "0x4002791")]
		public const string victory = "VICTORY!!";

		[Token(Token = "0x4002792")]
		public const int MIN_SECTOR_ID = 10;

		[Token(Token = "0x4002793")]
		public const int MAX_SECTOR_ID = 63;

		[Token(Token = "0x4002794")]
		public const int DEFAULT_MAX_SPAWN_COUNT = 15;

		[Token(Token = "0x4002795")]
		public const float HERO_FOLLOW_DISTANCE = 1.5f;

		[Token(Token = "0x4002796")]
		public const float CHAR_ROT_SPEED = 25f;

		[Token(Token = "0x4002797")]
		public const float DIE_KNOCKBACK_SPEED = 14f;

		[Token(Token = "0x4002798")]
		public const int DEFAULT_LAYER = 0;

		[Token(Token = "0x4002799")]
		public const int IGNORE_RAYCAST_LAYER = 2;

		[Token(Token = "0x400279A")]
		public const int UI_LAYER = 5;

		[Token(Token = "0x400279B")]
		public const int FLOOR_LAYER = 9;

		[Token(Token = "0x400279C")]
		public const int DIE_OBJECT_LAYER = 11;

		[Token(Token = "0x400279D")]
		public const int CHARACTER_LAYER = 14;

		[Token(Token = "0x400279E")]
		public const int ATTACK_COLLISION_LAYER = 15;

		[Token(Token = "0x400279F")]
		public const int MONSTER_LAYER = 17;

		[Token(Token = "0x40027A0")]
		public const int TRIGGER_LAYER = 18;

		[Token(Token = "0x40027A1")]
		public const int MAPOBJECT_LAYER = 19;

		[Token(Token = "0x40027A2")]
		public const int WALL_LAYER = 20;

		[Token(Token = "0x40027A3")]
		public const int GHOST_LAYER = 21;

		[Token(Token = "0x40027A4")]
		public const int NONECOLLISION_LAYER = 24;

		[Token(Token = "0x40027A5")]
		public const int PET_LAYER = 31;

		[Token(Token = "0x40027A6")]
		public const int AVOID_MASK = 671744;

		[Token(Token = "0x40027A7")]
		public const float TILE_WIDTH = 3f;

		[Token(Token = "0x40027A8")]
		public const float TILE_HEIGHT = 3f;

		[Token(Token = "0x40027A9")]
		public const int TAG_INVINCIBLE = 99997;

		[Token(Token = "0x40027AA")]
		public const int BUFF_REBIRTH = 99999;

		[Token(Token = "0x40027AB")]
		public const int BUFF_AROUSAL = 311018;

		[Token(Token = "0x40027AC")]
		public const int AROUSAL_TIME = 90;

		[Token(Token = "0x40027AD")]
		public const string SOUND_GET_COIN = "GetCoin";

		[Token(Token = "0x40027AE")]
		public const string SOUND_GET_CHARACTER = "UICharacterGet";

		[Token(Token = "0x40027AF")]
		public const float TAG_GLOBAL_COOLTIME = 2f;

		[Token(Token = "0x40027B0")]
		public const float TAG_COOLTIME = 10f;

		[Token(Token = "0x40027B1")]
		public const int RECOVERY_SECTOR_LOCK_RATE = 20;

		[Token(Token = "0x40027B2")]
		public const int FRIEND_SECTOR_LOCK_RATE = 10;

		[Token(Token = "0x40027B3")]
		public const float DEFAULT_SIGHT_RANGE = 20f;

		[Token(Token = "0x40027B4")]
		public const int GACHA_GOLD = 100;

		[Token(Token = "0x40027B5")]
		public const int MAPOBJ_ID_GOLD = 30001;

		[Token(Token = "0x40027B6")]
		public const int MAPOBJ_ID_MEAT = 30002;

		[Token(Token = "0x40027B7")]
		public const int MAPOBJ_ID_TRAP = 20006;

		[Token(Token = "0x40027B8")]
		public const int MAPOBJ_ID_MEAT2 = 30002;

		[Token(Token = "0x40027B9")]
		public const int MAPOBJ_ID_TREASURE_COIN = 30001;

		[Token(Token = "0x40027BA")]
		public const int MAPOBJ_ID_TREASURE_HERO = 30002;

		[Token(Token = "0x40027BB")]
		public const int MAPOBJ_ID_TREASURE_WEAPON = 30003;

		[Token(Token = "0x40027BC")]
		public const int MAPOBJ_ID_TILE_DEFAULT_BOTTOM = 5;

		[Token(Token = "0x40027BD")]
		public const bool RANDOM_SPAWN = false;

		[Token(Token = "0x40027BE")]
		public const float RANDOM_RATIO_RANGE = 0.05f;

		[Token(Token = "0x40027BF")]
		public const int WALL_CHARACTER_ID = 90000000;

		[Token(Token = "0x40027C0")]
		public const bool USE_NET_COMMAND_COMPRESSION = true;

		[Token(Token = "0x40027C1")]
		public const int NET_COMMAND_COMPRESSION_THRESHOLD = 256;

		[Token(Token = "0x40027C2")]
		public const float NET_PING_LOBBY_TICK_TIME = 30f;

		[Token(Token = "0x40027C3")]
		public const float NET_POLLING_PROCESS_TICK_TIME = 45f;

		[Token(Token = "0x40027C4")]
		public const float NET_BROADCAST_PROCESS_TIME_TICK = 60f;

		[Token(Token = "0x40027C5")]
		public const float NET_MAINTENANCE_PROCESS_TIME_TICK = 120f;

		[Token(Token = "0x40027C6")]
		public const float CRITICAL_DAMAGE_RATIO = 0.05f;

		[Token(Token = "0x40027C7")]
		public const float AVOID_RATIO = 0f;

		[Token(Token = "0x40027C8")]
		public const int CONTINUE_DUNGEON_CRYSTAL_COUNT = 1;

		[Token(Token = "0x40027C9")]
		public const int STAMINA_RESTORE_PERIOD = 300;

		[Token(Token = "0x40027CA")]
		public const int STAMINA_LIMIT_COUNT = 999;

		[Token(Token = "0x40027CB")]
		public const int ENERGY_RESTORE_PERIOD = 300;

		[Token(Token = "0x40027CC")]
		public const int ENERGY_LIMIT_COUNT = 999;

		[Token(Token = "0x40027CD")]
		public const int BLIND_SIGHT_BUFF_ID = 101;

		[Token(Token = "0x40027CE")]
		public const int BUFF_ID_MASTER_ZOMBIE = 121;

		[Token(Token = "0x40027CF")]
		public const int BUFF_ID_ZOMBIE = 122;

		[Token(Token = "0x40027D0")]
		public const int BUFF_ID_TAGGER = 2000401;

		[Token(Token = "0x40027D1")]
		public const int BUFF_ID_TAGGER_STUN = 2000400;

		[Token(Token = "0x40027D2")]
		public const float TOUCH_STICK_MOVE_ANGLE = 45f;

		[Token(Token = "0x40027D3")]
		public const float DEFAULT_DIE_VISIABLE_TIME = 5f;

		[Token(Token = "0x40027D4")]
		public const float INGAME_MESSAGE_DURATION_TIME = 1f;

		[Token(Token = "0x40027D5")]
		public const float INGAME_JOIN_MESSAGE_DURATION_TIME = 2f;

		[Token(Token = "0x40027D6")]
		public const float INGAME_GOAL_MESSAGE_DURATION_TIME = 5f;

		[Token(Token = "0x40027D7")]
		public const float INGAME_ZOMBIETAG_SUDDEN_DEATH_TIME = 5f;

		[Token(Token = "0x40027D8")]
		public const bool LOG_SOUND = false;

		[Token(Token = "0x40027D9")]
		public const string ASSETBUNDLE_LIST_FILENAME = "AssetBundleList.txt";

		[Token(Token = "0x40027DA")]
		public const int ResetDailyStatsHour = 5;

		[Token(Token = "0x40027DB")]
		public const DayOfWeek ResetWeeklyStatsDay = DayOfWeek.Thursday;

		[Token(Token = "0x40027DC")]
		public const int ResetWeeklyStatsHour = 5;

		[Token(Token = "0x40027DD")]
		public const DayOfWeek ResetDuelRankingDay = DayOfWeek.Thursday;

		[Token(Token = "0x40027DE")]
		public const int ResetDuelRankingHour = 5;

		[Token(Token = "0x40027DF")]
		public const string CHAT_CHANNEL_PREFIX = "Open.Normal";

		[Token(Token = "0x40027E0")]
		public const string CHAT_CLAN_CHANNEL_PREFIX = "Open.Clan";

		[Token(Token = "0x40027E1")]
		public const string CHAT_CLAN_INVITE_CHANNEL_PREFIX = "Open.ClanWarInvite";

		[Token(Token = "0x40027E2")]
		public const string IGAWORKS_POPUP_A_KEY = "heroesarena_notice_a";

		[Token(Token = "0x40027E3")]
		public const string IGAWORKS_POPUP_B_KEY = "heroesarena_notice_b";

		[Token(Token = "0x40027E4")]
		public const string IGAWORKS_POPUP_C_KEY = "heroesarena_notice_c";

		[Token(Token = "0x40027E5")]
		public const string ANIMATION_NONE = "none";

		[Token(Token = "0x40027E6")]
		public const string ANIMATION_BEATEN = "beaten";

		[Token(Token = "0x40027E7")]
		public const string ANIMATION_FAKEBEATEN = "fakebeaten";

		[Token(Token = "0x40027E8")]
		public const string ANIMATION_STUN = "stun";

		[Token(Token = "0x40027E9")]
		public const string ANIMATION_KNOCKBACK = "knockback";

		[Token(Token = "0x40027EA")]
		public const string ANIMATION_THROWUP = "throwup";

		[Token(Token = "0x40027EB")]
		public const string ANIMATION_PULL = "throwup";

		[Token(Token = "0x40027EC")]
		public const string ANIMATION_AIRBORNE = "airborne";

		[Token(Token = "0x40027ED")]
		public const string ANIMATION_PARALYSIS = "paralysis";

		[Token(Token = "0x40027EE")]
		public const string ANIMATION_SPLIT = "throwup";

		[Token(Token = "0x40027EF")]
		public const string LANG_DEFAULT_EN = "en-US";

		[Token(Token = "0x40027F0")]
		public const string DEFAULT_COUNTRY_CODE = "US";

		[Token(Token = "0x40027F1")]
		public const int FIRST_PAGE = 0;

		[Token(Token = "0x40027F2")]
		public const int END_PAGE = -999999;

		[Token(Token = "0x40027F3")]
		public const int LIMIT_EVAL_TEAM_MIN_LEVEL = 7;

		[Token(Token = "0x40027F4")]
		public const int LIMIT_EVAL_TEAM_MAX_LEVEL = 20;

		[Token(Token = "0x40027F5")]
		public const int GAME_EVAL_WINNING_STREAK_COUNT = 2;

		[Token(Token = "0x40027F6")]
		public const int GAME_EVAL_ZOMBIE_RANK = 6;

		[Token(Token = "0x40027F7")]
		public const string FRIENDLY_MATCH_ROOM_NAME_PREFIX = "friendly_";

		[Token(Token = "0x40027F8")]
		public const int FRIENDLY_MATCH_ROOM_NAME_MAX_LENGTH = 30;

		[Token(Token = "0x40027F9")]
		public const string COMMUNITY_URL = "http://m.cafe.naver.com/arenamasters.cafe";

		[Token(Token = "0x40027FA")]
		public const string DDINGDONG_URL = "https://hooks.slack.com/services/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";

		[Token(Token = "0x40027FB")]
		public const string PURCHASE_LOG_URL = "https://hooks.slack.com/services/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";

		[Token(Token = "0x40027FC")]
		public const string JapanCommerceUrl = "http://m.nexon.com/terms/160";

		[Token(Token = "0x40027FD")]
		public const string JapanBillingUrl = "http://m.nexon.com/terms/162";

		[Token(Token = "0x40027FE")]
		public const int NECESSARY_FUSION_CONSUME_ITEM_COUNT = 2;

		[Token(Token = "0x40027FF")]
		public const ItemRarity NECESSARY_FUSION_MIN_RARITY = ItemRarity.Rare;

		[Token(Token = "0x4002800")]
		public const ItemRarity NECESSARY_FUSION_MAX_RARITY = ItemRarity.Ancient;

		[Token(Token = "0x4002801")]
		public const int REFINE_MATERIAL_MAX_COUNT = 10;

		[Token(Token = "0x4002802")]
		public const int MULTIPLE_SELL_MAX_COUNT = 20;

		[Token(Token = "0x4002803")]
		public const int NECESSARY_TRANSCEND_SELECT_ITEM_COUNT = 2;

		[Token(Token = "0x4002804")]
		public const int MAX_ROUND_IN_GAME = 5;

		[Token(Token = "0x4002805")]
		public const int DUEL_MAX_ROUND_IN_GAME = 3;

		[Token(Token = "0x4002806")]
		public const int DUEL_VICTORY_CONDITION_ROUND_WIN_COUNT = 2;

		[Token(Token = "0x4002807")]
		public const int ANNIHILAITON_VICTORY_CONDITION_ROUND_WIN_COUNT = 3;

		[Token(Token = "0x4002808")]
		public const float GRAVITY = -15f;

		[Token(Token = "0x4002809")]
		public const int DEATH_DAMAGE = 99999999;

		[Token(Token = "0x400280A")]
		public const string INIT_DATE_TIME = "0001-01-01";

		[Token(Token = "0x400280B")]
		public const int INIT_INT = -9999;

		[Token(Token = "0x400280C")]
		public const int MISSION_CLEAR_PERFECT_SCORE = 3;

		[Token(Token = "0x400280D")]
		public const int CLEAR_TICKET_MODE_x1 = 1;

		[Token(Token = "0x400280E")]
		public const int CLEAR_TICKET_MODE_x5 = 5;

		[Token(Token = "0x400280F")]
		public const int TRANSCEND_ABLE_MAX_COUNT = 2;

		[Token(Token = "0x4002810")]
		public const int CAPTURE_POINT_REST_TIME = 25;

		[Token(Token = "0x4002811")]
		public const int CAPTURE_POINT_FLAG_DESTROY_TIME = 5;

		[Token(Token = "0x4002812")]
		public const int ZOMBIE_TAG_ZOMBIE_BUFF_ID = 2300002;

		[Token(Token = "0x4002813")]
		public const int ZOMBIE_TAG_ADVANTAGE_BUFF_ID = 2300001;

		[Token(Token = "0x4002814")]
		public const int MAP_PORTAL_EXIT_BUFF_ID = 141;

		[Token(Token = "0x4002815")]
		public const string CHARACTER_STAGE_START_ANI = "stage_start";

		[Token(Token = "0x4002816")]
		public const string CHARACTER_VICTORY_ANI = "result_victory";

		[Token(Token = "0x4002817")]
		public const string CHARACTER_VICTORY_IDLE_ANI = "result_idle";

		[Token(Token = "0x4002818")]
		public const string LOBBY_IDLE_ANI = "intro_idle";

		[Token(Token = "0x4002819")]
		public const string INTRO_ANI = "intro";

		[Token(Token = "0x400281A")]
		public const string INTRO_IDLE_ANI = "intro_idle";

		[Token(Token = "0x400281B")]
		public const string RESULT_VICTORY_ANI = "result_victory";

		[Token(Token = "0x400281C")]
		public const string RESULT_IDLE_ANI = "result_idle";

		[Token(Token = "0x400281D")]
		public const int NOT_SELECTED_ID = -1;

		[Token(Token = "0x400281E")]
		public const int DEFAULT_TITLE_ID = 1;

		[Token(Token = "0x400281F")]
		public const int DEFAULT_PROFILE_ICON_ID = 1;

		[Token(Token = "0x4002820")]
		public const int DEFAULT_EMOTICON_SET_ID = 1;

		[Token(Token = "0x4002821")]
		public const int RELIC_SLOT_DEFAULT_INDEX = 3;

		[Token(Token = "0x4002822")]
		public const float ULTIMATE_MAX_CHARGE_DEFAULT = 10000f;

		[Token(Token = "0x4002823")]
		public const int ROUND_TRIP_TIME_BAD = 170;

		[Token(Token = "0x4002824")]
		public const int ROUND_TRIP_TIME_GOOD = 69;

		[Token(Token = "0x4002825")]
		public const float SHOW_MULTI_KILL_TIME = 1f;

		[Token(Token = "0x4002826")]
		public const int SHOW_STREAK_KILL_COUNT = 3;

		[Token(Token = "0x4002827")]
		public const float SHOW_SCR_CAUTION = 0.3f;

		[Token(Token = "0x4002828")]
		public const int INGAME_CHAT_MESSAGE_LEN = 20;

		[Token(Token = "0x4002829")]
		public const int CHAT_MESSAGE_MAX = 100;

		[Token(Token = "0x400282A")]
		public const int SHOP_CRYTICKET_PRODUCTID = 110;

		[Token(Token = "0x400282B")]
		public const int SHOP_CRYTICKET_PREMIUM_PRODUCTID = 120;

		[Token(Token = "0x400282C")]
		public const string HEXADECIMAL_COLOR_WHITE = "FFFFFF";

		[Token(Token = "0x400282D")]
		public const int TALENT_GROUP_MAX_COUNT = 3;

		[Token(Token = "0x400282E")]
		public const string NORMAL_BUFF_ID = "70000";

		[Token(Token = "0x400282F")]
		public const string PREMIUM_BUFF_ID = "70001";

		[Token(Token = "0x4002830")]
		public const int SKY_TOWER_LAST_FLOOR = 100;

		[Token(Token = "0x4002831")]
		public const int TUTORIAL_AI_SECTOR_ID_1 = 2004;

		[Token(Token = "0x4002832")]
		public const int TUTORIAL_AI_SECTOR_ID_2 = 2003;

		[Token(Token = "0x4002833")]
		public const bool IsDebugStackCommandLog = true;

		[Token(Token = "0x4002834")]
		public const int IsDebugStackCommandCount = 10;

		[Token(Token = "0x4002835")]
		public const string GOOGLE_PLAY_URL = "https://play.google.com/store/apps/details?id=com.nexon.am";

		[Token(Token = "0x4002836")]
		public const string APPLE_APPSTORE_URL = "https://itunes.apple.com/app/id1157844657";

		[Token(Token = "0x4002837")]
		public const int SpeedHackintervalMs = 4000;

		[Token(Token = "0x4002838")]
		public const int SpeedHackCheckTimeMsPVE = 2147383647;

		[Token(Token = "0x4002839")]
		public const int SpeedHackCheckTimeMsPVP = 20000;

		[Token(Token = "0x400283A")]
		public const int SpeedHackInvalidCheckCount = 3;

		[Token(Token = "0x400283B")]
		public const int SpeedHackDiffQueueCount = 10;

		[Token(Token = "0x400283C")]
		public const int MaxBadMannerClickCount = 5;

		[Token(Token = "0x400283D")]
		public const string CONTENTS_TAGS_DEVELOP = "dev";

		[Token(Token = "0x400283E")]
		public const string CONTENTS_TAGS_STABLE = "";

		[Token(Token = "0x400283F")]
		public const string ARCHIEVEMENT_GET_CHAR = "char_get";

		[Token(Token = "0x4002840")]
		public const string ARCHIEVEMENT_SKYTOWER = "win_solo";

		[Token(Token = "0x4002841")]
		public const string ARCHIEVEMENT_PROMOTION = "terms_item_promotion";

		[Token(Token = "0x4002842")]
		public const string ARCHIEVEMENT_FUSION = "terms_item_fusion";

		[Token(Token = "0x4002843")]
		public const string ARCHIEVEMENT_GET_EPIC = "accum_item_get_epic";

		[Token(Token = "0x4002844")]
		public const string ARCHIEVEMENT_GET_LEGEND = "accum_item_get_legend";

		[Token(Token = "0x4002845")]
		public const string ARCHIEVEMENT_GET_ANCIENT = "accum_item_get_ancient";

		[Token(Token = "0x4002846")]
		public const int RECOMMANDED_FRIEND_SEARCH_DAY = 7;

		[Token(Token = "0x4002847")]
		public const int ACCOUNT_BLOCK_CHANGE_MASTER_DAY = 7;

		[Token(Token = "0x4002848")]
		public const int ACCOUNT_LEAVE_DEFER_DAY = 7;

		[Token(Token = "0x4002849")]
		public const int ONE_DAY_INVITE_FRIEND_LIMIT = 150;

		[Token(Token = "0x400284A")]
		public const int ONE_DAY_REMOVE_FRIEND_LIMIT = 10;

		[Token(Token = "0x400284B")]
		public const int EMPTY_GAME_ROOM_TTL = 5000;

		[Token(Token = "0x400284C")]
		public const bool PROFILERCHECK = false;

		[Token(Token = "0x400284D")]
		public const int PLACEMENT_TEST_PLAY_COUNT = 10;

		[Token(Token = "0x400284E")]
		public const int BROADCAST_WIN_STREAK = 5;

		[Token(Token = "0x400284F")]
		public const int BROADCAST_EXPIRE_ELAPSED_MIN = 3;

		[Token(Token = "0x4002850")]
		public const int TAKE_TROPHY_REWARD_COUNT_MAX = 2;

		[Token(Token = "0x4002851")]
		public const bool USE_FIND_REGION_GAME_SERVER = true;

		[Token(Token = "0x4002852")]
		public const string DEFAULT_RESION_GAME_SERVER_KEY = "";

		[Token(Token = "0x4002853")]
		public const int FREE_BOX_LOCAL_PUSH_ID = 100;

		[Token(Token = "0x4002854")]
		public const int PANDORA_LOCAL_PUSH_ID = 200;

		[Token(Token = "0x4002855")]
		public const int ChattingMessageDaysToKeep = 3;

		[Token(Token = "0x4002856")]
		public const int LoadMessageCount = 100;

		[Token(Token = "0x4002857")]
		public const string ExtraCharUid = "extraCharUid";

		[Token(Token = "0x4002858")]
		public const string XML_DATE_FORMAT = "yyyy/MM/dd/HH/mm";

		[Token(Token = "0x4002859")]
		public const int PointVerserCheckDefault = -1;

		[Token(Token = "0x400285A")]
		[FieldOffset(Offset = "0x0")]
		public static string ServerAddr_Local;

		[Token(Token = "0x400285B")]
		[FieldOffset(Offset = "0x4")]
		public static readonly string PhotonAddr_Local;

		[Token(Token = "0x400285C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ServerDateTimeOffset;

		[Token(Token = "0x400285D")]
		[FieldOffset(Offset = "0xC")]
		public static string NJPwd;

		[Token(Token = "0x400285E")]
		[FieldOffset(Offset = "0x10")]
		public static string EncryptPWD;

		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0x14")]
		public static ConnectEnum.ServerType CONNECT_SERVER_TYPE;

		[Token(Token = "0x4002860")]
		[FieldOffset(Offset = "0x18")]
		public static string PHOTON_CHAT_APPLICATION_ASIA_ID;

		[Token(Token = "0x4002861")]
		[FieldOffset(Offset = "0x1C")]
		public static string PHOTON_CHAT_APPLICATION_US_ID;

		[Token(Token = "0x4002862")]
		[FieldOffset(Offset = "0x20")]
		public static string PHOTON_CHAT_APPLICATION_KOREA_ID;

		[Token(Token = "0x4002863")]
		[FieldOffset(Offset = "0x24")]
		public static string PHOTON_CHAT_APPLICATION_DEV_ID;

		[Token(Token = "0x4002864")]
		[FieldOffset(Offset = "0x28")]
		public static int ANDROID_MARKET_TYPE_NUMBER;

		[Token(Token = "0x4002865")]
		[FieldOffset(Offset = "0x2C")]
		public static int IOS_MARKET_TYPE_NUMBER;

		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0x30")]
		public static string GOOGLE_PUSH_PROJECT_NUMBER;

		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0x34")]
		public static Encoding ENCODING;

		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0x38")]
		public static string FOR_DEVELOP_NEXON_NPSN;

		[Token(Token = "0x4002869")]
		[FieldOffset(Offset = "0x3C")]
		public static string FOR_DEVELOP_NEXON_TOKEN;

		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string NEXON_SERVICE_ID_DEV;

		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x44")]
		public static readonly string NEXON_SERVICE_ID_STAGE;

		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string NEXON_SERVICE_ID_LIVE;

		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly string NEXON_STORE_ID_DEV;

		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string NEXON_STORE_ID_STAGE;

		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x54")]
		public static readonly string NEXON_STORE_ID_LIVE;

		[Token(Token = "0x4002870")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string ANDROID_STRNIG_XML_PATH;

		[Token(Token = "0x4002871")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly string ANDROID_STRINGS_NPA_ID;

		[Token(Token = "0x4002872")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string ANDROID_STRINGS_PURCHASE_ID;

		[Token(Token = "0x4002873")]
		[FieldOffset(Offset = "0x64")]
		public static string ANDROID_BANNER_NUM_CHECK_TITLE;

		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x68")]
		public static string ANDROID_BANNER_NUM_EVENT_TITLE;

		[Token(Token = "0x4002875")]
		[FieldOffset(Offset = "0x6C")]
		public static string ANDROID_BANNER_NUM_QUESTION;

		[Token(Token = "0x4002876")]
		[FieldOffset(Offset = "0x70")]
		public static string ANDROID_BANNER_NUM_INFO;

		[Token(Token = "0x4002877")]
		[FieldOffset(Offset = "0x74")]
		public static string IOS_BANNER_NUM_CHECK_TITLE;

		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x78")]
		public static string IOS_BANNER_NUM_EVENT_TITLE;

		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x7C")]
		public static string IOS_BANNER_NUM_QUESTION;

		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x80")]
		public static string IOS_BANNER_NUM_INFO;

		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x84")]
		public static int ANDROID_BASEPLATE_NUM_INFO;

		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x88")]
		public static int IOS_BASEPLATE_NUM_INFO;

		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x8C")]
		public static string LOCALE_KOREAN;

		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x90")]
		public static string LOCALE_ENGLISH;

		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x94")]
		public static string LOCALE_THAI;

		[Token(Token = "0x4002880")]
		[FieldOffset(Offset = "0x98")]
		public static string LOCALE_JAPANESE;

		[Token(Token = "0x4002881")]
		[FieldOffset(Offset = "0x9C")]
		public static string LOCALE_CHINESETRADITIONAL;

		[Token(Token = "0x4002882")]
		[FieldOffset(Offset = "0xA0")]
		public static string LOCALE_CHINESESIMPLIFIED;

		[Token(Token = "0x4002883")]
		[FieldOffset(Offset = "0xA4")]
		public static bool DefaultStatIsPVP;

		[Token(Token = "0x4002884")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string[] PORTRAIT_FRAME_PATH;

		[Token(Token = "0x4002885")]
		[FieldOffset(Offset = "0xAC")]
		public static readonly string[] PORTRAIT_LEVEL_FRAME_PATH;

		[Token(Token = "0x4002886")]
		[FieldOffset(Offset = "0xB0")]
		public static bool NET_ENABLE_DEBUG_LOG;

		[Token(Token = "0x4002887")]
		[FieldOffset(Offset = "0xB4")]
		public static readonly int[] PLAYER_CHAR_ID;

		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0xB8")]
		public static string STR_AVOID;

		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0xBC")]
		public static string STR_CRITICAL;

		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0xC0")]
		public static string STR_LEVEL_FORMAT;

		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0xC4")]
		public static readonly string[] MULTI_KILL_PATH;

		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0xC8")]
		public static bool AlwaysLadderOpenTest;

		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0xC9")]
		public static bool GetOTPProcessEnable;

		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x2228CF0", Offset = "0x2228CF0", VA = "0x2228CF0")]
		public CSConst()
		{
		}
	}
}
