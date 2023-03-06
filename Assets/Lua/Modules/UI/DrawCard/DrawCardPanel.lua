---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/17 15:44
---  抽卡界面
local PoolSelectBtn = require("Modules.UI.DrawCard.PoolSelectBtn")
local PoolControl = require("Modules.UI.DrawCard.PoolControl")
local CardControl = require("Modules.UI.DrawCard.CardControl")
local DrawCardModel = require("Modules.UI.DrawCard.Model.DrawCardModel")
local OpenCardShow = require("Modules.UI.DrawCard.OpenCardShow")
local RollCards = require("Modules.UI.DrawCard.RollCards")
---@class UI.DrawCard.DrawCardPanel:UI.BasePanel
---@field New fun():UI.DrawCard.DrawCardPanel
local DrawCardPanel = class("UI.DrawCard.DrawCardPanel", BasePanel)

function DrawCardPanel:Init()
    DrawCardPanel.super.Init(self)
    self.PoolRoot = self.transform:Find("PoolRoot")
    self.SelectPoolRoot = self.transform:Find("SelectPoolRoot")
    self.SelectRoot = self.transform:Find("SelectPoolRoot/Scroll View/Viewport/Content")
    self.ResultRoot = self.transform:Find("ResultRoot").gameObject
    self.light = self.transform:Find("ResultRoot/light").gameObject
    self.OnceRoot = self.transform:Find("ResultRoot/OnceRoot").gameObject
    self.cardPos = self.transform:Find("ResultRoot/OnceRoot/cardPos")
    self.TenRoot = self.transform:Find("ResultRoot/TenRoot").gameObject
    self.PosRoot = self.transform:Find("ResultRoot/TenRoot/PosRoot")
    self.ButtonRoot = self.transform:Find("ResultRoot/ButtonRoot").gameObject
    self.AutoButton = self.transform:Find("ResultRoot/ButtonRoot/AutoButton").gameObject
    self.YesButton = self.transform:Find("ResultRoot/ButtonRoot/YesButton").gameObject
    self.AgainButton = self.transform:Find("ResultRoot/ButtonRoot/AgainButton").gameObject
    self.click = self.transform:Find("ResultRoot/Click").gameObject
    self.List1 = self.TenRoot.transform:Find("PosRoot/List1").gameObject
    self.List2 = self.TenRoot.transform:Find("PosRoot/List2").gameObject
    self.List3 = self.TenRoot.transform:Find("PosRoot/List3").gameObject
    self.cardPosList = {} --卡牌坐标位置list
    for i = 1, self.List1.transform.childCount do
        table.insert(self.cardPosList, self.List1.transform:GetChild(i-1))
    end
    for i = 1, self.List2.transform.childCount do
        table.insert(self.cardPosList, self.List2.transform:GetChild(i-1))
    end
    for i = 1, self.List3.transform.childCount do
        table.insert(self.cardPosList, self.List3.transform:GetChild(i-1))
    end

    AddButtonHandler(self.YesButton, PointerHandler.CLICK, self.OnYesButton, self)
    AddButtonHandler(self.AgainButton, PointerHandler.CLICK, self.OnAgainButton, self)
    AddButtonHandler(self.click, PointerHandler.CLICK, self.OnShowClick, self)

    self.AutoButton:SetActive(false)
    self.ResultRoot:SetActive(false)
    self.poolIdList = SData.GetOpenPools()
    self.poolMap = {}
    self:InitSelectPool()
    self.cardList = {}
    EventMgr.AddEventListener(DrawCardModel.eventDefine.selectPool, self.OnDrawCardPoolSelect, self)
    EventMgr.AddEventListener(DrawCardModel.eventDefine.oneDraw, self.OnDrawCard, self)
    EventMgr.AddEventListener(DrawCardModel.eventDefine.tenDraw, self.OnDrawCard, self)
    EventMgr.AddEventListener(DrawCardModel.eventDefine.showResult, self.OnShowResult, self)
    EventMgr.AddEventListener(DrawCardModel.eventDefine.activeClick, self.OnActiveClick, self)

    EventMgr.DispatchEvent(DrawCardModel.eventDefine.selectPool, {id = self.poolIdList[1]})
    RollCards.New(self.transform)
end

---卡池选择scrollView配置
local selectPosCfg =
{
    startGap = 10,
    startY = 0,
    gapX = 10
}

