---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2018/5/19 下午3:40
---

require "LuaCore/functions"
require "Data/Constants/define"
require "Game"

function Main()
     print("Main", LuaFramework)
     Game.Init()
end

local function errorHandler(msg)
     LogError("[lua error]\n"..msg, debug.traceback("", 2))
end

xpcall(Main, errorHandler)