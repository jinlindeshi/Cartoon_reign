---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 16:27
--- 主界面

---@class UI.MainMenuPanel:UI.BasePanel
---@field New fun():UI.MainMenuPanel
local MainMenuPanel = class("UI.MainMenuPanel", BasePanel)

function MainMenuPanel:Init()
    MainMenuPanel.super.OnInit(self)
    self.ItemIconObj = self.transform:Find("ItemIcon").gameObject
    self.infoButton = self.transform:Find("bottomRoot/infoButton").gameObject
    self.rewardButton = self.transform:Find("bottomRoot/rewardButton").gameObject
    self.notice = self.transform:Find("Notice").gameObject
    self.noticeText = GetComponent.Text(self.transform:Find("Notice/Text").gameObject)
    self.noticePos = GetComponent.RectTransform(self.notice).anchoredPosition
    self.ItemIconObj:SetActive(false)

    self.btnLight =
    {
        ["info"] = self.transform:Find("bottomRoot/infoLight").gameObject,
        ["reward"] = self.transform:Find("bottomRoot/rewardLight").gameObject,
    }
    self:ActiveBtnLight("info", false)
    self:ActiveBtnLight("reward", true)

    self:ShowNotice("挂机奖励可以领取了！")

    AddButtonHandler(self.infoButton, PointerHandler.CLICK, self.OnInfoButtonClick, self)
    AddButtonHandler(self.rewardButton, PointerHandler.CLICK, self.OnRewardButtonClick, self)
end

function MainMenuPanel:ActiveBtnLight(type, flag)
    if self.btnLight[type] then
        self.btnLight[type]:SetActive(flag)
    end
end

function MainMenuPanel:ShowNotice(notice, time)
    local xPos = self.noticePos.x + 380
    self.noticeText.text = notice
    local sequence = DOTween.Sequence()
    sequence:AppendInterval(2)
    sequence:Append(GetComponent.RectTransform(self.notice):DOAnchorPosX(xPos, 0.5))
    sequence:AppendInterval(time or 2)
    sequence:Append(GetComponent.RectTransform(self.notice):DOAnchorPosX(self.noticePos.x, 0.25))
end

function MainMenuPanel:OnInfoButtonClick()
    UIMgr.OpenPanel(UIPanelCfg.growUp)
end

function MainMenuPanel:OnRewardButtonClick()
    UIMgr.OpenPanel(UIPanelCfg.rewardAlert, DemoCfg.rewardData)
end

function MainMenuPanel:RemoveListeners()
    MainMenuPanel.super.RemoveListeners(self)
    RemoveButtonHandler(self.infoButton, PointerHandler.CLICK, self.OnInfoButtonClick, self)
    RemoveButtonHandler(self.rewardButton, PointerHandler.CLICK, self.OnRewardButtonClick, self)
end

return MainMenuPanel
