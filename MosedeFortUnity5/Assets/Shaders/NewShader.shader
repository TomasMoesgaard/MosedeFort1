Shader "Custom/NewShader" {
	Properties {
	    _Color ("Main Color", Color) = (1,0.5,0.5,1)
        _Tint ("Tint Color", Color) = (0,0,0,0)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_TintAmount ("Tint Amount", float) = 0.0f
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;
		float4 _Color;
		float4 _Tint;
		float _TintAmount;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = _Color + (_Tint * _TintAmount);
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
