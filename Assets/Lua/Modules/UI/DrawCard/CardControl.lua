---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/20 16:03
---
local DrawCardModel = require("Modules.UI.DrawCard.Model.DrawCardModel")
local poolItem = require("Data.Excel.poolItem")
---@class UI.DrawCard.CardControl:LuaObj
---@field New fun():UI.DrawCard.CardControl
local CardControl = class("UI.DrawCard.CardControl", LuaObj)
function CardControl:Ctor(parent, id)
    CardControl.super.Ctor(self, "Prefabs/Panel/DrawCard/CardControl.prefab", nil, parent)
    self.Root = self.transform:Find("Root")
    self.click = self.transform:Find("click").gameObject
    self.cardBg = self.Root:Find("cardBg").gameObject
    self.cardFront = self.Root:Find("cardFront").gameObject
    self.itemIcon = GetComponent.Image(self.Root:Find("cardFront/itemIcon").gameObject)
    self.heroIcon = GetComponent.Image(self.Root:Find("cardFront/heroIcon").gameObject)
    self.nameBG = GetComponent.Image(self.Root:Find("cardFront/nameBg").gameObject)
    self.nameText = GetComponent.Text(self.Root:Find("cardFront/nameBg/Text").gameObject)
    self.cardBg:SetActive(true)
    self.cardFront:SetActive(false)
    self.Root.transform.localEulerAngles = Vector2.New(0, -180)
    self.isOpen = false ---是否已经翻开

    self.id = id
    self.data = poolItem.GetData(id)
    self:SetCard()
    AddButtonHandler(self.click, PointerHandler.CLICK, self.OnClick, self)
end

function CardControl:SetCard()
    if self.data.type == DemoCfg.cardType.equip then
        self.itemIcon.gameObject:SetActive(true)
        self.heroIcon.gameObject:SetActive(false)
        local info = require("Data.Excel.equip").GetData(self.data.toID)
        self.nameText.text = info.name
    elseif self.data.type == DemoCfg.cardType.hero then
        self.itemIcon.gameObject:SetActive(false)
        self.heroIcon.gameObject:SetActive(true)
        local info = require("Data.Excel.avatar").GetData(self.data.toID)
        self.nameText.text = info.name
    end
    if self.data.quality ~= DemoCfg.cardQuality.white then
        self.nameBG.color = DemoCfg.cardColorCfg[self.data.quality]
    end
    GetComponent.Image(self.cardBg).color = DemoCfg.cardColorCfg[self.data.quality]
end

function CardControl:Open(callback)
    if self.isOpen then
        return
    end
    RemoveButtonHandler(self.click, PointerHandler.CLICK, self.OnClick, self)
    self.isOpen = true
    local seq = DOTween.Sequence()
    seq:Append(self.Root:DOLocalRotate(Vector2.New(0,90),0.3, DG.Tweening.RotateMode.WorldAxisAdd))
    seq:AppendCallback(function()
        self.cardBg:SetActive(false)
        self.cardFront:SetActive(true)
    end)
    seq:Append(self.Root:DOLocalRotate(Vector2.New(0,90),0.3, DG.Tweening.RotateMode.WorldAxisAdd))
    seq:AppendCallback(function()
        if callback then
            callback()
        end
    end)
end

function CardControl:OnClick()
    self:Open(function()
        EventMgr.DispatchEvent(DrawCardModel.eventDefine.checkOpen)
    end)
end

function CardControl:OnDestroy()
    RemoveButtonHandler(self.click, PointerHandler.CLICK, self.OnClick, self)
end

return CardControl