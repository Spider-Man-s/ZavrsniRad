﻿Shader "Unlit/Heatmap2D"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Transparency ("Transparency", Float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" }

        Blend SrcAlpha OneMinusSrcAlpha 
        
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
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
            
            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _Transparency;
            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv) * _Transparency;
                return col;
            }
            ENDCG
        }
    }
}