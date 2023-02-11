---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 10:34
--- panel基类
---@class UI.BasePanel
---@field New fun():UI.BasePanel
---@field cfg panelConfig 页面配置
---@vararg any 构造参数
---@field prefabPath string prefab文件路径
---@field layer UnityEngine.Transform 所在涂层
local BasePanel = class("UI.BasePanel")
function BasePanel:Ctor(cfg, ...)
    self.cfg = cfg
    self.prefabPath = cfg.prefabPath
    self.layer = UIMgr.GetLayer(cfg.layer or UILayerName.panel)
    self.gameObject = CreatePrefab(self.prefabPath, self.layer)
    self.transform = self.gameObject.transform ---@type UnityEngine.Transform

    ---gameObject销毁事件监听
    self.component = AddOrGetComponent(self.gameObject, Prayer.OnDestroyHandler) ---@type Prayer.OnDestroyHandler
    self.component.checkCall = function()
        if self.OnDestroy then
            self:OnDestroy()
        end
    end

    self:Init(...)
    if self.cfg.aniEffect == false then
        ---不需要动效 直接执行OnInit
        self:OnInit()
    else
        ---需要动效
        self:_initAniEffect()
        self:_playOpenAni()
        self._openAniSeq:AppendCallback(function()
            self:OnInit()
        end)
    end
end

---页面初始化
---播放页面打开动画之前
function BasePanel:Init()
end

---页面初始化
---播放页面打开动画之后
function BasePanel:OnInit()
    ---自动添加关闭界面点击事件
    local BtnClose = self.transform:Find("BtnClose")
    if BtnClose ~= nil then
        self.BtnClose = BtnClose.gameObject
        AddButtonHandler(self.BtnClose, PointerHandler.CLICK, self.Close, self)
    end
end

---页面动效初始化
function BasePanel:_initAniEffect()
    self._cg = AddOrGetComponent(self.gameObject, UnityEngine.CanvasGroup) ---@type UnityEngine.CanvasGroup
    self._openAniSeq = DOTween.Sequence()
end

---播放页面打开动画
function BasePanel:_playOpenAni()
    if self._openAniSeq == nil then
        return
    end
    self._cg.alpha = 0
    self.transform.localScale = Vector2.New(0.8,0.8)
    self._openAniSeq:Append(self._cg:DOFade(1, 0.25))
    self._openAniSeq:Join(self.transform:DOScale(1,0.25))
end

---播放页面关闭动画
function BasePanel:_playCloseAni()
    if self._closeAniSeq == nil then
        return
    end
    self._closeAniSeq:Append(self._cg:DOFade(0, 0.25))
    self._closeAniSeq:Join(self.transform:DOScale(0.8,0.25))
end

---移除事件监听
function BasePanel:RemoveListeners()
    RemoveButtonHandler(self.BtnClose, PointerHandler.CLICK, self.Close, self)
end

---关闭页面
function BasePanel:Close()
    if self.cfg.aniEffect == false then
        UIMgr.ClosePanel(self.cfg)
    else
        self._closeAniSeq = DOTween.Sequence()
        self:_playCloseAni()
        self._closeAniSeq:AppendCallback(function()
            UIMgr.ClosePanel(self.cfg)
        end)
    end
end

---页面销毁时
function BasePanel:OnDestroy()
    self:RemoveListeners()
    if self._openAniSeq then
        self._openAniSeq:Kill(false)
        self._openAniSeq = nil
    end
    if self._closeAniSeq then
        self._closeAniSeq:Kill(false)
        self._closeAniSeq = nil
    end
    UIMgr.CheckPanelClean(self.cfg)
end

return BasePanel