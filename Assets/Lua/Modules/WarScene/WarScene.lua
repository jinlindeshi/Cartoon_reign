---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/11/18 9:39
--- 战场场景

local WarAvatar = require("Modules.WarScene.View.WarAvatar")
local FocusAvatar = require("Modules.WarScene.View.FocusAvatar")
local LuaScene = require("Prayer.Core.LuaScene")
local WarData = require("Modules.WarScene.Model.WarData")
local SData = require("Modules.WarScene.Model.SData")
local AvatarData = require("Modules.WarScene.Model.AvatarData")


---@class WarScene:LuaScene
local WarScene = class("WarScene", LuaScene)

function WarScene:Ctor(scene)
    --print("WarScene:Ctor", scene)
    WarScene.super.Ctor(self, scene)
    WarData.scene = self

    LuaHelper.AddCameraToStackList(self.mainCamera, GetComponent.Canvas(Game.UICanvas).worldCamera, true)

    self.avatarLoc = {}
    WarData.gridGraph = AstarPath.active.graphs[0] ---@type Pathfinding.GridGraph
    --AstarPath.active.logPathResults = Pathfinding.PathLog.Normal
    AstarPath.active.logPathResults = Pathfinding.PathLog.None

    ---编辑器模式下生成坐标展示
    --if Application.isEditor == true then
    --    self:GenerateGrids()
    --    self.locContainer:SetActive(false) ---默认是否显示格子
    --end
    self.happyCam = GetComponent.HappyCamera(Camera.main.gameObject)

    self.avatarConTran = self:GetRootObjByName("AvatarCon").transform
    self.avatarList = {} --角色列表
    self:TestFocusAvatar()
    UIMgr.OpenPanel(UIPanelCfg.mainMenu)

    --DelayedCall(1, function()
    --    Happy.MainCameraBlurToggle(true, 1)
    --    DelayedCall(4, function()
    --        Happy.MainCameraBlurToggle(false, 1)
    --    end)
    --end)
    --DelayedCall(1, function()
    --    Talk.Play(TalkerConfig.Bear, {"我是杀不完的"
    --    ,"一波一波无穷尽"}, function()
    --        Talk.Play(TalkerConfig.Me2D, {"跟你拼啦！"}, function()
    --            print("播放完毕~")
    --        end)
    --    end)
    --end)

    --DelayedCall(1, function()
    --    Happy.ScreenTrans(nil,nil,nil,nil,nil, Color.red, "dsafa fasdsa ewqrdasd")
    --end)
end

---TEST 测试相机跟随Avatar
function WarScene:TestFocusAvatar()
    self:AddAvatar(DemoCfg.mainAvatarID, true, nil, 1).skill = require("Modules.WarScene.Controller.Skill.SkillWhirlwind").New()
    self:AddAvatar(DemoCfg.followerID, false, nil, 1):SetRangedAttackInfo(2)
end
---TEST

local testBossData = {atk = 75, def = 0, hp = 2000, maxHp = 2000, name = "金刚熊",
                      prefab = "Prefabs/Avatars/monster_xiong.prefab", side = 2}
---挑战BOSS
function WarScene:ChallengeBoss()
    --print("WarScene:ChallengeBoss 挑战BOSS")
    WarData.bossFighting = true
    WarData.StopAllAvatarAI()

    ---@param avatar WarAvatar
    for id, avatar in pairs(WarData.AvatarHash) do
        if avatar.data.side ~= WarData.mainAvatar.data.side then
            DelayedFrameCall(function()
                WarData.RemoveAvatar(avatar)
            end)
        else
            avatar:SetMoveSpeedScale(3)
        end
    end

    WarData.avatarIdIndex = WarData.avatarIdIndex + 1
    testBossData.id = WarData.avatarIdIndex
    local avatar = WarAvatar.New(testBossData.prefab,
            testBossData, false, WarData.scene.avatarConTran)
    avatar:SetExternalBehavior("BehaviorTree/EnemyAI.asset")
    WarData.AddAvatar(avatar, avatar.data)
    WarData.scene:PutInNode(avatar, WarData.bossNode[1], WarData.bossNode[2])
    avatar.transform.localScale = avatar.transform.localScale * 1.5
    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)

    DelayedCall(2, function()
        WarData.StartAllAvatarAI()
    end)
end

