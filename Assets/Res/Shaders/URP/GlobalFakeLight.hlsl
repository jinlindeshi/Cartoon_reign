//
// 全局虚拟灯光
// Author: zhengnan
// Date: 2018年10月17日
//
//#ifndef MAX_GLOBAL_FAKE_LIGHT_NUM

#ifndef GLOBAL_FAKE_LIGHT
#define GLOBAL_FAKE_LIGHT

#define ANGLE_2_RADIAN 3.1415926 / 180
#define MAX_GLOBAL_FAKE_LIGHT_NUM 32

// Direction
half4 globalFake_LightPosition[MAX_GLOBAL_FAKE_LIGHT_NUM];
half4 globalFake_LightDirection[MAX_GLOBAL_FAKE_LIGHT_NUM];
half globalFake_LightIntensity[MAX_GLOBAL_FAKE_LIGHT_NUM];
half globalFake_LightSpread[MAX_GLOBAL_FAKE_LIGHT_NUM];
half4 globalFake_LightColor[MAX_GLOBAL_FAKE_LIGHT_NUM];
// Point
half globalFake_PointLightRadius[MAX_GLOBAL_FAKE_LIGHT_NUM];//点光源半径
half globalFake_PointLightFactor[MAX_GLOBAL_FAKE_LIGHT_NUM];//点光源衰减系数1
// Proj
half globalFake_ProjLightAngle[MAX_GLOBAL_FAKE_LIGHT_NUM];//投射灯光源半径
half globalFake_ProjLightDistance[MAX_GLOBAL_FAKE_LIGHT_NUM];//投射灯光源距离
half globalFake_ProjLightFactor1[MAX_GLOBAL_FAKE_LIGHT_NUM];//投射灯光源衰减系数1
half globalFake_ProjLightFactor2[MAX_GLOBAL_FAKE_LIGHT_NUM];//点光源衰减系数2
half globalFake_ProjLightFactor3[MAX_GLOBAL_FAKE_LIGHT_NUM];//点光源衰减系数3
// Ambient
half globalFake_AmbientIntensity;
half4 globalFake_AmbientSkyColor;
half4 globalFake_AmbientEquatorColor;
half4 globalFake_AmbientGroundColor;

//获取关照
half3 globalFakeLight() 
{
	//half3 V = normalize(i.viewDir);
	half3 lightCol = 1;
	half3 L = 0;
	for (int i = 0; i < MAX_GLOBAL_FAKE_LIGHT_NUM; i++) 
	{
		if(globalFake_LightPosition[i].w == 0) // 方向光
		{
			lightCol *= globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb;
		}
	}
	return lightCol;
}

//获取半兰伯特关照系数
half3 globalFakeLightHalfLambert(half3 orgCol, half3 N) 
{
	half3 diffuse = 0;
	for (int i = 0; i < MAX_GLOBAL_FAKE_LIGHT_NUM; i++) 
	{
		if(globalFake_LightPosition[i].w == 0) // 方向光
		{
			if(globalFake_LightDirection[i].w > 0)
			{
				half3 lightDir = TransformWorldToObjectDir(globalFake_LightDirection[i].xyz);
				half diff = max(0, dot (N, normalize(-lightDir)));
				diffuse += i * globalFake_LightIntensity[i] * diff;
			}
		}
	}
	return diffuse;
}

//获取半兰伯特关照系数
half3 globalFakeLightHalfLambertWidthColor(half3 orgCol, half3 N) 
{
	half3 diffuse = 0;
	for (int i = 0; i < MAX_GLOBAL_FAKE_LIGHT_NUM; i++) 
	{
		if(globalFake_LightPosition[i].w == 0) // 方向光
		{
			if(globalFake_LightDirection[i].w > 0)
			{
				half3 lightDir = TransformWorldToObjectDir(globalFake_LightDirection[i].xyz);
				half diff = max(0, dot (N, normalize(-lightDir)));
				diffuse += orgCol * globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb * diff;
			}
		}
	}
	return diffuse;
}

// 获取高光
half3 globalFakeSpecular(half3 N,half3 V) 
{
	half3 final = 0;
	half3 L = 0;
	for (int i = 0; i < MAX_GLOBAL_FAKE_LIGHT_NUM; i++) 
	{
		if(globalFake_LightPosition[i].w == 0) // 方向光
		{
			if(globalFake_LightDirection[i].w > 0)
			{
				half3 lightDir = TransformWorldToObjectDir(globalFake_LightDirection[i].xyz);
				L = normalize(-lightDir);
				half3 halfView = V + L;
				half3 specular = pow(max(dot(N,halfView),0),globalFake_LightSpread[i]);
				final *= specular * globalFake_LightColor[i].rgb;
			}
		}
	}
	return final;
}
//计算点光源衰减系数
half globalFakePointLightAttenuation(half3 worldPos,int i) 
{
	half3 lightPos = globalFake_LightPosition[i].xyz;
	half a = globalFake_PointLightFactor[i];
	//lightPos = TransformWorldToObjec(lightPos);
	half radius = globalFake_PointLightRadius[i];//半径
	half distan = length(lightPos - worldPos);//距离
	half atten = 1 - step(0,distan - radius);
	// f(x) = ax^2 + bx + c
	atten = atten * (1 - pow(distan / radius, a));
	return atten;
}

