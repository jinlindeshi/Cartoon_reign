﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BehaviorDesigner_Runtime_Tasks_LuaActionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BehaviorDesigner.Runtime.Tasks.LuaAction), typeof(BehaviorDesigner.Runtime.Tasks.Action));
		L.RegFunction("SetUpdateStatus", SetUpdateStatus);
		L.RegFunction("GetUpdateStatus", GetUpdateStatus);
		L.RegFunction("CheckUpdateStatus", CheckUpdateStatus);
		L.RegFunction("OnAwake", OnAwake);
		L.RegFunction("OnStart", OnStart);
		L.RegFunction("OnUpdate", OnUpdate);
		L.RegFunction("OnPause", OnPause);
		L.RegFunction("OnEnd", OnEnd);
		L.RegFunction("OnReset", OnReset);
		L.RegFunction("OnBehaviorComplete", OnBehaviorComplete);
		L.RegFunction("OnBehaviorRestart", OnBehaviorRestart);
		L.RegFunction("New", _CreateBehaviorDesigner_Runtime_Tasks_LuaAction);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("paramFloat", get_paramFloat, set_paramFloat);
		L.RegVar("paramBool", get_paramBool, set_paramBool);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBehaviorDesigner_Runtime_Tasks_LuaAction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				BehaviorDesigner.Runtime.Tasks.LuaAction obj = new BehaviorDesigner.Runtime.Tasks.LuaAction();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: BehaviorDesigner.Runtime.Tasks.LuaAction.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetUpdateStatus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)ToLua.CheckObject(L, 2, typeof(BehaviorDesigner.Runtime.Tasks.TaskStatus));
			obj.SetUpdateStatus(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUpdateStatus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.GetUpdateStatus();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckUpdateStatus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)ToLua.CheckObject(L, 2, typeof(BehaviorDesigner.Runtime.Tasks.TaskStatus));
			bool o = obj.CheckUpdateStatus(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAwake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			obj.OnAwake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			obj.OnStart();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OnUpdate();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.OnPause(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			obj.OnEnd();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnReset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			obj.OnReset();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBehaviorComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			obj.OnBehaviorComplete();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBehaviorRestart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.LuaAction>(L, 1);
			obj.OnBehaviorRestart();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_paramFloat(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)o;
			BehaviorDesigner.Runtime.SharedFloat ret = obj.paramFloat;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index paramFloat on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_paramBool(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)o;
			BehaviorDesigner.Runtime.SharedBool ret = obj.paramBool;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index paramBool on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_paramFloat(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)o;
			BehaviorDesigner.Runtime.SharedFloat arg0 = (BehaviorDesigner.Runtime.SharedFloat)ToLua.CheckObject<BehaviorDesigner.Runtime.SharedFloat>(L, 2);
			obj.paramFloat = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index paramFloat on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_paramBool(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.LuaAction obj = (BehaviorDesigner.Runtime.Tasks.LuaAction)o;
			BehaviorDesigner.Runtime.SharedBool arg0 = (BehaviorDesigner.Runtime.SharedBool)ToLua.CheckObject<BehaviorDesigner.Runtime.SharedBool>(L, 2);
			obj.paramBool = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index paramBool on a nil value");
		}
	}
}

