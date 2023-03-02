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
    self.heroIcon = GetComponent.Image(self.Root:Find("cardFront/heroMask/heroIcon").gameObject)
    self.nameBG = GetComponent.Image(self.Root:Find("cardFront/nameBg").gameObject)
    self.nameText = GetComponent.Text(self.Root:Find("cardFront/nameBg/Text").gameObject)
    self.fx_star_show = self.transform:Find("fx_star_show").gameObject
    self.fx_star_light_cg = GetComponent.CanvasGroup(self.transform:Find("fx_star_light").gameObject)

    self.cardBg:SetActive(true)
    self.cardFront:SetActive(false)
    self.fx_star_show:SetActive(false)
    self.Root.transform.localEulerAngles = Vector2.New(0, -180)
    self.fx_star_light_cg.alpha = 0
    self.isOpen = false ---是否已经翻开

    self.Root.localScale = Vector2.one * 0.9
    self.id = id
    self.data = poolItem.GetData(id)
    self:SetCard()
end

function CardControl:SetCard()
    if self.data.type == DemoCfg.cardType.equip then
        self.itemIcon.gameObject:SetActive(true)
        self.heroIcon.gameObject:SetActive(false)
        local info = require("Data.Excel.equip").GetData(self.data.toID)
        self.nameText.text = info.name
        self.itemIcon.sprite = resMgr:LoadSpriteAtPath(string.format("%s%s.png", DemoCfg.equipIconPath, info.icon))
    elseif self.data.type == DemoCfg.cardType.hero then
        self.itemIcon.gameObject:SetActive(false)
        self.heroIcon.gameObject:SetActive(true)
        local info = require("Data.Excel.avatar").GetData(self.data.toID)
        self.nameText.text = info.name
    end
    if self.data.quality ~= DemoCfg.cardQuality.white then
        GetComponent.Image(self.cardBg).color = DemoCfg.cardColorCfg[self.data.quality]
        GetComponent.Image(self.cardFront).color = DemoCfg.cardColorCfg[self.data.quality]
        self.nameText.color = DemoCfg.cardColorCfg[self.data.quality]
    else
        GetComponent.Image(self.cardBg).color = Color.white
        GetComponent.Image(self.cardFront).color = Color.white
        self.nameText.color = Color.white
    end
end

function CardControl:Open(callback)
    if self.isOpen then
        return
    end
    RemoveButtonHandler(self.click, PointerHandler.CLICK, self.OnClick, self)
    self.isOpen = true
    local seq = DOTween.Sequence()
    seq:Append(self.Root:DOLocalRotate(Vector2.New(0,90),0.25, DG.Tweening.RotateMode.WorldAxisAdd))
    seq:AppendCallback(function()
        self.cardBg:SetActive(false)
        self.cardFront:SetActive(true)
    end)
    seq:Append(self.Root:DOLocalRotate(Vector2.New(0,90),0.25, DG.Tweening.RotateMode.WorldAxisAdd))
    if self.data.type == DemoCfg.cardType.hero then
        seq:Append(self.Root:DOScale(1.1, 0.25))
    end
    seq:AppendCallback(function()
        if self.data.quality == DemoCfg.cardQuality.orange then
            self.fx_star_show:SetActive(true)
        end
        if callback then
            callback()
        end
    end)
    if self.data.quality == DemoCfg.cardQuality.orange then
        seq:Append(self.fx_star_light_cg:DOFade(1,0.15))
    end

end

return CardControl