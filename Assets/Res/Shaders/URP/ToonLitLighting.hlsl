#ifndef TOON_LIT_LIGHTING_INCLUDED
#define TOON_LIT_LIGHTING_INCLUDED

//////////////////////////////
//		 Fast BRDF		//
//////////////////////////////

#include "GlobalFakeLight.hlsl"
#include "ToonLitInputs.hlsl"

float3 ToonLitBRDF(BRDFData brdfData, ToonLitSurfaceData surfaceData, ToonLitInputData inputData, Light light, float NdotL)
{    
    float3 L = light.direction;
    float3 N = inputData.normalWS;
    float3 V = inputData.viewDirectionWS;
    float3 Y = inputData.bitangentWS;
    float3 H = SafeNormalize(L + V);
    
    //float NdotL = saturate(dot(N, L));
    //float NdotV = saturate(dot(N, V));
    float NdotH = saturate(dot(N, H));
    float LdotH = saturate(dot(L, H));
    float VdotH = saturate(dot(V, H));
    //float TdotH = saturate(dot(X, H));
    //float BdotH = saturate(dot(Y, H));
    
    // Unity URP  https://community.arm.com/events/1155
    float d = NdotH * NdotH * brdfData.roughness2MinusOne + 1.00001f;
    half LoH2 = LdotH * LdotH;
    half SpecularResult = brdfData.roughness2 / ((d * d) * max(0.1h, LoH2) * brdfData.normalizationTerm);
    
#if defined (SHADER_API_MOBILE) || defined (SHADER_API_SWITCH)
    SpecularResult = SpecularResult - HALF_MIN;
    SpecularResult = clamp(SpecularResult, 0.0, 100.0); // Prevent FP16 overflow on mobiles
#endif
    return SpecularResult;
}

float3 ToonLitCaroonSpecular(BRDFData brdfData, ToonLitSurfaceData surfaceData, ToonLitInputData inputData, Light light, float NdotL)
{    
    float3 L = light.direction;
    float3 N = inputData.normalWS;
    float3 V = inputData.viewDirectionWS;
    float3 Y = inputData.bitangentWS;
    float3 H = SafeNormalize(L + V);
    
    //float NdotL = saturate(dot(N, L));
    //float NdotV = saturate(dot(N, V));
    float NdotH = saturate(dot(N, H));
    float LdotH = saturate(dot(L, H));
    float VdotH = saturate(dot(V, H));
    //float TdotH = saturate(dot(X, H));
    //float BdotH = saturate(dot(Y, H));
    
    half lambert = NdotL * 0.5 + 0.5;
    
    half w = fwidth(NdotH) * 2.0;
    half3 SpecularResult = light.color.rgb * surfaceData.specularColor * lerp(0, 1, smoothstep(-w, w, NdotH - surfaceData.specularScale));
    
    /*
    float d = NdotH * NdotH * brdfData.roughness2MinusOne + 1.00001f;
    half LoH2 = LdotH * LdotH;
    half specularTerm = brdfData.roughness2 / ((d * d) * max(0.1h, LoH2) * brdfData.normalizationTerm);
    float maxD = NdotH * NdotH * brdfData.roughness2MinusOne + 1.00001f;
    half maxSpecularTerm = brdfData.roughness2 / ((maxD * maxD) * brdfData.normalizationTerm);
    half SpecularResult = SmoothstepToon(specularTerm, maxSpecularTerm, maxSpecularTerm, step, feather);
    */
#if defined (SHADER_API_MOBILE) || defined (SHADER_API_SWITCH)
    SpecularResult = SpecularResult - HALF_MIN;
    SpecularResult = clamp(SpecularResult, 0.0, 100.0); // Prevent FP16 overflow on mobiles
#endif

    return SpecularResult;
}

float3 ToonLitCaroonDiffuse(BRDFData brdfData, ToonLitSurfaceData surfaceData, ToonLitInputData inputData, Light light, float NdotL)
{    
    float3 L = light.direction;
    float3 N = inputData.normalWS;
    float3 V = inputData.viewDirectionWS;
    float3 Y = inputData.bitangentWS;
    float3 H = SafeNormalize(L + V);
    
    //float NdotL = saturate(dot(N, L));
    //float NdotV = saturate(dot(N, V));
    float NdotH = saturate(dot(N, H));
    float LdotH = saturate(dot(L, H));
    float VdotH = saturate(dot(V, H));
    //float TdotH = saturate(dot(X, H));
    //float BdotH = saturate(dot(Y, H));
    
    
    half lambert = NdotL * 0.5 + 0.5;
    
    //浅的阴影
    half3 shallowShadowColor = surfaceData.albedo * _ShadowMultiColor.rgb;
    //深的阴影
    half3 darkShadowColor = surfaceData.albedo * _DarkShadowMultiColor.rgb;
    
    //平滑阴影边缘
    half rampSS = smoothstep(0, _ShadowSmooth, lambert - _ShadowArea);
    half rampDS = smoothstep(0, _DarkShadowSmooth, lambert - _DarkShadowArea);
    shallowShadowColor = lerp(shallowShadowColor, surfaceData.albedo, rampSS);
    darkShadowColor = lerp(darkShadowColor, shallowShadowColor, rampDS);
    half3 shadowColor = lerp(shallowShadowColor, darkShadowColor, 1 - NdotL);
    half3 DiffuseResult = lerp(surfaceData.albedo, shadowColor, surfaceData.cartoon);
    return DiffuseResult;
}

