Shader "Custom/CrossSection" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
		_section ("Section plane (x angle, y angle, z angle, w displacement)", vector) = (0,0,0,0.15)
		 _SectionColor ("Section Color", Color) = (0.55,0.0,0.0,0)
	}
	SubShader {
		Tags { "RenderType" = "Opaque" }
      Cull Off
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

	

		struct Input {
			float2 uv_MainTex;
			float3 worldPos;
			 float3 viewDir;
			 float3 worldNormal;
		};
		fixed4 _Color;
 		sampler2D _MainTex;
		half _Glossiness;
		half _Metallic;
		float4 _section;
		fixed4 _SectionColor;
		

		void surf (Input IN, inout SurfaceOutputStandard o) {
		
        float toClip = _section.x * 0.1 * IN.worldPos.x +
                       _section.y * 0.1 * IN.worldPos.y +
                       _section.z * 0.1 * IN.worldPos.z +
                       _section.w;
                       
        clip( toClip);
         
        float fd = dot( IN.viewDir, IN.worldNormal);
 
        if (fd.x > 0)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex)* _Color;
            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;
            return;
        }
       
        o.Emission = _SectionColor;
			
			
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
