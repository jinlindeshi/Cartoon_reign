---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 17:23
--- 角色养成界面

---@class UI.GrowUp.GrowUpPanel:UI.BasePanel
---@field New fun():UI.GrowUp.GrowUpPanel
local GrowUpPanel = class("UI.GrowUp.GrowUpPanel", BasePanel)

function GrowUpPanel:OnInit()
    GrowUpPanel.super.OnInit(self)
    self.nameText = GetComponent.Text(self.transform:Find("AttrRoot/Name").gameObject)
    self.EquipButton = self.transform:Find("heroRoot/EquipButton").gameObject
    self.UpButton = self.transform:Find("AttrRoot/UpButton").gameObject
    self.UpButtonImg = GetComponent.Image(self.UpButton)
    self.grayMat = Happy.GetGrayMaterial()
    self.UpButtonImg.material = self.grayMat
end

function GrowUpPanel:RemoveListeners()
end

return GrowUpPanel