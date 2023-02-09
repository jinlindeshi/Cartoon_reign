---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/12/7 11:44
--- 血条

local LuaObj = require("Prayer.Core.LuaObj")
---@class HpBar:LuaObj
local HpBar = class("HpBar", LuaObj)

function HpBar:Ctor(data, parent)
    HpBar.super.Ctor(self, "Prefabs/War/HpBar.prefab", nil, parent)
    self.transform.localPosition = Vector3.zero
    self.rect = GetComponent.RectTransform(self.gameObject)

    self.img = GetComponent.Image(self.transform:Find("progress").gameObject)
    GetComponent.Text(self.transform:Find("idText").gameObject).text = data.id
    self:ChangeHp(data.hp, data.maxHp)
end

function HpBar:ChangeHp(hp, maxHp, tween)
    if self.gameObject.activeSelf == false then
        self:Show()
    end
    local goal = hp/maxHp
    --print("HpBar:ChangeHp", hp, maxHp)
    if tween == true then
        local changeValue = math.abs(self.img.fillAmount - goal)
        self.img:DOFillAmount(goal, changeValue * 0.7)
    else
        self.img.fillAmount = goal
    end

    if self.autoHide then
        StopDelayedCall(self.autoHide)
    end
    self.autoHide = DelayedCall(3, function()
        self:Hide()
    end)
end

function HpBar:Show()
    HpBar.super.Show(self)
    self.transform:SetAsFirstSibling()
end

return HpBar