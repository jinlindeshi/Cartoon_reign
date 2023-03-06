﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using DG.Tweening;
using LuaInterface;

public class TMPro_TextMeshProWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TMPro.TextMeshPro), typeof(TMPro.TMP_Text));
		L.RegFunction("SetMask", SetMask);
		L.RegFunction("SetVerticesDirty", SetVerticesDirty);
		L.RegFunction("SetLayoutDirty", SetLayoutDirty);
		L.RegFunction("SetMaterialDirty", SetMaterialDirty);
		L.RegFunction("SetAllDirty", SetAllDirty);
		L.RegFunction("Rebuild", Rebuild);
		L.RegFunction("UpdateMeshPadding", UpdateMeshPadding);
		L.RegFunction("ForceMeshUpdate", ForceMeshUpdate);
		L.RegFunction("GetTextInfo", GetTextInfo);
		L.RegFunction("ClearMesh", ClearMesh);
		L.RegFunction("UpdateGeometry", UpdateGeometry);
		L.RegFunction("UpdateVertexData", UpdateVertexData);
		L.RegFunction("UpdateFontAsset", UpdateFontAsset);
		L.RegFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
		L.RegFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
		L.RegFunction("ComputeMarginSize", ComputeMarginSize);
		L.RegFunction("DOText", DOText);
		L.RegFunction("DOMaxVisibleCharacters", DOMaxVisibleCharacters);
		L.RegFunction("DOFontSize", DOFontSize);
		L.RegFunction("DOCounter", DOCounter);
		L.RegFunction("DOScale", DOScale);
		L.RegFunction("DOFaceFade", DOFaceFade);
		L.RegFunction("DOFade", DOFade);
		L.RegFunction("DOGlowColor", DOGlowColor);
		L.RegFunction("DOOutlineColor", DOOutlineColor);
		L.RegFunction("DOFaceColor", DOFaceColor);
		L.RegFunction("DOColor", DOColor);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("sortingLayerID", get_sortingLayerID, set_sortingLayerID);
		L.RegVar("sortingOrder", get_sortingOrder, set_sortingOrder);
		L.RegVar("autoSizeTextContainer", get_autoSizeTextContainer, set_autoSizeTextContainer);
		L.RegVar("transform", get_transform, null);
		L.RegVar("renderer", get_renderer, null);
		L.RegVar("mesh", get_mesh, null);
		L.RegVar("meshFilter", get_meshFilter, null);
		L.RegVar("maskType", get_maskType, set_maskType);
		L.RegVar("OnPreRenderText", get_OnPreRenderText, set_OnPreRenderText);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMask(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				TMPro.MaskingTypes arg0 = (TMPro.MaskingTypes)ToLua.CheckObject(L, 2, typeof(TMPro.MaskingTypes));
				UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 3);
				obj.SetMask(arg0, arg1);
				return 0;
			}
			else if (count == 5)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				TMPro.MaskingTypes arg0 = (TMPro.MaskingTypes)ToLua.CheckObject(L, 2, typeof(TMPro.MaskingTypes));
				UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
				obj.SetMask(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.SetMask");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVerticesDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.SetVerticesDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.SetLayoutDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaterialDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.SetMaterialDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAllDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.SetAllDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
			obj.Rebuild(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateMeshPadding(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.UpdateMeshPadding();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForceMeshUpdate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				obj.ForceMeshUpdate();
				return 0;
			}
			else if (count == 2)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.ForceMeshUpdate(arg0);
				return 0;
			}
			else if (count == 3)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.ForceMeshUpdate(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.ForceMeshUpdate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			TMPro.TMP_TextInfo o = obj.GetTextInfo(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearMesh(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				obj.ClearMesh();
				return 0;
			}
			else if (count == 2)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.ClearMesh(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.ClearMesh");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateGeometry(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			UnityEngine.Mesh arg0 = (UnityEngine.Mesh)ToLua.CheckObject(L, 2, typeof(UnityEngine.Mesh));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.UpdateGeometry(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateVertexData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				obj.UpdateVertexData();
				return 0;
			}
			else if (count == 2)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				TMPro.TMP_VertexDataUpdateFlags arg0 = (TMPro.TMP_VertexDataUpdateFlags)ToLua.CheckObject(L, 2, typeof(TMPro.TMP_VertexDataUpdateFlags));
				obj.UpdateVertexData(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.UpdateVertexData");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateFontAsset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.UpdateFontAsset();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputHorizontal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputVertical(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.CalculateLayoutInputVertical();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ComputeMarginSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			obj.ComputeMarginSize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOText(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				DG.Tweening.Core.TweenerCore<string,string,DG.Tweening.Plugins.Options.StringOptions> o = obj.DOText(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				DG.Tweening.Core.TweenerCore<string,string,DG.Tweening.Plugins.Options.StringOptions> o = obj.DOText(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				DG.Tweening.ScrambleMode arg3 = (DG.Tweening.ScrambleMode)ToLua.CheckObject(L, 5, typeof(DG.Tweening.ScrambleMode));
				DG.Tweening.Core.TweenerCore<string,string,DG.Tweening.Plugins.Options.StringOptions> o = obj.DOText(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 6)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				DG.Tweening.ScrambleMode arg3 = (DG.Tweening.ScrambleMode)ToLua.CheckObject(L, 5, typeof(DG.Tweening.ScrambleMode));
				string arg4 = ToLua.CheckString(L, 6);
				DG.Tweening.Core.TweenerCore<string,string,DG.Tweening.Plugins.Options.StringOptions> o = obj.DOText(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.DOText");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOMaxVisibleCharacters(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<int,int,DG.Tweening.Plugins.Options.NoOptions> o = obj.DOMaxVisibleCharacters(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOFontSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<float,float,DG.Tweening.Plugins.Options.FloatOptions> o = obj.DOFontSize(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOCounter(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				DG.Tweening.Core.TweenerCore<int,int,DG.Tweening.Plugins.Options.NoOptions> o = obj.DOCounter(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				DG.Tweening.Core.TweenerCore<int,int,DG.Tweening.Plugins.Options.NoOptions> o = obj.DOCounter(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 6)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				System.Globalization.CultureInfo arg4 = (System.Globalization.CultureInfo)ToLua.CheckObject<System.Globalization.CultureInfo>(L, 6);
				DG.Tweening.Core.TweenerCore<int,int,DG.Tweening.Plugins.Options.NoOptions> o = obj.DOCounter(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.DOCounter");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOScale(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> o = obj.DOScale(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOFaceFade(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOFaceFade(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOFade(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOFade(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOGlowColor(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOGlowColor(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
				UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOGlowColor(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TMPro.TextMeshPro.DOGlowColor");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOOutlineColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			UnityEngine.Color32 arg0 = StackTraits<UnityEngine.Color32>.Check(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOOutlineColor(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOFaceColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			UnityEngine.Color32 arg0 = StackTraits<UnityEngine.Color32>.Check(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOFaceColor(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject<TMPro.TextMeshPro>(L, 1);
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> o = obj.DOColor(arg0, arg1);
			ToLua.PushObject(L, o);
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
	static int get_sortingLayerID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			int ret = obj.sortingLayerID;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sortingLayerID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sortingOrder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			int ret = obj.sortingOrder;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sortingOrder on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoSizeTextContainer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			bool ret = obj.autoSizeTextContainer;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoSizeTextContainer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
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
	static int get_renderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			UnityEngine.Renderer ret = obj.renderer;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mesh(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			UnityEngine.Mesh ret = obj.mesh;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mesh on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_meshFilter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			UnityEngine.MeshFilter ret = obj.meshFilter;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index meshFilter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maskType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			TMPro.MaskingTypes ret = obj.maskType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maskType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnPreRenderText(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(System.Action<TMPro.TMP_TextInfo>)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sortingLayerID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.sortingLayerID = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sortingLayerID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sortingOrder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.sortingOrder = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sortingOrder on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoSizeTextContainer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.autoSizeTextContainer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoSizeTextContainer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maskType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)o;
			TMPro.MaskingTypes arg0 = (TMPro.MaskingTypes)ToLua.CheckObject(L, 2, typeof(TMPro.MaskingTypes));
			obj.maskType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maskType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnPreRenderText(IntPtr L)
	{
		try
		{
			TMPro.TextMeshPro obj = (TMPro.TextMeshPro)ToLua.CheckObject(L, 1, typeof(TMPro.TextMeshPro));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'TMPro.TextMeshPro.OnPreRenderText' can only appear on the left hand side of += or -= when used outside of the type 'TMPro.TextMeshPro'");
			}

			if (arg0.op == EventOp.Add)
			{
				System.Action<TMPro.TMP_TextInfo> ev = (System.Action<TMPro.TMP_TextInfo>)arg0.func;
				obj.OnPreRenderText += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				System.Action<TMPro.TMP_TextInfo> ev = (System.Action<TMPro.TMP_TextInfo>)arg0.func;
				obj.OnPreRenderText -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

