---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by sunshuo.
--- DateTime: 2023/2/3 15:13
--- UI界面相关配置

---UI层级名称
UILayerName = {}
UILayerName.scene = "Scene"
UILayerName.ui = "UI"
UILayerName.panel = "Panel"
UILayerName.uiTop = "UITop"
UILayerName.alert = "Alert"
UILayerName.guide = "Guide"
UILayerName.top = "Top"

---@class panelConfig UI页面配置
---@field classPath string 页面类的路径
---@field prefabPath string prefab路径
---@field layer string 页面层级 默认为panel
---@field aniEffect boolean 是否需要页面打开关闭动效 默认为true

UIPanelCfg = {} ---@type table<string, panelConfig>
UIPanelCfg.mainMenu = {classPath = "Modules.UI.MainMenu.MainMenuPanel", prefabPath = "Prefabs/Panel/MainMenu/MainMenu.prefab", aniEffect = false}
UIPanelCfg.growUp = {classPath = "Modules.UI.GrowUp.GrowUpPanel", prefabPath = "Prefabs/Panel/GrowUp/GrowUpPanel.prefab"}
UIPanelCfg.rewardAlert = {classPath = "Modules.UI.Reward.RewardAlertPanel", prefabPath = "Prefabs/Panel/Common/RewardAlertPanel.prefab", layer = UILayerName.alert}