using UnityEngine;

// Cena VFX_Test: camera da luta (55 graus, FOV 33) seguindo o heroi, pos-processamento da arena e o "relogio" do game feel
// (hit stop, tremida, numeros de dano), como o BattleManager faz na luta.
public class CenaTesteVfx : MonoBehaviour
{
	public Transform alvo;
	public float distancia = 11f;

	private const float Pitch = 55f;
	private Camera m_cam;

	private void Start()
	{
		m_cam = GetComponent<Camera>();
		m_cam.fieldOfView = 33f;
		PosProcessamentoArena.Aplicar(m_cam);
		HitStop.Clear();
		CameraShake.Clear();
		DamageNumber.Clear();
	}

	private void LateUpdate()
	{
		float realDt = Time.unscaledDeltaTime;
		HitStop.Tick(realDt);
		if (!HitStop.Active && Time.timeScale != 1f)
		{
			Time.timeScale = 1f;
		}
		Vector3 focus = alvo != null ? alvo.position + Vector3.up * 0.8f : Vector3.zero;
		float a = Pitch * Mathf.Deg2Rad;
		transform.position = focus + new Vector3(0f, Mathf.Sin(a), -Mathf.Cos(a)) * distancia + CameraShake.Offset(realDt);
		transform.rotation = Quaternion.Euler(Pitch, 0f, 0f);
		DamageNumber.Tick(m_cam);
	}
}
