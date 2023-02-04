﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_ABPathWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.ABPath), typeof(Pathfinding.Path));
		L.RegFunction("Construct", Construct);
		L.RegFunction("FakePath", FakePath);
		L.RegFunction("New", _CreatePathfinding_ABPath);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("startNode", get_startNode, set_startNode);
		L.RegVar("endNode", get_endNode, set_endNode);
		L.RegVar("originalStartPoint", get_originalStartPoint, set_originalStartPoint);
		L.RegVar("originalEndPoint", get_originalEndPoint, set_originalEndPoint);
		L.RegVar("startPoint", get_startPoint, set_startPoint);
		L.RegVar("endPoint", get_endPoint, set_endPoint);
		L.RegVar("startIntPoint", get_startIntPoint, set_startIntPoint);
		L.RegVar("calculatePartial", get_calculatePartial, set_calculatePartial);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_ABPath(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Pathfinding.ABPath obj = new Pathfinding.ABPath();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.ABPath.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Construct(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
				Pathfinding.ABPath o = Pathfinding.ABPath.Construct(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
				Pathfinding.OnPathDelegate arg2 = (Pathfinding.OnPathDelegate)ToLua.CheckDelegate<Pathfinding.OnPathDelegate>(L, 3);
				Pathfinding.ABPath o = Pathfinding.ABPath.Construct(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.ABPath.Construct");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FakePath(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Collections.Generic.List<UnityEngine.Vector3> arg0 = (System.Collections.Generic.List<UnityEngine.Vector3>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
				Pathfinding.ABPath o = Pathfinding.ABPath.FakePath(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				System.Collections.Generic.List<UnityEngine.Vector3> arg0 = (System.Collections.Generic.List<UnityEngine.Vector3>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
				System.Collections.Generic.List<Pathfinding.GraphNode> arg1 = (System.Collections.Generic.List<Pathfinding.GraphNode>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<Pathfinding.GraphNode>));
				Pathfinding.ABPath o = Pathfinding.ABPath.FakePath(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.ABPath.FakePath");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			Pathfinding.GraphNode ret = obj.startNode;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startNode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_endNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			Pathfinding.GraphNode ret = obj.endNode;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endNode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_originalStartPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 ret = obj.originalStartPoint;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index originalStartPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_originalEndPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 ret = obj.originalEndPoint;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index originalEndPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 ret = obj.startPoint;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_endPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 ret = obj.endPoint;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startIntPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			Pathfinding.Int3 ret = obj.startIntPoint;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startIntPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_calculatePartial(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			bool ret = obj.calculatePartial;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index calculatePartial on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			Pathfinding.GraphNode arg0 = (Pathfinding.GraphNode)ToLua.CheckObject<Pathfinding.GraphNode>(L, 2);
			obj.startNode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startNode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_endNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			Pathfinding.GraphNode arg0 = (Pathfinding.GraphNode)ToLua.CheckObject<Pathfinding.GraphNode>(L, 2);
			obj.endNode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endNode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_originalStartPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.originalStartPoint = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index originalStartPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_originalEndPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.originalEndPoint = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index originalEndPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.startPoint = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_endPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.endPoint = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index endPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startIntPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			Pathfinding.Int3 arg0 = StackTraits<Pathfinding.Int3>.Check(L, 2);
			obj.startIntPoint = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index startIntPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_calculatePartial(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.ABPath obj = (Pathfinding.ABPath)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.calculatePartial = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index calculatePartial on a nil value");
		}
	}
}

