---@class LuaFramework.NetworkManager : Manager
---@field pushCall LuaInterface.LuaFunction
local m = {}
function m:Connect() end
---@param action string
---@param content string
---@param callBack LuaInterface.LuaFunction
function m:Send(action, content, callBack) end
function m:Unload() end
LuaFramework = {}
LuaFramework.NetworkManager = m
return m