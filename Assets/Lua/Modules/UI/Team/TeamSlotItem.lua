---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/23 15:02
---
local AvatarData = require("Modules.WarScene.Model.AvatarData")
---@class UI.Team.TeamSlotItem:LuaObj
---@field New fun():UI.Team.TeamSlotItem
local TeamSlotItem = class("UI.Team.CardControl", LuaObj)
function TeamSlotItem:Ctor(go, index)
    TeamSlotItem.super.Ctor(self, nil, go)
    self.icon = GetComponent.Image(self.transform:Find("icon").gameObject)
    self.nameBg = GetComponent.Image(self.transform:Find("nameBg").gameObject)
    self.nameText = GetComponent.Text(self.transform:Find("nameBg/name").gameObject)
    self.add = self.transform:Find("add").gameObject
    self.click = self.transform:Find("click").gameObject
    self.lock = self.transform:Find("lock").gameObject
    AddButtonHandler(self.click, PointerHandler.CLICK, self.OnClick, self)

    self.index = index
    local slotInfo = AvatarData.HeroSlotMap[self.index]
    if slotInfo.lock then
        self:SetLock()
    else
        self:SetHero(slotInfo.id)
    end
end

function TeamSlotItem:SetHero(id)
    if id == nil then
        self.lock:SetActive(false)
        self.add:SetActive(true)
        self.nameBg.gameObject:SetActive(false)
        self.icon.gameObject:SetActive(false)
    else
        if self.id ~= id then
            self.lock:SetActive(false)
            self.add:SetActive(false)
            self.nameBg.gameObject:SetActive(true)
            self.icon.gameObject:SetActive(true)
            local data = AvatarData.GetHeroSData(id)
            self.nameText.text = data.name
            self.nameBg.color = DemoCfg.cardColorCfg[data.quality]
        end
    end
    self.id = id
end

function TeamSlotItem:SetLock()
    self.lock:SetActive(true)
    self.add:SetActive(false)
    self.nameBg:SetActive(false)
    self.icon.gameObject:SetActive(false)
end

function TeamSlotItem:OnClick()
    if self.id == DemoCfg.mainAvatarID then
        return
    end
end

function TeamSlotItem:OnDestroy()
    RemoveButtonHandler(self.click, PointerHandler.CLICK, self.OnClick, self)
end

return TeamSlotItem