﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BitBenderGames_MobileTouchCameraWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BitBenderGames.MobileTouchCamera), typeof(BitBenderGames.MonoBehaviourWrapped));
		L.RegFunction("Awake", Awake);
		L.RegFunction("Start", Start);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("ResetCameraBoundaries", ResetCameraBoundaries);
		L.RegFunction("ResetZoomTilt", ResetZoomTilt);
		L.RegFunction("GetFinger0PosWorld", GetFinger0PosWorld);
		L.RegFunction("RaycastGround", RaycastGround);
		L.RegFunction("GetIntersectionPoint", GetIntersectionPoint);
		L.RegFunction("GetIntersectionPointUnsafe", GetIntersectionPointUnsafe);
		L.RegFunction("GetIsBoundaryPosition", GetIsBoundaryPosition);
		L.RegFunction("GetClampToBoundaries", GetClampToBoundaries);
		L.RegFunction("OnDragSceneObject", OnDragSceneObject);
		L.RegFunction("CheckCameraAxesErrors", CheckCameraAxesErrors);
		L.RegFunction("UnprojectVector2", UnprojectVector2);
		L.RegFunction("ProjectVector3", ProjectVector3);
		L.RegFunction("LateUpdate", LateUpdate);
		L.RegFunction("FixedUpdate", FixedUpdate);
		L.RegFunction("InputControllerOnFingerDown", InputControllerOnFingerDown);
		L.RegFunction("InputControllerOnFingerUp", InputControllerOnFingerUp);
		L.RegFunction("setDragMode", setDragMode);
		L.RegFunction("setShopMode", setShopMode);
		L.RegFunction("setTruckTutorialMode", setTruckTutorialMode);
		L.RegFunction("OnDrawGizmosSelected", OnDrawGizmosSelected);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, set_Instance);
		L.RegVar("main", get_main, set_main);
		L.RegVar("CameraAxes", get_CameraAxes, set_CameraAxes);
		L.RegVar("IsAutoScrolling", get_IsAutoScrolling, null);
		L.RegVar("IsPinching", get_IsPinching, null);
		L.RegVar("IsDragging", get_IsDragging, null);
		L.RegVar("Cam", get_Cam, null);
		L.RegVar("CamZoom", get_CamZoom, set_CamZoom);
		L.RegVar("CamZoomMin", get_CamZoomMin, set_CamZoomMin);
		L.RegVar("CamZoomMax", get_CamZoomMax, set_CamZoomMax);
		L.RegVar("CamOverzoomMargin", get_CamOverzoomMargin, set_CamOverzoomMargin);
		L.RegVar("CamFollowFactor", get_CamFollowFactor, set_CamFollowFactor);
		L.RegVar("AutoScrollDamp", get_AutoScrollDamp, set_AutoScrollDamp);
		L.RegVar("AutoScrollDampCurve", get_AutoScrollDampCurve, set_AutoScrollDampCurve);
		L.RegVar("GroundLevelOffset", get_GroundLevelOffset, set_GroundLevelOffset);
		L.RegVar("BoundaryMin", get_BoundaryMin, set_BoundaryMin);
		L.RegVar("BoundaryMax", get_BoundaryMax, set_BoundaryMax);
		L.RegVar("PerspectiveZoomMode", get_PerspectiveZoomMode, set_PerspectiveZoomMode);
		L.RegVar("EnableRotation", get_EnableRotation, set_EnableRotation);
		L.RegVar("EnableTilt", get_EnableTilt, set_EnableTilt);
		L.RegVar("TiltAngleMin", get_TiltAngleMin, set_TiltAngleMin);
		L.RegVar("TiltAngleMax", get_TiltAngleMax, set_TiltAngleMax);
		L.RegVar("EnableZoomTilt", get_EnableZoomTilt, set_EnableZoomTilt);
		L.RegVar("ZoomTiltAngleMin", get_ZoomTiltAngleMin, set_ZoomTiltAngleMin);
		L.RegVar("ZoomTiltAngleMax", get_ZoomTiltAngleMax, set_ZoomTiltAngleMax);
		L.RegVar("RefPlane", get_RefPlane, null);
		L.RegVar("IsSmoothingEnabled", get_IsSmoothingEnabled, set_IsSmoothingEnabled);
		L.RegVar("CameraScrollVelocity", get_CameraScrollVelocity, set_CameraScrollVelocity);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Awake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.Awake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Start(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.Start();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.OnDestroy();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetCameraBoundaries(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.ResetCameraBoundaries();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetZoomTilt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.ResetZoomTilt();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFinger0PosWorld(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Vector3 o = obj.GetFinger0PosWorld();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RaycastGround(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Ray arg0 = ToLua.ToRay(L, 2);
			UnityEngine.Vector3 arg1;
			bool o = obj.RaycastGround(arg0, out arg1);
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
	static int GetIntersectionPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Ray arg0 = ToLua.ToRay(L, 2);
			UnityEngine.Vector3 o = obj.GetIntersectionPoint(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIntersectionPointUnsafe(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Ray arg0 = ToLua.ToRay(L, 2);
			UnityEngine.Vector3 o = obj.GetIntersectionPointUnsafe(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIsBoundaryPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool o = obj.GetIsBoundaryPosition(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClampToBoundaries(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.GetClampToBoundaries(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.Vector3 o = obj.GetClampToBoundaries(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BitBenderGames.MobileTouchCamera.GetClampToBoundaries");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDragSceneObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.OnDragSceneObject();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckCameraAxesErrors(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			string o = obj.CheckCameraAxesErrors();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnprojectVector2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
				UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
				UnityEngine.Vector3 o = obj.UnprojectVector2(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
				UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector3 o = obj.UnprojectVector2(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BitBenderGames.MobileTouchCamera.UnprojectVector2");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProjectVector3(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector2 o = obj.ProjectVector3(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LateUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.LateUpdate();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FixedUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.FixedUpdate();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InputControllerOnFingerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.InputControllerOnFingerDown(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InputControllerOnFingerUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.InputControllerOnFingerUp();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setDragMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.setDragMode(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setShopMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.setShopMode(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setTruckTutorialMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.setTruckTutorialMode(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrawGizmosSelected(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 1);
			obj.OnDrawGizmosSelected();
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
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, BitBenderGames.MobileTouchCamera.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_main(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Camera ret = obj.main;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index main on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CameraAxes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			BitBenderGames.CameraPlaneAxes ret = obj.CameraAxes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CameraAxes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsAutoScrolling(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.IsAutoScrolling;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsAutoScrolling on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsPinching(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.IsPinching;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsPinching on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsDragging(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.IsDragging;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsDragging on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Cam(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Camera ret = obj.Cam;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Cam on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CamZoom(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.CamZoom;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamZoom on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CamZoomMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.CamZoomMin;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamZoomMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CamZoomMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.CamZoomMax;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamZoomMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CamOverzoomMargin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.CamOverzoomMargin;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamOverzoomMargin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CamFollowFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.CamFollowFactor;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamFollowFactor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AutoScrollDamp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.AutoScrollDamp;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AutoScrollDamp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AutoScrollDampCurve(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.AnimationCurve ret = obj.AutoScrollDampCurve;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AutoScrollDampCurve on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GroundLevelOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.GroundLevelOffset;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GroundLevelOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BoundaryMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Vector2 ret = obj.BoundaryMin;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BoundaryMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BoundaryMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Vector2 ret = obj.BoundaryMax;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BoundaryMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PerspectiveZoomMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			BitBenderGames.PerspectiveZoomMode ret = obj.PerspectiveZoomMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PerspectiveZoomMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableRotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.EnableRotation;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index EnableRotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableTilt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.EnableTilt;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index EnableTilt on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TiltAngleMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.TiltAngleMin;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TiltAngleMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TiltAngleMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.TiltAngleMax;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TiltAngleMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EnableZoomTilt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.EnableZoomTilt;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index EnableZoomTilt on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ZoomTiltAngleMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.ZoomTiltAngleMin;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ZoomTiltAngleMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ZoomTiltAngleMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float ret = obj.ZoomTiltAngleMax;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ZoomTiltAngleMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RefPlane(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Plane ret = obj.RefPlane;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index RefPlane on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSmoothingEnabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool ret = obj.IsSmoothingEnabled;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsSmoothingEnabled on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CameraScrollVelocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Vector2 ret = obj.CameraScrollVelocity;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CameraScrollVelocity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Instance(IntPtr L)
	{
		try
		{
			BitBenderGames.MobileTouchCamera arg0 = (BitBenderGames.MobileTouchCamera)ToLua.CheckObject<BitBenderGames.MobileTouchCamera>(L, 2);
			BitBenderGames.MobileTouchCamera.Instance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_main(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 2, typeof(UnityEngine.Camera));
			obj.main = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index main on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CameraAxes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			BitBenderGames.CameraPlaneAxes arg0 = (BitBenderGames.CameraPlaneAxes)ToLua.CheckObject(L, 2, typeof(BitBenderGames.CameraPlaneAxes));
			obj.CameraAxes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CameraAxes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CamZoom(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CamZoom = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamZoom on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CamZoomMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CamZoomMin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamZoomMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CamZoomMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CamZoomMax = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamZoomMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CamOverzoomMargin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CamOverzoomMargin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamOverzoomMargin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CamFollowFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CamFollowFactor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CamFollowFactor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AutoScrollDamp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.AutoScrollDamp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AutoScrollDamp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AutoScrollDampCurve(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.AnimationCurve arg0 = (UnityEngine.AnimationCurve)ToLua.CheckObject<UnityEngine.AnimationCurve>(L, 2);
			obj.AutoScrollDampCurve = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AutoScrollDampCurve on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GroundLevelOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.GroundLevelOffset = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GroundLevelOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BoundaryMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.BoundaryMin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BoundaryMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BoundaryMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.BoundaryMax = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BoundaryMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PerspectiveZoomMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			BitBenderGames.PerspectiveZoomMode arg0 = (BitBenderGames.PerspectiveZoomMode)ToLua.CheckObject(L, 2, typeof(BitBenderGames.PerspectiveZoomMode));
			obj.PerspectiveZoomMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PerspectiveZoomMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_EnableRotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.EnableRotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index EnableRotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_EnableTilt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.EnableTilt = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index EnableTilt on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TiltAngleMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.TiltAngleMin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TiltAngleMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TiltAngleMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.TiltAngleMax = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TiltAngleMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_EnableZoomTilt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.EnableZoomTilt = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index EnableZoomTilt on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ZoomTiltAngleMin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.ZoomTiltAngleMin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ZoomTiltAngleMin on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ZoomTiltAngleMax(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.ZoomTiltAngleMax = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ZoomTiltAngleMax on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsSmoothingEnabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsSmoothingEnabled = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsSmoothingEnabled on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CameraScrollVelocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BitBenderGames.MobileTouchCamera obj = (BitBenderGames.MobileTouchCamera)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.CameraScrollVelocity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CameraScrollVelocity on a nil value");
		}
	}
}