function DrawCardPanel:InitSelectPool()
    self.btnList = {}
    local count = #self.poolIdList
    local contentWidth = 0
    for i = 1, count do
        local id = self.poolIdList[i]
        local btn = PoolSelectBtn.New(self.SelectRoot, id)
        local rect = GetComponent.RectTransform(btn.gameObject)
        local btnWidth = rect.rect.width
        local pos = Vector2.New(btnWidth/2 + selectPosCfg.startGap + (i - 1) * (btnWidth + selectPosCfg.gapX), selectPosCfg.startY )
        contentWidth = contentWidth + btnWidth
        rect.anchoredPosition = pos
        table.insert(self.btnList, btn)
    end
    contentWidth = contentWidth + selectPosCfg.startGap * 2 + selectPosCfg.gapX * (count - 1)
    GetComponent.RectTransform(self.SelectRoot.gameObject).sizeDelta = Vector2.New(contentWidth, 0)
end

function DrawCardPanel:SelectPool(poolId)
    if self.selectPoolId == poolId then
        return
    end
    self.selectPoolId = poolId
    if self.poolMap[poolId] == nil then
        self.poolMap[poolId] = PoolControl.New(self.PoolRoot, poolId)
    end
    for id, view in pairs(self.poolMap) do
        if id == poolId then
            view:Show()
        else
            view:Hide()
        end
    end
end

function DrawCardPanel:OnDrawCardPoolSelect(event)
    self:SelectPool(event.data.id)
end

---开始抽卡
function DrawCardPanel:StartDraw(callback)
    local cg1 = GetComponent.CanvasGroup(self.SelectPoolRoot.gameObject)
    local cg2 = GetComponent.CanvasGroup(self.PoolRoot.gameObject)
    local resultCg = GetComponent.CanvasGroup(self.ResultRoot)
    local lightCg = GetComponent.CanvasGroup(self.light)
    local btnCg = GetComponent.CanvasGroup(self.ButtonRoot)
    resultCg.alpha = 0
    lightCg.alpha = 0
    btnCg.alpha = 0

    self.ResultRoot:SetActive(true)
    --self.AutoButton:SetActive(true)
    self.YesButton:SetActive(false)
    self.AgainButton:SetActive(false)
    self.click:SetActive(false)

    local seq = DOTween.Sequence()
    seq:Append(cg1:DOFade(0, 0.25))
    seq:Join(cg2:DOFade(0, 0.25))
    seq:Join(resultCg:DOFade(1, 0.25))
    seq:Join(lightCg:DOFade(1, 0.15))
    seq:AppendInterval(1)
    seq:Append(lightCg:DOFade(0, 0.15))
    seq:AppendCallback(function()
        self.click:SetActive(true)
        callback()
    end)
    seq:Append(btnCg:DOFade(1, 0.2))
end

---抽卡完成
function DrawCardPanel:DrawComplete()
    --self.AutoButton:SetActive(false)
    self.click:SetActive(false)
    self.YesButton:SetActive(true)
    self.AgainButton:SetActive(true)
end


---抽卡结束
function DrawCardPanel:DrawEnd()
    local cg1 = GetComponent.CanvasGroup(self.SelectPoolRoot.gameObject)
    local cg2 = GetComponent.CanvasGroup(self.PoolRoot.gameObject)
    local resultCg = GetComponent.CanvasGroup(self.ResultRoot)

    local seq = DOTween.Sequence()
    seq:Append(cg1:DOFade(1, 0.25))
    seq:Join(cg2:DOFade(1, 0.25))
    seq:Join(resultCg:DOFade(0, 0.25))
    seq:AppendCallback(function()
        self.ResultRoot:SetActive(false)
        self:CleanCard()
    end)
end

---抽一次
function DrawCardPanel:DrawOnce()
    self.OnceRoot:SetActive(true)
    self.TenRoot:SetActive(false)

    local data = DrawCardModel.GetOneDrawData()
    self.resultData = data
    self.show = OpenCardShow.New(self.OnceRoot, data) ---@type UI.DrawCard.OpenCardShow
end

---抽十次
function DrawCardPanel:DrawTenTimes()
    self.OnceRoot:SetActive(false)
    self.TenRoot:SetActive(true)
    local data = DrawCardModel.GetTenDrawData()
    self.resultData = data
    self.show = OpenCardShow.New(self.TenRoot, data) ---@type UI.DrawCard.OpenCardShow
