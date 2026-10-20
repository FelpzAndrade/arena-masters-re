using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000B9B")]
	public class ObjectDiffPatch
	{
		[Token(Token = "0x4003B2B")]
		private const string PREFIX_ARRAY_SIZE = "@@ Count";

		[Token(Token = "0x4003B2C")]
		private const string PREFIX_REMOVED_FIELDS = "@@ Removed";

		[Token(Token = "0x4003B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JsonSerializerSettings defaultSerializerSettings;

		[Token(Token = "0x4003B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Func<JsonSerializer> defaultSerializer;

		[Token(Token = "0x17000C68")]
		public static Func<JsonSerializer> DefaultSerializer
		{
			[Token(Token = "0x6005401")]
			[Address(RVA = "0x234056C", Offset = "0x234056C", VA = "0x234056C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005402")]
			[Address(RVA = "0x234064C", Offset = "0x234064C", VA = "0x234064C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C69")]
		public static JsonSerializerSettings DefaultSerializerSettings
		{
			[Token(Token = "0x6005403")]
			[Address(RVA = "0x23406D0", Offset = "0x23406D0", VA = "0x23406D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005404")]
			[Address(RVA = "0x2340864", Offset = "0x2340864", VA = "0x2340864")]
			set
			{
			}
		}

		[Token(Token = "0x6005400")]
		[Address(RVA = "0x2340564", Offset = "0x2340564", VA = "0x2340564")]
		public ObjectDiffPatch()
		{
		}

		[Token(Token = "0x6005405")]
		public static ObjectDiffPatchResult GenerateDiff<T1, T2>(T1 original, T2 updated) where T1 : class where T2 : class
		{
			return null;
		}

		[Token(Token = "0x6005406")]
		public static ObjectDiffPatchResult GenerateDiff<T>(T original, JObject updated) where T : class
		{
			return null;
		}

		[Token(Token = "0x6005407")]
		public static ObjectDiffPatchResult GenerateDiff<T>(JObject original, T updated) where T : class
		{
			return null;
		}

		[Token(Token = "0x6005408")]
		[Address(RVA = "0x23408E8", Offset = "0x23408E8", VA = "0x23408E8")]
		public static ObjectDiffPatchResult GenerateDiff(JObject original, JObject updated)
		{
			return null;
		}

		[Token(Token = "0x6005409")]
		[Address(RVA = "0x23409C4", Offset = "0x23409C4", VA = "0x23409C4")]
		public static ObjectDiffPatchResult GenerateDiff(JObject original, JObject updated, Type comparedType)
		{
			return null;
		}

		[Token(Token = "0x600540A")]
		public static T PatchObject<T>(T source, string diffJson) where T : class
		{
			return null;
		}

		[Token(Token = "0x600540B")]
		public static T PatchObject<T>(T source, JObject diffJson) where T : class
		{
			return null;
		}

		[Token(Token = "0x600540C")]
		public static JObject Snapshot<T>(T source) where T : class
		{
			return null;
		}

		[Token(Token = "0x600540D")]
		[Address(RVA = "0x2340AC0", Offset = "0x2340AC0", VA = "0x2340AC0")]
		private static ObjectDiffPatchResult Diff(JObject source, JObject target)
		{
			return null;
		}

		[Token(Token = "0x600540E")]
		[Address(RVA = "0x234146C", Offset = "0x234146C", VA = "0x234146C")]
		private static ObjectDiffPatchResult DiffField(string fieldName, JToken source, JToken target, [Optional] ObjectDiffPatchResult result)
		{
			return null;
		}

		[Token(Token = "0x600540F")]
		[Address(RVA = "0x2341C14", Offset = "0x2341C14", VA = "0x2341C14")]
		private static JsonSerializer InternalDefaultSerializer()
		{
			return null;
		}

		[Token(Token = "0x6005410")]
		[Address(RVA = "0x2340784", Offset = "0x2340784", VA = "0x2340784")]
		private static JsonSerializerSettings InternalDefaultSerializerSettings()
		{
			return null;
		}

		[Token(Token = "0x6005411")]
		[Address(RVA = "0x2341C34", Offset = "0x2341C34", VA = "0x2341C34")]
		public static JToken PatchUseJsonUtility(JToken sourceJson, JToken diffJson)
		{
			return null;
		}

		[Token(Token = "0x6005412")]
		[Address(RVA = "0x2341C38", Offset = "0x2341C38", VA = "0x2341C38")]
		private static JToken Patch(JToken sourceJson, JToken diffJson)
		{
			return null;
		}

		[Token(Token = "0x6005413")]
		[Address(RVA = "0x2341A8C", Offset = "0x2341A8C", VA = "0x2341A8C")]
		private static void AddNewValuesToken(ObjectDiffPatchResult item, JToken newToken, string fieldName)
		{
		}

		[Token(Token = "0x6005414")]
		[Address(RVA = "0x2341398", Offset = "0x2341398", VA = "0x2341398")]
		private static void AddOldValuesToken(ObjectDiffPatchResult item, JToken oldToken, string fieldName)
		{
		}

		[Token(Token = "0x6005415")]
		[Address(RVA = "0x2341B60", Offset = "0x2341B60", VA = "0x2341B60")]
		private static void AddToken(ObjectDiffPatchResult item, string fieldName, JToken oldToken, JToken newToken)
		{
		}

		[Token(Token = "0x6005416")]
		[Address(RVA = "0x2341BC0", Offset = "0x2341BC0", VA = "0x2341BC0")]
		private static void AddToken(ObjectDiffPatchResult item, string fieldName, ObjectDiffPatchResult diff)
		{
		}
	}
}
