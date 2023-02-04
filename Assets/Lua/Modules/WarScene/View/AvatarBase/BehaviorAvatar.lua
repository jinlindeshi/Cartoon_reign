---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2020/9/25 2:37 PM
--- 配置好行为的Avatar


local Avatar = require("Modules.WarScene.View.AvatarBase.Avatar")
---@class BehaviorAvatar:Avatar
---@field New fun(prefabPath:string, parent:UnityEngine.Transform):BehaviorAvatar
local BehaviorAvatar = class("BehaviorAvatar", Avatar)

function BehaviorAvatar:Ctor(prefabPath, parent)
    BehaviorAvatar.super.Ctor(self, prefabPath, true, parent)
    self.b2Lua = AddOrGetComponent(self.gameObject, BehaviorToLua) ---@type BehaviorToLua
    self.runningActions = {}
    self.b2Lua.StartWhenEnabled = false
    --self.b2Lua.ResetValuesOnRestart = true
    self.b2Lua.RestartWhenComplete = true
end


function BehaviorAvatar:SetExternalBehavior(path)
    --print("Avatar:SetExternalBehavior")
    self.b2Lua.ExternalBehavior = resMgr:LoadAssetsAtPath(path)
end

function BehaviorAvatar:RegisterAction(name, class)
    self.b2Lua:RegisterLuaFun(name, function (cAction, statusFunName, paramFloat, paramBool, paused)
        local action = self.runningActions[name]
        if not action then
            self.runningActions[name] = class.New(self, self.b2Lua, cAction, paramFloat, paramBool)
            action = self.runningActions[name]
        end
        if action[statusFunName] then
            if statusFunName == "OnPause" then
                action[statusFunName](action,paused)
            else
                action[statusFunName](action)
            end
        end
    end)

end

function BehaviorAvatar:AIStart()
    self.b2Lua.enabled = true
    self.b2Lua.StartWhenEnabled = true
    self.b2Lua:Start()
end


function BehaviorAvatar:AIPause()
    self.b2Lua:Pause()
end


function BehaviorAvatar:AIStop()
    self.b2Lua:Stop()
end

function BehaviorAvatar:Recycle()
    self:AIStop()
    self.b2Lua:Destroy()
    BehaviorAvatar.super.Recycle(self)

end

return BehaviorAvatar