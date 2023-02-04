/// <summary>
/// <para>Author: zhengnan </para>
/// <para>Create: 2021年09月07日 星期二 23:29 </para>
/// </summary>

/*
struct VertexPositionInputs
{
    float3 positionWS; // World space position
    float3 positionVS; // View space position
    float4 positionCS; // Homogeneous clip space position
    float4 positionNDC;// Homogeneous normalized device coordinates
};*/

#ifndef TOON_LIT_INPUTS_INCLUDED
#define TOON_LIT_INPUTS_INCLUDED

#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

//Textures
    TEXTURE2D(_BaseMap);    SAMPLER(sampler_BaseMap);
    TEXTURE2D(_BumpMap);    SAMPLER(sampler_BumpMap);
    TEXTURE2D(_MaskMap);    SAMPLER(sampler_MaskMap);
    
CBUFFER_START(UnityPerMaterial)
    //Base
    float4 _BaseMap_ST, _MaskMap_ST, _BumpMap_ST;
    float4 _BaseColor, _EmissionColor;
    
    float4 _SpecularColor;
    float _SpecularScale;
    float _Cartoon;
    float _ShadowArea;
    float _ShadowSmooth;
    float4 _ShadowMultiColor;
    float _DarkShadowArea;
    float _DarkShadowSmooth;
    float4 _DarkShadowMultiColor;
            
    float _Smoothness;
    float _Metallic;
    float _Occlusion;
    
    float _Cutout;
    float _Alpha;
    float _Fade;
    
    // Advanced
    float _Diffuse;
    float _Specular;
    float _Sheen;
    float _SSAO;
    float _ShadowAttenuation;
    
    float _OutlineWidth;
    float4 _OutlineColor;
    
    half4 _SnowColor;
    half  _SnowThreshold;

CBUFFER_END

struct Attributes
{
    float4 positionOS   : POSITION;
    float3 normalOS     : NORMAL;
    float3 color        : COLOR;
    float4 tangentOS    : TANGENT;
    float2 texcoord     : TEXCOORD0;
    float2 lightmapUV   : TEXCOORD1;
    float2 texcoord7    : TEXCOORD7;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS               : SV_POSITION;
    float3 color                    : COLOR;
    float4 normalWS                 : NORMAL;
    float2 uv                       : TEXCOORD0;
    DECLARE_LIGHTMAP_OR_SH(lightmapUV, vertexSH, 1);    // lightmapUV & vertexSH
    float3 positionWS               : TEXCOORD2;
    float4 tangentWS                : TEXCOORD3;    
    float4 bitangentWS              : TEXCOORD4;    
    float4 shadowCoord              : TEXCOORD5;
    float4 fogFactorAndVertexLight  : TEXCOORD6;
    float4 positionSS               : TEXCOORD7; // Screen Space Position
    float3 positionVS              : TEXCOORD8; // Screen Space Position
    
    UNITY_VERTEX_INPUT_INSTANCE_ID
    UNITY_VERTEX_OUTPUT_STEREO
};
 

struct ToonLitInputData
{
    float3 positionWS;
    float4 positionSS;
    float3 positionVS;
    float3 normalWS;
    float3 tangentWS;
    float3 bitangentWS;
    float3 binormalWS;
    float3 viewDirectionWS;
    float4 shadowCoord;
    float  fogCoord;
    float3 vertexLighting;
    float3 bakedGI;
    float2 normalizedScreenSpaceUV;
    float4 shadowMask;
};
   
struct ToonLitSurfaceData
{
    float3  albedo;
    float   alpha;
    float   fade;
    float   emission;
    float   cutout; 
    float   cartoon;
    float3  normalTS;
    float   specularScale;
    float3  specularColor;
    
    float   metallic;
    float   smoothness;
    float   occlusion;
 
    // _EnableAdvanced
    float   specular;
    float   diffuse;
    float   sheen;
    float   ssao;
    float   shadowAttenuation;
};

