---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 10:34
--- panel基类
local LuaObj = require("Prayer.Core.LuaObj")
---@class UI.BasePanel:LuaObj
---@field New fun(cfg:UIPanelCfg, layer:UnityEngine.Transform):LuaObj
---@field cfg UIPanelCfg 页面配置
---@field layer UnityEngine.Transform 所在UI层级
local BasePanel = class("UI.BasePanel", LuaObj)
function BasePanel:Ctor(cfg, layer)
    self.cfg = cfg
    self.layer = layer or UIMgr.UILayer.panel
    BasePanel.super.Ctor(self, cfg.prefabPath, nil, self.layer)
    self:OnInitialize()
end

function BasePanel:OnInitialize()
    local BtnClose = self.transform:Find("BtnClose")
    if BtnClose ~= nil then
        self.BtnClose = BtnClose.gameObject
        AddButtonHandler(self.BtnClose, PointerHandler.CLICK, self.Close, self)
    end
end

---移除事件监听
function BasePanel:RemoveListeners()
    RemoveButtonHandler(self.BtnClose, PointerHandler.CLICK, self.Close, self)
end

function BasePanel:Close()
    UIMgr.ClosePanel(self.cfg)
end

function BasePanel:OnDestroy()
    BasePanel.super.OnDestroy(self)
    self:RemoveListeners()
    UIMgr.CheckPanelClean(self.cfg)
end

return BasePanel