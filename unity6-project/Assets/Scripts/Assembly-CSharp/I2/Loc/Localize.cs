using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2000085")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x2000086")]
		public enum TermModification
		{
			[Token(Token = "0x4000261")]
			DontModify = 0,
			[Token(Token = "0x4000262")]
			ToUpper = 1,
			[Token(Token = "0x4000263")]
			ToLower = 2,
			[Token(Token = "0x4000264")]
			ToUpperFirst = 3,
			[Token(Token = "0x4000265")]
			ToTitle = 4
		}

		[Token(Token = "0x2000087")]
		public delegate void DelegateSetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x2000088")]
		public delegate void DelegateDoLocalize(string primaryTerm, string secondaryTerm);

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string mTerm;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public UnityEngine.Object mTarget;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DelegateSetFinalTerms EventSetFinalTerms;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DelegateDoLocalize EventDoLocalize;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool CanUseSecondaryTerm;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool AllowMainTermToBeRTL;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool AllowSecondTermToBeRTL;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool IgnoreRTL;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public UnityEngine.Object[] TranslatedObjects;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string SecondaryTranslation;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string CallBackTerm;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private UILabel mTarget_UILabel;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UISprite mTarget_UISprite;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private UITexture mTarget_UITexture;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NGUIText.Alignment mOriginalAlignmentNGUI;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Text mTarget_uGUI_Text;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image mTarget_uGUI_Image;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private RawImage mTarget_uGUI_RawImage;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextAnchor mOriginalAlignmentUGUI;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private UnityEngine.Component mTarget_GUIText;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMesh mTarget_TextMesh;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private AudioSource mTarget_AudioSource;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UnityEngine.Component mTarget_GUITexture;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private GameObject mTarget_Child;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool mInitializeAlignment;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private TextAlignment mOriginalAlignmentStd;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action m_EventFindTarget;

		[Token(Token = "0x1700008B")]
		public string Term
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xD78524", Offset = "0xD78524", VA = "0xD78524")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xD7852C", Offset = "0xD7852C", VA = "0xD7852C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public string SecondaryTerm
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xD78648", Offset = "0xD78648", VA = "0xD78648")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xD78650", Offset = "0xD78650", VA = "0xD78650")]
			set
			{
			}
		}

		[Token(Token = "0x14000054")]
		public event Action EventFindTarget
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xD7820C", Offset = "0xD7820C", VA = "0xD7820C")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xD78398", Offset = "0xD78398", VA = "0xD78398")]
			remove
			{
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD780F4", Offset = "0xD780F4", VA = "0xD780F4")]
		public Localize()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD7865C", Offset = "0xD7865C", VA = "0xD7865C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xD786B4", Offset = "0xD786B4", VA = "0xD786B4")]
		private void RegisterTargets()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD795A0", Offset = "0xD795A0", VA = "0xD795A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD7467C", Offset = "0xD7467C", VA = "0xD7467C")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xD795A8", Offset = "0xD795A8", VA = "0xD795A8")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		public void FindAndCacheTarget<T>(ref T targetCache, DelegateSetFinalTerms setFinalTerms, DelegateDoLocalize doLocalize, bool UseSecondaryTerm, bool MainRTL, bool SecondRTL) where T : Component
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xD799CC", Offset = "0xD799CC", VA = "0xD799CC")]
		private void FindAndCacheTarget(ref GameObject targetCache, DelegateSetFinalTerms setFinalTerms, DelegateDoLocalize doLocalize, bool UseSecondaryTerm, bool MainRTL, bool SecondRTL)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xD786E8", Offset = "0xD786E8", VA = "0xD786E8")]
		private bool HasTargetCache()
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xD79608", Offset = "0xD79608", VA = "0xD79608")]
		public void GetFinalTerms(out string PrimaryTerm, out string SecondaryTerm)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xD79D7C", Offset = "0xD79D7C", VA = "0xD79D7C")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD79E78", Offset = "0xD79E78", VA = "0xD79E78")]
		private void SetFinalTerms(string Main, string Secondary, out string PrimaryTerm, out string SecondaryTerm, bool RemoveNonASCII)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD78534", Offset = "0xD78534", VA = "0xD78534")]
		public void SetTerm(string primary, [Optional] string secondary)
		{
		}

		[Token(Token = "0x6000457")]
		private T GetSecondaryTranslatedObj<T>(ref string MainTranslation, ref string SecondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		private T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xD79FCC", Offset = "0xD79FCC", VA = "0xD79FCC")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
			secondary = default;
			value = default;
		}

		[Token(Token = "0x600045B")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD7A164", Offset = "0xD7A164", VA = "0xD7A164")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD7A2D0", Offset = "0xD7A2D0", VA = "0xD7A2D0")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD7A3D0", Offset = "0xD7A3D0", VA = "0xD7A3D0")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD78F24", Offset = "0xD78F24", VA = "0xD78F24")]
		public static void RegisterEvents_2DToolKit()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xD78B0C", Offset = "0xD78B0C", VA = "0xD78B0C")]
		public static void RegisterEvents_DFGUI()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xD786F8", Offset = "0xD786F8", VA = "0xD786F8")]
		public void RegisterEvents_NGUI()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xD7A470", Offset = "0xD7A470", VA = "0xD7A470")]
		private void FindTarget_UILabel()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xD7A5B4", Offset = "0xD7A5B4", VA = "0xD7A5B4")]
		private void FindTarget_UISprite()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xD7A6D0", Offset = "0xD7A6D0", VA = "0xD7A6D0")]
		private void FindTarget_UITexture()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xD7A7E8", Offset = "0xD7A7E8", VA = "0xD7A7E8")]
		private void SetFinalTerms_UIlabel(string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = default;
			secondaryTerm = default;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xD7A980", Offset = "0xD7A980", VA = "0xD7A980")]
		public void SetFinalTerms_UISprite(string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = default;
			secondaryTerm = default;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xD7AB48", Offset = "0xD7AB48", VA = "0xD7AB48")]
		public void SetFinalTerms_UITexture(string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = default;
			secondaryTerm = default;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xD7AC10", Offset = "0xD7AC10", VA = "0xD7AC10")]
		public void DoLocalize_UILabel(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xD7B288", Offset = "0xD7B288", VA = "0xD7B288")]
		public void DoLocalize_UISprite(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xD7B564", Offset = "0xD7B564", VA = "0xD7B564")]
		public void DoLocalize_UITexture(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xD7959C", Offset = "0xD7959C", VA = "0xD7959C")]
		public static void RegisterEvents_SVG()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xD78F28", Offset = "0xD78F28", VA = "0xD78F28")]
		public static void RegisterEvents_TextMeshPro()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xD78B10", Offset = "0xD78B10", VA = "0xD78B10")]
		public void RegisterEvents_UGUI()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xD7B744", Offset = "0xD7B744", VA = "0xD7B744")]
		private void FindTarget_uGUI_Text()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xD7B860", Offset = "0xD7B860", VA = "0xD7B860")]
		private void FindTarget_uGUI_Image()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD7B978", Offset = "0xD7B978", VA = "0xD7B978")]
		private void FindTarget_uGUI_RawImage()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xD7BA90", Offset = "0xD7BA90", VA = "0xD7BA90")]
		private void SetFinalTerms_uGUI_Text(string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = default;
			secondaryTerm = default;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD7BC4C", Offset = "0xD7BC4C", VA = "0xD7BC4C")]
		public void SetFinalTerms_uGUI_Image(string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = default;
			secondaryTerm = default;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD7BD14", Offset = "0xD7BD14", VA = "0xD7BD14")]
		public void SetFinalTerms_uGUI_RawImage(string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = default;
			secondaryTerm = default;
		}

		[Token(Token = "0x6000474")]
		public static T FindInParents<T>(Transform tr) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xD7BDB8", Offset = "0xD7BDB8", VA = "0xD7BDB8")]
		public void DoLocalize_uGUI_Text(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xD7C310", Offset = "0xD7C310", VA = "0xD7C310")]
		public void DoLocalize_uGUI_Image(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xD7C49C", Offset = "0xD7C49C", VA = "0xD7C49C")]
		public void DoLocalize_uGUI_RawImage(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xD78F2C", Offset = "0xD78F2C", VA = "0xD78F2C")]
		public void RegisterEvents_UnityStandard()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xD7C628", Offset = "0xD7C628", VA = "0xD7C628")]
		private void FindTarget_GUIText()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xD7C744", Offset = "0xD7C744", VA = "0xD7C744")]
		private void FindTarget_TextMesh()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xD7C860", Offset = "0xD7C860", VA = "0xD7C860")]
		private void FindTarget_AudioSource()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xD7C978", Offset = "0xD7C978", VA = "0xD7C978")]
		private void FindTarget_GUITexture()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xD7CA90", Offset = "0xD7CA90", VA = "0xD7CA90")]
		private void FindTarget_Child()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xD7CB94", Offset = "0xD7CB94", VA = "0xD7CB94")]
		public void SetFinalTerms_GUIText(string Main, string Secondary, out string PrimaryTerm, out string SecondaryTerm)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xD7CD28", Offset = "0xD7CD28", VA = "0xD7CD28")]
		public void SetFinalTerms_TextMesh(string Main, string Secondary, out string PrimaryTerm, out string SecondaryTerm)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xD7CEC0", Offset = "0xD7CEC0", VA = "0xD7CEC0")]
		public void SetFinalTerms_GUITexture(string Main, string Secondary, out string PrimaryTerm, out string SecondaryTerm)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xD7D150", Offset = "0xD7D150", VA = "0xD7D150")]
		public void SetFinalTerms_AudioSource(string Main, string Secondary, out string PrimaryTerm, out string SecondaryTerm)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xD7D3E0", Offset = "0xD7D3E0", VA = "0xD7D3E0")]
		public void SetFinalTerms_Child(string Main, string Secondary, out string PrimaryTerm, out string SecondaryTerm)
		{
			PrimaryTerm = default;
			SecondaryTerm = default;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xD7D510", Offset = "0xD7D510", VA = "0xD7D510")]
		private void DoLocalize_GUIText(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xD7D830", Offset = "0xD7D830", VA = "0xD7D830")]
		private void DoLocalize_TextMesh(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xD7DBA4", Offset = "0xD7DBA4", VA = "0xD7DBA4")]
		private void DoLocalize_AudioSource(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xD7DD50", Offset = "0xD7DD50", VA = "0xD7DD50")]
		private void DoLocalize_GUITexture(string MainTranslation, string SecondaryTranslation)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xD7DEE0", Offset = "0xD7DEE0", VA = "0xD7DEE0")]
		private void DoLocalize_Child(string MainTranslation, string SecondaryTranslation)
		{
		}
	}
}
