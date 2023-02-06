---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/6 17:57
--- 成长界面属性条
---@class UI.GrowUp.GrowUpAttrItem:LuaObj
---@field New fun():LuaObj
local GrowUpAttrItem = class("UI.GrowUp.GrowUpAttrItem", LuaObj)
function GrowUpAttrItem:Ctor(gameObject, data)
    GrowUpAttrItem.super.Ctor(self, nil, gameObject)
    self.data = data
    self.attrPic = self.transform:Find("AttrPic").gameObject
    self.attrTextObj = self.transform:Find("Now").gameObject
    self.attrText = GetComponent.Text(self.attrTextObj)
end

---属性值增加表现
function GrowUpAttrItem:AddRefresh(data)
    local floatTween = Happy.DOTweenFloat(self.data.value, data.value, 0.6, function(value)
        self.attrText.text = value
    end, function()
        self.attrText.text = data.value
        self.data.value = data.value
    end)
    local sequence = DOTween.Sequence()
end

return GrowUpAttrItem