float3 ToonLitDirectLight(BRDFData brdfData, ToonLitSurfaceData surfaceData, ToonLitInputData inputData, Light light, float NdotL, float shadowAttenuation)
{
    half lambert = NdotL * 0.5 + 0.5;
#if _ENABLE_CARTOON
    float3 SpecularResult = ToonLitCaroonSpecular(brdfData, surfaceData, inputData, light, NdotL);
    float3 DiffuseResult = ToonLitCaroonDiffuse(brdfData, surfaceData, inputData, light, NdotL);
    float3 DirectLightResult = DiffuseResult * surfaceData.diffuse + surfaceData.specularColor * SpecularResult * surfaceData.specular;
#else
    float3 SpecularResult = ToonLitBRDF(brdfData, surfaceData, inputData, light, NdotL);
    float3 DiffuseResult = brdfData.diffuse;
    float3 DirectLightResult = DiffuseResult * surfaceData.diffuse + brdfData.specular * SpecularResult * surfaceData.specular;
#endif
    float lightAtten = 1;
#if _ENABLE_RECEIVE_SHADOW
    lightAtten = shadowAttenuation;
#endif
    DirectLightResult = DirectLightResult * light.color * lightAtten;
    return DirectLightResult;
}

float4 ToonLitFragment(ToonLitInputData inputData, ToonLitSurfaceData surfaceData, float2 uv)
{
    BRDFData brdfData;
    InitializeBRDFData(surfaceData.albedo, surfaceData.metallic, surfaceData.smoothness, brdfData);
    
    
#if defined(SHADOWS_SHADOWMASK) && defined(LIGHTMAP_ON)
    half4 shadowMask = inputData.shadowMask;
#elif !defined (LIGHTMAP_ON)
    half4 shadowMask = unity_ProbesOcclusion;
#else
    half4 shadowMask = half4(1, 1, 1, 1);
#endif
    Light mainLight = GetMainLight(inputData.shadowCoord, inputData.positionWS, shadowMask);
    
    #if defined(_SCREEN_SPACE_OCCLUSION)
        AmbientOcclusionFactor aoFactor = GetScreenSpaceAmbientOcclusion(inputData.normalizedScreenSpaceUV);
        mainLight.color *= lerp(1, aoFactor.directAmbientOcclusion, surfaceData.ssao);
        surfaceData.occlusion = lerp(surfaceData.occlusion, min(surfaceData.occlusion, aoFactor.indirectAmbientOcclusion), surfaceData.ssao);
        
        //return float4(aoFactor.directAmbientOcclusion.rrr, 1);
    #endif
    
    MixRealtimeAndBakedGI(mainLight, inputData.normalWS, inputData.bakedGI);

    float NdotL = saturate(dot(inputData.normalWS, mainLight.direction));
    float shadowAttenuation = mainLight.shadowAttenuation * mainLight.distanceAttenuation;
    shadowAttenuation = lerp(1, shadowAttenuation, surfaceData.shadowAttenuation);
    //return float4(inputData.normalWS, 1);
    //直接光照部分结果
    float3 DirectLightResult = ToonLitDirectLight(brdfData, surfaceData, inputData, mainLight, NdotL, shadowAttenuation);
    //return float4(DirectLightResult, 1);

    float3 color = DirectLightResult;
    float3 IndirectLightResult = GlobalIllumination(brdfData, inputData.bakedGI, surfaceData.occlusion, inputData.normalWS, inputData.viewDirectionWS);
    //return float4(IndirectLightResult,1);
    color += lerp(0, IndirectLightResult, surfaceData.sheen);
    
#ifdef _ADDITIONAL_LIGHTS
    int pixelLightCount = GetAdditionalLightsCount();
    for (int i = 0; i < pixelLightCount; ++i)
    {
        Light addlight = GetAdditionalLight(i, inputData.positionWS, shadowMask);
        float aNdotL = saturate(dot(inputData.normalWS, addlight.direction));
        float addlightAttenuation = addlight.shadowAttenuation * addlight.distanceAttenuation;
        #if defined(_SCREEN_SPACE_OCCLUSION)
            addlight.color *= aoFactor.directAmbientOcclusion;
        #endif
        color += ToonLitDirectLight(brdfData, surfaceData, inputData, addlight, aNdotL, addlightAttenuation);
    }
    //return float4(sssColor,1);
#endif

    color += globalFakePointLight(inputData.positionWS);

#ifdef _ADDITIONAL_LIGHTS_VERTEX
    color += inputData.vertexLighting * brdfData.diffuse;
#endif
    //color += surfaceData.emission * _EmissionColor;
    return float4(color,1);
}
#endif
