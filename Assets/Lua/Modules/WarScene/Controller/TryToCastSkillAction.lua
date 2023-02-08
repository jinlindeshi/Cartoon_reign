---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/12/2 15:31
--- 尝试施放技能

local BaseAction = require("Prayer.Core.BaseAction")
---@class TryToCastSkillAction:BaseAction
local TryToCastSkillAction = class("TryToCastSkillAction", BaseAction)

function TryToCastSkillAction:Ctor(avatar, bToLua, cAction, paramFloat, paramBool)
    TryToCastSkillAction.super.Ctor(self, bToLua, cAction, paramFloat, paramBool)
    self.avatar = avatar ---@type WarAvatar
    self.skillCD = paramFloat ---技能CD
end

function TryToCastSkillAction:OnStart()
    if not self.avatar.skill then
        print("技能没配~")
        self.cAction:SetUpdateStatus(TaskStatus.Failure)
    end
    if self.avatar.skillMarkTime and os.clock() - self.avatar.skillMarkTime < self.skillCD then
        --print("技能CD中")
        self.cAction:SetUpdateStatus(TaskStatus.Failure)
        return
    end
    self.cAction:SetUpdateStatus(TaskStatus.Running)
    self.avatar.skill:Begin(self.avatar, function()
        self.cAction:SetUpdateStatus(TaskStatus.Success)
    end)

end

function TryToCastSkillAction:OnPause(paused)
    --print("TryToCastSkillAction:OnPause", paused)
    self.paused = paused
    if paused == false then
        self:AttackToDeath()
    end
end

function TryToCastSkillAction:OnBehaviorComplete()
    --print("TryToCastSkillAction:OnBehaviorComplete")
end

function TryToCastSkillAction:OnBehaviorRestart()
    --print("TryToCastSkillAction:OnBehaviorRestart")
end

function TryToCastSkillAction:OnEnd()
    --print("TryToCastSkillAction:OnEnd")
end

return TryToCastSkillAction