end

---抽卡事件
function DrawCardPanel:OnDrawCard(event)
    self.drawType = event.type
    self:StartDraw(function()
        if self.drawType == DrawCardModel.eventDefine.oneDraw then
            self:DrawOnce()
        else
            self:DrawTenTimes()
        end
    end)
end

---展示抽卡结果
function DrawCardPanel:OnShowResult()
    local btnCg = GetComponent.CanvasGroup(self.ButtonRoot)
    btnCg.alpha = 0
    local sequence = DOTween.Sequence()
    if self.drawType == DrawCardModel.eventDefine.oneDraw then
        local card = CardControl.New(self.cardPos, self.resultData[1])
        table.insert(self.cardList, card)
        sequence:AppendCallback(function()
            for i = 1, #self.cardList do
                self.cardList[i]:Open()
            end
        end)
        sequence:AppendInterval(0.5)
        sequence:AppendCallback(function()
            self:DrawComplete()
        end)
        sequence:Append(btnCg:DOFade(1, 0.2))
    else
        self.List1.transform.localPosition = Vector2.New(-210, 200)
        self.List2.transform.localPosition = Vector2.New(0, -300)
        self.List3.transform.localPosition = Vector2.New(210, 200)
        for i = 1, #self.cardPosList do
            local card = CardControl.New(self.cardPosList[i], self.resultData[i])
            table.insert(self.cardList, card)
        end
        --local cg = GetComponent.CanvasGroup(self.TenRoot.transform:Find("PosRoot").gameObject)
        --cg.alpha = 0
        sequence:Append(self.List1.transform:DOLocalMoveY(-100, 1.5):SetEase(DOTWEEN_EASE.OutSine))
        sequence:Join(self.List2.transform:DOLocalMoveY(0, 1.5):SetEase(DOTWEEN_EASE.OutSine))
        sequence:Join(self.List3.transform:DOLocalMoveY(-100, 1.5):SetEase(DOTWEEN_EASE.OutSine))
        --sequence:Join(cg:DOFade(1, 0.15))
        sequence:InsertCallback(1,function()
            for i = 1, #self.cardList do
                self.cardList[i]:Open()
            end
        end)
        sequence:AppendInterval(0.2)
        sequence:AppendCallback(function()
            self:DrawComplete()
        end)
        sequence:Append(btnCg:DOFade(1, 0.2))
    end
end

---控制是否可以点击
function DrawCardPanel:OnActiveClick(event)
    self.click:SetActive(event.data.active)
end

---清理结果
function DrawCardPanel:CleanCard()
    for i = 1, #self.cardList do
        self.cardList[i]:Destroy()
        self.cardList[i] = nil
    end
end

---确定
function DrawCardPanel:OnYesButton()
    self:DrawEnd()
end

---再来一次
function DrawCardPanel:OnAgainButton()
    self:CleanCard()
    self:StartDraw(function()
        if self.drawType == DrawCardModel.eventDefine.oneDraw then
            self:DrawOnce()
        else
            self:DrawTenTimes()
        end
    end)
end

---展示下个结果
function DrawCardPanel:OnShowClick()
    self.show:Next()
end

function DrawCardPanel:RemoveListeners()
    DrawCardPanel.super.RemoveListeners(self)
    EventMgr.RemoveEventListener(DrawCardModel.eventDefine.selectPool, self.OnDrawCardPoolSelect, self)
    EventMgr.RemoveEventListener(DrawCardModel.eventDefine.oneDraw, self.OnDrawCard, self)
    EventMgr.RemoveEventListener(DrawCardModel.eventDefine.tenDraw, self.OnDrawCard, self)
    EventMgr.RemoveEventListener(DrawCardModel.eventDefine.showResult, self.OnShowResult, self)
    EventMgr.RemoveEventListener(DrawCardModel.eventDefine.activeClick, self.OnActiveClick, self)

    RemoveButtonHandler(self.YesButton, PointerHandler.CLICK, self.OnYesButton, self)
    RemoveButtonHandler(self.AgainButton, PointerHandler.CLICK, self.OnAgainButton, self)
    RemoveButtonHandler(self.click, PointerHandler.CLICK, self.OnShowClick, self)
end

return DrawCardPanel