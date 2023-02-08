---@class LuaFramework.ResourceManager : Manager
local m = {}
function m:Initialize() end
---@param assetPath string
---@return UnityEngine.GameObject
function m:LoadPrefabAtPath(assetPath) end
---@param assetPath string
---@return UnityEngine.Object
function m:LoadAssetsAtPath(assetPath) end
---@param assetPath string
---@return UnityEngine.Material
function m:LoadMaterialAtPath(assetPath) end
---@param assetPath string
---@return UnityEngine.Sprite
function m:LoadSpriteAtPath(assetPath) end
---@param abname string
---@param async bool
---@param callBack LuaInterface.LuaFunction
---@return UnityEngine.AssetBundle
function m:LoadAssetBundle(abname, async, callBack) end
---@param abname string
---@return UnityEngine.AssetBundleCreateRequest
function m:GetLoadingRequestInfo(abname) end
---@param abname string
---@return table
function m:GetLoadingDependsList(abname) end
LuaFramework = {}
LuaFramework.ResourceManager = m
return m