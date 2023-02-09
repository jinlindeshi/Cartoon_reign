---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/6 17:57
--- 成长界面装备格
local SData = require("Modules.WarScene.Model.SData")
---@class UI.GrowUp.GrowUpEquipItem:LuaObj
---@field New fun():LuaObj
local GrowUpEquipItem = class("UI.GrowUp.GrowUpEquipItem", LuaObj)
function GrowUpEquipItem:Ctor(gameObject, data)
    GrowUpEquipItem.super.Ctor(self, nil, gameObject)
    self.data = data
    self.equipId = data.equipId

    self.qualityBg = self.transform:Find("qualityBg").gameObject
    self.icon = self.transform:Find("Equip").gameObject
    self.iconImg = GetComponent.Image(self.icon)
    self.qualityBgImg = GetComponent.Image(self.qualityBg)

    self:Refresh()
end

function GrowUpEquipItem:Refresh()
    if self.data.equipId == 0 then
        self.icon:SetActive(false)
        self.qualityBg:SetActive(false)
    else
        self.sData = SData.GetEquipSData(self.data.equipId)
        self.icon:SetActive(true)
        self.qualityBg:SetActive(true)
        self.iconImg.sprite = resMgr:LoadSpriteAtPath(string.format("%s%s.png", DemoCfg.equipIconPath, self.sData.icon))
        self.qualityBgImg.sprite = resMgr:LoadSpriteAtPath(DemoCfg.qualityBgMap[self.sData.quality])
    end
end

function GrowUpEquipItem:SetEquip(data, isFx)
    if self.equipId ~= data.equipId then
        self:Refresh()
        self.equipId = data.equipId
        local sequence = DOTween.Sequence()
        if isFx then
            sequence:AppendCallback(function()
                local fx = CreatePrefab("Effect/Prefabs/fx_pur_light_show.prefab", self.transform)
                fx:Destroy(1)
            end)
        end
        sequence:Append(self.icon.transform:DOScale(1.5, 0.25):SetEase(Happy.DOTWEEN_EASE.OutCubic))
        sequence:Append(self.icon.transform:DOScale(1, 0.15):SetEase(Happy.DOTWEEN_EASE.InCubic))

    end
end

return GrowUpEquipItem