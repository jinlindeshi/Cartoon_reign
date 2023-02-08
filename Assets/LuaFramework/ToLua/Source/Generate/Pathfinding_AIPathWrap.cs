﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_AIPathWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.AIPath), typeof(Pathfinding.AIBase));
		L.RegFunction("Teleport", Teleport);
		L.RegFunction("GetRemainingPath", GetRemainingPath);
		L.RegFunction("OnTargetReached", OnTargetReached);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("maxAcceleration", get_maxAcceleration, set_maxAcceleration);
		L.RegVar("rotationSpeed", get_rotationSpeed, set_rotationSpeed);
		L.RegVar("slowdownDistance", get_slowdownDistance, set_slowdownDistance);
		L.RegVar("pickNextWaypointDist", get_pickNextWaypointDist, set_pickNextWaypointDist);
		L.RegVar("endReachedDistance", get_endReachedDistance, set_endReachedDistance);
		L.RegVar("alwaysDrawGizmos", get_alwaysDrawGizmos, set_alwaysDrawGizmos);
		L.RegVar("slowWhenNotFacingTarget", get_slowWhenNotFacingTarget, set_slowWhenNotFacingTarget);
		L.RegVar("whenCloseToDestination", get_whenCloseToDestination, set_whenCloseToDestination);
		L.RegVar("constrainInsideGraph", get_constrainInsideGraph, set_constrainInsideGraph);
		L.RegVar("remainingDistance", get_remainingDistance, null);
		L.RegVar("reachedDestination", get_reachedDestination, null);
		L.RegVar("reachedEndOfPath", get_reachedEndOfPath, null);
		L.RegVar("hasPath", get_hasPath, null);
		L.RegVar("pathPending", get_pathPending, null);
		L.RegVar("steeringTarget", get_steeringTarget, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Teleport(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Pathfinding.AIPath obj = (Pathfinding.AIPath)ToLua.CheckObject<Pathfinding.AIPath>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.Teleport(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Pathfinding.AIPath obj = (Pathfinding.AIPath)ToLua.CheckObject<Pathfinding.AIPath>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.Teleport(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.AIPath.Teleport");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRemainingPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)ToLua.CheckObject<Pathfinding.AIPath>(L, 1);
			System.Collections.Generic.List<UnityEngine.Vector3> arg0 = (System.Collections.Generic.List<UnityEngine.Vector3>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
			bool arg1;
			obj.GetRemainingPath(arg0, out arg1);
			LuaDLL.lua_pushboolean(L, arg1);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTargetReached(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)ToLua.CheckObject<Pathfinding.AIPath>(L, 1);
			obj.OnTargetReached();
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxAcceleration(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float ret = obj.maxAcceleration;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxAcceleration on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotationSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float ret = obj.rotationSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotationSpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_slowdownDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float ret = obj.slowdownDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index slowdownDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pickNextWaypointDist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float ret = obj.pickNextWaypointDist;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pickNextWaypointDist on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_endReachedDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float ret = obj.endReachedDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endReachedDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alwaysDrawGizmos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.alwaysDrawGizmos;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alwaysDrawGizmos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_slowWhenNotFacingTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.slowWhenNotFacingTarget;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index slowWhenNotFacingTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_whenCloseToDestination(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			Pathfinding.CloseToDestinationMode ret = obj.whenCloseToDestination;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index whenCloseToDestination on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_constrainInsideGraph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.constrainInsideGraph;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constrainInsideGraph on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_remainingDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float ret = obj.remainingDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index remainingDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reachedDestination(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.reachedDestination;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reachedDestination on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reachedEndOfPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.reachedEndOfPath;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reachedEndOfPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.hasPath;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hasPath on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathPending(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool ret = obj.pathPending;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pathPending on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_steeringTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			UnityEngine.Vector3 ret = obj.steeringTarget;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index steeringTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxAcceleration(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.maxAcceleration = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxAcceleration on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rotationSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.rotationSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotationSpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_slowdownDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.slowdownDistance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index slowdownDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pickNextWaypointDist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.pickNextWaypointDist = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pickNextWaypointDist on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_endReachedDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.endReachedDistance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endReachedDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alwaysDrawGizmos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.alwaysDrawGizmos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alwaysDrawGizmos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_slowWhenNotFacingTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.slowWhenNotFacingTarget = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index slowWhenNotFacingTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_whenCloseToDestination(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			Pathfinding.CloseToDestinationMode arg0 = (Pathfinding.CloseToDestinationMode)ToLua.CheckObject(L, 2, typeof(Pathfinding.CloseToDestinationMode));
			obj.whenCloseToDestination = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index whenCloseToDestination on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_constrainInsideGraph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AIPath obj = (Pathfinding.AIPath)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.constrainInsideGraph = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constrainInsideGraph on a nil value");
		}
	}
}

