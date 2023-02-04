---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 16:27
--- 主界面

---@class UI.MainMenuPanel:UI.BasePanel
---@field New fun():UI.MainMenuPanel
local MainMenuPanel = class("UI.MainMenuPanel", BasePanel)
function MainMenuPanel:Ctor()
    MainMenuPanel.super.Ctor(self, UIPanelCfg.mainMenu)
end

function MainMenuPanel:OnInitialize()
    MainMenuPanel.super.OnInitialize(self)
    self.ItemIconObj = self.transform:Find("ItemIcon").gameObject
    self.infoButton = self.transform:Find("bottomRoot/infoButton").gameObject

    self.ItemIconObj:SetActive(false)
    AddButtonHandler(self.infoButton, PointerHandler.CLICK, self.OnInfoButtonClick)
end

function MainMenuPanel:RemoveListeners()
    RemoveButtonHandler(self.infoButton, PointerHandler.CLICK, self.OnInfoButtonClick)
end

function MainMenuPanel:OnInfoButtonClick()
    UIMgr.OpenPanel(UIPanelCfg.growUp)
end

return MainMenuPanel
