---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2023/2/14 10:49
--- 角色说话
---@class Talk:LuaObj
local Talk = class("Talk", LuaObj)

---@param featureInfo TalkerInfo 详见 TalkerConfig
---@param contentList table 说话内容列表
---@param callBack function 完毕回调
---@param beforeTalkCall function fun(goOnFun, index)每段文本前回调
---@param afterTalkCall function fun(goOnFun, index)每段文本后回调
function Talk.Play(featureInfo, contentList, callBack, beforeTalkCall, afterTalkCall)
    if not Talk.instance then
        Talk.instance = Talk.New() ---@type Talk
    end
    --print("Talk.Show",Talk.instance.gameObject)
    Talk.instance:Show(featureInfo, contentList, callBack, beforeTalkCall, afterTalkCall)
end

---震动效果
Talk.SHAKE_EFF_FUN = function(playFun)
    --playFun()
    Happy.Shake(Talk.instance.featureC,1, playFun, 0.5)
end

function Talk:Ctor()

    Talk.super.Ctor(self, "Prefabs/Common/Talk.prefab", nil, UIMgr.GetLayer(UILayerName.guide))

    self.nameLabel = GetComponent.Text(self.transform:Find("Bg/nameText").gameObject)
    self.contentLabel = GetComponent.Text(self.transform:Find("Bg/contentText").gameObject)
    self.nameLabel.text = ""
    self.contentLabel.text = ""
    self.featureC = self.transform:Find("featureC")
    self.lightFor3DGo = self.transform:Find("LightFor3D").gameObject
    self.arrow = self.transform:Find("Bg/arrow").gameObject

    self.waitingForClick = false
    AddButtonHandler(self.gameObject, PointerHandler.CLICK, handler(self, self.ClickHandler))
    Talk.instance = self
end

function Talk:ClickHandler()
    if self.waitingForClick == true then
        if self.afterTalkCall then
            self.afterTalkCall(handler(self, self.PlayContent), self.playContentIdx)
        else
            self:PlayContent()
        end
    elseif self.textTween then
        self.textTween.timeScale = 100
        DelayedFrameCall(function()
            if self.textTween then
                self.textTween.timeScale = 1
            end
        end)
    end
end

local UILayer = LayerMask.NameToLayer("UI")
---@param featureInfo TalkerInfo
function Talk:Show(featureInfo, contentList, callBack, beforeTalkCall, afterTalkCall)
    Talk.super.Show(self)
    if self:CheckFeatureNoChange() == true then
        return
    end
    self:ClearFeatures()
    self.featureInfo = featureInfo
    self.contentList = contentList
    self.callBack = callBack
    self.beforeTalkCall = beforeTalkCall
    self.afterTalkCall = afterTalkCall
    self.use3d = featureInfo.use3d

    self.lightFor3DGo:SetActive(self.use3d)
    self.nameLabel.text = featureInfo.name
    for i = 1, #featureInfo.featureList do
        local props = featureInfo.featureList[i] ---@type TalkerProp
        ---3D模型
        if self.use3d == true then
            local featureGo = CreatePrefab(props.path, self.featureC)
            props.oldScale = featureGo.transform.localScale
            featureGo.name = "feature"..i
            props.oldLayer = featureGo.layer
            HappyFuns.SetLayerRecursive(featureGo, UILayer)
            for propName, propValue in pairs(props.transformProps) do
                featureGo.transform[propName] = propValue
            end
        ---2D图片
        else
            local imgGo = GameObject.New() ---@type UnityEngine.GameObject
            imgGo.name = "feature"..i
            local img = AddOrGetComponent(imgGo, UnityEngine.UI.Image) ---@type UnityEngine.UI.Image
            img.sprite = resMgr:LoadSpriteAtPath(props.path)
            img:SetNativeSize()
            local imgRect = AddOrGetComponent(imgGo, UnityEngine.RectTransform) ---@type UnityEngine.RectTransform
            imgRect:SetParent(self.featureC)
            imgRect.localPosition = Vector3.zero
            imgRect.localEulerAngles = Vector3.zero
            imgRect.localScale = Vector3.one
            HappyFuns.SetLayerRecursive(imgGo, UILayer)
            for propName, propValue in pairs(props.transformProps) do
                imgRect[propName] = propValue
            end
        end
    end

    self.playContentIdx = 0
    self:PlayContent()
end

---播放文本内容
function Talk:PlayContent()
    self.arrow:SetActive(false)
    self.waitingForClick = false
    self.playContentIdx = self.playContentIdx + 1
    if #self.contentList < self.playContentIdx then
        self:Hide()
        self:ClearFeatures()
        if self.callBack then
            local call = self.callBack
            self.callBack = nil
            call()
        end
        return
    end
    local playFun = function()
        self.contentLabel.text = ""
        local content = self.contentList[self.playContentIdx]
        self.textTween = self.contentLabel:DOText(content, string.len(content)/30):SetEase(DOTWEEN_EASE.Linear):OnComplete(function()
            self.arrow:SetActive(true)
            self.textTween = nil
            self.waitingForClick = true
        end) ---@type DG.Tweening.Core.TweenerCore
    end
    if self.beforeTalkCall then
        self.beforeTalkCall(playFun, self.playContentIdx)
    else
        playFun()
    end
end

---清理现有的形象们
function Talk:ClearFeatures()
    local i = 1
    while(self.featureC.childCount > 0) do
        local featureGo = self.featureC:GetChild(0).gameObject
        if self.use3d == true then
            local props = self.featureInfo.featureList[i] ---@type TalkerProp
            RecyclePrefab(featureGo, props.path)
            HappyFuns.SetLayerRecursive(featureGo, props.oldLayer)
            --print("你妹啊~", featureGo.transform.parent.name, props.oldScale.x, props.oldScale.y, props.oldScale.z)
            featureGo.transform.localScale = props.oldScale
            i = i + 1
        else
            DestroyImmediate(featureGo)
        end
    end
end

---验证Feature数据是不是没变
function Talk:CheckFeatureNoChange()

end

return Talk