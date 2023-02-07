---@class LuaFramework.AppConst : object
---@field FrameworkRoot string
---@field LuaByteMode bool
---@field BundleMode bool
---@field UpdateMode bool
---@field TimerInterval int
---@field GameFrameRate int
---@field ResPathHead string
---@field AppName string
---@field LuaTempDir string
---@field AppPrefix string
---@field ExtName string
---@field AssetDir string
---@field GameServerIP string
---@field GameServerPort int
---@field UserId string
---@field SocketPort int
---@field SocketAddress string
local m = {}
LuaFramework = {}
LuaFramework.AppConst = m
return m