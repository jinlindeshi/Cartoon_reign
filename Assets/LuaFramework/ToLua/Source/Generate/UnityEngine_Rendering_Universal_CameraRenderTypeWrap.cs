﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Rendering_Universal_CameraRenderTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.Rendering.Universal.CameraRenderType));
		L.RegVar("Base", get_Base, null);
		L.RegVar("Overlay", get_Overlay, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.Rendering.Universal.CameraRenderType>.Check = CheckType;
		StackTraits<UnityEngine.Rendering.Universal.CameraRenderType>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.Rendering.Universal.CameraRenderType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.Rendering.Universal.CameraRenderType), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Base(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Rendering.Universal.CameraRenderType.Base);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Overlay(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Rendering.Universal.CameraRenderType.Overlay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.Universal.CameraRenderType o = (UnityEngine.Rendering.Universal.CameraRenderType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

