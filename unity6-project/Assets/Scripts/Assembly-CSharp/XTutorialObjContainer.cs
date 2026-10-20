using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C15")]
public class XTutorialObjContainer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000C16")]
	public class TutorialEntity
	{
		[Token(Token = "0x4003D2A")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4003D2B")]
		[FieldOffset(Offset = "0xC")]
		public GameObject target;

		[Token(Token = "0x4003D2C")]
		[FieldOffset(Offset = "0x10")]
		public bool Cloneable;

		[Token(Token = "0x4003D2D")]
		[FieldOffset(Offset = "0x11")]
		public bool IsCloneEntity;

		[Token(Token = "0x4003D2E")]
		[FieldOffset(Offset = "0x14")]
		private int OriginSiblingIdx__BackingField;

		[Token(Token = "0x4003D2F")]
		[FieldOffset(Offset = "0x18")]
		private Transform OriginParent__BackingField;

		[Token(Token = "0x17000CA4")]
		public int OriginSiblingIdx
		{
			[Token(Token = "0x60057A0")]
			[Address(RVA = "0x185858C", Offset = "0x185858C", VA = "0x185858C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60057A1")]
			[Address(RVA = "0x1859034", Offset = "0x1859034", VA = "0x1859034")]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA5")]
		public Transform OriginParent
		{
			[Token(Token = "0x60057A2")]
			[Address(RVA = "0x1858430", Offset = "0x1858430", VA = "0x1858430")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A3")]
			[Address(RVA = "0x185902C", Offset = "0x185902C", VA = "0x185902C")]
			private set
			{
			}
		}

		[Token(Token = "0x600579E")]
		[Address(RVA = "0x1858F50", Offset = "0x1858F50", VA = "0x1858F50")]
		public TutorialEntity()
		{
		}

		[Token(Token = "0x600579F")]
		[Address(RVA = "0x1857D6C", Offset = "0x1857D6C", VA = "0x1857D6C")]
		public TutorialEntity(string name, GameObject target, bool cloneable, bool IsCloneEntity = false)
		{
		}

		[Token(Token = "0x60057A4")]
		[Address(RVA = "0x1857C84", Offset = "0x1857C84", VA = "0x1857C84")]
		public void SetTarget(GameObject target, bool cloneable)
		{
		}

		[Token(Token = "0x60057A5")]
		[Address(RVA = "0x1858720", Offset = "0x1858720", VA = "0x1858720")]
		public void ResetTargetOriginParent()
		{
		}
	}

	[Token(Token = "0x2000C17")]
	private sealed class _003CAdd_003Ec__AnonStorey171
	{
		[Token(Token = "0x4003D30")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057A6")]
		[Address(RVA = "0x1857C7C", Offset = "0x1857C7C", VA = "0x1857C7C")]
		public _003CAdd_003Ec__AnonStorey171()
		{
		}

		[Token(Token = "0x60057A7")]
		[Address(RVA = "0x18589BC", Offset = "0x18589BC", VA = "0x18589BC")]
		internal bool _003C_003Em__241(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C18")]
	private sealed class _003CClear_003Ec__AnonStorey172
	{
		[Token(Token = "0x4003D31")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057A8")]
		[Address(RVA = "0x1857F2C", Offset = "0x1857F2C", VA = "0x1857F2C")]
		public _003CClear_003Ec__AnonStorey172()
		{
		}

		[Token(Token = "0x60057A9")]
		[Address(RVA = "0x1858B54", Offset = "0x1858B54", VA = "0x1858B54")]
		internal bool _003C_003Em__242(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C19")]
	private sealed class _003CAddClone_003Ec__AnonStorey173
	{
		[Token(Token = "0x4003D32")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057AA")]
		[Address(RVA = "0x185816C", Offset = "0x185816C", VA = "0x185816C")]
		public _003CAddClone_003Ec__AnonStorey173()
		{
		}

		[Token(Token = "0x60057AB")]
		[Address(RVA = "0x1858A88", Offset = "0x1858A88", VA = "0x1858A88")]
		internal bool _003C_003Em__243(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C1A")]
	private sealed class _003CGetOriginParent_003Ec__AnonStorey174
	{
		[Token(Token = "0x4003D33")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x1858428", Offset = "0x1858428", VA = "0x1858428")]
		public _003CGetOriginParent_003Ec__AnonStorey174()
		{
		}

		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x1858C20", Offset = "0x1858C20", VA = "0x1858C20")]
		internal bool _003C_003Em__244(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C1B")]
	private sealed class _003CGetSibilingIdx_003Ec__AnonStorey175
	{
		[Token(Token = "0x4003D34")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x1858584", Offset = "0x1858584", VA = "0x1858584")]
		public _003CGetSibilingIdx_003Ec__AnonStorey175()
		{
		}

		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x1858CEC", Offset = "0x1858CEC", VA = "0x1858CEC")]
		internal bool _003C_003Em__245(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C1C")]
	private sealed class _003CGetTutorialTargetObject_003Ec__AnonStorey176
	{
		[Token(Token = "0x4003D35")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057B0")]
		[Address(RVA = "0x1858594", Offset = "0x1858594", VA = "0x1858594")]
		public _003CGetTutorialTargetObject_003Ec__AnonStorey176()
		{
		}

		[Token(Token = "0x60057B1")]
		[Address(RVA = "0x1858DB8", Offset = "0x1858DB8", VA = "0x1858DB8")]
		internal bool _003C_003Em__246(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C1D")]
	private sealed class _003CGetTutorialTargetTransform_003Ec__AnonStorey177
	{
		[Token(Token = "0x4003D36")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x60057B2")]
		[Address(RVA = "0x18589B4", Offset = "0x18589B4", VA = "0x18589B4")]
		public _003CGetTutorialTargetTransform_003Ec__AnonStorey177()
		{
		}

		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x1858E84", Offset = "0x1858E84", VA = "0x1858E84")]
		internal bool _003C_003Em__247(TutorialEntity x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003D28")]
	[FieldOffset(Offset = "0xC")]
	public List<TutorialEntity> objects;

	[Token(Token = "0x4003D29")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, Action> delayRegisterDic;

	[Token(Token = "0x6005792")]
	[Address(RVA = "0x1857830", Offset = "0x1857830", VA = "0x1857830")]
	public XTutorialObjContainer()
	{
	}

	[Token(Token = "0x6005793")]
	[Address(RVA = "0x1857910", Offset = "0x1857910", VA = "0x1857910")]
	public void DelayRegisterObject(string name, Action action)
	{
	}

	[Token(Token = "0x6005794")]
	[Address(RVA = "0x18579B8", Offset = "0x18579B8", VA = "0x18579B8")]
	public void Add(string name, GameObject target, bool cloneable = false)
	{
	}

	[Token(Token = "0x6005795")]
	[Address(RVA = "0x1857DE4", Offset = "0x1857DE4", VA = "0x1857DE4")]
	public void Clear(string name)
	{
	}

	[Token(Token = "0x6005796")]
	[Address(RVA = "0x1857F34", Offset = "0x1857F34", VA = "0x1857F34")]
	public void AddClone(string name, GameObject target, bool cloneable = false)
	{
	}

	[Token(Token = "0x6005797")]
	[Address(RVA = "0x1858174", Offset = "0x1858174", VA = "0x1858174")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005798")]
	[Address(RVA = "0x185829C", Offset = "0x185829C", VA = "0x185829C")]
	public Transform GetOriginParent(string name)
	{
		return null;
	}

	[Token(Token = "0x6005799")]
	[Address(RVA = "0x1858438", Offset = "0x1858438", VA = "0x1858438")]
	public int GetSibilingIdx(string name)
	{
		return default(int);
	}

	[Token(Token = "0x600579A")]
	[Address(RVA = "0x184CDA4", Offset = "0x184CDA4", VA = "0x184CDA4")]
	public GameObject GetTutorialTargetObject(string name, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600579B")]
	[Address(RVA = "0x1858834", Offset = "0x1858834", VA = "0x1858834")]
	private Vector3 GetGlobalPosition(Transform trans)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600579C")]
	[Address(RVA = "0x184C4CC", Offset = "0x184C4CC", VA = "0x184C4CC")]
	public Transform GetTutorialTargetTransform(string name)
	{
		return null;
	}

	[Token(Token = "0x600579D")]
	[Address(RVA = "0x185859C", Offset = "0x185859C", VA = "0x185859C")]
	private void CallDelayRegistObject(string name)
	{
	}
}
