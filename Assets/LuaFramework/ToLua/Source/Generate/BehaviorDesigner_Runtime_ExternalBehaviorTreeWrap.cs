﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BehaviorDesigner_Runtime_ExternalBehaviorTreeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BehaviorDesigner.Runtime.ExternalBehaviorTree), typeof(BehaviorDesigner.Runtime.ExternalBehavior));
		L.RegFunction("New", _CreateBehaviorDesigner_Runtime_ExternalBehaviorTree);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBehaviorDesigner_Runtime_ExternalBehaviorTree(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				BehaviorDesigner.Runtime.ExternalBehaviorTree obj = new BehaviorDesigner.Runtime.ExternalBehaviorTree();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: BehaviorDesigner.Runtime.ExternalBehaviorTree.New");
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
}

