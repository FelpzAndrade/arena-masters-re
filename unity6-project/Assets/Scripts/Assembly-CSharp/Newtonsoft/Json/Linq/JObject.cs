using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E4")]
	public class JObject : JContainer, INotifyPropertyChanged
	{
		[Token(Token = "0x20000E5")]
		private class JPropertKeyedCollection : KeyedCollection<string, JToken>
		{
			[Token(Token = "0x1700014F")]
			public new IDictionary<string, JToken> Dictionary
			{
				[Token(Token = "0x6000887")]
				[Address(RVA = "0xF91784", Offset = "0xF91784", VA = "0xF91784")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xF91098", Offset = "0xF91098", VA = "0xF91098")]
			public JPropertKeyedCollection(IEqualityComparer<string> comparer)
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0xF954D4", Offset = "0xF954D4", VA = "0xF954D4", Slot = "37")]
			protected override string GetKeyForItem(JToken item)
			{
				return null;
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0xF9558C", Offset = "0xF9558C", VA = "0xF9558C", Slot = "34")]
			protected override void InsertItem(int index, JToken item)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		private sealed class _003CGetEnumerator_003Ec__Iterator1E : IDisposable
		{
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x8")]
			internal IEnumerator<JToken> _003C_0024s_87_003E__0;

			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0xC")]
			internal JProperty _003Cproperty_003E__1;

			[Token(Token = "0x40003C9")]
			[FieldOffset(Offset = "0x10")]
			internal int _0024PC;

			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x14")]
			internal KeyValuePair<string, JToken> _0024current;

			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x1C")]
			internal JObject _003C_003Ef__this;

			[Token(Token = "0x17000150")]
			private KeyValuePair<string, JToken> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECurrent
			{
				[Token(Token = "0x6000889")]
				[Address(RVA = "0xF94E60", Offset = "0xF94E60", VA = "0xF94E60", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000151")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600088A")]
				[Address(RVA = "0xF94E74", Offset = "0xF94E74", VA = "0xF94E74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0xF94D74", Offset = "0xF94D74", VA = "0xF94D74")]
			public _003CGetEnumerator_003Ec__Iterator1E()
			{
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0xF94E60", Offset = "0xF94E60", VA = "0xF94E60", Slot = "8")]
			[DebuggerHidden]
			private KeyValuePair<string, JToken> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_Current()
			{
				return default(KeyValuePair<string, JToken>);
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0xF94E74", Offset = "0xF94E74", VA = "0xF94E74", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0xF94F0C", Offset = "0xF94F0C", VA = "0xF94F0C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0xF95330", Offset = "0xF95330", VA = "0xF95330", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0xF95440", Offset = "0xF95440", VA = "0xF95440", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x2C")]
		private JPropertKeyedCollection _properties;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x30")]
		private PropertyChangedEventHandler m_PropertyChanged;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x0")]
		private static Func<JProperty, JToken> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x17000148")]
		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EKeys
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xF91808", Offset = "0xF91808", VA = "0xF91808", Slot = "69")]
			get
			{
				return System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Keys();
			}
		}

		[Token(Token = "0x17000149")]
		private ICollection<JToken> System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EValues
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xF91920", Offset = "0xF91920", VA = "0xF91920", Slot = "70")]
			get
			{
				return System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Values();
			}
		}

		[Token(Token = "0x1700014A")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EIsReadOnly
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xF922C4", Offset = "0xF922C4", VA = "0xF922C4", Slot = "72")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x1700014B")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xF92E8C", Offset = "0xF92E8C", VA = "0xF92E8C", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		public override JTokenType Type
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xF93604", Offset = "0xF93604", VA = "0xF93604", Slot = "13")]
			get
			{
				return default(JTokenType);
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700014D")]
		[Token(Token = "0x6000873")]
		[Address(RVA = "0xF93820", Offset = "0xF93820", VA = "0xF93820", Slot = "15")]
		public override JToken get_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xF93AF4", Offset = "0xF93AF4", VA = "0xF93AF4", Slot = "16")]
		public override void set_Item(object key, JToken value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700014E")]
		[Token(Token = "0x6000875")]
		[Address(RVA = "0xF93A44", Offset = "0xF93A44", VA = "0xF93A44", Slot = "67")]
		public JToken get_Item(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xF93D20", Offset = "0xF93D20", VA = "0xF93D20", Slot = "68")]
		public void set_Item(string propertyName, JToken value)
		{
		}

		[Token(Token = "0x14000057")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xF91330", Offset = "0xF91330", VA = "0xF91330", Slot = "91")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xF914BC", Offset = "0xF914BC", VA = "0xF914BC", Slot = "92")]
			remove
			{
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xF9002C", Offset = "0xF9002C", VA = "0xF9002C")]
		public JObject()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xF91124", Offset = "0xF91124", VA = "0xF91124")]
		public JObject(JObject other)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xF9120C", Offset = "0xF9120C", VA = "0xF9120C")]
		public JObject(params object[] content)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xF91210", Offset = "0xF91210", VA = "0xF91210")]
		public JObject(object content)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xF91648", Offset = "0xF91648", VA = "0xF91648", Slot = "64")]
		private bool System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xF91808", Offset = "0xF91808", VA = "0xF91808", Slot = "69")]
		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xF91920", Offset = "0xF91920", VA = "0xF91920", Slot = "70")]
		private ICollection<JToken> System_002ECollections_002EGeneric_002EIDictionary_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xF91A38", Offset = "0xF91A38", VA = "0xF91A38", Slot = "73")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EAdd(KeyValuePair<string, JToken> item)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xF91C70", Offset = "0xF91C70", VA = "0xF91C70", Slot = "74")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EClear()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xF91C74", Offset = "0xF91C74", VA = "0xF91C74", Slot = "75")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EContains(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xF91D60", Offset = "0xF91D60", VA = "0xF91D60", Slot = "76")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xF922C4", Offset = "0xF922C4", VA = "0xF922C4", Slot = "72")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_IsReadOnly()
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xF922CC", Offset = "0xF922CC", VA = "0xF922CC", Slot = "77")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003Cstring_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ERemove(KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xF9248C", Offset = "0xF9248C", VA = "0xF9248C", Slot = "88")]
		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties()
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xF92580", Offset = "0xF92580", VA = "0xF92580", Slot = "89")]
		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xF92BC0", Offset = "0xF92BC0", VA = "0xF92BC0", Slot = "79")]
		private AttributeCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetAttributes()
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xF92C70", Offset = "0xF92C70", VA = "0xF92C70", Slot = "80")]
		private string System_002EComponentModel_002EICustomTypeDescriptor_002EGetClassName()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xF92C78", Offset = "0xF92C78", VA = "0xF92C78", Slot = "81")]
		private string System_002EComponentModel_002EICustomTypeDescriptor_002EGetComponentName()
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xF92C80", Offset = "0xF92C80", VA = "0xF92C80", Slot = "82")]
		private TypeConverter System_002EComponentModel_002EICustomTypeDescriptor_002EGetConverter()
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xF92D0C", Offset = "0xF92D0C", VA = "0xF92D0C", Slot = "83")]
		private EventDescriptor System_002EComponentModel_002EICustomTypeDescriptor_002EGetDefaultEvent()
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xF92D14", Offset = "0xF92D14", VA = "0xF92D14", Slot = "84")]
		private PropertyDescriptor System_002EComponentModel_002EICustomTypeDescriptor_002EGetDefaultProperty()
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xF92D1C", Offset = "0xF92D1C", VA = "0xF92D1C", Slot = "85")]
		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetEditor(Type editorBaseType)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xF92D24", Offset = "0xF92D24", VA = "0xF92D24", Slot = "87")]
		private EventDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetEvents(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xF92DD4", Offset = "0xF92DD4", VA = "0xF92DD4", Slot = "86")]
		private EventDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetEvents()
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xF92E84", Offset = "0xF92E84", VA = "0xF92E84", Slot = "90")]
		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xF92E94", Offset = "0xF92E94", VA = "0xF92E94", Slot = "12")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xF92F54", Offset = "0xF92F54", VA = "0xF92F54", Slot = "52")]
		internal override void InsertItem(int index, JToken item)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xF92FB8", Offset = "0xF92FB8", VA = "0xF92FB8", Slot = "61")]
		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xF93510", Offset = "0xF93510", VA = "0xF93510")]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xF93570", Offset = "0xF93570", VA = "0xF93570")]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xF93574", Offset = "0xF93574", VA = "0xF93574", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xF9360C", Offset = "0xF9360C", VA = "0xF9360C")]
		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xF902A8", Offset = "0xF902A8", VA = "0xF902A8")]
		public JProperty Property(string name)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xF936C0", Offset = "0xF936C0", VA = "0xF936C0")]
		public JEnumerable<JToken> PropertyValues()
		{
			return default(JEnumerable<JToken>);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xF93FF8", Offset = "0xF93FF8", VA = "0xF93FF8")]
		public new static JObject Load(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xF94380", Offset = "0xF94380", VA = "0xF94380")]
		public new static JObject Parse(string json)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xF94438", Offset = "0xF94438", VA = "0xF94438")]
		public new static JObject FromObject(object o)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xF944CC", Offset = "0xF944CC", VA = "0xF944CC")]
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xF9473C", Offset = "0xF9473C", VA = "0xF9473C", Slot = "22")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xF94B50", Offset = "0xF94B50", VA = "0xF94B50", Slot = "63")]
		public void Add(string propertyName, JToken value)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xF94C20", Offset = "0xF94C20", VA = "0xF94C20", Slot = "65")]
		public bool Remove(string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xF94D3C", Offset = "0xF94D3C", VA = "0xF94D3C", Slot = "66")]
		public bool TryGetValue(string propertyName, out JToken value)
		{
			value = default;
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xF94D70", Offset = "0xF94D70", VA = "0xF94D70", Slot = "23")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xF9290C", Offset = "0xF9290C", VA = "0xF9290C", Slot = "78")]
		[DebuggerHidden]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xF94D7C", Offset = "0xF94D7C", VA = "0xF94D7C", Slot = "93")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xF929B0", Offset = "0xF929B0", VA = "0xF929B0")]
		private static Type GetTokenPropertyType(JToken token)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xF94E38", Offset = "0xF94E38", VA = "0xF94E38")]
		private static JToken _003CPropertyValues_003Em__3A(JProperty p)
		{
			return null;
		}
	}
}
