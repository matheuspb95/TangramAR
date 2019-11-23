Shader "Custom/BlurShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
        _Size ("Size", Range(0, 20)) = 2
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
            float _Size;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
                float depth= _Size*0.001;
                half4 sum = half4(0,0,0,0);
                #define GRABPIXEL(weight,kernelx) tex2D( _MainTex, float2(i.uv.x + kernelx*depth*2, i.uv.y+ kernelx*depth*2)) * weight

                sum += GRABPIXEL(0.025, -5.0);
                sum += GRABPIXEL(0.05, -4.0);
                sum += GRABPIXEL(0.09, -3.0);
                sum += GRABPIXEL(0.12, -2.0);
                sum += GRABPIXEL(0.15, -1.0);
                sum += GRABPIXEL(0.16,  0.0);
                sum += GRABPIXEL(0.15, +1.0);
                sum += GRABPIXEL(0.12, +2.0);
                sum += GRABPIXEL(0.09, +3.0);
                sum += GRABPIXEL(0.05, +4.0);
                sum += GRABPIXEL(0.025, +5.0);

                return sum;
			}
			ENDCG
		}
	}
}
