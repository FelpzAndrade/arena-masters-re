// Shader de particula dos efeitos de skill (corte, faisca, onda). HLSL puro, sem luz, sem Shader Graph.
// Roda no pipeline padrao (Built-in, o que o projeto usa hoje) e tambem no URP, porque nao usa bibliotecas de pipeline.
//
// Custom Vertex Streams do Particle System (nesta ordem):
//   Position, Color, UV, Custom1.xy, StableRandom.x
//   -> TEXCOORD0.xy = UV, TEXCOORD0.z = dissolve (Custom1.x), TEXCOORD0.w = avanco do corte (Custom1.y)
//   -> TEXCOORD1.x  = sorteio fixo da particula (muda o desenho do ruido de uma particula pra outra)
// O Custom Data (modulo do Particle System) controla dissolve e avanco com curvas ao longo da vida da particula.
// Sem os streams os dois valem 0: a mascara aparece inteira e sem dissolve.
Shader "ArenaMasters/VFX/Particula Dissolve"
{
	Properties
	{
		[Header(Formato)]
		// mascara do formato: RGB = miolo quente (onde fica branco), A = recorte
		_MainTex ("Mascara (RGB miolo, A formato)", 2D) = "white" {}
		// rolagem constante da mascara, em UV por segundo (x, y)
		_MainScroll ("Rolagem da mascara (UV/s)", Vector) = (0, 0, 0, 0)

		[Header(Cor)]
		// cor principal; valores acima de 1 passam do limite do bloom e brilham
		[HDR] _Color ("Cor principal (HDR)", Color) = (2.5, 0.9, 0.25, 1)
		// cor do miolo quente (perto do fio do corte)
		[HDR] _CoreColor ("Cor do miolo (HDR)", Color) = (5, 4, 3, 1)
		// quanto maior, mais fino fica o miolo branco
		_CorePower ("Dureza do miolo", Range(0.5, 8)) = 2

		[Header(Ruido)]
		// ruido cinza que repete nas bordas (Wrap = Repeat)
		_NoiseTex ("Ruido", 2D) = "gray" {}
		// rolagem do ruido, em UV por segundo (x, y)
		_NoiseScroll ("Rolagem do ruido (UV/s)", Vector) = (-0.8, 0.15, 0, 0)
		// quanto o ruido entorta a mascara (deixa a borda viva)
		_Distortion ("Distorcao pelo ruido", Range(0, 0.3)) = 0.04

		[Header(Dissolve)]
		// dissolve fixo somado ao da particula (bom pra testar no material)
		_Dissolve ("Dissolve extra", Range(0, 1)) = 0
		// largura da borda queimando que aparece enquanto dissolve
		_EdgeWidth ("Largura da borda", Range(0, 0.3)) = 0.08
		// cor da borda queimando (HDR)
		[HDR] _EdgeColor ("Cor da borda (HDR)", Color) = (6, 1.8, 0.4, 1)
		// suavidade do recorte do dissolve (pequeno = recorte seco)
		_Softness ("Suavidade do recorte", Range(0.001, 0.5)) = 0.04

		[Header(Mistura)]
		// 1 = aditivo (soma luz), 0 = transparente comum; da pra misturar
		_Additive ("Aditivo", Range(0, 1)) = 1
		// multiplicador geral do brilho
		_Intensity ("Intensidade", Range(0, 10)) = 1
	}

	SubShader
	{
		Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "IgnoreProjector" = "True" "PreviewType" = "Plane" }
		// cor pre-multiplicada: com alfa de saida 0 vira aditivo, com alfa 1 vira transparente comum
		Blend One OneMinusSrcAlpha
		ZWrite Off
		Cull Off
		Lighting Off

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 3.0
			#include "HLSLSupport.cginc"
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _MainScroll;
			half4 _Color;
			half4 _CoreColor;
			half _CorePower;
			sampler2D _NoiseTex;
			float4 _NoiseTex_ST;
			float4 _NoiseScroll;
			half _Distortion;
			half _Dissolve;
			half _EdgeWidth;
			half4 _EdgeColor;
			half _Softness;
			half _Additive;
			half _Intensity;

			struct appdata
			{
				float4 vertex : POSITION;
				half4 color : COLOR;
				float4 uv : TEXCOORD0;   // xy = UV, z = dissolve, w = avanco do corte
				float4 uv1 : TEXCOORD1;  // x = sorteio fixo da particula
			};

			struct v2f
			{
				float4 pos : SV_POSITION;
				half4 color : COLOR;
				float4 uv : TEXCOORD0;     // xy = UV da mascara, zw = UV do ruido
				half2 life : TEXCOORD1;    // x = dissolve, y = avanco do corte
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.uv.xy = TRANSFORM_TEX(v.uv.xy, _MainTex) + _MainScroll.xy * _Time.y + float2(v.uv.w, 0);
				o.uv.zw = TRANSFORM_TEX(v.uv.xy, _NoiseTex) + _NoiseScroll.xy * _Time.y + v.uv1.x * 7.31;
				o.life = half2(v.uv.z, v.uv.w);
				return o;
			}

			half4 frag(v2f i) : SV_Target
			{
				half n = tex2D(_NoiseTex, i.uv.zw).r;
				half4 mask = tex2D(_MainTex, i.uv.xy + (n - 0.5h) * _Distortion);

				// dissolve: o limiar sobe de "abaixo de 0" (nada some) ate 1 (tudo some)
				half d = saturate(i.life.x + _Dissolve);
				half thr = lerp(-(_EdgeWidth + _Softness), 1.0h, d);
				half visible = smoothstep(thr, thr + _Softness, n);
				half edge = visible - smoothstep(thr + _EdgeWidth, thr + _EdgeWidth + _Softness, n);

				half core = pow(mask.r, _CorePower);
				half3 col = lerp(_Color.rgb, _CoreColor.rgb, core) * i.color.rgb + _EdgeColor.rgb * edge;
				half a = mask.a * visible * i.color.a;
				return half4(col * (a * _Intensity), a * (1.0h - _Additive));
			}
			ENDHLSL
		}
	}
}
