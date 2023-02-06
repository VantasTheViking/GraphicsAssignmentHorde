Shader "Custom/DiffuseWrap"
{
    Properties{
            _MainTex("Texture", 2D) = "white" {}
    }
        SubShader{
        Tags { "Queue" = "Geometry" }
        CGPROGRAM
        #pragma surface surf WrapLambert

        half4 LightingWrapLambert(SurfaceOutput s, half3 lightDir, half atten) {
            half NdotL = dot(s.Normal, lightDir);
            
            half4 c;
            c.rgb = s.Albedo * _LightColor0.rgb * (NdotL * atten);
            c.a = s.Alpha;
            return c;
        }

        struct Input {
            float2 uv_MainTex;
        };

        sampler2D _MainTex;
            void surf(Input IN, inout SurfaceOutput o) {
            o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
        }
        ENDCG
    }
        Fallback "Diffuse"
}