//计算点光源
half3 globalFakePointLight(half3 worldPos) 
{
	//half3 V = normalize(i.viewDir);
	half3 final = 0;
	half3 L = 0;
	for (int i = 0; i < MAX_GLOBAL_FAKE_LIGHT_NUM; i++) 
	{
		if(globalFake_LightPosition[i].w == 1) // 点光源
		{
			if(globalFake_PointLightRadius[i] > 0)
			{
				half3 lightDir = TransformWorldToObjectDir(globalFake_LightPosition[i].xyz - worldPos);
				//L = normalize(-lightDir);
				//half diffuse = max(0, dot (N, normalize(lightDir)));
				//final *= globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb * (saturate(dot(N, L)));
				//final += globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb * globalFakePointLightAttenuation(worldPos,i) * diffuse;
				final += globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb * globalFakePointLightAttenuation(worldPos,i);
			}
		}
	}
	return final;
}

//计算投射灯光源衰减系数
half2 globalFakeProjLightAttenuation(half3 worldPos,half3 lightDir,half3 N,int i) 
{
	half3 lightWorldPos = globalFake_LightPosition[i].xyz;
	half3 lightPos = TransformWorldToObject(globalFake_LightPosition[i].xyz);
	half angle = globalFake_ProjLightAngle[i];
	half range = globalFake_ProjLightDistance[i];	//距离
	half radius = sin(angle * ANGLE_2_RADIAN) * range;
	half maxRange = (range + radius) / cos(angle * ANGLE_2_RADIAN);//最大受光距离
	half distan = length(lightWorldPos - worldPos);	//距离
	half3 centerPos = lightWorldPos + lightDir * range; //投射中心点
	
	half EdotC = max(0,cos(atan(angle * ANGLE_2_RADIAN))); // 锥形边到中心轴的投影
	half WdotL = max(0,dot(lightDir, normalize(lightWorldPos - worldPos)));// 物体点到光源向量和光照方向的投影
	half2 atten = 1;
	atten.x = (1 - step(0,EdotC - WdotL)) * step(0,dot(N,lightDir));
	
	half a = globalFake_ProjLightFactor1[i];
	//half b = globalFake_ProjLightFactor2[i];
	half c = globalFake_ProjLightFactor3[i];
	//maxRange = sin(max(0,dot(N,lightDir))) * distan;
	atten.y = max(0.00001,1 - pow(EdotC / WdotL, a));
	atten.y *= range / c;
	//if(distan > maxRange)
		//atten.y = 0;
	return atten;
}


//计算投射灯光源
half3 globalFakeProjLight(half3 worldPos,half3 worldNormal) 
{
	//half3 V = normalize(i.viewDir);
	half3 final = 0;
	half3 L = 0;
	for (int i = 0; i < MAX_GLOBAL_FAKE_LIGHT_NUM; i++) 
	{
		if(globalFake_LightPosition[i].w == 2) // 投射灯光源
		{
			if(globalFake_ProjLightDistance[i] > 0)
			{
				half3 lightDir = -globalFake_LightDirection[i].xyz;
				L = normalize(lightDir);
				half diffuse = saturate(dot(worldNormal, L));
				//final *= globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb * (saturate(dot(N, L)));
				half2 atten = globalFakeProjLightAttenuation(worldPos,-globalFake_LightDirection[i].xyz,worldNormal,i);
				if(atten.x > globalFake_ProjLightFactor2[i])
					final += globalFake_LightIntensity[i] * globalFake_LightColor[i].rgb * atten.y * diffuse;
                
			}
		}
	}
	return final;
}

half3 getFakeAmbient(half3 worldNormal) 
{
    half angle = dot(worldNormal, half3(0,1,0));
    half3 dstCol = lerp(globalFake_AmbientSkyColor.rgb, globalFake_AmbientGroundColor.rgb,  step(angle,0));
    return  (globalFake_AmbientIntensity * 0.1) * lerp(globalFake_AmbientEquatorColor.rgb, dstCol, abs(angle));
}

#endif 