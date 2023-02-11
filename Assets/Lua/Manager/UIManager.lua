---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/2 17:51
--- UI管理器
local UIMgr = {}

---UI层级容器
local layer = {} ---@type table<string, UnityEngine.Transform>

---初始化UI层级
---@param UICanvas UnityEngine.Transform
function UIMgr.InitLayer(UICanvas)
    layer[UILayerName.scene] = UICanvas.transform:Find(UILayerName.scene)
    layer[UILayerName.UI] = UICanvas.transform:Find(UILayerName.UI)
    layer[UILayerName.panel] = UICanvas.transform:Find(UILayerName.panel)
    layer[UILayerName.UITop] = UICanvas.transform:Find(UILayerName.UITop)
    layer[UILayerName.alert] = UICanvas.transform:Find(UILayerName.alert)
    layer[UILayerName.guide] = UICanvas.transform:Find(UILayerName.guide)
    layer[UILayerName.top] = UICanvas.transform:Find(UILayerName.top)
end

---获取UI层级
function UIMgr.GetLayer(name)
    return layer[name]
end

---panel容器
local panelContainer = {} ---@type table<string, UI.BasePanel>

---打开页面
---@param cfg panelConfig 页面配置
---@vararg any 传入页面的参数
function UIMgr.OpenPanel(cfg, ...)
    if cfg == nil then
        LogError("OpenPanel 页面配置为空")
        return
    end
    local classPath = cfg.classPath
    if classPath == nil then
        LogError("OpenPanel 没有配置classPath")
        return
    end
    if panelContainer[classPath] ~= nil then
        LogWarning(classPath.." 此页面已经打开")
        return
    end
    local class = require(classPath) ---@type UI.BasePanel
    if class == nil then
        return
    end
    local panel = class.New(cfg, ...)
    panelContainer[classPath] = panel
end

---获取页面
---@param cfg panelConfig 页面配置
---@return UI.BasePanel
function UIMgr.GetPanel(cfg)
    if cfg == nil then
        LogError("GetPanel 页面配置为空")
        return
    end
    local classPath = cfg.classPath
    if cfg.classPath == nil then
        LogError("GetPanel 没有配置classPath")
        return
    end
    return panelContainer[classPath]

end

---关闭界面
---@param cfg panelConfig 页面配置
function UIMgr.ClosePanel(cfg)
    local panel = UIMgr.GetPanel(cfg)
    if panel then
        if isnull(panel.gameObject) then
            LogWarning("ClosePanel 界面的gameObject为null")
        else
            panel.gameObject:Destroy()
        end
        panel = nil
        panelContainer[cfg.classPath] = nil
    else
        LogWarning(cfg.classPath.." 此页面未打开")
    end
end

---检查页面引用是否清除
---@param cfg panelConfig 页面配置
function UIMgr.CheckPanelClean(cfg)
    local panel = UIMgr.GetPanel(cfg)
    if panel then
        panel = nil
        panelContainer[cfg.classPath] = nil
    end
end

return UIMgr