using System.Globalization;
using System.IO;
using System.Text;
using CS;
using UnityEditor;

// Verificacao da fatia 3: formula de dano e atributos com atores sinteticos.
public static class Slice3Check
{
	private class FakeActor : IActor
	{
		public CharStatus status = new CharStatus();
		public bool deathDoor;
		public XModuleActor.CharacterStatus OriginalStatus => new XModuleActor.CharacterStatus();
		public CharStatus Status => status;
		public bool IsDeathDoor() => deathDoor;
	}

	private static string F(float v) => v.ToString("0.####", CultureInfo.InvariantCulture);

	private static string Case(string name, int type, bool deathDoor, float victimDef, float pen, float damageRatio)
	{
		FakeActor attacker = new FakeActor();
		FakeActor victim = new FakeActor { deathDoor = deathDoor };
		CSSkillInfo skill = new CSSkillInfo();
		skill.DamageType = (SkillDamageTypes)type;
		skill.damageRatio = damageRatio;
		skill.nID = 777;
		attacker.status.PhysicalDamage.value = 1000f;
		attacker.status.MagicalDamage.value = 800f;
		skill.PhysicalDamage.ratio = 0.2f;
		skill.MagicalDamage.multiplier = 1.5f;
		attacker.status.PhysicalDamageAmp.value = 0.1f;
		attacker.status.MagicalDamageAmp.value = 0.25f;
		attacker.status.PhysicalPenetration.value = pen;
		attacker.status.MagicalPenetration.value = pen;
		attacker.status.AmplyDamageOnDeathsDoor.value = 0.4f;
		victim.status.PhysicalDefense.value = victimDef;
		victim.status.MagicalDefense.value = victimDef;
		victim.status.PhysicalDefense_Fix.value = 100f;
		victim.status.MagicalDefense_Fix.value = 50f;
		victim.status.AmplyDefenseOnDeathsDoor.value = 0.5f;
		XCalculator.SkillParam param = new XCalculator.SkillParam();
		param.attacker = attacker;
		param.victim = victim;
		param.skillInfo = skill;
		int damage = XCalculator.CalcSkillDamage(param, 1f, out float pure);
		return $"{name}={damage}/{F(pure)}";
	}

	[MenuItem("Arena Masters/Verificar fatia 3 (combate)")]
	public static void Run()
	{
		CSLog.Init(new CSLogger());
		StringBuilder sb = new StringBuilder();
		sb.Append(Case("phys", 1, false, 0.3f, 0.1f, 1.5f)).Append('|');
		sb.Append(Case("mag_death", 2, true, 0.3f, 0.1f, 1.5f)).Append('|');
		sb.Append(Case("pen_over", 1, false, 0.05f, 0.1f, 1.5f)).Append('|');
		sb.Append(Case("invalid", 3, false, 0.3f, 0.1f, 1.5f)).Append('|');
		sb.Append(Case("zero_ratio", 1, false, 0.3f, 0.1f, 0f)).AppendLine();

		CharStatusAttr a = new CharStatusAttr { value = 10f, ratio = 0.5f, multiplier = 2f };
		CharStatusAttr b = new CharStatusAttr { value = 4f, ratio = 0.1f, multiplier = 1.5f };
		a.Merge(b, 2f);
		XGameConst.AIRBORNE_SPEED = 10f;
		XGameConst.KNOCKBACK_SPEED = 20f;
		sb.AppendLine($"merge={F(a.value)},{F(a.ratio)},{F(a.multiplier)},{F(a.Calc())}"
			+ $"|motion={F(XCalculator.CalcMotionControlTime(3f, 0.25f))},{F(XCalculator.CalcMotionControlTime(500f, 0f))}"
			+ $"|airborne={F(XCalculator.CalcMotionControlAirborneTime(5f, 4f))}|knockback={F(XCalculator.CalcMotionControlKnockbackTime(40f, 1f))}"
			+ $"|pool={ObjectRepository<CharStatus>.Count() > 0}");
		File.WriteAllText("C:/Users/felip/arena-masters-re/decomp/slice3_result.txt", sb.ToString());
		UnityEngine.Debug.Log("Fatia 3:\n" + sb);
	}
}
