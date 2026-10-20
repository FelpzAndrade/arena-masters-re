// Shader da imagem fantasma (rastro da esquiva): copia da malha do boneco, sem luz, somando brilho.
// O contorno (borda vista de lado) brilha mais que o meio, entao a silhueta aparece sem esconder o que esta atras.
// HLSL puro (Built-in e URP), sem Shader Graph. A transparencia vem de _Alpha, mudada pelo jogo enquanto o fantasma some.
Shader "ArenaMasters/VFX/Fantasma"
{
	Properties
	{
		// cor do fantasma; acima de 1 passa do limite do bloom e brilha
		[HDR] _Color ("Cor (HDR)", Color) = (0.6, 1.2, 3, 1)
		// brilho do meio da silhueta (0 = so o contorno)
		_Base ("Brilho do meio", Range(0, 1)) = 0.15
		// quanto maior, mais fino fica o contorno brilhante
		_RimPower ("Dureza do contorno", Range(0.5, 8)) = 2.5
		// transparencia geral (1 = cheio, 0 = sumiu)
		_Alpha ("Transparencia", Range(0, 1)) = 1
	}

	SubShader
	{
		Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "IgnoreProjector" = "True" }
		Blend One One
		ZWrite Off
		Cull Back
		Lighting Off

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 3.0
			#include "HLSLSupport.cginc"
			#include "UnityCG.cginc"

			half4 _Color;
			half _Base;
			half _RimPower;
			half _Alpha;

			struct appdata
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL;
			};

			struct v2f
			{
				float4 pos : SV_POSITION;
				float3 normal : TEXCOORD0;
				float3 view : TEXCOORD1;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.normal = UnityObjectToWorldNormal(v.normal);
				o.view = WorldSpaceViewDir(v.vertex);
				return o;
			}

			half4 frag(v2f i) : SV_Target
			{
				half facing = saturate(dot(normalize(i.normal), normalize(i.view)));
				half rim = pow(1.0h - facing, _RimPower);
				return half4(_Color.rgb * (_Base + rim) * _Alpha, 0);
			}
			ENDHLSL
		}
	}
}
