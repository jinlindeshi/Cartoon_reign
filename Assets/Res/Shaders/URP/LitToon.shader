/// <summary>
/// <para>Author: zhengnan </para>
/// <para>Create: 2021年10月25日 15:29 </para>
/// </summary>
Shader "ReignURP/LitToon/LitToon"
{
    Properties
    {
        [Toggle(Receive Shadow)]_ENABLE_RECEIVE_SHADOW("Receive Shadow", Float) = 0
        [MainColor]_BaseColor ("Color", Color) = (1,1,1,1)
        [MainTexture]_BaseMap ("Albedo", 2D) = "white" {}
        _BumpMap ("BumpMap", 2D) = "bump" {}
        
        _Smoothness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.5
        _Occlusion("Occlusion", Range(0,1)) = 0.5
        
        [Toggle(Enable Advanced)]_ENABLE_ADVANCED("Use Advanced", Float) = 0
        _Diffuse ("Diffuse",            Range(0,4)) = 1
        _Specular ("Specular",          Range(0,4)) = 1
        _Sheen ("Sheen",                Range(0,4)) = 1
        _SSAO ("SSAO",                  Range(0,1)) = 1
        _ShadowAttenuation ("Shadow Attenuation",                Range(0,1)) = 1
        
        _SnowColor ("Snow Color", Color) = (1,1,1,1)
		_SnowThreshold ("Snow Threshold", Range(0, 1)) = 1
    }
    SubShader
    {
        Tags {"Queue" = "Geometry" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        //Tags {"Queue" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent"}
        //Tags {"Queue" = "AlphaTest" "RenderPipeline" = "UniversalPipeline" "RenderType" = "TransparentCutout"}
        
        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Packing.hlsl"
        ENDHLSL  
            
        Pass 
        {
            Name "Base"
            Tags { "LightMode" = "UniversalForward" }
            //Blend One Zero
            //Blend SrcAlpha OneMinusSrcAlpha
            Cull Back
            
            HLSLPROGRAM
	        #pragma target 3.0
           
            // -------------------------------------
            // Universal Pipeline keywords
            #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile _ LIGHTMAP_SHADOW_MIXING
            #pragma multi_compile _ SHADOWS_SHADOWMASK
            #pragma multi_compile _ LIGHTMAP_ON
            #pragma multi_compile _ DIRLIGHTMAP_COMBINED
            
            #pragma shader_feature _AdditionalLights
            // -------------------------------------
            
            // -------------------------------------
            // Custom keywords
            #pragma shader_feature_local_fragment _ENABLE_RECEIVE_SHADOW
            #pragma shader_feature_local_fragment _ENABLE_ADVANCED
            #pragma shader_feature_local_fragment _ENABLE_CARTOON
            // -------------------------------------
            
            #pragma multi_compile_instancing
            #pragma multi_compile_fog
            
            #pragma vertex ToonLitPassVertex
            #pragma fragment ToonLitPassFragment
            
            #include "ToonLitForwardPass.hlsl"
            
            ENDHLSL
        }
        UsePass "Universal Render Pipeline/Lit/ShadowCaster" 
        //UsePass "Universal Render Pipeline/Lit/DepthOnly" 
        //UsePass "Universal Render Pipeline/Lit/DepthNormals"
    }
    Fallback "Universal Render Pipeline/Lit"
    //CustomEditor "URPToon.LitToonShaderGUI"
}