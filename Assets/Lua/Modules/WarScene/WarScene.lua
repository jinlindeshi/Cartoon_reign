---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by likai.
--- DateTime: 2021/11/18 9:39
--- 战场场景

local WarAvatar = require("Modules.WarScene.View.WarAvatar")
local FocusAvatar = require("Modules.WarScene.View.FocusAvatar")
local LuaScene = require("Prayer.Core.LuaScene")
local WarData = require("Modules.WarScene.Model.WarData")
local WarUI = require("Modules.WarScene.View.UI.WarUI")
local SData = require("Modules.WarScene.Model.SData")
local AvatarData = require("Modules.WarScene.Model.AvatarData")


---@class WarScene:LuaScene
local WarScene = class("WarScene", LuaScene)

function WarScene:Ctor(scene)
    --print("WarScene:Ctor", scene)
    WarScene.super.Ctor(self, scene)
    WarData.scene = self
    self.avatarLoc = {}
    WarData.gridGraph = AstarPath.active.graphs[0] ---@type Pathfinding.GridGraph
    --AstarPath.active.logPathResults = Pathfinding.PathLog.Normal
    AstarPath.active.logPathResults = Pathfinding.PathLog.None

    self:GenerateGrids()
    self.locContainer:SetActive(false) ---默认是否显示格子
    WarUI.New(function()
        self.locContainer:SetActive(not self.locContainer.activeSelf)
    end)
    self.happyCam = GetComponent.HappyCamera(Camera.main.gameObject)

    self.avatarConTran = self:GetRootObjByName("AvatarCon").transform

    --self:TestGuardTower()
    self:TestFocusAvatar()
    UIMgr.OpenPanel(UIPanelCfg.mainMenu)
end

---TEST 测试相机跟随Avatar
function WarScene:TestFocusAvatar()
    --local me
    --for i = 1, #SData.myArmyList do
    --    local myData = clone(SData.myArmyList[i])
    --    local avatar = FocusAvatar.New(myData.prefab, myData.data, self.avatarConTran)
    --    WarData.AddAvatar(avatar, avatar.data)
    --    local loc = WarData.bornNodes[i]
    --    self:PutInNode(avatar, loc[1], loc[2])
    --    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)
    --    if i == 1 then
    --        me = avatar
    --        self.happyCam:SetAttachObj(me.gameObject)
    --        avatar:SetExternalBehavior("BehaviorTree/MeAI.asset")
    --    else
    --        avatar:SetLeader(me)
    --        avatar:SetExternalBehavior("BehaviorTree/Follower.asset")
    --    end
    --    avatar:AIStart()
    --end

    local myData = clone(SData.GetAvatarSData(DemoCfg.mainAvatarID))
    local attr = AvatarData.GetHeroAttr(DemoCfg.mainAvatarID)
    myData.hp = attr.maxHp
    myData.maxHp = attr.maxHp
    myData.atk = attr.atk
    myData.def = attr.def
    local avatar = FocusAvatar.New(myData.prefab, myData, self.avatarConTran)
    WarData.AddAvatar(avatar, avatar.data)
    WarData.mainAvatar = avatar
    local loc = WarData.bornNodes[-DemoCfg.mainAvatarID]
    self:PutInNode(avatar, loc[1], loc[2])
    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)
    self.happyCam:SetAttachObj(avatar.gameObject)
    avatar:SetExternalBehavior("BehaviorTree/MeAI.asset")
    avatar:AIStart()


    local followerData = clone(SData.GetAvatarSData(DemoCfg.followerID))
    followerData.hp = followerData.maxHp
    local avatar = WarAvatar.New(followerData.prefab, followerData, false, self.avatarConTran)
    WarData.AddAvatar(avatar, avatar.data)
    local loc = WarData.bornNodes[-DemoCfg.followerID]
    self:PutInNode(avatar, loc[1], loc[2])
    HappyFuns.SetLayerRecursive(avatar.gameObject, 11)
    avatar:SetLeader(WarData.mainAvatar)
    avatar:SetExternalBehavior("BehaviorTree/Follower.asset")
    avatar:AIStart()
end
---TEST

---TEST 测试防御塔
function WarScene:TestGuardTower()

    local enemy = WarAvatar.New("Prefabs/Avatars/Crystal.prefab", {id=-1, hp=300, maxHp=300, side=2}, true)
    enemy:SetExternalBehavior("BehaviorTree/GuardTowerAI.asset")
    WarData.AddAvatar(enemy, enemy.data)
    self:PutInNode(enemy, 45, 68, nil, 1)
    enemy:SetRangedAttackInfo("Effects/Prefabs/IceTrail.prefab",
            "Effects/Prefabs/IceHit.prefab", 4)
    enemy:AIStart()



    self.terrain = self:GetRootObjByName("Terrain")
    AddButtonHandler(self.terrain, PointerHandler.DOUBLE_CLICK, function (eventData)
        local ray = Camera.main:ScreenPointToRay(eventData.position)
        local success, hit = Physics.Raycast(ray, UnityEngine.RaycastHit.out,
                100,  HappyFuns.GetLayerMask(8))

        local info = WarData.gridGraph:GetNearest(hit.point, Pathfinding.NNConstraint.None)
        local gridNode = info.node ---@type Pathfinding.GridNode
        --print("木哈哈", gridNode.XCoordinateInGrid, gridNode.ZCoordinateInGrid)
        WarData.avatarIdIndex = WarData.avatarIdIndex + 1
        local avatar = WarAvatar.New("Prefabs/Avatars/TestZombie.prefab",
                {id=WarData.avatarIdIndex, hp=60, maxHp=60, side=1}, false)
        avatar:SetExternalBehavior("BehaviorTree/EnemyAI.asset")
        WarData.AddAvatar(avatar, avatar.data)
        self:PutInNode(avatar, gridNode.XCoordinateInGrid, gridNode.ZCoordinateInGrid)
        avatar.transform.localScale = Vector3.one
        HappyFuns.SetLayerRecursive(avatar.gameObject, 11)
        avatar:AIStart()

    end)
end
---TEST

---@param avatar WarAvatar
function WarScene:PutInNode(avatar, x, z, obstacle, radius)
    radius = radius or 0
    local grid = WarData.gridGraph:GetNode(x,z)
    avatar:SetLoc(x,z)
    local pos = SeekerToLua.IntToVector(grid.position)

    --print("WarScene:PutInNode", pos.x, pos.y, pos.z)
    avatar.transform.position = Vector3.New(pos.x, pos.y + 0.01, pos.z)
    if obstacle == true then
        WarData.AddAvatarLoc(x,z)
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