Shader "Tutorial/Basic" {
    Properties {
        _Color ("Main Color", Color) = (1,0.5,0.5,1)
        _Emission ("Emmisive Color", Color) = (0,0,0,0)
        _MainTex ("Base (RGB)", 2D) = "white" { }
    }
    SubShader {
    	Tags {"Queue" = "Transparent" }
        Pass {
            Material {
                Diffuse [_Color]
                Diffuse [_Emission]
            }
              Lighting On
            SeparateSpecular On
            SetTexture [_MainTex] {
                constantColor [_Color]
                Combine texture * primary DOUBLE, texture * constant
    		}
		}
	}
} 