﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_LuaHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("LuaHelper");
		L.RegFunction("GetType", GetType);
		L.RegFunction("GetResManager", GetResManager);
		L.RegFunction("GetNetManager", GetNetManager);
		L.RegFunction("GetSceneManager", GetSceneManager);
		L.RegFunction("OnCallLuaFunc", OnCallLuaFunc);
		L.RegFunction("OnJsonCallFunc", OnJsonCallFunc);
		L.RegFunction("CheckRayOverObject", CheckRayOverObject);
		L.RegFunction("Raycast", Raycast);
		L.RegFunction("Raycast2D", Raycast2D);
		L.RegFunction("ObjectIsNull", ObjectIsNull);
		L.RegFunction("Instantiate", Instantiate);
		L.RegFunction("WorldToCanvasPoint", WorldToCanvasPoint);
		L.RegFunction("WorldToScreenPoint", WorldToScreenPoint);
		L.RegFunction("ScreenToWorldPoint", ScreenToWorldPoint);
		L.RegFunction("ParticleSystemLength", ParticleSystemLength);
		L.RegFunction("GetAllParticleSystem", GetAllParticleSystem);
		L.RegFunction("GetChildByName", GetChildByName);
		L.RegFunction("SetAutoRotationLandscape", SetAutoRotationLandscape);
		L.RegFunction("SetAutoRotationPortrait", SetAutoRotationPortrait);
		L.RegFunction("StringRelaceAll", StringRelaceAll);
		L.RegFunction("GetLayerMask", GetLayerMask);
		L.RegFunction("Bit_Or", Bit_Or);
		L.RegFunction("Bit_And", Bit_And);
		L.RegFunction("NewPing", NewPing);
		L.RegFunction("AddLogMessageReceived", AddLogMessageReceived);
		L.RegFunction("ColliderDistance", ColliderDistance);
		L.RegFunction("SetDontDestroyOnLoad", SetDontDestroyOnLoad);
		L.RegFunction("DrawBlurTextureToggle", DrawBlurTextureToggle);
		L.RegVar("blurDrawing", get_blurDrawing, set_blurDrawing);
		L.RegVar("blurRange", get_blurRange, set_blurRange);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			System.Type o = LuaFramework.LuaHelper.GetType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaFramework.ResourceManager o = LuaFramework.LuaHelper.GetResManager();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNetManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaFramework.NetworkManager o = LuaFramework.LuaHelper.GetNetManager();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSceneManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaFramework.SceneManager o = LuaFramework.LuaHelper.GetSceneManager();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCallLuaFunc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaByteBuffer arg0 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 1));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			LuaFramework.LuaHelper.OnCallLuaFunc(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnJsonCallFunc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			LuaFramework.LuaHelper.OnJsonCallFunc(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckRayOverObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = LuaFramework.LuaHelper.CheckRayOverObject();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.RaycastHit o = LuaFramework.LuaHelper.Raycast(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast2D(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 1, typeof(UnityEngine.Camera));
			UnityEngine.RaycastHit2D o = LuaFramework.LuaHelper.Raycast2D(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ObjectIsNull(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object arg0 = ToLua.ToVarObject(L, 1);
			bool o = LuaFramework.LuaHelper.ObjectIsNull(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Instantiate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
				UnityEngine.Object o = LuaFramework.LuaHelper.Instantiate(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
				UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
				UnityEngine.Object o = LuaFramework.LuaHelper.Instantiate(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaFramework.LuaHelper.Instantiate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WorldToCanvasPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Canvas arg0 = (UnityEngine.Canvas)ToLua.CheckObject(L, 1, typeof(UnityEngine.Canvas));
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 o = LuaFramework.LuaHelper.WorldToCanvasPoint(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WorldToScreenPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.Vector3 o = LuaFramework.LuaHelper.WorldToScreenPoint(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenToWorldPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.Vector3 o = LuaFramework.LuaHelper.ScreenToWorldPoint(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParticleSystemLength(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.ParticleSystem[] arg0 = ToLua.CheckObjectArray<UnityEngine.ParticleSystem>(L, 1);
			float o = LuaFramework.LuaHelper.ParticleSystemLength(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllParticleSystem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			UnityEngine.ParticleSystem[] o = LuaFramework.LuaHelper.GetAllParticleSystem(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildByName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			string arg1 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = LuaFramework.LuaHelper.GetChildByName(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAutoRotationLandscape(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaFramework.LuaHelper.SetAutoRotationLandscape();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAutoRotationPortrait(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LuaFramework.LuaHelper.SetAutoRotationPortrait();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StringRelaceAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string o = LuaFramework.LuaHelper.StringRelaceAll(arg0, arg1, arg2);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLayerMask(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int o = LuaFramework.LuaHelper.GetLayerMask(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Bit_Or(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = LuaFramework.LuaHelper.Bit_Or(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Bit_And(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = LuaFramework.LuaHelper.Bit_And(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NewPing(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Ping o = LuaFramework.LuaHelper.NewPing(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddLogMessageReceived(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);
			LuaFramework.LuaHelper.AddLogMessageReceived(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ColliderDistance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Collider arg0 = (UnityEngine.Collider)ToLua.CheckObject<UnityEngine.Collider>(L, 1);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
			double o = LuaFramework.LuaHelper.ColliderDistance(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDontDestroyOnLoad(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			LuaFramework.LuaHelper.SetDontDestroyOnLoad(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawBlurTextureToggle(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				LuaFramework.LuaHelper.DrawBlurTextureToggle(arg0);
				return 0;
			}
			else if (count == 2)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				LuaFramework.LuaHelper.DrawBlurTextureToggle(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaFramework.LuaHelper.DrawBlurTextureToggle");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_blurDrawing(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, LuaFramework.LuaHelper.blurDrawing);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_blurRange(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, LuaFramework.LuaHelper.blurRange);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_blurDrawing(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			LuaFramework.LuaHelper.blurDrawing = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_blurRange(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			LuaFramework.LuaHelper.blurRange = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

