---@class UnityEngine.Rendering.Volume : UnityEngine.MonoBehaviour
---@field profile UnityEngine.Rendering.VolumeProfile
---@field isGlobal bool
---@field priority float
---@field blendDistance float
---@field weight float
---@field sharedProfile UnityEngine.Rendering.VolumeProfile
local m = {}
---@return bool
function m:HasInstantiatedProfile() end
UnityEngine = {}
UnityEngine.Rendering = {}
UnityEngine.Rendering.Volume = m
return m