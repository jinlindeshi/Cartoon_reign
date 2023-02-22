---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 16:27
--- 主界面

---@class UI.MainMenuPanel:UI.BasePanel
---@field New fun():UI.MainMenuPanel
local MainMenuPanel = class("UI.MainMenuPanel", BasePanel)
local WarData = require("Modules.WarScene.Model.WarData")

function MainMenuPanel:Init()
    MainMenuPanel.super.Init(self)
    self.ItemIconObj = self.transform:Find("ItemIcon").gameObject
    self.infoButton = self.transform:Find("bottomRoot/infoButton").gameObject
    self.bossBtn = self.transform:Find("bottomRoot/bossBtn").gameObject
    self.rewardButton = self.transform:Find("bottomRoot/rewardButton").gameObject
    self.notice = self.transform:Find("Notice").gameObject
    self.noticeText = GetComponent.Text(self.transform:Find("Notice/Text").gameObject)
    self.noticePos = GetComponent.RectTransform(self.notice).anchoredPosition
    self.res_gold = self.transform:Find("Res_gold")
    self.goldText = GetComponent.Text(self.transform:Find("Res_gold/Text").gameObject)
    self.killCount = GetComponent.Text(self.transform:Find("KillCount/count").gameObject)
    self.drawButton = self.transform:Find("bottomRoot/drawButton").gameObject

    self.ItemIconObj:SetActive(false)

    self.btnLight =
    {
        ["info"] = self.transform:Find("bottomRoot/infoLight").gameObject,
        ["reward"] = self.transform:Find("bottomRoot/rewardLight").gameObject,
    }
    self:ActiveBtnLight("info", false)
    self:ActiveBtnLight("reward", true)

    --self:ShowNotice("挂机奖励可以领取了！")
    self:RefreshKillCount()
    self.goldText.text = DemoCfg.goldNum
    AddButtonHandler(self.infoButton, PointerHandler.CLICK, self.OnInfoButtonClick, self)
    AddButtonHandler(self.rewardButton, PointerHandler.CLICK, self.OnRewardButtonClick, self)
    AddButtonHandler(self.drawButton, PointerHandler.CLICK, self.OnDrawButtonClick, self)
    AddButtonHandler(self.bossBtn, PointerHandler.CLICK, self.OnBossBtnClick, self)
    EventMgr.AddEventListener("MonsterDead", self.OnMonsterDead, self)


    ---TEST
    DelayedCall(3, function()
        self.bossBtn:SetActive(true)
        local cg = GetComponent.CanvasGroup(self.bossBtn)
        cg.blocksRaycasts = false
        self.bossBtn.transform:DOPunchScale(Vector3.one*0.3, 0.5, 0, 0):SetLoops(2, DOTWEEN_LOOP_TYPE.Restart):OnComplete(function()

            cg.blocksRaycasts = true
        end)
    end)
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
    --require("Modules.WarScene.Model.WarData").StopAllAvatarAI()
end

function MainMenuPanel:OnRewardButtonClick()
    UIMgr.OpenPanel(UIPanelCfg.rewardAlert, DemoCfg.rewardData)
    --require("Modules.WarScene.Model.WarData").StartAllAvatarAI()
end

function MainMenuPanel:OnDrawButtonClick()
    UIMgr.OpenPanel(UIPanelCfg.drawCard)
end

function MainMenuPanel:OnBossBtnClick()
    local cg = GetComponent.CanvasGroup(self.bossBtn)
    cg.blocksRaycasts = false
    cg:DOFade(0, 0.5):SetDelay(0.5):OnComplete(function()
        self.bossBtn:SetActive(false)
        cg.blocksRaycasts = true
        cg.alpha = 1
    end)

    WarData.scene:ChallengeBoss()
end

function MainMenuPanel:RefreshKillCount()
    self.killCount.text = DemoCfg.killCount
end
---怪物死亡事件
function MainMenuPanel:OnMonsterDead(event)
    local pos = event.data.pos
    local addNum = math.random(1,3)
    self:IconScenePosToUIPos(pos,addNum)
    DemoCfg.killCount = DemoCfg.killCount + 1
    self:RefreshKillCount()
end

---图标动效
local startTime = 0.2
local flyTime = 0.5
local gapTime = 0.15
function MainMenuPanel:IconScenePosToUIPos(pos, num, picUrl)
    local orgPos = Happy.WorldPointToRectTransform(pos, self.transform.parent)
    local targetPos = Vector2.New(self.res_gold.localPosition.x - 50, self.res_gold.localPosition.y)
    local seq = DOTween.Sequence()
    for i = 1, num do
        local item = CreatePrefab(self.ItemIconObj, self.ItemIconObj.transform.parent)
        local rect = GetComponent.RectTransform(item)
        if num == 1 then
            rect.anchoredPosition = orgPos
        else
            rect.anchoredPosition = Vector2.New(orgPos.x+math.random(-30,30),
                    orgPos.y+math.random(-20,-20))
        end
        item.transform.localScale = Vector2.one
        local icon = item.transform:Find("Icon").gameObject
        local iconBg = item.transform:Find("Bg").gameObject
        if picUrl then
            GetComponent.Image(icon).sprite = resMgr:LoadSpriteAtPath(picUrl)
        end
        icon.transform.localScale = Vector2.zero
        iconBg.transform.localScale = Vector2.zero
        item:SetActive(true)
        seq:AppendCallback(function()
            local itemSeq = DOTween.Sequence()
            itemSeq:Append(icon.transform:DOScale(1.2, startTime))
            itemSeq:Append(iconBg.transform:DOScale(1.2, startTime))
            itemSeq:Append(item.transform:DOLocalMove(targetPos, flyTime):SetEase(DOTWEEN_EASE.InCubic))
            itemSeq:Join(iconBg.transform:DOScale(0, flyTime/2))
            itemSeq:Join(icon.transform:DOScale(0.5, flyTime))
            itemSeq:AppendCallback(function()
                RecyclePrefab(item, self.ItemIconObj.name)
                local resSeq = DOTween.Sequence()
                resSeq:Append(self.res_gold.transform:DOScale(1.25, 0.15))
                resSeq:Append(self.res_gold.transform:DOScale(1, 0.1))
                resSeq:AppendCallback(function()
                    DemoCfg.goldNum = DemoCfg.goldNum + 1
                    self.goldText.text = DemoCfg.goldNum
                end)
            end)
        end)
        seq:AppendInterval(gapTime)
    end
end

function MainMenuPanel:RemoveListeners()
    MainMenuPanel.super.RemoveListeners(self)
    RemoveButtonHandler(self.infoButton, PointerHandler.CLICK, self.OnInfoButtonClick, self)
    RemoveButtonHandler(self.bossBtn, PointerHandler.CLICK, self.OnBossBtnClick, self)
    RemoveButtonHandler(self.rewardButton, PointerHandler.CLICK, self.OnRewardButtonClick, self)
    EventMgr.RemoveEventListener("MonsterDead", self.OnMonsterDead, self)
end

return MainMenuPanel
