using UnityEngine;
using UnityEngine.UI;

// Vitrine de modelo 3D para telas de menu (reutilizavel): camera e luz proprias numa camada so dela (30), longe da arena,
// desenhando numa RenderTexture mostrada num RawImage. O modelo gira devagar; Trocar() poe outro modelo.
public class Vitrine : MonoBehaviour
{
	public const int Camada = 30;
	public float giroPorSegundo = 35f;

	private static int s_contador;
	private Vector3 m_palco;
	private GameObject m_modelo;
	private Camera m_cam;
	private Light m_luz;
	private RenderTexture m_rt;

	public static Vitrine Criar(RawImage alvo, float distancia = 7.6f, int resolucao = 768)
	{
		Vitrine v = alvo.gameObject.AddComponent<Vitrine>();
		v.m_palco = new Vector3(400f * ++s_contador, -400f, 0f);   // cada vitrine num palco proprio
		v.m_rt = new RenderTexture(resolucao, resolucao, 24, RenderTextureFormat.ARGB32) { name = "Vitrine" };
		alvo.texture = v.m_rt;
		alvo.raycastTarget = false;
		v.m_cam = new GameObject("CameraVitrine").AddComponent<Camera>();
		v.m_cam.cullingMask = 1 << Camada;
		v.m_cam.clearFlags = CameraClearFlags.SolidColor;
		v.m_cam.backgroundColor = new Color(0f, 0f, 0f, 0f);
		v.m_cam.fieldOfView = 28f;
		v.m_cam.targetTexture = v.m_rt;
		v.m_cam.transform.position = v.m_palco + new Vector3(0f, 1.7f, distancia);
		v.m_cam.transform.LookAt(v.m_palco + Vector3.up * 1.05f);
		v.m_luz = new GameObject("LuzVitrine").AddComponent<Light>();
		v.m_luz.type = LightType.Directional;
		v.m_luz.cullingMask = 1 << Camada;
		v.m_luz.intensity = 1.25f;
		v.m_luz.color = new Color(1f, 0.92f, 0.82f);
		v.m_luz.transform.rotation = Quaternion.Euler(35f, 200f, 0f);
		return v;
	}

	public void Trocar(GameObject modelo)
	{
		if (m_modelo != null)
		{
			Destroy(m_modelo);
		}
		m_modelo = modelo;
		if (m_modelo == null)
		{
			return;
		}
		m_modelo.transform.SetPositionAndRotation(m_palco, Quaternion.Euler(0f, 180f, 0f));
		foreach (Transform t in m_modelo.GetComponentsInChildren<Transform>(true))
		{
			t.gameObject.layer = Camada;
		}
	}

	private void Update()
	{
		if (m_modelo != null)
		{
			m_modelo.transform.Rotate(0f, giroPorSegundo * Time.unscaledDeltaTime, 0f);
		}
	}

	private void OnDestroy()
	{
		if (m_modelo != null)
		{
			Destroy(m_modelo);
		}
		if (m_cam != null)
		{
			Destroy(m_cam.gameObject);
		}
		if (m_luz != null)
		{
			Destroy(m_luz.gameObject);
		}
		if (m_rt != null)
		{
			m_rt.Release();
		}
	}
}
