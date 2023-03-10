---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/5/13 3:01 PM
--- 开心点

Happy = {}

Happy.DOTWEEN_EASE = DG.Tweening.Ease ---@type DG.Tweening.Ease
Happy.DOTWEEN_LOOP_TYPE = DG.Tweening.LoopType ---@type DG.Tweening.LoopType

---处理对象下面所有指定type的材质球
function Happy.DoWithMaterials(gameObj, fun, type)
    type = type or UnityEngine.Renderer
    local smList = gameObj:GetComponentsInChildren(typeof(type))
    for i = 0, smList.Length-1 do
        local sm = smList[i] ---@type UnityEngine.Renderer
        for j = 0, sm.materials.Length-1 do
            local m = sm.materials[j] ---@type UnityEngine.Material
            fun(m)
        end
    end
end


---浮点数缓动
---@return DG.Tweening.DOTween
function Happy.DOTweenFloat(startValue, endValue, duration, setFloatFun, callBack, ease)
    local value = startValue
    local function getFunc()
        return value
    end
    local function setFunc(floatValue)
        setFloatFun(floatValue)
        value = floatValue
    end
    local getter = DG.Tweening.Core.DOGetter_float(getFunc)
    local setter = DG.Tweening.Core.DOSetter_float(setFunc)
    ease = ease or Happy.DOTWEEN_EASE.Linear
    local DOTween = DG.Tweening.DOTween ---@type DG.Tweening.DOTween
    return DOTween.To(getter, setter, endValue, duration):SetEase(ease):OnComplete(function ()
        if callBack then
            callBack(value)
        end
    end)
end

---世界坐标转化为UI层AnchorPosition
---@param rectParent UnityEngine.RectTransform
---@return Vector2
function Happy.WorldPointToRectTransform(worldP, rectParent)
    local screenP = Camera.main:WorldToScreenPoint(worldP)
    local hehe, p = RectTransformUtility.ScreenPointToLocalPointInRectangle(rectParent,
            screenP, nil, Vector2.zero)
    return p
end

---主相机模糊开关
---@param enabled boolean
---@param dynamic boolean 是否动态每帧都截图
---@param range boolean 模糊强度
function Happy.MainCameraBlurToggle(enabled, dynamic, range)
    dynamic = dynamic or true
    range = range or 2
    if not Happy.blurImg then
        local obj = GameObject.New() ---@type UnityEngine.GameObject
        obj.transform:SetParent(Game.UICanvas.transform)
        local rect = AddOrGetComponent(obj, UnityEngine.RectTransform) ---@type UnityEngine.RectTransform
        rect.anchoredPosition3D = Vector3.zero
        rect.localScale = Vector3.one
        rect.localEulerAngles = Vector3.zero
        Happy.blurImg = AddOrGetComponent(obj, UnityEngine.UI.RawImage) ---@type UnityEngine.UI.RawImage
        --Happy.blurImg.
    end
    LuaHelper.DrawBlurTextureToggle(enabled)
end

Happy.btnEffObjs = {}
---带默认效果的点击交互
---@param gameObj UnityEngine.GameObject
function Happy.BtnClickDownUP(gameObj, UpCallback, DownCallback, noEff, setScale)
    Happy.ClearBtnClick(gameObj)
    local initScale = gameObj.transform.localScale.x
    local DownL = function()
        if not noEff then
            gameObj.transform:DOScale(initScale * (setScale or 0.9), 0.05)
        end
        if DownCallback then
            DownCallback()
        end
    end
    AddButtonHandler(gameObj, PointerHandler.DOWN, DownL)
    local UpL = function()
        if not noEff then
            gameObj.transform:DOScale(initScale, 0.05)
        end
        if UpCallback then
            UpCallback()
        end
    end
    AddButtonHandler(gameObj, PointerHandler.CLICK, UpL)
    local ExitL = function()
        if not noEff then
            gameObj.transform:DOScale(initScale, 0.05)
        end
    end
    AddButtonHandler(gameObj, PointerHandler.EXIT, ExitL)
    AddButtonHandler(gameObj, PointerHandler.UP, ExitL)

    local DestryL = function()
        Happy.ClearBtnClick(gameObj)
    end
    AddEventListener(gameObj, Event.ON_DESTROY, DestryL)

    Happy.btnEffObjs[gameObj] = {DownL, UpL, ExitL, DestryL}
end

---清除点击交互
---@param gameObj UnityEngine.GameObject
function Happy.ClearBtnClick(gameObj)
    if not Happy.btnEffObjs[gameObj] then
        return
    end
    local DownL = Happy.btnEffObjs[gameObj][1]
    local UpL = Happy.btnEffObjs[gameObj][2]
    local ExitL = Happy.btnEffObjs[gameObj][3]
    local DestryL = Happy.btnEffObjs[gameObj][4]
    RemoveButtonHandler(gameObj, PointerHandler.DOWN, DownL)
    RemoveButtonHandler(gameObj, PointerHandler.CLICK, UpL)
    RemoveButtonHandler(gameObj, PointerHandler.EXIT, ExitL)
    RemoveButtonHandler(gameObj, PointerHandler.UP, ExitL)
    RemoveEventListener(gameObj, Event.ON_DESTROY, DestryL)
end

---获取UI灰色材质球
function Happy.GetGrayMat()
    return resMgr:LoadMaterialAtPath("Materials/UI/gray2D.mat")
end