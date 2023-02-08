﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Rendering_VolumeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Rendering.Volume), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("HasInstantiatedProfile", HasInstantiatedProfile);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isGlobal", get_isGlobal, set_isGlobal);
		L.RegVar("priority", get_priority, set_priority);
		L.RegVar("blendDistance", get_blendDistance, set_blendDistance);
		L.RegVar("weight", get_weight, set_weight);
		L.RegVar("sharedProfile", get_sharedProfile, set_sharedProfile);
		L.RegVar("profile", get_profile, set_profile);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasInstantiatedProfile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)ToLua.CheckObject<UnityEngine.Rendering.Volume>(L, 1);
			bool o = obj.HasInstantiatedProfile();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isGlobal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			bool ret = obj.isGlobal;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isGlobal on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			float ret = obj.priority;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_blendDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			float ret = obj.blendDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index blendDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_weight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			float ret = obj.weight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index weight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sharedProfile(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			UnityEngine.Rendering.VolumeProfile ret = obj.sharedProfile;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sharedProfile on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_profile(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			UnityEngine.Rendering.VolumeProfile ret = obj.profile;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index profile on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isGlobal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isGlobal = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isGlobal on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.priority = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_blendDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.blendDistance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index blendDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_weight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.weight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index weight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sharedProfile(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			UnityEngine.Rendering.VolumeProfile arg0 = (UnityEngine.Rendering.VolumeProfile)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.VolumeProfile));
			obj.sharedProfile = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sharedProfile on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_profile(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Volume obj = (UnityEngine.Rendering.Volume)o;
			UnityEngine.Rendering.VolumeProfile arg0 = (UnityEngine.Rendering.VolumeProfile)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.VolumeProfile));
			obj.profile = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index profile on a nil value");
		}
	}
}

