﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using DG.Tweening;
using LuaInterface;

public class UnityEngine_ComponentWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Component), typeof(UnityEngine.Object));
		L.RegFunction("GetComponent", GetComponent);
		L.RegFunction("TryGetComponent", TryGetComponent);
		L.RegFunction("GetComponentInChildren", GetComponentInChildren);
		L.RegFunction("GetComponentsInChildren", GetComponentsInChildren);
		L.RegFunction("GetComponentInParent", GetComponentInParent);
		L.RegFunction("GetComponentsInParent", GetComponentsInParent);
		L.RegFunction("GetComponents", GetComponents);
		L.RegFunction("CompareTag", CompareTag);
		L.RegFunction("SendMessageUpwards", SendMessageUpwards);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("BroadcastMessage", BroadcastMessage);
		L.RegFunction("DOTogglePause", DOTogglePause);
		L.RegFunction("DOSmoothRewind", DOSmoothRewind);
		L.RegFunction("DORewind", DORewind);
		L.RegFunction("DORestart", DORestart);
		L.RegFunction("DOPlayForward", DOPlayForward);
		L.RegFunction("DOPlayBackwards", DOPlayBackwards);
		L.RegFunction("DOPlay", DOPlay);
		L.RegFunction("DOPause", DOPause);
		L.RegFunction("DOGoto", DOGoto);
		L.RegFunction("DOFlip", DOFlip);
		L.RegFunction("DOKill", DOKill);
		L.RegFunction("DOComplete", DOComplete);
		L.RegFunction("New", _CreateUnityEngine_Component);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("transform", get_transform, null);
		L.RegVar("gameObject", get_gameObject, null);
		L.RegVar("tag", get_tag, set_tag);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Component(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Component obj = new UnityEngine.Component();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Component.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<System.Type>(L, 2))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component o = obj.GetComponent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.Component o = obj.GetComponent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponent");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TryGetComponent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			UnityEngine.Component arg1 = null;
			bool o = obj.TryGetComponent(arg0, out arg1);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.Push(L, arg1);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.Component o = obj.GetComponentInChildren(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.Component o = obj.GetComponentInChildren(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponentInChildren");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.Component[] o = obj.GetComponentsInChildren(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.Component[] o = obj.GetComponentsInChildren(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponentsInChildren");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInParent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.Component o = obj.GetComponentInParent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.Component o = obj.GetComponentInParent(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponentInParent");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInParent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.Component[] o = obj.GetComponentsInParent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.Component[] o = obj.GetComponentsInParent(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponentsInParent");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponents(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				UnityEngine.Component[] o = obj.GetComponents(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				System.Collections.Generic.List<UnityEngine.Component> arg1 = (System.Collections.Generic.List<UnityEngine.Component>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Component>));
				obj.GetComponents(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponents");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.CompareTag(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessageUpwards(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.SendMessageUpwards(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.SendMessageOptions>(L, 3))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessageUpwards(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<object>(L, 3))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessageUpwards(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.CheckObject(L, 4, typeof(UnityEngine.SendMessageOptions));
				obj.SendMessageUpwards(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.SendMessageUpwards");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.SendMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.SendMessageOptions>(L, 3))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<object>(L, 3))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.CheckObject(L, 4, typeof(UnityEngine.SendMessageOptions));
				obj.SendMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.SendMessage");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BroadcastMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.BroadcastMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.SendMessageOptions>(L, 3))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.BroadcastMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<object>(L, 3))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.BroadcastMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.CheckObject(L, 4, typeof(UnityEngine.SendMessageOptions));
				obj.BroadcastMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.BroadcastMessage");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOTogglePause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOTogglePause();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOSmoothRewind(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOSmoothRewind();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DORewind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				int o = obj.DORewind();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DORewind(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.DORewind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DORestart(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				int o = obj.DORestart();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DORestart(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.DORestart");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPlayForward(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOPlayForward();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPlayBackwards(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOPlayBackwards();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPlay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOPlay();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOPause();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOGoto(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				int o = obj.DOGoto(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				int o = obj.DOGoto(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.DOGoto");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOFlip(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
			int o = obj.DOFlip();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOKill(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				int o = obj.DOKill();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DOKill(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.DOKill");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOComplete(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				int o = obj.DOComplete();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DOComplete(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.DOComplete");
			}
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
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			UnityEngine.Transform ret = obj.transform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			UnityEngine.GameObject ret = obj.gameObject;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index gameObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			string ret = obj.tag;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.tag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tag on a nil value");
		}
	}
}

