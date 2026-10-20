using System.Collections;
using Il2CppDummyDll;

namespace Newtonsoft.Json.ObservableSupport
{
	[Token(Token = "0x20000FF")]
	public class NotifyCollectionChangedEventArgs
	{
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x8")]
		private NotifyCollectionChangedAction Action__BackingField;

		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0xC")]
		private IList NewItems__BackingField;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x10")]
		private int NewStartingIndex__BackingField;

		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x14")]
		private IList OldItems__BackingField;

		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x18")]
		private int OldStartingIndex__BackingField;

		[Token(Token = "0x1700017A")]
		internal NotifyCollectionChangedAction Action
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xFA6D90", Offset = "0xFA6D90", VA = "0xFA6D90")]
			get
			{
				return default(NotifyCollectionChangedAction);
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xFA6A20", Offset = "0xFA6A20", VA = "0xFA6A20")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		internal IList NewItems
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xFA6D98", Offset = "0xFA6D98", VA = "0xFA6D98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xFA6A50", Offset = "0xFA6A50", VA = "0xFA6A50")]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		internal int NewStartingIndex
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xFA6DA0", Offset = "0xFA6DA0", VA = "0xFA6DA0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xFA6BB4", Offset = "0xFA6BB4", VA = "0xFA6BB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		internal IList OldItems
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xFA6DA8", Offset = "0xFA6DA8", VA = "0xFA6DA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xFA6B7C", Offset = "0xFA6B7C", VA = "0xFA6B7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		internal int OldStartingIndex
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0xFA6DB0", Offset = "0xFA6DB0", VA = "0xFA6DB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xFA6D40", Offset = "0xFA6D40", VA = "0xFA6D40")]
			set
			{
			}
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xFA6A00", Offset = "0xFA6A00", VA = "0xFA6A00")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xFA6A28", Offset = "0xFA6A28", VA = "0xFA6A28")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xFA6A58", Offset = "0xFA6A58", VA = "0xFA6A58")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xFA6B4C", Offset = "0xFA6B4C", VA = "0xFA6B4C")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xFA6B84", Offset = "0xFA6B84", VA = "0xFA6B84")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xFA6BBC", Offset = "0xFA6BBC", VA = "0xFA6BBC")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xFA6BD8", Offset = "0xFA6BD8", VA = "0xFA6BD8")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xFA6CD0", Offset = "0xFA6CD0", VA = "0xFA6CD0")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xFA6D08", Offset = "0xFA6D08", VA = "0xFA6D08")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xFA6D48", Offset = "0xFA6D48", VA = "0xFA6D48")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xFA6D6C", Offset = "0xFA6D6C", VA = "0xFA6D6C")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
		}
	}
}
