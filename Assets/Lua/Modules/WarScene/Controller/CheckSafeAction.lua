---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by VIVA.
--- DateTime: 2023/1/27 12:07
--- 检查地图是否安全（是否有敌方单位）,如果不安全锁定最近的敌方单位
local WarData = require("Modules.WarScene.Model.WarData")
local BaseAction = require("Prayer.Core.BaseAction")
---@class CheckSafeAction:BaseAction
local CheckSafeAction = class("CheckSafeAction", BaseAction)

function CheckSafeAction:Ctor(avatar, bToLua, cAction, paramFloat, paramBool)
    CheckSafeAction.super.Ctor(self, bToLua, cAction, paramFloat, paramBool)
    self.avatar = avatar ---@type WarAvatar
end

function CheckSafeAction:OnStart()

    if self.avatar.target and self.avatar.target:CheckDead() ~= true then
        self.cAction:SetUpdateStatus(TaskStatus.Failure)
        return
    end

    ---从Avatar列表里找出一个非我方的对象 设为敌方目标
    local mySide = self.avatar.data.side
    local target
    local distance
    for id, avatar in pairs(WarData.AvatarHash) do
        local data = avatar.data
        ---找到一个没死的离我最近的敌方
        if mySide ~= data.side and avatar:CheckDead() ~= true then
            local newDistance = WarData.GetAvatarDistance(self.avatar, avatar)
            if not distance or newDistance < distance then
                target = avatar
                distance = newDistance
            end
        end
    end
    --print("CheckSafeAction:OnStart", target)
    if target then
        self.avatar:SetTarget(target)
        self.cAction:SetUpdateStatus(TaskStatus.Failure)
    else
        self.cAction:SetUpdateStatus(TaskStatus.Success)
    end
end

function CheckSafeAction:OnPause(paused)
    --print("CheckSafeAction:OnPause", paused)
    self.paused = paused
end

return CheckSafeAction