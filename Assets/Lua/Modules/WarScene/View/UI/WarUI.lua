---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/12/6 16:20
--- 战争UI

local WarData = require("Modules.WarScene.Model.WarData")
local WarUI = class("WarUI", LuaObj)

function WarUI:Ctor(funCall1)

    WarUI.super.Ctor(self, "Prefabs/War/WarUI.prefab", nil, UIMgr.GetLayer(UILayerName.top))
    --print("WarUI:Ctor", self.gameObject, self.transform)
    if funCall1 then
        Happy.BtnClickDownUP(self.transform:Find("LocVisibleButton").gameObject, funCall1)
    end
end

return WarUI