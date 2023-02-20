---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/17 16:14
--- 抽奖选择按钮
---@class UI.DrawCard.PoolSelectBtn:LuaObj
---@field New fun():UI.DrawCard.PoolSelectBtn
local PoolSelectBtn = class("UI.DrawCard.PoolSelectBtn", LuaObj)
function PoolSelectBtn:Ctor(parent, poolId)
    PoolSelectBtn.super.Ctor(self, "Prefabs/Panel/DrawCard/PoolSelectBtn.prefab", nil, parent)
    self.btn = self.transform:Find("btn").gameObject
    self.text = GetComponent.Text(self.transform:Find("Text").gameObject)
    self.select = self.transform:Find("select").gameObject
    AddButtonHandler(self.btn, PointerHandler.CLICK, self.OnBtnClick, self)

    self.poolId = poolId
    self.sData = SData.pools.GetData(self.poolId)
    self.text.text = self.sData.poolName
    self.select:SetActive(false)
    EventMgr.AddEventListener("DrawCardPoolSelect", self.OnDrawCardPoolSelect, self)
end

function PoolSelectBtn:OnDrawCardPoolSelect(event)
    self.select:SetActive(event.data.id == self.poolId)
end

function PoolSelectBtn:OnBtnClick()
    EventMgr.DispatchEvent("DrawCardPoolSelect", {id = self.poolId})
end

function PoolSelectBtn:OnDestroy()
    RemoveButtonHandler(self.btn, PointerHandler.CLICK, self.OnBtnClick, self)
    EventMgr.RemoveEventListener("DrawCardPoolSelect", self.OnDrawCardPoolSelect, self)
end

return PoolSelectBtn