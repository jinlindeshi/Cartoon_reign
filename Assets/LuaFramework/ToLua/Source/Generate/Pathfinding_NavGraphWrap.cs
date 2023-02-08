﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_NavGraphWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.NavGraph), typeof(System.Object));
		L.RegFunction("CountNodes", CountNodes);
		L.RegFunction("GetNodes", GetNodes);
		L.RegFunction("RelocateNodes", RelocateNodes);
		L.RegFunction("GetNearest", GetNearest);
		L.RegFunction("GetNearestForce", GetNearestForce);
		L.RegFunction("Scan", Scan);
		L.RegFunction("OnDrawGizmos", OnDrawGizmos);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("active", get_active, set_active);
		L.RegVar("guid", get_guid, set_guid);
		L.RegVar("initialPenalty", get_initialPenalty, set_initialPenalty);
		L.RegVar("open", get_open, set_open);
		L.RegVar("graphIndex", get_graphIndex, set_graphIndex);
		L.RegVar("name", get_name, set_name);
		L.RegVar("drawGizmos", get_drawGizmos, set_drawGizmos);
		L.RegVar("infoScreenOpen", get_infoScreenOpen, set_infoScreenOpen);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CountNodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
			int o = obj.CountNodes();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNodes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<System.Func<Pathfinding.GraphNode,bool>>(L, 2))
			{
				Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
				System.Func<Pathfinding.GraphNode,bool> arg0 = (System.Func<Pathfinding.GraphNode,bool>)ToLua.ToObject(L, 2);
				obj.GetNodes(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<System.Action<Pathfinding.GraphNode>>(L, 2))
			{
				Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
				System.Action<Pathfinding.GraphNode> arg0 = (System.Action<Pathfinding.GraphNode>)ToLua.ToObject(L, 2);
				obj.GetNodes(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.NavGraph.GetNodes");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RelocateNodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
			UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 2);
			obj.RelocateNodes(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNearest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				Pathfinding.NNInfoInternal o = obj.GetNearest(arg0);
				ToLua.PushValue(L, o);
				return 1;
			}
			else if (count == 3)
			{
				Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				Pathfinding.NNConstraint arg1 = (Pathfinding.NNConstraint)ToLua.CheckObject<Pathfinding.NNConstraint>(L, 3);
				Pathfinding.NNInfoInternal o = obj.GetNearest(arg0, arg1);
				ToLua.PushValue(L, o);
				return 1;
			}
			else if (count == 4)
			{
				Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				Pathfinding.NNConstraint arg1 = (Pathfinding.NNConstraint)ToLua.CheckObject<Pathfinding.NNConstraint>(L, 3);
				Pathfinding.GraphNode arg2 = (Pathfinding.GraphNode)ToLua.CheckObject<Pathfinding.GraphNode>(L, 4);
				Pathfinding.NNInfoInternal o = obj.GetNearest(arg0, arg1, arg2);
				ToLua.PushValue(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.NavGraph.GetNearest");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNearestForce(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.NNConstraint arg1 = (Pathfinding.NNConstraint)ToLua.CheckObject<Pathfinding.NNConstraint>(L, 3);
			Pathfinding.NNInfoInternal o = obj.GetNearestForce(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Scan(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
			obj.Scan();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrawGizmos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)ToLua.CheckObject<Pathfinding.NavGraph>(L, 1);
			Pathfinding.Util.RetainedGizmos arg0 = (Pathfinding.Util.RetainedGizmos)ToLua.CheckObject<Pathfinding.Util.RetainedGizmos>(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.OnDrawGizmos(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_active(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			AstarPath ret = obj.active;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index active on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_guid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			Pathfinding.Util.Guid ret = obj.guid;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index guid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_initialPenalty(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			uint ret = obj.initialPenalty;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index initialPenalty on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_open(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			bool ret = obj.open;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index open on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_graphIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			uint ret = obj.graphIndex;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graphIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawGizmos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			bool ret = obj.drawGizmos;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index drawGizmos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_infoScreenOpen(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			bool ret = obj.infoScreenOpen;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index infoScreenOpen on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_active(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			AstarPath arg0 = (AstarPath)ToLua.CheckObject<AstarPath>(L, 2);
			obj.active = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index active on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_guid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			Pathfinding.Util.Guid arg0 = StackTraits<Pathfinding.Util.Guid>.Check(L, 2);
			obj.guid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index guid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_initialPenalty(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.initialPenalty = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index initialPenalty on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_open(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.open = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index open on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_graphIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.graphIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graphIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drawGizmos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.drawGizmos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index drawGizmos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_infoScreenOpen(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.NavGraph obj = (Pathfinding.NavGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.infoScreenOpen = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index infoScreenOpen on a nil value");
		}
	}
}

