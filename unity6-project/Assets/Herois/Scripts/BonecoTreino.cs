using UnityEngine;

// Boneco de treino da cena VFX_Test: recebe o acerto, pisca branco (HitFlash), balanca e mostra o numero de dano.
public class BonecoTreino : MonoBehaviour
{
	public float altura = 1.6f;

	private HitFlash m_flash;
	private float m_tranco;
	private Vector3 m_tranDir;
	private Transform m_visual;

	private void Awake()
	{
		m_flash = gameObject.GetComponent<HitFlash>() ?? gameObject.AddComponent<HitFlash>();
		m_visual = transform.childCount > 0 ? transform.GetChild(0) : transform;
	}

	public void Acertar(int dano, bool critico, Vector3 deOnde)
	{
		m_flash.Play();
		m_tranco = 1f;
		m_tranDir = transform.position - deOnde;
		m_tranDir.y = 0f;
		m_tranDir = m_tranDir.sqrMagnitude > 0f ? m_tranDir.normalized : Vector3.forward;
		Vector3 pos = transform.position + Vector3.up * altura;   // o DamageNumber empilha quando sai mais de um
		DamageNumber.Show(pos, dano.ToString(), new Color(1f, 0.85f, 0.15f), critico ? DamageNumber.Estilo.Critico : DamageNumber.Estilo.Golpe);
	}

	private void Update()
	{
		// tranco: inclina para tras e volta (tempo real: aparece durante o hit stop)
		m_tranco = Mathf.Max(0f, m_tranco - Time.unscaledDeltaTime * 4f);
		float a = Mathf.Sin(m_tranco * Mathf.PI) * 14f * m_tranco;
		m_visual.localRotation = Quaternion.AngleAxis(a, Vector3.Cross(Vector3.up, transform.InverseTransformDirection(m_tranDir)));
	}
}
