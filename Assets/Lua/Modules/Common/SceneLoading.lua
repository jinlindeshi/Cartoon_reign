---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2020-05-06 11:45
--- 场景加载进度界面
---@class SceneLoading
local LuaObj = require("Prayer.Core.LuaObj")
local SceneLoading = class("SceneLoading", LuaObj)

function SceneLoading:Ctor()
    --print("SceneLoading:Ctor")
    SceneLoading.super.Ctor(self, "Prefabs/Core/SceneLoading.prefab", nil, Game.ALERT_LAYER)

    self.bar = self.transform:Find("bg/bar").gameObject:GetComponent("Image") ---@type UnityEngine.UI.Image

    self.infoT = self.transform:Find("bg/text").gameObject:GetComponent("Text") ---@type UnityEngine.UI.Text
end

function SceneLoading:Show(value)
    SceneLoading.super.Show(self)
    self.mainAssetName = value
end

function SceneLoading:SetProgress(value)
    self.bar.fillAmount = value
    local str = tostring(value * 100)
    local endIndex = string.find(str, ".")
    --print("SceneLoading:SetProgress1", str, endIndex)
    if endIndex < 0 or endIndex == nil or value == 1 then
        endIndex = string.len(str)
    end
    str = string.sub(str, 1, endIndex).."%"
    --str = str.."%"
    --print("SceneLoading:SetProgress2", str)
    self.infoT.text = self.mainAssetName .. " " .. str
end

return SceneLoading