---@class LuaFramework.GameManager : Manager
local m = {}
---@return System.Collections.IEnumerator
function m:CreateProgressUI() end
function m:CheckExtractResource() end
function m:OnResourceInited() end
LuaFramework = {}
LuaFramework.GameManager = m
return m