void InitializeToonLitSurfaceData(float2 uv, out ToonLitSurfaceData outSurfaceData)
{
    //float4 baseColorMap = SRGBToLinear(SAMPLE_TEXTURE2D(_BaseMap,sampler_BaseMap,uv));
    float4 baseColorMap = SAMPLE_TEXTURE2D(_BaseMap,sampler_BaseMap,uv);
    outSurfaceData.albedo = baseColorMap.rgb * _BaseColor.rgb;
    outSurfaceData.emission = baseColorMap.a;
    outSurfaceData.cutout = baseColorMap.a;
    outSurfaceData.alpha = _Alpha;
    outSurfaceData.fade = _Fade;
    
    outSurfaceData.normalTS = UnpackNormal(SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, uv));
    outSurfaceData.cartoon     = _Cartoon;   
    outSurfaceData.metallic     = _Metallic;   
    outSurfaceData.smoothness   = _Smoothness;
    outSurfaceData.occlusion    = _Occlusion;
    outSurfaceData.specularColor    = _SpecularColor.rgb;
    outSurfaceData.specularScale    = _SpecularScale;
    
#ifdef _ENABLE_ADVANCED    
    outSurfaceData.specular = _Specular;
    outSurfaceData.diffuse = _Diffuse;
    outSurfaceData.sheen = _Sheen;
    outSurfaceData.ssao = _SSAO;
    outSurfaceData.shadowAttenuation = _ShadowAttenuation;
#else
    outSurfaceData.specular = 1;
    outSurfaceData.diffuse = 1;
    outSurfaceData.sheen = 1;
    outSurfaceData.ssao = 0;
    outSurfaceData.shadowAttenuation = 1;
#endif
}

inline void InitializeToonLitInputData(Varyings input, float3 normalTS, out ToonLitInputData outInputData)
{
    outInputData = (ToonLitInputData)0;

    outInputData.positionWS = input.positionWS;
    outInputData.positionSS = input.positionSS;
    outInputData.positionVS = input.positionVS;
    
    outInputData.normalWS = TransformTangentToWorld(normalTS, float3x3(input.tangentWS.xyz, input.bitangentWS.xyz, input.normalWS.xyz));
    //outInputData.normalWS = input.normalWS.rgb;

    outInputData.tangentWS = input.tangentWS.xyz;
    outInputData.bitangentWS = input.bitangentWS.xyz;

    outInputData.normalWS = NormalizeNormalPerPixel(outInputData.normalWS);
    outInputData.binormalWS = cross(outInputData.normalWS,outInputData.tangentWS);
    outInputData.viewDirectionWS = float3(input.normalWS.w, input.tangentWS.w, input.bitangentWS.w);
    
    outInputData.shadowCoord = input.shadowCoord;

    outInputData.fogCoord = input.fogFactorAndVertexLight.x;
    outInputData.vertexLighting = input.fogFactorAndVertexLight.yzw;
    outInputData.bakedGI = SAMPLE_GI(input.lightmapUV, input.vertexSH, outInputData.normalWS);
    outInputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(input.positionCS);
    outInputData.shadowMask = SAMPLE_SHADOWMASK(input.lightmapUV);
}

inline void InitializeBRDFData(float3 albedo, float metallic, float smoothness, out BRDFData brdfData)
{
    brdfData = (BRDFData)0;
    
    float oneMinusReflectivity = OneMinusReflectivityMetallic(metallic);
    float reflectivity = 1.0 - oneMinusReflectivity;
    brdfData.diffuse             = albedo * oneMinusReflectivity;
    brdfData.specular            = lerp(kDieletricSpec.rgb, albedo, metallic);
    
    brdfData.grazingTerm         = saturate(smoothness + reflectivity);
    brdfData.perceptualRoughness = PerceptualSmoothnessToPerceptualRoughness(smoothness);
    brdfData.roughness           = PerceptualRoughnessToRoughness(brdfData.perceptualRoughness);
    brdfData.roughness2          = max(brdfData.roughness * brdfData.roughness, HALF_MIN);
    brdfData.normalizationTerm   = brdfData.roughness * 4.0h + 2.0h;
    brdfData.roughness2MinusOne  = brdfData.roughness2 - 1.0h;

}

#endif