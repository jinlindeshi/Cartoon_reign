---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2023/2/8 16:31
--- 角色头顶UI容器

local LuaObj = require("Prayer.Core.LuaObj")
---@class HeadUI:LuaObj
local HeadUI = class("HeadUI",LuaObj)


function HeadUI:Ctor(avatar, offsetV2)
    local gameObj = GameObject.New()
    --local img = AddOrGetComponent(gameObj, UnityEngine.UI.Image) ---@type UnityEngine.UI.Image
    --img.color = Color.New(1,1,1,0.3)
    self.rect = AddOrGetComponent(gameObj, UnityEngine.RectTransform)
    HeadUI.super.Ctor(self, nil, gameObj, UIMgr.GetLayer(UILayerName.scene))
    self.offsetV2 = offsetV2
    self.avatar = avatar ---@type WarAvatar
end

function HeadUI:SkillNameShow(name)
    name = name or "xuanfeng"
    local prefabPath = "Prefabs/War/SkillName.prefab"
    local gObj = CreatePrefab(prefabPath, self.transform)
    --GetComponent.Image(gObj).sprite = --TODO
    gObj.transform.localPosition = Vector3.New(0, 30,0)
    gObj.transform:SetAsLastSibling()
    gObj:SetActive(false)
    gObj:SetActive(true)
    DelayedCall(1.5, function()
        RecyclePrefab(gObj, prefabPath)
    end)
end

function HeadUI:Update()

    if self.destroyed == true or self.gameObject.activeSelf == false then
        return
    end
    --if self.destroyed == true then
    --    return
    --end
    local cam = Camera.main
    local screenP = cam:WorldToScreenPoint(self.avatar.transform.position)

    local hehe, p = RectTransformUtility.ScreenPointToLocalPointInRectangle(self.rect.parent, screenP, nil, Vector2.zero)

    self.rect.anchoredPosition = p + self.offsetV2
end

function HeadUI:Show()
    HeadUI.super.Show(self)
    self:Update()
end

return HeadUI