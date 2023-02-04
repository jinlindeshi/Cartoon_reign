/// <summary>
/// <para>Author: zhengnan </para>
/// <para>Create: 2021年10月25日 15:29 </para>
/// </summary>
#ifndef TOON_LIT_FORWARD_PASS_INCLUDED
#define TOON_LIT_FORWARD_PASS_INCLUDED
 
#include "ToonLitInputs.hlsl"
#include "ToonLitLighting.hlsl"
//#include "DitherDistance.hlsl"

Varyings ToonLitPassVertex(Attributes input)
{
    Varyings output = (Varyings) 0;
    
    UNITY_SETUP_INSTANCE_ID(input);
    UNITY_TRANSFER_INSTANCE_ID(input, output);
    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(output);
    
    VertexPositionInputs vertexInput = GetVertexPositionInputs(input.positionOS.xyz);
    VertexNormalInputs normalInput = GetVertexNormalInputs(input.normalOS, input.tangentOS);
    output.positionCS = vertexInput.positionCS;
    output.positionWS = vertexInput.positionWS;
    output.positionSS = ComputeScreenPos(output.positionCS);
    output.positionVS = vertexInput.positionVS;
    
    half3 viewDirWS = GetCameraPositionWS() - vertexInput.positionWS;
    //half3 viewDirWS = GetWorldSpaceViewDir(vertexInput.positionWS);
    half3 vertexLight = VertexLighting(vertexInput.positionWS, normalInput.normalWS);
    half fogFactor = ComputeFogFactor(vertexInput.positionCS.z);
    
    output.normalWS = float4(normalInput.normalWS, viewDirWS.x);
    output.tangentWS = float4(normalInput.tangentWS, viewDirWS.y);
    //real sign = input.tangentOS.w * GetOddNegativeScale();
    //float3 bitangent = sign * cross(normalInput.normalWS.xyz, normalInput.tangentWS.xyz); // should be either +1 or -1
    //output.bitangentWS = float4(bitangent, viewDirWS.z);
    output.bitangentWS = float4(normalInput.bitangentWS, viewDirWS.z);
    
    OUTPUT_LIGHTMAP_UV(input.lightmapUV, unity_LightmapST, output.lightmapUV);
    OUTPUT_SH(output.normalWS.xyz, output.vertexSH);
    
    output.uv = TRANSFORM_TEX(input.texcoord, _BaseMap);
    
    output.fogFactorAndVertexLight = float4(fogFactor, vertexLight);
    
    output.shadowCoord = GetShadowCoord(vertexInput);

    output.color = input.color;
    return output;
}

half4 ToonLitPassFragment(Varyings input) : SV_Target
{
    UNITY_SETUP_INSTANCE_ID(input);
    UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(input);
    
    ToonLitSurfaceData surfaceData;
    InitializeToonLitSurfaceData(input.uv.xy, surfaceData);
    
#ifdef _UseFade
    PerformDither(input, surfaceData.fade);
#endif

#ifdef _ALPHATEST_ON
    clip(surfaceData.emission - _Cutout);
#endif
    ToonLitInputData inputData;
    InitializeToonLitInputData(input, surfaceData.normalTS, inputData);

    float4 color = ToonLitFragment(inputData, surfaceData, input.uv.xy);
    
    float3 up = float3(0,1,0);
    float snowField = dot(inputData.normalWS, up);
    snowField = smoothstep(_SnowThreshold, 1, snowField);
    color.rgb = lerp(color.rgb, _SnowColor, snowField);

    color.rgb = MixFog(color.rgb,  inputData.fogCoord);
    //color.rgb = ACESFilm(color.rgb);
    //color = LinearToSRGB(color);
    return color;
}

#endif