---@param id number 角色ID
---@param isMainRole boolean 是否是主要角色
---@param bornLoc table 指定出生格子坐标
---@param delayAITime number 延迟AI开启的时间 默认不延迟
---@return WarAvatar
function WarScene:AddAvatar(id, isMainRole, bornLoc, delayAITime)
    local myData = clone(SData.avatar.GetData(id))
    local attr = AvatarData.GetHeroAttr(id)
    myData.hp = attr.maxHp
    myData.maxHp = attr.maxHp
    myData.atk = attr.atk
    myData.def = attr.def
    local avatar---@type WarAvatar
    if isMainRole then
        avatar = FocusAvatar.New(myData.prefab, myData, self.avatarConTran)
        WarData.mainAvatar = avatar
        self.happyCam:SetAttachObj(avatar.gameObject)
        avatar:SetExternalBehavior("BehaviorTree/MeAI.asset")
    else
        avatar = WarAvatar.New(myData.prefab, myData, false, self.avatarConTran)
        avatar:SetLeader(WarData.mainAvatar)
        avatar:SetExternalBehavior("BehaviorTree/Follower.asset")
    end
    WarData.AddAvatar(avatar, avatar.data)
    AvatarData.AddHeroData(id)
    WarData.TeamAddAvatar(avatar)
    local loc = bornLoc or WarData.bornNodes[-id]
    self:PutInNode(avatar, loc[1], loc[2])
    local bornFx = CreatePrefab("Effect/Prefabs/fx_Itemborn.prefab")
    bornFx.transform.localScale = Vector3.New(0.8,0.8,0.8)
    bornFx.transform.position = avatar.transform.position
    DelayedCall(1, function()
        RecyclePrefab(bornFx, "Effect/Prefabs/fx_Itemborn.prefab")
    end)
    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)
    if delayAITime then
        DelayedCall(delayAITime, function() avatar:AIStart() end)
    else
        avatar:AIStart()
    end
    return avatar
end

---添加新角色进入队伍
function WarScene:TeamAddAvatar(id)
    if WarData.mainAvatar == nil then
        LogError("TeamAddAvatar 没有找到主角色 无法添加新角色进入队伍")
        return
    end
    local nowGrid = WarData.gridGraph:GetNearest(WarData.mainAvatar.transform.position, Pathfinding.NNConstraint.None).node
    local grids = WarData.GetAroundGrids(nowGrid.XCoordinateInGrid, nowGrid.ZCoordinateInGrid, 2) --主角两格距离内格子
    local targetList = {}
    local remainList = {}
    for x, tb in pairs(grids) do
        for z, v in pairs(tb) do
            local grid = WarData.gridGraph:GetNode(x,z)
            local pos = SeekerToLua.IntToVector(grid.position)
            local dot = Vector3.Dot(WarData.mainAvatar.transform.forward, pos)
            if dot < 0 then
                --在主角后方的格子
                table.insert(targetList, {x,z,dot})
            else
                table.insert(remainList, {x,z,dot})
            end
        end
    end
    local loc
    if next(targetList) ~= nil then --优先选择在主角后面的位置
        table.sort(targetList, function(a, b) return a[3] < b[3] end)
        loc = targetList[1]
    elseif next(remainList) ~= nil then
        table.sort(remainList, function(a, b) return a[3] > b[3] end)
        loc = remainList[1]
    else
        LogError("TeamAddAvatar 没有找到合适的出生位置 出生在默认出生点")
    end
    self:AddAvatar(id, false, loc)
end

---从队伍中移除角色
function WarScene:TeamRemoveAvatar(id)
    if WarData.avatarTeam[id] == nil then
        return
    end
    local avatar = WarData.avatarTeam[id]
    avatar:AIStop()
    avatar:Recycle()
    WarData.RemoveAvatar(avatar, false)
    WarData.TeamRemoveAvatar(avatar)
end

---@param avatar WarAvatar
function WarScene:PutInNode(avatar, x, z, obstacle, radius)
    radius = radius or 0
    local grid = WarData.gridGraph:GetNode(x,z)
    avatar:SetLoc(x,z)
    local pos = SeekerToLua.IntToVector(grid.position)

    --print("WarScene:PutInNode", pos.x, pos.y, pos.z)
    avatar.transform.position = Vector3.New(pos.x, pos.y + 0.01, pos.z)
    if obstacle == true then
        local moreGrids = WarData.GetAroundGrids(x,z,radius)
        for moreX, moreZs in pairs(moreGrids) do
            for moreZ, hehe in pairs(moreZs) do
                --print("WarScene:PutInNode", moreX, moreZ)
                local moreGrid = WarData.gridGraph:GetNode(moreX,moreZ)
                moreGrid.Walkable = false
            end
        end
    end
    if not self.avatarLoc[x] then
        self.avatarLoc[x] = {}
    end
    self.avatarLoc[x][z] = avatar
end

function WarScene:GenerateGrids()

    self.locContainer = self:GetRootObjByName("LocContainer") ---@type UnityEngine.GameObject

    local gridsWidth = WarData.gridGraph.width
    local gridsDepth = WarData.gridGraph.depth
    self.gridHash = {}
    for x = 0, gridsWidth-1 do
        for z = 0, gridsDepth-1 do
            local node = WarData.gridGraph:GetNode(x, z) ---@type Pathfinding.GridNode
            if node.Walkable == true then
                local grid = CreatePrefab("Prefabs/War/LocText.prefab", self.locContainer.transform)

                if not self.gridHash[x] then
                    self.gridHash[x] = {}
                end
                self.gridHash[x][z] = grid
                grid.transform.localPosition = SeekerToLua.IntToVector(node.position)
                local tm = GetComponent.TextMesh(grid)
                tm.text = ""..node.XCoordinateInGrid..","..node.ZCoordinateInGrid
                tm.fontSize = 30
                tm.characterSize = 0.1
                grid.name = tm.text
            end
        end
    end
end

return WarScene