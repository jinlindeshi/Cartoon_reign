﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Rendering_Universal_UniversalAdditionalCameraDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Rendering.Universal.UniversalAdditionalCameraData), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SetRenderer", SetRenderer);
		L.RegFunction("OnBeforeSerialize", OnBeforeSerialize);
		L.RegFunction("OnAfterDeserialize", OnAfterDeserialize);
		L.RegFunction("OnDrawGizmos", OnDrawGizmos);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("version", get_version, null);
		L.RegVar("renderShadows", get_renderShadows, set_renderShadows);
		L.RegVar("requiresDepthOption", get_requiresDepthOption, set_requiresDepthOption);
		L.RegVar("requiresColorOption", get_requiresColorOption, set_requiresColorOption);
		L.RegVar("renderType", get_renderType, set_renderType);
		L.RegVar("cameraStack", get_cameraStack, null);
		L.RegVar("clearDepth", get_clearDepth, null);
		L.RegVar("requiresDepthTexture", get_requiresDepthTexture, set_requiresDepthTexture);
		L.RegVar("requiresColorTexture", get_requiresColorTexture, set_requiresColorTexture);
		L.RegVar("scriptableRenderer", get_scriptableRenderer, null);
		L.RegVar("volumeLayerMask", get_volumeLayerMask, set_volumeLayerMask);
		L.RegVar("volumeTrigger", get_volumeTrigger, set_volumeTrigger);
		L.RegVar("renderPostProcessing", get_renderPostProcessing, set_renderPostProcessing);
		L.RegVar("antialiasing", get_antialiasing, set_antialiasing);
		L.RegVar("antialiasingQuality", get_antialiasingQuality, set_antialiasingQuality);
		L.RegVar("stopNaN", get_stopNaN, set_stopNaN);
		L.RegVar("dithering", get_dithering, set_dithering);
		L.RegVar("allowXRRendering", get_allowXRRendering, set_allowXRRendering);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRenderer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)ToLua.CheckObject<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetRenderer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeforeSerialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)ToLua.CheckObject<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>(L, 1);
			obj.OnBeforeSerialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAfterDeserialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)ToLua.CheckObject<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>(L, 1);
			obj.OnAfterDeserialize();
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
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)ToLua.CheckObject<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>(L, 1);
			obj.OnDrawGizmos();
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
	static int get_version(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			float ret = obj.version;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index version on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderShadows(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.renderShadows;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderShadows on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_requiresDepthOption(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.CameraOverrideOption ret = obj.requiresDepthOption;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresDepthOption on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_requiresColorOption(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.CameraOverrideOption ret = obj.requiresColorOption;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresColorOption on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.CameraRenderType ret = obj.renderType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cameraStack(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			System.Collections.Generic.List<UnityEngine.Camera> ret = obj.cameraStack;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cameraStack on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clearDepth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.clearDepth;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clearDepth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_requiresDepthTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.requiresDepthTexture;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresDepthTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_requiresColorTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.requiresColorTexture;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresColorTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scriptableRenderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.ScriptableRenderer ret = obj.scriptableRenderer;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scriptableRenderer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_volumeLayerMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.LayerMask ret = obj.volumeLayerMask;
			ToLua.PushLayerMask(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index volumeLayerMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_volumeTrigger(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Transform ret = obj.volumeTrigger;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index volumeTrigger on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderPostProcessing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.renderPostProcessing;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderPostProcessing on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_antialiasing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.AntialiasingMode ret = obj.antialiasing;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index antialiasing on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_antialiasingQuality(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.AntialiasingQuality ret = obj.antialiasingQuality;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index antialiasingQuality on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stopNaN(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.stopNaN;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index stopNaN on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dithering(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.dithering;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dithering on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_allowXRRendering(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool ret = obj.allowXRRendering;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index allowXRRendering on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderShadows(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.renderShadows = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderShadows on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_requiresDepthOption(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.CameraOverrideOption arg0 = (UnityEngine.Rendering.Universal.CameraOverrideOption)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.Universal.CameraOverrideOption));
			obj.requiresDepthOption = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresDepthOption on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_requiresColorOption(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.CameraOverrideOption arg0 = (UnityEngine.Rendering.Universal.CameraOverrideOption)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.Universal.CameraOverrideOption));
			obj.requiresColorOption = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresColorOption on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.CameraRenderType arg0 = (UnityEngine.Rendering.Universal.CameraRenderType)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.Universal.CameraRenderType));
			obj.renderType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_requiresDepthTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.requiresDepthTexture = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresDepthTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_requiresColorTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.requiresColorTexture = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requiresColorTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_volumeLayerMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.LayerMask arg0 = ToLua.ToLayerMask(L, 2);
			obj.volumeLayerMask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index volumeLayerMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_volumeTrigger(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.volumeTrigger = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index volumeTrigger on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderPostProcessing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.renderPostProcessing = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderPostProcessing on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_antialiasing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.AntialiasingMode arg0 = (UnityEngine.Rendering.Universal.AntialiasingMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.Universal.AntialiasingMode));
			obj.antialiasing = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index antialiasing on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_antialiasingQuality(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			UnityEngine.Rendering.Universal.AntialiasingQuality arg0 = (UnityEngine.Rendering.Universal.AntialiasingQuality)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.Universal.AntialiasingQuality));
			obj.antialiasingQuality = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index antialiasingQuality on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stopNaN(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.stopNaN = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index stopNaN on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dithering(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.dithering = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dithering on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_allowXRRendering(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Rendering.Universal.UniversalAdditionalCameraData obj = (UnityEngine.Rendering.Universal.UniversalAdditionalCameraData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.allowXRRendering = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index allowXRRendering on a nil value");
		}
	}
}

