﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SeekerToLuaWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SeekerToLua), typeof(Pathfinding.Seeker));
		L.RegFunction("EditorInit", EditorInit);
		L.RegFunction("IntToVector", IntToVector);
		L.RegFunction("TakeMove", TakeMove);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EditorInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SeekerToLua obj = (SeekerToLua)ToLua.CheckObject<SeekerToLua>(L, 1);
			obj.EditorInit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToVector(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.Int3 arg0 = StackTraits<Pathfinding.Int3>.Check(L, 1);
			UnityEngine.Vector3 o = SeekerToLua.IntToVector(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TakeMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			SeekerToLua obj = (SeekerToLua)ToLua.CheckObject<SeekerToLua>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.TakeMove(arg0, arg1);
			return 0;
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

